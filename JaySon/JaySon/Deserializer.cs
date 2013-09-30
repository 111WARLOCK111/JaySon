using System.IO;

namespace JaySon
{
    class Deserializer
    {
        public static string[] Deserialize(string format, string file)
        {
            string[] str = format.Split('/');
            string[] rtn = format.Split('/');
            int strc = 0;
            using (var sr = new StreamReader(file))
            {
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    count = count + 1;
                    if (count > 2 && count < str.Length + 3)
                    {
                        rtn[strc] = line.Substring(str[strc].Length + 9).Replace("\"", "");
                        strc = strc + 1;
                    }
                }
            }
            return rtn;
        }
    }
}
