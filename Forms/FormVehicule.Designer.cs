namespace GestionareParcari.Forms
{
    partial class FormVehicule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnReset = new Button();
            txtOwner = new TextBox();
            label2 = new Label();
            txtNr = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            btnSterge = new Button();
            btnModifica = new Button();
            btnAdauga = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(txtOwner);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNr);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 80);
            panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.BackColor = Color.FromArgb(0, 192, 0);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(745, 25);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 33);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reseteaza";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(566, 31);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(122, 23);
            txtOwner.TabIndex = 3;
            txtOwner.TextChanged += txtOwner_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 29);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 2;
            label2.Text = "Cauta Proprietar:";
            // 
            // txtNr
            // 
            txtNr.Location = new Point(259, 29);
            txtNr.Name = "txtNr";
            txtNr.Size = new Size(122, 23);
            txtNr.TabIndex = 1;
            txtNr.TextChanged += txtNr_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(222, 21);
            label1.TabIndex = 0;
            label1.Text = "Cauta Numar Inmatriculare:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnSterge);
            panel2.Controls.Add(btnModifica);
            panel2.Controls.Add(btnAdauga);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 501);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 60);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.FromArgb(0, 64, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(697, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 33);
            btnClose.TabIndex = 8;
            btnClose.Text = "Inchide";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSterge
            // 
            btnSterge.AutoSize = true;
            btnSterge.BackColor = Color.FromArgb(192, 0, 0);
            btnSterge.FlatStyle = FlatStyle.Flat;
            btnSterge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSterge.ForeColor = SystemColors.ControlLightLight;
            btnSterge.Location = new Point(479, 15);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(132, 33);
            btnSterge.TabIndex = 7;
            btnSterge.Text = "Sterge Vehicul";
            btnSterge.UseVisualStyleBackColor = false;
            btnSterge.Click += btnSterge_Click;
            // 
            // btnModifica
            // 
            btnModifica.AutoSize = true;
            btnModifica.BackColor = Color.Yellow;
            btnModifica.FlatStyle = FlatStyle.Flat;
            btnModifica.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifica.ForeColor = Color.ForestGreen;
            btnModifica.Location = new Point(259, 15);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(151, 33);
            btnModifica.TabIndex = 6;
            btnModifica.Text = "Modifica Vehicul";
            btnModifica.UseVisualStyleBackColor = false;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnAdauga
            // 
            btnAdauga.AutoSize = true;
            btnAdauga.BackColor = Color.FromArgb(192, 0, 192);
            btnAdauga.FlatStyle = FlatStyle.Flat;
            btnAdauga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdauga.ForeColor = SystemColors.ControlLightLight;
            btnAdauga.Location = new Point(49, 15);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(142, 33);
            btnAdauga.TabIndex = 5;
            btnAdauga.Text = "Adauga Vehicul";
            btnAdauga.UseVisualStyleBackColor = false;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(884, 421);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // FormVehicule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormVehicule";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestionare Vehicule";
            Load += FormVehicule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReset;
        private TextBox txtOwner;
        private Label label2;
        private TextBox txtNr;
        private Label label1;
        private Panel panel2;
        private Button btnClose;
        private Button btnSterge;
        private Button btnModifica;
        private Button btnAdauga;
        private DataGridView dataGridView1;
    }
}