// See https://aka.ms/new-console-template for more information


//The program works with taking inputs and setting them to the string values, it just need the valadators for the correct information, 
//THe program was going to have the ways of checking to see if the data inputed was there but the grading rubric did nt have that so i did not put it.
//The program runs with taking input data and storing to prive string, if there is no data that is being inputed than the value is being set to null,



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
                        fName = "NULL";
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
                    if(valueOkay.isDataThere(value, 0) == true){
                        lName = value; 
                    }
                    else{
                        lName = "NULL";
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
                        street1 = "NULL";
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
                        street2 = "NULL";
                    }
                }
            }

            //this is the start of the city, zip, state setters
            public string City{
                get{
                    return city;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        city = value; 
                    }
                    else{
                        city = "NULL";
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
                        state = "NULL";
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
                        zip = "NULL";
                    }
                    
                }
            }


            //this is where the phone and email setters are
            public string Phone{
                get{
                    return phone;
                }
                set{
                    if(valueOkay.isDataThere(value, 0) == true){
                        phone = value; 
                    }
                    else{
                        phone = "NULL";
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
                        email = "NULL";
                    }
                }
            }
        
        }
            
            
        //#################The ending of the person class###############
        //this is the start of the class of okay values
        //a lot of them are not being used, they are more here som whne the valators need to be added i have them 
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

            //this is seeing if the lenght of the string is equal to a number, if yes it returns true
            public static bool isEqualToStr(string tempNum, int size)
            {
                bool value;
                if(tempNum.Length == size){
                    value = true;
                }
                else{
                    value = false;
                }

                return value;


            }


            //this is sting.value >= number
            public static bool isBiggerThanAnEqualStr(string tempNum, int size)
            {
                bool value;
                if(tempNum.Length >= size){
                    value = true;
                }
                else{
                    value = false;
                }
                return value;
            }
            

        }


        //###################################End of the valed data################################endregion
        //This is where i will put basic tool i need
        class basicTools{

            // just a quiting tool, it will be changed to allow the user to quit if they want to
            public static void quit(){
                
                Console.WriteLine("\n--Press any key to end the program--");
                Console.ReadKey();

            }
        }

        //##################################End of the tools start of the main code#####################

        //This is the main function, any code in here will run
        static void Main(){
            

            //this is checnking if the data inputed is correct
            bool valedInfo;

            person rec = new person();

            
            
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


            
            //this is making sure its a number,
            int tempZipInt;
            do{
                Console.Write("What is your Zip code? ");
                    //this is reading the input and making sure it can be a number
                valedInfo = int.TryParse(Console.ReadLine(), out tempZipInt);
                    //it is is anything other than a number it tells the user
                if (valedInfo == false){
                    Console.WriteLine("\nMust be a number\n");
                }
            }while(valedInfo == false);
                
            string tempZipString = tempZipInt.ToString();

            rec.Zip = tempZipString;
            
            








            // do{
            //     // rec.Zip = Console.ReadLine();
            //     //makse sure its a number
            //     int tempZipInt;
            //     do{
            //         Console.Write("What is your Zip code? ");
            //         valedInfo = int.TryParse(Console.ReadLine(), out tempZipInt);

            //         if (valedInfo == false){
            //             Console.WriteLine("\nMust be a number\n");
            //         }


            //     }while(valedInfo == false);
            //     //setting that number value to a string
            //     string tempZipString = tempZipInt.ToString();
            //     // valedInfo = int.TryParse(Console.ReadLine(), out tempZip);
                
                
            //     if (valueOkay.isBiggerThanAnEqualStr(tempZipString, 5) == true){
            //         valedInfo = true;
            //         rec.Zip = tempZipString;
            //     }
            //     else{
            //         Console.WriteLine("\nIt must be 5 numbers\n");
            //         valedInfo = false;
            //     }

            // }while (valedInfo == false);

            //needs to be ten digets
            // Console.Write("What is your phone number? ");
            // rec.Phone = Console.ReadLine();
            





            
            // rec.Zip = Console.ReadLine();
            //makse sure its a number

            int tempPhoneInt = 0;
            do{
                
                Console.Write("What is your Phone Number? ");
                valedInfo = int.TryParse(Console.ReadLine(), out tempPhoneInt);                    

                if (valedInfo == false){
                    
                    Console.WriteLine("\nMust be a number like: 1234567\n");
                }

            
            }while(valedInfo == false);
            //setting that number value to a string
            string tempPhoneString = tempPhoneInt.ToString();

            rec.Phone = tempPhoneString;
                



            
            // must be a email with the "@" just cus
            Console.Write("What is your email? ");
            rec.Email = Console.ReadLine();



            Console.Clear();
            //########################################################################
            //This will just be where outputs will be

            Console.WriteLine("\nThe Person you just enerted is \n");
            Console.WriteLine($"First Name: {rec.FName}");
            Console.WriteLine($"Middle Name: {rec.MName}");
            Console.WriteLine($"Last Name: {rec.LName}");

            Console.WriteLine($"\n1 Street: {rec.Street1}");
            Console.WriteLine($"2 Street: {rec.Street2}");

            Console.WriteLine($"\nCity: {rec.City}");
            Console.WriteLine($"State: {rec.State}");
            Console.WriteLine($"Zip Code: {rec.Zip}");

            Console.WriteLine($"\nPhone Number: {rec.Phone}");
            Console.WriteLine($"Email: {rec.Email}");


            
            basicTools.quit();

        }




    }





}
