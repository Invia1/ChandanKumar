using System;
class Palindrome
{
       public void IsPalindrome(String str)
       {
          string rev = "";
          for(int i=str.Length-1; i>=0; i--) 
          {
            rev += str[i];
          }
          if (rev == str)
             Console.WriteLine("Palindrome");
          else
             Console.WriteLine("Is not Palindrome");
       }
    static void Main()
    {
        Console.WriteLine("Enter the words");
        string word=Console.ReadLine();
        Palindrome p=new Palindrome();
        p.IsPalindrome(word);
     
    }
}
