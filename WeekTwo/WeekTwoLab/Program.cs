// See https://aka.ms/new-console-template for more information


namespace Week2Lab {
    class Program {
        static void Main (string[] args) {

            String studentNumStr, name, lab1, lab2, lab3, lab4, lab5;
            // string[] nameArrary;

            Int32 studentNumInt = 0, studentCount = 0;
            Double lab1Num = 0, lab1Total = 0, lab2Num = 0, lab2Total = 0, lab3Num = 0, lab3Total = 0, lab4Num = 0, lab4Total = 0, lab5Num = 0, lab5Total = 0;

            bool correctInput = false;


            do {
                Console.WriteLine("How many students do you want to enter?: ");
                studentNumStr = Console.ReadLine ();
                // intCntr = Int32.Parse (strCntr);
                //this is the checker to see if the loop true or false, If string num is not able to be a number than it sets BLNResult to false and runs again if true than it adds the run again
                correctInput = Int32.TryParse (studentNumStr, out studentNumInt);
                //This would print if the user enters the wrong vale so they can enter again
                if (correctInput == false) {
                    Console.WriteLine ("\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                }
            } while (correctInput == false);

            string[] nameArrary = new string[studentNumInt];
            double[] averageArrary = new double[studentNumInt];

            while(studentCount != studentNumInt){
                Double studentTotal = 0;


                //this is the everything for the name: Getting input, than adding it to an arrary
                Console.WriteLine("\nWho is student " + (studentCount + 1) + ": ");
                name = Console.ReadLine();
                nameArrary[studentCount] = name;


                //########################-----------------Lab 1--------------------##################################
                //This is lab 1 input and converting it to a number also checking to have it be a number
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#1 grade: ");
                    lab1 = Console.ReadLine();

                    correctInput = Double.TryParse(lab1, out lab1Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counter
                lab1Total += lab1Num;
                studentTotal += lab1Num;

                //##########################--------------------Lab 2------------------#######################
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#2 grade: ");
                    lab2 = Console.ReadLine();

                    correctInput = Double.TryParse(lab2, out lab2Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counter
                lab2Total += lab2Num;
                studentTotal += lab2Num;

                //##############################----------------Lab 3-----------------------#####################3
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#3 grade: ");
                    lab3 = Console.ReadLine();

                    correctInput = Double.TryParse(lab3, out lab3Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counter
                lab3Total += lab3Num;
                studentTotal += lab3Num;

                //##############################----------------Lab 4-----------------------#####################3
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#4 grade: ");
                    lab4 = Console.ReadLine();

                    correctInput = Double.TryParse(lab4, out lab4Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counter
                lab4Total += lab4Num;
                studentTotal += lab4Num;

                //##############################----------------Lab 5-----------------------#####################3
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#5 grade: ");
                    lab5 = Console.ReadLine();

                    correctInput = Double.TryParse(lab5, out lab5Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counter
                lab5Total += lab5Num;
                studentTotal += lab5Num;

                //This is the math for the avaerage
                studentTotal = studentTotal / 5;

                //this is adding the value of the average to a arrary 
                averageArrary[studentCount] = studentTotal;

                //this is where i would put the if for the letter value





                studentCount++; 
            }

            

            for(int i = 0; i < nameArrary.Length; i++){

                Console.WriteLine(nameArrary[i]);
                Console.WriteLine(averageArrary[i]);
            }












        }
    }
}