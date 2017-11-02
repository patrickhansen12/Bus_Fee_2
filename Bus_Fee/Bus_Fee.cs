using System;
using System.Collections.Generic;
using System.Text;

namespace Bus_Fee
{
    class Bus_Fee : IBusFee
    {
        private double priceBelow100km = 3.20;
        private int fee = 130;
        private double priceAbove100LessThan500 = 2.75;
        private double totalPrice;


        public double TotalCost(int noOfPassengers, int kilometers)
        {
            if (noOfPassengers < 12 && kilometers > 100)
            {
                totalPrice = fee  + (kilometers * priceAbove100LessThan500);
            }
            return totalPrice;

        }
    }
}
