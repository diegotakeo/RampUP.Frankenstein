using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampup.Atv2.Class.Models;

namespace Rampup.Atv2.Class.Interface
{
    public interface IClient<T> where T : class
    {
        void Create(T obj);
        void Update(int ID, ClientModel client);
        List<ClientModel> FindAll();
        ClientModel FindOne(int ID);
        Boolean Delete(int ID);
    }
}
