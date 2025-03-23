// See https://aka.ms/new-console-template for more information
using tpmodul6_103022300142;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - M. Tahtafaiz Madani");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}