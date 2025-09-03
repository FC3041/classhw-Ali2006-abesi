namespace Triangle3;

class Program
{   
    public static void print_right_triangle(int m){
    for(int i=0;i<m;i++){
        for(int z=m-i;z>=0;z--){
            Console.Write(" ");
        }
        for(int j=0;j<=i;j++){
            Console.Write("*");
        }
    Console.WriteLine();
    }
}

    public static void print_right_triangle_with_prameter(int m , char y){
        for(int i=0;i<m;i++){
            for(int z=m-i;z>=0;z--){
                Console.Write(" ");
            }
            for(int j=0;j<=i;j++){
                Console.Write(y);
            }
        Console.WriteLine();
        }
}

    static void Main(string[] args)
    {
        print_right_triangle(3);
        print_right_triangle_with_prameter(4,'E');
    }
}
