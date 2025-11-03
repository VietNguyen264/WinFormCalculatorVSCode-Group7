using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsCalculatorVSCode
{
    public partial class Form1 : Form
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly UndoRedoManager _undoRedoManager = new UndoRedoManager();

        public Form1()
        {
            InitializeComponent(); // Dòng này gọi code giao diện bạn vừa viết

            // Gán sự kiện cho các nút bấm
            this.addButton.Click += (s, e) => ExecuteCalculation('+');
            this.subtractButton.Click += (s, e) => ExecuteCalculation('-');
            this.multiplyButton.Click += (s, e) => ExecuteCalculation('*');
            this.divideButton.Click += (s, e) => ExecuteCalculation('/');
            this.undoButton.Click += (s, e) => _undoRedoManager.Undo();
            this.redoButton.Click += (s, e) => _undoRedoManager.Redo();

            // Đăng ký lắng nghe sự kiện từ manager
            _undoRedoManager.HistoryChanged += UpdateUI;

            // Cập nhật giao diện lần đầu
            UpdateUI();
        }

        private void ExecuteCalculation(char op)
        {
            if (int.TryParse(operandTextBox.Text, out int operand))
            {
                var action = new CalculatorAction(_calculator, op, operand);
                _undoRedoManager.Execute(action);
                operandTextBox.Focus();
                operandTextBox.SelectAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }

        private void UpdateUI()
        {
            resultLabel.Text = $"Kết quả: {_calculator.CurrentValue}";
            undoButton.Enabled = _undoRedoManager.CanUndo;
            redoButton.Enabled = _undoRedoManager.CanRedo;

            // Thêm hiệu ứng mờ cho nút bị vô hiệu hóa
            undoButton.BackColor = undoButton.Enabled ? Color.DodgerBlue : Color.Gray;
            redoButton.BackColor = redoButton.Enabled ? Color.DodgerBlue : Color.Gray;
        }
    }
}