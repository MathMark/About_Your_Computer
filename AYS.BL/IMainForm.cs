using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYS.BL
{
    public interface IMainForm
    {
        event EventHandler FormLoad;
        string VideoAdapter { set; }
        string system {  set; }
        string drives { set; }
        string Processor { set; }
    }
}
