using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Data
{
    interface ISystem
    {
        string[] GetDrives();
        string[] GetInformationAboutDrive(string drive);
    }
}
