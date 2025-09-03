double f_to_c(double f){
    double c = (f - 32) * 5/9;
    return Math.Round(c,2) ;
}


double x = f_to_c(90);
Console.Write(x);