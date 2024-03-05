using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            isiAgama();
            isiJenjang();
            isiJurusan();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //isiAgama();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void keluarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // PROSEDUR MENGISI DATA COMBOBOX AGAMA
        private void isiAgama()
        {
            agamaCmb.Items.Clear();
            agamaCmb.Items.Add("Islam");
            agamaCmb.Items.Add("Kristen");
            agamaCmb.Items.Add("Katolik");
            agamaCmb.Items.Add("Hindu");
            agamaCmb.Items.Add("Budha");
            agamaCmb.Items.Add("Konghucu");
        }

        // PROSEDUR MENGISI DATA COMBOBOX JENJANG
        private void isiJenjang()
        {
            jenjangCmb.Items.Clear();
            jenjangCmb.Items.Add("D3");
            jenjangCmb.Items.Add("D4");
        }

        // PROSEDUR MENGISI DATA COMBOBOX JURUSAN
        private void isiJurusan()
        {
            jurusanCmb.Items.Clear();
            jurusanCmb.Items.Add("Teknik Informatika");
            jurusanCmb.Items.Add("Teknik Elektro");
            jurusanCmb.Items.Add("Teknik Mesin");
            jurusanCmb.Items.Add("Teknik Informatika");
            jurusanCmb.Items.Add("Teknik Elektro");
            jurusanCmb.Items.Add("Teknik Mesin");
            jurusanCmb.Items.Add("Teknik Sipil");
        }

        private void agamaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void jurusanCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tampilBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tampilkanData(), "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string tampilkanData()
        {
            string jenis = "";

            if(lakiRbn.Checked == true)
            {
                jenis = "Laki-laki";
            }
            else if(perempuanRbn.Checked == true)
            {
                jenis = "Perempuan";
            }   

            string info = "No. Induk\t: " + noIndukTxt.Text + "\n" +
                "Nama\t\t: " + namaTxt.Text + "\n" +
                "Jenis Kelamin\t: " + jenis + "\n" +
                "Agama\t\t: " + agamaCmb.Text + "\n" +
                "Jenjang\t\t: " + jenjangCmb.Text + "\n" +
                "Jurusan\t\t: " + jurusanCmb.Text + "\n" +
                "Alamat\t\t: " + alamatTxt.Text + "\n" +
                "Kota\t\t: " + kotaLsb.Text + "\n" +
                "Telepon\t\t: " + telpTxt.Text + "\n";

            return info;
        }
    }
}