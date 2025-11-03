namespace WinFormsCalculatorVSCode
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox operandTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;

        private void InitializeComponent()
        {
            // Khởi tạo các Controls
            this.resultLabel = new System.Windows.Forms.Label();
            this.operandTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            var promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Cấu hình resultLabel
            this.resultLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.resultLabel.Size = new System.Drawing.Size(400, 80);
            this.resultLabel.Text = "Kết quả: 0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Cấu hình operandTextBox
            this.operandTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.operandTextBox.Location = new System.Drawing.Point(120, 95);
            this.operandTextBox.Name = "operandTextBox";
            this.operandTextBox.Size = new System.Drawing.Size(250, 39);
            this.operandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Cấu hình một Label nhỏ
            promptLabel.Text = "Nhập số:";
            promptLabel.ForeColor = System.Drawing.Color.White; // Thêm màu cho dễ thấy
            promptLabel.Location = new System.Drawing.Point(20, 100);
            promptLabel.AutoSize = true;

            // Cấu hình TableLayoutPanel
            this.buttonPanel.ColumnCount = 4;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.RowCount = 2;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Location = new System.Drawing.Point(20, 150);
            this.buttonPanel.Size = new System.Drawing.Size(350, 120);

            // Hàm trợ giúp để cấu hình các nút bấm
            Action<Button, string> configureButton = (btn, text) => {
                btn.Text = text;
                btn.Dock = System.Windows.Forms.DockStyle.Fill;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;
            };

            // Cấu hình và thêm nút vào Panel
            configureButton(this.addButton, "+");
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPanel.Controls.Add(this.addButton, 0, 0);

            configureButton(this.subtractButton, "-");
            this.subtractButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPanel.Controls.Add(this.subtractButton, 1, 0);

            configureButton(this.multiplyButton, "*");
            this.multiplyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPanel.Controls.Add(this.multiplyButton, 2, 0);

            configureButton(this.divideButton, "/");
            this.divideButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPanel.Controls.Add(this.divideButton, 3, 0);

            configureButton(this.undoButton, "Undo");
            this.undoButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPanel.Controls.Add(this.undoButton, 0, 1);
            this.buttonPanel.SetColumnSpan(this.undoButton, 2);

            configureButton(this.redoButton, "Redo");
            this.redoButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPanel.Controls.Add(this.redoButton, 2, 1);
            this.buttonPanel.SetColumnSpan(this.redoButton, 2);

            // Cấu hình Form chính
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(25, 25, 112); // MidnightBlue
            this.ClientSize = new System.Drawing.Size(392, 293);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính Undo/Redo (VS Code)";
            
            // Thêm các controls vào Form
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(promptLabel);
            this.Controls.Add(this.operandTextBox);
            this.Controls.Add(this.resultLabel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}