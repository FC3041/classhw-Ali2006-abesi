namespace math9;

class Program
{   
    public static void number(){
        Console.WriteLine("enter number: ");
        float n = float.Parse(Console.ReadLine());
        float sum = n;
        float max = n;
        float min = n;
        int count = 1;
        while (true){
            n = float.Parse(Console.ReadLine());
            if(n==-1){
                break;
            }
            sum+=n;
            if(n>max){
                max=n;
            }
            if(n<min){
                min=n;
            }
            count++;
        }
        sum = sum/count;
        Console.WriteLine("The number of entries : "+count);
        Console.WriteLine("The average : "+sum);
        Console.WriteLine("The minimum : "+min);
        Console.WriteLine("The maximum : "+max);
    }
    static void Main(string[] args)
    {
        number();
    }
}
