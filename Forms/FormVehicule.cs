using GestionareParcari.DataAccess;
using GestionareParcari.Models;
using GestionareParcari.Utils;
using Microsoft.Data.SqlClient;
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
    public partial class FormVehicule : Form
    {
        public FormVehicule()
        {
            InitializeComponent();
        }

        private void FormVehicule_Load(object sender, EventArgs e)
        {
            ConfigureazaGrid();
            IncarcaVehicule();
        }

        private void ConfigureazaGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void IncarcaVehicule()
        {
            try
            {
                List<Vehicul> v;
                if (string.IsNullOrWhiteSpace(txtNr.Text) && string.IsNullOrWhiteSpace(txtOwner.Text))
                {
                    v = VehiculRepository.GetAll();
                }
                else
                {
                    v = VehiculRepository.Search(txtNr.Text, txtOwner.Text);
                }

                dataGridView1.DataSource = v;
                AjusteazaColoane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare vehicule:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AjusteazaColoane()
        {
            if (dataGridView1.Columns["IdVehicul"] != null) dataGridView1.Columns["IdVehicul"].Visible = false;

            if (dataGridView1.Columns["NumarInmatriculare"] != null) dataGridView1.Columns["NumarInmatriculare"].HeaderText = "Numar Inmatriculare";

            if (dataGridView1.Columns["Marca"] != null) dataGridView1.Columns["Marca"].HeaderText = "Marca";

            if (dataGridView1.Columns["Model"] != null) dataGridView1.Columns["Model"].HeaderText = "Model";

            if (dataGridView1.Columns["Proprietar"] != null) dataGridView1.Columns["Proprietar"].HeaderText = "Proprietar";

        }

        private void txtNr_TextChanged(object sender, EventArgs e)
        {
            IncarcaVehicule();
        }

        private void txtOwner_TextChanged(object sender, EventArgs e)
        {
            IncarcaVehicule();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormVehiculeEdit f = new FormVehiculeEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                IncarcaVehicule();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selectati un vehicul pentru modificare", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["IdVehicul"].Value;
            FormVehiculeEdit f = new FormVehiculeEdit(id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                IncarcaVehicule();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selectati un vehicul pentru stergere", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["IdVehicul"].Value;
            var result = MessageBox.Show("Doriti sa stergeti acest vehicul?", "Atentie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                VehiculRepository.Delete(id);
                MessageBox.Show("Vehicul sters cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IncarcaVehicule();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Nu se poate sterge acest vehicul pentru ca are asociate alte abonamente in sistem");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu sa putut sterge vehicul:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNr.Text = "";
            txtOwner.Text = "";
            IncarcaVehicule();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["IdVehicul"].Value;
            FormVehiculeEdit f = new FormVehiculeEdit(id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                IncarcaVehicule();
            }
        }
    }
}
