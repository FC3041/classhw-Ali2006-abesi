void fac(int n){
    if (n==0){
        Console.WriteLine(1);
    }
    else if (n<0){
        Console.WriteLine("None");
    }
    else{
        double result = 1;
        for(int i=1;i<n+1;i++){
            result*=i;
        }
        Console.WriteLine(result);
    }
}

fac(5);

