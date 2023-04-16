using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace documnets_demo
{
    public partial class Dogovor : Form
    {
        DataBase_Connection DataBase = new DataBase_Connection();

        DataTable fiz_lico = new DataTable();
        DataTable obr_program = new DataTable();
        DataTable dogovor = new DataTable();
        DataTable price = new DataTable();

        public Dogovor()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            fiz_lico.Clear();
            dogovor.Clear();
            obr_program.Clear();

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            DataBase.OpenConnection();

            fiz_lico.Load(new SqlCommand("select * from Fiz_face", DataBase.GetConnection()).ExecuteReader());
            dogovor.Load(new SqlCommand("select * from Fiz_face2", DataBase.GetConnection()).ExecuteReader());
            obr_program.Load(new SqlCommand("select * from Education_Program", DataBase.GetConnection()).ExecuteReader());


            string fio = "";
            string obr = "";
            foreach (DataRow dr in fiz_lico.Rows)
            {
                fio = "";
                fio += dr.ItemArray[1] + " " + dr.ItemArray[2] + " " + dr.ItemArray[3];
                comboBox1.Items.Add(fio);
            }

            foreach (DataRow dr in obr_program.Rows)
            {
                obr = "";
                obr += dr.ItemArray[1].ToString();
                comboBox2.Items.Add(obr);
            }
            dataGridView1.DataSource = dogovor;
            DataBase.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = comboBox1.SelectedItem.ToString();
            string obrazovanie = comboBox2.SelectedItem.ToString();
            int stoimost = Convert.ToInt32(textBox1.Text);
            string srok = textBox2.Text;
            string datast = textBox3.Text;
            string datafin = textBox4.Text;

            DataBase.OpenConnection();
            new SqlCommand($"insert into Fiz_face2 values('{fio}', '{obrazovanie}', {stoimost}, '{srok}', '{datast}', '{datafin}')", DataBase.GetConnection()).ExecuteNonQuery();
            DataBase.CloseConnection();

            UpdateData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            price.Load(new SqlCommand($"select * from Education_program where Names = '{comboBox2.SelectedItem.ToString()}'", DataBase.GetConnection()).ExecuteReader());

            if (comboBox2.Text == "Механик")
            {
                textBox1.Text = price.Rows[0].ItemArray[4].ToString();
                textBox2.Text = price.Rows[0].ItemArray[2].ToString();
            }
            if (comboBox2.Text == "Преподаватель")
            {
                textBox1.Text = price.Rows[1].ItemArray[4].ToString();
                textBox2.Text = price.Rows[1].ItemArray[2].ToString();
            }
            if (comboBox2.Text == "Электрик")
            {
                textBox1.Text = price.Rows[2].ItemArray[4].ToString();
                textBox2.Text = price.Rows[2].ItemArray[2].ToString();
            }
            if (comboBox2.Text == "Программист")
            {
                textBox1.Text = price.Rows[3].ItemArray[4].ToString();
                textBox2.Text = price.Rows[3].ItemArray[2].ToString();
            }
            if (comboBox2.Text == "Водитель трамвая")
            {
                textBox1.Text = price.Rows[4].ItemArray[4].ToString();
                textBox2.Text = price.Rows[4].ItemArray[2].ToString();
            }

            DataBase.CloseConnection();
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox3.Text = e.Start.ToShortDateString();
            double days = double.Parse(textBox2.Text.Replace(" года", "")) * 365;

            textBox4.Text = e.Start.AddDays(days).ToShortDateString();
        }
    }
}
