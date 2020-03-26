using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using NUnit.Framework;
using dpu_server.UnitTest.Utilities;
using dpu_server.DataLayer;
using dpu_server.Configurations;

namespace dpu_server.UnitTest
{
    [TestFixture]
    public class UnittestDatalayer
    {
        /*
        public UnittestDatalayer()
        {
            using (var db = new FruitFlyContext(SQLContext.TestDbContextOptions()))
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
        */
        [Test]
        public void CreateReferencepoint()
        {

        }

        [Test]
        public void CreateHeatmap()
        {

        }

        [Test]
        public void RemoveReferencepoint()
        {

        }

        [Test]
        public void RemoveHeatmap()
        {

        }

        [Test]
        public void UpdateReferencepoint()
        {

        }

        [Test]
        public void UpdateHeatmap()
        {

        }

        [Test]
        public void DoesReferencepointExist()
        {

        }

        [Test]
        public void DoesHeatmapExist()
        {

        }

        [Test]
        public void UpdateReferencepointCategory()
        {

        }

        [Test]
        public void UpdateHeatmapStrength()
        {

        }
    }
}
