using Debug.Models;


namespace Debug
{
    
    internal class TabsUsed
    {
        

        public static List<TabModel> TabsUsedList = new List<TabModel>();
        
         
        static public TabModel DebugTab = new TabModel(TabsUsedList){
                                                                        HomeRibbons = ["Drawing","Assembly"],
                                                                        TabDisplayName = "Debugging",
                                                                        TabInternalName = "DebuggingTab",
                                                                        Panels = [PanelsUsed.DebugPanel,PanelsUsed.TestingPanel]

                                                                    };

        static public TabModel CustomDrawingTab = new TabModel(TabsUsedList){
                                                                        HomeRibbons = ["Drawing"],
                                                                        TabDisplayName = "Custom Drawing",
                                                                        TabInternalName = "CustomDrawingTab",
                                                                        Panels = [PanelsUsed.CustomDrawingSketchPanel]

                                                                    };



        static public TabModel CustomAssemblyTab = new TabModel(TabsUsedList){
                                                                        HomeRibbons = ["Assembly"],
                                                                        TabDisplayName = "Custom Assembly",
                                                                        TabInternalName = "CustomAssemblyTab",
                                                                        Panels = [PanelsUsed.CustomAssemblyPanel]

                                                                    };





    }


}