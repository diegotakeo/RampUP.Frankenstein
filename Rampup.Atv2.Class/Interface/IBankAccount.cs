using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Models;

namespace Rampup.Atv2.Class.Interface
{
    public interface IBankAccount<T> where T : class{
        void Create(T obj);
        void Update(int ID, BankAccountModel account);
        List<BankAccountModel> FindAll();
        BankAccountModel FindOne(int ID);
        Boolean Delete(int ID);
        double CashWithdrawal(int ID, double Amount);
        double MoneyDeposit(int ID, double Amount);

    }
}
