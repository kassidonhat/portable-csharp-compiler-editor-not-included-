


namespace Debug.Models
{
    
    public class TabModel
    {

        //For ButtonDef
        required public List<string> HomeRibbons { get; set; }
        required public string TabDisplayName { get; set; }
        required public string TabInternalName { get; set; }
        required public List<PanModel> Panels { get; set; }


        public TabModel(List<TabModel> TabModelList)
        {
            TabModelList.Add(this);
        }

         
        
    }


}