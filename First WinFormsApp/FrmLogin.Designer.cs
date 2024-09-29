namespace First_WinFormsApp
{
    partial class FrmLogin
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
            btnLogIn = new Button();
            btnCancel = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.Font = new Font("Segoe UI", 12F);
            btnLogIn.Location = new Point(218, 228);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(100, 32);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(218, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(178, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(219, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Location = new Point(178, 105);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(219, 23);
            txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(81, 103);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(86, 145);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 400);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnLogIn);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Button btnCancel;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
    }
}