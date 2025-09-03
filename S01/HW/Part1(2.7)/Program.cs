namespace absolute;

class Program
{
    public static int absolute_num(int n){
        if (n<0){
            return -1*n;
        }
        return n;
    }
    static void Main(string[] args)
    {
       int[] numbers={-100, -1, 0, 1 , 1000};
       int len = numbers.Length;
       int i=0;
       while(i<len){
        int x = absolute_num(numbers[i]);
        i++;
        Console.WriteLine(x);
       }
    }
}
