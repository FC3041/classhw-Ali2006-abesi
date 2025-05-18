double c_to_f(double c){
    double f = 1.8*c+32;
    return Math.Round(f,2);
}

double y=c_to_f(90);
Console.Write(y);