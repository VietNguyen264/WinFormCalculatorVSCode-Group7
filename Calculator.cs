namespace WinFormsCalculatorVSCode;

public class Calculator
{
    public int CurrentValue { get; private set; }
    public void Operation(char op, int operand)
    {
        switch (op)
        {
            case '+': CurrentValue += operand; break;
            case '-': CurrentValue -= operand; break;
            case '*': CurrentValue *= operand; break;
            case '/': if (operand != 0) CurrentValue /= operand; break;
        }
    }
    public void SetValue(int value) => CurrentValue = value;
}