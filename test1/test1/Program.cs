using System;
//funkcija koja prima argument i promijeni ga
namespace test1 {
    class Program {

        static string funkcija(string brojcek) {
            char[] charArr = brojcek.ToCharArray();
            int komplementPrvi = 0;

            for(int i = 0; i<brojcek.Length; i++) 
            {
                if (charArr[i] == '0')
                    charArr[i] = '1';
                else
                    charArr[i] = '0';
            }

            string komplement = new string(charArr);

            int binarno = Int32.Parse(charArr);
            int dekadsko = Convert.ToInt32(komplement, 2);

            dekadsko++;

            string dvojniKomplement = Convert.ToString(dekadsko, 2);
            return dvojniKomplement;
        }

        static void Main(string[] args) {
            string broj;
            broj = Console.ReadLine();
            Console.WriteLine(funkcija(broj));
                
        }
    }
}
