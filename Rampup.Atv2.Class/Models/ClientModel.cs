﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv2.Class.Models
{
    public class ClientModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CPF_CNPJ { get; set; }
        public string ClientType { get; set; }

        public ClientModel(int ID, string Name, string Email, string Password, string CPF_CNPJ, string ClientType)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.CPF_CNPJ = CPF_CNPJ;
            this.ClientType = ClientType;
        }

        public ClientModel() {}
    }
}
