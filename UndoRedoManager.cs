using System;
using System.Collections.Generic;
namespace WinFormsCalculatorVSCode;

public class UndoRedoManager
{
    private readonly Stack<IAction> _u = new Stack<IAction>();
    private readonly Stack<IAction> _r = new Stack<IAction>();
    public event Action HistoryChanged;
    public bool CanUndo => _u.Count > 0;
    public bool CanRedo => _r.Count > 0;

    public void Execute(IAction a)
    {
        a.Execute(); _u.Push(a); _r.Clear(); OnHistoryChanged();
    }
    public void Undo()
    {
        if (CanUndo) { var a = _u.Pop(); a.UnExecute(); _r.Push(a); OnHistoryChanged(); }
    }
    public void Redo()
    {
        if (CanRedo) { var a = _r.Pop(); a.Execute(); _u.Push(a); OnHistoryChanged(); }
    }
    protected virtual void OnHistoryChanged() => HistoryChanged?.Invoke();
}