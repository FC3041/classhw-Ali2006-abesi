void print_head(){
    Console.WriteLine("     ^      ");
    Console.WriteLine("    /|\\    ");
    Console.WriteLine("   //|\\\\   ");
    Console.WriteLine("  ///|\\\\\\  ");
}

void print_line(){
    Console.WriteLine(" +-------+  ");
}

void print_body(){
    Console.WriteLine(" +*******+  ");
    Console.WriteLine(" +*******+  ");
    Console.WriteLine(" +*******+  ");
    Console.WriteLine(" +*******+  ");
}
void print_rocketship(){
    print_head();
    print_line();
    print_body();
    print_line();
    print_body();
    print_line();
    print_head();
}

print_rocketship();
