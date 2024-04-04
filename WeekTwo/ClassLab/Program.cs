using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample1 {
    class Program {
        static void Main (string[] args) {

            //Declare vars
            String strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;


            //Asking the user for how many weeks they work (This is how many times the loops will run)
            // Console.WriteLine ("Averager Program: Find the average of how many week's did you work?");
            // strCntr = Console.ReadLine ();
            //This is converting the string to int number to be used
            // intCntr = Int32.Parse (strCntr);

            //just checking to see if the users enters in a number they are ment to enter 
            do {
                Console.WriteLine ("Averager Program: Find the average of how many week's did you work?");
                strCntr = Console.ReadLine ();
                // intCntr = Int32.Parse (strCntr);
                //this is the checker to see if the loop true or false, If string num is not able to be a number than it sets BLNResult to false and runs again if true than it adds the run again
                blnResult = Int32.TryParse (strCntr, out intCntr);
                //This would print if the user enters the wrong vale so they can enter again
                if (blnResult == false) {
                    Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00.\n");
                }
            } while (blnResult == false);




            
            //this is setting a new var for dulEarning and making it a new recored in a list, it makes an array the lenth the users enters
            Double[] dblEarnings = new Double[intCntr];

            

            //just a print
            Console.WriteLine ("Averager Program: Enter weekly earnings.\n\n");

            //********************************************************************************************************************************************
            //********************************************************************************************************************************************
            //this is running for the number of times the user enters in a week run
            for (int i = 0; i < intCntr; i++) {
                
                
                
                //*********************************************************************************************************************************
                //This would run if blnResult == to false 
                do {
                    Console.Write ("Please enter payroll #" + (i + 1) + " : ");
                    strNum = Console.ReadLine ();
                    //this is the checker to see if the loop true or false, If string num is not able to be a number than it sets BLNResult to false and runs again if true than it adds the run again
                    
                    
                    blnResult = Double.TryParse (strNum, out dblNum);
                    
                    //This would print if the user enters the wrong vale so they can enter again
                    if (blnResult == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00.");
                    }
                } while (blnResult == false);
                //*********************************************************************************************************************************


                //this is adding the num value the user entered to a tatal
                dblTotal += dblNum;

                //this is adding the values to the arrary
                dblEarnings[i] = dblNum;
                

            }
            //********************************************************************************************************************************************

            foreach(Double earning in dblEarnings){
                dblTotal += earning;
            }
            //*************************************************************************************************************************************
            //*************************************************************************************************************************************

            //This is doing the final math to find the average, taking the total of the numbers added and "/" by how many times it runs the loop
            dblResult = (dblTotal / intCntr);
            Console.WriteLine ("The average of the weekly earnings entered is: $" + dblResult);

            //*************************************************************************************************************************************
            //*************************************************************************************************************************************
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();

        }
    }
}