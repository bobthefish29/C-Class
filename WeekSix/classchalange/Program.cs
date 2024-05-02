// See https://aka.ms/new-console-template for more information
using System;
namespace classDemo {
    class Program {
        static bool isPalindrome(string text){
            if(text.Length == 0 ){
                return false;
            }
            for(int i = 0 ; i <= (text.Length - 1) / 2; i++ ){
                if(Char.ToLower(text[text.Length - 1 - i]) != Char.ToLower(text[i])){
                    return false;
                }
            }
            return true;
        }
        static void Main (string[] args) {
            string text = "";
            string afterText = "";
            bool isTrue;
            Console.Write("What is the value: ");
            text = Console.ReadLine();
            isTrue = isPalindrome(text);
            Console.Write($"The Value you entered is {isTrue}");
        }
    }
}