// See https://aka.ms/new-console-template for more information

//David punchak
//Doing lab #1 Choice #1


//Program is taking a name than 4 grade valuse to find an avarge, Than give the user a letter based on the average found
//Bonus* if the user enters 20%, 20%, 25%, 25% and still finds the average


/*Output Prompts
Gathering of input including multiple types of data types (string and numeric)
Converting from strings to numeric form.
Calculations that include more than one simple step
Multiple Branches (3+)
Output of results
Mechanism to allow user to comfortably see results before the program ends.
Tested & Debugged to class level.
Properly documented with Name, Date and description of program at top.  Remark all components of program.
*/

//--------------------------------Start of main code-----------------------------
namespace gradeCalk{

    class firstLab{



        static void Main (string[] args) {


            //this is where i am setting the vars to be used
            String userName, strInt1, strInt2, strInt3, strInt4, letterGrade = "Z";
            Double int1, int2, int3, int4, total, grade = 4, final;


            //this is where i am getting the inputs for the name and the grades
            Console.Write("Welcome to the avarage grade calulator \n\n");
            Console.Write ("Please enter your first name: ");
            userName = Console.ReadLine();
            Console.Write ("Please enter your first grade #: ");
            strInt1 = Console.ReadLine();
            Console.Write ("Please enter your next grade #: ");
            strInt2 = Console.ReadLine();
            Console.Write ("Please enter your next grade #: ");
            strInt3 = Console.ReadLine();
            Console.Write ("Please enter your last grade #: ");
            strInt4 = Console.ReadLine();

            //converting the inputs into numbers to use
            int1 = Convert.ToInt32 (strInt1);
            int2 = Convert.ToInt32 (strInt2);
            int3 = Convert.ToInt32 (strInt3);
            int4 = Convert.ToInt32 (strInt4);

            //doing the math for the avage
            total = int1 + int2 + int3 + int4;

            final = total / grade;

            //this is where we are putting the letter grade
            if (final >= 90)
                letterGrade = "A";
            else if (final >= 80 && final <= 89)
                letterGrade = "B";
            else if (final >= 70 && final <= 79)
                letterGrade = "C";
            else if (final >= 60 && final <= 69)
                letterGrade = "D";
            else 
                letterGrade = "F";
            //end of if statment

            //this is the final Outputs
            Console.Write("\nWelcome " + userName + "\n\n");
            Console.Write("With the grade's you inputed your average is " + final + "\nThat would be an " + letterGrade + "." + "\nThank you for using my program\n\n");
        }

    }

}




