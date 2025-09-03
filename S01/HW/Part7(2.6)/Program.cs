namespace Pythagorean;

class Program
{   public static bool is_Pythagorean_triple(int a , int b , int c){
    if (a*a+b*b==c*c){
        return true;
    }
    else {
        return false;
    }
}
    static void Main(string[] args)
    {
        for(int i=1;i<100;i++){
            for(int j=i;j<100;j++){
                for(int k=1;k<100;k++){
                    if(is_Pythagorean_triple(i,j,k)){
                        Console.WriteLine(i+" "+j+" "+k);
                    }
                }
            }
        }
    }
}
