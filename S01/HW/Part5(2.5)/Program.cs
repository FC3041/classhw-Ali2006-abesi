using System.Runtime.Serialization.Formatters;

int pow(int x , int y){
    int result = 1;
    while(y>0){
        result*=x;
        y--;
    }
    return result;
}

int h = pow(2,4);
Console.Write(h);