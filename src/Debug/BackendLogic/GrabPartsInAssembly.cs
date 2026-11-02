using Inventor;
using System.Runtime.InteropServices;
using Debug.Models;
using System;
using System.Threading.Tasks;


namespace Debug
{
    internal static class GrabPartsInAssembly
    {

        static public void CreateGrabPartsInAssemblyWindow()
        {              
        
            List<String> NewPartList = new List<String>();

            System.Windows.Forms.Form  LocatePartsHolder = new System.Windows.Forms.Form();
            LocatePartsHolder.Text = "Locate Parts";
            LocatePartsHolder.Show();

            System.Windows.Forms.TableLayoutPanel  LocatePartsTable = new System.Windows.Forms.TableLayoutPanel();
            LocatePartsHolder.Controls.Add(LocatePartsTable);
            LocatePartsTable.Visible = true;
            LocatePartsTable.AutoSize = true;
            LocatePartsTable.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LocatePartsTable.Dock = DockStyle.Fill;




            System.Windows.Forms.TextBox DisplayCurrentFilter = new System.Windows.Forms.TextBox();
            LocatePartsTable.Controls.Add(DisplayCurrentFilter);
            DisplayCurrentFilter.AutoSize = true;
            DisplayCurrentFilter.Anchor =System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DisplayCurrentFilter.Multiline = true;
            DisplayCurrentFilter.ScrollBars = ScrollBars.Vertical;
            DisplayCurrentFilter.Dock = DockStyle.Fill;
            DisplayCurrentFilter.Visible = true;

            

            System.Windows.Forms.TextBox NewPart = new System.Windows.Forms.TextBox();
            LocatePartsTable.Controls.Add(NewPart);
            NewPart.AutoSize = true;
            NewPart.Anchor =System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            NewPart.Visible = true;
            NewPart.Dock = DockStyle.Fill;


            Button AppendNewPartToTheFilter = new Button();
            LocatePartsTable.Controls.Add(AppendNewPartToTheFilter); 
            AppendNewPartToTheFilter.Text = "Append";
            AppendNewPartToTheFilter.AutoSize = true;
            AppendNewPartToTheFilter.Anchor =System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AppendNewPartToTheFilter.Visible = true;
            AppendNewPartToTheFilter.Click += (sender, e) => AppendNewPartToTheFilterFunc(sender, e,NewPartList,NewPart.Text,DisplayCurrentFilter);


            Button SelectPartsContainedInFilter = new Button();
            LocatePartsTable.Controls.Add(SelectPartsContainedInFilter); 
            SelectPartsContainedInFilter.Text = "Select Parts";
            SelectPartsContainedInFilter.AutoSize = true;
            SelectPartsContainedInFilter.Anchor =System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            SelectPartsContainedInFilter.Visible = true;
            SelectPartsContainedInFilter.Click += (sender, e) => SelectPartsContainedInFilterFunc(sender, e,NewPartList);


     
        }



        static public void AppendNewPartToTheFilterFunc(object? sender, System.EventArgs e,List<String> NewPartList,String NewPart,System.Windows.Forms.TextBox DisplayCurrentFilter)
        {
            NewPartList.Add(NewPart);
            DisplayCurrentFilter.Text = $"{DisplayCurrentFilter.Text}, {NewPart}";
        }


        static public void SelectPartsContainedInFilterFunc(object? sender, System.EventArgs e,List<String> NewPartList)
        {
            AssemblyDocument doc = (AssemblyDocument)AddInServer._inventor.ActiveDocument;
            ComponentOccurrences PartColl =doc.ComponentDefinition.Occurrences;

            SelectSet oSelectedObjects = doc.SelectSet;

            foreach(String PartNumber in NewPartList)
            {
                foreach (ComponentOccurrence PartVar in PartColl)
                {
                    if (PartVar.Name.Contains(PartNumber))
                    {
                        oSelectedObjects.Select(PartVar);
                    }
                }
            }
        }


       




    }

}
