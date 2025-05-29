public class Movie
{
    public string _name;
    public string _director;
    public int _year;
    public List<string> _mainLeads = new List<string>();

    public void AddLeads(string actor)
    {
        _mainLeads.Add(actor);
    }

    public void ShowActors()
    {
        foreach (var lead in _mainLeads)
        {
            Console.WriteLine($"Main Lead: {lead}");
        }
    }
    public void DisplayMovieInfo()
    {
        Console.WriteLine($"Movie Name: {_name} directed by {_director} in the year {_year}");
    }
}