using Inventor;
using System.Runtime.InteropServices;
using Debug.Models;
using System;
using System.Threading.Tasks;


namespace Debug
{
    internal static class AdjustFontSize
    {

        static public void CreateAdjustFontSizeWindow()
        {              
        
            System.Windows.Forms.Form  ChooseStyleHolder = new System.Windows.Forms.Form();
            ChooseStyleHolder.Text = "Type In New Size";
            ChooseStyleHolder.Show();


            System.Windows.Forms.FlowLayoutPanel  ChooseStyleFlow = new System.Windows.Forms.FlowLayoutPanel();
            ChooseStyleHolder.Controls.Add(ChooseStyleFlow);
            ChooseStyleFlow.Visible = true;
            ChooseStyleFlow.FlowDirection = FlowDirection.TopDown | FlowDirection.BottomUp| FlowDirection.LeftToRight| FlowDirection.RightToLeft;


            System.Windows.Forms.TextBox NewFontSize = new System.Windows.Forms.TextBox();
            ChooseStyleFlow.Controls.Add(NewFontSize);
            NewFontSize.Visible = true;


            Button AdjustFontButton = new Button();
            ChooseStyleFlow.Controls.Add(AdjustFontButton); 
            AdjustFontButton.Text = "Change Style";
            AdjustFontButton.AutoSize = true;
            AdjustFontButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AdjustFontButton.Visible = true;
            AdjustFontButton.Click += (sender, e) => AdjustFontButtonFunc(sender, e,NewFontSize);



     
        }

        static public void AdjustFontButtonFunc(object? sender, System.EventArgs e,System.Windows.Forms.TextBox NewFontSize)
        {
            DrawingDocument doc = (DrawingDocument)AddInServer._inventor.ActiveDocument;

            if (doc.SelectSet.Count >= 1)
            {
                SelectSet oSelectedObjects = doc.SelectSet;
                Inventor.TextBox TextBoxVar = (Inventor.TextBox)oSelectedObjects[1];
                string NewFormattedText = $"<StyleOverride Font='Roboto Black' FontSize='{NewFontSize.Text}'>{TextBoxVar.Text}</StyleOverride>";
                TextBoxVar.FormattedText = NewFormattedText;
            }
        }



       




    }

}
