#include<iostream>
#include<math.h>
using namespace std;

class point{
    public: //access to  the objects of class out of the this class
        double x;
        double y;
        point(double t , double r){ //constructor  according to its inputs checking
            x=t;
            y=r; 
        }
        point(double v){
            x=v;
            y=v;
        }
        point(){

        }
        // point(point* q){
        //     x=q->x;
        //     y=q->y;
        // }
        point(point& q){ //refrence     you define const to do not change the real value which is inputed
            x=q.x;
            y=q.y;
        }
        void print_point(){
            cout<<"x: "<<x<<" ,y:"<<y<<endl;
        }
        double com_distance(point q){
            double  disx;
            disx = x - q.x;
            double disy;
            disy=y-q.y;
            return sqrt(disx*disx+disy*disy);}
            ~point(){// distructor will free each object when the program or function or method will end
                    cout<<"x:"<<x<<",y:"<<y<<endl;
            }

};

void print_point(point p){
    cout<<"x: "<<p.x<<" ,y:"<<p.y<<endl;
}

double com_distance(point p , point q){
    double  disx;
    disx = p.x - q.x;
    double disy;
    disy=p.y-q.y;
    return sqrt(disx*disx+disy*disy);
}
int main(){   //main has to be int 
    // std::cin>>a;
    // std::cout<<"a: "<<a<<std::endl;

    // int a;
    // cin>>a;
    // cout<<"a: "<<a<<endl;
    // point p1;
    // p1.x= 4;
    // p1.y= 5;
    point p2;
    p2.x=-4;
    p2.y=-5;
    // print_point(p1);
    // p1.print_point();
    // cout<< p1.x<<endl;
    // cout<< p1.y<<endl;
    // cout<< p2.x<<endl;
    // cout<< p2.x<<endl;
    // double r = com_distance(p1,p2);
    // double rr=p1.com_distance(p2);
    point p1(4,5);
    point p0(9);
    point p3(p2);
    return 0;
}


// define circle 
// p
// s
// d o
// d p o
// p in or out