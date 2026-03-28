namespace CurrencyConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RadioButton radioUSD;
        private System.Windows.Forms.RadioButton radioEUR;
        private System.Windows.Forms.RadioButton radioPLN;
        private System.Windows.Forms.CheckBox checkBoxFile;
        private System.Windows.Forms.Button buttonCalc;

        private void InitializeComponent()
        {
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.radioUSD = new System.Windows.Forms.RadioButton();
            this.radioEUR = new System.Windows.Forms.RadioButton();
            this.radioPLN = new System.Windows.Forms.RadioButton();
            this.checkBoxFile = new System.Windows.Forms.CheckBox();
            this.buttonCalc = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // textBoxAmount
            this.textBoxAmount.Location = new System.Drawing.Point(30, 30);
            this.textBoxAmount.Size = new System.Drawing.Size(150, 22);

            // radioUSD
            this.radioUSD.Text = "USD";
            this.radioUSD.Location = new System.Drawing.Point(30, 70);

            // radioEUR
            this.radioEUR.Text = "EUR";
            this.radioEUR.Location = new System.Drawing.Point(30, 100);

            // radioPLN
            this.radioPLN.Text = "PLN";
            this.radioPLN.Location = new System.Drawing.Point(30, 130);

            // checkBoxFile
            this.checkBoxFile.Text = "Зчитувати з файлу";
            this.checkBoxFile.Location = new System.Drawing.Point(30, 170);

            // buttonCalc
            this.buttonCalc.Text = "Обчислити";
            this.buttonCalc.Location = new System.Drawing.Point(30, 210);
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);

            // textBoxResult
            this.textBoxResult.Location = new System.Drawing.Point(30, 250);
            this.textBoxResult.Size = new System.Drawing.Size(150, 22);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.radioUSD);
            this.Controls.Add(this.radioEUR);
            this.Controls.Add(this.radioPLN);
            this.Controls.Add(this.checkBoxFile);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxResult);
            this.Text = "Конвертер валют";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
