// See https://aka.ms/new-console-template for more information

using System;

namespace classDemo {






    class Program {
        

        static string rev(string text){
            // Console.WriteLine(text);
            string newText = "";
            for(int i = text.Length - 1; i >= 0; i-- ){
                // Console.Write(text[i]);
                newText += text[i];
                // string newText = text[i];
            }
            //Returning
            
            return newText;
        }


        static bool isPalindrome(string text, string newText){
        
            if (text != newText){
                return false;
            }
            return true;
        }



        static void Main (string[] args) {
            string text = "";
            string afterText = "";
            bool isTrue;
            Console.Write("What is the value: ");
            text = Console.ReadLine();

            afterText = rev(text);

            isTrue = isPalindrome(text, afterText);

            Console.Write(isTrue);
        }
    }
}



