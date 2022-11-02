using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    public class WordReverse
    {
        public string reverse_words(string str)
        {
            string reverse_word = string.Empty;
            string reverse_conversion = string.Empty;

            foreach(var word in str)
            {
                if((122 >= (int)word && (int)word >= 97) || (90 >= (int)word && (int)word >=65) || (57>=(int)word && (int)word >=48))
                {
                    reverse_word = word + reverse_word;
                }
                else if ((int)word == 32)
                {
                    reverse_conversion += reverse_word + " ";

                    reverse_word = String.Empty;
                }
                else
                {
                    reverse_conversion = reverse_conversion + reverse_word + word;

                    reverse_word = string.Empty;
                }
            }

            if(reverse_word != String.Empty)
            {
                reverse_conversion += reverse_word;
            }

            return reverse_conversion;
        }
    }
}
