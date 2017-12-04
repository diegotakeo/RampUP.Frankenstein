using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Interface;
using Rampup.Atv2.Class.Models;
using Rampup.Atv2.Class.Repository;

namespace Rampup.Atv2.Class.Services
{
    public class BankAccountService : IBankAccount<BankAccountModel>
    {
            // DECLARA REPOSITORY
            BankAccountRepository accountRepository = new BankAccountRepository();


            // SERVICE BASICAMENTE SÓ RE-IMPLEMENTA REPOSITORY (usando interface + model)
            // ----------------------------------------------- [ CREATE ]
            public void Create(BankAccountModel account)
            {
                accountRepository.Create(account);
            }

            // ----------------------------------------------- [ UPDATE ]
            public void Update(int ID, BankAccountModel account)
            {
                accountRepository.Update(ID, account);
            }

            // ----------------------------------------------- [ FIND ALL ]
            public List<BankAccountModel> FindAll()
            {
                return accountRepository.FindAll();
            }

            // ----------------------------------------------- [ FIND ONE ]
            public BankAccountModel FindOne(int ID)
            {
                return accountRepository.FindOne(ID);
            }

            // ----------------------------------------------- [ DELETE ]
            public Boolean Delete(int ID)
            {
                return accountRepository.Delete(ID);
            }
            // ----------------------------------------------- [ SAQUE ]
            public double CashWithdrawal(int ID, double Amount)
            {
                return accountRepository.CashWithdrawal(ID, Amount);
            }
            // ----------------------------------------------- [ DEPOSITO ]
            public double MoneyDeposit(int ID, double Amount)
            {
                return accountRepository.MoneyDeposit(ID, Amount);
            }

    }
}
