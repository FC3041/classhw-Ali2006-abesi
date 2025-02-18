namespace Assertions1;

class Program
{   
    public static double fac(int n){
        double result = 1;
        if (n==0){
            return 1 ;
        }
        else if (n<0){
            Console.WriteLine("باید مثبت باشهn ");
        }
        else{
            for(int i=1;i<n+1;i++){
                result*=i;
            }
        }
        if (result<0){
            Console.WriteLine("باید مثبت باشه result ");
        }
        return result;
        
    }
    static void Main(string[] args)
    {
        double h = fac(6);
        Console.WriteLine(h);
    }
}
