using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork1
{
    [System.Serializable]
    public abstract class Housing : IFIO, IComparable
    {
        string fio;
        public string name { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public Housing(string fio, string name, string street, int number)
        {
            this.fio = fio;
            this.name = name;
            this.street = street;
            this.number = number;
        }
        public string MyFio { get { return fio; } }
        public int CompareTo(object obj)
        {
            Housing h = (Housing)obj;

            if (this.fio == h.fio) return 0;
            else if (this.fio.CompareTo(h.fio) > 0) return 1;
            else return -1;
        }
        public abstract string Adress();
    }
    [System.Serializable]
    class House : Housing
    {
        int floors { get; set; }
        public House(string fi, string na, string s, int nu, int fl) : base(fi, na, s, nu)
        {
            floors = fl;
        }
        public override string Adress() 
        { 
            return $"Жильё: {this.name}       Улица:{this.street}     Номер дома:{this.number}    Этажность: {this.floors}"; 
        }
    }
    [System.Serializable]
    class Flat : Housing
    {
        int numberFlat { get; set; }
        int numberRooms { get; set; }
        public Flat(string fi, string na, string s, int nu, int nf, int nr) : base(fi, na, s, nu)
        {
            numberFlat = nf;
            numberRooms = nr;
        }
        public override string Adress()
        {
            return $"Жильё: {this.name}       Улица:{this.street}     Номер дома:{this.number}    Номер квартиры: {this.numberFlat}     Количество комнат: {this.numberRooms}";
        }
    }
}
