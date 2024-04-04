//David Punchak
//Lab #2
//04\04\24

//#############----------Create a program that------------##############:

// 1. Asks users to enter a number of students, or handle the number of students dynamically.

// 2. For each student, enter a name and 5 lab grades. 

// 3. Display each student with each average grade for their 5 labs, and their letter grade. 

// 4. Drop down a line or two, and then display the average for each lab #.  (Average grade on Lab #1 for all students)

//#############---------Main Code--------###########
//I still dont know why or what the 3 first lines of code mean
namespace Week2Lab {
    class Program {
        static void Main (string[] args) {
            
            //this is just setting vars for the project
            String studentNumStr, name, lab1, lab2, lab3, lab4, lab5, letterGrade;
            Int32 studentNumInt = 0, studentCount = 0;
            Double lab1Num = 0, lab1Total = 0, lab2Num = 0, lab2Total = 0, lab3Num = 0, lab3Total = 0, lab4Num = 0, lab4Total = 0, lab5Num = 0, lab5Total = 0;
            bool correctInput = false;

            //This is just checking to see if the user entered a number, it not it runs again
            do {
                Console.WriteLine("How many students do you want to enter?: ");
                studentNumStr = Console.ReadLine ();
                
                //this is the checker to see if the user input is a number 
                correctInput = Int32.TryParse (studentNumStr, out studentNumInt);
                //This would print if the user enters the wrong value so they can enter again and have a real value
                if (correctInput == false) {
                    Console.WriteLine ("\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                }
            } while (correctInput == false);

            //This is setting arrarys with the number of students enerted, if the user enters one it would be 1 length, if they did ten it would be ten length
            string[] nameArrary = new string[studentNumInt];
            double[] averageArrary = new double[studentNumInt];
            string[] letterArrary = new string[studentNumInt];

            //#################################------Main loop-------------######################3
            while(studentCount != studentNumInt){
                //Just setting student total back to 0 for the next student
                Double studentTotal = 0;


                //this is the everything for the name: Getting input, than adding it to an arrary
                Console.WriteLine("\nWho is student " + (studentCount + 1) + ": ");
                name = Console.ReadLine();
                nameArrary[studentCount] = name;


                //########################-----------------Lab 1--------------------##################################
                //This is lab 1: gets the input, converts it to a number, it it can't it runs again to get a number
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#1 grade: ");
                    lab1 = Console.ReadLine();
                    
                    correctInput = Double.TryParse(lab1, out lab1Num);

                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counters
                lab1Total += lab1Num;
                studentTotal += lab1Num;

                //##########################--------------------Lab 2------------------#######################
                //This is lab 2: gets the input, converts it to a number, it it can't it runs again to get a number
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#2 grade: ");
                    lab2 = Console.ReadLine();

                    correctInput = Double.TryParse(lab2, out lab2Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counters
                lab2Total += lab2Num;
                studentTotal += lab2Num;

                //##############################----------------Lab 3-----------------------#####################
                //This is lab 3: gets the input, converts it to a number, it it can't it runs again to get a number
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#3 grade: ");
                    lab3 = Console.ReadLine();

                    correctInput = Double.TryParse(lab3, out lab3Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counters
                lab3Total += lab3Num;
                studentTotal += lab3Num;

                //##############################----------------Lab 4-----------------------#####################
                //This is lab 4: gets the input, converts it to a number, it it can't it runs again to get a number
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#4 grade: ");
                    lab4 = Console.ReadLine();

                    correctInput = Double.TryParse(lab4, out lab4Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counters
                lab4Total += lab4Num;
                studentTotal += lab4Num;

                //##############################----------------Lab 5-----------------------#####################
                //This is lab 5: gets the input, converts it to a number, it it can't it runs again to get a number
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#5 grade: ");
                    lab5 = Console.ReadLine();

                    correctInput = Double.TryParse(lab5, out lab5Num);
                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counters
                lab5Total += lab5Num;
                studentTotal += lab5Num;


                //################---------------This is the math for the average, it than rounds the number down,than adding it to a arrary
                studentTotal = studentTotal / 5;
                //than it rounds the total down if its a decmal
                studentTotal = Math.Floor(studentTotal);
                //this is adding the value of the average to a arrary 
                averageArrary[studentCount] = studentTotal;

                //#################---------------GEtting a letter value based on the students grade value-----------###################
                //this is where i would put the if for the letter value
                if (studentTotal >= 90)
                    letterGrade = "A";
                else if (studentTotal >= 80 && studentTotal <= 89)
                    letterGrade = "B";
                else if (studentTotal >= 70 && studentTotal <= 79)
                    letterGrade = "C";
                else if (studentTotal >= 60 && studentTotal <= 69)
                    letterGrade = "D";
                else 
                    letterGrade = "F";

                //this is adding the letter value (a,b,c,d,f) to the letterArrary at the index
                letterArrary[studentCount] = letterGrade;

                //adding to the total student count to brake out of the loop
                studentCount++;

                //Just clearing the console so its not so gross
                Console.Clear();
            }
            

            

            //#############----------This is finding the average for each lab than rounding down------------#################
            // lab_ = lab_ / total number of students the user inputed at the start
            lab1Total = lab1Total / studentNumInt;
            lab2Total = lab2Total / studentNumInt;
            lab3Total = lab3Total / studentNumInt;
            lab4Total = lab4Total / studentNumInt;
            lab5Total = lab5Total / studentNumInt;

            //this is just rounding the lab values down
            lab1Total = Math.Floor(lab1Total);
            lab2Total = Math.Floor(lab2Total);
            lab3Total = Math.Floor(lab3Total);
            lab4Total = Math.Floor(lab4Total);
            lab5Total = Math.Floor(lab5Total);

            //##############-----------------Final outputs-----------------###################
            Console.WriteLine("\n-----Final OutPut----");
            Console.WriteLine("Name   |   Avarage   |   LetterGrade");
            Console.WriteLine("----------------------------------");
            //Just looping thought the lenth of any arrary than that item at that index would be put down
            for(int i = 0; i < nameArrary.Length; i++){
                Console.WriteLine(nameArrary[i]+ "  |  " + averageArrary[i] + "  |  " + letterArrary[i]);
            }
            //just the averages for the labs, it could have been in a loop so its not this but what works works
            Console.WriteLine("\n\nThe average for Lab#1 is: " + lab1Total);
            Console.WriteLine("The average for Lab#2 is: " + lab2Total);
            Console.WriteLine("The average for Lab#3 is: " + lab3Total);
            Console.WriteLine("The average for Lab#4 is: " + lab4Total);
            Console.WriteLine("The average for Lab#5 is: " + lab5Total);

            //mostly just a goodbye statment
            Console.WriteLine ("\n\nPress any key to leave");
            Console.ReadKey ();





        }
    }
}