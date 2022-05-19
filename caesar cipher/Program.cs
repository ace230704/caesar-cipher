using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            Console.WriteLine("write word:");
            string word = Console.ReadLine();
            Console.WriteLine("enter a number of shift");

            int shift = Convert.ToInt32(Console.ReadLine());
            
            char[] massage = word.ToCharArray();

            int j, num, result;
            string newWord;

            for (int i = 0; i < massage.Length; i++) 
            {
                for (j = 0; j < alfavit.Length; j++) 
                {
                    if (massage[i] == alfavit[j]) 
                    {
                        break;
                    }
                }

                if (j != 33) 
                {
                    num = j;
                    result = num + shift;

                    if (result > 32) 
                    {
                        result -= 33;
                    }

                    massage[i] = alfavit[result];
                }
            }
            newWord = new string(massage);
            Console.WriteLine(newWord);

        }
    }
}
