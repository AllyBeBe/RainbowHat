namespace Calculator
{
    public abstract class AbstractCalculatorController
    {
        public abstract void AcceptCharacter(char input);

        public virtual string GetOutput()
        {
            return "";
        }
    }
}
