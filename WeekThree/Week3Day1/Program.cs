// See https://aka.ms/new-console-template for more information



class testing{
    static void CreatedMethod(){
        //code is going here
    }
}


namespace Week3_Sample1 {
    class Program {
        static void Main (string[] args) {
            for (int i = 1; i <= 10; i++) {
                // Console.Write(i);
                for(int j = 1; j <= 10; j++){
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine(" ");
            }
        }
    }
}