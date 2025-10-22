using System;
using System.Diagnostics;

public class EmulatorLauncher
{
    public static void StartEmulator(string emulatorName)
    {
        try
        { 
            string emulatorPath = @"C:\Users\AK\AppData\Local\Android\Sdk\emulator\emulator.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = emulatorPath,
                Arguments = $"-avd {emulatorName}",
                CreateNoWindow = true,
                UseShellExecute = false,
            };
            
            Process emulatorProcess = new Process
            {
                StartInfo = startInfo
            };

            emulatorProcess.Start();
            Console.WriteLine($"Emulator '{emulatorName}' is starting...");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to start emulator: " + ex.Message);
        }
    }
}
