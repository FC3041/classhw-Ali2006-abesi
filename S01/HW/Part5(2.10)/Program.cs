namespace math6;

class Program
{   public static double com_root_2(double x , double pre){
    double low=0.0;
    double up=x;
    int count = 0;
    while((up-low)>pre){
        double mid = (up+low)/2;
        if(mid*mid<x){
            low = mid ;
        }
        else{
            up=mid;
        }
        count++;
    }
    Console.WriteLine("the iteration : "+count);
    return (up+low)/2;
}
    static void Main(string[] args)
    {
        double z=com_root_2(2,0.000001);
        Console.WriteLine(z);
    }
}
