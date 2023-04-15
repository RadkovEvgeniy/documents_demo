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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace documnets_demo
{
    public partial class Form1 : Form
    {
        Image img;
        string kurs;
        string obuh;
        string plat;
        string adres;
        string sum;

        DataBase_Connection DataBase = new DataBase_Connection();
        private readonly checkUser _user;

        public Form1(checkUser user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _user = user;
            label1.Text = $"{_user.Login} : {_user.Status}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Bitmap DrawKvit(int nmb, string kurs, string obuh, string plat, string adres, string sum)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bmp);

            Font font = new Font("Times New Roman", 14);
            Font sfont = new Font("Times New Roman", 10);
            QRCodeEncoder encoder = new QRCodeEncoder();
            graphics.DrawRectangle(new Pen(Brushes.Black), 0, 0, 700, 520);
            graphics.DrawRectangle(new Pen(Brushes.Black), 0, 0, 200, 520);

            int y = 0;

            for (int i = 0; i < 10; i++)
            {
                graphics.DrawRectangle(new Pen(Brushes.Black), 200, y += 40, 500, 40);
            }

            graphics.DrawImage(encoder.Encode("https://vk.com/fuck_everyday"), 20, 50, 150, 150);
            graphics.DrawString("Квитанция", font, Brushes.Black, 20, 10);
            graphics.DrawString("Воронежский филиал РЭУ им. Г.В Плеханова", font, Brushes.Black, 210, 10);
            graphics.DrawString("ИНН 7705043493 КПП 366643001", font, Brushes.Black, 210, 45);
            graphics.DrawString(@"БИК 012007084 (ОТДЕЛЕНИЕ ВОРОНЕЖ БАНКА РОССИИ/УФК по Воронежской 
                                    области г.Воронеж)", sfont, Brushes.Black, 210, 80);
            graphics.DrawString($"Договор: {nmb}", font, Brushes.Black, 210, 130);
            graphics.DrawString($"ФИО обучающегося: {obuh}", font, Brushes.Black, 210, 170);
            graphics.DrawString($"Назначение: Оплата за курс {kurs}", font, Brushes.Black, 210, 210);
            graphics.DrawString($"ФИО плательщика: {plat}", font, Brushes.Black, 210, 250);
            graphics.DrawString($"Адрес плательщика: {adres}", font, Brushes.Black, 210, 290);
            graphics.DrawString("КБК: 0000000000130", font, Brushes.Black, 210, 330);
            graphics.DrawString("ОКТМО: 20701000", font, Brushes.Black, 210, 370);
            graphics.DrawString($"Сумма: {sum} ₽", font, Brushes.Black, 210, 410);
            graphics.DrawString(@"С условиями приема указанной в платежном документе суммы, в т.ч. с суммой 
взнимаемой платы за услуги
банка ознакомлен и согласен.        Подпись плательщика __________\", sfont, Brushes.Black, 210, 450);

            return bmp;
        }

        int nmb = 0;

        private void Random()
        {
            Random rnd = new Random();
            nmb = rnd.Next(1, 10000);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random();
            kurs = comboBox1.Text;
            obuh = textBox2.Text;
            plat = textBox3.Text;
            adres = textBox4.Text;
            sum = textBox5.Text;
            img = DrawKvit(nmb, kurs, obuh, plat, adres, sum);
            pictureBox1.Image = img;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        DataTable table;
        SqlDataAdapter adapter;

        private void физическоеЛицоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            adapter = new SqlDataAdapter("select * from Fiz_face", DataBase.GetConnection());
            adapter.Fill(table);

            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            dataGridView1.DataSource = table;
        }

        private void образовательнаяПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            adapter = new SqlDataAdapter("select * from Education_program", DataBase.GetConnection());
            adapter.Fill(table);

            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Dogovor().Show();
        }
    }
}
