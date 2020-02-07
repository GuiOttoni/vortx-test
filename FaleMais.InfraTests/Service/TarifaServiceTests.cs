using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaleMais.Infra.Service;
using System;
using System.Collections.Generic;
using System.Text;
using FaleMais.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using FaleMais.Infra.Repository.Interface;
using FaleMais.Domain.DTO;

namespace FaleMais.Infra.Service.Tests
{
    [TestClass()]
    public class TarifaServiceTests
    {
        [TestMethod()]
        public void InjectionTest()
        {

                var options = new DbContextOptionsBuilder<Context>()
                        .UseSqlite("DataSource=:memory:")
                        .Options;

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new Context(options))
            {
                ITarifaRepository tarifaRepository = new TarifaRepository(context);
                TarifaService tarifaService = new TarifaService(tarifaRepository);
                Assert.IsNotNull(tarifaService);
            }
        }

        [TestMethod()]
        public async System.Threading.Tasks.Task GetTarifaTestEmptyAsync()
        {

            var options = new DbContextOptionsBuilder<Context>()
                    .UseSqlite("DataSource=:memory:")
                    .Options;

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new Context(options))
            {
                ITarifaRepository tarifaRepository = new TarifaRepository(context);
                TarifaService tarifaService = new TarifaService(tarifaRepository);

                var request = new RequestTarifa();

                var response = await tarifaService.GetTarifas(request);

                Assert.IsNotNull(response);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public async System.Threading.Tasks.Task GetTarifaTestNullAsync()
        {

            var options = new DbContextOptionsBuilder<Context>()
                    .UseSqlite("DataSource=:memory:")
                    .Options;

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new Context(options))
            {
                ITarifaRepository tarifaRepository = new TarifaRepository(context);
                TarifaService tarifaService = new TarifaService(tarifaRepository);

                var response = await tarifaService.GetTarifas(null);
            }
        }

        [TestMethod()]
        public async System.Threading.Tasks.Task GetTarifaTestValidRequestAsync()
        {

            var options = new DbContextOptionsBuilder<Context>()
                    .UseSqlite("DataSource=:memory:")
                    .Options;

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new Context(options))
            {
                ITarifaRepository tarifaRepository = new TarifaRepository(context);
                TarifaService tarifaService = new TarifaService(tarifaRepository);

                var request = new RequestTarifa();
                request.Origem = 11;
                request.Destino = 17;
                request.Plano = Domain.Enums.Planos.FaleMais30;
                request.Tempo = 40;

                var response = await tarifaService.GetTarifas(request);

                Assert.IsNotNull(response);
                Assert.AreEqual(response.SemFaleMais, 68);
                Assert.AreEqual((int)response.ComFaleMais, 18);
            }
        }

        [TestMethod()]
        public async System.Threading.Tasks.Task GetTarifaTestInvalidRequestAsync()
        {

            var options = new DbContextOptionsBuilder<Context>()
                    .UseSqlite("DataSource=:memory:")
                    .Options;

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new Context(options))
            {
                ITarifaRepository tarifaRepository = new TarifaRepository(context);
                TarifaService tarifaService = new TarifaService(tarifaRepository);

                var request = new RequestTarifa();
                request.Origem = 11;
                request.Destino = 199;
                request.Plano = null;
                request.Tempo = 40;

                var response = await tarifaService.GetTarifas(request);

                Assert.IsNotNull(response);
                Assert.AreEqual(response.SemFaleMais, 0);
                Assert.AreEqual(response.ComFaleMais, 0);
            }
        }

        [TestMethod()]
        public async System.Threading.Tasks.Task GetTarifaTestNotExistRequestAsync()
        {

            var options = new DbContextOptionsBuilder<Context>()
                    .UseSqlite("DataSource=:memory:")
                    .Options;

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new Context(options))
            {
                ITarifaRepository tarifaRepository = new TarifaRepository(context);
                TarifaService tarifaService = new TarifaService(tarifaRepository);

                var request = new RequestTarifa();
                request.Origem = 200;
                request.Destino = 199;
                request.Plano = null;
                request.Tempo = 40;

                var response = await tarifaService.GetTarifas(request);

                Assert.IsNotNull(response);
                Assert.AreEqual(response.SemFaleMais, 0);
                Assert.AreEqual(response.ComFaleMais, 0);
            }
        }


    }
}