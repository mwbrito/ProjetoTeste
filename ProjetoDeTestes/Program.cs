using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

internal class Program
{

    private static void Main(string[] args)
    {
        var resultado = BenchmarkRunner.Run<Teste>();
        //Teste teste = new Teste();

        //Stopwatch stopwatch = new Stopwatch();

        //stopwatch.Reset();
        //stopwatch.Start();
        //teste.TesteComListaContains();
        //stopwatch.Stop();
        //Console.WriteLine($"TesteComListaContains {stopwatch.ElapsedMilliseconds.ToString()}");

        //stopwatch.Reset();
        //stopwatch.Start();
        //teste.TesteComListaContainsParallel();
        //stopwatch.Stop();
        //Console.WriteLine($"TesteComListaContainsParallel {stopwatch.ElapsedMilliseconds.ToString()}");

        //stopwatch.Reset();
        //stopwatch.Start();
        //teste.TesteComHashSet();
        //stopwatch.Stop();
        //Console.WriteLine($"TesteComHashSet {stopwatch.ElapsedMilliseconds.ToString()}");

        //stopwatch.Reset();
        //stopwatch.Start();
        //teste.TesteComHashSetParallel();
        //stopwatch.Stop();
        //Console.WriteLine($"TesteComHashSetParallel {stopwatch.ElapsedMilliseconds.ToString()}");

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
    public void TesteComHashSet()
    {
        foreach (string s in combinacoes3)
        {
            combinacoes4.Contains(s);
        }
    }
    
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