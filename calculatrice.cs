namespace CsharpSandBox
{
    public class Calculatrice
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Substract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0) return 0;
            return a / b;
        }
        public int Modulo(int a, int b)
        {
            return a % b;
        }

        public void StartHere()
        {
            Console.Write("Veuillez entrer le premier nombre : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Veuillez entrer le deuxième nombre : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Veuillez choisir l'opération : ");
            string operation = String.Concat(Console.ReadLine());

            float result = 0;

            switch (operation)
            {
                case "+":
                    result = Addition(n1, n2);
                    break;
                case "-":
                    result = Substract(n1, n2);
                    break;
                case "*":
                    result = Multiply(n1, n2);
                    break;
                case "/":
                    result = Divide(n1, n2);
                    break;
                case "%":
                    result = Modulo(n1, n2);
                    break;
                default:
                    Console.WriteLine("L'opération n'est pas reconnue.");
                    break;

            }
            String txt = "Resultat de l'opération : " + n1 + " " + operation + " " + n2 + " = " + result;
            Console.WriteLine(txt);
                
        }

    }
} 