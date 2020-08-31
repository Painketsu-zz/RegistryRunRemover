using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryRunRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 1)
                    Remove(args);
                else
                    Console.WriteLine("1 param, command should be [remove Name]");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static void Remove(string[] args)
        {
            string name = args[0] + ".exe";
            string KeyName = string.Format(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\{0}", name);

            RegistryKey reg = null;
            reg = Registry.LocalMachine.OpenSubKey(KeyName, RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (reg != null)
            {
                reg.Close();
                Registry.LocalMachine.DeleteSubKey(KeyName);
            }

        }
    }
}
