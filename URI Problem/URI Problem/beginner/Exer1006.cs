using System; 

class URI {

    static void Main(string[] args) { 
            double A, B, C, MEDIA;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

           
           MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;
            Console.WriteLine("MEDIA = "+String.Format("{0:0.0}",MEDIA));
            Console.ReadKey();

    }

}
