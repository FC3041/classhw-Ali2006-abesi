double average_of_squares0(int n){
    double result = 0;
    for(int i=0;i<n;i++){
        result+=i*i;
    }
    return result/n;
}

double x=average_of_squares0(5);
Console.WriteLine(x);

