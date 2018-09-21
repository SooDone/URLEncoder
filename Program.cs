using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 1;
            string ProjectName, ActivityName, UserInput;

            Console.WriteLine("Welcome to URLEncoder");

            while (userInput == 1)
                {

                Console.WriteLine("Please input the project name: ");
                ProjectName = Console.ReadLine();

                while (ProjectName.Contains("NUL") || ProjectName.Contains("SOH") || ProjectName.Contains("STX") || ProjectName.Contains("ETX") || ProjectName.Contains("EOT") || ProjectName.Contains("ENQ") || ProjectName.Contains("ACK") || ProjectName.Contains("BEL") || ProjectName.Contains("BS") || ProjectName.Contains("HT") || ProjectName.Contains("LF") || ProjectName.Contains("VT") || ProjectName.Contains("FF") || ProjectName.Contains("CR") || ProjectName.Contains("SO") || ProjectName.Contains("SI") || ProjectName.Contains("DLE") || ProjectName.Contains("DC1") || ProjectName.Contains("DC2") || ProjectName.Contains("DC3") || ProjectName.Contains("DC4") || ProjectName.Contains("NAK") || ProjectName.Contains("SYN") || ProjectName.Contains("ETB") || ProjectName.Contains("CAN") || ProjectName.Contains("EM") || ProjectName.Contains("SUB") || ProjectName.Contains("ESC") || ProjectName.Contains("FS") || ProjectName.Contains("GS") || ProjectName.Contains("RS") || ProjectName.Contains("US"))
                {
                    Console.WriteLine("That input is invalid beause it contains a control character. Please input a new project name: ");
                    ProjectName = Console.ReadLine();
                }

                Console.WriteLine("Please input the activity name: ");
                ActivityName = Console.ReadLine();

                while (ActivityName.Contains("NUL") || ActivityName.Contains("SOH") || ActivityName.Contains("STX") || ActivityName.Contains("ETX") || ActivityName.Contains("EOT") || ActivityName.Contains("ENQ") || ActivityName.Contains("ACK") || ActivityName.Contains("BEL") || ActivityName.Contains("BS") || ActivityName.Contains("HT") || ActivityName.Contains("LF") || ActivityName.Contains("VT") || ActivityName.Contains("FF") || ActivityName.Contains("CR") || ActivityName.Contains("SO") || ActivityName.Contains("SI") || ActivityName.Contains("DLE") || ActivityName.Contains("DC1") || ActivityName.Contains("DC2") || ActivityName.Contains("DC3") || ActivityName.Contains("DC4") || ActivityName.Contains("NAK") || ActivityName.Contains("SYN") || ActivityName.Contains("ETB") || ActivityName.Contains("CAN") || ActivityName.Contains("EM") || ActivityName.Contains("SUB") || ActivityName.Contains("ESC") || ActivityName.Contains("FS") || ActivityName.Contains("GS") || ActivityName.Contains("RS") || ActivityName.Contains("US"))
                {
                    Console.WriteLine("That input is invalid beause it contains a control character. Please input a new activity name: ");
                    ActivityName = Console.ReadLine();
                }

                var projectName = ProjectName.Replace(" ", "%20").Replace("<", "%3C").Replace(">", "%3E").Replace("#", "%23").Replace("%", "%25").Replace("\"", "%22").Replace(";", "%3B").Replace("/", "%2F").Replace("?", "%3F").Replace(":", "%3A").Replace("@", "%40").Replace("&", "%26").Replace("$", "%24").Replace("+", "%2B").Replace("=", "%3D").Replace("[", "%5B").Replace("]", "%5D").Replace("\\", "%5C").Replace("^", "%5E").Replace("`", "%60").Replace("{", "%7B").Replace("}", "%7D").Replace("|", "%7C");
                var activityName = ActivityName.Replace(" ", "%20").Replace("<", "%3C").Replace(">", "%3E").Replace("#", "%23").Replace("%", "%25").Replace("\"", "%22").Replace(";", "%3B").Replace("/", "%2F").Replace("?", "%3F").Replace(":", "%3A").Replace("@", "%40").Replace("&", "%26").Replace("$", "%24").Replace("+", "%2B").Replace("=", "%3D").Replace("[", "%5B").Replace("]", "%5D").Replace("\\", "%5C").Replace("^", "%5E").Replace("`", "%60").Replace("{", "%7B").Replace("}", "%7D").Replace("|", "%7C");

                Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName, activityName);

                Console.WriteLine("Would you like to create another URL? Type \"yes\", and then hit the \"enter\" key twice if you do, or type anything else and hit enter twice to exit the program.");
                UserInput = Console.ReadLine();

                if (UserInput == "yes")
                {
                    userInput = 1;
                }

                else
                {
                    userInput = 0;
                }

                Console.ReadLine();
            }
        }
    }
}
