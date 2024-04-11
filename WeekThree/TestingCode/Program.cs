// See https://aka.ms/new-console-template for more information



//the labs work, the number inputs work, need to do some math stuff


namespace Week2_Sample1 {
    class Program {


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


        static string[] doingLab(){
            string name = "david";
            // int inputNumber = 0, studentCount = 0, howManyStu = 0;
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
                // dogLegs[i] = "test";
                // Console.WriteLine(dogLegs[i]);
            }
            //part of the lab 
            for(int i = 0; i < labTotal.Length; i++){
                Console.WriteLine(labTotal[i]);
            }
            Console.WriteLine(studentTotal);

            return lab;
        }





        static void Main (string[] args) {

            // string name = "david";
            int inputNumber = 0, studentCount = 0, howManyStu = 0;
            // bool correctInput = false;
            // double labNum = 0, studentTotal = 0;


            //getting the number of students the user will enter
            howManyStu = studentNum(inputNumber);

            while (howManyStu != studentCount){
                Console.WriteLine("hakjsh");


                doingLab();


                studentCount ++;
            }

            // //setting the vars for the labs
            // var lab = new String[5];
            // var labTotal = new double[5];
            
            // for(int i = 0; i <= lab.Length - 1; i++)
            // {
            //     //all of this is used for the labs
            //     do{
            //         Console.WriteLine("\nWhat is " + name + "'s lab#"+ (i + 1) + " grade: ");

            //         lab[i] = Console.ReadLine();
                    
            //         correctInput = Double.TryParse(lab[i], out labNum);

            //         if (correctInput == false) {
            //             Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051\n");
            //         }

            //     } while(correctInput == false);
            //     //after chicking if its a number it adds that number to a total counters
            //     labTotal[i] += labNum;
            //     studentTotal += labNum;
            //     // dogLegs[i] = "test";
            //     // Console.WriteLine(dogLegs[i]);
            // }
            // //part of the lab 
            // for(int i = 0; i < labTotal.Length; i++){
            //     Console.WriteLine(labTotal[i]);
            // }
            // Console.WriteLine(studentTotal);
            
            

        }
    }
}