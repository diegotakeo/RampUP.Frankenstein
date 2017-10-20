using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rampup.Atv2.Class
{
    public class Conta
    {
        // Criando atributos da classe
        public int IDAccount { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
        public string Password { get; set; }

        public Conta()
        {
            this.IDAccount = IDAccount;
            this.Name = Name;
            this.CPF = CPF;
            this.Balance = Balance;
            this.Bank = Bank;
            this.Password = Password;
        }
        // Encapsulando os atributos da classe Conta
        public Conta(int id, string name, string cpf, double balance, string bank, string password)
        {
            this.IDAccount = id;
            this.Name = name;
            this.CPF = cpf;
            this.Balance = balance;
            this.Bank = bank;
            this.Password = password;
        }
  
       ~Conta(){

            System.Diagnostics.Debug.WriteLine("Destructor called.");
 
        }

        public double Saca(double current, double valor)
        {
            current -= valor;
            return current;
        }

        public double Deposita(double current, double valor)
        {
            current += valor;
            return current;
        }

    }

}
