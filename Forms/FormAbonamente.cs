using GestionareParcari.DataAccess;
using GestionareParcari.Models;
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
    public partial class FormAbonamente : Form
    {
        private const string text = "TOATE_CATEGORIILE";
        public FormAbonamente()
        {
            InitializeComponent();
        }

        private void FormAbonamente_Load(object sender, EventArgs e)
        {
            ConfigureazaGrid();
            IncarcaVehicule();
            IncarcaDate();
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
                cbVehicul.Items.Clear();
                cbVehicul.Items.Add(text);
                List<Vehicul> v = VehiculRepository.GetAll();
                foreach (Vehicul veh in v)
                {
                    cbVehicul.Items.Add(veh);
                }
                cbVehicul.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu sau putut incarca vehicule:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncarcaDate()
        {
            try
            {
                List<Abonament> abonamente;
                if (cbVehicul.SelectedItem == null || cbVehicul.SelectedItem.ToString() == text)
                {
                    abonamente = AbonamentRepository.GetAll();
                }
                else
                {
                    Vehicul v = cbVehicul.SelectedItem as Vehicul;

                    if (v == null)
                    {
                        abonamente = AbonamentRepository.GetAll();
                    }
                    else
                    {
                        abonamente = AbonamentRepository.GetByVehicul(v.IdVehicul);
                    }
                }
                AfiseazaAbonamente(abonamente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare date:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AfiseazaAbonamente(List<Abonament> abonamente)
        {
            var dataPentruGrid = abonamente.Select(a => new
            {
                IdAbonament = a.IdAbonament,
                Vehicul = a.NumarInmatriculare + " — " + a.MarcaModel,
                Proprietar = a.Proprietar,
                Parcare = a.Zona + " (" + a.Tip + ")",
                Inceput = a.DataIncepere,
                Sfarsit = a.DataSfarsit,
                Luni = a.LuniAchitate,
                PretLunar = a.PretLunar,
                Total = a.SumaTotala,
                Status = a.Status
            }).ToList();

            dataGridView1.DataSource = dataPentruGrid;
            AjusteazaColoane();
        }

        private void AjusteazaColoane()
        {
            if (dataGridView1.Columns["IdAbonament"] != null) dataGridView1.Columns["IdAbonament"].Visible = false;

            if (dataGridView1.Columns["Vehicul"] != null)
                dataGridView1.Columns["Vehicul"].HeaderText = "Vehicul";

            if (dataGridView1.Columns["Proprietar"] != null)
                dataGridView1.Columns["Proprietar"].HeaderText = "Proprietar";

            if (dataGridView1.Columns["Parcare"] != null)
                dataGridView1.Columns["Parcare"].HeaderText = "Parcare";

            if (dataGridView1.Columns["Inceput"] != null)
            {
                dataGridView1.Columns["Inceput"].HeaderText = "Început";
                dataGridView1.Columns["Inceput"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dataGridView1.Columns["Inceput"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["Sfarsit"] != null)
            {
                dataGridView1.Columns["Sfarsit"].HeaderText = "Sfârșit";
                dataGridView1.Columns["Sfarsit"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dataGridView1.Columns["Sfarsit"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["Luni"] != null)
            {
                dataGridView1.Columns["Luni"].HeaderText = "Luni";
                dataGridView1.Columns["Luni"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["PretLunar"] != null)
            {
                dataGridView1.Columns["PretLunar"].HeaderText = "Preț/lună (lei)";
                dataGridView1.Columns["PretLunar"].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns["PretLunar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridView1.Columns["Total"] != null)
            {
                dataGridView1.Columns["Total"].HeaderText = "Total (lei)";
                dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns["Total"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["Total"].DefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);
            }

            if (dataGridView1.Columns["Status"] != null)
            {
                dataGridView1.Columns["Status"].HeaderText = "Status";
                dataGridView1.Columns["Status"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Status"].DefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (cbVehicul.Items.Count > 0)
            {
                cbVehicul.SelectedIndex = 0;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormAbonamentEdit f = new FormAbonamentEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                IncarcaDate();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selectati un abonament pentru modificare", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (int)dataGridView1.CurrentRow.Cells["IdAbonament"].Value;
                
            FormAbonamentEdit f = new FormAbonamentEdit(id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                IncarcaDate();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selectati un abonament pentru anulare", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["IdAbonament"].Value;

            var result = MessageBox.Show("Sunteti sigur ca doriti sa anulati acest abonament?", "Anulare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }


            try
            {
                AbonamentRepository.Delete(id);
                MessageBox.Show("Abonamentul a fost anulat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IncarcaDate();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu sa putut anula abonamentul:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAbonamenteVehicul_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selectati mai intai un abonament", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vehiculText = dataGridView1.CurrentRow.Cells["Vehicul"].Value.ToString();
            string numarInmat = vehiculText.Split(new[] { " — " }, StringSplitOptions.None)[0];

            List<Vehicul> vehicule = VehiculRepository.GetAll();
            Vehicul v = vehicule.FirstOrDefault(x => x.NumarInmatriculare == numarInmat);

            if (v == null)
            {
                MessageBox.Show("Vehicul negăsit!",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //FormAbonamenteVehicul f = new FormAbonamenteVehicul(v.IdVehicul, v.NumarInmatriculare + " — " + v.Marca + " " + v.Model);
            //f.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbVehicul_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncarcaDate();
        }
    }
}
