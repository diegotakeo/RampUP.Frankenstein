using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv2.Class.Models
{
    public class IndividualClientModel : ClientModel
    {
        public string CPF { get; set; }

        public IndividualClientModel(ClientModel client, string CPF)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.ClientType = ClientType;
            this.CPF = CPF;
        }
    }
}
