﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class HomeForm : Comp3020A3.MainForm
    {
        public HomeForm()
        {
            InitializeComponent();
            ApplicationManager.loggedIn = new User() { username = "bobafett2", password = "demonlord2", following = new List<string>() };
            ApplicationManager.createForms(this);
            checkLoggedIn();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadNewMovies();
            loadNewReviews();
        }

        private void loadNewMovies()
        {
            List<Movie> newMovies = DataAccess.readMovies();
            MovieManager.sortByYear(newMovies);
            newMovies = MovieManager.getMovies(newMovies, 10);

            dataGridView1.DataSource = newMovies;
        }

        private void loadNewReviews()
        {
            List<Review> newReviews = DataAccess.readReviews();
            ReviewManager.sortByDateTime(newReviews);
            newReviews = ReviewManager.getReviews(newReviews, 10);

            dataGridView2.DataSource = newReviews;
            dataGridView2.Columns[0].Visible = false;
        }

        private void viewMoviePage(object sender, DataGridViewCellEventArgs e)
        {
            List<Movie> movies = (List<Movie>)dataGridView1.DataSource;
            Movie[] movs = new Movie[movies.Count];
            movies.CopyTo(movs);
            Movie movie = movs[e.RowIndex];

            ApplicationManager.showForm(this, "MOVIE", new Movie(movie));
        }
    }
}
