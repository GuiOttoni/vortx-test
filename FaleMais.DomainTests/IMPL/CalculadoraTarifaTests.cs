using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaleMais.Domain.IMPL;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaleMais.Domain.IMPL.Tests
{
    [TestClass()]
    public class CalculadoraTarifaTests
    {
        private DTO.ResponseTarifa tarifa30;
        private DTO.ResponseTarifa tarifa60;
        private DTO.ResponseTarifa tarifa120;
        private DTO.ResponseTarifa tarifaSemPlano;

        [TestInitialize]
        public void Setup()
        {
            tarifa30 = new DTO.ResponseTarifa()
            {
                PrecoMinuto = 1.2,
                Plano = Enums.Planos.FaleMais30,
                Tempo = 40
            };

            tarifa60 = new DTO.ResponseTarifa()
            {
                PrecoMinuto = 1.2,
                Plano = Enums.Planos.FaleMais60,
                Tempo = 75
            };

            tarifa120 = new DTO.ResponseTarifa()
            {
                PrecoMinuto = 1.2,
                Plano = Enums.Planos.FaleMais120,
                Tempo = 150
            };

            tarifaSemPlano = new DTO.ResponseTarifa()
            {
                PrecoMinuto = 1.2,
                Tempo = 95,
                Plano = null
            };

        }

        [TestMethod()]
        public void CalculoSemPlanoTest()
        {
            Assert.AreEqual(CalculadoraTarifa.CalculoSemPlano(tarifa30), 48);
        }

        [TestMethod()]
        public void CalculoSemPlanoNull()
        {
            Assert.AreEqual(CalculadoraTarifa.CalculoSemPlano(tarifaSemPlano), 114);
        }

        [TestMethod()]
        public void CalculoComPlano30()
        {
            Assert.AreEqual((int)CalculadoraTarifa.CalculoComPlano(tarifa30), 13);
        }

        [TestMethod()]
        public void CalculoComPlano60()
        {
            Assert.AreEqual((int)CalculadoraTarifa.CalculoComPlano(tarifa60), 19);
        }

        [TestMethod()]
        public void CalculoComPlano120()
        {
            Assert.AreEqual((int)CalculadoraTarifa.CalculoComPlano(tarifa120), 39);
        }

        [TestMethod()]
        public void CalculoComPlanoNull()
        {
            Assert.AreEqual(CalculadoraTarifa.CalculoComPlano(tarifaSemPlano), 0);
        }
    }
}