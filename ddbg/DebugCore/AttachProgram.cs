using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace ddbg.DebugCore
{
    public class DebuggableProgram
    {

        public static async void StartDebugSession(String programPath, String programArgs)
        {
            Process process = new Process();
            process.StartInfo.FileName = programPath;
            process.StartInfo.Arguments = programArgs;
            try
            {
                Console.WriteLine("Debug session starting....");
                Console.WriteLine("Program: " + programPath);
                Console.WriteLine("Arguments: " + programArgs);

                process.Start();

                if (!Debugger.IsAttached)
                {
                    process.WaitForInputIdle();
                    Debug.WriteLine("Debugger attached!");
                }
                
                process.WaitForExit();
                if(process.HasExited == true)
                {
                    Console.WriteLine("Program " + programPath + " exited with code " + process.ExitCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
