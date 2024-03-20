using MOD5_1302220105;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD5_1302220105
{
     class simpleDatabase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public simpleDatabase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData(T input)
        {
            storedData.Add(input);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < this.storedData.Count(); i++)
            {
                Console.WriteLine("Data " + (i + 1) + " Berisi data: " + this.storedData[i] + ", yang disimpan pada waktu UTC: " + this.inputDates[i]+" AM");
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        simpleDatabase<double> T1 = new simpleDatabase<double>();
        T1.AddNewData(1.3);
        T1.AddNewData(0.2);
        T1.AddNewData(2.0);
        T1.PrintAllData();
    }
}

