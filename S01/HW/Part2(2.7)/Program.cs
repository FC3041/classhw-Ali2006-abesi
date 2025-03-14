namespace fix_factorial;

class Program
{   
    public static double fac(int n){
        if (n==0){
            return 1 ;
        }
        else if (n<0){
            Console.WriteLine("None");
        }
        else{
            double result = 1;
            for(int i=1;i<n+1;i++){
                result*=i;
            }
            return result;
        }
        return 0 ;
    }
    static void Main(string[] args)
    {
        double w = fac(5);
        Console.WriteLine(w);
    }
}
