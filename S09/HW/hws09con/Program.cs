namespace hws09con;

class Program
{
    static void Main(string[] args)
    {
        Student zerang = new Student(
            name:"Ali mohammad",
            stdid:4037,
            natid:121973,
            credits:18,
            active: true);

    // Console.WriteLine(zerang.ToString());

    string newstd="Ali,4035,121973,18,False";
    Student tanbal = Student.Parse(newstd);
    // System.Console.WriteLine(tanbal.ToString());
    string newstd2="Mohammad,4036,121973,18,False";
    Student bihal = Student.Parse(newstd2);
    // System.Console.WriteLine(bihal.ToString());

    MakeFile pdf = new MakeFile("student.csv");
    pdf.Register(zerang);
    pdf.Register(tanbal);
    pdf.Register(bihal);
    // pdf.Append(45); show error

    string[]lines=pdf.Read();
    foreach(var x in lines){
        var s = Student.Parse(x);
        System.Console.WriteLine(s);
    }
    pdf.remove(4036);
    string[]liness=pdf.Read();
    foreach(var y in liness){
        var ss = Student.Parse(y);
        System.Console.WriteLine(ss);
    }
    }
    
}
