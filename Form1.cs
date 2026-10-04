using System;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (cmbOperasi.Items.Count > 0)
            {
                cmbOperasi.SelectedIndex = 0;
            }
        }

        private int Penambahan(int a, int b) => a + b;
        private int Pengurangan(int a, int b) => a - b;
        private int Perkalian(int a, int b) => a * b;
        private int Pembagian(int a, int b) => a / b;

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNilaiA.Text) || string.IsNullOrEmpty(txtNilaiB.Text))
            {
                MessageBox.Show("Nilai A dan Nilai B harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int a = int.Parse(txtNilaiA.Text);
            int b = int.Parse(txtNilaiB.Text);

            if (cmbOperasi.SelectedIndex == 0)
                txtHasil.Text = Penambahan(a, b).ToString();
            else if (cmbOperasi.SelectedIndex == 1)
                txtHasil.Text = Pengurangan(a, b).ToString();
            else if (cmbOperasi.SelectedIndex == 2)
                txtHasil.Text = Perkalian(a, b).ToString();
            else if (cmbOperasi.SelectedIndex == 3)
                txtHasil.Text = Pembagian(a, b).ToString();
        }
    }
}