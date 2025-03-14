namespace MoreAsciiiArt;

class Program
{   
    public static void print_left_triangle(int n){
        for(int i=0;i<n;i++){
            if(i%2==0){
            for(int j=0;j<=i;j++){
                Console.Write("%");
            }
            }
            else{
                for(int j=0;j<=i;j++){
                Console.Write("*");
            }
            }
        Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        print_left_triangle(4);
        
    }
}
