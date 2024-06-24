
class JuegoDados
{
    static void Main(string[] args)
    {
       
      int LanzarDado()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

      
        while (true)
        {
        
            int   dado1 = LanzarDado();
            int dado2 = LanzarDado();


            Console.WriteLine("Primer dado: " + dado1);
            Console.WriteLine("Segundo dado: " + dado2);


            Console.Write("Desea volver a lanzar los dados (si/ no): ");
            string respuesta = Console.ReadLine().ToLower();
          
            if (respuesta != "si")
            {
                break;
            }
       

        }
       
        Console.WriteLine("¡Gracias por jugar!");
    }
}
