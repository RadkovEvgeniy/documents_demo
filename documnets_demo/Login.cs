using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace documnets_demo
{
    public partial class Login : Form
    {
        DataBase_Connection DataBase = new DataBase_Connection();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            PassBox.UseSystemPasswordChar = true;
        }

        private int count;

        private void EnterBut_Click(object sender, EventArgs e)
        {
            var login = LoginBox.Text;
            var pass = PassBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String loginquery = $"select logins, passwords, isAdmin from users where logins = '{login}' and passwords = '{pass}'";

            SqlCommand command = new SqlCommand(loginquery, DataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[0].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[2]));

                MessageBox.Show("Вход выполнен успешно");
                Form1 f1 = new Form1(user);
                this.Hide();
                f1.ShowDialog();
                LoginBox.Text = "";
                PassBox.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");

                if(count++ == 2)
                {
                    New_Login nl = new New_Login();
                    this.Hide();
                    nl.ShowDialog();
                }
            }
        }

        private void eyesClose_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = false;
            eyesClose.Visible = false;
            eyesOpen.Visible = true;
        }

        private void eyesOpen_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = true;
            eyesOpen.Visible = false;
            eyesClose.Visible = true;
        }
    }
}
