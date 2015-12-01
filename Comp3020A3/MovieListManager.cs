﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class MovieListManager
    {
        public static List<FormError> createMovieList(string lname, string username)
        {
            List<FormError> errors = new List<FormError>();

            MovieList ml = new MovieList() { ID = DataAccess.generateID(), name = lname, user = username };

            if (ml.valid(errors))
            {
                List<MovieList> mls = DataAccess.readMovieLists();
                mls.Add(ml);
                DataAccess.writeMovieLists(mls);
            }

            return errors;
        }

        public static bool addToMovieList(long ID, string movie)
        {
            List<MovieList> ml = DataAccess.readMovieLists();

            int i = 0;

            while (i < ml.Count && ID != ml.ElementAt(i).ID)
            {
                i++;
            }

            if (i < ml.Count && !ml.ElementAt(i).contains(movie))
            {
                ml.ElementAt(i).movies.Add(movie);
                DataAccess.writeMovieLists(ml);

                return true;
            }

            return false;
        }

        public static bool removeFromMovieList(long ID, string movie)
        {
            List<MovieList> ml = DataAccess.readMovieLists();

        int i = 0;

            while (i<ml.Count && ID != ml.ElementAt(i).ID)
            {
                i++;
            }

            if (i < ml.Count)
            {
                if(ml.ElementAt(i).removeMovie(movie))
                {
                    DataAccess.writeMovieLists(ml);
                }

                return true;
            }

            return false;
        }

        public static List<MovieList> getMovieLists(string username)
        {
            List<MovieList> mls = DataAccess.readMovieLists();

            int i = mls.Count - 1;

            while (i >= 0)
            {
                if (!mls.ElementAt(i).user.Equals(username))
                {
                    mls.RemoveAt(i);
                }
                i--;
            }

            return mls;
        }

        public static MovieList getMovieList(long ID)
        {
            List<MovieList> mls = DataAccess.readMovieLists();

            int i = 0;

            while (i < mls.Count && mls.ElementAt(i).ID != ID)
            {
                i++;
            }

            if(i < mls.Count)
            {
                return mls.ElementAt(i);
            }

            return null;
        }

        public static bool destroyMovieList(long ID)
        {
            List<MovieList> ml = DataAccess.readMovieLists();
            int i = 0;
            bool removed = false;

            while (i < ml.Count && !removed)
            {
                if (ml.ElementAt(i).ID == ID)
                {
                    ml.RemoveAt(i);
                    removed = true;
                    DataAccess.writeMovieLists(ml);
                }

                i++;
            }

            return removed;
        }

        public static bool changeListName(long ID, string name, List<FormError> errors)
        {
            List<MovieList> ml = DataAccess.readMovieLists();
            int i = 0;

            while(i < ml.Count && ml.ElementAt(i).ID != ID)
            {
                i++;
            }

            if(i < ml.Count)
            {
                ml.ElementAt(i).name = name;

                if(ml.ElementAt(i).valid(errors))
                {
                    DataAccess.writeMovieLists(ml);
                    return true;
                }
            }

            return false;
        }

        public static bool saveMovieList(MovieList list)
        {
            List<MovieList> lists = DataAccess.readMovieLists();
            int i = 0;

            while(i < lists.Count && lists[i].ID != list.ID)
            {
                i++;
            }

            if(i < lists.Count)
            {
                lists[i].movies = list.movies;
                DataAccess.writeMovieLists(lists);
            }

            return false;
        }

        public static void updateListOrder(User user, List<MovieList> lists)
        {
            List<MovieList> mls = DataAccess.readMovieLists();
            int i;

            foreach (MovieList list in lists)
            {
                i = 0;
                while (i < mls.Count && mls[i].ID != list.ID)
                {
                    i++;
                }

                if(i < mls.Count)
                {
                    mls.RemoveAt(i);
                    mls.Add(list);
                }
            }

            DataAccess.writeMovieLists(mls);
        }

        public static void updateListOrder(long ID, List<Movie> movies)
        {
            MovieList list = getMovieList(ID);
            int i;

            for (i = 0; i < list.movies.Count; i++)
            {
                list.movies[i] = movies[i].title;
            }

            saveMovieList(list);
        }
    }
}
