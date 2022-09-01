namespace metotlar{

    class program{
        static void Main(string[] args)
        {
          //erisim_belirteci geri_donustipi metot_adi(parametre_Listesi/    arguman)

            //{
             //   komutlar;
             //return;
            //}
            int a=2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc= Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek= new Metotlar();
            ornek.Ekrana_yazdir(Convert.ToString (sonuc));
            int sonuc2= ornek.ArttirVeTopla(ref a, ref b);
            ornek.Ekrana_yazdir(Convert.ToString (sonuc2));
            Console.WriteLine(a+b);
        }
        static int Topla(int deger1,int deger2)
        {
            return(deger1+deger2);
        }
    }
    class Metotlar
    {
        public void Ekrana_yazdir(string veri)
        {
           Console.WriteLine(veri); 
        }
        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1=deger1+1;
            deger2=deger2+1;
            return deger1+deger2;
        }
    }

}