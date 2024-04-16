


namespace Week4_classDemo {
    class Program {
        struct Point{
            public int X;
            public  int Y;
            public Point(int x, int y){
                X = x;
                Y = y;
            }
        }
        static Point getRandomPoint(){
            Random rnd = new Random();
            int xValue = rnd.Next(-101, 101);
            int yValue = rnd.Next(-101, 101);
            return new Point(xValue,yValue);
        }
        static void Main (string[] args) {
            Point firstPoint = getRandomPoint();
            Console.WriteLine($"({firstPoint.X} , {firstPoint.Y})");
            
        }
    }

    



    class car{

        string color = "red";

        static void Carlists(string[] args){

            




        }





    }





}