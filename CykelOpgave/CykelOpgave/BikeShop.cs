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

        public void AddBike(Bike bike)
        {
            bikeList.Add(bike);
        }

        public void DeleteBike(int index)
        {
            bikeList.RemoveAt(index);
        }

        public void UpdateBike(int index, string newBrand)
        {
            bikeList[index].brand = newBrand;
        }

        public List<string> GetAllBrands()
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

        public List<Bike> SearchBikeBrand(string brand)
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

        public string ReturnBikeBrand(int index)
        {
            return bikeList[index].brand;
        }

        public string ReturnBikeDescription(int index)
        {
            return bikeList[index].GetDescription();
        }
    }
}
