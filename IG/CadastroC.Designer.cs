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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtEndr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calendarior = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcpfr = new System.Windows.Forms.Label();
            this.lblparentesco = new System.Windows.Forms.Label();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltxtIdade = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblIdader = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtCelr = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtRgr = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfr = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCepr = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(106, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(34, 116);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(115, 15);
            this.lblNasc.TabIndex = 1;
            this.lblNasc.Text = "Data de nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(155, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(120, 184);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(25, 15);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG:";
            // 
            // Calendario
            // 
            this.Calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Calendario.Location = new System.Drawing.Point(155, 110);
            this.Calendario.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Calendario.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(150, 23);
            this.Calendario.TabIndex = 6;
            this.Calendario.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            this.Calendario.ValueChanged += new System.EventHandler(this.Calendario_ValueChanged);
            this.Calendario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calendario_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(114, 281);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 15);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(86, 320);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(59, 15);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(155, 320);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(150, 23);
            this.txtEnd.TabIndex = 13;
            this.txtEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnd_KeyDown);
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(155, 365);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(150, 23);
            this.txtSala.TabIndex = 14;
            this.txtSala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSala_KeyDown);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(114, 368);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 15);
            this.lblSala.TabIndex = 15;
            this.lblSala.Text = "Sala:";
            // 
            // txtEndr
            // 
            this.txtEndr.Location = new System.Drawing.Point(698, 312);
            this.txtEndr.Name = "txtEndr";
            this.txtEndr.Size = new System.Drawing.Size(150, 23);
            this.txtEndr.TabIndex = 27;
            this.txtEndr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndr_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "CEP:";
            // 
            // Calendarior
            // 
            this.Calendarior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Calendarior.Location = new System.Drawing.Point(698, 110);
            this.Calendarior.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Calendarior.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.Calendarior.Name = "Calendarior";
            this.Calendarior.Size = new System.Drawing.Size(150, 23);
            this.Calendarior.TabIndex = 23;
            this.Calendarior.Value = new System.DateTime(2022, 10, 6, 0, 0, 0, 0);
            this.Calendarior.ValueChanged += new System.EventHandler(this.Calendarior_ValueChanged);
            this.Calendarior.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calendarior_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "RG:";
            // 
            // txtNomer
            // 
            this.txtNomer.Location = new System.Drawing.Point(698, 67);
            this.txtNomer.Name = "txtNomer";
            this.txtNomer.Size = new System.Drawing.Size(150, 23);
            this.txtNomer.TabIndex = 20;
            this.txtNomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomer_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data de nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nome:";
            // 
            // lblcpfr
            // 
            this.lblcpfr.AutoSize = true;
            this.lblcpfr.Location = new System.Drawing.Point(661, 231);
            this.lblcpfr.Name = "lblcpfr";
            this.lblcpfr.Size = new System.Drawing.Size(31, 15);
            this.lblcpfr.TabIndex = 29;
            this.lblcpfr.Text = "CPF:";
            // 
            // lblparentesco
            // 
            this.lblparentesco.AutoSize = true;
            this.lblparentesco.Location = new System.Drawing.Point(624, 354);
            this.lblparentesco.Name = "lblparentesco";
            this.lblparentesco.Size = new System.Drawing.Size(68, 15);
            this.lblparentesco.TabIndex = 30;
            this.lblparentesco.Text = "Parentesco:";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Location = new System.Drawing.Point(698, 351);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Size = new System.Drawing.Size(150, 23);
            this.txtParentesco.TabIndex = 31;
            this.txtParentesco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParentesco_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cadastro de Crianças";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cadastro de Responsáveis";
            // 
            // lbltxtIdade
            // 
            this.lbltxtIdade.AutoSize = true;
            this.lbltxtIdade.Location = new System.Drawing.Point(110, 152);
            this.lbltxtIdade.Name = "lbltxtIdade";
            this.lbltxtIdade.Size = new System.Drawing.Size(39, 15);
            this.lbltxtIdade.TabIndex = 36;
            this.lbltxtIdade.Text = "Idade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Idade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(155, 152);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(13, 15);
            this.lblIdade.TabIndex = 38;
            this.lblIdade.Text = "0";
            // 
            // lblIdader
            // 
            this.lblIdader.AutoSize = true;
            this.lblIdader.Location = new System.Drawing.Point(698, 152);
            this.lblIdader.Name = "lblIdader";
            this.lblIdader.Size = new System.Drawing.Size(13, 15);
            this.lblIdader.TabIndex = 39;
            this.lblIdader.Text = "0";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(645, 401);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(47, 15);
            this.lblCel.TabIndex = 40;
            this.lblCel.Text = "Celular:";
            // 
            // txtCelr
            // 
            this.txtCelr.Location = new System.Drawing.Point(698, 398);
            this.txtCelr.Mask = "(99) 00000-0000";
            this.txtCelr.Name = "txtCelr";
            this.txtCelr.Size = new System.Drawing.Size(150, 23);
            this.txtCelr.TabIndex = 41;
            this.txtCelr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCelr_KeyDown);
            this.txtCelr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelr_KeyPress);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(155, 181);
            this.txtRg.Mask = "00,000,000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(150, 23);
            this.txtRg.TabIndex = 42;
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress_1);
            // 
            // txtRgr
            // 
            this.txtRgr.Location = new System.Drawing.Point(698, 181);
            this.txtRgr.Mask = "00,000,000-0";
            this.txtRgr.Name = "txtRgr";
            this.txtRgr.Size = new System.Drawing.Size(150, 23);
            this.txtRgr.TabIndex = 43;
            this.txtRgr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRgr_KeyDown);
            this.txtRgr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRgr_KeyPress_1);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(155, 228);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(150, 23);
            this.txtCpf.TabIndex = 44;
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress_1);
            // 
            // txtCpfr
            // 
            this.txtCpfr.Location = new System.Drawing.Point(698, 228);
            this.txtCpfr.Mask = "000,000,000-00";
            this.txtCpfr.Name = "txtCpfr";
            this.txtCpfr.Size = new System.Drawing.Size(150, 23);
            this.txtCpfr.TabIndex = 45;
            this.txtCpfr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpfr_KeyDown);
            this.txtCpfr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfr_KeyPress_1);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(155, 278);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(150, 23);
            this.txtCep.TabIndex = 46;
            this.txtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyDown);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress_1);
            // 
            // txtCepr
            // 
            this.txtCepr.Location = new System.Drawing.Point(698, 273);
            this.txtCepr.Mask = "00000-000";
            this.txtCepr.Name = "txtCepr";
            this.txtCepr.Size = new System.Drawing.Size(150, 23);
            this.txtCepr.TabIndex = 47;
            this.txtCepr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCepr_KeyDown);
            this.txtCepr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCepr_KeyPress_1);
            // 
            // CadastroC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.txtCepr);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCpfr);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRgr);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCelr);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblIdader);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbltxtIdade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParentesco);
            this.Controls.Add(this.lblparentesco);
            this.Controls.Add(this.lblcpfr);
            this.Controls.Add(this.txtEndr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calendarior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroC";
            this.Text = "Cadastro de crianças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblNasc;
        private TextBox txtNome;
        private Label lblRg;
        private DateTimePicker Calendario;
        private Button btnSave;
        private Label lblCep;
        private Label lblEndereco;
        private TextBox txtEnd;
        private TextBox txtSala;
        private Label lblSala;
        private TextBox txtEndr;
        private Label label1;
        private Label label2;
        private DateTimePicker Calendarior;
        private Label label3;
        private TextBox txtNomer;
        private Label label4;
        private Label label5;
        private Label lblcpfr;
        private Label lblparentesco;
        private TextBox txtParentesco;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbltxtIdade;
        private Label label9;
        private Label lblIdade;
        private Label lblIdader;
        private Label lblCel;
        private MaskedTextBox txtCelr;
        private MaskedTextBox txtRg;
        private MaskedTextBox txtRgr;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtCpfr;
        private MaskedTextBox txtCep;
        private MaskedTextBox txtCepr;
    }
}