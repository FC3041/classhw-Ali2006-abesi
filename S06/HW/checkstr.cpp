#include<iostream>
#include<stdlib.h>


using namespace std;

class String
{   private:
    int m_lengh =0;
    char* m_str = (char*)malloc(sizeof(char));
    int m_capacity =1;

    int len(const char* str){
        int count=0;
        while(*str){
            count++;
            str++;
        }
        return count;
    }
    int copy_str(const char* pch , char*mch){
        while(*pch){
            *mch=*pch;
            mch++;
            pch++;
        }
        *mch='\0';
        return 0;
    }
    int resize(int newcapacity){
        char* newstr=(char*)malloc(sizeof(char)*newcapacity);
        copy_str(m_str,newstr);
        free(m_str);
        m_str=newstr;
        m_capacity=newcapacity;
        return 0;
    }




    public:

    String(const char* pch){
        m_lengh+=len(pch);
        m_str=(char*)malloc(sizeof(char)*(m_lengh+1));
        while(m_lengh>=m_capacity){
            m_capacity*=2;
        }
        copy_str(pch,m_str);

    }
    String(){};
    int assign(const char* str){
        m_lengh=len(str);
        while(m_lengh>=m_capacity){
            resize(m_capacity*2);
        }
        copy_str(str,m_str);
        return 0;
    }

    int append(const char* str){
        m_lengh+=len(str);
        while(m_lengh>=m_capacity){
            resize(m_capacity*2);
        }
        copy_str(str,m_str+(m_lengh-len(str)));
        return 0;
    }
    int append(String p){
        m_lengh+=p.size();
        while(m_lengh>=m_capacity){
            resize(m_capacity*2);
        }
        copy_str(p.m_str,m_str+(m_lengh-p.size()));
        return 0;
    }

    int size(){
        return m_lengh;
    }

    char* c_str(){
        return m_str;
    }
    int capacity(){
        return m_capacity;
    }
    bool checkSubstr(const char* str){
        int size = len(str);
        int j;
        for(int i=0;i<m_lengh-size+1;i++){
            for(j=0;j<size;j++){
                if(m_str[i+j]!=str[j]){
                    break;
                }
            }
            if(j==size){
                return true;
            }
            
        }
        return false;
    }



};














int main(){
    String name;
    String name2("ABESI");
    name.assign("ALI mohammad");
    cout<<name.c_str()<<endl;
    name.append(" + ");
    name.append(name2);
    cout<<name.c_str()<<endl;
    cout<<name.capacity()<<endl;
    cout<<name.size()<<endl;
    cout<<name.checkSubstr("AES")<<endl;
    return 0;
}