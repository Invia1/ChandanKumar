delegate int studyDelegate();
delegate string TopicDelegate();
class student
{
    public double expenses()
    {
        return 1200;
    }
    public string Topic()
    {
        return "C# with oops";
    }
    public int study()
    {
        return 3;
    }
}
class friend
{
    public static void Main()
    {
        student obj = new student();
        studyDelegate mydel = new studyDelegate(obj.study);
        var temp=mydel.Invoke();
        Console.WriteLine(temp);

        TopicDelegate mydel2=new TopicDelegate(obj.Topic);
        var temp2=mydel2.Invoke();
        Console.WriteLine(temp2);
    }
  
}