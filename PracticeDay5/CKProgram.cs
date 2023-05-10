class person
{
    int id;
    string name;
    int age;

    public int PID
    {
        get 
        {
            return id;
        }
        set
        { 
            id = value; 
        }
    }
    public string Name
    {
        get 
        { 
            return name;
        }
        set
        {
            name = value;
        }
    }

}

class personDetails
{
    static void Main()
    {
        person obj= new person();
        obj.Name = "Tappu";
        obj.PID = 1;
        Console.WriteLine(obj.PID+" "+obj.Name);
        Console.WriteLine();
    }
}