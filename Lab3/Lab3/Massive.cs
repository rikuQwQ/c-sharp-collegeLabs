using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Massive
    {
        int size;
        int[] mas;
        bool isItLargerThan2 = false;

        public int Size
        {
            get { return size; }
            set
            {
                if (value >= 1)
                {
                    size = value;
                }
                else
                {
                    size = 0;
                }
            }
        }

        public string CreateMas()
        {
            string s = "";
            if(size > 2)
            {
                isItLargerThan2 = true;
            }
            else
            {
                isItLargerThan2 = false;
            }
            if (size == 0) return s;
            else
            {
                Random r = new Random();
                mas = new int[size];

                for(int i = 0; i < size; i++)
                {
                    mas[i] = r.Next(-100, 100);
                    s = s + mas[i].ToString() + " ";
                }
                return s;
            }
        }

        public string SummMas()
        {
            int sum = 0;
            for(int i = 0; i < mas.Length; i++)
            {
                sum = sum + mas[i];
            }
            return sum.ToString();
        }

        public string ReverseMas()
        {
            string s = "";
            Array.Reverse(mas);
            for(int i = 0; i < mas.Length; i++)
            {
                s = s + mas[i].ToString() + " ";
            }
            Array.Reverse(mas);
            return s;
        }

        public string ChangeElem()
        {
            if (isItLargerThan2)
            {
                string s = "";
                int secondMasElem, thirdElemMas = 0;
                secondMasElem = mas[1];
                thirdElemMas = mas[2];
                mas[1] = thirdElemMas;
                mas[2] = secondMasElem;

                for (int i = 0; i < size; i++)
                {
                    s = s + mas[i].ToString() + " ";
                }
                return s;
            }
            else
            {
                return "Недостаточно элементов массива";
            }

        }
    }
}
