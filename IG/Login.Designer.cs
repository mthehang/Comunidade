namespace IG
{
    partial class Login
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
            panel1 = new Panel();
            btnFechar2 = new PictureBox();
            btnFechar1 = new PictureBox();
            btnEntrarb = new PictureBox();
            btnEntrar = new PictureBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnFechar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFechar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEntrarb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEntrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnFechar2);
            panel1.Controls.Add(btnFechar1);
            panel1.Controls.Add(btnEntrarb);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 380);
            panel1.TabIndex = 0;
            // 
            // btnFechar2
            // 
            btnFechar2.Cursor = Cursors.Hand;
            btnFechar2.Image = Properties.Resources.fechar_login_2;
            btnFechar2.Location = new Point(552, 3);
            btnFechar2.Name = "btnFechar2";
            btnFechar2.Size = new Size(26, 26);
            btnFechar2.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFechar2.TabIndex = 6;
            btnFechar2.TabStop = false;
            btnFechar2.Visible = false;
            btnFechar2.Click += btnFechar2_Click;
            btnFechar2.MouseLeave += btnFechar2_MouseLeave;
            // 
            // btnFechar1
            // 
            btnFechar1.Cursor = Cursors.Hand;
            btnFechar1.Image = Properties.Resources.fechar_login_1;
            btnFechar1.Location = new Point(552, 2);
            btnFechar1.Name = "btnFechar1";
            btnFechar1.Size = new Size(26, 26);
            btnFechar1.TabIndex = 5;
            btnFechar1.TabStop = false;
            btnFechar1.MouseEnter += pictureBox2_MouseEnter_1;
            // 
            // btnEntrarb
            // 
            btnEntrarb.Cursor = Cursors.Hand;
            btnEntrarb.Image = Properties.Resources.salvar_login3;
            btnEntrarb.Location = new Point(234, 275);
            btnEntrarb.Name = "btnEntrarb";
            btnEntrarb.Size = new Size(114, 50);
            btnEntrarb.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEntrarb.TabIndex = 4;
            btnEntrarb.TabStop = false;
            btnEntrarb.Visible = false;
            btnEntrarb.Click += btnEntrarb_Click;
            btnEntrarb.MouseLeave += btnEntrarb_MouseLeave;
            // 
            // btnEntrar
            // 
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Image = Properties.Resources.salvar_login_b1;
            btnEntrar.Location = new Point(234, 275);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(114, 50);
            btnEntrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEntrar.TabIndex = 3;
            btnEntrar.TabStop = false;
            btnEntrar.MouseEnter += pictureBox2_MouseEnter;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(167, 197);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(282, 29);
            txtSenha.TabIndex = 2;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(167, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 29);
            txtEmail.TabIndex = 1;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(580, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Paint += Login_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnFechar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFechar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEntrarb).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEntrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private PictureBox btnEntrar;
        private PictureBox btnEntrarb;
        private PictureBox btnFechar1;
        private PictureBox btnFechar2;
    }
}