﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ProfileForm : Comp3020A3.MainForm
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(User user)
        {
            InitializeComponent();

            fillInProfile(user);
        }

        private void followButton_Click(object sender, EventArgs e)
        {

        }

        private void fillInProfile(User user)
        {
            userTitleLabel.Text = user.username;

            int followers = user.getFollowerCount();

            if(followers > 0)
            {
                followerCountLabel.Text = "Followers: " + followers;
            }
            else
            {
                followerCountLabel.Text = "No Followers";
            }

            listGrid.DataSource = MovieListManager.getMovieLists(user.username);
            reviewGrid.DataSource = ReviewManager.getReviewsByAuthor(user.username);

            if(ApplicationManager.loggedIn != null && ApplicationManager.loggedIn.username.Equals(user.username))
            {
                followButton.Hide();
            }
            else
            {
                followButton.Show();
                if(ApplicationManager.loggedIn != null && ApplicationManager.loggedIn.isFollowing(user.username))
                {
                    followButton.Text = "Unfollow";
                }
                else
                {
                    followButton.Text = "Follow";
                }
            }
        }
    }
}
