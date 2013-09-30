using System.IO;

namespace JaySon
{
    class Serializer
    {
        public static void Serialize(string data, string format, string file)
        {
            string[] getsplit = data.Split('/');
            string[] getform = format.Split('/');
            var sw = new StreamWriter(file);
            sw.WriteLine("JaySon V1.0.0.1 Format");
            sw.WriteLine("{");
            int count = 0;
            foreach (string getd in getsplit)
            {
                sw.WriteLine("    \"" + getform[count] + "\"  \"" + getd + "\"");
                count = count + 1;
            }
            sw.Write("}");
            sw.Close();
        }
    }
}
