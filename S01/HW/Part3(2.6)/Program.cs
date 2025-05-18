using System.Reflection.Metadata.Ecma335;

namespace MyAsciiArg_print_cone;

class Program
{   public static void print_cone(int n){
    int x = (n+1)/2;
     for(int z=x-1;z>=0;z--){
            Console.Write(" ");
        }
        Console.WriteLine("^");
    for(int i=1;i<x;i++){
        for(int z=x-i-1;z>=0;z--){
            Console.Write(" ");
        }
        for(int j=0;j<i;j++){
            Console.Write("/");
        }
    Console.Write("|");
        for(int j=0;j<i;j++){
            Console.Write("\\");
        }
    Console.WriteLine();
    }
    
    
}
    static void Main(string[] args)
    {
        print_cone(7);
    }
}
