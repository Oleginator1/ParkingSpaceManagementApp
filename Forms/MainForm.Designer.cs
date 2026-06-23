namespace GestionareParcari.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gestionareToolStripMenuItem = new ToolStripMenuItem();
            vehiculeButton = new ToolStripMenuItem();
            parcariButton = new ToolStripMenuItem();
            abonamenteButton = new ToolStripMenuItem();
            rapoarteToolStripMenuItem = new ToolStripMenuItem();
            raportVehiculeToolStripMenuItem = new ToolStripMenuItem();
            iesireToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRaport = new Button();
            btnAbonamente = new Button();
            btnParcari = new Button();
            btnVehicule = new Button();
            panel1 = new Panel();
            statusLabel1 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionareToolStripMenuItem, rapoarteToolStripMenuItem, iesireToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionareToolStripMenuItem
            // 
            gestionareToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vehiculeButton, parcariButton, abonamenteButton });
            gestionareToolStripMenuItem.Name = "gestionareToolStripMenuItem";
            gestionareToolStripMenuItem.Size = new Size(75, 20);
            gestionareToolStripMenuItem.Text = "Gestionare";
            // 
            // vehiculeButton
            // 
            vehiculeButton.Name = "vehiculeButton";
            vehiculeButton.Size = new Size(143, 22);
            vehiculeButton.Text = "Vehicule";
            vehiculeButton.Click += vehiculeButton_Click;
            // 
            // parcariButton
            // 
            parcariButton.Name = "parcariButton";
            parcariButton.Size = new Size(143, 22);
            parcariButton.Text = "Parcari";
            parcariButton.Click += parcariButton_Click;
            // 
            // abonamenteButton
            // 
            abonamenteButton.Name = "abonamenteButton";
            abonamenteButton.Size = new Size(143, 22);
            abonamenteButton.Text = "Abonamente";
            abonamenteButton.Click += abonamenteButton_Click;
            // 
            // rapoarteToolStripMenuItem
            // 
            rapoarteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { raportVehiculeToolStripMenuItem });
            rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            rapoarteToolStripMenuItem.Size = new Size(66, 20);
            rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // raportVehiculeToolStripMenuItem
            // 
            raportVehiculeToolStripMenuItem.Name = "raportVehiculeToolStripMenuItem";
            raportVehiculeToolStripMenuItem.Size = new Size(156, 22);
            raportVehiculeToolStripMenuItem.Text = "Raport Vehicule";
            raportVehiculeToolStripMenuItem.Click += raportVehiculeToolStripMenuItem_Click;
            // 
            // iesireToolStripMenuItem
            // 
            iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            iesireToolStripMenuItem.Size = new Size(46, 20);
            iesireToolStripMenuItem.Text = "Iesire";
            iesireToolStripMenuItem.Click += iesireToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRaport, 1, 1);
            tableLayoutPanel1.Controls.Add(btnAbonamente, 0, 1);
            tableLayoutPanel1.Controls.Add(btnParcari, 1, 0);
            tableLayoutPanel1.Controls.Add(btnVehicule, 0, 0);
            tableLayoutPanel1.Location = new Point(34, 134);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(807, 303);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnRaport
            // 
            btnRaport.AutoSize = true;
            btnRaport.BackColor = Color.DeepSkyBlue;
            btnRaport.Dock = DockStyle.Fill;
            btnRaport.FlatStyle = FlatStyle.Flat;
            btnRaport.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaport.ForeColor = SystemColors.ControlLightLight;
            btnRaport.Location = new Point(406, 154);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(398, 146);
            btnRaport.TabIndex = 3;
            btnRaport.Text = "Raport";
            btnRaport.UseVisualStyleBackColor = false;
            btnRaport.Click += btnRaport_Click;
            // 
            // btnAbonamente
            // 
            btnAbonamente.AutoSize = true;
            btnAbonamente.BackColor = Color.DeepSkyBlue;
            btnAbonamente.Dock = DockStyle.Fill;
            btnAbonamente.FlatStyle = FlatStyle.Flat;
            btnAbonamente.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            btnAbonamente.ForeColor = SystemColors.ControlLightLight;
            btnAbonamente.Location = new Point(3, 154);
            btnAbonamente.Name = "btnAbonamente";
            btnAbonamente.Size = new Size(397, 146);
            btnAbonamente.TabIndex = 2;
            btnAbonamente.Text = "Abonamente";
            btnAbonamente.UseVisualStyleBackColor = false;
            btnAbonamente.Click += btnAbonamente_Click;
            // 
            // btnParcari
            // 
            btnParcari.AutoSize = true;
            btnParcari.BackColor = Color.DeepSkyBlue;
            btnParcari.Dock = DockStyle.Fill;
            btnParcari.FlatStyle = FlatStyle.Flat;
            btnParcari.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParcari.ForeColor = SystemColors.ControlLightLight;
            btnParcari.Location = new Point(406, 3);
            btnParcari.Name = "btnParcari";
            btnParcari.Size = new Size(398, 145);
            btnParcari.TabIndex = 1;
            btnParcari.Text = "Parcari";
            btnParcari.UseVisualStyleBackColor = false;
            btnParcari.Click += btnParcari_Click;
            // 
            // btnVehicule
            // 
            btnVehicule.AutoSize = true;
            btnVehicule.BackColor = Color.DeepSkyBlue;
            btnVehicule.Dock = DockStyle.Fill;
            btnVehicule.FlatStyle = FlatStyle.Flat;
            btnVehicule.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehicule.ForeColor = SystemColors.ControlLightLight;
            btnVehicule.Location = new Point(3, 3);
            btnVehicule.Name = "btnVehicule";
            btnVehicule.Size = new Size(397, 145);
            btnVehicule.TabIndex = 0;
            btnVehicule.Text = "Vehicule";
            btnVehicule.UseVisualStyleBackColor = false;
            btnVehicule.Click += btnVehicule_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(statusLabel1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 84);
            panel1.TabIndex = 2;
            // 
            // statusLabel1
            // 
            statusLabel1.AutoSize = true;
            statusLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel1.ForeColor = SystemColors.ControlLightLight;
            statusLabel1.Location = new Point(12, 54);
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new Size(57, 21);
            statusLabel1.TabIndex = 0;
            statusLabel1.Text = "label1";
            statusLabel1.Click += statusLabel1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(147, 14);
            label1.Name = "label1";
            label1.Size = new Size(619, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistem de gestionare Parcari Vehicule si Abonamente";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionare Parcari";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionareToolStripMenuItem;
        private ToolStripMenuItem vehiculeButton;
        private ToolStripMenuItem parcariButton;
        private ToolStripMenuItem abonamenteButton;
        private ToolStripMenuItem rapoarteToolStripMenuItem;
        private ToolStripMenuItem raportVehiculeToolStripMenuItem;
        private ToolStripMenuItem iesireToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnVehicule;
        private Panel panel1;
        private Label statusLabel1;
        private Label label1;
        private Button btnRaport;
        private Button btnAbonamente;
        private Button btnParcari;
    }
}