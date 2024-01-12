using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * ЗАДАНИЕ 1: 
 * Создайте оконное приложение, генерирующее набор простых чисел в диапазоне, указанном пользователем. 
 * Если не указана нижняя граница, поток с стартует с 2. 
 * Если не указана верхняя граница, генерирование происходит до завершения приложения. Используйте механизм потоков. 
 * Числа должны отображаться в оконном интерфейсе. 
 * 
 * ЗАДАНИЕ 2: 
 * Добавьте к первому заданию поток, генерирующий набор чисел Фибоначчи. Числа должны отображаться в оконном интерфейсе. 
 * 
 * ЗАДАНИЕ 3: 
 * Добавьте ко второму заданию кнопки для полной остановки каждого из потоков. 
 * Одна кнопка на один поток. Если пользователь нажал на кнопку остановки, поток полностью прекращает свою работу.
 */


namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource genPrimeNumsCancellationTokenSource;
        private CancellationTokenSource genFibNumsCancellationTokenSource;

        private Random random;

        public Form1()
        {
            InitializeComponent();
            this.random = new Random();
        }

        // ГЕНЕРАТОР ПРОСТЫХ ЧИСЕЛ
        private void startGenPrimeNumsButton_Click(object sender, EventArgs e)
        {
            int lowerBound = (int)this.lowerBoundPrimeNumsNumericUpDown.Value;
            int upperBound = (int)this.upperBoundPrimeNumsNumericUpDown.Value;

            int count = this.countPrimeNumsNumericUpDown.Value == 0 ? int.MaxValue : (int)this.countPrimeNumsNumericUpDown.Value; // если count равен нулю, то числа будут генерироваться условно бесконечно

            if (lowerBound >= upperBound)
            {
                MessageBox.Show($"Нижняя граница ({lowerBound}) больше или равна верхней границы ({upperBound}).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.genPrimeNumsCancellationTokenSource = new CancellationTokenSource();

            Task.Run(() => PrimeNumberGenerator(lowerBound, upperBound + 1, count)); // добавляется единица, так как последнее число не включается

            this.startGenPrimeNumsButton.Enabled = false;
            this.stopGenPrimeNumsButton.Enabled = true;
        }

        private void stopGenPrimeNumsButton_Click(object sender, EventArgs e)
        {
            this.genPrimeNumsCancellationTokenSource?.Cancel(); // если объект не пустой, то отмена операции (хотя, это не нужно, у меня кнопки блокируются)

            this.startGenPrimeNumsButton.Enabled = true;
            this.stopGenPrimeNumsButton.Enabled = false;
        }

        private void clearGenPrimeNumsButton_Click(object sender, EventArgs e)
        {
            this.genPrimeNumsListBox.Items.Clear();
        }

        private async void PrimeNumberGenerator(int lowerBound, int upperBound, int count)
        {
            int i = 0;
            while (!this.genPrimeNumsCancellationTokenSource.IsCancellationRequested && i < count)
            {
                this.genPrimeNumsListBox.Items.Add(this.random.Next(lowerBound, upperBound));
                this.genPrimeNumsListBox.TopIndex = this.genPrimeNumsListBox.Items.Count - 1; // чтобы фокус переключался на последний добавленный элемент
                i++;

                await Task.Delay(50);
            }

            // ChatGPT предложил это
            //for (int i = 0; i < count; i++)
            //{
            //    this.cancellationTokenSource.Token.ThrowIfCancellationRequested();

            //    this.generatedNumsListBox.Items.Add(this.random.Next(lowerBound, upperBound));
            //    this.generatedNumsListBox.TopIndex = this.generatedNumsListBox.Items.Count - 1;

            //    this.cancellationTokenSource.Token.ThrowIfCancellationRequested();
            //}

            this.startGenPrimeNumsButton.Enabled = true;
            this.stopGenPrimeNumsButton.Enabled = false;
        }



        // ГЕНЕРАТОР ЧИСЕЛ ФИБОНАЧЧИ
        private void startGenFibNumsButton_Click(object sender, EventArgs e)
        {
            int lowerBound = (int)this.lowerBoundFibNumsNumericUpDown.Value;
            int upperBound = (int)this.upperBoundFibNumsNumericUpDown.Value;

            int count = this.countFibNumsNumericUpDown.Value == 0 ? int.MaxValue : (int)this.countFibNumsNumericUpDown.Value; // если count равен нулю, то числа будут генерироваться условно бесконечно

            if (lowerBound >= upperBound)
            {
                MessageBox.Show($"Нижняя граница ({lowerBound}) больше или равна верхней границы ({upperBound}).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.genFibNumsCancellationTokenSource = new CancellationTokenSource();

            Task.Run(() => FibNumberGenerator(lowerBound, upperBound + 1, count)); // добавляется единица, так как последнее число не включается

            this.startGenFibNumsButton.Enabled = false;
            this.stopGenFibNumsButton.Enabled = true;
        }

        private void stopGenFibNumsButton_Click(object sender, EventArgs e)
        {
            this.genFibNumsCancellationTokenSource?.Cancel(); // если объект не пустой, то отмена операции (хотя, это не нужно, у меня кнопки блокируются)

            this.startGenFibNumsButton.Enabled = true;
            this.stopGenFibNumsButton.Enabled = false;
        }

        private void clearGenFibNumsButton_Click(object sender, EventArgs e)
        {
            this.genFibNumsListBox.Items.Clear();
        }

        private async void FibNumberGenerator(int lowerBound, int upperBound, int count)
        {
            int i = 0;
            while (!this.genFibNumsCancellationTokenSource.IsCancellationRequested && i < count)
            {
                // Тут какая-то каша происходит
                int first = 0;
                int second = 1;

                for (int j = 0; j < this.random.Next(0, upperBound); j++)
                {
                    int temp = first;
                    first = second;
                    second = temp + first;
                }

                if (second >= lowerBound && second <= upperBound)
                {
                    this.genFibNumsListBox.Items.Add(second);
                    this.genFibNumsListBox.TopIndex = this.genFibNumsListBox.Items.Count - 1; // чтобы фокус переключался на последний добавленный элемент
                    i++;

                    await Task.Delay(50);
                }
            }

            this.startGenFibNumsButton.Enabled = true;
            this.stopGenFibNumsButton.Enabled = false;
        }
    }
}
