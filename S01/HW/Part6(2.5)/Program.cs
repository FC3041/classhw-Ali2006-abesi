void root_of_2(double a , double  b , double c) // AX*X + BX + C =0
{   if (a!=0){

    double delta=(b*b)-4*a*c;
    if (delta<0){
        Console.WriteLine("No answer");
    }
    else if(delta==0){
        double x = -1*b/(2*a);
        Console.WriteLine("The answer is "+x);
    }
    else{
        double jazar_delta=Math.Sqrt(delta);
        double x1=(-1*b+jazar_delta)/2*a;
        double x2=(-1*b-jazar_delta)/2*a;
        Console.WriteLine("The answer1 is "+x1);
        Console.WriteLine("The answer2 is "+x2);
    }
            }
    else{
        double x = -1*c/b;
        Console.WriteLine("The answer is "+x);
    }
}

root_of_2(1,2,-3);