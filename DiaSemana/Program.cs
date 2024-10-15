namespace DiaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un número :D");
            string dato = Console.ReadLine();
            int dia = 0;
            bool sePudoconvertir = false;
            sePudoconvertir = int.TryParse(dato, out dia); 

            if (sePudoconvertir && dia >=1 && dia <=7)
            {
                Console.WriteLine(sePudoconvertir + " " + dia);
            }
        }
    }
}
