using System;

class Program
{
    static void Main(string[] args)
    {
        Movie movie = new Movie();
        movie._name = "Love Next Door";
        movie._director = "Yoo Je-Won";
        movie._year = 2024;

        movie.AddLeads("Jung Hae-in");
        movie.AddLeads("Jung So-min");
        movie.AddLeads("Kim Ji-eun");
        movie.AddLeads("Yoon Ji-on");

        movie.DisplayMovieInfo();
        movie.ShowActors();
    }
}