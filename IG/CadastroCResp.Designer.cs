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
            this.Calendarior = new System.Windows.Forms.DateTimePicker();
            this.txtNomer = new System.Windows.Forms.TextBox();
            this.txtCepr = new System.Windows.Forms.MaskedTextBox();
            this.txtRgr = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdader = new System.Windows.Forms.Label();
            this.txtEndr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.lblcpfr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtCelr = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpfr = new System.Windows.Forms.MaskedTextBox();
            this.lblparentesco = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.btnCloseF = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelBtnBuscar = new System.Windows.Forms.Panel();
            this.labelend = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnBuscarF = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEnd2 = new System.Windows.Forms.Label();
            this.linkEnd = new System.Windows.Forms.LinkLabel();
            this.ganb = new System.Windows.Forms.Label();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelBtnBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarF)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendarior
            // 
            this.Calendarior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calendarior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Calendarior.Location = new System.Drawing.Point(157, 201);
            this.Calendarior.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Calendarior.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.Calendarior.Name = "Calendarior";
            this.Calendarior.Size = new System.Drawing.Size(200, 29);
            this.Calendarior.TabIndex = 52;
            this.Calendarior.Value = new System.DateTime(2022, 10, 6, 0, 0, 0, 0);
            this.Calendarior.ValueChanged += new System.EventHandler(this.Calendarior_ValueChanged);
            this.Calendarior.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calendarior_KeyDown);
            // 
            // txtNomer
            // 
            this.txtNomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomer.Location = new System.Drawing.Point(157, 124);
            this.txtNomer.Name = "txtNomer";
            this.txtNomer.Size = new System.Drawing.Size(325, 29);
            this.txtNomer.TabIndex = 50;
            this.txtNomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomer_KeyDown);
            // 
            // txtCepr
            // 
            this.txtCepr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCepr.Location = new System.Drawing.Point(157, 353);
            this.txtCepr.Mask = "00000-000";
            this.txtCepr.Name = "txtCepr";
            this.txtCepr.Size = new System.Drawing.Size(115, 29);
            this.txtCepr.TabIndex = 66;
            this.txtCepr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCepr_KeyDown);
            this.txtCepr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCepr_KeyPress);
            // 
            // txtRgr
            // 
            this.txtRgr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRgr.Location = new System.Drawing.Point(157, 276);
            this.txtRgr.Mask = "00,000,000-0";
            this.txtRgr.Name = "txtRgr";
            this.txtRgr.Size = new System.Drawing.Size(115, 29);
            this.txtRgr.TabIndex = 64;
            this.txtRgr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRgr_KeyDown);
            this.txtRgr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRgr_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(157, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "RG:";
            // 
            // lblIdader
            // 
            this.lblIdader.AutoSize = true;
            this.lblIdader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIdader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdader.Location = new System.Drawing.Point(363, 198);
            this.lblIdader.Name = "lblIdader";
            this.lblIdader.Size = new System.Drawing.Size(19, 21);
            this.lblIdader.TabIndex = 61;
            this.lblIdader.Text = "0";
            // 
            // txtEndr
            // 
            this.txtEndr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndr.Location = new System.Drawing.Point(388, 353);
            this.txtEndr.Name = "txtEndr";
            this.txtEndr.Size = new System.Drawing.Size(200, 29);
            this.txtEndr.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(363, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 60;
            this.label9.Text = "Idade: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(156, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Data de nascimento:";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtParentesco.Location = new System.Drawing.Point(488, 124);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Size = new System.Drawing.Size(150, 29);
            this.txtParentesco.TabIndex = 58;
            this.txtParentesco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParentesco_KeyDown);
            // 
            // lblcpfr
            // 
            this.lblcpfr.AutoSize = true;
            this.lblcpfr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblcpfr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcpfr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcpfr.Location = new System.Drawing.Point(278, 252);
            this.lblcpfr.Name = "lblcpfr";
            this.lblcpfr.Size = new System.Drawing.Size(40, 21);
            this.lblcpfr.TabIndex = 56;
            this.lblcpfr.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 30);
            this.label8.TabIndex = 59;
            this.label8.Text = "Cadastro de Responsáveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(157, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "CEP:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCel.Location = new System.Drawing.Point(644, 100);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(62, 21);
            this.lblCel.TabIndex = 62;
            this.lblCel.Text = "Celular:";
            // 
            // txtCelr
            // 
            this.txtCelr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCelr.Location = new System.Drawing.Point(644, 124);
            this.txtCelr.Mask = "(99) 00000-0000";
            this.txtCelr.Name = "txtCelr";
            this.txtCelr.Size = new System.Drawing.Size(129, 29);
            this.txtCelr.TabIndex = 63;
            this.txtCelr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCelr_KeyDown);
            this.txtCelr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelr_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(388, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(157, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nome:";
            // 
            // txtCpfr
            // 
            this.txtCpfr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpfr.Location = new System.Drawing.Point(278, 276);
            this.txtCpfr.Mask = "000,000,000-00";
            this.txtCpfr.Name = "txtCpfr";
            this.txtCpfr.Size = new System.Drawing.Size(115, 29);
            this.txtCpfr.TabIndex = 65;
            this.txtCpfr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpfr_KeyDown);
            this.txtCpfr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfr_KeyPress);
            // 
            // lblparentesco
            // 
            this.lblparentesco.AutoSize = true;
            this.lblparentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblparentesco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblparentesco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblparentesco.Location = new System.Drawing.Point(488, 100);
            this.lblparentesco.Name = "lblparentesco";
            this.lblparentesco.Size = new System.Drawing.Size(88, 21);
            this.lblparentesco.TabIndex = 57;
            this.lblparentesco.Text = "Parentesco:";
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.TopBar.Controls.Add(this.btnCloseF);
            this.TopBar.Controls.Add(this.btnClose);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(915, 31);
            this.TopBar.TabIndex = 67;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // btnCloseF
            // 
            this.btnCloseF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseF.Image = global::IG.Properties.Resources.x_b;
            this.btnCloseF.Location = new System.Drawing.Point(881, 3);
            this.btnCloseF.Name = "btnCloseF";
            this.btnCloseF.Size = new System.Drawing.Size(25, 25);
            this.btnCloseF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseF.TabIndex = 4;
            this.btnCloseF.TabStop = false;
            this.btnCloseF.MouseEnter += new System.EventHandler(this.btnCloseF_MouseEnter);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::IG.Properties.Resources.x_tb2;
            this.btnClose.Location = new System.Drawing.Point(881, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.panel1.Location = new System.Drawing.Point(-3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 571);
            this.panel1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.panel2.Location = new System.Drawing.Point(913, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 571);
            this.panel2.TabIndex = 69;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(-1, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 5);
            this.panel3.TabIndex = 70;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(398, 493);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 33);
            this.btnSalvar.TabIndex = 72;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panelBtnBuscar
            // 
            this.panelBtnBuscar.BackColor = System.Drawing.Color.Silver;
            this.panelBtnBuscar.Controls.Add(this.labelend);
            this.panelBtnBuscar.Controls.Add(this.btnBuscar);
            this.panelBtnBuscar.Controls.Add(this.btnBuscarF);
            this.panelBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBtnBuscar.Location = new System.Drawing.Point(278, 353);
            this.panelBtnBuscar.Name = "panelBtnBuscar";
            this.panelBtnBuscar.Size = new System.Drawing.Size(104, 29);
            this.panelBtnBuscar.TabIndex = 73;
            this.panelBtnBuscar.Click += new System.EventHandler(this.panelBtnBuscar_Click);
            // 
            // labelend
            // 
            this.labelend.AutoSize = true;
            this.labelend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelend.Location = new System.Drawing.Point(30, 3);
            this.labelend.Name = "labelend";
            this.labelend.Size = new System.Drawing.Size(71, 21);
            this.labelend.TabIndex = 69;
            this.labelend.Text = "Localizar";
            this.labelend.Click += new System.EventHandler(this.labelend_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::IG.Properties.Resources.search_b1;
            this.btnBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.TabStop = false;
            // 
            // btnBuscarF
            // 
            this.btnBuscarF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarF.Image = global::IG.Properties.Resources.search_click;
            this.btnBuscarF.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarF.Name = "btnBuscarF";
            this.btnBuscarF.Size = new System.Drawing.Size(29, 29);
            this.btnBuscarF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarF.TabIndex = 66;
            this.btnBuscarF.TabStop = false;
            this.btnBuscarF.Click += new System.EventHandler(this.btnBuscarF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(289, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 82;
            this.label6.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(288, 430);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(165, 29);
            this.txtBairro.TabIndex = 81;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBairro_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(156, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 80;
            this.label7.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.Location = new System.Drawing.Point(156, 430);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(126, 29);
            this.txtComplemento.TabIndex = 79;
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComplemento_KeyDown);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(594, 329);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 21);
            this.lblNumero.TabIndex = 78;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(594, 353);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 29);
            this.txtNumero.TabIndex = 77;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtEnd2
            // 
            this.txtEnd2.AutoSize = true;
            this.txtEnd2.Location = new System.Drawing.Point(459, 438);
            this.txtEnd2.Name = "txtEnd2";
            this.txtEnd2.Size = new System.Drawing.Size(12, 15);
            this.txtEnd2.TabIndex = 76;
            this.txtEnd2.Text = "-";
            this.txtEnd2.Visible = false;
            // 
            // linkEnd
            // 
            this.linkEnd.AutoSize = true;
            this.linkEnd.Location = new System.Drawing.Point(388, 385);
            this.linkEnd.Name = "linkEnd";
            this.linkEnd.Size = new System.Drawing.Size(155, 15);
            this.linkEnd.TabIndex = 83;
            this.linkEnd.TabStop = true;
            this.linkEnd.Text = "Localizar CEP pelo endereço";
            // 
            // ganb
            // 
            this.ganb.AutoSize = true;
            this.ganb.Location = new System.Drawing.Point(789, 457);
            this.ganb.Name = "ganb";
            this.ganb.Size = new System.Drawing.Size(10, 15);
            this.ganb.TabIndex = 84;
            this.ganb.Text = ".";
            this.ganb.Visible = false;
            // 
            // CadastroCResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(915, 600);
            this.Controls.Add(this.ganb);
            this.Controls.Add(this.linkEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEnd2);
            this.Controls.Add(this.panelBtnBuscar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Calendarior);
            this.Controls.Add(this.txtNomer);
            this.Controls.Add(this.txtCepr);
            this.Controls.Add(this.txtRgr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdader);
            this.Controls.Add(this.txtEndr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParentesco);
            this.Controls.Add(this.lblcpfr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.txtCelr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCpfr);
            this.Controls.Add(this.lblparentesco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCResp";
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelBtnBuscar.ResumeLayout(false);
            this.panelBtnBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txtParentesco;
        private Label lblcpfr;
        private Label label8;
        private Label label2;
        private Label lblCel;
        private MaskedTextBox txtCelr;
        private Label label1;
        private Label label5;
        private MaskedTextBox txtCpfr;
        private Label lblparentesco;
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
    }
}