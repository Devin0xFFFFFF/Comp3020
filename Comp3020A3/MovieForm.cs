﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class MovieForm : Comp3020A3.MainForm
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        protected override void fillInForm(Object element)
        {
            Movie movie = (Movie)element;
            fillInPage(movie);
        }

        private void fillInPage(Movie movie)
        {
            movieTitleLabel.Text = movie.title;
            yearLabel.Text = "(" + movie.year + ")";
            ratingLabel.Text = "Rating: " + movie.rating;
            certificationLabel.Text = movie.certification;

            genreList.Items.Clear();

            foreach(string genre in movie.genres)
            {
                genreList.Items.Add(genre);
            }

            directorLabel.Text = "Director: " + movie.director;
            lengthLabel.Text = "Length: " + movie.length + " min";

            actorList.Items.Add("Actors:");

            actorList.Items.Clear();

            foreach (string actor in movie.actors)
            {
                actorList.Items.Add(actor);
            }

            fillInReviews(movie.title);
        }

        private void fillInReviews(string movie)
        {
            List<Review> reviews = ReviewManager.getReviewsByMovie(movie);

            reviewsGrid.DataSource = reviews;
        }
    }
}
