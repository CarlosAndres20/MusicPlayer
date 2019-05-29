using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlay
{
    class MusicPlayer
    {
        public string Cancion { get; set; }
        public int Codigo { get; set; }
        public string Reproducir { get; set; }
        public List<MusicPlayer> musica = new List<MusicPlayer>();
        public List<MusicPlayer> AgregarMusica()
        {
            bool num = false;

            //if (num=="0")
            //{
            //    Console.WriteLine("Funciono");
            //}

            Console.WriteLine("Escriba y para ingresar cancion");
            var res = Console.ReadLine();
            int count = 0;
            while (res == "y")
            {
                num = true;
                Console.WriteLine("Escriba el nombre de la canción");
                var nom = Console.ReadLine();
                for (int i = 1; i < 10; i++)
                {
                    if (num)

                    {
                        //count = i++;
                        var miProyecto = new MusicPlayer()
                        {
                            Cancion = nom,
                            Codigo=i
                        };
                        musica.Add(miProyecto);
                    }
                }
                Console.WriteLine("Escriba y para ingresar no para salir");
                res = Console.ReadLine();
            }
            res = Console.ReadLine();
            //Console.WriteLine("Reproduciendo");

            foreach (var item in musica)
            {

                Console.WriteLine($"Cancion:  {item.Cancion}\n Codigo: {item.Codigo}");
            }
           

            //while (res != "x")
            //{
            //    foreach (var item in musica)
            //    {
            //        Reproducir = item.Cancion;

            //    }
            //    Console.WriteLine($"Reproduciendo{Reproducir} pulse p para pausar");
            //    var res2 = Console.ReadLine();
            //    if (res2 == "p")
            //    {
            //        Console.WriteLine($"{Reproducir}  pausada pulse s para reproducir");
            //        res = Console.ReadLine();
            //    }


            //}
            return musica;
        }
    }
}
