using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Models;

namespace Rampup.Atv2.Class
{
    public sealed class ListAccounts
    {
        private static readonly ListAccounts _instance = new ListAccounts();
        public static ListAccounts Instance { get { return _instance; } }

        public List<Conta> Lista { get; set; }

        public ListAccounts(){
            this.Lista = new List<Conta>();
        }
    }


}
