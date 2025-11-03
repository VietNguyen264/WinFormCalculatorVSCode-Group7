namespace WinFormsCalculatorVSCode;

public class CalculatorAction : IAction
{
    private readonly Calculator _calculator;
    private readonly char _operator;
    private readonly int _operand;
    private int _previousValue;

    public CalculatorAction(Calculator c, char op, int val)
    {
        _calculator = c; _operator = op; _operand = val;
    }

    public void Execute()
    {
        _previousValue = _calculator.CurrentValue;
        _calculator.Operation(_operator, _operand);
    }

    public void UnExecute() => _calculator.SetValue(_previousValue);
}