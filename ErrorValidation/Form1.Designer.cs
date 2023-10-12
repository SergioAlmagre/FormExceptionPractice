namespace ErrorValidation
{
    partial class PersonalData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblSecondName = new Label();
            lblMovilNumber = new Label();
            lblEmail = new Label();
            lblCarPlate = new Label();
            lblNif = new Label();
            lblAccountNumber = new Label();
            btnValidate = new Button();
            txtFirsName = new MaskedTextBox();
            txtSecondName = new MaskedTextBox();
            txtMovil = new MaskedTextBox();
            txtEmail = new MaskedTextBox();
            txtCarPlate = new MaskedTextBox();
            txtNif = new MaskedTextBox();
            txtAccountNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(47, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 15);
            lblName.TabIndex = 0;
            lblName.Text = "First name:";
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Location = new Point(47, 80);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(82, 15);
            lblSecondName.TabIndex = 1;
            lblSecondName.Text = "Second name:";
            // 
            // lblMovilNumber
            // 
            lblMovilNumber.AutoSize = true;
            lblMovilNumber.Location = new Point(47, 118);
            lblMovilNumber.Name = "lblMovilNumber";
            lblMovilNumber.Size = new Size(85, 15);
            lblMovilNumber.TabIndex = 2;
            lblMovilNumber.Text = "Movil number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(47, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblCarPlate
            // 
            lblCarPlate.AutoSize = true;
            lblCarPlate.Location = new Point(47, 204);
            lblCarPlate.Name = "lblCarPlate";
            lblCarPlate.Size = new Size(57, 15);
            lblCarPlate.TabIndex = 4;
            lblCarPlate.Text = "Car plate:";
            lblCarPlate.Click += label1_Click;
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Location = new Point(47, 249);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(28, 15);
            lblNif.TabIndex = 5;
            lblNif.Text = "NIF:";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(47, 294);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(97, 15);
            lblAccountNumber.TabIndex = 6;
            lblAccountNumber.Text = "Account number";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(47, 340);
            btnValidate.Margin = new Padding(3, 2, 3, 2);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(287, 22);
            btnValidate.TabIndex = 14;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // txtFirsName
            // 
            txtFirsName.Location = new Point(179, 36);
            txtFirsName.Margin = new Padding(3, 2, 3, 2);
            txtFirsName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            txtFirsName.Name = "txtFirsName";
            txtFirsName.Size = new Size(155, 23);
            txtFirsName.TabIndex = 15;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(179, 77);
            txtSecondName.Margin = new Padding(3, 2, 3, 2);
            txtSecondName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(155, 23);
            txtSecondName.TabIndex = 16;
            // 
            // txtMovil
            // 
            txtMovil.Location = new Point(179, 116);
            txtMovil.Margin = new Padding(3, 2, 3, 2);
            txtMovil.Mask = "000,000,000";
            txtMovil.Name = "txtMovil";
            txtMovil.Size = new Size(155, 23);
            txtMovil.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 159);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtCarPlate
            // 
            txtCarPlate.Location = new Point(179, 199);
            txtCarPlate.Margin = new Padding(3, 2, 3, 2);
            txtCarPlate.Name = "txtCarPlate";
            txtCarPlate.Size = new Size(155, 23);
            txtCarPlate.TabIndex = 19;
            // 
            // txtNif
            // 
            txtNif.Location = new Point(179, 247);
            txtNif.Margin = new Padding(3, 2, 3, 2);
            txtNif.Mask = "00000000-L";
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(155, 23);
            txtNif.TabIndex = 20;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(179, 289);
            txtAccountNumber.Margin = new Padding(3, 2, 3, 2);
            txtAccountNumber.Mask = "ES00-0000-0000-00-0000000000";
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(155, 23);
            txtAccountNumber.TabIndex = 21;
            // 
            // PersonalData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 394);
            Controls.Add(txtAccountNumber);
            Controls.Add(txtNif);
            Controls.Add(txtCarPlate);
            Controls.Add(txtEmail);
            Controls.Add(txtMovil);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirsName);
            Controls.Add(btnValidate);
            Controls.Add(lblAccountNumber);
            Controls.Add(lblNif);
            Controls.Add(lblCarPlate);
            Controls.Add(lblEmail);
            Controls.Add(lblMovilNumber);
            Controls.Add(lblSecondName);
            Controls.Add(lblName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PersonalData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration of personal data";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSecondName;
        private Label lblMovilNumber;
        private Label lblEmail;
        private Label lblCarPlate;
        private Label lblNif;
        private Label lblAccountNumber;
        private Button btnValidate;
        private MaskedTextBox txtFirsName;
        private MaskedTextBox txtSecondName;
        private MaskedTextBox txtMovil;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtCarPlate;
        private MaskedTextBox txtNif;
        private MaskedTextBox txtAccountNumber;
    }
}