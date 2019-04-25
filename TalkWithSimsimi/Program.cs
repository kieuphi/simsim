using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace TalkWithSimsimi
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.Title = "Chat with Simsimi!";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Control ctrl = new Control();
            Console.Write("hello ae \n");
            while (true)
            {
                ctrl.CONTROL();
                //Console.ReadKey();
            }

        }

    }
}
