using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Models;

namespace Rampup.Atv2.Class
{
    public sealed class ClientList
    {
        // SET INSTANCE FOR SIMULATING DATABASE
        private static readonly ClientList _instance = new ClientList();
        public static ClientList Instance { get { return _instance; } }

        // GETTER & SETTERS
        public List<ClientModel> Lista { get; set; }

        // CONSTRUCTOR
        public ClientList(){
            this.Lista = new List<ClientModel>();
        }
    }


}
