using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dpu_server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dpu_server.Configurations
{
    public class ReferencepointConfiguration : IEntityTypeConfiguration<Referencepoint>
    {
        public void Configure(EntityTypeBuilder<Referencepoint> entity)
        {
            var rand = new Random();
            //250 referencepoints for testing
            



        }
    }
}
