//Ali Mohammad Abesi
#include<iostream>
#include<stdlib.h>

using namespace std;
template<typename x>
class Vector
{   private:
        int m_lengh =0;
        int m_capacity=1;
        x* m_listnum =(x*)malloc(sizeof(x));
        int resize(int newcapacity){
            x*newlist=(x*)malloc(sizeof(x)*newcapacity);
            for(int i=0;i<m_lengh;i++){
                newlist[i]=m_listnum[i];
            }
            free(m_listnum);
            m_listnum=newlist;
            m_capacity=newcapacity;
            return 0;
        }

    public:

        void push_back(int a){
            m_lengh+=1;
            while (m_lengh*4>=m_capacity)
            {
                resize(m_capacity*2);
            }
            m_listnum[m_lengh-1]=a;
            
        }

        int at(int index){
            if(index<m_lengh){

                return m_listnum[index];
            }
            else{
                throw out_of_range("out of range");
            }
        }
        int size(){
            return m_lengh;
        }
        
        int capacity(){
            return m_capacity;
        }

        void insert(int index , x num){
            m_lengh+=1;
            while (m_lengh*4>=m_capacity)
            {
                resize(m_capacity*2);
            }
            for(int i=m_lengh-1;i>index;i--){
                m_listnum[i]=m_listnum[i-1];
            }
            m_listnum[index]=num;
        }

        void erase(int index){
            for(int i=index;i<m_lengh;i++){
                m_listnum[i]=m_listnum[i+1];
            }
            m_lengh-=1;
        }
        void reverse(){
            for(int z=0;z<int(m_lengh/2);z++){
                x temp=m_listnum[z];
                m_listnum[z]=m_listnum[m_lengh-z-1];
                m_listnum[m_lengh-z-1]=temp;
            }
        }

        void sort(){
            for(int i=0;i<m_lengh;i++){
                for(int j=0;j<m_lengh-1;j++){
                    if(m_listnum[j+1]<m_listnum[j]){
                        x temp = m_listnum[j];
                        m_listnum[j]=m_listnum[j+1];
                        m_listnum[j+1]=temp;
                    }
                }
            }
        }

        void clear(){
            m_lengh=0;
            m_capacity=1;
        }

};


int main(){
    Vector<int>nums;
    nums.push_back(5);
    nums.push_back(3);
    nums.push_back(2);
    nums.push_back(1);
    nums.push_back(6);
    for(int j=0;j<nums.size();j++){
        cout<<nums.at(j)<<" , ";
    }
    nums.insert(1,4);
    
    nums.erase(3);

    nums.sort();
    cout<<endl;
    for(int j=0;j<nums.size();j++){
        cout<<nums.at(j)<<" , ";
    }
    return 0;
}