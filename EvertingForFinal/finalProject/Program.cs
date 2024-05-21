


namespace final{


    class Program {
        
        class userData{
            private string userName;


            public string USERNAME{
                get{return userName;}
                set{ userName = value;}
            }

            



        }

        static void Main (string[] args) {
            string value = "";

            userData temp = new userData();


            Console.WriteLine("What would you like to input: ");
            

            temp.USERNAME = Console.ReadLine();
            
            Console.WriteLine(temp.USERNAME);
        }
        
    }

}