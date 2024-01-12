namespace NumberGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.primeNumGroupBox = new System.Windows.Forms.GroupBox();
            this.clearGenPrimeNumsButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.countPrimeNumsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowerBoundPrimeNumsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.upperBoundPrimeNumsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stopGenPrimeNumsButton = new System.Windows.Forms.Button();
            this.startGenPrimeNumsButton = new System.Windows.Forms.Button();
            this.genPrimeNumsListBox = new System.Windows.Forms.ListBox();
            this.upperBoundLabel = new System.Windows.Forms.Label();
            this.lowerBoundLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearGenFibNumsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countFibNumsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowerBoundFibNumsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.upperBoundFibNumsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stopGenFibNumsButton = new System.Windows.Forms.Button();
            this.startGenFibNumsButton = new System.Windows.Forms.Button();
            this.genFibNumsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.primeNumGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countPrimeNumsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundPrimeNumsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundPrimeNumsNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countFibNumsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundFibNumsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundFibNumsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // primeNumGroupBox
            // 
            this.primeNumGroupBox.Controls.Add(this.clearGenPrimeNumsButton);
            this.primeNumGroupBox.Controls.Add(this.quantityLabel);
            this.primeNumGroupBox.Controls.Add(this.countPrimeNumsNumericUpDown);
            this.primeNumGroupBox.Controls.Add(this.lowerBoundPrimeNumsNumericUpDown);
            this.primeNumGroupBox.Controls.Add(this.upperBoundPrimeNumsNumericUpDown);
            this.primeNumGroupBox.Controls.Add(this.stopGenPrimeNumsButton);
            this.primeNumGroupBox.Controls.Add(this.startGenPrimeNumsButton);
            this.primeNumGroupBox.Controls.Add(this.genPrimeNumsListBox);
            this.primeNumGroupBox.Controls.Add(this.upperBoundLabel);
            this.primeNumGroupBox.Controls.Add(this.lowerBoundLabel);
            this.primeNumGroupBox.Location = new System.Drawing.Point(13, 13);
            this.primeNumGroupBox.Name = "primeNumGroupBox";
            this.primeNumGroupBox.Size = new System.Drawing.Size(252, 283);
            this.primeNumGroupBox.TabIndex = 1;
            this.primeNumGroupBox.TabStop = false;
            this.primeNumGroupBox.Text = "Генерация простых чисел";
            // 
            // clearGenPrimeNumsButton
            // 
            this.clearGenPrimeNumsButton.Location = new System.Drawing.Point(166, 245);
            this.clearGenPrimeNumsButton.Name = "clearGenPrimeNumsButton";
            this.clearGenPrimeNumsButton.Size = new System.Drawing.Size(75, 23);
            this.clearGenPrimeNumsButton.TabIndex = 10;
            this.clearGenPrimeNumsButton.Text = "Очистить";
            this.clearGenPrimeNumsButton.UseVisualStyleBackColor = true;
            this.clearGenPrimeNumsButton.Click += new System.EventHandler(this.clearGenPrimeNumsButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(6, 103);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(98, 13);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Количество чисел";
            // 
            // countPrimeNumsNumericUpDown
            // 
            this.countPrimeNumsNumericUpDown.Location = new System.Drawing.Point(121, 101);
            this.countPrimeNumsNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.countPrimeNumsNumericUpDown.Name = "countPrimeNumsNumericUpDown";
            this.countPrimeNumsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.countPrimeNumsNumericUpDown.TabIndex = 8;
            // 
            // lowerBoundPrimeNumsNumericUpDown
            // 
            this.lowerBoundPrimeNumsNumericUpDown.Location = new System.Drawing.Point(121, 30);
            this.lowerBoundPrimeNumsNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.lowerBoundPrimeNumsNumericUpDown.Name = "lowerBoundPrimeNumsNumericUpDown";
            this.lowerBoundPrimeNumsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.lowerBoundPrimeNumsNumericUpDown.TabIndex = 7;
            // 
            // upperBoundPrimeNumsNumericUpDown
            // 
            this.upperBoundPrimeNumsNumericUpDown.Location = new System.Drawing.Point(121, 65);
            this.upperBoundPrimeNumsNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.upperBoundPrimeNumsNumericUpDown.Name = "upperBoundPrimeNumsNumericUpDown";
            this.upperBoundPrimeNumsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.upperBoundPrimeNumsNumericUpDown.TabIndex = 2;
            // 
            // stopGenPrimeNumsButton
            // 
            this.stopGenPrimeNumsButton.Enabled = false;
            this.stopGenPrimeNumsButton.Location = new System.Drawing.Point(87, 245);
            this.stopGenPrimeNumsButton.Name = "stopGenPrimeNumsButton";
            this.stopGenPrimeNumsButton.Size = new System.Drawing.Size(75, 23);
            this.stopGenPrimeNumsButton.TabIndex = 6;
            this.stopGenPrimeNumsButton.Text = "Стоп";
            this.stopGenPrimeNumsButton.UseVisualStyleBackColor = true;
            this.stopGenPrimeNumsButton.Click += new System.EventHandler(this.stopGenPrimeNumsButton_Click);
            // 
            // startGenPrimeNumsButton
            // 
            this.startGenPrimeNumsButton.Location = new System.Drawing.Point(6, 245);
            this.startGenPrimeNumsButton.Name = "startGenPrimeNumsButton";
            this.startGenPrimeNumsButton.Size = new System.Drawing.Size(75, 23);
            this.startGenPrimeNumsButton.TabIndex = 5;
            this.startGenPrimeNumsButton.Text = "Старт";
            this.startGenPrimeNumsButton.UseVisualStyleBackColor = true;
            this.startGenPrimeNumsButton.Click += new System.EventHandler(this.startGenPrimeNumsButton_Click);
            // 
            // genPrimeNumsListBox
            // 
            this.genPrimeNumsListBox.FormattingEnabled = true;
            this.genPrimeNumsListBox.Location = new System.Drawing.Point(6, 144);
            this.genPrimeNumsListBox.Name = "genPrimeNumsListBox";
            this.genPrimeNumsListBox.Size = new System.Drawing.Size(235, 82);
            this.genPrimeNumsListBox.TabIndex = 4;
            // 
            // upperBoundLabel
            // 
            this.upperBoundLabel.AutoSize = true;
            this.upperBoundLabel.Location = new System.Drawing.Point(6, 67);
            this.upperBoundLabel.Name = "upperBoundLabel";
            this.upperBoundLabel.Size = new System.Drawing.Size(93, 13);
            this.upperBoundLabel.TabIndex = 3;
            this.upperBoundLabel.Text = "Верхняя граница";
            // 
            // lowerBoundLabel
            // 
            this.lowerBoundLabel.AutoSize = true;
            this.lowerBoundLabel.Location = new System.Drawing.Point(6, 32);
            this.lowerBoundLabel.Name = "lowerBoundLabel";
            this.lowerBoundLabel.Size = new System.Drawing.Size(91, 13);
            this.lowerBoundLabel.TabIndex = 2;
            this.lowerBoundLabel.Text = "Нижняя граница";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearGenFibNumsButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countFibNumsNumericUpDown);
            this.groupBox1.Controls.Add(this.lowerBoundFibNumsNumericUpDown);
            this.groupBox1.Controls.Add(this.upperBoundFibNumsNumericUpDown);
            this.groupBox1.Controls.Add(this.stopGenFibNumsButton);
            this.groupBox1.Controls.Add(this.startGenFibNumsButton);
            this.groupBox1.Controls.Add(this.genFibNumsListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(317, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 283);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация чисел Фибоначчи";
            // 
            // clearGenFibNumsButton
            // 
            this.clearGenFibNumsButton.Location = new System.Drawing.Point(166, 245);
            this.clearGenFibNumsButton.Name = "clearGenFibNumsButton";
            this.clearGenFibNumsButton.Size = new System.Drawing.Size(75, 23);
            this.clearGenFibNumsButton.TabIndex = 10;
            this.clearGenFibNumsButton.Text = "Очистить";
            this.clearGenFibNumsButton.UseVisualStyleBackColor = true;
            this.clearGenFibNumsButton.Click += new System.EventHandler(this.clearGenFibNumsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество чисел";
            // 
            // countFibNumsNumericUpDown
            // 
            this.countFibNumsNumericUpDown.Location = new System.Drawing.Point(121, 101);
            this.countFibNumsNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.countFibNumsNumericUpDown.Name = "countFibNumsNumericUpDown";
            this.countFibNumsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.countFibNumsNumericUpDown.TabIndex = 8;
            // 
            // lowerBoundFibNumsNumericUpDown
            // 
            this.lowerBoundFibNumsNumericUpDown.Location = new System.Drawing.Point(121, 30);
            this.lowerBoundFibNumsNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.lowerBoundFibNumsNumericUpDown.Name = "lowerBoundFibNumsNumericUpDown";
            this.lowerBoundFibNumsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.lowerBoundFibNumsNumericUpDown.TabIndex = 7;
            // 
            // upperBoundFibNumsNumericUpDown
            // 
            this.upperBoundFibNumsNumericUpDown.Location = new System.Drawing.Point(121, 65);
            this.upperBoundFibNumsNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.upperBoundFibNumsNumericUpDown.Name = "upperBoundFibNumsNumericUpDown";
            this.upperBoundFibNumsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.upperBoundFibNumsNumericUpDown.TabIndex = 2;
            // 
            // stopGenFibNumsButton
            // 
            this.stopGenFibNumsButton.Enabled = false;
            this.stopGenFibNumsButton.Location = new System.Drawing.Point(87, 245);
            this.stopGenFibNumsButton.Name = "stopGenFibNumsButton";
            this.stopGenFibNumsButton.Size = new System.Drawing.Size(75, 23);
            this.stopGenFibNumsButton.TabIndex = 6;
            this.stopGenFibNumsButton.Text = "Стоп";
            this.stopGenFibNumsButton.UseVisualStyleBackColor = true;
            this.stopGenFibNumsButton.Click += new System.EventHandler(this.stopGenFibNumsButton_Click);
            // 
            // startGenFibNumsButton
            // 
            this.startGenFibNumsButton.Location = new System.Drawing.Point(6, 245);
            this.startGenFibNumsButton.Name = "startGenFibNumsButton";
            this.startGenFibNumsButton.Size = new System.Drawing.Size(75, 23);
            this.startGenFibNumsButton.TabIndex = 5;
            this.startGenFibNumsButton.Text = "Старт";
            this.startGenFibNumsButton.UseVisualStyleBackColor = true;
            this.startGenFibNumsButton.Click += new System.EventHandler(this.startGenFibNumsButton_Click);
            // 
            // genFibNumsListBox
            // 
            this.genFibNumsListBox.FormattingEnabled = true;
            this.genFibNumsListBox.Location = new System.Drawing.Point(6, 144);
            this.genFibNumsListBox.Name = "genFibNumsListBox";
            this.genFibNumsListBox.Size = new System.Drawing.Size(235, 82);
            this.genFibNumsListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Верхняя граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Нижняя граница";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.primeNumGroupBox);
            this.Name = "Form1";
            this.Text = "Генератор чисел";
            this.primeNumGroupBox.ResumeLayout(false);
            this.primeNumGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countPrimeNumsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundPrimeNumsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundPrimeNumsNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countFibNumsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundFibNumsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundFibNumsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox primeNumGroupBox;
        private System.Windows.Forms.Label upperBoundLabel;
        private System.Windows.Forms.Label lowerBoundLabel;
        private System.Windows.Forms.ListBox genPrimeNumsListBox;
        private System.Windows.Forms.Button startGenPrimeNumsButton;
        private System.Windows.Forms.Button stopGenPrimeNumsButton;
        private System.Windows.Forms.NumericUpDown lowerBoundPrimeNumsNumericUpDown;
        private System.Windows.Forms.NumericUpDown upperBoundPrimeNumsNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown countPrimeNumsNumericUpDown;
        private System.Windows.Forms.Button clearGenPrimeNumsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearGenFibNumsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown countFibNumsNumericUpDown;
        private System.Windows.Forms.NumericUpDown lowerBoundFibNumsNumericUpDown;
        private System.Windows.Forms.NumericUpDown upperBoundFibNumsNumericUpDown;
        private System.Windows.Forms.Button stopGenFibNumsButton;
        private System.Windows.Forms.Button startGenFibNumsButton;
        private System.Windows.Forms.ListBox genFibNumsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

