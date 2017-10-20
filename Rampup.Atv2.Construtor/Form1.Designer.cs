namespace Rampup.Atv2.Construtor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Salve = new System.Windows.Forms.Button();
            this.txt_Bank = new System.Windows.Forms.TextBox();
            this.cb_TypePerson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TypeAccount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Opening_Balance = new System.Windows.Forms.TextBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Conta:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(16, 41);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(138, 41);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(222, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(385, 41);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(100, 20);
            this.txt_CPF.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Banco:";
            // 
            // btn_Salve
            // 
            this.btn_Salve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salve.BackgroundImage")));
            this.btn_Salve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salve.Location = new System.Drawing.Point(12, 147);
            this.btn_Salve.Name = "btn_Salve";
            this.btn_Salve.Size = new System.Drawing.Size(45, 45);
            this.btn_Salve.TabIndex = 8;
            this.btn_Salve.UseVisualStyleBackColor = true;
            this.btn_Salve.Click += new System.EventHandler(this.btn_Salve_Click);
            // 
            // txt_Bank
            // 
            this.txt_Bank.Location = new System.Drawing.Point(506, 41);
            this.txt_Bank.Name = "txt_Bank";
            this.txt_Bank.Size = new System.Drawing.Size(90, 20);
            this.txt_Bank.TabIndex = 9;
            // 
            // cb_TypePerson
            // 
            this.cb_TypePerson.FormattingEnabled = true;
            this.cb_TypePerson.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cb_TypePerson.Location = new System.Drawing.Point(12, 108);
            this.cb_TypePerson.Name = "cb_TypePerson";
            this.cb_TypePerson.Size = new System.Drawing.Size(95, 21);
            this.cb_TypePerson.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Pessoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Conta:";
            // 
            // cb_TypeAccount
            // 
            this.cb_TypeAccount.FormattingEnabled = true;
            this.cb_TypeAccount.Items.AddRange(new object[] {
            "Corrente",
            "Poupança"});
            this.cb_TypeAccount.Location = new System.Drawing.Point(138, 107);
            this.cb_TypeAccount.Name = "cb_TypeAccount";
            this.cb_TypeAccount.Size = new System.Drawing.Size(100, 21);
            this.cb_TypeAccount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Senha:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(263, 108);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(97, 20);
            this.txt_Password.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saldo Inicial:";
            // 
            // txt_Opening_Balance
            // 
            this.txt_Opening_Balance.Location = new System.Drawing.Point(385, 108);
            this.txt_Opening_Balance.Name = "txt_Opening_Balance";
            this.txt_Opening_Balance.Size = new System.Drawing.Size(90, 20);
            this.txt_Opening_Balance.TabIndex = 17;
            // 
            // btn_New
            // 
            this.btn_New.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_New.BackgroundImage")));
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.Location = new System.Drawing.Point(67, 147);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(49, 45);
            this.btn_New.TabIndex = 18;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 221);
            this.dataGridView1.TabIndex = 19;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.txt_Opening_Balance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_TypeAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_TypePerson);
            this.Controls.Add(this.txt_Bank);
            this.Controls.Add(this.btn_Salve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_Bank;
        private System.Windows.Forms.ComboBox cb_TypePerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TypeAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Opening_Balance;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

