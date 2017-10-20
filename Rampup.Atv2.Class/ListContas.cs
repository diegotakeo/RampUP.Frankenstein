using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv2.Class
{
    public sealed class ListContas
    {
        private static readonly ListContas _instance = new ListContas();
        public static ListContas Instance { get { return _instance; } }

        public List<Conta> Lista { get; set; }

        public ListContas()
        {
            this.Lista = new List<Conta>();
        }
    }


}
