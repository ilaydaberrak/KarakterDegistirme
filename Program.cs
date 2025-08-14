using System;
class Program
{
    static void Main()
    {
        //algoritma
        //1. kullanıcıdan string ifadeler al.
        //2. her ifade için ilk ve son karakterin yerini değiştir.
        //3. değiştirilmiş ifaddeleri ekrana yazdır 

        Console.WriteLine("Kelimeleri aralarına boşluk bırakarak giriniz:");
        string[] kelimeler = (Console.ReadLine() ?? "").Split(" ");

        foreach (string kelime in kelimeler)
        {
            if (kelime.Length > 1)
            {
                char ilk = kelime[0];
                char son = kelime[kelime.Length - 1];
                string ortasi = kelime.Substring(1, kelime.Length - 2);
                Console.Write(son + ortasi + ilk + " ");
            }
            else
            {
                Console.Write(kelime + " ");
            }
        }
    }
}