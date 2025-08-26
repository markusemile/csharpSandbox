using CsharpSandBox.Operations;

public class Puissance : Operation
{
    
    public override string symbole => "^";
    public Puissance(int operandGauche, int operandDroit) : base(operandGauche, operandDroit)
    {

    }

    public override void Executer()
    {
        Resultat = (int)Math.Pow(OperandGauche, OperandDroit);
    }
}