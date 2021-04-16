using NUnit.Framework;
using CykelOpgave;
using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave.Tests
{
    [TestFixture()]
    public class BikeShopTests
    {
        [Test()]
        public void AddBikeTest() // Sikrer at AddBike tilføjer en ny cykel til butikken
        {
            BikeShop bikeShop = new BikeShop();
            bikeShop.AddBike(new Bike("Mustang", 12, "White", false));
            int currCount = bikeShop.GetAllBrands().Count;

            bikeShop.AddBike(new Bike("Centurion", 15, "Black", true));
            int newCount = bikeShop.GetAllBrands().Count;
            Assert.That(newCount > currCount);
        }

        [Test()]
        public void UpdateBikeTest() // Sikre at UpdateBike opdatere brand på en allerede eksisterende cykel
        {
            // Opretter vores test shop
            BikeShop bikeShop = new BikeShop();
            // Giver den shop en cykel at arbejde med
            bikeShop.AddBike(new Bike("Mustang", 12, "White", false));
            // Gemmer brand på vores cykel i en variabel
            string currentBrand = bikeShop.ReturnBikeBrand(0);
            // Priner den ud for at verificere nuværende navn
            Console.WriteLine(currentBrand);
            // Opdater brand til nyt
            bikeShop.UpdateBike(0, "Century");
            // gemmer i en variabel det nye navn
            string afterChange = bikeShop.ReturnBikeBrand(0);
            // Printer ud for at verificere det nye navn
            Console.WriteLine(afterChange);
            // Verificere at de to navne ikke er det samme.
            Assert.AreNotSame(currentBrand, afterChange);
        }
        [Test()]
        public void DeleteBikeTest()// Sikre at vi også sletter en cykel
        {
            BikeShop testShop = new BikeShop();
            testShop.AddBike(new Bike("Munstang", 12, "White", false));
            int currentNumberOfBikeBrands = testShop.GetAllBrands().Count;
            Console.WriteLine(currentNumberOfBikeBrands);
            testShop.DeleteBike(0);
            int numberOfBikesBrandAfterDelete = testShop.GetAllBrands().Count;
            Console.WriteLine(numberOfBikesBrandAfterDelete);
            Assert.That(numberOfBikesBrandAfterDelete <= 0);
        }

        [Test()]
        public void ReadBikeDataTest() // Sikre at en cykel har en besrkrivelse
        {
            BikeShop testShop = new BikeShop();
            testShop.AddBike(new Bike("Munstang", 12, "White", false));
            int numberOfWords = testShop.ReturnBikeDescription(0).Length;

            Assert.That(numberOfWords > 0); // Tjekker om der er mere end 0 bogstaver i beskrivelsen af cyklen
        }
    }
}