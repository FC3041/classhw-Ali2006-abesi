using System.Globalization;
using System.Reflection.Metadata.Ecma335;

public class MakeFile
{
    string path;
    public MakeFile(string str){
        path = str;
    }

    private bool checkin(Student c){
        string[]lines=File.ReadAllLines(path);
        foreach(var line in lines){
            if(line==c.ToString()){
                return false;
            }
        }
        return true;
    }
    public void Register(object x)
    {   if (x is Student){
        Student n = x as Student;
        if(checkin(n)){
        File.AppendAllText(path,n.ToString());
        File.AppendAllText(path,"\n");
        System.Console.WriteLine($"{n.stdname} registered!!"); 
        }
    }
    else{
        System.Console.WriteLine($"{x} is not student!!");

    }
    }
    public string[] Read()
    {
        string [] lines =File.ReadAllLines(path);
        return lines;
    }
    

    public void remove(int nstdid)
    {
        string [] lines =File.ReadAllLines(path);
        string [] newlines=new string[lines.Length-1];
        int index = 0;
        for(int i=0;i<lines.Length;i++){
            string [] words = lines[i].Split(',');
            if (int.Parse(words[1])!=nstdid){
            newlines[index]=lines[i];
            index++;
            }
            else{
                System.Console.WriteLine($"{words[0]} with this stdid {words[1]} is removed!");
            }
        }
    File.WriteAllLines(path,newlines);
    }
}