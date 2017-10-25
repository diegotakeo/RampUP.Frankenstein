using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv2.Class.Models
{
    public class BankAccountModel
    {
        public int ID               { get; set; }
        public string Owner         { get; set; }
        public double Balance       { get; set; }
        public string Bank          { get; set; }
        public string AccountType   { get; set; }
    }
}
