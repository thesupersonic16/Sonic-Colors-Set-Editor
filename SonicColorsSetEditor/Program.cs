using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicColorsSetEditor
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new MainForm();
            // e.g. SonicColorsSetEditor /c /o stg110_obj_00.orc /so 30
            if (args.Length > 0)
            {
                int argIndex = 0;
                while (argIndex < args.Length)
                    switch (args[argIndex++].ToLower())
                    {
                        case "/?":
                            ShowHelp();
                            break;
                        case "/c":
                            CreateConsole();
                            break;
                        case "/o":
                            if (args.Length > argIndex)
                                form.OpenSetData(args[argIndex++]);
                            break;
                        case "/debug":
                            form.debugToolStripMenuItem.Visible = true;
                            break;
                        case "/so":
                            if (form.SetData == null)
                            {
                                MessageBox.Show("You can not select a SetObject without an opened SetData");
                                return;
                            }
                            if (args.Length > argIndex)
                            {
                                try
                                {
                                    int id = int.Parse(args[argIndex++]);
                                    form.SelectSetObject(form.SetData.Objects.Find(t => t.ObjectID == id));
                                }
                                catch
                                {
                                    return;
                                }
                            }
                            break;
                        default:
                            break;
                    }
            }
            Console.WriteLine("Done With Arguments!");
            if (!MainForm.HasBeenInit)
                form.Init();
            Application.Run(form);
            FreeConsole();
        }

        public static void ShowHelp()
        {
            MessageBox.Show("Command-line Arguments:" + Environment.NewLine + Environment.NewLine +
                    "/O {filepath to .orc/xml}" + Environment.NewLine +
                    "\t (Opens the SetData.)" +
                    Environment.NewLine +

                    "/SO {ID} " + Environment.NewLine +
                    "\t (Selects the SetObject, /O is required for this to work)" +
                    Environment.NewLine +

                    "/C " + Environment.NewLine +
                    "\t (Opens a Console Window)" +
                    Environment.NewLine +

                    "/?" + Environment.NewLine +
                    "\t (Shows this help.)",

                    MainForm.ProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void CreateConsole()
        {
            try
            {
                AllocConsole();
                int TextLength = MainForm.ProgramName.Length + 2;
                int ConsoleWidth = Console.BufferWidth;
                string s = "\n";
                s += new string('=', (ConsoleWidth - TextLength) / 2);
                s += $" {MainForm.ProgramName} ";
                s += new string('=', (ConsoleWidth - TextLength) / 2);
                Console.WriteLine(s);
            }
            catch
            {
                FreeConsole();
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FreeConsole();
        
    }
}
