namespace Triangle2;

class Program
{   public static void print_left_triangle_with_prameter(int n , char x){
    for(int i=0;i<n;i++){
        for(int j=0;j<=i;j++){
            Console.Write(x);
        }
    Console.WriteLine();
    }
}
    static void Main(string[] args)
    {
        print_left_triangle_with_prameter(4,'A');
    }
}
