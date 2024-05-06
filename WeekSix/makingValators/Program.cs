// See https://aka.ms/new-console-template for more information


public class Program{



    public static bool isInstaAccount(string tempString){
        string Instachecker = "instagram.com/";
        for(int i = 0; i != 13; i++ ){
            
            if (char.ToLower(tempString[i]) != Instachecker[i]){
                return false;
            }
        }
        return true;
    }



    public static void Main(){




        /*they look like instagram.com/username */

        string instaAccount = "";
        bool IsItAnaccount = false;
        Console.WriteLine("What is the instaAccount: ");
        instaAccount = Console.ReadLine();

        IsItAnaccount = isInstaAccount(instaAccount);

        Console.WriteLine(IsItAnaccount);






    }

}