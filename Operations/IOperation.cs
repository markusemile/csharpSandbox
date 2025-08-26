namespace CsharpSandBox.Operations
{
    public interface IOperation
    {
        void Executer();

        int Resultat { get; }

        String ToString();
    }
}