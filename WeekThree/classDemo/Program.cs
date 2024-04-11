// See https://aka.ms/new-console-template for more information




namespace Week3_ClassDemo {
    class Program {
        static string rev(string text){
            // Console.WriteLine(text);
            string newText = " ";
            for(int i = text.Length - 1; i >= 0; i-- ){
                // Console.Write(text[i]);
                newText += text[i];
                // string newText = text[i];
            }
            //Returning
            return newText;
        }
        static void Main (string[] args) {
            string text = "hello", textTest = "";
            // rev(text);
            textTest = rev(text);
            Console.WriteLine(text);
            Console.WriteLine(textTest);
            
        }
    }
}

