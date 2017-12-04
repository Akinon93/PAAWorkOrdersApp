/********************
 * November 29, 2017 - Created
 * November 30, 2017 - Updated
 * 
 * A basic class used to create the tabs for our Work Order forms.
 ********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PAAWorkOrdersApp{

    class AccTab{
        
        public ComboBox nameBox;
        public TextBox numBox;
        public TextBox serialBox;
        public ComboBox processBox;
        public RichTextBox remarksBox;
        public int tabNum;

        public TabPage ThePage = new TabPage("Add+");
        private TabControl tab_control;

        //Create the discription labels for our new tabs
        public void DisplayLabelNames(){

            //Set our temporary label variables
            Label pName = new Label();
            Label pNum = new Label();
            Label pSerial = new Label();
            Label process = new Label();
            Label remarks = new Label();

            //pName first
            pName.Location = new Point(37, 38);
            pName.AutoSize = true;
            pName.Text = "Part Name:";
            pName.Font = new Font("Verdana", 14.25f, FontStyle.Bold);

            //pNum second
            pNum.Location = new Point(37, 100);
            pNum.AutoSize = true;
            pNum.Text = "Part Number:";
            pNum.Font = new Font("Verdana", 14.25f, FontStyle.Bold);

            //pSerial third
            pSerial.Location = new Point(37, 163);
            pSerial.AutoSize = true;
            pSerial.Text = "Serial Number:";
            pSerial.Font = new Font("Verdana", 14.25f, FontStyle.Bold);

            //process fourth
            process.Location = new Point(37, 221);
            process.AutoSize = true;
            process.Text = "Process:";
            process.Font = new Font("Verdana", 14.25f, FontStyle.Bold);

            //remarks fifth
            remarks.Location = new Point(37, 292);
            remarks.AutoSize = true;
            remarks.Text = "Remarks:";
            remarks.Font = new Font("Verdana", 14.25f, FontStyle.Bold);

            ThePage.Controls.Add(pName);
            ThePage.Controls.Add(pNum);
            ThePage.Controls.Add(pSerial);
            ThePage.Controls.Add(process);
            ThePage.Controls.Add(remarks);


        }

        //Create the different input boxes for our new tabs
        public void DisplayInputBoxes(TabControl temp, List<string> pNameList, List<string> processList){

            tab_control = temp;


            //First our Parts Name Box
            nameBox = new ComboBox();
            nameBox.Name = "pNameDropDownBox";
            nameBox.Location = new Point(401, 38);
            nameBox.Size = new Size(190, 21);
            nameBox.TextChanged += new EventHandler(PNDropDown);
            nameBox.Items.AddRange(pNameList.ToArray());

            //Second our Parts Number Box
            numBox = new TextBox();
            numBox.Name = "pNumberBox";
            numBox.Location = new Point(401, 100);
            numBox.Size = new Size(190, 20);

            //Third our Parts Serial Number Box
            serialBox = new TextBox();
            serialBox.Name = "serialNumberBox";
            serialBox.Location = new Point(401, 163);
            serialBox.Size = new Size(190, 21);

            //Fourth our Process Box
            processBox = new ComboBox();
            processBox.Name = "processDropDownBox";
            processBox.Location = new Point(401, 221);
            processBox.Size = new Size(190, 21);
            processBox.Items.AddRange(processList.ToArray());

            //Fifth our Remarks box
            remarksBox = new RichTextBox();
            remarksBox.Name = "remarksBox";
            remarksBox.Location = new Point(401, 292);
            remarksBox.Size = new Size(190, 71);

            ThePage.Controls.Add(nameBox);
            ThePage.Controls.Add(numBox);
            ThePage.Controls.Add(serialBox);
            ThePage.Controls.Add(processBox);
            ThePage.Controls.Add(remarksBox);


        }

        //Function called when we change our Parts Name drop down menu text
        private void PNDropDown(object sender, System.EventArgs e){

            tab_control.SelectedTab.Text = ThePage.Controls["pNameDropDownBox"].Text;

        }

    }
    
    
}
