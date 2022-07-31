using System;
namespace switch_case
{
    class Program
    {
        static void Main (string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression= kontrol edilmek istenen koşul
            switch (month)
            {
                case 1:
                    Console.WriteLine ("Ocak ayındasınız.");
                    break;
                
                case 2:
                    Console.WriteLine ("Şubat ayındasınız.");
                    break;

                case 7:
                    Console.WriteLine ("Temmuz ayındasınız.");
                    break;
                default:

                    Console.WriteLine ("Yanlış veri girdiniz.");
                break;
            }


            
            switch (month)
            {

                case 12:
                case 1:
                case 2:
                    Console.WriteLine ("kış mevsimindesiniz.");
                    break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine ("İlkbahar mevsimindesiniz.");
                    break;

                case 6 :
                case 7:
                case 8:
                    Console.WriteLine ("Yaz mevsimindesiniz.");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine ("Sonbahar mevsimindesiniz.");
                    break;
                default:
                break;
            }


            

        }
        
    }
}

