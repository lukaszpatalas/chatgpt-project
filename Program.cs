// Setting up Windows Forms application that displays a graphical user interface (GUI) 
// with custom visual styles and text rendering that is compatible with modern operating systems.

using System;
using System.Windows.Forms;

namespace EducationalTool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}
