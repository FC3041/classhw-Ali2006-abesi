#include<iostream>
#include<math.h>
using namespace std;
class point{
    public:
        double xx;
        double yy;
        point(double q , double t){
            xx=q;
            yy=t;
        }
};
class circle
{
    public:
        double x;//طول مرکز
        double y;//عرض مرکز
        double r;//شعاع
        circle(double l , double w , double h){
            x=l;
            y=w;
            r=h;
        }

        void print_circle(){
            cout<<"x : "<<x<<" , y : "<<y<<" , r : "<<r<<endl;
        }
        double Mohitt_circle(){
            double Mohitt = 2*3.14*r;
            return Mohitt;
        }
        double Masahatt_circle(){
            double Masahatt = 3.14*r*r;
            return Masahatt;
        }
        double Fasele_Markaz_2_circle(circle b){
            double Fasele_x=x-b.x;
            double Fasele_y=y-b.y;
            return sqrt(Fasele_x*Fasele_x+Fasele_y*Fasele_y);
        }
        double Fasele_point_az_Markaz_circle(point f){
            double Fasele_xx=f.xx-x;
            double Fasele_yy=f.yy-y;
            return sqrt(Fasele_xx*Fasele_xx+Fasele_yy*Fasele_yy);
        }
        void is_point_in_or_out_or_on_circle(point s){
            double Fasele = Fasele_point_az_Markaz_circle(s);
            if (Fasele==r){
                cout<<"point on circle!"<<endl;
            }
            else if(Fasele<r){
                cout<<"point in circle!"<<endl;
            }
            else{
                cout<<"point out circle!"<<endl;
            }
        }
        double Momase_moshtrac_kharegi(circle q){
            double d = Fasele_Markaz_2_circle(q);
            double d_r=r-q.r;
            return sqrt(d*d-d_r*d_r);
        }
        double Momase_moshtrac_dakheli(circle q){
            double d = Fasele_Markaz_2_circle(q);
            double d_r=r+q.r;
            return sqrt(d*d-d_r*d_r);
        }
        void Baresi_vaziat_2_circle(circle b){
            double dd=Fasele_Markaz_2_circle(b);
            if (dd>r+b.r){
                cout<<"out of each other"<<endl;
            }
            else if (dd<r+b.r){
                cout<<"part of each other"<<endl;
            }
            else if (dd==r+b.r){
                cout<<"tangent of each other"<<endl;
            }
            else if (dd==abs(r-b.r)){
                cout<<"tangent_in each other"<<endl;
            }
            else if (dd<abs(r-b.r)){
                cout<<"canon of each other"<<endl;
            }
        }
        
};

// double Mohitt_circle(circle c){
//     double Mohitt = 2*3.14*c.r;
//     return Mohitt;
// }
// double Masahatt_circle(circle c){
//     double Masahatt = 3.14*c.r*c.r;
//     return Masahatt;
// }

// double Fasele_Markaz_2_circle(circle a , circle b){
//     double Fasele_x=a.x-b.x;
//     double Fasele_y=a.y-b.y;
//     return sqrt(Fasele_x*Fasele_x+Fasele_y*Fasele_y);
// }

// double Fasele_point_az_Markaz_circle(point f , circle c){
//     double Fasele_xx=f.xx-c.x;
//     double Fasele_yy=f.yy-c.y;
//     return sqrt(Fasele_xx*Fasele_xx+Fasele_yy*Fasele_yy);
// }
// void is_point_in_or_out_or_on_circle(point s , circle o){
//     double Fasele = Fasele_point_az_Markaz_circle(s,o);
//     if (Fasele==o.r){
//         cout<<"point on circle!"<<endl;
//     }
//     else if(Fasele<o.r){
//         cout<<"point in circle!"<<endl;
//     }
//     else{
//         cout<<"point out circle!"<<endl;
//     }
// }
// double Momase_moshtrac_kharegi(circle c , circle q){
//     double d = Fasele_Markaz_2_circle(c,q);
//     double d_r=c.r-q.r;
//     return sqrt(d*d-d_r*d_r);
// }
// double Momase_moshtrac_dakheli(circle c , circle q){
//     double d = Fasele_Markaz_2_circle(c,q);
//     double d_r=c.r+q.r;
//     return sqrt(d*d-d_r*d_r);
// }
// void Baresi_vaziat_2_circle(circle a , circle b){
//     double dd=Fasele_Markaz_2_circle(a,b);
//     if (dd>a.r+b.r){
//         cout<<"out of each other"<<endl;
//     }
//     if (dd<a.r+b.r){
//         cout<<" part of each other"<<endl;
//     }
//     if (dd==a.r+b.r){
//         cout<<"tangent of each other"<<endl;
//     }
// }
int main(){

    circle c1(0,0,5);
    circle c2(3,4,5);
    point a(9,12);
    cout<<"Mohitt_circle : "<<c1.Mohitt_circle()<<endl;
    cout<<"Masahat_circle : "<<c1.Masahatt_circle()<<endl;
    cout<<"Fasele_Markaz_2_circle : "<<c1.Fasele_Markaz_2_circle(c2)<<endl;
    cout<<"Fasele_point_az_Markaz_circle : "<<c2.Fasele_point_az_Markaz_circle(a)<<endl;
    c1.is_point_in_or_out_or_on_circle(a);
    cout<<"Momase_moshtrac_kharegi_2_circle : "<<c1.Momase_moshtrac_kharegi(c2)<<endl;
    cout<<"Momase_moshtrac_dakheli_2_circle : "<<c1.Momase_moshtrac_dakheli(c2)<<endl;
    c1.Baresi_vaziat_2_circle(c2);
    
    return 0;
}
