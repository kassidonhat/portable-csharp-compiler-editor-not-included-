using Inventor;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;



namespace Debug
{
    // [ComVisible(true)]
    [Guid("3d829332-8e28-4068-b645-d69bea49a93e")]

    // this part is apparently necessary in all add ins
    public class AddInServer : ApplicationAddInServer
    {

		#region This is the data
		
        public static Inventor.Application? _inventor;





        //custom Classes
        private DebugTextUIClass UIObj = new DebugTextUIClass();
        // private DebugBackEndLogicFunctions BackFuncObj = new DebugBackEndLogicFunctions();
        

        #endregion

        // this runs on load (firstTime is for if there is first time setup to be done)
        public void Activate(ApplicationAddInSite addInSiteObject, bool firstTime)
        {
            try
            {
                //initialize AddIn members
                _inventor = addInSiteObject.Application;
                // System.Windows.Forms.MessageBox.Show("debug loaded","My Inventor Add-in");
                UIObj.GenerateUI(firstTime);
            }     

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                Clipboard.SetText(ex.ToString());
                return;
            }                     

        }


        public void Deactivate()
        {
            _inventor = null;
        }

        public void ExecuteCommand(int commandID)
        {
        }

        public object Automation
        {
            get
            {
                // TODO: Add ApplicationAddInServer.Automation getter implementation
                return null;
            }
        }
    }
}