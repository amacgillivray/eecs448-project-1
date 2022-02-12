﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EECS_448___Project_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void LocalGameButton_Click(object sender, EventArgs e) {

            SetupPage setup = new SetupPage();
            setup.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreditsPage credits = new CreditsPage();
            credits.Show();
            this.Hide();
        }

        private void NetworkGameButton_Click(object sender, EventArgs e)
        {
            ConstructionPage constructionPage = new ConstructionPage();
            constructionPage.Show();
            this.Hide();
        }
    }
}
