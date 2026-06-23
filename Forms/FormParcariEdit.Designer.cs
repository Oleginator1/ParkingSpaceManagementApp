namespace GestionareParcari.Forms
{
    partial class FormParcariEdit
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbZona = new ComboBox();
            cbTip = new ComboBox();
            txtNrL = new TextBox();
            txtPret = new TextBox();
            btnAnulare = new Button();
            btnSalveaza = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Zona*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 126);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 1;
            label2.Text = "Numar Locuri Parcare*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 210);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Pret Lunar*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 298);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 3;
            label4.Text = "Tip*";
            // 
            // cbZona
            // 
            cbZona.FormattingEnabled = true;
            cbZona.Location = new Point(127, 45);
            cbZona.Name = "cbZona";
            cbZona.Size = new Size(137, 23);
            cbZona.TabIndex = 4;
           
            // 
            // cbTip
            // 
            cbTip.FormattingEnabled = true;
            cbTip.Location = new Point(99, 300);
            cbTip.Name = "cbTip";
            cbTip.Size = new Size(137, 23);
            cbTip.TabIndex = 5;
         
            // 
            // txtNrL
            // 
            txtNrL.Location = new Point(225, 128);
            txtNrL.Name = "txtNrL";
            txtNrL.Size = new Size(100, 23);
            txtNrL.TabIndex = 6;
            // 
            // txtPret
            // 
            txtPret.Location = new Point(155, 212);
            txtPret.Name = "txtPret";
            txtPret.Size = new Size(100, 23);
            txtPret.TabIndex = 7;
            // 
            // btnAnulare
            // 
            btnAnulare.AutoSize = true;
            btnAnulare.BackColor = Color.FromArgb(192, 0, 0);
            btnAnulare.FlatStyle = FlatStyle.Flat;
            btnAnulare.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnulare.ForeColor = SystemColors.ControlLightLight;
            btnAnulare.Location = new Point(233, 388);
            btnAnulare.Name = "btnAnulare";
            btnAnulare.Size = new Size(93, 33);
            btnAnulare.TabIndex = 11;
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
            btnSalveaza.Location = new Point(56, 388);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(89, 33);
            btnSalveaza.TabIndex = 10;
            btnSalveaza.Text = "Salveaza";
            btnSalveaza.UseVisualStyleBackColor = false;
            btnSalveaza.Click += btnSalveaza_Click;
            // 
            // FormParcariEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 461);
            Controls.Add(btnAnulare);
            Controls.Add(btnSalveaza);
            Controls.Add(txtPret);
            Controls.Add(txtNrL);
            Controls.Add(cbTip);
            Controls.Add(cbZona);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormParcariEdit";
            Text = "FormParcariEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbZona;
        private ComboBox cbTip;
        private TextBox txtNrL;
        private TextBox txtPret;
        private Button btnAnulare;
        private Button btnSalveaza;
    }
}