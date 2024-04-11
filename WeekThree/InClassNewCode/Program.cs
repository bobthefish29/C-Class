using System;
using System.Collections.Generic;

namespace Week3_Sample1 {

    //The starting program
    class Program {
        //just for ending the program
        static void Pause () {
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
        
        static double CalcAvg (double dblTotal, int intNumofPaychecks) {
            double dblResult = (dblTotal / intNumofPaychecks);
            return dblResult;
        }

        //this is for the display
        static void DisplayTheList (List<double> dblListIncoming) {
            int intCntr = 1;
            foreach (double d in dblListIncoming) {
                Console.WriteLine ($"Weekly entry #{intCntr}: ${d}");
                intCntr++;
            }
        }

        //this where we are adding the values to the list 
        static void StoreToTheList (List<double> dblEarnings, ref double dblTotal, ref int intCounter, double dblPaycheck) {
            dblEarnings.Add (dblPaycheck);
            dblTotal += dblPaycheck;
            intCounter++;
        }

        //Just changing the string to doubles, it it works it send the true and number value there
        static bool IsValidDouble (String strNum) {
            double dblNum = 0;
            bool blnResult = Double.TryParse (strNum, out dblNum);
            return blnResult;
        }

        //this is the main code that is going to be running
        static void Main (string[] args) {
            //setting some vars
            String strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;
            //making a list for double
            List<double> dblEarnings = new List<double> ();
            //this is just a print for the starting inputs
            Console.WriteLine ("Averager Program: Enter weekly earnings.  (a -1 to end entries)\n\n");

            do {
                //this is the whole loop to check if the user enters a number based on the inputs
                do {
                    Console.Write ("Please enter payroll #" + (intCntr + 1) + ": ");
                    strNum = Console.ReadLine ();
                    blnResult = IsValidDouble (strNum);

                    //just a quick checker to make sure its a number
                    if (blnResult == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00.");
                    } else {
                        dblNum = Double.Parse (strNum);
                    }

                } while (blnResult == false);

                if (dblNum >= 0) {
                    StoreToTheList (dblEarnings, ref dblTotal, ref intCntr, dblNum);
                }

            } while (dblNum >= 0);

            
            DisplayTheList (dblEarnings);

            //this is calling the cal avarage and sending it the values than outputing them
            dblResult = CalcAvg (dblTotal, intCntr);
            Console.WriteLine ("The average of the weekly earnings entered is: $" + dblResult);
            //calling the function for the ending
            Pause ();
        }
    }
}