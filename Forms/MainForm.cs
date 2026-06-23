using GestionareParcari.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionareParcari.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Nu s-a putut conecta la baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            statusLabel1.Text = "Conectat la baza de date";
        }

        private void OpenVehicule()
        {
            Form v = new FormVehicule();
            v.ShowDialog();
        }

        private void OpenParcari()
        {
            Form p = new FormParcari();
            p.ShowDialog();
        }

        private void OpenAbonamente()
        {
            Form a = new FormAbonamente();
            a.ShowDialog();
        }

        private void OpenRaport()
        {
            Form r = new FormRaport();
            r.ShowDialog();
        }

        private void vehiculeButton_Click(object sender, EventArgs e)
        {
            OpenVehicule();
        }

        private void parcariButton_Click(object sender, EventArgs e)
        {
            OpenParcari();
        }

        private void abonamenteButton_Click(object sender, EventArgs e)
        {
            OpenAbonamente();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnVehicule_Click(object sender, EventArgs e)
        {
            OpenVehicule();
        }

        private void btnParcari_Click(object sender, EventArgs e)
        {
            OpenParcari();
        }

        private void btnAbonamente_Click(object sender, EventArgs e)
        {
            OpenAbonamente();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            OpenRaport();
        }

        private void raportVehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
