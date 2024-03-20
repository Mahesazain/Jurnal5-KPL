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
class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan<double> T = new Penjumlahan<double>();
        T.JumlahTigaAnggka(13.0, 02.0, 22.0);
    }
}