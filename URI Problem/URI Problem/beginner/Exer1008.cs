using System; 

class URI {

    static void Main(string[] args) { 

             int numero, horas;
            double qtoGanha, salario;

            numero = Convert.ToInt16(Console.ReadLine());
            horas = Convert.ToInt16(Console.ReadLine());
            qtoGanha = Convert.ToDouble(Console.ReadLine());

            salario = horas * qtoGanha;

            Console.WriteLine("NUMBER = "+numero+"\nSALARY = U$ "+String.Format("{0:0.00}",salario));
            Console.ReadKey();

    }

}
