using System.Text;

 class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Put your text that you want to say!");

        string wordText = Console.ReadLine();
        string translatedTest = TranslateText(wordText);

        Console.WriteLine("Translated Text is: " + translatedTest);

    }
        private static string TranslateText(string text)
        {
            StringBuilder translated = new StringBuilder();
            translated.Append("UBCO ");

            string[] words = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                foreach (var ch in word)
                {
                    if ("aeiou".Contains(char.ToLower(ch)))
                    {
                        translated.Append(ch);
                        translated.Append(ch);
                        //Console.WriteLine("aeiou: " + translated);
                    }
                    else if (char.IsLetter(ch))
                    {
                        translated.Append(ShiftConsonant(ch));
                        //Console.WriteLine("IsLetter: " + translated);
                    }
                    else
                    {
                        translated.Append(ch);
                        //Console.WriteLine(translated);
                    }
                }
                translated.Append(' ');
            }
            
            String FullText = translated.ToString().TrimEnd() + words.Length;
        //translated.ToString().TrimEnd();
        //translated.Append(words.Length);
        //return translated.ToString().Trim();
        return FullText;
        }

        private static char ShiftConsonant(char ch)
        {

        //Console.WriteLine("ShiftConsonant: " + ch);
        char lowerCh = char.ToLower(ch);
        char nextCh;
        char nextNewCh = 'v';
        //Console.WriteLine("lowerCh: " + lowerCh);
        
        if (lowerCh == 'z')
        {
            nextCh = 'b';
        }
        else
        {
                //do
                //{
            nextCh = (char)(lowerCh + 1);
            //Console.WriteLine("nextCh: " + nextCh);

            if ("aeiou".Contains(nextCh))
            {
                nextNewCh = (char)(nextCh + 1);
            }
            else
            {
                nextNewCh = nextCh;
            }

            //Console.WriteLine("nextNewCh: " + nextNewCh);
            //}
            // while (!"aeiou".Contains(nextCh));
        }

            return char.IsUpper(ch) ? char.ToUpper(nextNewCh) : nextNewCh;
        }
}