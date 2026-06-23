namespace GestionareParcari.Forms
{
    partial class FormAbonamentEdit
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
            label1 = new Label();
            cbVehicul = new ComboBox();
            cbParcare = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lblPretLunar = new Label();
            label4 = new Label();
            dtpDataIncepere = new DateTimePicker();
            label5 = new Label();
            numLuni = new NumericUpDown();
            lblDataSfarsit = new Label();
            label7 = new Label();
            lblTotal = new Label();
            label9 = new Label();
            btnAnulare = new Button();
            btnSalveaza = new Button();
            ((System.ComponentModel.ISupportInitialize)numLuni).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 0;
            label1.Text = "Vehicul*";
            // 
            // cbVehicul
            // 
            cbVehicul.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehicul.FormattingEnabled = true;
            cbVehicul.Location = new Point(111, 31);
            cbVehicul.Name = "cbVehicul";
            cbVehicul.Size = new Size(187, 23);
            cbVehicul.TabIndex = 1;
            cbVehicul.SelectedIndexChanged += cbVehicul_SelectedIndexChanged;
            // 
            // cbParcare
            // 
            cbParcare.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParcare.FormattingEnabled = true;
            cbParcare.Location = new Point(111, 91);
            cbParcare.Name = "cbParcare";
            cbParcare.Size = new Size(187, 23);
            cbParcare.TabIndex = 3;
            cbParcare.SelectedIndexChanged += cbParcare_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 92);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 2;
            label2.Text = "Parcare*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 148);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 4;
            label3.Text = "Pret Lunar*";
            // 
            // lblPretLunar
            // 
            lblPretLunar.AutoSize = true;
            lblPretLunar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPretLunar.Location = new Point(111, 148);
            lblPretLunar.Name = "lblPretLunar";
            lblPretLunar.Size = new Size(52, 17);
            lblPretLunar.TabIndex = 5;
            lblPretLunar.Text = "0.00 lei";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 206);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 6;
            label4.Text = "Data Incepere*";
            // 
            // dtpDataIncepere
            // 
            dtpDataIncepere.Format = DateTimePickerFormat.Short;
            dtpDataIncepere.Location = new Point(131, 206);
            dtpDataIncepere.Name = "dtpDataIncepere";
            dtpDataIncepere.Size = new Size(167, 23);
            dtpDataIncepere.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 268);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 8;
            label5.Text = "Luni Achitate*";
            // 
            // numLuni
            // 
            numLuni.Location = new Point(131, 268);
            numLuni.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLuni.Name = "numLuni";
            numLuni.Size = new Size(102, 23);
            numLuni.TabIndex = 9;
            numLuni.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numLuni.ValueChanged += numLuni_ValueChanged;
            // 
            // lblDataSfarsit
            // 
            lblDataSfarsit.AutoSize = true;
            lblDataSfarsit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataSfarsit.Location = new Point(111, 318);
            lblDataSfarsit.Name = "lblDataSfarsit";
            lblDataSfarsit.Size = new Size(13, 17);
            lblDataSfarsit.TabIndex = 11;
            lblDataSfarsit.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 318);
            label7.Name = "label7";
            label7.Size = new Size(86, 17);
            label7.TabIndex = 10;
            label7.Text = "Data Sfarsit*";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(111, 368);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 17);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0.00 lei";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 368);
            label9.Name = "label9";
            label9.Size = new Size(90, 17);
            label9.TabIndex = 12;
            label9.Text = "Suma Totala*";
            // 
            // btnAnulare
            // 
            btnAnulare.AutoSize = true;
            btnAnulare.BackColor = Color.FromArgb(192, 0, 0);
            btnAnulare.FlatStyle = FlatStyle.Flat;
            btnAnulare.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnulare.ForeColor = SystemColors.ControlLightLight;
            btnAnulare.Location = new Point(251, 402);
            btnAnulare.Name = "btnAnulare";
            btnAnulare.Size = new Size(93, 33);
            btnAnulare.TabIndex = 15;
            btnAnulare.Text = "Anuleaza";
            btnAnulare.UseVisualStyleBackColor = false;
            btnAnulare.Click += btnAnulare_Click;
            // 
            // btnSalveaza
            // 
            btnSalveaza.AutoSize = true;
            btnSalveaza.BackColor = Color.Green;
            btnSalveaza.FlatStyle = FlatStyle.Flat;
            btnSalveaza.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalveaza.ForeColor = SystemColors.ControlLightLight;
            btnSalveaza.Location = new Point(74, 402);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(89, 33);
            btnSalveaza.TabIndex = 14;
            btnSalveaza.Text = "Salveaza";
            btnSalveaza.UseVisualStyleBackColor = false;
            btnSalveaza.Click += btnSalveaza_Click;
            // 
            // FormAbonamentEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 461);
            Controls.Add(btnAnulare);
            Controls.Add(btnSalveaza);
            Controls.Add(lblTotal);
            Controls.Add(label9);
            Controls.Add(lblDataSfarsit);
            Controls.Add(label7);
            Controls.Add(numLuni);
            Controls.Add(label5);
            Controls.Add(dtpDataIncepere);
            Controls.Add(label4);
            Controls.Add(lblPretLunar);
            Controls.Add(label3);
            Controls.Add(cbParcare);
            Controls.Add(label2);
            Controls.Add(cbVehicul);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbonamentEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAbonamentEdit";
            Load += FormAbonamentEdit_Load;
            ((System.ComponentModel.ISupportInitialize)numLuni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbVehicul;
        private ComboBox cbParcare;
        private Label label2;
        private Label label3;
        private Label lblPretLunar;
        private Label label4;
        private DateTimePicker dtpDataIncepere;
        private Label label5;
        private NumericUpDown numLuni;
        private Label lblDataSfarsit;
        private Label label7;
        private Label lblTotal;
        private Label label9;
        private Button btnAnulare;
        private Button btnSalveaza;
    }
}