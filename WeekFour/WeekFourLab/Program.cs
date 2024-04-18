// See https://aka.ms/new-console-template for more information


//The program works with taking inputs and setting them to the string values, it just need the valadators for the correct information, 




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

                    if(valueOkay.isDataThere(value, 0) == true){
                        mName = value;  
                    }
                    else{
                        mName = "NULL";
                    }

                    // mName = value;            
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

            public string Street1{
                get{
                    return street1;
                }
                set{
                    street1 = value;
                }
            }

            public string Street2{
                get{
                    return street2;
                }
                set{
                    street2 = value;
                }
            }

            public string City{
                get{
                    return city;
                }
                set{
                    city = value;
                }
            }

            public string State{
                get{
                    return state;
                }
                set{
                    state = value;
                }
            }

            public string Zip{
                get{
                    return zip;
                }
                set{
                    zip = value;
                }
            }

            public string Phone{
                get{
                    return phone;
                }
                set{
                    phone = value;
                }
            }

            public string Email{
                get{
                    return email;
                }
                set{


                    email = value;
                }
            }











        }

            


        class valueOkay{
            public static bool isDataThere(string tempValue, int minValue)
            {
                bool valed = false;

                if(tempValue.Length > minValue ){
                    valed = true;
                }
                return valed;
                
            }

        }

        static void Main(){

            bool valedInfo = true;

            person rec = new person();


            Console.Write("What is your First name? ");
            rec.FName = Console.ReadLine();

            //this is calling the sored value but sence its provite it would not show up, the seccond one is setting the value to poopy bacsue its public and not provite
            // rec.fName = "Poopy";
            // rec.FName = "Poopy";
            
            Console.Write("What is your Middle name(Enter if no name)? ");
            rec.MName = Console.ReadLine();

            Console.Write("What is your Last name? ");
            rec.LName = Console.ReadLine();


            Console.Write("What is your Street name? ");
            rec.Street1 = Console.ReadLine();

            Console.Write("What is your Street2 name? ");
            rec.Street2 = Console.ReadLine();

            Console.Write("What is your City name? ");
            rec.City = Console.ReadLine();

            Console.Write("What is your State name? ");
            rec.State = Console.ReadLine();

            Console.Write("What is your Zip code? ");
            rec.Zip = Console.ReadLine();

            Console.Write("What is your phone number? ");
            rec.Phone = Console.ReadLine();

            Console.Write("What is your email? ");
            rec.Email = Console.ReadLine();





            Console.WriteLine("\nThe Person you just enerted is \n");
            Console.WriteLine(rec.FName);
            Console.WriteLine(rec.MName);
            Console.WriteLine(rec.LName);

            Console.WriteLine(rec.Street1);
            Console.WriteLine(rec.Street2);

            Console.WriteLine(rec.City);
            Console.WriteLine(rec.State);
            Console.WriteLine(rec.Zip);

            Console.WriteLine(rec.Phone);
            Console.WriteLine(rec.Email);


            

        }




    }





}
