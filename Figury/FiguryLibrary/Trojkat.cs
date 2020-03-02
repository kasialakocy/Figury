using System;

namespace FiguryLibrary //namespace-identyfikuje obiekty języka C#, przestrzeń nazw
{
    public class Trojkat 
    {
        //definiujemy dane obiektu - pola (fields)
        double a; // this.a
        double b; // this.b
        double c; // this.c


        //konstruktory - jego głównym zadaniem jest stworzyć obiekt



        public Trojkat () // kontruktor domyślny, on nie ma argumentów
        {
            a = b = c = 1.0;

        }

        public Trojkat(double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
