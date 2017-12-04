using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Interface;
using Rampup.Atv2.Class.Models;
using Rampup.Atv2.Class.Repository;

namespace Rampup.Atv2.Class.Services
{
    // SERVICE [interface, model, repository]
    //      - herda da Interface<model>
    //      - metodos da SERVICE só chama os métodos da REPOSITORY
    public class ClientService : IClient<ClientModel>
    {
        // DECLARA REPOSITORY
        ClientRepository clientRepository = new ClientRepository();
        

        // SERVICE BASICAMENTE SÓ RE-IMPLEMENTA REPOSITORY (usando interface + model)
        // ----------------------------------------------- [ CREATE ]
        public void Create(ClientModel client){
            clientRepository.Create(client);
        }

        // ----------------------------------------------- [ UPDATE ]
        public void Update(int ID, ClientModel client){
            clientRepository.Update(ID, client);
        }

        // ----------------------------------------------- [ FIND ALL ]
        public List<ClientModel> FindAll(){
            return clientRepository.FindAll();
        }

        // ----------------------------------------------- [ FIND ONE ]
        public ClientModel FindOne(int ID){
            return clientRepository.FindOne(ID);
        }

        // ----------------------------------------------- [ DELETE ]
        public Boolean Delete(int ID){
            return clientRepository.Delete(ID);
        }
    }
}
