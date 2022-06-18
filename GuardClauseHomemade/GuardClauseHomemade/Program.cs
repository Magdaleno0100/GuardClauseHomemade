using GuardClauseHomemade.Guard;
using System;

namespace GuardClauseHomemade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input data
            string name = "Magdaleno";
            int age = 1;

            try
            {
                var oGuardClauses = new GuardClauses();
                oGuardClauses.EvaluateInput<string>((x) => !string.IsNullOrEmpty(x), "Es nullo o vacío", name);
                oGuardClauses.EvaluateInput<int>((x) => x > 18, "No es mayor a 18", age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finaliza Pruebas");
            }

            Console.ReadKey();
        }
    }
}
