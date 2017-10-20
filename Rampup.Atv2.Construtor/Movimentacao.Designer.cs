namespace Rampup.Atv2.Construtor
{
    partial class Movimentacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDM = new System.Windows.Forms.TextBox();
            this.txt_ValueM = new System.Windows.Forms.TextBox();
            this.btn_Move = new System.Windows.Forms.Button();
            this.cb_Movement = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movimentação";
            // 
            // txt_IDM
            // 
            this.txt_IDM.Location = new System.Drawing.Point(16, 62);
            this.txt_IDM.Name = "txt_IDM";
            this.txt_IDM.Size = new System.Drawing.Size(86, 20);
            this.txt_IDM.TabIndex = 3;
            // 
            // txt_ValueM
            // 
            this.txt_ValueM.Location = new System.Drawing.Point(144, 61);
            this.txt_ValueM.Name = "txt_ValueM";
            this.txt_ValueM.Size = new System.Drawing.Size(112, 20);
            this.txt_ValueM.TabIndex = 4;
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(16, 133);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(75, 23);
            this.btn_Move.TabIndex = 6;
            this.btn_Move.Text = "Movimentar";
            this.btn_Move.UseVisualStyleBackColor = true;
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // cb_Movement
            // 
            this.cb_Movement.FormattingEnabled = true;
            this.cb_Movement.Items.AddRange(new object[] {
            "Saque",
            "Depósito"});
            this.cb_Movement.Location = new System.Drawing.Point(287, 61);
            this.cb_Movement.Name = "cb_Movement";
            this.cb_Movement.Size = new System.Drawing.Size(121, 21);
            this.cb_Movement.TabIndex = 7;
            // 
            // Movimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 175);
            this.Controls.Add(this.cb_Movement);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.txt_ValueM);
            this.Controls.Add(this.txt_IDM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Movimentacao";
            this.Text = "Movimentacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IDM;
        private System.Windows.Forms.TextBox txt_ValueM;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.ComboBox cb_Movement;
    }
}