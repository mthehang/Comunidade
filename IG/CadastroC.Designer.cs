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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroC));
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
            this.ListView = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Cpf = new System.Windows.Forms.ColumnHeader();
            this.Rg = new System.Windows.Forms.ColumnHeader();
            this.lblObs = new System.Windows.Forms.Label();
            this.panelbtnCriar = new System.Windows.Forms.Panel();
            this.lblCriar = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.PictureBox();
            this.btnCriarF = new System.Windows.Forms.PictureBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.Fundo.SuspendLayout();
            this.panelbtnCriar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriarF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(384, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNasc.Location = new System.Drawing.Point(384, 134);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(150, 21);
            this.lblNasc.TabIndex = 1;
            this.lblNasc.Text = "Data de nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(384, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRg.Location = new System.Drawing.Point(384, 211);
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
            this.Calendario.Location = new System.Drawing.Point(384, 158);
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
            this.btnSalvar.Location = new System.Drawing.Point(505, 535);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.Location = new System.Drawing.Point(384, 288);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(40, 21);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(507, 288);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnd.Location = new System.Drawing.Point(509, 312);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(200, 29);
            this.txtEnd.TabIndex = 13;
            this.txtEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnd_KeyDown);
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSala.Location = new System.Drawing.Point(384, 389);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(150, 29);
            this.txtSala.TabIndex = 14;
            this.txtSala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSala_KeyDown);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSala.Location = new System.Drawing.Point(384, 365);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(42, 21);
            this.lblSala.TabIndex = 15;
            this.lblSala.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(505, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "CPF:";
            // 
            // lbltxtIdade
            // 
            this.lbltxtIdade.AutoSize = true;
            this.lbltxtIdade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxtIdade.Location = new System.Drawing.Point(590, 135);
            this.lbltxtIdade.Name = "lbltxtIdade";
            this.lbltxtIdade.Size = new System.Drawing.Size(50, 20);
            this.lbltxtIdade.TabIndex = 36;
            this.lbltxtIdade.Text = "Idade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.Location = new System.Drawing.Point(590, 158);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(19, 21);
            this.lblIdade.TabIndex = 38;
            this.lblIdade.Text = "0";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRg.Location = new System.Drawing.Point(384, 235);
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
            this.txtCpf.Location = new System.Drawing.Point(505, 235);
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
            this.txtCep.Location = new System.Drawing.Point(384, 312);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(115, 29);
            this.txtCep.TabIndex = 46;
            this.txtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyDown);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress_1);
            // 
            // Fundo
            // 
            this.Fundo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.Fundo.Location = new System.Drawing.Point(-110, -35);
            this.Fundo.Name = "Fundo";
            this.Fundo.Size = new System.Drawing.Size(970, 655);
            this.Fundo.TabIndex = 48;
            this.Fundo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fundo_MouseClick);
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
            this.ListView.Location = new System.Drawing.Point(384, 495);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(296, 131);
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
            this.lblObs.Location = new System.Drawing.Point(384, 498);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(134, 15);
            this.lblObs.TabIndex = 56;
            this.lblObs.Text = "Digite nome, RG ou CPF";
            // 
            // panelbtnCriar
            // 
            this.panelbtnCriar.Controls.Add(this.lblCriar);
            this.panelbtnCriar.Controls.Add(this.btnCriar);
            this.panelbtnCriar.Controls.Add(this.btnCriarF);
            this.panelbtnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelbtnCriar.Location = new System.Drawing.Point(686, 471);
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
            this.lblCriar.Location = new System.Drawing.Point(40, 0);
            this.lblCriar.Name = "lblCriar";
            this.lblCriar.Size = new System.Drawing.Size(131, 21);
            this.lblCriar.TabIndex = 55;
            this.lblCriar.Text = "Criar responsável";
            this.lblCriar.Click += new System.EventHandler(this.lblCriar_Click);
            this.lblCriar.MouseEnter += new System.EventHandler(this.lblCriar_MouseEnter);
            this.lblCriar.MouseLeave += new System.EventHandler(this.lblCriar_MouseLeave);
            // 
            // btnCriar
            // 
            this.btnCriar.Image = ((System.Drawing.Image)(resources.GetObject("btnCriar.Image")));
            this.btnCriar.Location = new System.Drawing.Point(0, 0);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(34, 21);
            this.btnCriar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCriar.TabIndex = 53;
            this.btnCriar.TabStop = false;
            this.btnCriar.MouseEnter += new System.EventHandler(this.btnCriar_MouseEnter);
            // 
            // btnCriarF
            // 
            this.btnCriarF.Image = ((System.Drawing.Image)(resources.GetObject("btnCriarF.Image")));
            this.btnCriarF.Location = new System.Drawing.Point(0, 0);
            this.btnCriarF.Name = "btnCriarF";
            this.btnCriarF.Size = new System.Drawing.Size(34, 21);
            this.btnCriarF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCriarF.TabIndex = 54;
            this.btnCriarF.TabStop = false;
            this.btnCriarF.Visible = false;
            this.btnCriarF.Click += new System.EventHandler(this.btnCriarF_Click);
            this.btnCriarF.MouseLeave += new System.EventHandler(this.btnCriarF_MouseLeave);
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponsavel.Location = new System.Drawing.Point(384, 466);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(296, 29);
            this.txtResponsavel.TabIndex = 49;
            this.txtResponsavel.TextChanged += new System.EventHandler(this.txtResponsavel_TextChanged_1);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResponsavel.Location = new System.Drawing.Point(384, 442);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(165, 21);
            this.lblResponsavel.TabIndex = 48;
            this.lblResponsavel.Text = "Nome do responsável:";
            // 
            // CadastroC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(860, 619);
            this.Controls.Add(this.Fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de crianças";
            this.Fundo.ResumeLayout(false);
            this.Fundo.PerformLayout();
            this.panelbtnCriar.ResumeLayout(false);
            this.panelbtnCriar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriarF)).EndInit();
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
        private TextBox txtResponsavel;
        private PictureBox btnCriar;
        private PictureBox btnCriarF;
        private Panel panelbtnCriar;
        private Label lblCriar;
        private Label lblObs;
        private ListView ListView;
        private ColumnHeader Id;
        private ColumnHeader Nome;
        private ColumnHeader Cpf;
        private ColumnHeader Rg;
    }
}