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
    public partial class New_Login : Form
    {
        DataBase_Connection DataBase = new DataBase_Connection();   

        public New_Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SaveBut.Enabled = false;
            PassBox.UseSystemPasswordChar = true;
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection(); 
            var login = LoginBox.Text;
            var password = PassBox.Text;

            var changequery = $"update users set passwords = '{password}' where logins = '{login}'";

            var command = new SqlCommand(changequery,DataBase.GetConnection());

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно изменили пароль");
                LoginBox.Text = "";
                PassBox.Text = "";
                Login l = new Login();
                this.Hide();
                l.ShowDialog();
            }
            else
            {
                MessageBox.Show("Произошла ошибка");
            }
            DataBase.CloseConnection();
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            if (PassBox.Text.Length == 15 & PassBox.Text.Contains("@") & PassBox.Text.Contains("#") & PassBox.Text.Contains("%") & PassBox.Text.Contains("(") & PassBox.Text.Contains(")") & PassBox.Text.Contains(".") & PassBox.Text.Contains("<"))
            {
                SaveBut.Enabled = true;
            }
            else
            {
                SaveBut.Enabled = false;
            }
        }

        private void eyesOpen_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = true;
            eyesOpen.Visible = false;
            eyesClose.Visible = true;
        }

        private void eyesClose_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = false;
            eyesClose.Visible = false;
            eyesOpen.Visible = true;
        }
    }
}
