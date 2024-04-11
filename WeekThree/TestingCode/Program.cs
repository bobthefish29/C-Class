// See https://aka.ms/new-console-template for more information



//the labs work, the number inputs work, need to do some math stuff


namespace Week2_Sample1 {
    class Program {

        //used for getting the number of students the user want to enter
        static int studentNum(int inputNumber){
            bool correctInput;
            string studentNumStr = "";
            int studentNumInt = 0;
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


            return studentNumInt;
        }

        //string[]VVVV
        static double doingLab(string name, ref double lab1, ref double lab2,ref double lab3,ref double lab4,ref double lab5){

            //Working on just doing the math after

            bool correctInput = false;
            double labNum = 0, studentTotal = 0;
            var lab = new String[5];
            var labTotal = new double[5];
            
            for(int i = 0; i <= lab.Length - 1; i++)
            {
                //all of this is used for the labs
                do{
                    Console.WriteLine("\nWhat is " + name + "'s lab#"+ (i + 1) + " grade: ");

                    lab[i] = Console.ReadLine();
                    
                    correctInput = Double.TryParse(lab[i], out labNum);

                    if (correctInput == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
                    }

                } while(correctInput == false);
                //after chicking if its a number it adds that number to a total counters
                labTotal[i] += labNum;
                studentTotal += labNum;


                if (i == 0)
                    lab1 += labNum;
                else if (i == 1)
                    lab2 += labNum;
                else if (i == 2)
                    lab3 += labNum;
                else if (i == 3)
                    lab4 += labNum;
                else
                    lab5 += labNum;
                    
                
                
            }


            //part of the lab just outputs
            // for(int i = 0; i < labTotal.Length; i++){
            //     Console.WriteLine(labTotal[i]);
            // }
            // Console.WriteLine(studentTotal);

            return studentTotal;
        }





        static void Main (string[] args) {

            int inputNumber = 0, studentCount = 0, howManyStu = 0;
            string name = "";

            double lab1 = 0, lab2 = 0, lab3 = 0, lab4 = 0 , lab5 = 0;
            
            howManyStu = studentNum(inputNumber);

            string[] nameArrary = new string[howManyStu];
            double[] avgArrary = new double[howManyStu];
            string[] letterArrary = new string[howManyStu];


        

            while (howManyStu != studentCount){
                
                Console.WriteLine("\nWho is student " + (studentCount + 1) + ": ");
                name = Console.ReadLine();

                nameArrary[studentCount] = name;

                avgArrary[studentCount] = doingLab(name, ref lab1, ref lab2, ref lab3, ref lab4, ref lab5);

                avgArrary[studentCount] = avgArrary[studentCount] / 5;

                avgArrary[studentCount] = Math.Floor(avgArrary[studentCount]);

                

                if (avgArrary[studentCount] >= 90)
                    letterArrary[studentCount] = "A";
                else if (avgArrary[studentCount] >= 80 && avgArrary[studentCount] <= 89)
                    letterArrary[studentCount] = "B";
                else if (avgArrary[studentCount] >= 70 && avgArrary[studentCount] <= 79)
                    letterArrary[studentCount] = "C";
                else if (avgArrary[studentCount] >= 60 && avgArrary[studentCount] <= 69)
                    letterArrary[studentCount] = "D";
                else 
                    letterArrary[studentCount] = "F";
                //end the if

            
                studentCount ++;
                Console.Clear();
            }

            //Final Outputs   VVVVVVVVVVVVV
            Console.WriteLine("\n-----Final OutPut----");
            Console.WriteLine("Name\tAvarage\t\tLetterGrade");
            Console.WriteLine("----------------------------------");
            for(int i = 0; i < nameArrary.Length; i++){
                Console.WriteLine(nameArrary[i]+ "\t" + avgArrary[i] + "\t\t" + letterArrary[i]);
            }

            lab1 = lab1 / howManyStu;
            lab2 = lab2 / howManyStu;
            lab3 = lab3 / howManyStu;
            lab4 = lab4 / howManyStu;
            lab5 = lab5 / howManyStu;


            lab1 = Math.Floor(lab1);
            lab2 = Math.Floor(lab2);
            lab3 = Math.Floor(lab3);
            lab4 = Math.Floor(lab4);
            lab5 = Math.Floor(lab5);


            Console.WriteLine("\n\nThe average for Lab#1 is: " + lab1);
            Console.WriteLine("The average for Lab#2 is: " + lab2);
            Console.WriteLine("The average for Lab#3 is: " + lab3);
            Console.WriteLine("The average for Lab#4 is: " + lab4);
            Console.WriteLine("The average for Lab#5 is: " + lab5);
            
        }
    }
}