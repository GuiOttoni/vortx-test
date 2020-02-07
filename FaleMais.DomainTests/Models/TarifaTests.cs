using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaleMais.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaleMais.Domain.Models.Tests
{
    [TestClass()]
    public class TarifaTests
    {
        [TestMethod()]
        public void ToDTONullTest()
        {
            Tarifa tarifa = new Tarifa();
            DTO.RequestTarifa request = new DTO.RequestTarifa();
            DTO.ResponseTarifa response = tarifa.ToDTO(request);
            Assert.IsNotNull(response);
        }
    }
}