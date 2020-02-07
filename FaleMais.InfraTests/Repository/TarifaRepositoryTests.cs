using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaleMais.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace FaleMais.Infra.Repository.Tests
{
    [TestClass()]
    public class TarifaRepositoryTests
    {
        [TestMethod()]
        public void RepositoryBasicTest()
        {

            var options = new DbContextOptionsBuilder<Context>()
                    .UseSqlite("DataSource=:memory:")
                    .Options;

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new Context(options))
            {
                Assert.AreEqual(7, context.Tarifa.Count());
            }

        }
    }
}