namespace HWS08;

class Program
{   
    public static void reverse_sentence_word(string name , out string rev){
        rev="";
        for(int i=0;i<name.Length;i++){
            rev=rev+name[name.Length-i-1];
        }
    }
    public static void reverse_sentence(string str ,out string pcr){
       var list = str.Split();
       pcr="";
       foreach(string s in list){
        pcr=s+" "+pcr;
       }
    }
    static void Main(string[] args)
    {
        string str;
        reverse_sentence("Ali Mohammad Abesi is a bad boy" ,out str);
        System.Console.WriteLine(str);

        string str2;
        reverse_sentence_word("Ali Mohammad Abesi is a good boy" ,out str2);
        System.Console.WriteLine(str2);
        
    }
}
