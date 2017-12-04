using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv2.Class.Models
{
    public class CompanyClientModel : ClientModel
    {
        public string CNPJ { get; set; }

        public CompanyClientModel(ClientModel client, string CNPJ)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.ClientType = ClientType;
            this.CNPJ = CNPJ;
        }
    }
}
