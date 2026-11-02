using Inventor;
using System.Runtime.InteropServices;
// using System.Runtime.InteropServices;
using Debug.Models;
using System;
using System.Threading.Tasks;


namespace Debug
{
    internal static class DebugBackEndLogicFunctions
    {


        static public void TestIfDebugLoaded(
            // Inventor.NameValueMap Context
            )
        {


            AppendLog("DebugLoaded");


           

        }


        static public void TestingFunc()
        {              


        }






        public static System.Windows.Forms.Form DebugConsoleHolder = new System.Windows.Forms.Form();
        public static System.Windows.Forms.RichTextBox DebugConsole = new System.Windows.Forms.RichTextBox();
        public static DockableWindow DebugDock = AddInServer._inventor.UserInterfaceManager.DockableWindows.Add(Guid.NewGuid().ToString(), "DebugDockWindow", "Debug Console");
        public static bool firstLogRun = true;
        static public void ShowDebugConsole()
        {

            if (!firstLogRun)
            {
                DebugDock.Visible = true;
        
            }
            

            if(firstLogRun){
                firstLogRun = false;
                DebugConsoleHolder.Controls.Add(DebugConsole);
                DebugConsole.Text="";
                DebugConsole.Multiline = true;
                DebugConsole.Anchor = System.Windows.Forms.AnchorStyles.Top | 
                                        System.Windows.Forms.AnchorStyles.Bottom | 
                                        System.Windows.Forms.AnchorStyles.Left | 
                                        System.Windows.Forms.AnchorStyles.Right;

                DebugConsole.Visible = true;
                DebugConsole.Size = DebugConsoleHolder.Size;
                DebugConsoleHolder.Show(); 
                DebugDock.AddChild(DebugConsoleHolder.Handle);
                DebugDock.Visible = true;
            }


        }   


        public static string LogPreOpenStorage = "";

        public static void AppendLog(string message)
        {

            if (!firstLogRun)
            {
                if (LogPreOpenStorage != "")
                {
                    DebugConsole.AppendText($"{LogPreOpenStorage}");
                    DebugConsole.AppendText("\n");
                    LogPreOpenStorage="";
                }


                DebugConsole.AppendText($"{message}");
                DebugConsole.AppendText("\n");
            }


            if (firstLogRun)
            {
                LogPreOpenStorage = $"{LogPreOpenStorage}{message}\n";
            }
        }




        public static void ClearLog()
        {
            try{
            DebugConsole.Text = "";
            
            
            } 
            catch (Exception ex)
            {System.Windows.Forms.MessageBox.Show(ex.ToString());}
        }




    }

}
