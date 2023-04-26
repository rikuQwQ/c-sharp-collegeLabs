using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    class Data
    {
        internal const int n = 5;
        internal static int[,] mas = new int[n,n];
        internal static int[,] masChange = new int[n, n];
        public int positive = 0;

        internal void CreateArray()
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = random.Next(-100, 100);
                }
            }
            return;
        }


        internal void Print(DataGridView dgv, int[,] mass)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dgv[i, j].Value = mass[i, j];
                }
            }
        }

        internal int[,] DoubleArray()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    masChange[i, j] = mas[i, j] * 2;
                }
            }
            return masChange;
        }

        internal int[,] TripleSecondColumn()
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j == 1)
                    {
                        masChange[j, i] = mas[j, i] * 3;
                    }
                    else
                    {
                    masChange[j, i] = mas[j, i];
                    }
                }
            }
            return masChange;
        }

        internal int Positive()
        {
            positive = 0;
            for (int i = 0; i < n; i++)
            {
                if (mas[0, i] > 0)
                {
                    positive++;
                } 
            }
            return positive;
        }
        internal int Negative()
        {
            int negative = 0;
            for (int i = 0; i < n; i++)
            {
                if (mas[0, i] < 0)
                {
                    negative++;
                }
            }
            return negative;
        }

        internal int[,] Above()
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j > i)
                    {
                        masChange[j, i] = 0;
                    }
                    else
                    {
                    masChange[j, i] = mas[j, i];
                    }
                }
            }
            return masChange;
        }
    }

}
