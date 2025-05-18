using System.Net.Http.Headers;

public interface Imachine
{
    public bool ismoving();
    public int count_wheels();
    public int capacity();
    public string color();
    public string fuel();
    public string model();
}




public class Bicycle: Imachine
{
    string m_model;
    string m_color;


    public Bicycle(string model , string color)
    {
        m_model=model;
        m_color=color;
    }

    public int capacity()
    {
        return 1;
    }

    public string color()
    {
        return m_color;
    }

    public int count_wheels()
    {
        return 2;
    }

    public string fuel()
    {
        return "Renewable Fuel";
    }

    public bool ismoving()
    {
        return true;
    }

    public string model()
    {
        return m_model;
    }
}

public class Machine : Imachine
{
    string m_model;
    string m_color;


    public Machine(string model , string color)
    {
        m_model=model;
        m_color=color;
    }
    public int capacity()
    {
        return 5;
    }

    public string color()
    {
        return m_color;
    }

    public int count_wheels()
    {
        return 4;
    }

    public string fuel()
    {
        return "Non-Renewable Fuel";
    }

    public bool ismoving()
    {
        return true;
    }

    public string model()
    {
        return m_model;
    }
}

public class Bus : Imachine
{
    string m_model;
    string m_color;


    public Bus(string model , string color)
    {
        m_model=model;
        m_color=color;
    }
    public int capacity()
    {
        return 30;
    }

    public string color()
    {
        return m_color;
    }

    public int count_wheels()
    {
        return 8;
    }

    public string fuel()
    {
        return "Non-Renewable Fuel";
    }

    public bool ismoving()
    {
        return true;
    }

    public string model()
    {
        return m_model;
    }

}

public class Motorcycle: Imachine
{
    string m_model;
    string m_color;


    public Motorcycle(string model , string color)
    {
        m_model=model;
        m_color=color;
    }
    public int capacity()
    {
        return 2;
    }

    public string color()
    {
        return m_color;
    }

    public int count_wheels()
    {
        return 2;
    }

    public string fuel()
    {
        return "Non-Renewable Fuel";
    }

    public bool ismoving()
    {
        return true;
    }

    public string model()
    {
        return m_model;
    }
}