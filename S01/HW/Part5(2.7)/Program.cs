namespace fibonacci;

class Program
{   
    public static int fibo(int n){
        if ((n==1)||(n==2)){
            return 1;
        }
        return fibo(n-1)+fibo(n-2);
    }
    static void Main(string[] args)
    {
        for(int k=1;k<=20;k++){
            Console.WriteLine(fibo(k));
        }
    }
}
