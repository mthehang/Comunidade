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
            lblNome = new Label();
            lblNasc = new Label();
            txtName = new TextBox();
            Calendario = new DateTimePicker();
            btnSalvar = new Button();
            lblCep = new Label();
            lblEndereco = new Label();
            txtEnd = new TextBox();
            lblSala = new Label();
            lbltxtIdade = new Label();
            lblIdade = new Label();
            txtCep = new MaskedTextBox();
            Fundo = new Panel();
            cbSala = new ComboBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtParentesco = new TextBox();
            lblParentesco = new Label();
            linkEnd = new LinkLabel();
            lblCuidados = new Label();
            txtCuidados = new TextBox();
            btnEspecial = new CheckBox();
            panelBtnBuscar = new Panel();
            labelend = new Label();
            btnBuscar = new PictureBox();
            btnBuscarF = new PictureBox();
            label2 = new Label();
            txtBairro = new TextBox();
            label1 = new Label();
            txtComplemento = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtEnd2 = new Label();
            ListView = new ListView();
            Id = new ColumnHeader();
            Nome = new ColumnHeader();
            Cpf = new ColumnHeader();
            Rg = new ColumnHeader();
            lblObs = new Label();
            panelbtnCriar = new Panel();
            lblCriar = new Label();
            btnCriarF = new PictureBox();
            btnCriar = new PictureBox();
            txtResponsavel = new TextBox();
            lblResponsavel = new Label();
            Fundo.SuspendLayout();
            panelBtnBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarF).BeginInit();
            panelbtnCriar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCriarF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCriar).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(550, 127);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblNasc
            // 
            lblNasc.Anchor = AnchorStyles.None;
            lblNasc.AutoSize = true;
            lblNasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNasc.Location = new Point(550, 203);
            lblNasc.Name = "lblNasc";
            lblNasc.Size = new Size(150, 21);
            lblNasc.TabIndex = 1;
            lblNasc.Text = "Data de nascimento:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(550, 151);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 29);
            txtName.TabIndex = 2;
            txtName.KeyDown += txtNome_KeyDown;
            // 
            // Calendario
            // 
            Calendario.Anchor = AnchorStyles.None;
            Calendario.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Calendario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Calendario.Format = DateTimePickerFormat.Short;
            Calendario.Location = new Point(550, 227);
            Calendario.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            Calendario.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            Calendario.Name = "Calendario";
            Calendario.Size = new Size(200, 29);
            Calendario.TabIndex = 6;
            Calendario.Value = new DateTime(2022, 10, 7, 0, 0, 0, 0);
            Calendario.ValueChanged += Calendario_ValueChanged;
            Calendario.KeyDown += Calendario_KeyDown;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.None;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(742, 718);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 33);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSave_Click;
            // 
            // lblCep
            // 
            lblCep.Anchor = AnchorStyles.None;
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCep.Location = new Point(550, 280);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(40, 21);
            lblCep.TabIndex = 10;
            lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            lblEndereco.Anchor = AnchorStyles.None;
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereco.Location = new Point(550, 356);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(77, 21);
            lblEndereco.TabIndex = 12;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEnd
            // 
            txtEnd.Anchor = AnchorStyles.None;
            txtEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnd.Location = new Point(550, 380);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(200, 29);
            txtEnd.TabIndex = 13;
            txtEnd.KeyDown += txtEnd_KeyDown;
            // 
            // lblSala
            // 
            lblSala.Anchor = AnchorStyles.None;
            lblSala.AutoSize = true;
            lblSala.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSala.Location = new Point(550, 510);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(42, 21);
            lblSala.TabIndex = 15;
            lblSala.Text = "Sala:";
            // 
            // lbltxtIdade
            // 
            lbltxtIdade.Anchor = AnchorStyles.None;
            lbltxtIdade.AutoSize = true;
            lbltxtIdade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxtIdade.Location = new Point(756, 204);
            lbltxtIdade.Name = "lbltxtIdade";
            lbltxtIdade.Size = new Size(50, 20);
            lbltxtIdade.TabIndex = 36;
            lbltxtIdade.Text = "Idade:";
            // 
            // lblIdade
            // 
            lblIdade.Anchor = AnchorStyles.None;
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdade.Location = new Point(756, 227);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(19, 21);
            lblIdade.TabIndex = 38;
            lblIdade.Text = "0";
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.None;
            txtCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.Location = new Point(550, 303);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(115, 29);
            txtCep.TabIndex = 46;
            txtCep.TextChanged += txtCep_TextChanged;
            txtCep.KeyDown += txtCep_KeyDown;
            txtCep.KeyPress += txtCep_KeyPress_1;
            // 
            // Fundo
            // 
            Fundo.BackColor = Color.FromArgb(224, 224, 224);
            Fundo.Controls.Add(cbSala);
            Fundo.Controls.Add(txtLastName);
            Fundo.Controls.Add(lblLastName);
            Fundo.Controls.Add(txtParentesco);
            Fundo.Controls.Add(lblParentesco);
            Fundo.Controls.Add(linkEnd);
            Fundo.Controls.Add(lblCuidados);
            Fundo.Controls.Add(txtCuidados);
            Fundo.Controls.Add(btnEspecial);
            Fundo.Controls.Add(panelBtnBuscar);
            Fundo.Controls.Add(label2);
            Fundo.Controls.Add(txtBairro);
            Fundo.Controls.Add(label1);
            Fundo.Controls.Add(txtComplemento);
            Fundo.Controls.Add(lblNumero);
            Fundo.Controls.Add(txtNumero);
            Fundo.Controls.Add(txtEnd2);
            Fundo.Controls.Add(ListView);
            Fundo.Controls.Add(lblObs);
            Fundo.Controls.Add(panelbtnCriar);
            Fundo.Controls.Add(txtResponsavel);
            Fundo.Controls.Add(lblResponsavel);
            Fundo.Controls.Add(txtName);
            Fundo.Controls.Add(lblIdade);
            Fundo.Controls.Add(Calendario);
            Fundo.Controls.Add(txtEnd);
            Fundo.Controls.Add(lblNasc);
            Fundo.Controls.Add(lblNome);
            Fundo.Controls.Add(btnSalvar);
            Fundo.Controls.Add(lbltxtIdade);
            Fundo.Controls.Add(txtCep);
            Fundo.Controls.Add(lblEndereco);
            Fundo.Controls.Add(lblSala);
            Fundo.Controls.Add(lblCep);
            Fundo.Dock = DockStyle.Fill;
            Fundo.Location = new Point(0, 0);
            Fundo.Name = "Fundo";
            Fundo.Size = new Size(1699, 825);
            Fundo.TabIndex = 48;
            Fundo.MouseClick += Fundo_MouseClick;
            // 
            // cbSala
            // 
            cbSala.Anchor = AnchorStyles.None;
            cbSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSala.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSala.FormattingEnabled = true;
            cbSala.Items.AddRange(new object[] { "Berçário (até 2 anos)", "3 e 4 anos", "5 e 6 anos", "7 e 8 anos", "9 e 10 anos" });
            cbSala.Location = new Point(550, 534);
            cbSala.Name = "cbSala";
            cbSala.Size = new Size(159, 29);
            cbSala.TabIndex = 84;
            cbSala.SelectedIndexChanged += cbSala_SelectedIndexChanged;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(706, 151);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(156, 29);
            txtLastName.TabIndex = 83;
            txtLastName.KeyDown += txtLastName_KeyDown;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.None;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(706, 127);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 21);
            lblLastName.TabIndex = 82;
            lblLastName.Text = "Sobrenome:";
            // 
            // txtParentesco
            // 
            txtParentesco.Anchor = AnchorStyles.None;
            txtParentesco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtParentesco.Location = new Point(853, 611);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.Size = new Size(139, 29);
            txtParentesco.TabIndex = 75;
            // 
            // lblParentesco
            // 
            lblParentesco.Anchor = AnchorStyles.None;
            lblParentesco.AutoSize = true;
            lblParentesco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblParentesco.Location = new Point(853, 587);
            lblParentesco.Name = "lblParentesco";
            lblParentesco.Size = new Size(92, 21);
            lblParentesco.TabIndex = 74;
            lblParentesco.Text = "Parentesco: ";
            // 
            // linkEnd
            // 
            linkEnd.Anchor = AnchorStyles.None;
            linkEnd.AutoSize = true;
            linkEnd.Location = new Point(550, 412);
            linkEnd.Name = "linkEnd";
            linkEnd.Size = new Size(155, 15);
            linkEnd.TabIndex = 73;
            linkEnd.TabStop = true;
            linkEnd.Text = "Localizar CEP pelo endereço";
            linkEnd.LinkClicked += linkEnd_LinkClicked;
            // 
            // lblCuidados
            // 
            lblCuidados.Anchor = AnchorStyles.None;
            lblCuidados.AutoSize = true;
            lblCuidados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuidados.Location = new Point(878, 203);
            lblCuidados.Name = "lblCuidados";
            lblCuidados.Size = new Size(78, 21);
            lblCuidados.TabIndex = 72;
            lblCuidados.Text = "Cuidados:";
            lblCuidados.Visible = false;
            // 
            // txtCuidados
            // 
            txtCuidados.Anchor = AnchorStyles.None;
            txtCuidados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuidados.Location = new Point(881, 227);
            txtCuidados.Multiline = true;
            txtCuidados.Name = "txtCuidados";
            txtCuidados.Size = new Size(216, 124);
            txtCuidados.TabIndex = 71;
            txtCuidados.Visible = false;
            // 
            // btnEspecial
            // 
            btnEspecial.Anchor = AnchorStyles.None;
            btnEspecial.AutoSize = true;
            btnEspecial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEspecial.Location = new Point(881, 153);
            btnEspecial.Name = "btnEspecial";
            btnEspecial.Size = new Size(140, 25);
            btnEspecial.TabIndex = 70;
            btnEspecial.Text = "Criança especial";
            btnEspecial.UseVisualStyleBackColor = true;
            btnEspecial.CheckedChanged += btnEspecial_CheckedChanged;
            // 
            // panelBtnBuscar
            // 
            panelBtnBuscar.Anchor = AnchorStyles.None;
            panelBtnBuscar.BackColor = Color.Silver;
            panelBtnBuscar.Controls.Add(labelend);
            panelBtnBuscar.Controls.Add(btnBuscar);
            panelBtnBuscar.Controls.Add(btnBuscarF);
            panelBtnBuscar.Cursor = Cursors.Hand;
            panelBtnBuscar.Location = new Point(671, 303);
            panelBtnBuscar.Name = "panelBtnBuscar";
            panelBtnBuscar.Size = new Size(104, 29);
            panelBtnBuscar.TabIndex = 68;
            panelBtnBuscar.MouseClick += panel1_MouseClick;
            panelBtnBuscar.MouseEnter += panel1_MouseEnter;
            panelBtnBuscar.MouseLeave += panel1_MouseLeave;
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
            labelend.MouseEnter += labelend_MouseEnter;
            labelend.MouseLeave += labelend_MouseLeave;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Image = Properties.Resources.search_b;
            btnBuscar.Location = new Point(0, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(29, 29);
            btnBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            btnBuscar.TabIndex = 67;
            btnBuscar.TabStop = false;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
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
            btnBuscarF.MouseLeave += btnBuscarF_MouseLeave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(682, 436);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 65;
            label2.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.None;
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(682, 460);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(165, 29);
            txtBairro.TabIndex = 64;
            txtBairro.KeyDown += txtBairro_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(550, 436);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 63;
            label1.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.None;
            txtComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(550, 460);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(126, 29);
            txtComplemento.TabIndex = 62;
            txtComplemento.KeyDown += txtComplemento_KeyDown;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.None;
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(756, 356);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(71, 21);
            lblNumero.TabIndex = 61;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.None;
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(756, 380);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(71, 29);
            txtNumero.TabIndex = 60;
            txtNumero.KeyDown += txtNumero_KeyDown;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtEnd2
            // 
            txtEnd2.Anchor = AnchorStyles.None;
            txtEnd2.AutoSize = true;
            txtEnd2.Location = new Point(853, 468);
            txtEnd2.Name = "txtEnd2";
            txtEnd2.Size = new Size(12, 15);
            txtEnd2.TabIndex = 59;
            txtEnd2.Text = "-";
            txtEnd2.Visible = false;
            // 
            // ListView
            // 
            ListView.Anchor = AnchorStyles.None;
            ListView.Columns.AddRange(new ColumnHeader[] { Id, Nome, Cpf, Rg });
            ListView.Cursor = Cursors.Hand;
            ListView.FullRowSelect = true;
            ListView.Location = new Point(897, 657);
            ListView.Name = "ListView";
            ListView.Size = new Size(297, 142);
            ListView.TabIndex = 57;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            ListView.Visible = false;
            ListView.MouseClick += ListView_MouseClick;
            // 
            // Id
            // 
            Id.Text = "OC";
            Id.Width = 50;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // Cpf
            // 
            Cpf.Text = "CPF";
            Cpf.Width = 100;
            // 
            // Rg
            // 
            Rg.Text = "RG";
            Rg.Width = 100;
            // 
            // lblObs
            // 
            lblObs.Anchor = AnchorStyles.None;
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblObs.ForeColor = SystemColors.ControlDarkDark;
            lblObs.Location = new Point(550, 643);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(134, 15);
            lblObs.TabIndex = 56;
            lblObs.Text = "Digite nome, RG ou CPF";
            // 
            // panelbtnCriar
            // 
            panelbtnCriar.Anchor = AnchorStyles.None;
            panelbtnCriar.Controls.Add(lblCriar);
            panelbtnCriar.Controls.Add(btnCriarF);
            panelbtnCriar.Controls.Add(btnCriar);
            panelbtnCriar.Cursor = Cursors.Hand;
            panelbtnCriar.Location = new Point(540, 673);
            panelbtnCriar.Name = "panelbtnCriar";
            panelbtnCriar.Size = new Size(190, 24);
            panelbtnCriar.TabIndex = 55;
            panelbtnCriar.Click += panelbtnCriar_Click;
            panelbtnCriar.MouseEnter += panelbtnCriar_MouseEnter;
            panelbtnCriar.MouseLeave += panelbtnCriar_MouseLeave;
            // 
            // lblCriar
            // 
            lblCriar.AutoSize = true;
            lblCriar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCriar.Location = new Point(38, 0);
            lblCriar.Name = "lblCriar";
            lblCriar.Size = new Size(131, 21);
            lblCriar.TabIndex = 55;
            lblCriar.Text = "Criar responsável";
            lblCriar.Click += lblCriar_Click;
            lblCriar.MouseEnter += lblCriar_MouseEnter;
            lblCriar.MouseLeave += lblCriar_MouseLeave;
            // 
            // btnCriarF
            // 
            btnCriarF.Image = Properties.Resources.mais_b;
            btnCriarF.Location = new Point(3, 0);
            btnCriarF.Name = "btnCriarF";
            btnCriarF.Size = new Size(34, 21);
            btnCriarF.SizeMode = PictureBoxSizeMode.Zoom;
            btnCriarF.TabIndex = 54;
            btnCriarF.TabStop = false;
            btnCriarF.Visible = false;
            btnCriarF.Click += btnCriarF_Click;
            btnCriarF.MouseLeave += btnCriarF_MouseLeave;
            // 
            // btnCriar
            // 
            btnCriar.Image = Properties.Resources.mais;
            btnCriar.Location = new Point(3, 0);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(34, 21);
            btnCriar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCriar.TabIndex = 53;
            btnCriar.TabStop = false;
            btnCriar.MouseEnter += btnCriar_MouseEnter;
            // 
            // txtResponsavel
            // 
            txtResponsavel.Anchor = AnchorStyles.None;
            txtResponsavel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResponsavel.Location = new Point(550, 611);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(296, 29);
            txtResponsavel.TabIndex = 49;
            txtResponsavel.TextChanged += txtResponsavel_TextChanged_1;
            txtResponsavel.Enter += txtResponsavel_Enter;
            // 
            // lblResponsavel
            // 
            lblResponsavel.Anchor = AnchorStyles.None;
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResponsavel.Location = new Point(550, 587);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(100, 21);
            lblResponsavel.TabIndex = 48;
            lblResponsavel.Text = "Responsável:";
            // 
            // CadastroC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1699, 825);
            Controls.Add(Fundo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroC";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Cadastro de crianças";
            Fundo.ResumeLayout(false);
            Fundo.PerformLayout();
            panelBtnBuscar.ResumeLayout(false);
            panelBtnBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarF).EndInit();
            panelbtnCriar.ResumeLayout(false);
            panelbtnCriar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCriarF).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCriar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblNasc;
        private TextBox txtName;
        private DateTimePicker Calendario;
        private Button btnSalvar;
        private Label lblCep;
        private Label lblEndereco;
        private TextBox txtEnd;
        private Label lblSala;
        private Label lbltxtIdade;
        private Label lblIdade;
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
        private TextBox txtParentesco;
        private Label lblParentesco;
        private TextBox txtLastName;
        private Label lblLastName;
        private ComboBox cbSala;
    }
}