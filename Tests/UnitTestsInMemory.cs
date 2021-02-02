﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Model.Repositories;
using Model.Entities;
using Model.Services;
using System;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class UnitTestsInMemory
    {
        DbContextOptions<EFOpleidingenContext> options;
        [TestInitialize]
        public void Initializer() 
        {
            options = new DbContextOptionsBuilder<EFOpleidingenContext>()
                        .UseInMemoryDatabase($"InMemoryDatabase{Guid.NewGuid()}")
                        .Options; 
        }

        [TestMethod]
        public void GetDocentenVoorCampus_Docenten_AantalIsZesDocenten()
        {
            /* geschakeld  naar initilize
            //arrange
            var options = new DbContextOptionsBuilder<EFOpleidingenContext>()
                //UseInMemoryDatabase("InMemoryDatabase").
                .UseInMemoryDatabase($"InMemoryDatabase{Guid.NewGuid()}").
                Options;
            */
            using var context = new EFOpleidingenContext(options);
            
           // context.Landen.Add(new Land { LandCode = "BE", Naam = "België" });

            // Toevoegen campussen 
            context.Campussen.Add(new Campus()
            { CampusId = 1, Naam = "Andros", Straat = "Somersstraat", Huisnummer = "22", Postcode = "2018", Gemeente = "Antwerpen" });
            context.Campussen.Add(new Campus()
            { CampusId = 2, Naam = "Delos", Straat = "Oude Vest", Huisnummer = "17", Postcode = "9200", Gemeente = "Dendermonde" });

            // Toevoegen docenten 
            context.Docenten.Add(new Docent()
            { DocentId = 001, Voornaam = "Willy", Familienaam = "Abbeloos", Wedde = 1500m, HeeftRijbewijs = new Nullable<bool>(), InDienst = new DateTime(2019, 1, 1), LandCode = "BE", CampusId = 1 });
            context.Docenten.Add(new Docent()
            { DocentId = 002, Voornaam = "Joseph", Familienaam = "Abelshausen", Wedde = 1800m, HeeftRijbewijs = true, InDienst = new DateTime(2019, 1, 2), LandCode = "BE", CampusId = 2 });
            context.Docenten.Add(new Docent()
            { DocentId = 003, Voornaam = "Joseph", Familienaam = "Achten", Wedde = 1300m, HeeftRijbewijs = false, InDienst = new DateTime(2019, 1, 3), LandCode = "BE", CampusId = 1 });
            context.Docenten.Add(new Docent()
            { DocentId = 004, Voornaam = "François", Familienaam = "Adam", Wedde = 1700m, HeeftRijbewijs = new Nullable<bool>(), InDienst = new DateTime(2019, 1, 4), LandCode = "BE", CampusId = 2 });
            context.Docenten.Add(new Docent()
            { DocentId = 005, Voornaam = "Jan", Familienaam = "Adriaensens", Wedde = 2100m, HeeftRijbewijs = true, InDienst = new DateTime(2019, 1, 5), LandCode = "BE", CampusId = 1 });
            context.Docenten.Add(new Docent()
            { DocentId = 006, Voornaam = "René", Familienaam = "Adriaensens", Wedde = 1600m, HeeftRijbewijs = false, InDienst = new DateTime(2019, 1, 6), LandCode = "BE", CampusId = 2 });
            context.Docenten.Add(new Docent()
            { DocentId = 007, Voornaam = "Frans", Familienaam = "Aerenhouts", Wedde = 1300m, HeeftRijbewijs = new Nullable<bool>(), InDienst = new DateTime(2019, 1, 7), LandCode = "BE", CampusId = 1 });
            context.Docenten.Add(new Docent()
            { DocentId = 008, Voornaam = "Emile", Familienaam = "Aerts", Wedde = 1700m, HeeftRijbewijs = true, InDienst = new DateTime(2019, 1, 8), LandCode = "BE", CampusId = 1 });
            context.Docenten.Add(new Docent()
            {
                DocentId = 009,
                Voornaam = "Jean",
                Familienaam = "Aerts",
                Wedde = 1200m,
                HeeftRijbewijs = false,
                InDienst = new DateTime(2019, 1, 9),
                LandCode= "BE",
                CampusId = 3
            });// Onbekende campus ! 
            context.Docenten.Add(new Docent()
            { DocentId = 010, Voornaam = "Mario", Familienaam = "Aerts", Wedde = 1600m, HeeftRijbewijs = new Nullable<bool>(), InDienst = new DateTime(2019, 1, 10), CampusId = 1 });

            context.SaveChanges();

            var docentService = new DocentService(context);

            // Act
            var docenten = docentService.GetDocentenVoorCampus(1);

            // Assert
            Assert.AreEqual(6, docenten.Count());
        }


        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void GetDocent_Docent0_ThrowArgumentException()
        {
            /* to initilize
             * var options = new DbContextOptionsBuilder<EFOpleidingenContext>()
               // .UseInMemoryDatabase("InMemoryDatabase")
               .UseInMemoryDatabase($"InMemoryDatabase{Guid.NewGuid()}")
                .Options;
            */
            using var context = new EFOpleidingenContext(options);
            context.Landen.Add(new Land() { LandCode = "BE", Naam = "België" });
            context.SaveChanges();
            // Act
            var docentService = new DocentService(context);
            docentService.GetDocent(0); // Onbestaande docent
            // Assert 
        }



        [TestMethod]
        public void ToevoegenDocent_DocentZonderLand_DocentHeeftLandBE()
        {
            /* to initilize
            // Arrange
            var options = new DbContextOptionsBuilder<EFOpleidingenContext>()
               // .UseInMemoryDatabase("InMemoryDatabase")
               .UseInMemoryDatabase($"InMemoryDatabase{Guid.NewGuid()}")
                .Options;
            */
            using var context = new EFOpleidingenContext(options);
            context.Landen.Add(new Land() { LandCode = "BE", Naam = "België" }); context.SaveChanges();
            var docent = new Docent()
            { DocentId = 20, Voornaam = "Fanny", Familienaam = "Kiekeboe", Wedde = 10100, InDienst = new DateTime(2019, 1, 1), CampusId = 1 };
            // Act
            var docentService = new DocentService(context);
            docentService.ToevoegenDocent(docent);
            context.SaveChanges();
            // Assert
            var docent1 = docentService.GetDocent(20);
            Assert.AreEqual("BE", docent1.LandCode);
        }



    }
}
