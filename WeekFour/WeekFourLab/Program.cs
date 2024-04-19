// See https://aka.ms/new-console-template for more information


//The program works with taking inputs and setting them to the string values, it just need the valadators for the correct information, 




namespace Week4_classDemo
{
    class Program{


        public class person{

            // setting the values, making the first name poopy for the part 2 test
            private string fName = "Poopy";
            private string mName;
            private string lName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;


            //the start of the getting and setting for tha values, they are orderd as they appear in the making of data
            public string FName{
                get{
                    return fName;
                }
                set{

                    if(valueOkay.isDataThere(value, 0) == true){
                        fName = value;

                    }
                    else{
                        // Console.WriteLine("testing"); 
                        fName = "NULLnf";
                    }
                    
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
                        mName = "NULLnm";
                    }

                    // mName = value;            
                }
            }

            public string LName{
                get{
                    return lName;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        lName = value; 
                    }
                    else{
                        lName = "NULLnl";
                    }
                    
                }
            }

            //the is where i will have the street
            public string Street1{
                get{
                    return street1;
                }
                set{

                    if(valueOkay.isDataThere(value, 0) == true){
                        street1 = value; 
                    }
                    else{
                        street1 = "NULLs1";
                    }
                    
                }
            }

            public string Street2{
                get{
                    return street2;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        street2 = value; 
                    }
                    else{
                        street2 = "NULLs2";
                    }
                }
            }

            public string City{
                get{
                    return city;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        city = value; 
                    }
                    else{
                        city = "NULLc";
                    }
                    
                }
            }

            public string State{
                get{
                    return state;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        state = value; 
                    }
                    else{
                        state = "NULLs";
                    }
                    
                }
            }

            public string Zip{
                get{
                    return zip;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        zip = value; 
                    }
                    else{
                        zip = "NULLz";
                    }
                    
                }
            }

            public string Phone{
                get{
                    return phone;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        phone = value; 
                    }
                    else{
                        phone = "NULLp";
                    }
                    
                }
            }

            public string Email{
                get{
                    return email;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        email = value; 
                    }
                    else{
                        email = "NULLE";
                    }
                }
            }











        }
            //#################The ending of the person class###############
            //this is the start of the class of okay values
        class valueOkay{

            //This is making sure the data is there, accepthing 2 values and returning a true or false value 
            public static bool isDataThere(string tempValue, int minValue)
            {
                bool valed = false;

                if(tempValue.Length > minValue ){
                    valed = true;
                }
                return valed;
                
            }

            //this is the same thing but with == to
            public static bool isBiggerThan(string tempNum, int size)
            {
                
                bool value = false;

                if(tempNum.Length == size){
                    value = true;
                }
                else{
                    value = false;
                }

                return value;


            }


            

        }

        static void Main(){

            bool valedInfo = true;

            person rec = new person();

            //this must be there also part of part 2 and 1
            // Console.Write("What is your First name? ");
            // rec.FName = Console.ReadLine();

            
            Console.Write("What is your First name? ");
            rec.FName = Console.ReadLine();
            // fnTemp = Console.ReadLine();

            // // valedInfo = .TryParse(Console.ReadLine(), out fnTemp);
            // if (valueOkay.isDataThere(fnTemp, 0) == false){
            //     Console.WriteLine("Error");
            // }
            // else{
            //     rec.FName = fnTemp;
            // }

            

            //this is calling the sored value but sence its provite it would not show up, the seccond one is setting the value to poopy bacsue its public and not provite
            // rec.fName = "Poopy";
            // rec.FName = "Poopy";
            
            //this does not have to be there
            Console.Write("What is your Middle name('-Enter-' if no name)? ");
            rec.MName = Console.ReadLine();

            //this must be there
            Console.Write("What is your Last name? ");
            rec.LName = Console.ReadLine();

            //must have one
            Console.Write("What is your Street name? ");
            rec.Street1 = Console.ReadLine();

            //this will just be like this
            Console.Write("What is your Street2 name('-Enter-' if no name)? ");
            rec.Street2 = Console.ReadLine();
            
            //it must be there
            Console.Write("What is your City name? ");
            rec.City = Console.ReadLine();

            //needs to be a two diget value EX) RI, MA, NY
            Console.Write("What is your State name? ");
            rec.State = Console.ReadLine();


            //needs to be five numbers
            // Console.Write("What is your Zip code? ");
            // rec.Zip = Console.ReadLine();

            do{
                // rec.Zip = Console.ReadLine();
                //makse sure its a number
                int tempZipInt;
                do{
                    Console.Write("What is your Zip code? ");
                    valedInfo = int.TryParse(Console.ReadLine(), out tempZipInt);

                    if (valedInfo == false){
                        Console.WriteLine("\nMust be a number\n");
                    }


                }while(valedInfo == false);
                //setting that number value to a string
                string tempZipString = tempZipInt.ToString();
                // valedInfo = int.TryParse(Console.ReadLine(), out tempZip);
                
                
                if (valueOkay.isBiggerThan(tempZipString, 5) == true){
                    valedInfo = true;
                    rec.Zip = tempZipString;
                    

                }
                else{
                    Console.WriteLine("\nIt must be 5 numbers\n");
                    valedInfo = false;
                }

            }while (valedInfo == false);

            //needs to be ten digets
            // Console.Write("What is your phone number? ");
            // rec.Phone = Console.ReadLine();
            
            do{
                // rec.Zip = Console.ReadLine();
                //makse sure its a number
                int tempPhoneInt = 0;
                do{
                    
                    Console.Write("What is your Phone Number? ");
                    valedInfo = int.TryParse(Console.ReadLine(), out tempPhoneInt);
                    

                    if (valedInfo == false){
                    
                        Console.WriteLine("\nMust be a number EX) 123-4567\n");
                    }

                    

                }while(valedInfo == false);
                //setting that number value to a string
                string tempPhoneString = tempPhoneInt.ToString();
                
                // valedInfo = int.TryParse(Console.ReadLine(), out tempZip);
                
                if (valueOkay.isBiggerThan(tempPhoneString, 7) == true){
                    valedInfo = true;
                    rec.Phone = tempPhoneString;
                    

                }
                else{
                    Console.WriteLine("\nIT must be 10 numbers\n");
                    valedInfo = false;
                }

            }while (valedInfo == false);



            
            // must be a email with the "@" just cus
            Console.Write("What is your email? ");
            rec.Email = Console.ReadLine();




            //########################################################################
            //This will just be where outputs will be

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
