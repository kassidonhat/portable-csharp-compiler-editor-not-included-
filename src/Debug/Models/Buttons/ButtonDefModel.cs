
using Inventor;


namespace Debug.Models
{
    
    public class ButtonDefModel
    {
        
        //For ButtonDef
        required public string ButtonDisplayName { get; set; }
        required public string ButtonInternalName { get; set; }
        required public CommandTypesEnum CommandTypesEnumUsed { get; set; }
        required public string ButtonDescription { get; set; }
        required public string ButtonToolTip { get; set; }
        // required public Action<Inventor.Application> ButtonFunc { get; set; }
        required public Action ButtonFunc { get; set; }
       
        public ButtonDefModel(List<ButtonDefModel> ButtonList)
        {
            ButtonList.Add(this);
        }

            
    }


}