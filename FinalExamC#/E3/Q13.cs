public class DataService
{
    public DataService()
    {

    }


    public async Task<string> FetchDataAsync(string n)
    {
        await Task.Delay(2000);
        return $"Data for {n}";
    }
}