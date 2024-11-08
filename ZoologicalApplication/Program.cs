namespace ZoologicalApplication;

class Program
{
    static void Main(string[] args)
    {
        Lion lion1 = new Lion("Aslan Kral", 250, "Yeleli Aslan");
        Elephant elephant1 = new Elephant("Fil", 140, "Yavru Fil");
        Giraffe giraffe1 = new Giraffe("Uzun Zürafa", 56, "Beneki Zürafa");

        lion1.MakeSound();
        elephant1.MakeSound();
        giraffe1.MakeSound();
    }
}
