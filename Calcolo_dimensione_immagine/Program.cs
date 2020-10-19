using System;

namespace Calcolo_dimensione_immagine
{
    class Program
    {
        static void Main(string[] args)
        {
            double bianconero, menocolori, piucolori, truecolor;
            Console.Write("Inserisci il valore dell'altezza dell'immagine: ");
            double am = double.Parse(Console.ReadLine());
            Console.Write("Inserisci il valore della larghezza dell'immagine: ");
            double lm = double.Parse(Console.ReadLine());
            bianconero = am * lm / (1024 * 8);
            menocolori = am * lm / 1024;
            piucolori = am * lm * 2 / 1024;
            truecolor = am * lm * 3 / 1024;
            Console.WriteLine($"La dimensione è: \n In bianco e nero {bianconero}KB \n In 256 colori {menocolori} KB \n In 65000 colori {piucolori} KB \n In true color {truecolor} KB");

        }
    }
}
