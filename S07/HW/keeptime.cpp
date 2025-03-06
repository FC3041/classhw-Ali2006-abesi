#include<iostream>
#include<string>
#include<Windows.h>

using namespace std;

class Keeptime
{
    char m_text[100];
    unsigned long m_t1;
    unsigned long m_t2;



    public:
        Keeptime(const char *txt)
        :m_t1(GetTickCount())
        {   
            int i;
            for(i=0;i<strlen(txt);i++){
                m_text[i]=txt[i];
            }
            m_text[i]='\0';
        }

        ~Keeptime()
        {
            m_t2=GetTickCount();
            cout<<m_text<<" : "<<endl;
            cout<<m_t2-m_t1<<" milliseconds  "<<endl;
        }
};

int main(){

    Keeptime sleep("Time of sleep and for loop");
    Sleep(1000);
    double sum=0;
    for(int i=0;i<100000000;i++){
        sum+=i;
    }
    cout<<"sum is : "<<sum<<endl;
    
    return 0;
}