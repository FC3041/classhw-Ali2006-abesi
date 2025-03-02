using System.Security.Cryptography.X509Certificates;

namespace prime;

class Program
{   public static bool is_prime(int n){
        if(n<=1){
            return false;
        }
        if (n==2){
            return true;
        }
        for(int i=2;i<n;i++){
            if(is_divisible(n,i)){
                return false;
            }
        }
        return true;
    }
    static bool is_divisible(int x , int y){
    if(x%y==0){
        return true;
    }
    else{
        return false;
    }
    
}
    static void Main(string[] args)
    {
        for(int j=0;j<100;j++){
            if(is_prime(j)){

            Console.WriteLine(j);
            }
        }
    }
}
