using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rampup.Atv2.Class;

namespace Rampup.Atv2.Construtor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public enum TipoConta
        {
            Conta_corrente,
            Conta_poupanca,
        }

        public enum TipoPessoa
        {
            Pessoa_fisica,
            Pessoa_Juridica,
        }

        

        private void btn_Salve_Click(object sender, EventArgs e)
        {
            var ct = new Conta();
            ct.IDAccount = Convert.ToInt32(txt_ID.Text);
            ct.Name = txt_Name.Text;
            ct.CPF = txt_CPF.Text;
            ct.Bank = txt_Bank.Text;
            ct.Password = txt_Password.Text;
            ct.Balance = Convert.ToDouble(txt_Opening_Balance.Text);


            var list = ListContas.Instance.Lista.ToList();
            var acc = list.Where(x => x.IDAccount == ct.IDAccount).FirstOrDefault();

            if(acc == null)
            {

                MessageBox.Show("A conta: " + ct.IDAccount + "\nCliente: " + ct.Name + "\nCPF: " + ct.CPF + "\nBanco: " + ct.Bank + "\nSenha: " + ct.Password + "\nSaldo Inicial: " + ct.Balance);

                if (cb_TypeAccount.Text == "Corrente")
                {
                    MessageBox.Show("Tipo da Conta: " + TipoConta.Conta_corrente.ToString());
                }
                else
                {
                    MessageBox.Show("Tipo da Conta: " + TipoConta.Conta_corrente.ToString());
                }


                if (cb_TypePerson.Text == "Física")
                {
                    MessageBox.Show("Tipo de Pessoa: " + TipoPessoa.Pessoa_fisica.ToString());
                }
                else
                {
                    MessageBox.Show("Tipo de Pessoa: " + TipoPessoa.Pessoa_Juridica.ToString());
                }
                ListContas.Instance.Lista.Add(ct);
            }
            else
            {
                MessageBox.Show("Conta Já Existe");
            }

            List<Conta> showList = ListContas.Instance.Lista;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = showList;

            ct = null;
            GC.Collect();
           
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_Name.Clear();
            txt_CPF.Clear();
            txt_Bank.Clear();
            cb_TypePerson.SelectedIndex= -1;
            cb_TypeAccount.SelectedIndex = -1;
            txt_Password.Clear();
            txt_Opening_Balance.Clear();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
