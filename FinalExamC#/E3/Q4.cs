public class LinqProblems
{
    LinqProblems() { }

    public static List<int> FilterAndDouble(List<int> nums)
    {
        var result = nums.Where(i => i % 2 == 0 && i > 5).ToList();
        var res = result.Select(i => i * 2).ToList();

        return res;
    }


    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> mylist)
    {   Dictionary<string, int> mydic = new Dictionary<string, int>();

        var result = mylist.GroupBy(i=>i.Category).ToList();
        result.Select(i =>
        {
            string name = i.Key;
            int c = i.Sum(e => e.Amount);
            return (n: name, count: c);
        }).ToList()
        .ForEach(i => mydic[i.n] = i.count);

        
        

        return mydic;
    }
}