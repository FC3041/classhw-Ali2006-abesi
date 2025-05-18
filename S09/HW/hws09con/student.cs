using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

public class Student 
{
    public string stdname;
    public int stdid;
    public int natid;
    public int stdcredits;
    public bool stdactive;
    

    public Student(){}
    public Student(string name,int stdid,int natid,int credits,bool active)
    {
        stdname=name;
        this.stdid=stdid;
        this.natid=natid;
        stdcredits=credits;
        stdactive=active;
    }
    public override string ToString()=>
    $"{stdname},{stdid},{natid},{stdcredits},{stdactive}";
    
    // public static Student Parse(string std)
    // {
    //     string[] str=std.Split(',');
    //     string xname=str[0];
    //     int xstdid = int.Parse(str[1]);
    //     int xnatid = int.Parse(str[2]);
    //     int xcredits = int.Parse(str[3]);
    //     bool xactive = bool.Parse(str[4]);

    //     return new Student(xname,xstdid,xnatid,xcredits,xactive);

    // }
    public static Student Parse(string std)
    {   Student sc=new Student();

        string[] str=std.Split(',');
        sc.stdname=str[0];
        sc.stdid = int.Parse(str[1]);
        sc.natid = int.Parse(str[2]);
        sc.stdcredits = int.Parse(str[3]);
        sc.stdactive= bool.Parse(str[4]);

        return sc;

    }
}