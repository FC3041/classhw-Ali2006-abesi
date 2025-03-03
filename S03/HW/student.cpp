#include<iostream>
#include<stdlib.h>
#include<string.h>
using namespace std;
class student {
    public:
        int std_num;
        char first_name[20];
        char last_name[20];
        int darse_pass_shodeh;
        int tedad_vahed_har_dars[40];
        double nomreh_har_dars[40];
        char* name_dars[40];

        int copy_name( const char* x , char* y){
            while(*x){
                *y=*x;
                x++;
                y++;
            }
            *y='\0';
            return 0;
        }
        student(int num , const char* fname , const char* lname){
            std_num=num;
            copy_name(fname,first_name);
            copy_name(lname,last_name);
        }

        double hesab_kardan_moadel(){
            double jame_nomreh = 0;
            int jame_vaheda = 0;
            for(int n=0;n<darse_pass_shodeh;n++){
                jame_nomreh+=nomreh_har_dars[n]*tedad_vahed_har_dars[n];
                jame_vaheda+=tedad_vahed_har_dars[n];
            }
        return jame_nomreh/jame_vaheda;
        }
        void sabt_dars_nomreh_vahed(const char* name,int vahed ,double nomreh){
            tedad_vahed_har_dars[darse_pass_shodeh]=vahed;
            nomreh_har_dars[darse_pass_shodeh]=nomreh;
            char* name_dars_pass_shodeh = (char*)malloc(strlen(name)+1);
            copy_name(name,name_dars_pass_shodeh);
            name_dars[darse_pass_shodeh]=name_dars_pass_shodeh;
            darse_pass_shodeh++;
        }

        void namayesh_list_doros_pass_shodeh(){
            cout<<"R"<<"        "<<"Course_name"<<"      "<<"Credit"<<"      "<<"Grade"<<endl;
            for(int i=0;i<darse_pass_shodeh;i++){
                cout<<i+1<<".            "<<name_dars[i]<<"             "<<tedad_vahed_har_dars[i]<<"          "<<nomreh_har_dars[i]<<endl;
            }
        }
        void namayesh_name_stdnum(){
            cout<<"Name student : "<<first_name<<" "<<last_name<<"       "<<"Student_num : "<<std_num<<endl;

        }
        ~student(){
            cout<<"The details of this student is deleted !"<<endl;
        }
};




int main(){
    student s(4035,"ali","abesi");
    s.darse_pass_shodeh=0;
    char name_vared_shodeh[20];
    int vahed_dars;
    double nomreh_dars;
    int x ;
    while (true){
        cin>>x;
        if(x==1){
            cout<<"Name_dars : ";
            cin>>name_vared_shodeh;
            cout<<"Vahed dars : ";
            cin>>vahed_dars;
            cout<<"Nomreh dars : ";
            cin>>nomreh_dars;
            s.sabt_dars_nomreh_vahed(name_vared_shodeh,vahed_dars,nomreh_dars);
        }
        if(x==0){
            break;
        }
    }
    s.namayesh_name_stdnum();
    s.namayesh_list_doros_pass_shodeh();
    cout<<"Average is : "<<s.hesab_kardan_moadel()<<endl;
    return 0 ;
    
}