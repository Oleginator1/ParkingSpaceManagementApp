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
    public partial class FormParcari : Form
    {
        private const string text = "TOATE_PARCARILE";
        public FormParcari()
        {
            InitializeComponent();
        }

        private void FormParcari_Load(object sender, EventArgs e)
        {
            ConfigureazaGrid();
            IncarcaDate();
            IncarcaZone();
            IncarcaTipuri();
        }

        private void ConfigureazaGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void IncarcaDate()
        {
            try
            {
                List<Parcare> p = new List<Parcare>();
                if ((cbZona.SelectedItem == null || cbZona.SelectedItem.ToString() == text) && (cbTip.SelectedItem == null || cbTip.SelectedItem.ToString() == text))
                {
                    p = ParcareRepository.GetAll();
                }
                else if (cbZona.SelectedItem != null && cbZona.SelectedItem.ToString() != text)
                {
                    p = ParcareRepository.GetByZona(cbZona.SelectedItem.ToString());
                }
                else if (cbTip.SelectedItem != null && cbTip.SelectedItem.ToString() != text)
                {
                    p = ParcareRepository.GetByTip(cbTip.SelectedItem.ToString());
                }
                dataGridView1.DataSource = p;
                AjusteazaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare date: \n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IncarcaZone()
        {
            try
            {
                cbZona.Items.Clear();
                cbZona.Items.Add(text);
                List<string> z = ParcareRepository.GetZona();
                foreach (var item in z)
                {
                    cbZona.Items.Add(item);
                }
                cbZona.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu sau putut incarca zonele: \n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IncarcaTipuri()
        {
            try
            {
                cbTip.Items.Clear();
                cbTip.Items.Add(text);
                List<string> t = ParcareRepository.GetTip();
                foreach (var item in t)
                {
                    cbTip.Items.Add(item);
                }
                cbTip.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu sau putut incarca tipurile: \n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AjusteazaGrid()
        {
            if (dataGridView1.Columns["IdParcare"] != null) dataGridView1.Columns["IdParcare"].Visible = false;

            if (dataGridView1.Columns["Zona"] != null) dataGridView1.Columns["Zona"].HeaderText = "Zona Parcarii";
            if (dataGridView1.Columns["NumarLocuri"] != null) dataGridView1.Columns["NumarLocuri"].HeaderText = "Numar Locuri";
            if (dataGridView1.Columns["PretLunar"] != null)
            {
                dataGridView1.Columns["PretLunar"].HeaderText = "Pret Lunar (lei)";
                dataGridView1.Columns["PretLunar"].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns["PretLunar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridView1.Columns["Tip"] != null) dataGridView1.Columns["Tip"].HeaderText = "Tipul Parcarii";


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (cbZona.Items.Count > 0)
            {
                cbZona.SelectedIndex = 0;
            }
            if (cbTip.Items.Count > 0) { cbTip.SelectedIndex = 0; }
        }

        private void cbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncarcaDate();
        }

        private void cbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncarcaDate();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormParcariEdit f = new FormParcariEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                IncarcaDate();
                IncarcaTipuri();
                IncarcaZone();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selectati o parcare pentru modificare", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["IdParcare"].Value;
            FormParcariEdit f = new FormParcariEdit(id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                IncarcaDate();
                IncarcaTipuri();
                IncarcaZone();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selectati o parcare pentru modificare", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["IdParcare"].Value;
            var result = MessageBox.Show("Doriti sa stergeti aceasta parcare?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                ParcareRepository.Delete(id);
                MessageBox.Show("Parcarea a fost stearsa cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IncarcaDate();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Parcarea face parte din abonamente existente si nu poate fi stearsa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere: \n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
