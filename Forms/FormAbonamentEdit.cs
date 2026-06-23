using GestionareParcari.DataAccess;
using GestionareParcari.Models;
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
    public partial class FormAbonamentEdit : Form
    {
        private int? idAbonament = null;
        private decimal pretLunarCurent = 0;
        public FormAbonamentEdit()
        {
            InitializeComponent();
            this.Text = "Adaugare Abonament";
            dtpDataIncepere.Value = DateTime.Today;
        }

        public FormAbonamentEdit(int id) : this()
        {
            this.Text = "Modificare Abonament";
            idAbonament = id;
        }

        private void FormAbonamentEdit_Load(object sender, EventArgs e)
        {
            IncarcaVehicule();
            IncarcaParcari();

            if (idAbonament != null)
            {
                IncarcaDate();
            }
            else
            {
                ActualizeazaCalcule();
            }
        }

        private void IncarcaVehicule()
        {
            try
            {
                cbVehicul.Items.Clear();
                List<Vehicul> vehicule = VehiculRepository.GetAll();
                foreach (var vehicul in vehicule)
                {
                    cbVehicul.Items.Add(vehicul);
                }
                if (cbVehicul.Items.Count > 0)
                {
                    cbVehicul.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare vehicule:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void IncarcaParcari()
        {
            try
            {
                cbParcare.Items.Clear();
                List<Parcare> parcari = ParcareRepository.GetAll();
                foreach (var p in parcari)
                {
                    cbParcare.Items.Add(p);
                }
                if (cbParcare.Items.Count > 0)
                {
                    cbParcare.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare parcari:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncarcaDate()
        {
            try
            {
                Abonament a = AbonamentRepository.GetById(idAbonament.Value);
                if (a == null)
                {
                    MessageBox.Show("Abonamentul nu a fost gasit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                foreach (object item in cbVehicul.Items)
                {
                    Vehicul v = item as Vehicul;
                    if (v != null && v.IdVehicul == a.IdVehicul)
                    {
                        cbVehicul.SelectedItem = item;
                        break;
                    }
                }
                foreach (object item in cbParcare.Items)
                {
                    Parcare p = item as Parcare;
                    if (p != null && p.IdParcare == a.IdParcare)
                    {
                        cbParcare.SelectedItem = item;
                        break;
                    }
                }

                dtpDataIncepere.Value = a.DataIncepere;
                numLuni.Value = a.LuniAchitate;
                ActualizeazaCalcule();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare date:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaCalcule()
        {
            Parcare p = cbParcare.SelectedItem as Parcare;
            if (p != null)
            {
                pretLunarCurent = p.PretLunar;
                lblPretLunar.Text = pretLunarCurent.ToString("N2") + " lei";
            }
            else
            {
                pretLunarCurent = 0;
                lblPretLunar.Text = "0.00 lei";
            }

            DateTime dataSfarsit = dtpDataIncepere.Value.AddMonths((int)numLuni.Value);
            lblDataSfarsit.Text = dataSfarsit.ToString("dd.MM.yyyy");

            decimal total = pretLunarCurent * numLuni.Value;
            lblTotal.Text = total.ToString("N2") + " lei";
        }

        private bool ValideazaFormular()
        {
            if (cbVehicul.SelectedItem == null)
            {
                MessageBox.Show("Selectati un vehicul", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbVehicul.Focus();
                return false;
            }

            if (cbParcare.SelectedItem == null)
            {
                MessageBox.Show("Selectati o parcare", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbParcare.Focus();
                return false;
            }

            if (numLuni.Value <= 0)
            {
                MessageBox.Show("Numarul de luni trebuie sa fie mai mare ca 0!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numLuni.Focus();
                return false;
            }

            Vehicul vehiculSelectat = cbVehicul.SelectedItem as Vehicul;
            DateTime dataIncepere = dtpDataIncepere.Value.Date;
            int luni = (int)numLuni.Value;

            bool exista = AbonamentRepository.ExistaSuprapunere(vehiculSelectat.IdVehicul, dataIncepere, luni, idAbonament);

            if (exista)
            {
                MessageBox.Show(
                   "Există deja un abonament pentru acest vehicul " +
                   "care se suprapune cu perioada selectată!\n\n" +
                   "Verificați abonamentele existente ale vehiculului " +
                   "și alegeți altă perioadă.",
                   "Conflict abonament",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if(!ValideazaFormular()) { return; }

            try
            {
                Vehicul v = cbVehicul.SelectedItem as Vehicul;
                Parcare p = cbParcare.SelectedItem as Parcare;

                Abonament a = new Abonament
                {
                    IdVehicul = v.IdVehicul,
                    IdParcare = p.IdParcare,
                    DataIncepere = dtpDataIncepere.Value.Date,
                    LuniAchitate = (int)numLuni.Value
                };

                if (idAbonament == null)
                {
                    AbonamentRepository.Create(a);
                    MessageBox.Show("Abonament emis cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AbonamentRepository.Update(a);
                    MessageBox.Show("Abonament actualizat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea datelor:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbVehicul_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizeazaCalcule();
        }

        private void cbParcare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizeazaCalcule();
        }

        private void numLuni_ValueChanged(object sender, EventArgs e)
        {
            ActualizeazaCalcule();
        }
    }
}
