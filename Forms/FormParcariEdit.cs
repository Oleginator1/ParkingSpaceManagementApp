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
    public partial class FormParcariEdit : Form
    {
        private int? idParcare = null;
        public FormParcariEdit()
        {
            InitializeComponent();
            this.Text = "Adauga Parcare";
            IncarcaZone();
            IncarcaTipuri();
        }

        public FormParcariEdit(int id) : this() 
        {
            this.Text = "Modifica Parcare";
            idParcare = id;
            IncarcaDate();
        }

        private void IncarcaZone()
        {
            try
            {
                List<string> z = ParcareRepository.GetZona();
                cbZona.Items.Clear();
                foreach (string z2 in z)
                {
                    cbZona.Items.Add(z2);
                }
                cbZona.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare zone", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncarcaTipuri()
        {
            try
            {
                List<string> t = ParcareRepository.GetTip();
                cbTip.Items.Clear();
                foreach (string t2 in t)
                {
                    cbTip.Items.Add(t2);
                }
                cbTip.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare tipuri", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncarcaDate()
        {
            try
            {
                Parcare p = ParcareRepository.GetById(idParcare.Value);
                if (p == null)
                {
                    MessageBox.Show("Parcarea nu a fost gasita", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                cbZona.Text = p.Zona;
                txtNrL.Text = p.NumarLocuri.ToString();
                txtPret.Text = p.PretLunar.ToString();
                cbZona.Text = p.Tip;
            }
            catch (Exception e)
            {
                MessageBox.Show("Eroare la incarcare date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValideazaFormular(out int nr, out decimal pret)
        {
            string mesaj;
            nr = 0;
            pret = 0;
            if (!Validator.TextObligatoriu(cbZona.Text, "Zona", out mesaj))
            {
                MessageBox.Show(mesaj, "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validator.NumarIntPozitiv(txtNrL.Text, "Numar Locuri", out nr, out mesaj))
            {
                MessageBox.Show(mesaj, "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.NumarDecimalPozitiv(txtPret.Text, "Pret Lunar", out pret, out mesaj))
            {
                MessageBox.Show(mesaj, "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }      

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            int nr;
            decimal pret;
            if (!ValideazaFormular(out nr, out pret)) return;

            try
            {
                Parcare p = new Parcare
                {
                    Zona = cbZona.Text,
                    NumarLocuri = nr,
                    PretLunar = pret,
                    Tip = cbTip.Text
                };

                if (idParcare != null)
                {
                    p.IdParcare = idParcare.Value;
                    ParcareRepository.Update(p);
                    MessageBox.Show("Parcare actualizata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ParcareRepository.Create(p);
                    MessageBox.Show("Parcare creata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
