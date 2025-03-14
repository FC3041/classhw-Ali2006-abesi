#include<iostream>
#include<stdlib.h>

using namespace std;
// template<typename T>  you can define the type of your list by the same method 
//==>
//vector<int>l1;
//vector<float>l2;
//vector<double>l3;
class Vector_int
{
    private:
        int m_lengh = 0;
        int* m_listnum =(int*)malloc(sizeof(int));
        int m_capacity = 1;
        int resize(int newcapacity){
            int* newlist=(int*)malloc(sizeof(int)*newcapacity);
            for(int i=0;i<m_lengh;i++){
                newlist[i]=m_listnum[i];
            }
            free(m_listnum);
            m_listnum=newlist;
            m_capacity=newcapacity;
            return 0;
        }


    public:

    int push_back(int x){
        m_lengh+=1;
        while(4*m_lengh>=m_capacity){
            resize(m_capacity*2);
        }
        m_listnum[m_lengh-1]=x;
        return 0;
    }
    int capacity(){
        return m_capacity;
    }
    int size(){
        return m_lengh;
    }
    int at(int index){
        if(index<m_lengh){

            return m_listnum[index];
        }
        else{
            throw out_of_range("Out of the range");
        }
    }

    int insert(int index , int num){
        m_lengh+=1;
        while(4*m_lengh>=m_capacity){
            resize(m_capacity*2);
        }
        int last = m_listnum[m_lengh-2];
        for(int i=m_lengh-2;i>index;i--){
            m_listnum[i]=m_listnum[i-1];
            }
        m_listnum[index]=num;
        m_listnum[m_lengh-1]=last;

        return 0;
    }
    int erase(int index){
        for(int i=index;i<m_lengh;i++){
            m_listnum[i]=m_listnum[i+1];
        }
        m_lengh-=1;
        return 0;
    }

    int clear(){
        free(m_listnum);
        m_lengh=0;
        m_capacity=1;
        return 0;
    }
    void reverse(){
        for(int i=0;i<int(m_lengh/2);i++){
            int temp = m_listnum[i];
            m_listnum[i]=m_listnum[m_lengh-i-1];
            m_listnum[m_lengh-i-1]=temp;
        }
    }

};








int main(){
    Vector_int nums;
    nums.push_back(78);
    nums.push_back(10);
    nums.push_back(8);
    nums.push_back(9);
    nums.reverse();
    for(int i=0;i<nums.size();i++){
        
        cout<<"The number"<<i<<" : "<<nums.at(i)<<endl;
    }
    cout<<"The capacity : "<<nums.capacity()<<endl;
    nums.insert(2,2);
    for(int i=0;i<nums.size();i++){
        
        cout<<"The number"<<i<<" : "<<nums.at(i)<<endl;
    }
    cout<<"The capacity : "<<nums.capacity()<<endl;
    nums.erase(1);
    for(int i=0;i<nums.size();i++){
        
        cout<<"The number"<<i<<" : "<<nums.at(i)<<endl;
    }
    nums.clear();
    cout<<"The size of empty nums : "<<nums.size()<<endl;


    return 0;
}