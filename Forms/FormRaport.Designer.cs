namespace GestionareParcari.Forms
{
    partial class FormRaport
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelButoane = new Panel();
            btnClose = new Button();
            btnExport = new Button();
            btnRefresh = new Button();
            panelStatistici = new Panel();
            lblParcareTop = new Label();
            lblMediaPlatilor = new Label();
            lblAbonamenteActive = new Label();
            lblSumaTotala = new Label();
            lblNrAbonamente = new Label();
            panelTitlu = new Panel();
            lblDataRaport = new Label();
            lblTitlu = new Label();
            dvgRaport = new DataGridView();
            panelButoane.SuspendLayout();
            panelStatistici.SuspendLayout();
            panelTitlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRaport).BeginInit();
            SuspendLayout();
            // 
            // panelButoane
            // 
            panelButoane.BackColor = Color.Gainsboro;
            panelButoane.Controls.Add(btnClose);
            panelButoane.Controls.Add(btnExport);
            panelButoane.Controls.Add(btnRefresh);
            panelButoane.Dock = DockStyle.Bottom;
            panelButoane.Location = new Point(0, 601);
            panelButoane.Name = "panelButoane";
            panelButoane.Size = new Size(934, 60);
            panelButoane.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(734, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Inchide";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnExport
            // 
            btnExport.AutoSize = true;
            btnExport.BackColor = Color.FromArgb(0, 0, 192);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = SystemColors.ControlLightLight;
            btnExport.Location = new Point(408, 16);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(118, 29);
            btnExport.TabIndex = 1;
            btnExport.Text = "Exporta in fisier";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(0, 192, 0);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(98, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 29);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelStatistici
            // 
            panelStatistici.BackColor = Color.RosyBrown;
            panelStatistici.Controls.Add(lblParcareTop);
            panelStatistici.Controls.Add(lblMediaPlatilor);
            panelStatistici.Controls.Add(lblAbonamenteActive);
            panelStatistici.Controls.Add(lblSumaTotala);
            panelStatistici.Controls.Add(lblNrAbonamente);
            panelStatistici.Dock = DockStyle.Top;
            panelStatistici.Location = new Point(0, 90);
            panelStatistici.Name = "panelStatistici";
            panelStatistici.Size = new Size(934, 180);
            panelStatistici.TabIndex = 4;
            // 
            // lblParcareTop
            // 
            lblParcareTop.AutoSize = true;
            lblParcareTop.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParcareTop.Location = new Point(20, 119);
            lblParcareTop.Name = "lblParcareTop";
            lblParcareTop.Size = new Size(337, 23);
            lblParcareTop.TabIndex = 5;
            lblParcareTop.Text = "Parcare cu cele mai multe abonamente: -";
            // 
            // lblMediaPlatilor
            // 
            lblMediaPlatilor.AutoSize = true;
            lblMediaPlatilor.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMediaPlatilor.Location = new Point(20, 67);
            lblMediaPlatilor.Name = "lblMediaPlatilor";
            lblMediaPlatilor.Size = new Size(194, 23);
            lblMediaPlatilor.TabIndex = 3;
            lblMediaPlatilor.Text = "Media platilor: 0.00 lei";
            // 
            // lblAbonamenteActive
            // 
            lblAbonamenteActive.AutoSize = true;
            lblAbonamenteActive.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbonamenteActive.Location = new Point(480, 67);
            lblAbonamenteActive.Name = "lblAbonamenteActive";
            lblAbonamenteActive.Size = new Size(193, 23);
            lblAbonamenteActive.TabIndex = 2;
            lblAbonamenteActive.Text = "Abonamente Active:  0";
            // 
            // lblSumaTotala
            // 
            lblSumaTotala.AutoSize = true;
            lblSumaTotala.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSumaTotala.Location = new Point(20, 20);
            lblSumaTotala.Name = "lblSumaTotala";
            lblSumaTotala.Size = new Size(183, 23);
            lblSumaTotala.TabIndex = 1;
            lblSumaTotala.Text = "Total incasari: 0.00 lei";
            // 
            // lblNrAbonamente
            // 
            lblNrAbonamente.AutoSize = true;
            lblNrAbonamente.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrAbonamente.Location = new Point(480, 20);
            lblNrAbonamente.Name = "lblNrAbonamente";
            lblNrAbonamente.Size = new Size(198, 23);
            lblNrAbonamente.TabIndex = 0;
            lblNrAbonamente.Text = "Nr total abonamente: 0";
            // 
            // panelTitlu
            // 
            panelTitlu.BackColor = Color.Gainsboro;
            panelTitlu.Controls.Add(lblDataRaport);
            panelTitlu.Controls.Add(lblTitlu);
            panelTitlu.Dock = DockStyle.Top;
            panelTitlu.Location = new Point(0, 0);
            panelTitlu.Name = "panelTitlu";
            panelTitlu.Size = new Size(934, 90);
            panelTitlu.TabIndex = 3;
            // 
            // lblDataRaport
            // 
            lblDataRaport.AutoSize = true;
            lblDataRaport.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDataRaport.Location = new Point(22, 55);
            lblDataRaport.Name = "lblDataRaport";
            lblDataRaport.Size = new Size(73, 17);
            lblDataRaport.TabIndex = 1;
            lblDataRaport.Text = "Generat la: ";
            // 
            // lblTitlu
            // 
            lblTitlu.AutoSize = true;
            lblTitlu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlu.Location = new Point(20, 12);
            lblTitlu.Name = "lblTitlu";
            lblTitlu.Size = new Size(423, 37);
            lblTitlu.TabIndex = 0;
            lblTitlu.Text = "RAPORT SUMAR ABONAMENTE";
            // 
            // dvgRaport
            // 
            dvgRaport.AllowUserToAddRows = false;
            dvgRaport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dvgRaport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgRaport.BackgroundColor = SystemColors.ControlLightLight;
            dvgRaport.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgRaport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgRaport.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dvgRaport.DefaultCellStyle = dataGridViewCellStyle3;
            dvgRaport.Dock = DockStyle.Fill;
            dvgRaport.EnableHeadersVisualStyles = false;
            dvgRaport.Location = new Point(0, 270);
            dvgRaport.MultiSelect = false;
            dvgRaport.Name = "dvgRaport";
            dvgRaport.ReadOnly = true;
            dvgRaport.RowHeadersVisible = false;
            dvgRaport.RowTemplate.Height = 30;
            dvgRaport.Size = new Size(934, 331);
            dvgRaport.TabIndex = 6;
            // 
            // FormRaport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 661);
            Controls.Add(dvgRaport);
            Controls.Add(panelButoane);
            Controls.Add(panelStatistici);
            Controls.Add(panelTitlu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRaport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Raport Abonamente";
            Load += FormRaport_Load;
            panelButoane.ResumeLayout(false);
            panelButoane.PerformLayout();
            panelStatistici.ResumeLayout(false);
            panelStatistici.PerformLayout();
            panelTitlu.ResumeLayout(false);
            panelTitlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRaport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButoane;
        private Button btnClose;
        private Button btnExport;
        private Button btnRefresh;
        private Panel panelStatistici;
        private Label lblParcareTop;
        private Label lblMediaPlatilor;
        private Label lblAbonamenteActive;
        private Label lblSumaTotala;
        private Label lblNrAbonamente;
        private Panel panelTitlu;
        private Label lblDataRaport;
        private Label lblTitlu;
        private DataGridView dvgRaport;
    }
}