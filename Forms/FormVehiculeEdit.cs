using GestionareParcari.DataAccess;
using GestionareParcari.Models;
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
    public partial class FormVehiculeEdit : Form
    {
        private int? idVehicul = null;
        public FormVehiculeEdit()
        {
            InitializeComponent();
            this.Text = "Adaugare vehicul";
        }

        public FormVehiculeEdit(int id) : this()
        {
            idVehicul = id;
            this.Text = "Modificare vehicul";
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            try
            {
                Vehicul v = VehiculRepository.GetById(idVehicul.Value);
                if (v == null)
                {
                    MessageBox.Show("Vehicolul nu a fost gasit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                txtNr.Text = v.NumarInmatriculare;
                txtMarca.Text = v.Marca;
                txtModel.Text = v.Model;
                txtProprietar.Text = v.Proprietar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcare:\n" + ex.Message,
                     "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool ValideazaFormular()
        {
            string mesaj;
            if (!Validator.TextObligatoriu(txtNr.Text, "Numar Inmatriculare", out mesaj))
            {
                MessageBox.Show(mesaj, "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNr.Focus();
                return false;
            }

            if (!Validator.TextObligatoriu(txtModel.Text, "Model", out mesaj))
            {
                MessageBox.Show(mesaj, "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return false;
            }
            if (!Validator.TextObligatoriu(txtMarca.Text, "Marca", out mesaj))
            {
                MessageBox.Show(mesaj, "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }
            if (!Validator.TextObligatoriu(txtProprietar.Text, "Proprietar", out mesaj))
            {
                MessageBox.Show(mesaj, "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProprietar.Focus();
                return false;
            }

            return true;
        }

        private void FormVehiculeEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicul v = new Vehicul
                {
                    NumarInmatriculare = txtNr.Text,
                    Marca = txtMarca.Text,
                    Model = txtModel.Text,
                    Proprietar = txtProprietar.Text,
                };

                if (idVehicul == null)
                {
                    VehiculRepository.Create(v);
                    MessageBox.Show("Vehiculul a fost adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    v.IdVehicul = idVehicul.Value;
                    VehiculRepository.Update(v);
                    MessageBox.Show("Vehiculul a fost modificat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
