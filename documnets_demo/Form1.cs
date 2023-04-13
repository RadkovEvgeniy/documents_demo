using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace documnets_demo
{
    public partial class Form1 : Form
    {
        private readonly checkUser _user;

        public Form1(checkUser user)
        {
            InitializeComponent();
            _user = user;
            label1.Text = $"{_user.Login} : {_user.Status}";
            isAdmin();
        }

        private void isAdmin()
        {
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
        }
    }
}
