﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class RemoveFromListsForm : Comp3020A3.ListManagementForm
    {
        private MovieList ml = null;
        private List<MovieList> mls = null;

        public RemoveFromListsForm(MovieList list)
        {
            InitializeComponent();
            editWindowTitle("Edit List");
            editTitle("Manage " + list.name);
            editSubTitle("");
            EditToolTip("Uncheck boxes to remove movies. Press Ok to save changes.");
            showActionButton(true);
            editActionButton("Search for a Movie");
            showTextBox(true);
            ml = list;
            fillOutForm(list);
        }

        public RemoveFromListsForm(List<MovieList> lists)
        {
            InitializeComponent();
            editWindowTitle("Edit List");
            editTitle("Manage My Lists");
            editSubTitle("");
            showActionButton(false);
            showTextBox(false);
            EditToolTip("Uncheck boxes to delete lists. Press Ok to save changes.");
            mls = lists;
            fillOutForm(lists);
        }

        private void fillOutForm(MovieList list)
        {
            int i;

            foreach (string movie in list.movies)
            { 
                box().Items.Add(movie);
            }

            for (i = 0; i < box().Items.Count; i++)
            {
                box().SetItemChecked(i, true);
            }
        }

        private void fillOutForm(List<MovieList> lists)
        {
            int i;

            foreach (MovieList list in lists)
            {
                box().Items.Add(list.name);
            }

            for (i = 0; i < box().Items.Count; i++)
            {
                box().SetItemChecked(i, true);
            }
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            //add in some reordering stuff

            if(ml != null)
            {
                foreach (string s in ml.movies)
                {
                    if (!box().GetItemChecked(i))
                    {
                        MovieListManager.removeFromMovieList(ml.ID, box().Items[i].ToString());
                    }
                    i++;
                }

                ApplicationManager.reloadForm(MovieListManager.getMovieList(ml.ID));
            }
            else
            {
                foreach (MovieList list in mls)
                {
                    if (!box().GetItemChecked(i))
                    {
                        MovieListManager.destroyMovieList(list.ID);
                    }
                    i++;
                }

                ApplicationManager.reloadForm(MovieListManager.getMovieLists(ApplicationManager.loggedIn.username));
            }

            Close();
        }

        protected override void actionButton_Click(object sender, EventArgs e)
        {
            search();
        }

        protected override void enterSearch(object sender, KeyPressEventArgs e)
        {
            search();
        }

        private void search()
        {
            if (getTextBox().Length > 0)
            {
                //search
            }
            else
            {
                ApplicationManager.changeForm("SEARCH", null);
            }
        }
    }
}
