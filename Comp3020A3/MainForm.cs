﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void changeProfileLinkText(string text)
        {
            profileLink.Text = text;
        }

        public void changemyListsLinkText(string text)
        {
            myListsLink.Text = text;
        }

        public void changesignOutLinkText(string text)
        {
            signOutLink.Text = text;
        }

        public void changesignInLinkText(string text)
        {
            signInLink.Text = text;
        }

        public void checkLoggedIn()
        {
            if (ApplicationManager.loggedIn != null)
            {
                changeProfileLinkText("Profile");
                changemyListsLinkText("My Lists");
                changesignOutLinkText("Sign Out");
                changesignInLinkText("");
            }
            else
            {
                changeProfileLinkText("");
                changemyListsLinkText("");
                changesignOutLinkText("");
                changesignInLinkText("Sign In / Up");
            }
        }

        private void profileLink_Click(object sender, EventArgs e)
        {
            ApplicationManager.showForm(this, "PROFILE", ApplicationManager.loggedIn);
        }

        private void myListsLink_Click(object sender, EventArgs e)
        {
            List<MovieList> lists = MovieListManager.getMovieLists(ApplicationManager.loggedIn.username);
            ApplicationManager.showForm(this, "LISTS", lists);
        }

        private void signOutLink_Click(object sender, EventArgs e)
        {
            ApplicationManager.loggedIn = null;
            ApplicationManager.showForm(this, "HOME", null);
        }

        private void signInLink_Click(object sender, EventArgs e)
        {
            ApplicationManager.showForm(this, "SIGNIN", null);
        }

        private void search(object sender, EventArgs e)
        {
            ApplicationManager.lastQuery = new SearchQuery() { title = searchBox.Text };
            //SearchResultsForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            ApplicationManager.showForm(this, "HOME", null);
        }

        private void closeApplication(object sender, FormClosedEventArgs e)
        {
            ApplicationManager.exitApplication();
        }

        public void changeForm(Object element)
        {
            checkLoggedIn();
            fillInForm(element);
        }

        public virtual void processData(FormData data)
        {

        }

        protected virtual void fillInForm(Object element)
        {
            
        }
    }
}
