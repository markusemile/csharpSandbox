namespace CsharpSandBox.Operations
{
    public class Addition : Operation
    {
        
        public Addition(int operandGauche, int operandDroit) : base(operandGauche, operandDroit)
        {

        }

        public override string symbole => "+";

        public override void Executer()
        {
            Resultat = OperandGauche + OperandDroit;
        }
    }
    
}