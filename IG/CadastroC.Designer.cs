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
            this.Fundo = new System.Windows.Forms.Panel();
            this.cbResponsavel = new System.Windows.Forms.ComboBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.Fundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(104, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNasc.Location = new System.Drawing.Point(104, 168);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(150, 21);
            this.lblNasc.TabIndex = 1;
            this.lblNasc.Text = "Data de nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(104, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRg.Location = new System.Drawing.Point(104, 245);
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
            this.Calendario.Location = new System.Drawing.Point(104, 192);
            this.Calendario.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Calendario.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(200, 29);
            this.Calendario.TabIndex = 6;
            this.Calendario.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            this.Calendario.ValueChanged += new System.EventHandler(this.Calendario_ValueChanged);
            this.Calendario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calendario_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(498, 527);
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
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.Location = new System.Drawing.Point(104, 322);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(40, 21);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(227, 322);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnd.Location = new System.Drawing.Point(229, 346);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(200, 29);
            this.txtEnd.TabIndex = 13;
            this.txtEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnd_KeyDown);
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSala.Location = new System.Drawing.Point(104, 423);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(150, 29);
            this.txtSala.TabIndex = 14;
            this.txtSala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSala_KeyDown);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSala.Location = new System.Drawing.Point(104, 399);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(42, 21);
            this.lblSala.TabIndex = 15;
            this.lblSala.Text = "Sala:";
            // 
            // txtEndr
            // 
            this.txtEndr.Location = new System.Drawing.Point(740, 382);
            this.txtEndr.Name = "txtEndr";
            this.txtEndr.Size = new System.Drawing.Size(150, 23);
            this.txtEndr.TabIndex = 27;
            this.txtEndr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndr_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(675, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(703, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "CEP:";
            // 
            // Calendarior
            // 
            this.Calendarior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Calendarior.Location = new System.Drawing.Point(740, 180);
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
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(709, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "RG:";
            // 
            // txtNomer
            // 
            this.txtNomer.Location = new System.Drawing.Point(740, 137);
            this.txtNomer.Name = "txtNomer";
            this.txtNomer.Size = new System.Drawing.Size(150, 23);
            this.txtNomer.TabIndex = 20;
            this.txtNomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomer_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(619, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data de nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(691, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nome:";
            // 
            // lblcpfr
            // 
            this.lblcpfr.AutoSize = true;
            this.lblcpfr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblcpfr.Location = new System.Drawing.Point(703, 301);
            this.lblcpfr.Name = "lblcpfr";
            this.lblcpfr.Size = new System.Drawing.Size(31, 15);
            this.lblcpfr.TabIndex = 29;
            this.lblcpfr.Text = "CPF:";
            // 
            // lblparentesco
            // 
            this.lblparentesco.AutoSize = true;
            this.lblparentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblparentesco.Location = new System.Drawing.Point(666, 424);
            this.lblparentesco.Name = "lblparentesco";
            this.lblparentesco.Size = new System.Drawing.Size(68, 15);
            this.lblparentesco.TabIndex = 30;
            this.lblparentesco.Text = "Parentesco:";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Location = new System.Drawing.Point(740, 421);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Size = new System.Drawing.Size(150, 23);
            this.txtParentesco.TabIndex = 31;
            this.txtParentesco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParentesco_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(225, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(104, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cadastro de Crianças";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(740, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cadastro de Responsáveis";
            // 
            // lbltxtIdade
            // 
            this.lbltxtIdade.AutoSize = true;
            this.lbltxtIdade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxtIdade.Location = new System.Drawing.Point(310, 169);
            this.lbltxtIdade.Name = "lbltxtIdade";
            this.lbltxtIdade.Size = new System.Drawing.Size(50, 20);
            this.lbltxtIdade.TabIndex = 36;
            this.lbltxtIdade.Text = "Idade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(695, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Idade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.Location = new System.Drawing.Point(310, 192);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(19, 21);
            this.lblIdade.TabIndex = 38;
            this.lblIdade.Text = "0";
            // 
            // lblIdader
            // 
            this.lblIdader.AutoSize = true;
            this.lblIdader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIdader.Location = new System.Drawing.Point(740, 222);
            this.lblIdader.Name = "lblIdader";
            this.lblIdader.Size = new System.Drawing.Size(13, 15);
            this.lblIdader.TabIndex = 39;
            this.lblIdader.Text = "0";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCel.Location = new System.Drawing.Point(687, 471);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(47, 15);
            this.lblCel.TabIndex = 40;
            this.lblCel.Text = "Celular:";
            // 
            // txtCelr
            // 
            this.txtCelr.Location = new System.Drawing.Point(740, 468);
            this.txtCelr.Mask = "(99) 00000-0000";
            this.txtCelr.Name = "txtCelr";
            this.txtCelr.Size = new System.Drawing.Size(150, 23);
            this.txtCelr.TabIndex = 41;
            this.txtCelr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCelr_KeyDown);
            this.txtCelr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelr_KeyPress);
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRg.Location = new System.Drawing.Point(104, 269);
            this.txtRg.Mask = "00,000,000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(115, 29);
            this.txtRg.TabIndex = 42;
            this.txtRg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress_1);
            // 
            // txtRgr
            // 
            this.txtRgr.Location = new System.Drawing.Point(740, 251);
            this.txtRgr.Mask = "00,000,000-0";
            this.txtRgr.Name = "txtRgr";
            this.txtRgr.Size = new System.Drawing.Size(150, 23);
            this.txtRgr.TabIndex = 43;
            this.txtRgr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRgr_KeyDown);
            this.txtRgr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRgr_KeyPress_1);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(225, 269);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(115, 29);
            this.txtCpf.TabIndex = 44;
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress_1);
            // 
            // txtCpfr
            // 
            this.txtCpfr.Location = new System.Drawing.Point(740, 298);
            this.txtCpfr.Mask = "000,000,000-00";
            this.txtCpfr.Name = "txtCpfr";
            this.txtCpfr.Size = new System.Drawing.Size(150, 23);
            this.txtCpfr.TabIndex = 45;
            this.txtCpfr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpfr_KeyDown);
            this.txtCpfr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfr_KeyPress_1);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.Location = new System.Drawing.Point(104, 346);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(115, 29);
            this.txtCep.TabIndex = 46;
            this.txtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyDown);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress_1);
            // 
            // txtCepr
            // 
            this.txtCepr.Location = new System.Drawing.Point(740, 343);
            this.txtCepr.Mask = "00000-000";
            this.txtCepr.Name = "txtCepr";
            this.txtCepr.Size = new System.Drawing.Size(150, 23);
            this.txtCepr.TabIndex = 47;
            this.txtCepr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCepr_KeyDown);
            this.txtCepr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCepr_KeyPress_1);
            // 
            // Fundo
            // 
            this.Fundo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Fundo.Controls.Add(this.cbResponsavel);
            this.Fundo.Controls.Add(this.lblResponsavel);
            this.Fundo.Controls.Add(this.Calendarior);
            this.Fundo.Controls.Add(this.label7);
            this.Fundo.Controls.Add(this.txtNomer);
            this.Fundo.Controls.Add(this.txtNome);
            this.Fundo.Controls.Add(this.txtCepr);
            this.Fundo.Controls.Add(this.label6);
            this.Fundo.Controls.Add(this.txtRgr);
            this.Fundo.Controls.Add(this.lblIdade);
            this.Fundo.Controls.Add(this.label3);
            this.Fundo.Controls.Add(this.Calendario);
            this.Fundo.Controls.Add(this.lblIdader);
            this.Fundo.Controls.Add(this.txtEnd);
            this.Fundo.Controls.Add(this.txtEndr);
            this.Fundo.Controls.Add(this.txtSala);
            this.Fundo.Controls.Add(this.label9);
            this.Fundo.Controls.Add(this.lblRg);
            this.Fundo.Controls.Add(this.label4);
            this.Fundo.Controls.Add(this.lblNasc);
            this.Fundo.Controls.Add(this.txtParentesco);
            this.Fundo.Controls.Add(this.lblNome);
            this.Fundo.Controls.Add(this.btnSave);
            this.Fundo.Controls.Add(this.lbltxtIdade);
            this.Fundo.Controls.Add(this.lblcpfr);
            this.Fundo.Controls.Add(this.txtRg);
            this.Fundo.Controls.Add(this.label8);
            this.Fundo.Controls.Add(this.label2);
            this.Fundo.Controls.Add(this.txtCpf);
            this.Fundo.Controls.Add(this.lblCel);
            this.Fundo.Controls.Add(this.txtCep);
            this.Fundo.Controls.Add(this.txtCelr);
            this.Fundo.Controls.Add(this.lblEndereco);
            this.Fundo.Controls.Add(this.label1);
            this.Fundo.Controls.Add(this.lblSala);
            this.Fundo.Controls.Add(this.label5);
            this.Fundo.Controls.Add(this.lblCep);
            this.Fundo.Controls.Add(this.txtCpfr);
            this.Fundo.Controls.Add(this.lblparentesco);
            this.Fundo.Location = new System.Drawing.Point(1, 0);
            this.Fundo.Name = "Fundo";
            this.Fundo.Size = new System.Drawing.Size(1081, 620);
            this.Fundo.TabIndex = 48;
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbResponsavel.FormattingEnabled = true;
            this.cbResponsavel.Location = new System.Drawing.Point(104, 500);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(325, 29);
            this.cbResponsavel.TabIndex = 49;
            this.cbResponsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbResponsavel_KeyDown);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResponsavel.Location = new System.Drawing.Point(104, 476);
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
            this.ClientSize = new System.Drawing.Size(1080, 619);
            this.Controls.Add(this.Fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de crianças";
            this.Fundo.ResumeLayout(false);
            this.Fundo.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel Fundo;
        private Label lblResponsavel;
        private ComboBox cbResponsavel;
    }
}