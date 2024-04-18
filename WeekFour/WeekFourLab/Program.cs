// See https://aka.ms/new-console-template for more information

namespace Week4_classDemo
{
    class Program{


        public class person{

            private string fName;
            private string mName;
            private string lName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            public string FName{
                get{
                    return fName;
                }
                set{
                    fName = value;
                }
            }

            public string MName{
                get{
                    return mName;
                }
                set{
                    mName = value;            
                }
            }

            public string LName{
                get{
                    return lName;
                }
                set{
                    lName = value;
                }
            }







        }



        static void Main(){

            bool valedInfo = true;

            person rec = new person();


            Console.Write("What is your First name? ");
            rec.FName = Console.ReadLine();


            
            Console.Write("What is your Middle name(Enter if no name)? ");
            rec.MName = Console.ReadLine();

            Console.Write("What is your Last name? ");
            rec.LName = Console.ReadLine();





            Console.WriteLine("\nThe Person you just enerted is \n");
            Console.WriteLine(rec.FName);
            Console.WriteLine(rec.MName);
            Console.WriteLine(rec.LName);


            

        }




    }





}
