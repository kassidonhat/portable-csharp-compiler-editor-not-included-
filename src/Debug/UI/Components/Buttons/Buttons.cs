using Debug.Models;
using Inventor;


namespace Debug
{
    


    
    internal class ButtonsUsed
    {

        static public List<ButtonDefModel> ButtonsUsedList = new List<ButtonDefModel>();
        
        static public ButtonDefModel TestButton = new ButtonDefModel(ButtonsUsedList){
                                                                                    ButtonDisplayName= "TestButton",
                                                                                    ButtonInternalName = "TestButtonInter",
                                                                                    CommandTypesEnumUsed = CommandTypesEnum.kNonShapeEditCmdType,
                                                                                    ButtonDescription = "test",
                                                                                    ButtonToolTip = "test",
                                                                                    ButtonFunc = DebugBackEndLogicFunctions.TestIfDebugLoaded
                                                                                };
        static public ButtonDefModel ConsoleButton = new ButtonDefModel(ButtonsUsedList){
                                                                                    ButtonDisplayName= "ConsoleButton",
                                                                                    ButtonInternalName = "ConsoleButtonInter",
                                                                                    CommandTypesEnumUsed = CommandTypesEnum.kNonShapeEditCmdType,
                                                                                    ButtonDescription = "Opens Console",
                                                                                    ButtonToolTip = "Opens Console",
                                                                                    ButtonFunc = DebugBackEndLogicFunctions.ShowDebugConsole
                                                                                };
        static public ButtonDefModel TestButton2 = new ButtonDefModel(ButtonsUsedList){
                                                                                    ButtonDisplayName= "Testing Func Button",
                                                                                    ButtonInternalName = "TestingFuncButton",
                                                                                    CommandTypesEnumUsed = CommandTypesEnum.kShapeEditCmdType,
                                                                                    ButtonDescription = "Test The Function Currently Attached",
                                                                                    ButtonToolTip = "Test The Function Currently Attached",
                                                                                    ButtonFunc = DebugBackEndLogicFunctions.TestingFunc
                                                                                };
        static public ButtonDefModel ClearConsoleButton = new ButtonDefModel(ButtonsUsedList){
                                                                                    ButtonDisplayName= "Clear Console",
                                                                                    ButtonInternalName = "ClearConsoleButton",
                                                                                    CommandTypesEnumUsed = CommandTypesEnum.kShapeEditCmdType,
                                                                                    ButtonDescription = "Clear The Console",
                                                                                    ButtonToolTip = "Clear The Console",
                                                                                    ButtonFunc = DebugBackEndLogicFunctions.ClearLog
                                                                                };
        static public ButtonDefModel CreateAdjustFontSizeWindowButton = new ButtonDefModel(ButtonsUsedList){
                                                                                    ButtonDisplayName= "Adjust Font Size",
                                                                                    ButtonInternalName = "CreateAdjustFontSizeWindowButton",
                                                                                    CommandTypesEnumUsed = CommandTypesEnum.kShapeEditCmdType,
                                                                                    ButtonDescription = "Adjust Font Size",
                                                                                    ButtonToolTip = "Adjust Font Size",
                                                                                    ButtonFunc = AdjustFontSize.CreateAdjustFontSizeWindow
                                                                                };

        static public ButtonDefModel GrabPartsInAssemblyButton = new ButtonDefModel(ButtonsUsedList){
                                                                                    ButtonDisplayName= "Grab Parts",
                                                                                    ButtonInternalName = "GrabPartsInAssemblyButton",
                                                                                    CommandTypesEnumUsed = CommandTypesEnum.kShapeEditCmdType,
                                                                                    ButtonDescription = "Grab Parts In Assembly Based On A Filter",
                                                                                    ButtonToolTip = "Grab Parts In Assembly Based On A Filter",
                                                                                    ButtonFunc = GrabPartsInAssembly.CreateGrabPartsInAssemblyWindow
                                                                                };

        
 }


}