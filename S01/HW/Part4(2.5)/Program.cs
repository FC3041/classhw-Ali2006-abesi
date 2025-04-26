namespace Factorial2;

class Program
{   
    static double fac(int n){
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
    public static void table_of_fac_num(int m){
        for(int i=1;i<m+1;i++){
            double z = fac(i);
            Console.WriteLine(z + " ");
        }
    }

    static void Main(string[] args)
    {
        table_of_fac_num(20);
    }
}
