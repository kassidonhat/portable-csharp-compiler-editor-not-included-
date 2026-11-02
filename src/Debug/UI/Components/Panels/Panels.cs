using Debug.Models;


namespace Debug
{
    
    internal class PanelsUsed
    {

            
        static readonly public PanModel DebugPanel = new PanModel{
                                                                    PanelDisplayName= "DebugNative",
                                                                    PanelInternalName = "DebugNativePanel",
                                                                    Buttons = [ButtonsUsed.TestButton,ButtonsUsed.ConsoleButton,ButtonsUsed.ClearConsoleButton]
                                                                };

            
        static readonly public PanModel TestingPanel = new PanModel{
                                                                    PanelDisplayName= "Testing",
                                                                    PanelInternalName = "TestingPanel",
                                                                    Buttons = [ButtonsUsed.TestButton2]
                                                                };

        static readonly public PanModel CustomDrawingSketchPanel = new PanModel{
                                                                    PanelDisplayName= "Custom Drawing Sketch Tools",
                                                                    PanelInternalName = "CustomDrawingSketchPanel",
                                                                    Buttons = [ButtonsUsed.CreateAdjustFontSizeWindowButton]
                                                                };
        static readonly public PanModel CustomAssemblyPanel = new PanModel{
                                                                    PanelDisplayName= "Custom Assembly Tools",
                                                                    PanelInternalName = "CustomAssemblyPanel",
                                                                    Buttons = [ButtonsUsed.GrabPartsInAssemblyButton]
                                                                };


    }


}