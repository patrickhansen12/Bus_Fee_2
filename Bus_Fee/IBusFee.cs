using System;
using System.Collections.Generic;
using System.Text;

namespace Bus_Fee
{
    interface IBusFee
    {
        double TotalCost(int noOfPassengers, int kilometers);



        //void hundredKm();
        //void aboveFiveHundredKm();
        //void fiveHundredkm();
    }
}
