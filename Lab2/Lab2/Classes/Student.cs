using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab2.Classes
{
    [Serializable]
    public class Student :IComparable
    {
        public int id = 0; 
        public string fullName;
        public uint birthYear;

        public int CompareTo(object obj)
        {
            Student b = (Student)obj;

            if (this.fullName == b.fullName) return 0;
            else if (this.fullName.CompareTo(b.fullName) > 0) return 1;
            else return -1; 
        }
    }
    [Serializable]
    public class Student2 : Group 
    {
        public Student2(string g) : base(g) { }

        public ArrayList studentList = new ArrayList();

        public void AddStudent(int iterator, string fullName, uint year)
        {
            studentList.Add(new Student { id = iterator++, fullName = fullName, birthYear = year});
        }
        public void DeleteStudent(int id)
        {
            int it = 0;
            foreach (Student student in studentList)
            {
                if (student.id == id)
                {
                    studentList.RemoveAt(it);
                    break;
                }
                it++;
            }
        }

        public bool Find(string name)
        {
            foreach(Student b in studentList)
            {
                if(b.fullName == name)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
