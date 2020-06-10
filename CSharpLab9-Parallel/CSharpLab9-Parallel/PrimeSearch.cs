using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLab9_Parallel
{
    public partial class PrimeSearch : Form
    {
        int startPos = 0;
        int endPos = 0;
        int threads = 1;
        public PrimeSearch()
        {
            InitializeComponent();
        }

        private bool IsPrime(int n)
        {
            //проверяем четные
            if (n % 2 == 0)
            {//из четных простым числом м.б. только 2
                return n == 2;
            }
            //проверяем нечетные
            int d = 3;
            while (d * d <= n)
            {
                if (n % d == 0) { return false; }
                d = d + 2;
            }
            return true;
        }

        private int[] SearchForPrimes(int start, int end, int step = 1)
        {
            List<int> primes = new List<int>();
            int[] emp = { 0 };
            for (int i= start; i <= end;i += step )
            {
                if (IsPrime(i)) primes.Add(i);
            }
            //if (primes != null)
                return primes.ToArray();
            //else
            //    return emp;
            //else
            //    return Task.FromResult<object>(null);
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            //очищаем tb
            tbPrimes.Text = "";
            //если numeric -> parse
            int start = Int32.Parse(tbStart.Text);
            int end = Int32.Parse(tbEnd.Text);
            threads = (int)numUpDThreads.Value;
            int[] allPrimes = new int[0];
            Task<int[]>[] tasks = null;
            //если start<end -> делим на потоки и выполняем
            //для 1..1 - +проверить при 2 потоках
            if (start < end)
            {
                //каждому потоку соответствет свой интервал поиска
                //лучше делить не поровну т.к. 
                //чем больше число, тем дольше проверка,
                //можно брать каждое второе (энное, где n - число потоков)
                // step = threads
                //для этого функцию поиска надо дополнить необяз параметром "шаг"
                //интервал/число потоков => trunc(result)
                //получаем номера нач и конечной позиции для каждого интервала
                

                //если threads > end - start
                //1 поток или не разветвлять? на создание потоков тратится время
                if(threads> end - start + 1)
                {
                    allPrimes = SearchForPrimes(start, end);//1 или threads n t не ветвить
                }
                else
                {
                    tasks = new Task<int[]>[threads];
                    for (int i = 0; i < threads; i++)
                    {
                        int ti = i;
                        tasks[ti] = Task<int[]>.Run(() => SearchForPrimes(start+ti, end, threads));
                    }
                    Task.WaitAll(tasks);
                    //allPrimes = new int[1];
                    foreach (Task<int[]> task in tasks)
                        allPrimes = task.Result.Concat(allPrimes).ToArray();
                    Array.Sort(allPrimes);
                }

                if (allPrimes != null)
                {
                    foreach (int prime in allPrimes)
                        tbPrimes.Text += prime + " ";
                }
            }

            // привести массив primes в SearchForPrimes к приличному виду
            //записать через int[0] вместо list

            //изменить логику:

            //перераспределить интервал между потоками
            //поделить на кол-во потоков 
            //тогда Tasks будут заканчивать выполнение 
            //в порядке следования диапазонов
            //т.к. каждый следующий занимает больше времени (числа больше)

            // ?? должны ли Tasks выполняться асинхронно????

            //выводить часть данных - каждые 10 цифр
            //BackGroudMode - выводит в StatusBar сообщение - Calculating
            //Performing calculations


            //добавить оганичения на ввод в textBox
            //УМЕНЬШИТЬ SCROLL
        }
    }
}
