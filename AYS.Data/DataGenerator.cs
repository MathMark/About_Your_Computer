using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AYS.Data
{
    public class DataGenerator //: ISystem
    {
        DriveInfo[] drives;
        public DataGenerator()
        {
            drives = DriveInfo.GetDrives();
        }
        public string[] GetDrives()
        {
            string[] driveNames=new string[drives.Length];
            
            for(int i=0;i<drives.Length;i++)
            {
                driveNames[i] = drives[i].Name;
            }
            return driveNames;
        }

       // public string[] GetInformationAboutDrive(string driveName)
      //  {
           // string Information;
           // return "Name: "+drives.+""
        //}
    }
}
