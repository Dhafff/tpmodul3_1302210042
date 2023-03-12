using System;

namespace tpmodul3_1302210042
{
    public class KodePos
    {
        public string getKodePos(string kelurahan)
        {
            switch (kelurahan)
            {
                case "Batununggal":
                    return "40266";
                case "Kujangsari":
                    return "40287";
                case "Mengger":
                    return "40267";
                case "Wates":
                    return "40256";
                case "Cijaura":
                    return "40287";
                case "Jatisari":
                    return "40286";
                case "Margasari":
                    return "40286";
                case "Sekejati":
                    return "40286";
                case "Kebonwaru":
                    return "40272";
                case "Maleer":
                    return "40274";
                case "Samoja":
                    return "40273";
                default:
                    return "Kode pos tidak ditemukan";
            }
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            KodePos kodepos = new KodePos();
            string kelurahan = "Batununggal";
            string kode = kodepos.getKodePos(kelurahan);
            Console.WriteLine($"Kode pos kelurahan {kelurahan} adalah {kode}");
        }
    }
}
