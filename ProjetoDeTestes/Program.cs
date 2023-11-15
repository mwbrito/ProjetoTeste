using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Reflection.Metadata.Ecma335;

internal class Program
{

    private static void Main(string[] args)
    {
        var resultado = BenchmarkRunner.Run<Teste>();
        //Teste teste = new Teste();
    }
}

public class demo
{
    public string ss;
}

[RankColumn]
[MemoryDiagnoser]
public class Teste
{
    List<string> list = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "w", "z", "y" };

    List<string> combinacoes2 = new List<string>();
    List<string> combinacoes = new List<string>();

    HashSet<string> combinacoes3 = new HashSet<string>();
    HashSet<string> combinacoes4 = new HashSet<string>();

    public Teste()
    {
        Random randNum = new Random();



        while (combinacoes3.Count() < 40000)
        {

            string combinacao = $"{list[randNum.Next(25)]}{list[randNum.Next(25)]}{list[randNum.Next(25)]}{list[randNum.Next(25)]}";

            combinacoes3.Add(combinacao);

        }

        combinacoes.AddRange(combinacoes3);
        combinacoes2.AddRange(combinacoes3.OrderBy(x => x));
        combinacoes4.UnionWith(combinacoes2);

    }


    [Benchmark]
    public void TesteComListaContains()
    {
        foreach (string s in combinacoes)
        {
            combinacoes2.Contains(s);
        }
    }
    [Benchmark]
    public void TesteComListaContainsParallel()
    {
        Parallel.ForEach(combinacoes, item =>
        {
            combinacoes2.Contains(item);
        }
        );
    }
    [Benchmark]
    public void TesteComListaAny()
    {
        combinacoes.Any(x => combinacoes2.Contains(x));
    }
    [Benchmark]
    public void TesteComHashSet()
    {
        foreach (string s in combinacoes3)
        {
            combinacoes4.Contains(s);
        }
    }

    //[Benchmark]
    //public void TesteComListaContains()
    //{
    //    foreach (string s in combinacoes)
    //    {
    //        combinacoes2.Contains(s);
    //    }
    //}

    [Benchmark]
    public void TesteComHashSetParallel()
    {
        Parallel.ForEach(combinacoes3, item =>
            {
                combinacoes4.Contains(item);
            }
        );
    }
}














//[Benchmark]
//public void escreveArquivo()
//{
//    //

//    foreach (string s in list)
//    {
//        foreach (string x in list)
//        {
//            foreach (string y in list)
//            {
//                foreach (string z in list)
//                {
//                    //string d = $"{s}{x}{y}{z}";
//                    demo dd = new demo();
//                    dd.ss = $"{s}{x}{y}{z}";

//                    combinacoes.Add(dd.ss);
//                    if (combinacoes.Count() >= 10000) break;
//                }
//                if (combinacoes.Count() >= 10000) break;
//            }
//            if (combinacoes.Count() >= 10000) break;
//        }
//        if (combinacoes.Count() >= 10000) break;
//    }

//    //File.WriteAllLines("c:\\dev\\combinacoes.txt", combinacoes);
//}

//[Benchmark]
//public void escreveArquivo2()
//{
//    //List<string> combinacoes = new List<string>();

//    foreach (string s in list)
//    {
//        foreach (string x in list)
//        {
//            foreach (string y in list)
//            {
//                foreach (string z in list)
//                {
//                    combinacoes2.Add($"{s}{x}{y}{z}");
//                    if (combinacoes2.Count() >= 10000) break;
//                }
//                if (combinacoes2.Count() >= 10000) break;
//            }
//            if (combinacoes2.Count() >= 10000) break;
//        }
//        if (combinacoes2.Count() >= 10000) break;
//    }

//    //File.WriteAllLines("c:\\dev\\combinacoes2.txt", combinacoes);
//}
//}