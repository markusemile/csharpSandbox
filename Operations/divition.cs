namespace CsharpSandBox.Operations
{
    public class Division : Operation
    {
        public override string symbole => "/";
        
        public Division(int operandGauche, int operandDroit) : base(operandGauche, operandDroit)
        {

        }
        public override void Executer()
        {
            if (OperandDroit != 0) {   
                Resultat = OperandGauche / OperandDroit;
            }
        }
    }
    
}