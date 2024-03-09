using ddbg.DebugCore;
using ddbg.IO;

namespace ddbg
{
    public class Program
    {
        static void Main(string[] args)
        {
            String commandLine;
            DebuggableProgram program;

            while (true)
            {
                Console.Write("(ddbg) ");
                commandLine = Console.ReadLine();
                CommandParser.parse(commandLine);
                
            }
        }
    }
}
