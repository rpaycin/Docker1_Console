using System;

namespace WorkAtDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NOT : 
            1. uygulamanın yazılmasıı bittikten sonra publish edilir
            2. docker ile build alınarak image alınır => 	docker build -t imageName .
            3. alınan image docker da run edilir      => 	docker run imageName
            4. eğer uygulama değişirse 1 ile 3 arası tekrar yapılmalı
            */
            Console.WriteLine("Hello Ayaz 34");

            Console.Read();
        }
    }
}

