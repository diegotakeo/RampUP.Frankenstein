using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Models;
namespace Rampup.Atv2.Class.Repository
{
    // REPOSITORY IMPLEMENTA CRUD!
    public class ClientRepository
    {
        List<ClientModel> clientList = ClientList.Instance.Lista;

        // ----------------------------------------------- [ CREATE CLIENT ]
        public void Create(ClientModel client){
            clientList.Add(client);
        }

        // ----------------------------------------------- [ UPDATE CLIENT ]
        public void Update(int ID, ClientModel client){
            // FIND BASED UPON ID
            var c = clientList.Where(x => x.ID == ID).FirstOrDefault();
            c = client;
        }

        // ----------------------------------------------- [ FIND ALL CLIENTS ]
        public List<ClientModel> FindAll(){
            return clientList;
        }

        // ----------------------------------------------- [ FIND ONE CLIENT ]
        public ClientModel FindOne(int ID){
            var client = clientList.Where(x => x.ID == ID).FirstOrDefault();
            return client;
        }

        // ----------------------------------------------- [ DELETE CLIENT ]
        public Boolean Delete(int ID){
            var itemToBeRemoved = clientList.Single(r => r.ID == ID);
            clientList.Remove(itemToBeRemoved);
            return true;
        }
    }
}
