using dpu_server.DataLayer.Interfaces;
using dpu_server.Models;
using dpu_server.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.ServiceLayer.Services
{
    public class ReferencepointService : CrudService<Referencepoint>, IReferencepointService
    {
        private readonly IReferencepointRepository _ReferenceRepository;
        public ReferencepointService(IReferencepointRepository ReferencepointRepository) : base(ReferencepointRepository)
        {
            _ReferenceRepository = ReferencepointRepository;
        }

        public async Task<bool> DoesReferencepointExist(int referencepointId)
        {
            return await _ReferenceRepository.DoesReferencepointExist(referencepointId);
        }
    }
}
