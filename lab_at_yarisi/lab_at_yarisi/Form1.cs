using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_at_yarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //bir kontrolun left ve top özelliklerine atama yapabilirsiniz.Ancak right ve bottom özelliklerinin o anki değerini alabilirsiniz.

            
            int sayı1 = rnd.Next(1, 15);
            int sayı2 = rnd.Next(1, 15);
            int sayı3 = rnd.Next(1, 15);
            pic_1.Left += sayı1;
            pic_2.Left += sayı2;
            pic3.Left += sayı3;
            
            
            if (pic_1.Right > label4.Left)
            {
                timer1.Stop();
                MessageBox.Show("ATILGAN YARIŞI KAZANDI!!");
            }
            else if (pic_2.Right > label4.Left)
            {
                timer1.Stop();
                MessageBox.Show("UÇAN YELE YARIŞI KAZANDI!!");
            }
            else if (pic3.Right > label4.Left)
            {
                timer1.Stop();
                MessageBox.Show("FIRTINA YARIŞI KAZANDI!!");
            }
            else
            {
                txt_durum.Text = "Berabere";
            }

            if (pic_1.Right > pic_2.Right && pic_1.Right > pic3.Right)
            {
                txt_durum.Text = "ATILGAN yarışıönde götürüyor.";
            }
            else if (pic_2.Right > pic_1.Right && pic_2.Right > pic3.Right)
            {
                txt_durum.Text = "UÇAN YELE yarışıönde götürüyor.";
            }
            else if (pic3.Right > pic_1.Right && pic3.Right > pic_2.Right)
            {
                txt_durum.Text = "FIRTINA  yarışıönde götürüyor.";
            }
            
                

            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pic_1.Left = 0;
            pic_2.Left = 0;
            pic3.Left = 0;
            txt_durum.Text = "";

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pic3.Left += 15;
        }
    }
}
