using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    public class BikeShop
    {
        private List<Bike> bikeList;

        public BikeShop()
        {
            bikeList = new List<Bike>();
        }

        public void AddBike(Bike bike) // Tilføjer cykel til en butik
        {
            bikeList.Add(bike);
        }

        public void DeleteBike(int index) // Fjerner en cykel fra en butik
        {
            bikeList.RemoveAt(index);
        }

        public void UpdateBike(int index, string newBrand) // Opdater værdi for en cykel (Dette tilfølde kun mærket)
        {
            bikeList[index].brand = newBrand;
        }

        public List<string> GetAllBrands() // Henter alle de forskellige mærker vi har i en List
        {
            List<string> brands = new List<string>();
            
            foreach (Bike bike in bikeList)
            {
                if (!brands.Contains(bike.brand))
                {
                    brands.Add(bike.brand);
                }
            }
            return brands;
        }

        public List<Bike> SearchForBrand(string brand) // Retunere liste med alle cykler med et specifikt mærke.
        {
            List<Bike> brandList = new List<Bike>();

            for (int i = 0; i < bikeList.Count; i++)
            {
                if (brand == bikeList[i].brand)
                {
                    brandList.Add(bikeList[i]);
                }
            }
            if (brandList.Count > 0)
            {
                Console.WriteLine("Mærke fundet.");
                
            }
            else
            {
                Console.WriteLine("Mærke ikke fundet");
            }
            return brandList;
        }

        public string ReturnBikeBrand(int index) // Henter en cykel med et specifik mærke i listen
        {
            return bikeList[index].brand;
        }

        public string ReturnBikeDescription(int index) // retunere en beskrivelse af en cykel i listen.
        {
            return bikeList[index].GetDescription();
        }
    }
}
