using ddbg.DebugCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddbg.IO
{
    public class CommandParser
    {
        private static String execPath;
        private static String execArgs;
        private static DebuggableProgram debugSession;

        public static void parse(String line)
        {
            switch(line)
            {
                case "exit":
                    Environment.Exit(0);
                    break;

                case String str when str.StartsWith("target"):
                    execPath = str.Remove(0, 7);
                    break;
                case String str when str.StartsWith("args"):
                    execArgs = str.Remove(0, 5);
                    break;

                case "run":
                    DebuggableProgram.StartDebugSession(execPath, execArgs);
                    break;

                default:
                    break;
            }
        }
    }
}
