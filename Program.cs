using CsharpSandBox;
using CsharpSandBox.Operations;

namespace CsharpSandBox
{
    class Program
    {
        static IOperation? operation;
        static bool exit = false;
        static List<String> operations = new List<String>();
        static void Main(string[] args)
        {
            while (!exit)
            {
                Console.Clear();
                Console.Write("Veuillez entrer le premier nombre : ");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Veuillez entrer le deuxième nombre : ");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Veuillez choisir l'opération : ");
                string operateur = String.Concat(Console.ReadLine());

                switch (operateur)
                {
                    case "+":
                        operation = new Addition(a1, a2);
                        break;
                    case "-":
                        operation = new Substraction(a1, a2);
                        break;
                    case "*":
                        operation = new Multiplication(a1, a2);
                        break;
                    case "/":
                        operation = new Division(a1, a2);
                        break;
                    case "%":
                        operation = new Modulo(a1, a2);
                        break;
                    case "^":
                        operation = new Puissance(a1, a2);
                        break;
                }
                if (operation == null)
                {
                    Console.WriteLine("Opération non reconnue.");
                    continue;
                }
                Calculatrice calculatrice = new Calculatrice(operation);
                calculatrice.Executer();
                Console.WriteLine($"Le résultat est : {calculatrice.Resultat}");
                operations.Add(calculatrice.ToString());

                Console.WriteLine("Voulez-vous continuer ? (O/N) : ");
                string reponse = String.Concat(Console.ReadLine());
                if (reponse == "N" || reponse == "n")
                {
                    exit = true;
                }
            }
            foreach (string operation in operations)
            {
                Console.WriteLine(operation);
            }
        }
    }
}