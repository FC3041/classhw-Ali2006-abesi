using System.Collections.Concurrent;
using Microsoft.VisualBasic;

namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {   int rank = 1;
        int ranking = 1;
        var datas = File.ReadAllLines("data.csv")
        .Skip(1)
        .Select(l =>
        {
            var data = Data.Parse(l);
            return (country: data.Country, lettype: data.LEType, dg: data.DataGender, year: data.Year, data.Value);
        });
        //Query 1
        var Query1 = datas.Where(t => t.country.ToLower() == "Iran (Islamic Republic of)".ToLower() && t.lettype == LifeExpectancyType.AtBirth && t.dg == DataGender.Both)
                .OrderBy(t => t.Value)
                .ToList();




        //Query 2
        if (Query1.Any())
        {
            var max_value = Query1.Max(t => t.Value);
            var min_value = Query1.Min(t => t.Value);
            var diff = max_value - min_value;
            System.Console.WriteLine(Math.Round(diff,2));
        }
        


        Console.WriteLine();

        //Query 3
        var Query3 = datas.Where(t => t.lettype == LifeExpectancyType.AtBirth && t.dg == DataGender.Both)
        .GroupBy(t => t.country)
        .Select(g =>
        {
            var maxvalue = g.Max(t => t.Value);
            var minvalue = g.Min(t => t.Value);
            var diffmaxmin = maxvalue - minvalue;
            var yearmin = g.OrderBy(t => t.Value).First().year;
            return (country: g.Key, year: yearmin, min_value: minvalue, diff: diffmaxmin);
        })
        .OrderByDescending(t => t.diff)
        .ToList();


        foreach (var item in Query3)
        {
            System.Console.WriteLine($"{ranking++} ) {item}");
        }

        Console.WriteLine();

        //Query 4
        var male = datas.Where(t => t.lettype == LifeExpectancyType.AtBirth && t.dg==DataGender.Male);
        var female = datas.Where(t => t.lettype == LifeExpectancyType.AtBirth && t.dg==DataGender.Female);

        male.Join(female, (k1) => (k1.country, k1.year), (k2) => (k2.country, k2.year), (k1, k2) => (country: k1.country, year: k1.year, malevalue: k1.Value, femalevalue: k2.Value, diff: k1.Value - k2.Value))

        .GroupBy(t => t.country)
        .Select(g =>
        {
            var maxdiff = g.Max(t => t.diff);
            return (g.Key, maxdiff);
        })
        .OrderByDescending(t=>t.maxdiff)
        .ToList()
        .ForEach(o =>
        {
            
            System.Console.WriteLine($"{rank++} ) {o}");
        });

        Console.WriteLine();

    }
}
