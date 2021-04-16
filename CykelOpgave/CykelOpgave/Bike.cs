using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    public class Bike
    {
        public string brand;
        public double wheelSize;
        public string color;
        public bool withMotor;

        private int numOfbikes = 0;

        public Bike(string brand, double wheelSize, string color, bool withMotor)
        {
            this.brand = brand;
            this.wheelSize = wheelSize;
            this.color = color;
            this.withMotor = withMotor;
            numOfbikes += 1;
        }

        public string GetDescription()
        {
            return $"Mærke: {brand} Dæk: {wheelSize} Farve: {color} Med El-motor: {withMotor}";
        }

        public int GetTotalAmountOfBikes()
        {
            return numOfbikes;
        }
    }
}
