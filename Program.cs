using System;

namespace Kodlama.io_HW_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Şeyma");
            isimler.Add("Şeyma");
            isimler.Add("Şeyma");
            isimler.Add("Şeyma");
           Console.WriteLine("isimlerin sayısı"+isimler.Count);
        }
    }
}
