namespace StringConcatMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TCno = "12345678901";
            string ad = "Ali";
            string soyad = "Veli";
            double maas = 2500;
            int cocukSayisi = 2;

            string birlestirilenVeri = string.Concat(TCno + " " + ad + " " + soyad + " " + maas + " " + cocukSayisi);

            string birlestirilenVeri2 = string.Concat($"TC No: {TCno}, Adı: {ad}, Soyadı: {soyad}, Maaş: {maas}, Çocuk Sayısı: {cocukSayisi}");


            Console.WriteLine(birlestirilenVeri);

            Console.WriteLine();

            Console.WriteLine(birlestirilenVeri2);

            Console.ReadKey();
        }
    }
}
