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
using Rampup.Atv2.Class.Interface;
using Rampup.Atv2.Class.Models;
using Rampup.Atv2.Class.Services;

namespace Rampup.Atv2.Construtor
{
    public partial class WindowsFormTabs : Form
    {

        // ----------------------------------------------------------------------------------- //
        // CALLS INTERFACE
        private readonly IClient<ClientModel> _clientModel;
        private readonly IBankAccount<BankAccountModel> _bankAccountModel;

        // SET METHODS OF INTERFACE (by calling service at the "controller" constructor)
        public WindowsFormTabs()
        {
            InitializeComponent();

            // SET UI DROPDOWN VALUES BASED UPON ENUMS
            cb_TypePerson.DataSource    = Enum.GetValues(typeof(TipoPessoa));
            cb_TypeAccount.DataSource   = Enum.GetValues(typeof(TipoConta));
            cb_Movement.DataSource      = Enum.GetValues(typeof(TipoMov));

            

            // INTERFACE = SERVICE (gets all implemented methods)
            _clientModel = new ClientService();
            _bankAccountModel = new BankAccountService();

        }


        // ----------------------------------------------------------------------------------- //
        // ENUMS
        public enum TipoConta
        {
            Corrente,
            Poupança
        }

        public enum TipoPessoa
        {
            Física,
            Juridica
        }
        public enum TipoMov
        {
            Saque,
            Deposito
        }

        // ----------------------------------------------------------------------------------- //
        // [button] REGISTER CLIENT
        private void btn_Salve_Click(object sender, EventArgs e)
        {
            // GET DATA FROM INPUTS
            var client          = new ClientModel();
            client.ID           = Convert.ToInt32(txt_clientID.Text);
            client.Name         = txt_Name.Text;
            client.Email        = txtEmail.Text;
            client.CPF_CNPJ     = txt_CPF.Text;
            client.Password     = txt_Password.Text;
            client.ClientType   = cb_TypePerson.SelectedItem.ToString();
            
            // SIMULATE DATABASE QUERY
            var clientList = ClientList.Instance.Lista;
            var CPF_Exists = clientList.ToList().Where(x => x.CPF_CNPJ == client.CPF_CNPJ).FirstOrDefault();
            var ID_Exists  = clientList.ToList().Where(x => x.ID == client.ID).FirstOrDefault();

            // IF NOT EXISTS, INSERT!
            if (CPF_Exists == null && ID_Exists == null)
                _clientModel.Create(client);

            if (CPF_Exists != null)
                MessageBox.Show("Esse CPF/CNPJ já foi cadastrado!");

            if (ID_Exists != null)
                MessageBox.Show("Esse ID já foi cadastrado!");


            // UPDATE VIEW
            dataGridClientes.DataSource = null;
            dataGridClientes.DataSource = clientList;

            client = null;
            GC.Collect();
        }

        // ----------------------------------------------------------------------------------- //
        // [button] REGISTER BANK ACCOUNT
        private void button2_Click(object sender, EventArgs e)
        {
            // GET DATA FROM INPUTS
            var ct          = new BankAccountModel();
            ct.ID           = Convert.ToInt32(txt_ID.Text);
            ct.Owner        = txtOwner.Text;
            ct.Bank         = txtBanco.Text;
            ct.Balance      = Convert.ToDouble(txt_Opening_Balance.Text);
            ct.AccountType  = cb_TypeAccount.SelectedItem.ToString();
            
            // SIMULATE DATABASE QUERY
            var bankAccountList = BankAccountList.Instance.Lista;
            var ID_exists = bankAccountList.ToList().Where(x => x.ID == ct.ID).FirstOrDefault();

            // CHECK IF CLIENT EXISTS
            var clientList = ClientList.Instance.Lista;
            var Owner_Exists = clientList.ToList().Where(x => x.Name == ct.Owner).FirstOrDefault();


            // IF NOT EXISTS, INSERT!
            if (ID_exists == null && Owner_Exists != null)
                _bankAccountModel.Create(ct);
                
            if (ID_exists != null)
                MessageBox.Show("Numero da Conta já existe!");

            if (Owner_Exists == null)
                MessageBox.Show("Cliente não existe!");

            // UPDATE VIEW
            dataGridContas.DataSource = null;
            dataGridContas.DataSource = bankAccountList;

            ct = null;
            GC.Collect();
        }


        // ----------------------------------------------------------------------------------- //
        // [button] CLEAR CLIENT FIELDS
        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_CPF.Clear();
            cb_TypePerson.SelectedIndex= -1;
            txtEmail.Clear();
            txt_Password.Clear();
        }
        // ----------------------------------------------------------------------------------- //
        // [button] CLEAR BANK ACCOUNT FIELDS
        private void button1_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txtOwner.Clear();
            txtBanco.Clear();
            txt_Opening_Balance.Clear();
            cb_TypeAccount.SelectedIndex = -1;
        }
        
        // ----------------------------------------------------------------------------------- //
        // ´[ button ] MOVIMENTAÇÃO BANCÁRIA
        private void btn_Move_Click(object sender, EventArgs e)
        {
            int ID               = Convert.ToInt32(txt_IDM.Text);
            double Amount        = Convert.ToDouble(txt_ValueM.Text);
            string movType       = cb_Movement.SelectedItem.ToString();
            double UpdatedAmount = 0;

            switch (movType) {
                case "Saque":
                    UpdatedAmount = _bankAccountModel.CashWithdrawal(ID, Amount);
                    break;
                case "Deposito":
                    UpdatedAmount = _bankAccountModel.MoneyDeposit(ID, Amount);
                    break;
                default:
                    MessageBox.Show("Operação Inválida");
                    break;
            }
            MessageBox.Show("O seu saldo atual é: R$" + UpdatedAmount);
            
            var lista = BankAccountList.Instance.Lista.ToList();
            dataGridContas.DataSource = null;
            dataGridContas.DataSource = lista;
        }

        private void txt_CPF_TextChanged(object sender, EventArgs e){}

        private void label3_Click(object sender, EventArgs e){}

        private void txt_Password_TextChanged(object sender, EventArgs e){}

        private void label7_Click(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e){}

        private void label9_Click(object sender, EventArgs e){}

        private void cb_Movement_SelectedIndexChanged(object sender, EventArgs e){}

        private void cb_TypeAccount_SelectedIndexChanged(object sender, EventArgs e){}

        private void label6_Click(object sender, EventArgs e){}
        
        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void txt_ID_TextChanged(object sender, EventArgs e){}

        private void dataGridContas_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void cb_TypePerson_SelectedIndexChanged(object sender, EventArgs e){}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<BankAccountList> ownedAccounts = new List<BankAccountList>();
            int counter = 0;
            double moneyCounter = 0;
            var bankAccountList = BankAccountList.Instance.Lista;
            int listLength = bankAccountList.Count;
            string ownerName = txtSearchName.Text;

            for(int i = 0; i < listLength; i++)
            {
                if (bankAccountList[i].Owner == ownerName) { 
                    counter++;
                    moneyCounter += bankAccountList[i].Balance;
                }
            }

            MessageBox.Show("O cliente "+ownerName+" possui "+counter+" conta(s) e um saldo combinado de R$"+moneyCounter);
            
        }
    }
 }

