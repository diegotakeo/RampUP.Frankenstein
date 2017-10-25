namespace Rampup.Atv2.Construtor
{
    partial class WindowsFormTabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormTabs));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Salve = new System.Windows.Forms.Button();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.cb_TypePerson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TypeAccount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Opening_Balance = new System.Windows.Forms.TextBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cliente = new System.Windows.Forms.TabPage();
            this.mov = new System.Windows.Forms.TabPage();
            this.cb_Movement = new System.Windows.Forms.ComboBox();
            this.btn_Move = new System.Windows.Forms.Button();
            this.txt_ValueM = new System.Windows.Forms.TextBox();
            this.txt_IDM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.conta = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridContas = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TabPage();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.cliente.SuspendLayout();
            this.mov.SuspendLayout();
            this.conta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContas)).BeginInit();
            this.search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Conta:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(57, 35);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(222, 20);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.Text = "1";
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(57, 33);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(222, 20);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.Text = "Fulanozinho";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(57, 82);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(100, 20);
            this.txt_CPF.TabIndex = 4;
            this.txt_CPF.Text = "123.456.789-77";
            this.txt_CPF.TextChanged += new System.EventHandler(this.txt_CPF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF / CNPJ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dono da conta:";
            // 
            // btn_Salve
            // 
            this.btn_Salve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salve.BackgroundImage")));
            this.btn_Salve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salve.Location = new System.Drawing.Point(231, 218);
            this.btn_Salve.Name = "btn_Salve";
            this.btn_Salve.Size = new System.Drawing.Size(45, 44);
            this.btn_Salve.TabIndex = 10;
            this.btn_Salve.UseVisualStyleBackColor = true;
            this.btn_Salve.Click += new System.EventHandler(this.btn_Salve_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(57, 82);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(222, 20);
            this.txtOwner.TabIndex = 3;
            this.txtOwner.Text = "Fulanozinho";
            // 
            // cb_TypePerson
            // 
            this.cb_TypePerson.FormattingEnabled = true;
            this.cb_TypePerson.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cb_TypePerson.Location = new System.Drawing.Point(182, 82);
            this.cb_TypePerson.Name = "cb_TypePerson";
            this.cb_TypePerson.Size = new System.Drawing.Size(97, 21);
            this.cb_TypePerson.TabIndex = 5;
            this.cb_TypePerson.Text = "Física";
            this.cb_TypePerson.SelectedIndexChanged += new System.EventHandler(this.cb_TypePerson_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Pessoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Conta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cb_TypeAccount
            // 
            this.cb_TypeAccount.FormattingEnabled = true;
            this.cb_TypeAccount.Items.AddRange(new object[] {
            "Corrente",
            "Poupança"});
            this.cb_TypeAccount.Location = new System.Drawing.Point(57, 185);
            this.cb_TypeAccount.Name = "cb_TypeAccount";
            this.cb_TypeAccount.Size = new System.Drawing.Size(90, 21);
            this.cb_TypeAccount.TabIndex = 6;
            this.cb_TypeAccount.Text = "Corrente";
            this.cb_TypeAccount.SelectedIndexChanged += new System.EventHandler(this.cb_TypeAccount_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Senha:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(57, 181);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(219, 20);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.Text = "123456789";
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saldo Inicial:";
            // 
            // txt_Opening_Balance
            // 
            this.txt_Opening_Balance.Location = new System.Drawing.Point(172, 186);
            this.txt_Opening_Balance.Name = "txt_Opening_Balance";
            this.txt_Opening_Balance.Size = new System.Drawing.Size(107, 20);
            this.txt_Opening_Balance.TabIndex = 8;
            this.txt_Opening_Balance.Text = "1000,00";
            // 
            // btn_New
            // 
            this.btn_New.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_New.BackgroundImage")));
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.Location = new System.Drawing.Point(176, 217);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(49, 45);
            this.btn_New.TabIndex = 9;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(367, 34);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(625, 133);
            this.dataGridClientes.TabIndex = 19;
            this.dataGridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cliente);
            this.tabControl1.Controls.Add(this.conta);
            this.tabControl1.Controls.Add(this.mov);
            this.tabControl1.Controls.Add(this.search);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 311);
            this.tabControl1.TabIndex = 20;
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.label16);
            this.cliente.Controls.Add(this.txt_clientID);
            this.cliente.Controls.Add(this.label12);
            this.cliente.Controls.Add(this.txtEmail);
            this.cliente.Controls.Add(this.btn_New);
            this.cliente.Controls.Add(this.btn_Salve);
            this.cliente.Controls.Add(this.label2);
            this.cliente.Controls.Add(this.txt_Name);
            this.cliente.Controls.Add(this.txt_Password);
            this.cliente.Controls.Add(this.label3);
            this.cliente.Controls.Add(this.label7);
            this.cliente.Controls.Add(this.txt_CPF);
            this.cliente.Controls.Add(this.label5);
            this.cliente.Controls.Add(this.cb_TypePerson);
            this.cliente.Location = new System.Drawing.Point(4, 22);
            this.cliente.Name = "cliente";
            this.cliente.Padding = new System.Windows.Forms.Padding(3);
            this.cliente.Size = new System.Drawing.Size(341, 285);
            this.cliente.TabIndex = 0;
            this.cliente.Text = "Cadastro de Cliente";
            this.cliente.UseVisualStyleBackColor = true;
            // 
            // mov
            // 
            this.mov.Controls.Add(this.cb_Movement);
            this.mov.Controls.Add(this.btn_Move);
            this.mov.Controls.Add(this.txt_ValueM);
            this.mov.Controls.Add(this.txt_IDM);
            this.mov.Controls.Add(this.label10);
            this.mov.Controls.Add(this.label11);
            this.mov.Controls.Add(this.label9);
            this.mov.Location = new System.Drawing.Point(4, 22);
            this.mov.Name = "mov";
            this.mov.Padding = new System.Windows.Forms.Padding(3);
            this.mov.Size = new System.Drawing.Size(341, 285);
            this.mov.TabIndex = 1;
            this.mov.Text = "Movimentação";
            this.mov.UseVisualStyleBackColor = true;
            // 
            // cb_Movement
            // 
            this.cb_Movement.FormattingEnabled = true;
            this.cb_Movement.Items.AddRange(new object[] {
            "Saque",
            "Depósito"});
            this.cb_Movement.Location = new System.Drawing.Point(169, 40);
            this.cb_Movement.Name = "cb_Movement";
            this.cb_Movement.Size = new System.Drawing.Size(121, 21);
            this.cb_Movement.TabIndex = 13;
            this.cb_Movement.Text = "Saque";
            this.cb_Movement.SelectedIndexChanged += new System.EventHandler(this.cb_Movement_SelectedIndexChanged);
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(169, 80);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(121, 25);
            this.btn_Move.TabIndex = 12;
            this.btn_Move.Text = "Executar";
            this.btn_Move.UseVisualStyleBackColor = true;
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // txt_ValueM
            // 
            this.txt_ValueM.Location = new System.Drawing.Point(42, 85);
            this.txt_ValueM.Name = "txt_ValueM";
            this.txt_ValueM.Size = new System.Drawing.Size(110, 20);
            this.txt_ValueM.TabIndex = 11;
            this.txt_ValueM.Text = "500,00";
            // 
            // txt_IDM
            // 
            this.txt_IDM.Location = new System.Drawing.Point(42, 40);
            this.txt_IDM.Name = "txt_IDM";
            this.txt_IDM.Size = new System.Drawing.Size(110, 20);
            this.txt_IDM.TabIndex = 10;
            this.txt_IDM.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Movimentação";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Número da Conta";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // conta
            // 
            this.conta.Controls.Add(this.txtBanco);
            this.conta.Controls.Add(this.label13);
            this.conta.Controls.Add(this.button1);
            this.conta.Controls.Add(this.txtOwner);
            this.conta.Controls.Add(this.button2);
            this.conta.Controls.Add(this.txt_ID);
            this.conta.Controls.Add(this.label8);
            this.conta.Controls.Add(this.label1);
            this.conta.Controls.Add(this.cb_TypeAccount);
            this.conta.Controls.Add(this.txt_Opening_Balance);
            this.conta.Controls.Add(this.label4);
            this.conta.Controls.Add(this.label6);
            this.conta.Location = new System.Drawing.Point(4, 22);
            this.conta.Name = "conta";
            this.conta.Size = new System.Drawing.Size(341, 285);
            this.conta.TabIndex = 2;
            this.conta.Text = "Cadastro de Conta";
            this.conta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(179, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 43);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(232, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Text = "fulanozinho@programmers.com.br";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(57, 132);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(222, 20);
            this.txtBanco.TabIndex = 23;
            this.txtBanco.Text = "Banco do Brasil";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Banco:";
            // 
            // dataGridContas
            // 
            this.dataGridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContas.Location = new System.Drawing.Point(367, 197);
            this.dataGridContas.Name = "dataGridContas";
            this.dataGridContas.Size = new System.Drawing.Size(625, 122);
            this.dataGridContas.TabIndex = 21;
            this.dataGridContas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridContas_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(364, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Clientes Cadastrados:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(365, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Contas Bancárias Cadastradas: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Unique ID:";
            // 
            // txt_clientID
            // 
            this.txt_clientID.Location = new System.Drawing.Point(57, 238);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.Size = new System.Drawing.Size(100, 20);
            this.txt_clientID.TabIndex = 17;
            this.txt_clientID.Text = "1";
            // 
            // search
            // 
            this.search.Controls.Add(this.btnSearch);
            this.search.Controls.Add(this.txtSearchName);
            this.search.Controls.Add(this.label17);
            this.search.Location = new System.Drawing.Point(4, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(341, 285);
            this.search.TabIndex = 3;
            this.search.Text = "Pesquisar";
            this.search.UseVisualStyleBackColor = true;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(58, 48);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(110, 20);
            this.txtSearchName.TabIndex = 15;
            this.txtSearchName.Text = "Fulanozinho";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Nome do Cliente";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(174, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 20);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // WindowsFormTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 344);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridContas);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "WindowsFormTabs";
            this.Text = "Simlador de Conta Bancária";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            this.mov.ResumeLayout(false);
            this.mov.PerformLayout();
            this.conta.ResumeLayout(false);
            this.conta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContas)).EndInit();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Salve;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.ComboBox cb_TypePerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TypeAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Opening_Balance;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cliente;
        private System.Windows.Forms.TabPage mov;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Movement;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.TextBox txt_ValueM;
        private System.Windows.Forms.TextBox txt_IDM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TabPage conta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridContas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_clientID;
        private System.Windows.Forms.TabPage search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label17;
    }
}

