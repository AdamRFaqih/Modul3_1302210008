using System.Reflection.Emit;

namespace Modul3_1302210008
{
    public partial class Form1 : Form
    {
        int angka;
        int hasil = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text= "";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void empat_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void lima_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void enam_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            angka = int.Parse(label1.Text);
            hasil += angka;
            label1.Text = "+";
            label1.Text = "";
        }

        private void samaDengan_Click(object sender, EventArgs e)
        {
            angka = int.Parse(label1.Text);
            hasil += angka;
            label1.Text = hasil.ToString();
        }

        private void nol_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}