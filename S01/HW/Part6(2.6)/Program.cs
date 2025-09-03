namespace ComputeChange;

class Program
{   
    public static void compute_change(int n){
        Console.WriteLine("The change from a dollar for "+ n +" cents is");
        int quarters = n/25;
        n=n%25;
        int dime = n/10;
        n=n%10;
        int nickel=n/5;
        n=n%5;
        int pennies=n;
        Console.WriteLine(quarters+" quarters");
        Console.WriteLine(dime + " dime");
        Console.WriteLine(nickel + " nickel");
        Console.WriteLine(pennies+ " pennies");
    }
    static void Main(string[] args)
    {
        compute_change(8);
    }
}
