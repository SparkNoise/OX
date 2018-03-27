using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {

        int kolko = 0, krzyz = 0, mecz = 3,klik;     
        bool znak = true, gra = true;

       
        public Form1()
        {
            InitializeComponent();
        }
        public void czarne()
        {
            
            button1.Image = Image.FromFile("..\\..\\black.png");
            button2.Image = Image.FromFile("..\\..\\black.png");
            button3.Image = Image.FromFile("..\\..\\black.png");
            button4.Image = Image.FromFile("..\\..\\black.png");
            button5.Image = Image.FromFile("..\\..\\black.png");
            button6.Image = Image.FromFile("..\\..\\black.png");
            button7.Image = Image.FromFile("..\\..\\black.png");
            button8.Image = Image.FromFile("..\\..\\black.png");
            button9.Image = Image.FromFile("..\\..\\black.png");
        }
        string kolo()
        {
            return "O";
        }
        string krzyzyk()
        {
            return "X";
        }
        string dane()
        {
            if (textBox1.Text == "Podaj imie" || textBox1.Text == "" || textBox2.Text == "Podaj imie" || textBox2.Text == "")
            {
                return "Podaj imie!!!";

            }
            else
            {
                czarne();
                groupBox1.Enabled = true;
                button10.Visible = true;
                button11.Visible = false;
                return "Gracz " + textBox1.Text + " zaczyna!";
            }
        }
        void wygrana()
        {

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.Image = Image.FromFile("..\\..\\crosswin.png");
                button2.Image = Image.FromFile("..\\..\\crosswin.png");
                button3.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                krzyz++;
                button10.Enabled = true;
                klik = 0;

            }
         else   if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.Image = Image.FromFile("..\\..\\crosswin.png");
                button5.Image = Image.FromFile("..\\..\\crosswin.png");
                button9.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                krzyz++;
                button10.Enabled = true;
                klik = 0;

            }
        else    if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                button7.Image = Image.FromFile("..\\..\\crosswin.png");
                button5.Image = Image.FromFile("..\\..\\crosswin.png");
                button3.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                krzyz++;
                button10.Enabled = true;
                klik = 0;

            }
          else  if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.Image = Image.FromFile("..\\..\\crosswin.png");
                button4.Image = Image.FromFile("..\\..\\crosswin.png");
                button7.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                krzyz++;
                button10.Enabled = true;
                klik = 0;

            }
          else  if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.Image = Image.FromFile("..\\..\\crosswin.png");
                button5.Image = Image.FromFile("..\\..\\crosswin.png");
                button6.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                button10.Enabled = true;
                krzyz++;
                klik = 0;

            }
          else  if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.Image = Image.FromFile("..\\..\\crosswin.png");
                button6.Image = Image.FromFile("..\\..\\crosswin.png");
                button9.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                krzyz++;
                button10.Enabled = true;
                klik = 0;

            }
          else  if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.Image = Image.FromFile("..\\..\\crosswin.png");
                button5.Image = Image.FromFile("..\\..\\crosswin.png");
                button8.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                krzyz++;
                button10.Enabled = true;
                klik = 0;
            }
          else  if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.Image = Image.FromFile("..\\..\\crosswin.png");
                button8.Image = Image.FromFile("..\\..\\crosswin.png");
                button9.Image = Image.FromFile("..\\..\\crosswin.png");
                groupBox1.Enabled = false;
                krzyz++;
                button10.Enabled = true;
                klik = 0;

            }
           else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.Image = Image.FromFile("..\\..\\toewin.png");
                button2.Image = Image.FromFile("..\\..\\toewin.png");
                button3.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;

            }
         else   if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.Image = Image.FromFile("..\\..\\toewin.png");
                button5.Image = Image.FromFile("..\\..\\toewin.png");
                button9.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.Image = Image.FromFile("..\\..\\toewin.png");
                button4.Image = Image.FromFile("..\\..\\toewin.png");
                button7.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;

            }
           else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.Image = Image.FromFile("..\\..\\toewin.png");
                button5.Image = Image.FromFile("..\\..\\toewin.png");
                button6.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;

            }
          else  if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.Image = Image.FromFile("..\\..\\toewin.png");
                button6.Image = Image.FromFile("..\\..\\toewin.png");
                button9.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;

            }
          else   if (button3.Text == "O" && button7.Text == "O" && button5.Text == "O")
            {
                button3.Image = Image.FromFile("..\\..\\toewin.png");
                button5.Image = Image.FromFile("..\\..\\toewin.png");
                button7.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;

            }
           else  if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.Image = Image.FromFile("..\\..\\toewin.png");
                button5.Image = Image.FromFile("..\\..\\toewin.png");
                button8.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.Image = Image.FromFile("..\\..\\toewin.png");
                button8.Image = Image.FromFile("..\\..\\toewin.png");
                button9.Image = Image.FromFile("..\\..\\toewin.png");
                groupBox1.Enabled = false;
                kolko++;
                button10.Enabled = true;
                klik = 0;
            }
            label4.Text = kolko.ToString();
            label5.Text = krzyz.ToString();

        }    
        void czysc()
        {
            czarne();
            button1.BackColor = Color.Transparent;
            button1.Text = "";
            button1.Enabled = true;
            button2.BackColor = Color.Transparent;
            button2.Text = "";
            button2.Enabled = true;
            button3.BackColor = Color.Transparent;
            button3.Text = "";
            button3.Enabled = true;
            button4.BackColor = Color.Transparent;
            button4.Text = "";
            button4.Enabled = true;
            button5.BackColor = Color.Transparent;
            button5.Text = "";
            button5.Enabled = true;
            button6.BackColor = Color.Transparent;
            button6.Text = "";
            button6.Enabled = true;
            button7.BackColor = Color.Transparent;
            button7.Text = "";
            button7.Enabled = true;
            button8.BackColor = Color.Transparent;
            button8.Text = "";
            button8.Enabled = true;
            button9.BackColor = Color.Transparent;
            button9.Text = "";
            button9.Enabled = true;

        }
        void reset()
        {
            klik = 0;
            button10.Text="Jeszcze raz?";
            label4.Text = "0";
            label5.Text = "0";
            button10.Visible = false;
            button11.Visible = true;
            znak = true;
            gra = true;
            kolko = 0;
            krzyz = 0;
            textBox1.Text = "Podaj imie";
            textBox2.Text = "Podaj imie";
            button1.BackColor = Color.Transparent;
            button1.Text = "";
          
            button1.Enabled = true;
            button2.BackColor = Color.Transparent;
            button2.Text = "";
            button2.Enabled = true;
            button3.BackColor = Color.Transparent;
            button3.Text = "";
            button3.Enabled = true;
            button4.BackColor = Color.Transparent;
            button4.Text = "";
            button4.Enabled = true;
            button5.BackColor = Color.Transparent;
            button5.Text = "";
            button5.Enabled = true;
            button6.BackColor = Color.Transparent;
            button6.Text = "";
            button6.Enabled = true;
            button7.BackColor = Color.Transparent;
            button7.Text = "";
            button7.Enabled = true;
            button8.BackColor = Color.Transparent;
            button8.Text = "";
            button8.Enabled = true;
            button9.BackColor = Color.Transparent;
            button9.Text = "";
            button9.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (znak == true)
            {
                button1.Text = krzyzyk();                            
                znak = false;
                button1.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button1.Text = kolo();
                button1.Image = Image.FromFile("..\\..\\toe.png");
                znak = true;
            }
            klik++;
            button1.Enabled = false;
            wygrana();
            if (klik == 9) button10.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (znak == true)
            {
                button2.Text = krzyzyk();
                znak = false;
                button2.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button2.Text = kolo();
                button2.Image = Image.FromFile("..\\..\\toe.png");
                znak = true;
            }
            button2.Enabled = false;
            wygrana();
            klik++;
            if (klik == 9) button10.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            if (znak == true)
            {
                button3.Text = krzyzyk();
                znak = false;
                button3.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button3.Text = kolo();
                button3.Image = Image.FromFile("..\\..\\toe.png");
                znak = true;
            }
            button3.Enabled = false;
            wygrana();
            klik++;
            if (klik == 9) button10.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                button4.Text = krzyzyk();
                znak = false;
                button4.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button4.Text = kolo();
                znak = true;
                button4.Image = Image.FromFile("..\\..\\toe.png");
            }
            button4.Enabled = false;
            wygrana();
            klik++;
            if (klik == 9) button10.Enabled = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                button5.Text = krzyzyk();
                znak = false;
                button5.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button5.Text = kolo();
                znak = true;
                button5.Image = Image.FromFile("..\\..\\toe.png");
            }
            button5.Enabled = false;
            wygrana();
            klik++;
            if (klik == 9) button10.Enabled = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                button6.Text = krzyzyk();
                znak = false;
                button6.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button6.Text = kolo();
                znak = true;
                button6.Image = Image.FromFile("..\\..\\toe.png");
            }
            button6.Enabled = false;
            klik++;
            wygrana();
            if (klik == 9) button10.Enabled = true;

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                button7.Text = krzyzyk();
                znak = false;
                button7.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button7.Text = kolo();
                znak = true;
                button7.Image = Image.FromFile("..\\..\\toe.png");
            }
            button7.Enabled = false;
            wygrana();
            klik++;
            if (klik == 9) button10.Enabled = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                button8.Text = krzyzyk();
                znak = false;
                button8.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button8.Text = kolo();
                znak = true;
                button8.Image = Image.FromFile("..\\..\\toe.png");
            }
            button8.Enabled = false;
            wygrana();
            klik++;
            if (klik == 9) button10.Enabled = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                button9.Text = krzyzyk();
                znak = false;
                button9.Image = Image.FromFile("..\\..\\cross.png");
            }
            else
            {
                button9.Text = kolo();
                znak = true;
                button9.Image = Image.FromFile("..\\..\\toe.png");
            }
            button9.Enabled = false;
            wygrana();
            klik++;
            if (klik == 9) button10.Enabled = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dane());
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            label4.Text = kolko.ToString();
            label5.Text = krzyz.ToString();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mecz = 5;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            mecz = 7;
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            mecz = 10;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            if (kolko < mecz && krzyz< mecz)
            {
                groupBox1.Enabled = true;
                czysc();
                if (gra == true)
                {
                    MessageBox.Show("Zaczyna gracz " + textBox2.Text, "ZAMIANA GRACZA");
                    gra = false;
                    znak = false;
                }
                else
                {
                    MessageBox.Show("Zaczyna gracz "+ textBox1.Text,"ZAMIANA GRACZA");
                    gra = true;
                    znak = true;
                }
                
            }
            else
            {
                button10.Text = "KONIEC";
                if (kolko == mecz) MessageBox.Show("Wygrał gracz "+textBox2.Text);
                if (krzyz == mecz) MessageBox.Show("Wygrał gracz "+textBox1.Text);
                if (MessageBox.Show("Czy chcesz zagrać od nowa?", "KONIEC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reset();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
