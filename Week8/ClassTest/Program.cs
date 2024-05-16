namespace gradeCalk{
    class firstLab{
        public static int lengthOfLastKey(string UserInputED){
            int counting = 0;
            for(int i = UserInputED.Length - 1; i >= 0; i--){
                if(UserInputED[i] != ' '){
                    counting++;
                }else if (counting > 0){
                    break;
                }                
            }
            return counting;}
        
        static void Main (string[] args) {
            Console.WriteLine("What would you like to input: ");
            int number = lengthOfLastKey(Console.ReadLine());
            Console.WriteLine(number);
        }
    }
}
