namespace GestionareParcari.Forms
{
    partial class FormVehiculeEdit
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
            txtNr = new TextBox();
            txtMarca = new TextBox();
            label2 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtProprietar = new TextBox();
            label4 = new Label();
            btnSalveaza = new Button();
            btnAnulare = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 45);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 0;
            label1.Text = "Numar Inmatriculare*";
            // 
            // txtNr
            // 
            txtNr.Location = new Point(185, 44);
            txtNr.Name = "txtNr";
            txtNr.Size = new Size(134, 23);
            txtNr.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(111, 115);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(134, 23);
            txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 2;
            label2.Text = "Marca*";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(109, 192);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(134, 23);
            txtModel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 192);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 4;
            label3.Text = "Model*";
            // 
            // txtProprietar
            // 
            txtProprietar.Location = new Point(111, 288);
            txtProprietar.Name = "txtProprietar";
            txtProprietar.Size = new Size(134, 23);
            txtProprietar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 294);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 6;
            label4.Text = "Proprietar*";
            // 
            // btnSalveaza
            // 
            btnSalveaza.AutoSize = true;
            btnSalveaza.BackColor = Color.Green;
            btnSalveaza.FlatStyle = FlatStyle.Flat;
            btnSalveaza.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalveaza.ForeColor = SystemColors.ControlLightLight;
            btnSalveaza.Location = new Point(53, 394);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(89, 33);
            btnSalveaza.TabIndex = 8;
            btnSalveaza.Text = "Salveaza";
            btnSalveaza.UseVisualStyleBackColor = false;
            btnSalveaza.Click += btnSalveaza_Click;
            // 
            // btnAnulare
            // 
            btnAnulare.AutoSize = true;
            btnAnulare.BackColor = Color.FromArgb(192, 0, 0);
            btnAnulare.FlatStyle = FlatStyle.Flat;
            btnAnulare.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnulare.ForeColor = SystemColors.ControlLightLight;
            btnAnulare.Location = new Point(230, 394);
            btnAnulare.Name = "btnAnulare";
            btnAnulare.Size = new Size(93, 33);
            btnAnulare.TabIndex = 9;
            btnAnulare.Text = "Anuleaza";
            btnAnulare.UseVisualStyleBackColor = false;
            btnAnulare.Click += btnAnulare_Click;
            // 
            // FormVehiculeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 461);
            Controls.Add(btnAnulare);
            Controls.Add(btnSalveaza);
            Controls.Add(txtProprietar);
            Controls.Add(label4);
            Controls.Add(txtModel);
            Controls.Add(label3);
            Controls.Add(txtMarca);
            Controls.Add(label2);
            Controls.Add(txtNr);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVehiculeEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adauga Vehicul";
            Load += FormVehiculeEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNr;
        private TextBox txtMarca;
        private Label label2;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtProprietar;
        private Label label4;
        private Button btnSalveaza;
        private Button btnAnulare;
    }
}