using Inventor;
using System.Runtime.InteropServices;
using Debug;
using System;
using Debug.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Collections.Immutable;


namespace Debug
{
    internal class DebugTextUIClass
    {

		// intro variables

        private RibbonTab? ribbonTab;
        private RibbonPanel? ribbonPanel;
    	public ButtonDefinition? buttonDef;
		private ButtonDefModel? ButtonHolder;
		public static Dictionary<string,ButtonDefinition> SubmittedButtons = new Dictionary<string,ButtonDefinition>();

		public void GenerateUI(bool firstTime)
		{

			if(firstTime){
				CreateButtons();

				foreach(TabModel TabModelVar in TabsUsed.TabsUsedList)
				{
					createTabs(TabModelVar);
				}
			}
		}



		private void createTabs(TabModel TabVar)
		{
			
			//for every mode we use this tab in
            foreach (string ribbVar in TabVar.HomeRibbons)
			{


				Ribbon ribbon = AddInServer._inventor.UserInterfaceManager.Ribbons[ribbVar]; 


				//Is the tab registered?
				ribbonTab = null;
				foreach (RibbonTab tab in ribbon.RibbonTabs)
				{
					if (tab.DisplayName == TabVar.TabDisplayName)
					{
						ribbonTab = tab;
						break;
					}
				}


				//if not register
				if (ribbonTab == null)
				{
					string tab_client_ID = Guid.NewGuid().ToString();
					ribbonTab = ribbon.RibbonTabs.Add($"{TabVar.TabDisplayName}", $"{TabVar.TabInternalName}{ribbVar}", tab_client_ID);

				}




				
				//create all of the panels
				foreach(PanModel panelVar in TabVar.Panels)
				{
					string panel_client_ID = Guid.NewGuid().ToString();
					ribbonPanel = ribbonTab.RibbonPanels.Add(panelVar.PanelDisplayName,
																	panelVar.PanelInternalName,
																	panel_client_ID);


					//Add the buttons in the panel to the panel
					foreach(ButtonDefModel buttonVar in panelVar.Buttons){

						

						try{
							ribbonPanel.CommandControls.AddButton(SubmittedButtons[buttonVar.ButtonDisplayName]);
						}catch (Exception ex){System.Windows.Forms.MessageBox.Show(ex.ToString());}
	
					}
				}
			}
		}



		private void CreateButtons()
		{

			foreach(ButtonDefModel buttonVar in ButtonsUsed.ButtonsUsedList){
				

				string button_client_ID = Guid.NewGuid().ToString();
				buttonDef = AddInServer._inventor.CommandManager.ControlDefinitions.AddButtonDefinition(buttonVar.ButtonDisplayName,
																										buttonVar.ButtonInternalName,
																										buttonVar.CommandTypesEnumUsed,
																										button_client_ID,
																										buttonVar.ButtonDescription,
																										buttonVar.ButtonToolTip);
				ButtonHolder = buttonVar;
				buttonDef.OnExecute  += (NameValueMap context) => buttonVar.ButtonFunc();

				
				try{SubmittedButtons.Add(buttonVar.ButtonDisplayName,buttonDef);}
				catch (Exception ex){System.Windows.Forms.MessageBox.Show(ex.ToString());}
			}


		}


		// private void ButtonInfoSender(NameValueMap Context)
        // {
        //     ButtonHolder.ButtonFunc(AddInServer._inventor);
        // }






    }

}
