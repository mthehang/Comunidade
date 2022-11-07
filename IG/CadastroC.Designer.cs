namespace IG
{
    partial class CadastroC
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltxtIdade = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.Fundo = new System.Windows.Forms.Panel();
            this.linkEnd = new System.Windows.Forms.LinkLabel();
            this.lblCuidados = new System.Windows.Forms.Label();
            this.txtCuidados = new System.Windows.Forms.TextBox();
            this.btnEspecial = new System.Windows.Forms.CheckBox();
            this.panelBtnBuscar = new System.Windows.Forms.Panel();
            this.labelend = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnBuscarF = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEnd2 = new System.Windows.Forms.Label();
            this.lblObrigatorio = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Cpf = new System.Windows.Forms.ColumnHeader();
            this.Rg = new System.Windows.Forms.ColumnHeader();
            this.lblObs = new System.Windows.Forms.Label();
            this.panelbtnCriar = new System.Windows.Forms.Panel();
            this.lblCriar = new System.Windows.Forms.Label();
            this.btnCriarF = new System.Windows.Forms.PictureBox();
            this.btnCriar = new System.Windows.Forms.PictureBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.Fundo.SuspendLayout();
            this.panelBtnBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarF)).BeginInit();
            this.panelbtnCriar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriarF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(550, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNasc.Location = new System.Drawing.Point(550, 187);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(150, 21);
            this.lblNasc.TabIndex = 1;
            this.lblNasc.Text = "Data de nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(550, 135);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRg.Location = new System.Drawing.Point(550, 264);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 21);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG:";
            // 
            // Calendario
            // 
            this.Calendario.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calendario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Calendario.Location = new System.Drawing.Point(550, 211);
            this.Calendario.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Calendario.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(200, 29);
            this.Calendario.TabIndex = 6;
            this.Calendario.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            this.Calendario.ValueChanged += new System.EventHandler(this.Calendario_ValueChanged);
            this.Calendario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calendario_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(742, 697);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 33);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.Location = new System.Drawing.Point(550, 356);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(40, 21);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(791, 356);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnd.Location = new System.Drawing.Point(791, 380);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(200, 29);
            this.txtEnd.TabIndex = 13;
            this.txtEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnd_KeyDown);
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSala.Location = new System.Drawing.Point(550, 534);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(150, 29);
            this.txtSala.TabIndex = 14;
            this.txtSala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSala_KeyDown);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSala.Location = new System.Drawing.Point(550, 510);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(42, 21);
            this.lblSala.TabIndex = 15;
            this.lblSala.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(671, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "CPF:";
            // 
            // lbltxtIdade
            // 
            this.lbltxtIdade.AutoSize = true;
            this.lbltxtIdade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxtIdade.Location = new System.Drawing.Point(756, 188);
            this.lbltxtIdade.Name = "lbltxtIdade";
            this.lbltxtIdade.Size = new System.Drawing.Size(50, 20);
            this.lbltxtIdade.TabIndex = 36;
            this.lbltxtIdade.Text = "Idade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.Location = new System.Drawing.Point(756, 211);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(19, 21);
            this.lblIdade.TabIndex = 38;
            this.lblIdade.Text = "0";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRg.Location = new System.Drawing.Point(550, 288);
            this.txtRg.Mask = "00,000,000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(115, 29);
            this.txtRg.TabIndex = 42;
            this.txtRg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress_1);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(671, 288);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(115, 29);
            this.txtCpf.TabIndex = 44;
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress_1);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.Location = new System.Drawing.Point(550, 380);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(115, 29);
            this.txtCep.TabIndex = 46;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyDown);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress_1);
            // 
            // Fundo
            // 
            this.Fundo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Fundo.Controls.Add(this.linkEnd);
            this.Fundo.Controls.Add(this.lblCuidados);
            this.Fundo.Controls.Add(this.txtCuidados);
            this.Fundo.Controls.Add(this.btnEspecial);
            this.Fundo.Controls.Add(this.panelBtnBuscar);
            this.Fundo.Controls.Add(this.label2);
            this.Fundo.Controls.Add(this.txtBairro);
            this.Fundo.Controls.Add(this.label1);
            this.Fundo.Controls.Add(this.txtComplemento);
            this.Fundo.Controls.Add(this.lblNumero);
            this.Fundo.Controls.Add(this.txtNumero);
            this.Fundo.Controls.Add(this.txtEnd2);
            this.Fundo.Controls.Add(this.lblObrigatorio);
            this.Fundo.Controls.Add(this.ListView);
            this.Fundo.Controls.Add(this.lblObs);
            this.Fundo.Controls.Add(this.panelbtnCriar);
            this.Fundo.Controls.Add(this.txtResponsavel);
            this.Fundo.Controls.Add(this.lblResponsavel);
            this.Fundo.Controls.Add(this.txtNome);
            this.Fundo.Controls.Add(this.label6);
            this.Fundo.Controls.Add(this.lblIdade);
            this.Fundo.Controls.Add(this.Calendario);
            this.Fundo.Controls.Add(this.txtEnd);
            this.Fundo.Controls.Add(this.txtSala);
            this.Fundo.Controls.Add(this.lblRg);
            this.Fundo.Controls.Add(this.lblNasc);
            this.Fundo.Controls.Add(this.lblNome);
            this.Fundo.Controls.Add(this.btnSalvar);
            this.Fundo.Controls.Add(this.lbltxtIdade);
            this.Fundo.Controls.Add(this.txtRg);
            this.Fundo.Controls.Add(this.txtCpf);
            this.Fundo.Controls.Add(this.txtCep);
            this.Fundo.Controls.Add(this.lblEndereco);
            this.Fundo.Controls.Add(this.lblSala);
            this.Fundo.Controls.Add(this.lblCep);
            this.Fundo.Location = new System.Drawing.Point(85, 94);
            this.Fundo.Name = "Fundo";
            this.Fundo.Size = new System.Drawing.Size(1400, 854);
            this.Fundo.TabIndex = 48;
            this.Fundo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fundo_MouseClick);
            // 
            // linkEnd
            // 
            this.linkEnd.AutoSize = true;
            this.linkEnd.Location = new System.Drawing.Point(791, 412);
            this.linkEnd.Name = "linkEnd";
            this.linkEnd.Size = new System.Drawing.Size(155, 15);
            this.linkEnd.TabIndex = 73;
            this.linkEnd.TabStop = true;
            this.linkEnd.Text = "Localizar CEP pelo endereço";
            this.linkEnd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEnd_LinkClicked);
            // 
            // lblCuidados
            // 
            this.lblCuidados.AutoSize = true;
            this.lblCuidados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuidados.Location = new System.Drawing.Point(848, 187);
            this.lblCuidados.Name = "lblCuidados";
            this.lblCuidados.Size = new System.Drawing.Size(78, 21);
            this.lblCuidados.TabIndex = 72;
            this.lblCuidados.Text = "Cuidados:";
            this.lblCuidados.Visible = false;
            // 
            // txtCuidados
            // 
            this.txtCuidados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCuidados.Location = new System.Drawing.Point(848, 211);
            this.txtCuidados.Multiline = true;
            this.txtCuidados.Name = "txtCuidados";
            this.txtCuidados.Size = new System.Drawing.Size(216, 124);
            this.txtCuidados.TabIndex = 71;
            this.txtCuidados.Visible = false;
            // 
            // btnEspecial
            // 
            this.btnEspecial.AutoSize = true;
            this.btnEspecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEspecial.Location = new System.Drawing.Point(881, 137);
            this.btnEspecial.Name = "btnEspecial";
            this.btnEspecial.Size = new System.Drawing.Size(140, 25);
            this.btnEspecial.TabIndex = 70;
            this.btnEspecial.Text = "Criança especial";
            this.btnEspecial.UseVisualStyleBackColor = true;
            this.btnEspecial.CheckedChanged += new System.EventHandler(this.btnEspecial_CheckedChanged);
            // 
            // panelBtnBuscar
            // 
            this.panelBtnBuscar.BackColor = System.Drawing.Color.Silver;
            this.panelBtnBuscar.Controls.Add(this.labelend);
            this.panelBtnBuscar.Controls.Add(this.btnBuscar);
            this.panelBtnBuscar.Controls.Add(this.btnBuscarF);
            this.panelBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBtnBuscar.Location = new System.Drawing.Point(671, 380);
            this.panelBtnBuscar.Name = "panelBtnBuscar";
            this.panelBtnBuscar.Size = new System.Drawing.Size(104, 29);
            this.panelBtnBuscar.TabIndex = 68;
            this.panelBtnBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panelBtnBuscar.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panelBtnBuscar.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
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
            this.labelend.MouseEnter += new System.EventHandler(this.labelend_MouseEnter);
            this.labelend.MouseLeave += new System.EventHandler(this.labelend_MouseLeave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::IG.Properties.Resources.search_b;
            this.btnBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
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
            this.btnBuscarF.MouseLeave += new System.EventHandler(this.btnBuscarF_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(675, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(682, 457);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(165, 29);
            this.txtBairro.TabIndex = 64;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBairro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.Location = new System.Drawing.Point(550, 457);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(126, 29);
            this.txtComplemento.TabIndex = 62;
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComplemento_KeyDown);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(997, 356);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 21);
            this.lblNumero.TabIndex = 61;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(997, 380);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 29);
            this.txtNumero.TabIndex = 60;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtEnd2
            // 
            this.txtEnd2.AutoSize = true;
            this.txtEnd2.Location = new System.Drawing.Point(853, 465);
            this.txtEnd2.Name = "txtEnd2";
            this.txtEnd2.Size = new System.Drawing.Size(12, 15);
            this.txtEnd2.TabIndex = 59;
            this.txtEnd2.Text = "-";
            this.txtEnd2.Visible = false;
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblObrigatorio.Location = new System.Drawing.Point(550, 320);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(292, 15);
            this.lblObrigatorio.TabIndex = 58;
            this.lblObrigatorio.Text = "* Obrigatório preencher pelo menos UM documento *";
            this.lblObrigatorio.Visible = false;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nome,
            this.Cpf,
            this.Rg});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView.FullRowSelect = true;
            this.ListView.Location = new System.Drawing.Point(550, 638);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(297, 160);
            this.ListView.TabIndex = 57;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.Visible = false;
            this.ListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
            // 
            // Id
            // 
            this.Id.Text = "OC";
            this.Id.Width = 50;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 120;
            // 
            // Cpf
            // 
            this.Cpf.Text = "CPF";
            this.Cpf.Width = 100;
            // 
            // Rg
            // 
            this.Rg.Text = "RG";
            this.Rg.Width = 100;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblObs.Location = new System.Drawing.Point(550, 643);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(134, 15);
            this.lblObs.TabIndex = 56;
            this.lblObs.Text = "Digite nome, RG ou CPF";
            // 
            // panelbtnCriar
            // 
            this.panelbtnCriar.Controls.Add(this.lblCriar);
            this.panelbtnCriar.Controls.Add(this.btnCriarF);
            this.panelbtnCriar.Controls.Add(this.btnCriar);
            this.panelbtnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelbtnCriar.Location = new System.Drawing.Point(852, 616);
            this.panelbtnCriar.Name = "panelbtnCriar";
            this.panelbtnCriar.Size = new System.Drawing.Size(190, 24);
            this.panelbtnCriar.TabIndex = 55;
            this.panelbtnCriar.Click += new System.EventHandler(this.panelbtnCriar_Click);
            this.panelbtnCriar.MouseEnter += new System.EventHandler(this.panelbtnCriar_MouseEnter);
            this.panelbtnCriar.MouseLeave += new System.EventHandler(this.panelbtnCriar_MouseLeave);
            // 
            // lblCriar
            // 
            this.lblCriar.AutoSize = true;
            this.lblCriar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCriar.Location = new System.Drawing.Point(38, 0);
            this.lblCriar.Name = "lblCriar";
            this.lblCriar.Size = new System.Drawing.Size(131, 21);
            this.lblCriar.TabIndex = 55;
            this.lblCriar.Text = "Criar responsável";
            this.lblCriar.Click += new System.EventHandler(this.lblCriar_Click);
            this.lblCriar.MouseEnter += new System.EventHandler(this.lblCriar_MouseEnter);
            this.lblCriar.MouseLeave += new System.EventHandler(this.lblCriar_MouseLeave);
            // 
            // btnCriarF
            // 
            this.btnCriarF.Image = global::IG.Properties.Resources.mais_b;
            this.btnCriarF.Location = new System.Drawing.Point(3, 0);
            this.btnCriarF.Name = "btnCriarF";
            this.btnCriarF.Size = new System.Drawing.Size(34, 21);
            this.btnCriarF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCriarF.TabIndex = 54;
            this.btnCriarF.TabStop = false;
            this.btnCriarF.Visible = false;
            this.btnCriarF.Click += new System.EventHandler(this.btnCriarF_Click);
            this.btnCriarF.MouseLeave += new System.EventHandler(this.btnCriarF_MouseLeave);
            // 
            // btnCriar
            // 
            this.btnCriar.Image = global::IG.Properties.Resources.mais;
            this.btnCriar.Location = new System.Drawing.Point(3, 0);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(34, 21);
            this.btnCriar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCriar.TabIndex = 53;
            this.btnCriar.TabStop = false;
            this.btnCriar.MouseEnter += new System.EventHandler(this.btnCriar_MouseEnter);
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponsavel.Location = new System.Drawing.Point(550, 611);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(296, 29);
            this.txtResponsavel.TabIndex = 49;
            this.txtResponsavel.TextChanged += new System.EventHandler(this.txtResponsavel_TextChanged_1);
            this.txtResponsavel.Enter += new System.EventHandler(this.txtResponsavel_Enter);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResponsavel.Location = new System.Drawing.Point(546, 587);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(100, 21);
            this.lblResponsavel.TabIndex = 48;
            this.lblResponsavel.Text = "Responsável:";
            // 
            // CadastroC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1700, 1049);
            this.Controls.Add(this.Fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de crianças";
            this.Fundo.ResumeLayout(false);
            this.Fundo.PerformLayout();
            this.panelBtnBuscar.ResumeLayout(false);
            this.panelBtnBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarF)).EndInit();
            this.panelbtnCriar.ResumeLayout(false);
            this.panelbtnCriar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriarF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNome;
        private Label lblNasc;
        private TextBox txtNome;
        private Label lblRg;
        private DateTimePicker Calendario;
        private Button btnSalvar;
        private Label lblCep;
        private Label lblEndereco;
        private TextBox txtEnd;
        private TextBox txtSala;
        private Label lblSala;
        private Label label6;
        private Label lbltxtIdade;
        private Label lblIdade;
        private MaskedTextBox txtRg;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtCep;
        private Panel Fundo;
        private Label lblResponsavel;
        private PictureBox btnCriar;
        private PictureBox btnCriarF;
        private Panel panelbtnCriar;
        private Label lblCriar;
        private Label lblObs;
        private ColumnHeader Id;
        private ColumnHeader Nome;
        private ColumnHeader Cpf;
        private ColumnHeader Rg;
        private Label lblObrigatorio;
        private Label txtEnd2;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtBairro;
        private Label label1;
        private TextBox txtComplemento;
        private Panel panelBtnBuscar;
        private PictureBox btnBuscar;
        private PictureBox btnBuscarF;
        private Label labelend;
        private Label lblCuidados;
        private TextBox txtCuidados;
        private CheckBox btnEspecial;
        private LinkLabel linkEnd;
        public TextBox txtResponsavel;
        public ListView ListView;
    }
}