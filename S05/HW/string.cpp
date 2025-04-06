#include<iostream>
#include<stdlib.h>

using namespace std;


class String
{private:
    int m_lengh;
    char* m_str;
    int m_capacity = 1;

    int resize(int newcapacity){
        char* list=(char*)malloc(sizeof(char)*newcapacity);
        copy_str(m_str,list);
        free(m_str);
        m_str=list;
        m_capacity=newcapacity;
        return 0;
    }

    int len(const char* pch){
        int count = 0;
        while(*pch){
            count++;
            pch++;
        }
        return count;
    }
    int copy_str(const char* x ,char* y){
        while(*x){
            *y=*x;
            x++;
            y++;
        }
        *y='\0';
        
        return 0;
    }
    public:
        String(const char* name){
            m_lengh=len(name);
            while(m_lengh>m_capacity){
                m_capacity*=2;
            }
            m_str=(char*)malloc(sizeof(char)*m_lengh+1);
            copy_str(name,m_str);
        }
        String(){}

        void assign(const char* abc){
            m_lengh=len(abc);
            while(m_lengh>m_capacity){
                m_capacity*=2;
            }
            m_str=(char*)malloc(sizeof(char)*m_lengh+1);
            copy_str(abc,m_str);
        }
    
        int size(){
            return m_lengh;
        }
        int capacity(){
            return m_capacity;
        }
    
        char* c_str(){
            return m_str;
        }

        void append(const char* trl){
            int newsize=m_lengh+len(trl);
            while(newsize>m_capacity){
                resize(m_capacity*2);
            }
            copy_str(trl,m_str+m_lengh);
            m_lengh=newsize;
        }

        void append(String p){
            int newsize=m_lengh+p.m_lengh;
            while(newsize>m_capacity){
                resize(m_capacity*2);
            }
            copy_str(p.m_str,m_str+m_lengh);
            m_lengh=newsize;
        }


};












int main(){

    String name("Ali");
    cout<<name.c_str()<<endl;
    cout<<name.size()<<endl;
    cout<<name.capacity()<<endl;
    String name2;
    name2.assign("mohammad");
    cout<<name2.c_str()<<endl;
    name.append(" + ");
    name.append(name2);
    cout<<name.c_str()<<endl;
    cout<<name.size()<<endl;
    cout<<name.capacity()<<endl;

    return 0;
}