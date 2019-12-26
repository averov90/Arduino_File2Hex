using System;
using System.Linq;
using System.Text;
using System.IO;

namespace Arduino_File2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Binary To HEX of C++ for Arduino IDE ----");
            string result = "#include <avr/pgmspace.h>\r\n", sbstr;
            string[] files = Directory.GetFiles(Environment.CurrentDirectory, "*.*", SearchOption.TopDirectoryOnly).Where(c => !(c.EndsWith(".exe") || c.EndsWith(".ino"))).ToArray();
            foreach (string item in files)
            {
                sbstr = item.Substring(item.LastIndexOf('\\') + 1);
                result += "const char* bin" + sbstr.Substring(0,sbstr.IndexOf('.')).Replace(' ', '_') + " PROGMEM = {0x" + BitConverter.ToString(File.ReadAllBytes(item)).Replace("-",",0x") + "};\r\n";
            }
            File.WriteAllText(Environment.CurrentDirectory + "\\result.ino", result, Encoding.ASCII);
            Console.WriteLine("Complete!");
            Console.ReadKey();
        }
    }
}
