﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2202_GitHubTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/mbublitz-pappert/github-test");
        }

        private void button1_Click(object sender, EventArgs e) {
            panel1.BackColor = Color.Yellow;
            label1.Text = "Gelb";
        }

    }
}
