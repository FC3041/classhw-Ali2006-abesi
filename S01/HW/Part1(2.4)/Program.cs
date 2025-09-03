void print_left_triangle(int n){
    for(int i=0;i<n;i++){
        for(int j=0;j<=i;j++){
            Console.Write("*");
        }
    Console.WriteLine();
    }
}

print_left_triangle(3);
