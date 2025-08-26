namespace CsharpSandBox.Operations
{
    public abstract class Operation : IOperation
    {
        protected int OperandDroit { get; }
        protected int OperandGauche { get; }
        public int Resultat { get; protected set; }

        public abstract String symbole { get; }


        protected Operation(int operandGauche, int operandDroit)
        {
            this.OperandGauche = operandGauche;
            this.OperandDroit = operandDroit;
        }

        public abstract void Executer();
        
        override public string ToString() => $"{OperandGauche} {this.symbole} {OperandDroit} = {Resultat}";

       
    }
}