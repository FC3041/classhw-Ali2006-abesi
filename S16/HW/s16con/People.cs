

using System.Diagnostics;

class Citizen
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int NationalId {get; set;}
    public bool IsMale {get; set;}

    public int PostalCode {get; set;} = 0;

    public Citizen(string fname, string lname, 
                  int id, bool isMale, int postalCode)
    {
        this.FirstName = fname;
        this.LastName = lname;
        this.NationalId = id;
        this.IsMale = isMale;
        this.PostalCode = postalCode;
    
    }

    public Citizen(string fname, string lname, int id, 
                   bool isMale)
        : this(fname, lname, id, isMale, 0)
    {
    }

    public override string ToString()
    {
        return $"{base.ToString()}({this.FirstName},{this.LastName})";
    }
    // public Citizen(){}
}

class Student: Citizen
{
    public int StdId {get; set;}
    public string Major {get; set;}
    public bool IsPaying {get;set;}

    public virtual void Register(string course)
    {
        System.Console.WriteLine(
            $"{this.FirstName} reg in {course}");
    }

    public Student(
        string fname, string lname, 
        int id, string major, int stdid, 
        bool isPaying)
        : base(fname, lname, id, false)
    {
        this.IsPaying = isPaying;
        this.StdId = stdid;
        this.Major = major;
    }
    public override string ToString()
    {
        return $"{base.ToString()} - {this.Major}";
    }
}

// class Teacher: Citizen
// {
//     // TODO1 Salary
//     // TODO2 Rating
//     // TODO3 EmployeeId

// }
class Teacher : Citizen
{
    public double Salary { get; set; }
    public int Rating { get; set; } 
    public int EmployeeId { get; set; }

    public Teacher (string fname, string lname, int id, bool isMale , double s , int r , int ee)
    :base (fname , lname , id , isMale )
    {
        this.Salary=s;
        this.Rating=r;
        this.EmployeeId=ee;
    }
    public override string ToString()
    {
        return $"{base.ToString()}-{this.FirstName} {this.LastName}";
    }
    public virtual void Register(string course)
    {
        System.Console.WriteLine(
            $"{this.FirstName} reg in the work by this employeeid {this.EmployeeId}");
    }
}

class GradStudent: Student
{
    public string Minor {get;set;}
    public string ThesisTitle {get; set;}
    public GradStudent(
        string fname, string lname, 
        int id, string major, int stdid, 
        bool isPaying, string minor, string thesisTitle)
        : base(fname, lname, id, major, stdid, isPaying)
    {
        this.Minor = minor;
        this.ThesisTitle = thesisTitle;        
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {this.Minor}";
    }

    public override void Register(string course)
    {
        System.Console.WriteLine(
            $"{this.FirstName} intro to prof in {course}");
    }



}

