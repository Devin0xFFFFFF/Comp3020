﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class ReviewManager
    {
        public static List<FormError> createReview(string rauthor, string rmovie, string rtitle, string rcontent)
        {
            List<FormError> errors = new List<FormError>();

            Review review = new Review() { ID = DataAccess.generateID(),
                author = rauthor, movie = rmovie, title = rtitle, content = rcontent,
            createdAt = DateTime.Now, lastEdited = DateTime.Now};

            if (review.valid(errors))
            {
                List<Review> reviews = DataAccess.readReviews();
                reviews.Add(review);
                DataAccess.writeReviews(reviews);
            }

            return errors;
        }

        public static List<Review> getReviews(string author)
        {
            List<Review> reviews = DataAccess.readReviews();
            int i = reviews.Count;

            while (i >= 0)
            {
                if(reviews.ElementAt(i).author.Equals(author))
                {
                    reviews.RemoveAt(i);
                }
                i--;
            }

            return reviews;
        }

        public static bool destroyReview(long ID)
        {
            List<Review> reviews = DataAccess.readReviews();
            int i = 0;
            bool removed = false;

            while(i < reviews.Count && !removed)
            {
                if(reviews.ElementAt(i).ID == ID)
                {
                    reviews.RemoveAt(i);
                    removed = true;
                }

                i++;
            }

            return removed;
        }
    }
}
