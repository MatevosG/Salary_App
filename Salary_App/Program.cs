using System;
using System.Collections;

namespace Salary_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();

            foreach (int item in salary)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Salary : IEnumerable
    {
        protected int[] salary  = new int[] { 200000, 60000, 500000, 400000 };
        public IEnumerator GetEnumerator()
        {
            return new SalaryIEnumerator(salary);
        }
    }
    public class SalaryIEnumerator : IEnumerator
    {
        private int[] salary;
        private int count  = 0;
        public SalaryIEnumerator(int [] salary)
        {
            this.salary = salary;
        }
        public object Current => salary[count++];

        public bool MoveNext()
        {
            return count < salary.Length;
        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
