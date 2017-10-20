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
    public partial class Movimentacao : Form
    {

        public Movimentacao()
        {
            InitializeComponent();
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            
            int numeroConta = Convert.ToInt32(txt_IDM.Text);
            string valueCombo = cb_Movement.Text;
            var NewValue = Convert.ToDouble(txt_ValueM.Text);
            double ValueReturn = 0;

            var list = ListContas.Instance.Lista.ToList();
            var acc =list.Where(x => x.IDAccount == numeroConta).FirstOrDefault();

           
            Conta c = new Conta();
          

           if (valueCombo == "Saque")
           {
               ValueReturn = c.Saca(acc.Balance, NewValue);

           }
            else if (valueCombo == "Depósito")
           {
              ValueReturn = c.Deposita(acc.Balance, NewValue);
           }

           MessageBox.Show("O seu saldo atual é: " + Convert.ToString(ValueReturn));

            // Realiza o Update na instancia da lista
            acc.Balance = ValueReturn;

            //var lista = ListContas.Instance.Lista.ToList();
            //dataGridView1.DataSource = null;
           // dataGridView1.DataSource = lista;

            
        }
    }
}
