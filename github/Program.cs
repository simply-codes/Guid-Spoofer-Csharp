//                                Used for HardwareID Ban bypassing
//  This changes("Spoofs") your Universally Unique Identifier(GUID) so AntiCheats dont recognize you.     (commonly used for that)
//                           Or you can ofc use it for whatever you want :D


//                                       github.com/simply-codes


using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace hwid_spoof_test
{
    class Program
    {



        public static void SpoofGUID()
        {

            string guid = Guid.NewGuid().ToString();

            RegistryKey OurKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            OurKey = OurKey.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", true);
            OurKey.SetValue("MachineGuid", guid);


        }






        public static void SpoofHwProfileGUID()
        {
            string hwguid = "{" + Guid.NewGuid().ToString() + "}";

            RegistryKey OurKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            OurKey = OurKey.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", true);
            OurKey.SetValue("HwProfileGUID", hwguid);
            OurKey.Close();


        }




        static void Main(string[] args)
        {
            if (IsAdministrator())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Made By simply#9999");
                Thread.Sleep(2250);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Console.WriteLine("TYPE 1 AND HIT ENTER");
                Thread.Sleep(150);
                Thread.Sleep(150);
                string mudjja = Console.ReadLine();
                if (mudjja == "1")
                {
                    Thread.Sleep(500);
                    SpoofHwProfileGUID();
                    SpoofGUID();
                    Console.Clear();
                    Console.WriteLine("SPOOFING YOUR GUID...");
                    Thread.Sleep(2750);
                    Console.Clear();
                    Console.WriteLine("DONE SPOOFING YOUR GUID");
                    Thread.Sleep(1750);
                    Environment.Exit(0);
                    Console.ReadLine();
                }
                else if (mudjja == "1")
                {
                    Thread.Sleep(500);
                    SpoofHwProfileGUID();
                    SpoofGUID();
                    Console.Clear();
                    Console.WriteLine("SPOOFING YOUR GUID...");
                    Thread.Sleep(2750);
                    Console.Clear();
                    Console.WriteLine("DONE SPOOFING YOUR GUID");
                    Thread.Sleep(1750);
                    Environment.Exit(0);
                    Console.ReadLine();
                }


                else
                {
                    Thread.Sleep(100);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Please run the program as administrator.");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }


         bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }




            }

        }
    }
