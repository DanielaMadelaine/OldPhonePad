using System;
using System.Text;

namespace IronChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test cases

            OldPad conver = new OldPad();
            Console.WriteLine(conver.OldPhonePad("4433555 555666#"));
            //Console.WriteLine(conver.OldPhonePad("227*#")); 
            //Console.WriteLine(conver.OldPhonePad("2277*#")); 
            //Console.WriteLine(conver.OldPhonePad("4433555 555666#")); 
            //Console.WriteLine(conver.OldPhonePad("8 88777444666*664#")); 
            Console.Read();
        }
    }
}
