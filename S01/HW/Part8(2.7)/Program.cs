﻿namespace Date2;

class Program
{   
    public static bool is_leapyear(int year){
    if((year%400==0)||((year%4==0)&&(year%100!=0))){
        return true ;
    }
    else{
        return false;
    }
}
public static int day_in_month(int year , int monthnumber){
    if ((monthnumber==1)||(monthnumber==3)||(monthnumber==5)||(monthnumber==7)||(monthnumber==8)||(monthnumber==10)||(monthnumber==12)){
        return 31;
    }
    if ((monthnumber==4)||(monthnumber==6)||(monthnumber==9)||(monthnumber==11)){
        return 30;
    }

    if(monthnumber==2){
        if (is_leapyear(year)){
            return 29;
        }
        else{
            return 28;
        }
    }
    return 0 ;
}
    public static int days_before_date(int year , int monthnum , int day){
        int sum_day=0;
        for(int i = 1;i<monthnum;i++){
            sum_day+=day_in_month(year , i);
        }
        while(day>1){
            sum_day+=1;
            day--;
        }
        return sum_day;
    }
    static void Main(string[] args)
    {
        int d=days_before_date(2014,12,31);
        Console.WriteLine(d);
    }
}
