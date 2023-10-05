// See https://aka.ms/new-console-template for more information
using ConsoleApp1;



List<Band> bands = new List<Band>()
{
    new Band("Band 1", 2000),
    new Band("Band 2", 2001),
    new Band("Band 3", 2002),
    new Band("Band 4", 2003),
};

List<Concert> concerts = new List<Concert>()
{
    new Concert("Concert 1", "1-1-2023", 20, 22, new List<Band>() {bands[1], bands[2] }),
    new Concert("Concert 2", "1-2-2023", 20, 22, new List<Band>() {bands[0], bands[3] }),
    new Concert("Concert 3", "1-3-2023", 20, 22, new List<Band>() {bands[2], bands[0] }),
};

foreach(Concert concert in concerts)
{
    Console.WriteLine(concert.getInfo());
    int counter = 0;
    foreach (Band band in concert.bands)
    {
        Console.WriteLine(counter + ". " + band.getInfo());
        counter++;
    }
    Console.WriteLine();
}