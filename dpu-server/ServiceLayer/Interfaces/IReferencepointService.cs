using dpu_server.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.ServiceLayer.Interfaces
{
    public interface IReferencepointService : ICrudService<Referencepoint>
    {
        Task<bool> DoesReferencepointExist(int referencepoint);
    }
}
