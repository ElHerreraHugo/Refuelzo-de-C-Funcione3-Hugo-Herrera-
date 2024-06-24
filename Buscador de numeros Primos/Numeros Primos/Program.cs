
class NumerosPrimo
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al Buscador de Numeros Primos.");

        Console.Write("\nIngrese el Numero inicial del Rango: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("\nIngrese el Numero Final del Rango: ");
        int final = int.Parse(Console.ReadLine());


        List<int> Primos = new List<int>();

        for (int i = inicio; i <= final; i++)
        {
            if (EsPrimo(i))
            {
                Primos.Add(i);

            }
        }


        bool EsPrimo(int numero)
        {
            bool primo;

            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }


        {
            Console.WriteLine($"\nLos Numeros Dentro del Rango son: {inicio} y {final} los números primos son:");

            foreach (int primo in Primos)
            {
                Console.Write(primo + ",");
            }
        }
    }
}
        
        
    













