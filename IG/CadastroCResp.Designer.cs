namespace IG
{
    partial class CadastroCResp
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
            Calendarior = new DateTimePicker();
            txtNomer = new TextBox();
            txtCepr = new MaskedTextBox();
            txtRgr = new MaskedTextBox();
            label3 = new Label();
            lblIdader = new Label();
            txtEndr = new TextBox();
            label9 = new Label();
            label4 = new Label();
            lblcpfr = new Label();
            label8 = new Label();
            label2 = new Label();
            lblCel = new Label();
            txtCelr = new MaskedTextBox();
            label1 = new Label();
            label5 = new Label();
            txtCpfr = new MaskedTextBox();
            TopBar = new Panel();
            btnCloseF = new PictureBox();
            btnClose = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSalvar = new Button();
            panelBtnBuscar = new Panel();
            labelend = new Label();
            btnBuscar = new PictureBox();
            btnBuscarF = new PictureBox();
            label6 = new Label();
            txtBairro = new TextBox();
            label7 = new Label();
            txtComplemento = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtEnd2 = new Label();
            linkEnd = new LinkLabel();
            ganb = new Label();
            lblOb = new Label();
            cbSupervisao = new ComboBox();
            lblSupervisao = new Label();
            txtLastNamer = new TextBox();
            lblLastNamer = new Label();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelBtnBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarF).BeginInit();
            SuspendLayout();
            // 
            // Calendarior
            // 
            Calendarior.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Calendarior.Format = DateTimePickerFormat.Short;
            Calendarior.Location = new Point(157, 201);
            Calendarior.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            Calendarior.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            Calendarior.Name = "Calendarior";
            Calendarior.Size = new Size(200, 29);
            Calendarior.TabIndex = 52;
            Calendarior.Value = new DateTime(2022, 10, 6, 0, 0, 0, 0);
            Calendarior.ValueChanged += Calendarior_ValueChanged;
            Calendarior.KeyDown += Calendarior_KeyDown;
            // 
            // txtNomer
            // 
            txtNomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomer.Location = new Point(157, 124);
            txtNomer.Name = "txtNomer";
            txtNomer.Size = new Size(149, 29);
            txtNomer.TabIndex = 50;
            txtNomer.KeyDown += txtNomer_KeyDown;
            // 
            // txtCepr
            // 
            txtCepr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCepr.Location = new Point(157, 353);
            txtCepr.Mask = "00000-000";
            txtCepr.Name = "txtCepr";
            txtCepr.Size = new Size(115, 29);
            txtCepr.TabIndex = 66;
            txtCepr.KeyDown += txtCepr_KeyDown;
            txtCepr.KeyPress += txtCepr_KeyPress;
            // 
            // txtRgr
            // 
            txtRgr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgr.Location = new Point(157, 276);
            txtRgr.Mask = "00,000,000-0";
            txtRgr.Name = "txtRgr";
            txtRgr.Size = new Size(115, 29);
            txtRgr.TabIndex = 64;
            txtRgr.KeyDown += txtRgr_KeyDown;
            txtRgr.KeyPress += txtRgr_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(157, 252);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 51;
            label3.Text = "RG:";
            // 
            // lblIdader
            // 
            lblIdader.AutoSize = true;
            lblIdader.BackColor = Color.FromArgb(224, 224, 224);
            lblIdader.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdader.ForeColor = SystemColors.ActiveCaptionText;
            lblIdader.Location = new Point(363, 198);
            lblIdader.Name = "lblIdader";
            lblIdader.Size = new Size(19, 21);
            lblIdader.TabIndex = 61;
            lblIdader.Text = "0";
            // 
            // txtEndr
            // 
            txtEndr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndr.Location = new Point(388, 353);
            txtEndr.Name = "txtEndr";
            txtEndr.Size = new Size(200, 29);
            txtEndr.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(363, 177);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 60;
            label9.Text = "Idade: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(156, 177);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 49;
            label4.Text = "Data de nascimento:";
            // 
            // lblcpfr
            // 
            lblcpfr.AutoSize = true;
            lblcpfr.BackColor = Color.FromArgb(224, 224, 224);
            lblcpfr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblcpfr.ForeColor = SystemColors.ActiveCaptionText;
            lblcpfr.Location = new Point(278, 252);
            lblcpfr.Name = "lblcpfr";
            lblcpfr.Size = new Size(40, 21);
            lblcpfr.TabIndex = 56;
            lblcpfr.Text = "CPF:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(40, 31, 30);
            label8.Location = new Point(8, 34);
            label8.Name = "label8";
            label8.Size = new Size(253, 30);
            label8.TabIndex = 59;
            label8.Text = "Cadastro de Responsáveis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(157, 329);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 53;
            label2.Text = "CEP:";
            // 
            // lblCel
            // 
            lblCel.AutoSize = true;
            lblCel.BackColor = Color.FromArgb(224, 224, 224);
            lblCel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCel.Location = new Point(667, 101);
            lblCel.Name = "lblCel";
            lblCel.Size = new Size(62, 21);
            lblCel.TabIndex = 62;
            lblCel.Text = "Celular:";
            // 
            // txtCelr
            // 
            txtCelr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelr.Location = new Point(667, 125);
            txtCelr.Mask = "(99) 00000-0000";
            txtCelr.Name = "txtCelr";
            txtCelr.Size = new Size(134, 29);
            txtCelr.TabIndex = 63;
            txtCelr.KeyDown += txtCelr_KeyDown;
            txtCelr.KeyPress += txtCelr_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(388, 329);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 54;
            label1.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(157, 100);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 48;
            label5.Text = "Nome:";
            // 
            // txtCpfr
            // 
            txtCpfr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfr.Location = new Point(278, 276);
            txtCpfr.Mask = "000,000,000-00";
            txtCpfr.Name = "txtCpfr";
            txtCpfr.Size = new Size(115, 29);
            txtCpfr.TabIndex = 65;
            txtCpfr.KeyDown += txtCpfr_KeyDown;
            txtCpfr.KeyPress += txtCpfr_KeyPress;
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.FromArgb(236, 47, 67);
            TopBar.Controls.Add(btnCloseF);
            TopBar.Controls.Add(btnClose);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(915, 31);
            TopBar.TabIndex = 67;
            TopBar.MouseDown += TopBar_MouseDown;
            // 
            // btnCloseF
            // 
            btnCloseF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseF.Cursor = Cursors.Hand;
            btnCloseF.Image = Properties.Resources.x_b;
            btnCloseF.Location = new Point(881, 3);
            btnCloseF.Name = "btnCloseF";
            btnCloseF.Size = new Size(25, 25);
            btnCloseF.SizeMode = PictureBoxSizeMode.Zoom;
            btnCloseF.TabIndex = 4;
            btnCloseF.TabStop = false;
            btnCloseF.MouseEnter += btnCloseF_MouseEnter;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.x_tb2;
            btnClose.Location = new Point(881, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 47, 67);
            panel1.Location = new Point(-3, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 571);
            panel1.TabIndex = 68;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 47, 67);
            panel2.Location = new Point(913, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 571);
            panel2.TabIndex = 69;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 47, 67);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(-1, 598);
            panel3.Name = "panel3";
            panel3.Size = new Size(916, 5);
            panel3.TabIndex = 70;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(398, 493);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 33);
            btnSalvar.TabIndex = 72;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panelBtnBuscar
            // 
            panelBtnBuscar.BackColor = Color.Silver;
            panelBtnBuscar.Controls.Add(labelend);
            panelBtnBuscar.Controls.Add(btnBuscar);
            panelBtnBuscar.Controls.Add(btnBuscarF);
            panelBtnBuscar.Cursor = Cursors.Hand;
            panelBtnBuscar.Location = new Point(278, 353);
            panelBtnBuscar.Name = "panelBtnBuscar";
            panelBtnBuscar.Size = new Size(104, 29);
            panelBtnBuscar.TabIndex = 73;
            panelBtnBuscar.Click += panelBtnBuscar_Click;
            // 
            // labelend
            // 
            labelend.AutoSize = true;
            labelend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelend.Location = new Point(30, 3);
            labelend.Name = "labelend";
            labelend.Size = new Size(71, 21);
            labelend.TabIndex = 69;
            labelend.Text = "Localizar";
            labelend.Click += labelend_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Image = Properties.Resources.search_b1;
            btnBuscar.Location = new Point(0, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(29, 29);
            btnBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            btnBuscar.TabIndex = 67;
            btnBuscar.TabStop = false;
            // 
            // btnBuscarF
            // 
            btnBuscarF.Cursor = Cursors.Hand;
            btnBuscarF.Image = Properties.Resources.search_click;
            btnBuscarF.Location = new Point(0, 0);
            btnBuscarF.Name = "btnBuscarF";
            btnBuscarF.Size = new Size(29, 29);
            btnBuscarF.SizeMode = PictureBoxSizeMode.Zoom;
            btnBuscarF.TabIndex = 66;
            btnBuscarF.TabStop = false;
            btnBuscarF.Click += btnBuscarF_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(289, 406);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 82;
            label6.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(288, 430);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(165, 29);
            txtBairro.TabIndex = 81;
            txtBairro.KeyDown += txtBairro_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(156, 406);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 80;
            label7.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(156, 430);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(126, 29);
            txtComplemento.TabIndex = 79;
            txtComplemento.KeyDown += txtComplemento_KeyDown;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(594, 329);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(71, 21);
            lblNumero.TabIndex = 78;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(594, 353);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(84, 29);
            txtNumero.TabIndex = 77;
            txtNumero.KeyDown += txtNumero_KeyDown;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtEnd2
            // 
            txtEnd2.AutoSize = true;
            txtEnd2.Location = new Point(459, 438);
            txtEnd2.Name = "txtEnd2";
            txtEnd2.Size = new Size(12, 15);
            txtEnd2.TabIndex = 76;
            txtEnd2.Text = "-";
            txtEnd2.Visible = false;
            // 
            // linkEnd
            // 
            linkEnd.AutoSize = true;
            linkEnd.Location = new Point(388, 385);
            linkEnd.Name = "linkEnd";
            linkEnd.Size = new Size(155, 15);
            linkEnd.TabIndex = 83;
            linkEnd.TabStop = true;
            linkEnd.Text = "Localizar CEP pelo endereço";
            // 
            // ganb
            // 
            ganb.AutoSize = true;
            ganb.Location = new Point(789, 457);
            ganb.Name = "ganb";
            ganb.Size = new Size(10, 15);
            ganb.TabIndex = 84;
            ganb.Text = ".";
            ganb.Visible = false;
            // 
            // lblOb
            // 
            lblOb.AutoSize = true;
            lblOb.BackColor = Color.FromArgb(224, 224, 224);
            lblOb.ForeColor = Color.Red;
            lblOb.Location = new Point(157, 308);
            lblOb.Name = "lblOb";
            lblOb.Size = new Size(179, 15);
            lblOb.TabIndex = 85;
            lblOb.Text = "* Documentos são obrigatórios *";
            lblOb.Visible = false;
            // 
            // cbSupervisao
            // 
            cbSupervisao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSupervisao.FormattingEnabled = true;
            cbSupervisao.Location = new Point(488, 124);
            cbSupervisao.Name = "cbSupervisao";
            cbSupervisao.Size = new Size(173, 29);
            cbSupervisao.TabIndex = 87;
            cbSupervisao.KeyDown += cbSupervisao_KeyDown;
            // 
            // lblSupervisao
            // 
            lblSupervisao.AutoSize = true;
            lblSupervisao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupervisao.Location = new Point(488, 101);
            lblSupervisao.Name = "lblSupervisao";
            lblSupervisao.Size = new Size(84, 20);
            lblSupervisao.TabIndex = 86;
            lblSupervisao.Text = "Supervisão:";
            // 
            // txtLastNamer
            // 
            txtLastNamer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastNamer.Location = new Point(311, 125);
            txtLastNamer.Name = "txtLastNamer";
            txtLastNamer.Size = new Size(156, 29);
            txtLastNamer.TabIndex = 89;
            // 
            // lblLastNamer
            // 
            lblLastNamer.AutoSize = true;
            lblLastNamer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastNamer.Location = new Point(308, 100);
            lblLastNamer.Name = "lblLastNamer";
            lblLastNamer.Size = new Size(94, 21);
            lblLastNamer.TabIndex = 88;
            lblLastNamer.Text = "Sobrenome:";
            // 
            // CadastroCResp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(915, 600);
            Controls.Add(txtLastNamer);
            Controls.Add(lblLastNamer);
            Controls.Add(cbSupervisao);
            Controls.Add(lblSupervisao);
            Controls.Add(lblOb);
            Controls.Add(ganb);
            Controls.Add(linkEnd);
            Controls.Add(label6);
            Controls.Add(txtBairro);
            Controls.Add(label7);
            Controls.Add(txtComplemento);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(txtEnd2);
            Controls.Add(panelBtnBuscar);
            Controls.Add(btnSalvar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(TopBar);
            Controls.Add(Calendarior);
            Controls.Add(txtNomer);
            Controls.Add(txtCepr);
            Controls.Add(txtRgr);
            Controls.Add(label3);
            Controls.Add(lblIdader);
            Controls.Add(txtEndr);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(lblcpfr);
            Controls.Add(label2);
            Controls.Add(lblCel);
            Controls.Add(txtCelr);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(txtCpfr);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroCResp";
            Load += CadastroCResp_Load;
            TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCloseF).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelBtnBuscar.ResumeLayout(false);
            panelBtnBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker Calendarior;
        private TextBox txtNomer;
        private MaskedTextBox txtCepr;
        private MaskedTextBox txtRgr;
        private Label label3;
        private Label lblIdader;
        private TextBox txtEndr;
        private Label label9;
        private Label label4;
        private Label lblcpfr;
        private Label label8;
        private Label label2;
        private Label lblCel;
        private MaskedTextBox txtCelr;
        private Label label1;
        private Label label5;
        private MaskedTextBox txtCpfr;
        private Panel TopBar;
        private PictureBox btnCloseF;
        private PictureBox btnClose;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnSalvar;
        private Panel panelBtnBuscar;
        private Label labelend;
        private PictureBox btnBuscar;
        private PictureBox btnBuscarF;
        private Label label6;
        private TextBox txtBairro;
        private Label label7;
        private TextBox txtComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label txtEnd2;
        private LinkLabel linkEnd;
        private Label ganb;
        private Label lblOb;
        private ComboBox cbSupervisao;
        private Label lblSupervisao;
        private TextBox txtLastNamer;
        private Label lblLastNamer;
    }
}