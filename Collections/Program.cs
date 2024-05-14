using System;
using System.Collections.Generic;

namespace Collections
{

    class Program
    {

        static void Main(string[] args) 
        {
            //string[] isimler = new string[] {"Çağrı", "Özgür", "Tufan", "Bumerang", "Onur" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //isimler[5] = "Ahmet";
            //Console.WriteLine(isimler[5]);

            //ARRAY OLARAK EKLEME YAPTIĞIMIZDA REFERANS TİPTE OLDUĞUNDAN YENİ ATADIĞIM DİZİNİN İLK ELEMANLARI BOŞ OLUYOR. LİST TE İSE KAYDEDIYOR

            List  <string> isimler2 = new List<string> {"Çağrı", "Özgür", "Tufan", "Bumerang", "Onur" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            isimler2.Add("Ahmet");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);
            



        }
    }
}