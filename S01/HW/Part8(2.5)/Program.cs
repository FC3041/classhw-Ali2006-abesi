namespace AAverageOfSquares2;

class Program
{   
    
    public static double average_of_squares1(int n){
        double result = 0;
        for(int i=1;i<n+1;i++){
            result+=i*i;
        }
        return result/n;
    }


    static void Main(string[] args)
    {
        double y=average_of_squares1(4);
        Console.WriteLine(y);
    }
}
