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

            for (int i = 0; i < drives.Length; i++)
            {
                View.drives = drives[i].Name+" [Capacity: "+drives[i].TotalSize/1024/1024/1024+" GB; "+"Free Space: "+
                    drives[i].TotalFreeSpace/1024/1024/1024+" GB; "+"File System: "+drives[i].DriveFormat+"; Drive Type: "+drives[i].DriveType+"]";
            }
            ManagementObjectSearcher searcher11 = new ManagementObjectSearcher
                ("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher11.Get())
            {
                View.VideoAdapter = "AdapterRAM: " + queryObj["AdapterRAM"];
                View.VideoAdapter = "Caption: " + queryObj["Caption"];
                View.VideoAdapter = "Description: " + queryObj["Description"];
                View.VideoAdapter = "VideoProcessor: " + queryObj["VideoProcessor"];
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                ("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                View.Processor = "Name: " + queryObj["Name"];
                View.Processor = "NumberOfCores: "+queryObj["NumberOfCores"];
                View.Processor = "ProcessorId: "+queryObj["ProcessorId"];

            }
            searcher = new ManagementObjectSearcher("root\\CIMV2", 
    "SELECT * FROM Win32_PhysicalMemory");

            foreach(ManagementObject queryObj in searcher.Get())
            {
                View.RAM = "Bank Label: " +queryObj["BankLabel"]+" Capacity: " + (Convert.ToInt64(queryObj["Capacity"])/1024/1024/1024)+" GB";
            }
        }
    }
}
