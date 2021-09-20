using System;
using System.IO;

namespace ExceptionsProject {
    class Program {
        static void Main(string[] args)
        {
            Conto c = new Conto();
            c.Saldo = 1000;
            try
            {
                c.Ritira(500);
                c.Ritira(501);
            }
            catch (FondiInsufficientiException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine($" Saldo : {fe.Saldo} , Somma richiesta : {fe.AmmontareRichiesto}, Sforamento : {fe.Sforamento}");
            }
            
            Console.WriteLine("Inizio Main :");
            F1();
            Console.WriteLine("Fine Main : ");
        }
        static void F1()
        {
            Console.WriteLine("Inizio F1 :");
            F2();
            Console.WriteLine("Fine F1 : ");
        }
        static void F2()
        {
            Console.WriteLine("Inizio F2 :");
            try
            {
                F3();
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (FileNotFoundException fnf)
            {

            }
            catch (IOException sql)
            {

            }
            finally
            {

            }
            Console.WriteLine("Fine F2 : ");
        }
        static void F3()
        {
            Console.WriteLine("Inizio F3 :");
            int x;
            x = int.Parse("Ciccio");
            bool succes = int.TryParse("ciccio", out int y);

            Console.WriteLine("Fine F3 : ");
        }
    }
    
}
