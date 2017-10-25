using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Models;

namespace Rampup.Atv2.Class.Repository
{
    public class BankAccountRepository
    {
        List<BankAccountModel> accountList = BankAccountList.Instance.Lista;

        // ----------------------------------------------- [ CREATE ]
        public void Create(BankAccountModel account)
        {
            accountList.Add(account);
        }

        // ----------------------------------------------- [ UPDATE ]
        public void Update(int ID, BankAccountModel account)
        {
            // FIND BASED UPON ID
            var a = accountList.Where(x => x.ID == ID).FirstOrDefault();
            a = account;
        }

        // ----------------------------------------------- [ FIND ALL ]
        public List<BankAccountModel> FindAll()
        {
            return accountList;
        }

        // ----------------------------------------------- [ FIND ONE ]
        public BankAccountModel FindOne(int ID)
        {
            var account = accountList.Where(x => x.ID == ID).FirstOrDefault();
            return account;
        }

        // ----------------------------------------------- [ DELETE ]
        public Boolean Delete(int ID)
        {
            var itemToBeRemoved = accountList.Single(r => r.ID == ID);
            accountList.Remove(itemToBeRemoved);
            return true;
        }

        // ----------------------------------------------- [ SAQUE ]
        public double CashWithdrawal(int ID, double Amount)
        {
            var account = accountList.Where(x => x.ID == ID).FirstOrDefault();
            return account.Balance -= Amount;
        }
        // ----------------------------------------------- [ DEPOSITO ]
        public double MoneyDeposit(int ID, double Amount)
        {
            var account = accountList.Where(x => x.ID == ID).FirstOrDefault();
            return account.Balance += Amount;
        }

    }
}
