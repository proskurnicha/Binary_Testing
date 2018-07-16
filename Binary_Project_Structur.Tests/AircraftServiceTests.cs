using Binary_Project_Structure_BLL.Services;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;
using FakeItEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structur.Tests
{
    [TestFixture]
    public class AircraftServiceTests
    {
        [Test]
        public void Create_WhenValidAircraft_ThenReturnAircraft()
        {
            Aircraft aircraft = new Aircraft()
            {
                Id = 154,
                AircraftName = "Test",
                TypeAircraftId = 165
            };
            IRepository<Aircraft> aircrafts = A.Fake<IRepository<Aircraft>>();

            IUnitOfWork context = A.Fake<IUnitOfWork>();

            A.CallTo(() => context.Set<IRepository<Aircraft>>()).Returns(aircrafts);

            A.CallTo(() => aircrafts.Create(aircraft)).Returns(aircraft);
            
            AircraftDto aircraftDto = new AircraftDto()
            {
                Id = 154,
                AircraftName = "Test",
                TypeAircraftId = 165
            };

            AircraftService service = new AircraftService(context);
            AircraftDto aircraftDtoSaved = service.Create(aircraftDto);

            Assert.AreEqual(aircraftDto, aircraftDtoSaved);
        }

    }
}
