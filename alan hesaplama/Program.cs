namespace alan_hesaplama;

class Program
{
    static void Main(string[] args)
    {
        Area result = new Area();
        Console.WriteLine(result.CalculateArea());
    }
    class Area{
        public string chosen="";
        public string size="";
        public Area(){
            Console.Write("Lütfen istediğiniz geometri şekli seçin (Daire,Ücgen,Kare,Dikdortgen): ");
            chosen = Console.ReadLine();

            Console.Write("Lütfen hesaplamak istediğiniz boyutu seçiniz (Cevre,Alan,Hacim): ");
            size = Console.ReadLine();

        }
        public int CalculateArea(){
            int result=0;
            Console.WriteLine(chosen);
            Console.WriteLine(size);
            if(chosen == "daire"){
                Console.Write("Lütfen dairenin yarıçapını giriniz");
                int radius = Convert.ToInt32(Console.ReadLine());
                if(size == "cevre"){
                    result = 2 * 3 * radius;
                    
                }else if(size == "alan"){
                    result = 3 * radius * radius;
                }else{
                    Console.Write("Lütfen yükseklik değerini giriniz: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    result = 3 * radius * 2 * height;
                }
            }else if(chosen == "ucgen"){
                if(size=="cevre"){
                    Console.Write("Birinci kenar için bir değer giriniz: ");
                    int triangle1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("İkinci kenar için bir değer giriniz: ");
                    int triangle2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Üçüncü  kenar için bir değer giriniz: ");
                    int triangle3 = Convert.ToInt32(Console.ReadLine());

                    result = triangle1 + triangle2 + triangle3;
                }else if(size == "alan"){
                    Console.Write("Bir kenar değeri giriniz: ");
                    int area1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("O kenara ait bir yükseklik giriniz: ");
                    int height1 = Convert.ToInt32(Console.ReadLine());
                    
                    result = (area1 * height1)/2;
                }else{
                    Console.Write("Bir kenar değeri giriniz: ");
                    int area1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("O kenara ait bir yükseklik giriniz: ");
                    int height1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Üçgen prizmanın yükseklik değerini giriniz:");
                    int height2 = Convert.ToInt32(Console.ReadLine());
                    result = ((area1 * height1)/2) * height2;
                }
            }else if(chosen == "kare"){
                Console.WriteLine("Lütfen bir kenar değeri giriniz:");
                int square = Convert.ToInt32(Console.ReadLine());
                if(size == "cevre"){
                    result = 4 * square;
                }else if(size == "alan"){
                    result = square * square;
                }else{
                    Console.Write("Lütfen bir yükseklik değeri giriniz: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    result = square * square * height;
                }
            }else{
                Console.WriteLine("Lütfen dikdörtgenin bir kenarının değerini giriniz: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen dikdörtgenin iknici kenarının değerini giriniz: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                
                if(size == "cevre"){
                    result = 2 * (number1+number2);
                }else if(size == "alan"){
                    result = number1 * number2;
                }else{
                    Console.WriteLine("Lütfen dikdörtgenin yükseklik kenarının değerini giriniz: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    result = number1 * number2 * height;
                }
            }
            return result;
        }
    }
}
