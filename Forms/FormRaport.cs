using GestionareParcari.DataAccess;
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
    public partial class FormRaport : Form
    {
        private decimal sumaTotala = 0;
        private decimal mediaPlatilor = 0;
        private int nrAbonamente = 0;
        private int nrAbonamenteActive = 0;
        private string parcareTop = "—";
        private List<VehiculRaport> vehicule = new List<VehiculRaport>();
        public FormRaport()
        {
            InitializeComponent();
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {
            ConfigureazaGrid();
            GenereazaRaport();
        }

        private void ConfigureazaGrid()
        {
            dvgRaport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgRaport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GenereazaRaport()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                vehicule = RaportRepository.GetVehiculCuTotaluri();
                sumaTotala = RaportRepository.GetSumaTotalIncasata();
                mediaPlatilor = RaportRepository.GetMediaPlatilor();
                nrAbonamente = RaportRepository.GetNumarTotalAbonamente();
                nrAbonamenteActive = RaportRepository.GetNumarAbonamenteActive();
                parcareTop = RaportRepository.GetParcariCuCeleMaiMulteAbonamente();

                AfiseazaGrid();
                AfiseazaStatistici();

                lblDataRaport.Text = "Generat la: " +
                   DateTime.Now.ToString("dddd, dd MMMM yyyy, HH:mm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la generarea raportului:\n" + ex.Message,
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void AfiseazaGrid()
        {
            dvgRaport.DataSource = vehicule;

            if (dvgRaport.Columns["NumarInmatriculare"] != null)
                dvgRaport.Columns["NumarInmatriculare"].HeaderText = "Nr. înmatriculare";

            if (dvgRaport.Columns["MarcaModel"] != null)
                dvgRaport.Columns["MarcaModel"].HeaderText = "Marcă și model";

            if (dvgRaport.Columns["Proprietar"] != null)
                dvgRaport.Columns["Proprietar"].HeaderText = "Proprietar";

            if (dvgRaport.Columns["NrAbonamente"] != null)
            {
                dvgRaport.Columns["NrAbonamente"].HeaderText = "Nr. abonamente";
                dvgRaport.Columns["NrAbonamente"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            if (dvgRaport.Columns["SumaAchitata"] != null)
            {
                dvgRaport.Columns["SumaAchitata"].HeaderText = "Suma achitată (lei)";
                dvgRaport.Columns["SumaAchitata"].DefaultCellStyle.Format = "N2";
                dvgRaport.Columns["SumaAchitata"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dvgRaport.Columns["SumaAchitata"].DefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);
                dvgRaport.Columns["SumaAchitata"].DefaultCellStyle.ForeColor =
                    Color.FromArgb(40, 167, 69);
            }
        }

        private void AfiseazaStatistici()
        {
            lblSumaTotala.Text = "Suma totală încasată: " + sumaTotala.ToString("N2") + " lei";
            lblNrAbonamente.Text = "Total abonamente: " + nrAbonamente;
            lblMediaPlatilor.Text = "Media plăților: " + mediaPlatilor.ToString("N2") + " lei";
            lblAbonamenteActive.Text = "Abonamente active acum: " + nrAbonamenteActive;
            lblParcareTop.Text = "Parcare cu cele mai multe abonamente: " + parcareTop;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenereazaRaport();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Fișier text (*.txt)|*.txt|Toate fișierele (*.*)|*.*",
                FileName = "Raport_Parcari_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
                Title = "Salvare raport"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("═══════════════════════════════════════════════════════");
                sb.AppendLine("           RAPORT PARCĂRI MUNICIPALE                  ");
                sb.AppendLine("═══════════════════════════════════════════════════════");
                sb.AppendLine();
                sb.AppendLine("Generat la: " + DateTime.Now.ToString("dddd, dd MMMM yyyy, HH:mm"));
                sb.AppendLine();
                sb.AppendLine("─── STATISTICI GENERALE ──────────────────────────────");
                sb.AppendLine();
                sb.AppendLine("  Suma totală încasată:       " + sumaTotala.ToString("N2").PadLeft(15) + " lei");
                sb.AppendLine("  Total abonamente:           " + nrAbonamente.ToString().PadLeft(15));
                sb.AppendLine("  Abonamente active acum:     " + nrAbonamenteActive.ToString().PadLeft(15));
                sb.AppendLine("  Media plăților:             " + mediaPlatilor.ToString("N2").PadLeft(15) + " lei");
                sb.AppendLine("  Parcare cu cele mai multe abonamente: " + parcareTop);
                sb.AppendLine();
                sb.AppendLine("─── PLĂȚI PE VEHICULE ────────────────────────────────");
                sb.AppendLine();
                sb.AppendLine("  Nr. înmat.  Marcă/Model              Proprietar              Abon.    Total (lei)");
                sb.AppendLine("  " + new string('─', 90));

                foreach (VehiculRaport v in vehicule)
                {
                    string nrInmat = v.NumarInmatriculare.PadRight(10);
                    string marca = (v.MarcaModel.Length > 25
                        ? v.MarcaModel.Substring(0, 25)
                        : v.MarcaModel).PadRight(25);
                    string prop = (v.Proprietar.Length > 22
                        ? v.Proprietar.Substring(0, 22)
                        : v.Proprietar).PadRight(22);
                    string nrAbon = v.NumarAbonamente.ToString().PadLeft(5);
                    string total = v.SumaAchitata.ToString("N2").PadLeft(13);
                    sb.AppendLine("  " + nrInmat + "  " + marca + "  " + prop + "  " + nrAbon + "  " + total);
                }

                sb.AppendLine();
                sb.AppendLine("═══════════════════════════════════════════════════════");
                sb.AppendLine("                Sfârșitul raportului                   ");
                sb.AppendLine("═══════════════════════════════════════════════════════");

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                var rezultat = MessageBox.Show(
                    "Raport exportat cu succes!\n\n" +
                    "Locație: " + sfd.FileName + "\n\n" +
                    "Doriți să deschideți fișierul?",
                    "Succes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (rezultat == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Eroare la exportul raportului:\n" + ex.Message,
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
