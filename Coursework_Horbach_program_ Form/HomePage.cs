using System;
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
    public partial class HomePage : Form
    {
        private string login;
        private string password;
        private bool isAuthenticated;

        public HomePage(string login, string password, bool isAuthenticated)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            this.isAuthenticated = isAuthenticated;
        }
    }
}
