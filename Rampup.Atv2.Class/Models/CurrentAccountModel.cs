using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv2.Class.Models
{
    public class CurrentAccountModel : BankAccountModel
    {
        public CurrentAccountModel(int ID, string Owner, double Balance, string Bank, string AccountType)
        {
            this.ID = ID;
            this.Owner = Owner;
            this.Balance = Balance;
            this.Bank = Bank;
            this.AccountType = AccountType;
        }
    }
}
