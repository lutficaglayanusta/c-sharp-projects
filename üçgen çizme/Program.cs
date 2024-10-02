namespace üçgen_çizme;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        triangle.drawTriangle();
        
    }
    class Triangle{
        public int number;
        public Triangle(){
            Console.Write("Lütfen üçgenin boyutunu belirleyiniz:");
            this.number =Convert.ToInt32(Console.ReadLine());
        }
        public void drawTriangle(){
            for(int i=1;i<=number;i++){
                for(int j=0;j<i;j++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
