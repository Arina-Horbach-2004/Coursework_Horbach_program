﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_Horbach_program__Form
{
    public partial class AdminPage : Form
    {
        private string login;
        private string password;
        private bool isAuthenticated;

        public AdminPage(bool isAuthenticated)
        {
            InitializeComponent();
            this.isAuthenticated = isAuthenticated;
        }
    }
}