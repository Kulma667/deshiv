using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coder_Decoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = ""; // ввод
            string output = ""; // шрифованный 
            string decodedOutput = ""; // дешиф
            input = Console.ReadLine(); // ввод
            output = Convert.ToBase64String(Encoding.UTF8.GetBytes(input)); // шифруем
            Console.WriteLine("decoded: "+output); // выводим
            decodedOutput = Encoding.UTF8.GetString(Convert.FromBase64String(output));// дешифруем
            Console.WriteLine("DE-decoded: "+decodedOutput); //выводим
            Console.ReadLine();
        }
    }
}
