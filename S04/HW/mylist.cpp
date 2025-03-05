#include<iostream>
#include<stdlib.h>
using namespace std;



class List
{
    public:
        int m_size;
        int* m_numberlist;

        List(int len , int* list_num):m_size(len){
            m_numberlist=(int*)malloc(sizeof(int)*m_size);
            for(int i=0;i<m_size;i++){
                m_numberlist[i]=list_num[i];
            }
        }

        void print_list(){
            for(int j=0;j<m_size;j++){
                cout<<m_numberlist[j]<<endl;
            }
        }

        void append(int x){
            resize(m_size+1);
            m_numberlist[m_size-1]=x;
        }
        void pop(int y){
            int* newlist2=(int*)malloc(sizeof(int)*(m_size-1));
            int z;
            for(z=0;z<m_size;z++){
                if(m_numberlist[z]==y){
                    break;;
                }
            }
            int i=0;
            while(i<m_size-1){
                if(i<z){
                    newlist2[i]=m_numberlist[i];
                    i++;
                }
                else{
                    newlist2[i]=m_numberlist[i+1];
                    i++;
                }
            }
            m_numberlist=newlist2;
            m_size-=1;
            free(newlist2);
        }
        private:
        void resize(int newlen){
            int* newlist=(int*)malloc(sizeof(int)*newlen);
            for(int k=0;k<m_size;k++){
                newlist[k]=m_numberlist[k];
            }
            free(m_numberlist);
            m_numberlist=newlist;
            m_size=newlen;
            free(newlist);
        }
};


int main(){
    int nums[5]={1,3,24,5,6};
    List M(5,nums);
    M.append(12);
    M.pop(6);
    M.print_list();
    return 0;
}