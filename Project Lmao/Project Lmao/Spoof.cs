using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Lmao
{
    public partial class Spoof : Form
    {
        string adapterName = "Ethernet";
        string newMacAddress = "00-11-22-33-44-55";
        public Spoof()
        {
            InitializeComponent();
        }

        private void Spoof_Load(object sender, EventArgs e)
        {
            string mb = GetMotherboardManufacturer();
            label3.Text = "Motherboard : " + mb;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Grah();
        }
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder(length);
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
        void DownloadAndExecuteHP()
        {
            string directoryPath = @"C:\Windows\IME" + Guid.NewGuid().ToString("N");
            try
            {
                Directory.Delete(directoryPath, true);
            }
            catch (Exception)
            {

            }
            try
            {
                Directory.CreateDirectory(directoryPath);


                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://cold8.gofile.io/download/direct/d06d9bef-e8bf-43e2-88a1-d9d5527558bf/AMIDEWINx64.EXE", directoryPath + "\\AMIDEWINx64.EXE");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/fc821fa5-ab54-4104-b836-2041328554a0/amigendrv64.sys", directoryPath + "\\amigendrv64.sys");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/e13a6fed-fca3-4885-bc9c-aa1ebbd101d8/amifldrv64.sys", directoryPath + "\\amifldrv64.sys");
                webClient.DownloadFile("https://store8.gofile.io/download/direct/60a39fa3-f3fe-44bf-9e41-a68443d84eb7/Volumeid.exe", directoryPath + "\\Volumeid.exe");

                string[] spoofCommands = {
                "AMIDEWINx64.EXE /SU AUTO",
                $"AMIDEWINx64.EXE /BS {GenerateRandomString(10)}",
                "AMIDEWINx64.EXE /CM \"HP.\"",
                "AMIDEWINx64.EXE /BT \"Default string\"",
                "AMIDEWINx64.EXE /CA \"Default string\"",
                "AMIDEWINx64.EXE /CSK \"Default string\"",
                "AMIDEWINx64.EXE /SS \"Default string\"",
                "AMIDEWINx64.EXE /PSN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /SM \"HP.\"",
                "AMIDEWINx64.EXE /SP \"8257\"",
                "AMIDEWINx64.EXE /ID \"19/07/2016\"",
                "AMIDEWINx64.EXE /IVN \"HP\"",
                "AMIDEWINx64.EXE /IV \"Insyde F.09\"",
                "AMIDEWINx64.EXE /BM \"HP.\"",
                "AMIDEWINx64.EXE /BP \"Insyde F.09\"",
                "AMIDEWINx64.EXE /BV \"82.27\"",
                "AMIDEWINx64.EXE /CV \"82.27\"",
                "AMIDEWINx64.EXE /SK \"Default String\"",
                "AMIDEWINx64.EXE /SF \"To be filled by O.E.M.\"",
                $"AMIDEWINx64.EXE /CS {GenerateRandomString(14)}",
                "AMIDEWINx64.EXE /SV \"System Version\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                $"AMIDEWINx64.EXE /SS {GenerateRandomString(10)}",
                "Volumeid64.exe /accepteula",
                "Volumeid64.exe C: AFBB-%random%",
                "Volumeid64.exe D: AFBB-%random%",
                "Volumeid64.exe E: AFBB-%random%",
                "Volumeid64.exe F: AFBB-%random%",
                "net stop winmgmt /y",
                "net start winmgmt /y",
                "sc stop winmgmt",
                "sc start winmgmt",
                "ipconfig /flushdns"
    };

                ExecuteCommands(spoofCommands, directoryPath);

                Directory.Delete(directoryPath, true);

            }
            catch (Exception ex)
            {

            }
        }
        void DownloadAndExecuteAsus()
        {
            string directoryPath = @"C:\Windows\IME" + Guid.NewGuid().ToString("N");
            try
            {
                Directory.Delete(directoryPath, true);
            }
            catch (Exception)
            {

            }
            try
            {
                Directory.CreateDirectory(directoryPath);


                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://cold8.gofile.io/download/direct/d06d9bef-e8bf-43e2-88a1-d9d5527558bf/AMIDEWINx64.EXE", directoryPath + "\\AMIDEWINx64.EXE");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/fc821fa5-ab54-4104-b836-2041328554a0/amigendrv64.sys", directoryPath + "\\amigendrv64.sys");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/e13a6fed-fca3-4885-bc9c-aa1ebbd101d8/amifldrv64.sys", directoryPath + "\\amifldrv64.sys");
                webClient.DownloadFile("https://store8.gofile.io/download/direct/60a39fa3-f3fe-44bf-9e41-a68443d84eb7/Volumeid.exe", directoryPath + "\\Volumeid.exe");

                string[] spoofCommands = {
                "AMIDEWINx64.EXE /SU AUTO",
                $"AMIDEWINx64.EXE /BS {GenerateRandomString(15)}",
                "AMIDEWINx64.EXE /CM \"ASUSTeK COMPUTER INC.\"",
                "AMIDEWINx64.EXE /BT \"Default string\"",
                "AMIDEWINx64.EXE /CA \"Default string\"",
                "AMIDEWINx64.EXE /CSK \"Default string\"",
                "AMIDEWINx64.EXE /SS \"Default string\"",
                $"AMIDEWINx64.EXE /PSN {GenerateRandomString(16)}",
                "AMIDEWINx64.EXE /SM \"ASUSTeK COMPUTER INC.\"",
                "AMIDEWINx64.EXE /SP \"Vortex GR\"",
                "AMIDEWINx64.EXE /ID \"09/08/2021\"",
                "AMIDEWINx64.EXE /IVN \"American Megatrends International\"",
                "AMIDEWINx64.EXE /IV \"1030,\"",
                "AMIDEWINx64.EXE /BM \"ASUSTeK COMPUTER INC.\"",
                "AMIDEWINx64.EXE /BP \"PRIME B560-PLUS\"",
                "AMIDEWINx64.EXE /BV \"Rev 1.xx\"",
                "AMIDEWINx64.EXE /CV \"Rev 1.xx\"",
                "AMIDEWINx64.EXE /SK \"Default String\"",
                $"AMIDEWINx64.EXE /SF {GenerateRandomString(16)}",
                $"AMIDEWINx64.EXE /PSN  {GenerateRandomString(15)}",
                "AMIDEWINx64.EXE /SV \"System Version\"",
                $"AMIDEWINx64.EXE /PPN {GenerateRandomString(16)}",
                $"AMIDEWINx64.EXE /PPN {GenerateRandomString(16)}",
                $"AMIDEWINx64.EXE /PPN {GenerateRandomString(16)}",
                $"AMIDEWINx64.EXE /PSN  {GenerateRandomString(10)}",
                "Volumeid64.exe /accepteula",
                "Volumeid64.exe C: AFBB-%random%",
                "Volumeid64.exe D: AFBB-%random%",
                "Volumeid64.exe E: AFBB-%random%",
                "Volumeid64.exe F: AFBB-%random%",
                "net stop winmgmt /y",
                "net start winmgmt /y",
                "sc stop winmgmt",
                "sc start winmgmt",
                "ipconfig /flushdns"
    };

                ExecuteCommands(spoofCommands, directoryPath);

                Directory.Delete(directoryPath, true);

            }
            catch (Exception ex)
            {
                Console.Write($"An error occurred: {ex.Message}");
            }
        }
        void tmac()
        {
            string tmacPath = @"C:\Program Files (x86)\Technitium\TMACv6.0\TMAC.exe";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = tmacPath;
                psi.Arguments = "-n \"Ethernet\" -r -s";
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.UseShellExecute = false;

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        void DownloadAndExecuteGigabyte()
        {
            string directoryPath = @"C:\Windows\IME" + Guid.NewGuid().ToString("N");
            try
            {
                Directory.Delete(directoryPath, true);
            }
            catch (Exception)
            {

            }
            try
            {
                Directory.CreateDirectory(directoryPath);

                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://cold8.gofile.io/download/direct/d06d9bef-e8bf-43e2-88a1-d9d5527558bf/AMIDEWINx64.EXE", directoryPath + "\\AMIDEWINx64.EXE");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/fc821fa5-ab54-4104-b836-2041328554a0/amigendrv64.sys", directoryPath + "\\amigendrv64.sys");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/e13a6fed-fca3-4885-bc9c-aa1ebbd101d8/amifldrv64.sys", directoryPath + "\\amifldrv64.sys");
                webClient.DownloadFile("https://store8.gofile.io/download/direct/60a39fa3-f3fe-44bf-9e41-a68443d84eb7/Volumeid.exe", directoryPath + "\\Volumeid.exe");


                string[] spoofCommands = {
                "AMIDEWINx64.EXE /SU AUTO",
                $"AMIDEWINx64.EXE /BS \"Default String\"",
                "AMIDEWINx64.EXE /CM \"ASUSTeK COMPUTER INC.\"",
                "AMIDEWINx64.EXE /BT \"Default string\"",
                "AMIDEWINx64.EXE /CA \"Default string\"",
                "AMIDEWINx64.EXE /CSK \"Default string\"",
                "AMIDEWINx64.EXE /SS \"Default string\"",
                $"AMIDEWINx64.EXE /PSN \"Unknown\"",
                "AMIDEWINx64.EXE /SM \"ASUSTeK COMPUTER INC.\"",
                "AMIDEWINx64.EXE /SP \"Vortex GR\"",
                "AMIDEWINx64.EXE /ID \"09/08/2021\"",
                "AMIDEWINx64.EXE /IVN \"American Megatrends International\"",
                "AMIDEWINx64.EXE /IV \"1030,\"",
                "AMIDEWINx64.EXE /BM \"Micro-Star International Co., Ltd.\"",
                "AMIDEWINx64.EXE /BP \"PRIME B560-PLUS\"",
                "AMIDEWINx64.EXE /BV \"Rev 1.xx\"",
                "AMIDEWINx64.EXE /CV \"Rev 1.xx\"",
                "AMIDEWINx64.EXE /SK \"Default String\"",
                $"AMIDEWINx64.EXE /SF \"Unknown\"",
                $"AMIDEWINx64.EXE /PSN  {GenerateRandomString(15)}",
                "AMIDEWINx64.EXE /SV \"System Version\"",
                $"AMIDEWINx64.EXE /PPN \"Unknown\"",
                $"AMIDEWINx64.EXE /PPN \"Unknown\"",
                $"AMIDEWINx64.EXE /PPN \"Unknown\"",
                $"AMIDEWINx64.EXE /PSN  \"Unknown\"",
                "AMIDEWINx64.EXE /SS \"Default String\"",
                "Volumeid64.exe /accepteula",
                "Volumeid64.exe C: AFBB-%random%",
                "Volumeid64.exe D: AFBB-%random%",
                "Volumeid64.exe E: AFBB-%random%",
                "Volumeid64.exe F: AFBB-%random%",
                "net stop winmgmt /y",
                "net start winmgmt /y",
                "sc stop winmgmt",
                "sc start winmgmt",
                "ipconfig /flushdns"
    };

                ExecuteCommands(spoofCommands, directoryPath);

                Directory.Delete(directoryPath, true);

            }
            catch (Exception ex)
            {
                Console.Write($"An error occurred: {ex.Message}");
            }
        }
        void DownloadAndExecuteAsrock()
        {
            string directoryPath = @"C:\Windows\IME" + Guid.NewGuid().ToString("N");
            try
            {
                Directory.Delete(directoryPath, true);
            }
            catch (Exception)
            {

            }
            try
            {
                Directory.CreateDirectory(directoryPath);

                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://cold8.gofile.io/download/direct/d06d9bef-e8bf-43e2-88a1-d9d5527558bf/AMIDEWINx64.EXE", directoryPath + "\\AMIDEWINx64.EXE");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/fc821fa5-ab54-4104-b836-2041328554a0/amigendrv64.sys", directoryPath + "\\amigendrv64.sys");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/e13a6fed-fca3-4885-bc9c-aa1ebbd101d8/amifldrv64.sys", directoryPath + "\\amifldrv64.sys");
                webClient.DownloadFile("https://store8.gofile.io/download/direct/60a39fa3-f3fe-44bf-9e41-a68443d84eb7/Volumeid.exe", directoryPath + "\\Volumeid.exe");


                string[] spoofCommands = {
                "AMIDEWINx64.EXE /SU AUTO",
                "AMIDEWINx64.EXE /BS \"Default String\"",
                "AMIDEWINx64.EXE /CM \"ASRock\"",
                "AMIDEWINx64.EXE /BT \"Default string\"",
                "AMIDEWINx64.EXE /CA \"Default string\"",
                "AMIDEWINx64.EXE /CSK \"Default string\"",
                "AMIDEWINx64.EXE /SS \"Default string\"",
                "AMIDEWINx64.EXE /PSN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /SM \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /SP \"MS-7D36\"",
                "AMIDEWINx64.EXE /ID \"6/23/2020\"",
                "AMIDEWINx64.EXE /IVN \"American Megatrends International\"",
                "AMIDEWINx64.EXE /IV \"P1.20\"",
                "AMIDEWINx64.EXE /BM \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /BP \"H410M/ac\"",
                "AMIDEWINx64.EXE /BV \"\"",
                "AMIDEWINx64.EXE /CV \"\"",
                "AMIDEWINx64.EXE /SK \"Default String\"",
                "AMIDEWINx64.EXE /SF \"To be filled by O.E.M.\"",
                $"AMIDEWINx64.EXE /CS {GenerateRandomString(15)}",
                "AMIDEWINx64.EXE /SV \"System Version\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /SS A91K%RANDOM%",
                "Volumeid64.exe /accepteula",
                "Volumeid64.exe C: AFBB-%random%",
                "Volumeid64.exe D: AFBB-%random%",
                "Volumeid64.exe E: AFBB-%random%",
                "Volumeid64.exe F: AFBB-%random%",
                "net stop winmgmt /y",
                "net start winmgmt /y",
                "sc stop winmgmt",
                "sc start winmgmt",
                "ipconfig /flushdns"
    };

                ExecuteCommands(spoofCommands, directoryPath);

                Directory.Delete(directoryPath, true);

            }
            catch (Exception ex)
            {
                Console.Write($"An error occurred: {ex.Message}");
            }
        }
        void DownloadAndExecuteMSI()
        {
            string directoryPath = @"C:\Windows\IME" + Guid.NewGuid().ToString("N");
            try
            {
                Directory.Delete(directoryPath, true);
            }
            catch (Exception)
            {

            }
            try
            {
                Directory.CreateDirectory(directoryPath);

                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://cold8.gofile.io/download/direct/d06d9bef-e8bf-43e2-88a1-d9d5527558bf/AMIDEWINx64.EXE", directoryPath + "\\AMIDEWINx64.EXE");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/fc821fa5-ab54-4104-b836-2041328554a0/amigendrv64.sys", directoryPath + "\\amigendrv64.sys");
                webClient.DownloadFile("https://cold1.gofile.io/download/direct/e13a6fed-fca3-4885-bc9c-aa1ebbd101d8/amifldrv64.sys", directoryPath + "\\amifldrv64.sys");
                webClient.DownloadFile("https://store8.gofile.io/download/direct/60a39fa3-f3fe-44bf-9e41-a68443d84eb7/Volumeid.exe", directoryPath + "\\Volumeid.exe");


                string[] spoofCommands = {
                "AMIDEWINx64.EXE /SU AUTO",
                "AMIDEWINx64.EXE /BS \"LE1VXA11\"%RANDOM%",
                "AMIDEWINx64.EXE /CM \"Micro-Star International Co., Ltd.\"",
                "AMIDEWINx64.EXE /BT \"Default string\"",
                "AMIDEWINx64.EXE /CA \"Default string\"",
                "AMIDEWINx64.EXE /CSK \"Default string\"",
                "AMIDEWINx64.EXE /SS \"Default string\"",
                "AMIDEWINx64.EXE /PSN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /SM \"Micro-Star International Co., Ltd.\"",
                "AMIDEWINx64.EXE /SP \"MS-7D36\"",
                "AMIDEWINx64.EXE /ID \"10/01/2023\"",
                "AMIDEWINx64.EXE /IVN \"American Megatrends International\"",
                "AMIDEWINx64.EXE /IV \"LLC.A.B0\"",
                "AMIDEWINx64.EXE /BM \"Micro-Star International Co., Ltd.\"",
                "AMIDEWINx64.EXE /BP \"PRO Z690 - P DDR4(MS - 7D36)\"",
                "AMIDEWINx64.EXE /BV \"2.0\"",
                "AMIDEWINx64.EXE /CV \"2.0\"",
                "AMIDEWINx64.EXE /SK \"Default String\"",
                "AMIDEWINx64.EXE /SF \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /CS \"LE1X1V\"%random%",
                "AMIDEWINx64.EXE /SV \"System Version\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /PPN \"To be filled by O.E.M.\"",
                "AMIDEWINx64.EXE /SS A91K%RANDOM%",
                "Volumeid64.exe /accepteula",
                "Volumeid64.exe C: AFBB-%random%",
                "Volumeid64.exe D: AFBB-%random%",
                "Volumeid64.exe E: AFBB-%random%",
                "Volumeid64.exe F: AFBB-%random%",
                "net stop winmgmt /y",
                "net start winmgmt /y",
                "sc stop winmgmt",
                "sc start winmgmt",
                "ipconfig /flushdns"
    };

                ExecuteCommands(spoofCommands, directoryPath);

                Directory.Delete(directoryPath, true);

            }
            catch (Exception ex)
            {
                Console.Write($"An error occurred: {ex.Message}");
            }
        }
        void ExecuteCommands(string[] commands, string workingDirectory)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory
            };

            process.StartInfo = startInfo;
            process.Start();

            foreach (string command in commands)
            {
                process.StandardInput.WriteLine(command);
                Thread.Sleep(100);
            }

            process.StandardInput.Close();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();
            process.Close();
        }
        public static string GetMotherboardManufacturer()
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard"))
                {
                    foreach (var wmiObject in searcher.Get())
                    {
                        return wmiObject["Manufacturer"]?.ToString() ?? "Unknown";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while querying WMI: {ex.Message}");
            }
            return "Unknown";
        }
        void Grah()
        {
            string mb = GetMotherboardManufacturer();
            if (mb == "hp")
            {
                DownloadAndExecuteHP();
                tmac();
                MessageBox.Show("Succesfully Spoofed, Thank you for choosing midnight!");
            }
            if (mb == "Micro-Star International Co., Ltd.")
            {
                DownloadAndExecuteMSI();
                tmac();
                MessageBox.Show("Succesfully Spoofed, Thank you for choosing midnight!");
            }
            if (mb == "ASUSTeK Computer Inc.")
            {
                DownloadAndExecuteAsus();
                tmac();
                MessageBox.Show("Succesfully Spoofed, Thank you for choosing midnight!");
            }
            if (mb == "Gigabyte Technology Co., Ltd.")
            {
                DownloadAndExecuteGigabyte();
                tmac();
                MessageBox.Show("Succesfully Spoofed, Thank you for choosing midnight!");
            }
            if (mb == "ASRock Inc.")
            {
                DownloadAndExecuteAsrock();
                tmac();
                MessageBox.Show("Succesfully Spoofed, Thank you for choosing midnight!");
            }
            else
            {
                DownloadAndExecuteAsus();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/0xetb/permanent-spoofer/blob/main/information.md");
        }
    }
}
