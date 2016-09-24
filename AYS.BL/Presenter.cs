using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace AYS.BL
{
    public class Presenter
    {
        IMainForm View;

        public Presenter(IMainForm View)
        {
            this.View = View;

            View.FormLoad += View_FormLoad;

        }

        private void View_FormLoad(object sender, EventArgs e)
        {
            View.system = "OS - " + Environment.OSVersion.ToString();
            View.system = "Machine Name - " + Environment.MachineName;
            View.system = "Count of Processors - " + Environment.ProcessorCount;

            DriveInfo[] drives = DriveInfo.GetDrives();
            ManagementObjectSearcher searcher =new ManagementObjectSearcher("root\\CIMV2",
    "SELECT * FROM Win32_DiskDrive");



            foreach (ManagementObject queryObj in searcher.Get())
            {
                
                View.drives="Disk Drive: "+queryObj["Model"]+"Size: "+
                Math.Round(Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2)+" GB";

            }

            for (int i = 0; i < drives.Length; i++)
            {
                View.drives = drives[i].Name+" [Capacity: "+drives[i].TotalSize/1024/1024/1024+" GB; "+"Free Space: "+
                    drives[i].TotalFreeSpace/1024/1024/1024+" GB; "+"File System: "+drives[i].DriveFormat+"; Drive Type: "+drives[i].DriveType+"]";
            }
             searcher = new ManagementObjectSearcher
                ("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                View.VideoAdapter = "AdapterRAM: " + queryObj["AdapterRAM"];
                View.VideoAdapter = "Caption: " + queryObj["Caption"];
                View.VideoAdapter = "Description: " + queryObj["Description"];
                View.VideoAdapter = "VideoProcessor: " + queryObj["VideoProcessor"];
            }

            searcher = new ManagementObjectSearcher
                ("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                View.Processor = "Name: " + queryObj["Name"];
                View.Processor = "NumberOfCores: "+queryObj["NumberOfCores"];
                View.Processor = "ProcessorId: "+queryObj["ProcessorId"];
                View.Processor = "Maximum Clock Speed: " + queryObj["MaxClockSpeed"]+" MHz";
                View.Processor = "Description: " + queryObj["Description"];

            }
            searcher = new ManagementObjectSearcher("root\\CIMV2", 
    "SELECT * FROM Win32_PhysicalMemory");

            foreach(ManagementObject queryObj in searcher.Get())
            {
                View.RAM = "Bank Label: " +queryObj["BankLabel"]+" Capacity: " + (Convert.ToInt64(queryObj["Capacity"])/1024/1024/1024)+" GB";
            }

            searcher =
            new ManagementObjectSearcher(
                "SELECT * FROM Win32_DesktopMonitor");

            foreach (ManagementObject service in searcher.Get())
            {
                View.RAM=""+service["Description"];
            }
            searcher =
           new ManagementObjectSearcher(
               "SELECT * FROM Win32_NetworkAdapter");

            foreach(ManagementObject servise in searcher.Get())
            {
                View.NetworkAdapter = "Name: " + servise["Name"]+" "+
                    servise["AdapterType"];
            }

            searcher =
          new ManagementObjectSearcher(
              "SELECT * FROM Win32_DesktopMonitor");

            foreach (ManagementObject servise in searcher.Get())
            {
                View.Monitor = "Screen Width: "+servise["ScreenWidth"]+"; "+"Screen Height: " + servise["ScreenHeight"];
            }
        }
    }
}
