using System; 

class URI {

    static void Main(string[] args) { 

         int A, B, C, D,DIFERENCA;
            A = Convert.ToInt16(Console.ReadLine());
            B = Convert.ToInt16(Console.ReadLine());
            C = Convert.ToInt16(Console.ReadLine());
            D = Convert.ToInt16(Console.ReadLine());
           
           DIFERENCA = ((A * B) - ( C * D) );
            Console.WriteLine("DIFERENCA = "+DIFERENCA);
            Console.ReadKey();

    }

}
