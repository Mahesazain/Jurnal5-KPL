using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program;
public class Penjumlahan<IN>
{
    public void JumlahTigaAnggka(IN A, IN B, IN C)
    {
        dynamic a1 = A;
        dynamic b1 = B;
        dynamic c1 = C;
        Console.WriteLine(a1 + b1 + c1);
    }
}
public class simpleDatabase<T>
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

class Program
{
    public static void Main(string[] args)
    {

        Penjumlahan<double> T = new Penjumlahan<double>();
        T.JumlahTigaAnggka(13.0, 02.0, 22.0);

        simpleDatabase<double> T1 = new simpleDatabase<double>();
        T1.AddNewData(1.3);
        T1.AddNewData(0.2);
        T1.AddNewData(2.0);
        T1.PrintAllData();
    }
}
