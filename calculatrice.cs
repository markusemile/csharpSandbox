using CsharpSandBox.Operations;

namespace CsharpSandBox{


    public class Calculatrice
    {

        private IOperation Operation { get; set; }
        public int Resultat => Operation.Resultat;

        public Calculatrice(IOperation operation)
        {
            this.Operation = operation;
        }

        public void Executer()
        {
            Operation.Executer();
        }

        public String ToString() => Operation.ToString();

    }
} 