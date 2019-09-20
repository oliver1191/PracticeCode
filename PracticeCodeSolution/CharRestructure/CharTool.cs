using System;
using System.Collections.Generic;
using System.Text;

namespace CharRestructure
{
    public class CharTool
    {
        public string ReorganizeString(string oldStr)
        {
            string reorganizeStr = string.Empty;
            if (oldStr == null || oldStr.Length == 0)
            {
                return "";
            }
            int[] charCount = new int[26];
            foreach (char item in oldStr.ToCharArray())
            {
                charCount[item - 'a']++;
            }
            int maxCharCount = 0;
            char maxCountLetter='0';
            for (int i = 0; i < charCount.Length; i++)
            {
                if (maxCharCount < charCount[i])
                {
                    maxCharCount = charCount[i];
                    maxCountLetter = (char)('a' + i);
                }
            }
            if (maxCharCount > (oldStr.Length + 1) / 2)
            {
                return "";
            }
            char[] res = new char[oldStr.Length];
            int index = insert(charCount, res, 0, maxCountLetter);
            for (int i = 0; i < 26; i++)
            {
                index = insert(charCount, res, index, (char)('a' + i));
            }
            reorganizeStr = new string(res);
            return reorganizeStr;
        }

        private int insert(int[] oldCount,char[] res,int index, char letter)
        {
            int i = letter - 'a';
            while (oldCount[i] > 0)
            {
                if (index >= res.Length)
                {
                    index = 1;
                }
                res[index] = letter;
                oldCount[i]--;
                index += 2;
            }
            return index;
        }
    }
}
