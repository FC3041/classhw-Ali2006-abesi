void print_head(){
    Console.WriteLine("     ^      ");
    Console.WriteLine("    /|\\    ");
    Console.WriteLine("   //|\\\\   ");
    Console.WriteLine("  ///|\\\\\\  ");
}

void print_line(){
    Console.WriteLine(" +-------+  ");
}

void print_body(int m){
    for (int j=0;j<m;j++){
        Console.WriteLine(" +*******+  ");
    }
    
}

void print_line_body(int n){
    for(int i=0;i<n;i++){
        print_line();
        print_body(6);
    }
}

void print_rocketship(){
    print_head();
    print_line_body(4);
    print_head();
}

print_rocketship();