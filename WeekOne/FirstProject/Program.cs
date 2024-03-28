/*

1.What does the code do in each section of the program.

-added the comments to the main code

2. what is the overall goal of the program

- The overall goal of the project is to do math, 

3. do you see issues with the program

- The first issues is that there was no strNum1 var at the start
- The next problum is that there is no operation for multyply

4. do you have qustions about the program

- Why are we "using system"
- what is the switch statment
- what is name space

5. can you test out your qustion by crating an educated guess than make changes to the code

- using system is kind of like the import from python
- Swtich is for IDK
- name space is mostlily

6. please genearate solutions to the iussus is thge program 

- we could run the program and see what errors appear and fix them as we go along

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Week1_Samplel {
    class Program {
        static void Main (string[] args) {


            //1. this section is for starting the vars
            String strFirst = "test", strOperand, strNum1, strNum2;
            //Int32 intNum1 = 0, intNum2 = 0, intResult = 0;  //intNum3,
            Double dblResult, intNum1 = 0, intNum2 = 0, intResult = 0;



            //1. this is where we are getting there names, and seting it vars
            Console.WriteLine ("Hello There!");

            Console.Write ("Please enter your first name: ");
            strFirst = Console.ReadLine ();

            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");

            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine ();

            Console.Write ("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine().ToUpper();

            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine ();

            intNum1 = Int32.Parse (strNum1);
            intNum2 = Convert.ToInt32 (strNum2);




            //1. this is for switches to see what they do
            switch (strOperand) {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
            }




            //1. this is for doing the math
            dblResult = (Double) intResult;


            //1. this is for if thet user says that item than it would be that equastion

            if (strOperand == "PLUS")
                Console.WriteLine ($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "MINUS")
                Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            else if(strOperand == "MULTIPLY")
                Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "DIVIDE")
                Console.WriteLine ($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");

            //1. this is just keeping the program running 
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}