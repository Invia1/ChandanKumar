using System;

namespace App
{
    class Occurances
    {
        public void CharOccur(string str)
        {
            while(str.Length>0)
            {
                int count = 0;
                for(int k=0; k<str.Length; k++) 
                {
                    if (str[k] == str[0])
                        count++;
                }
                Console.WriteLine(str[0]+"="+count);
                str = str.Replace(str[0].ToString(), string.Empty);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the words:-");
            string word = Console.ReadLine();
            Occurances o= new Occurances();
            o.CharOccur(word);
        }
    }
}
