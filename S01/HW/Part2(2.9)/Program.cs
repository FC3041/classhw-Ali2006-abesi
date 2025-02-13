namespace Assertions2;

class Program
{   
    public static bool is_prime(int n){
        if(n<=1){
            return false;
        }
        else if (n==2){
            return true;
        }
        else{

        for(int i=2;i<n;i++){
            if(n%i==0){
                return false;
            }
        }
        return true;
        }
}
    static void Main(string[] args)
    {
        bool flag = is_prime(22);
        Console.WriteLine(flag);
    }
}
