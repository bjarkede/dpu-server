using dpu_server.DataLayer.Interfaces;
using dpu_server.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.DataLayer.Repositories
{
    public class ReferencepointRepository : CrudRepository<Referencepoint>, IReferencepointRepository
    {
        private readonly FruitFlyContext _fruitFlyContext;
        public ReferencepointRepository(FruitFlyContext fruitFlyContext) : base(fruitFlyContext)
        {
            _fruitFlyContext = fruitFlyContext;
        }
        /// <summary>
        /// Checks if referencepoint exist by checking ID
        /// </summary>
        /// <param name="referencepointId">ID of the referencepoint</param>
        /// <returns>Returns true if object exists</returns>
        public async Task<bool> DoesReferencepointExist(int referencepointId)
        {
            return (await base.GetByIdAsync(referencepointId)!= null);
        }
    }
}
