using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Models;

namespace Rampup.Atv2.Class
{
    public sealed class BankAccountList

    {
        private static readonly BankAccountList _instance = new BankAccountList();
        public static BankAccountList Instance { get { return _instance; } }

        public List<BankAccountModel> Lista { get; set; }

        public BankAccountList(){
            this.Lista = new List<BankAccountModel>();
        }
    }


}
