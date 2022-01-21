using System;

namespace A4
{
    class Vehicle
    {
        char Style,Length,Height;
        int  Line,Qty;
              
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Ford Van Shop");
            Console.Write("Please Enter Customer Name: ");
            string customer = Console.ReadLine();
            Console.Write ("How Many Orders Would You Like to Make? ");
            int orderlines = Convert.ToInt32(Console.ReadLine());
            Vehicle [] vans = new Vehicle [orderlines];
            for (int i=0; i<orderlines; i++) {
                Console.WriteLine ("Order: "+(i+1));
                vans[i]         = new Vehicle ();
                vans[i].Line    = i+1;
                vans[i].Style   = GetStyles();
                vans[i].Length  = GetLength();
                vans[i].Height  = GetHeight();
                vans[i].Qty     = GetQty();
            }
            int unitcost, extendedcost; 
            foreach (var v in vans) {
                switch (v.Style) {
                    case 'B': unitcost = 35270; break;
                    case 'C': unitcost = 37635; break;
                    case 'P': unitcost = 41090; break;
                    default : unitcost = 99999; break;
                }
                if (v.Length == 'E') {unitcost += 1000;} else if (v.Length == 'X') 
                {unitcost += 2000;}
                if (v.Height == 'M') {unitcost += 0750;} else if (v.Height == 'H') 
                {unitcost += 1500;}
                extendedcost = unitcost * v.Qty;
               Console.WriteLine (
                        v.Line+
                        ": {"+
                        v.Style+
                        ", "+
                        v.Length+
                        ", "+
                        v.Height+
                        "} Qty="+
                        v.Qty +
                        " $" +
                        unitcost +
                        " Each, Total $" +
                        extendedcost
                        );
            } 
        } 
        static char GetStyles() {
            Boolean done = false;
            Char result;
            while (done==false){
            Console.Write ("Choose Your Style Option, Cargo Van(B), Crew Van(C), Passanger Van(P) ");
            result = Convert.ToChar(Console.ReadLine());
            if ((result=='B') || (result=='C') || (result=='P')){
                return (result);
                }
            }   
            return('J');
        }
        static char GetLength() {
             Boolean done = false;
            Char result;
            while (done==false){
            Console.Write ("Choose Your Roof Height, Low Roof(L), Medium Roof(M), High Roof(H) ");
            result = Convert.ToChar(Console.ReadLine());
            if ((result=='L') || (result=='M') || (result=='H')){
                return (result);
                }
            } 
                return('J');

        } 
         static char GetHeight() {
            Boolean done = false;
            Char result;
            while (done==false){
            Console.Write ("Choose Your Van Length, Regular(R), Long(E), Extended(X) ");
            result = Convert.ToChar(Console.ReadLine());
            if ((result=='R') || (result=='E') || (result=='X')){
                return (result);
                }
            }   
            return('J');
        }
          static char GetQty() {
            char result;
            Console.WriteLine("Enter The Total Number Of Vehciles For This Order ");
            result = Convert.ToChar(Console.ReadLine());
            return (result);
        }

    } 
} 