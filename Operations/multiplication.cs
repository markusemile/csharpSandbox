namespace CsharpSandBox.Operations
{
    public class Multiplication : Operation
    {
        public override string symbole => "x";
        public Multiplication(int operandGauche, int operandDroit) : base(operandGauche, operandDroit)
        {

        }
        public override void Executer()
        {
            Resultat = OperandGauche * OperandDroit;
        }
    }
    
}