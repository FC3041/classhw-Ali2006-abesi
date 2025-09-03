namespace is_divisible;

class Program
{   
    public static bool is_divisible(int x , int y){
    if(x%y==0){
        return true;
    }
    else{
        return false;
    }
    }
    static void Main(string[] args)
    {
        bool x = is_divisible (120,5);
        Console.WriteLine(x);
    }
}
