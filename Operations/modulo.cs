namespace CsharpSandBox.Operations
{
    public class Modulo : Operation
    {
        public override string symbole => "%";
        public Modulo(int operandGauche, int operandDroit) : base(operandGauche, operandDroit)
        {

        }
        public override void Executer()
        {
            Resultat = OperandGauche % OperandDroit;
        }
    }
    
}