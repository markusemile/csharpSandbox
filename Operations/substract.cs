namespace CsharpSandBox.Operations
{
    public class Substraction : Operation
    {
        public override string symbole => "-";
        public Substraction(int operandGauche, int operandDroit) : base(operandGauche, operandDroit)
        {

        }
        public override void Executer()
        {
            Resultat = OperandGauche - OperandDroit;
        }
    }
    
}