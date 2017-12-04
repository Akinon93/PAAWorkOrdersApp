/************************
 * November 29, 2017 - Created
 * November 30, 2017 - Updated
 * 
 * This is the primary application form.
 * From here is where all other classes and forms will be called.
 ************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAAWorkOrdersApp{

    public partial class Form1 : Form{

        private List<Accessory> acc_list;   //A list of our accessories in the Work Order
        private List<String> pNameList;     //A list of all our Part Names to be used in the ComboBox control
        private List<String> processList;   //A list of all our potential Processes to be used in the ComboBox control
        private int tabNum;                 //New name of our "Add+" tab, when we select it.  Increments
        

        public Form1(){
            //Initialize our variables
            acc_list = new List<Accessory>();
            tabNum = 0;

            //Initialize and fill up our pNameList and processList variables
            pNameList = new List<string>();
            pNameList.Add("Magneto");
            pNameList.Add("Fuel Pump");
            pNameList.Add("Fuel Servo");
            pNameList.Add("Manifold Valve");
            pNameList.Add("Flow Divider");
            pNameList.Add("Starter Adapter");
            
            processList = new List<string>();
            processList.Add("O/H");
            processList.Add("500 Hour");
            processList.Add("IRAN");

            



            InitializeComponent();


            //Initialize our first "Add+" tab
            AccTab secondTab = new AccTab();
            secondTab.ThePage.Name = "addTab";                    //Have to set the name so we can alter this tab later if it's clicked on
            secondTab.DisplayLabelNames();
            secondTab.DisplayInputBoxes(tabControl1, pNameList, processList);
            secondTab.nameBox.LostFocus += new EventHandler(UpdateWOList);
            secondTab.numBox.LostFocus += new EventHandler(UpdateWOList);
            secondTab.serialBox.LostFocus += new EventHandler(UpdateWOList);
            secondTab.processBox.LostFocus += new EventHandler(UpdateWOList);
            secondTab.remarksBox.LostFocus += new EventHandler(UpdateWOList);
            tabControl1.TabPages.Add(secondTab.ThePage);
        }

        //This short function we will use a few times over
        //Changes the text of a tab
        //Used when adding a new tab or changing a part name
        private void ChangeTabText(TabPage tab, string s) {

            tab.Text = s;

        }

        //Adding a new accessory item
        //Adds a new tab to our accessory tab control
        private void AddNewAccessory(object sender, System.EventArgs e){

            TabPage tempTab = tabControl1.SelectedTab;

            //If we haven't clicked the "Add+" tab, don't go any further in the code and return
            if (tempTab != tabControl1.TabPages["addTab"])
                return;

            //Change Tab Text, then change its Name identifier, then increment the tabNum variable by 1
            ChangeTabText(tempTab, "New Acc");
            tempTab.Name = tabNum.ToString();
            tabNum++;

            //Now we create the new tab that will be "Add+"
            AccTab newPage = new AccTab();
            newPage.ThePage.Name = "addTab";                    //Have to set the name so we can alter this tab later if it's clicked on
            newPage.tabNum = tabNum;
            newPage.DisplayLabelNames();
            newPage.DisplayInputBoxes(tabControl1, pNameList, processList);
            newPage.nameBox.LostFocus += new EventHandler(UpdateWOList);
            newPage.numBox.LostFocus += new EventHandler(UpdateWOList);
            newPage.serialBox.LostFocus += new EventHandler(UpdateWOList);
            newPage.processBox.LostFocus += new EventHandler(UpdateWOList);
            newPage.remarksBox.LostFocus += new EventHandler(UpdateWOList);
            tabControl1.TabPages.Add(newPage.ThePage);


            acc_list.Add(new Accessory());
            //Need to find a way to show the acc_list values on screen for debugging and testing purposes


        }

        //Everything complete?
        //Submit!
        private void SubmitWorkOrder(object sender, System.EventArgs e){

            TabPage firsttab = tabControl1.TabPages[0];
            string customer = firsttab.Controls.Find("company_name", true)[0].Text;
            string purchaseNum = firsttab.Controls.Find("purchase_order_number", true)[0].Text;

            string temps = "Customer: " + customer + " \nPurchase Order #: " + purchaseNum + "\n\n\n";

            //Here is where we put our data values into our Work Order sheet.  Using the above 2 variables customer and purchaseNum in every line, as all these accessory parts will be under the same customer and purchase order number.
            for(int x = 0; x < acc_list.Count; x++) {

                temps += "Part Name: " + acc_list[x].Part_Name + " \nPart Number: " + acc_list[x].Part_Number + " \nSerial Number: " + acc_list[x].Part_Serial_Number + " \nProcess: " + acc_list[x].Process + " \nRemarks: " + acc_list[x].Remarks + " \n\n\n";

            }

            MessageBox.Show(temps, "Submitted!", MessageBoxButtons.OK);

        }

        //Exit application
        private void ExitApplication(object sender, System.EventArgs e){

            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e){

        }
        

        //Call function to update our Work_Order_List variable
        public void UpdateWOList(object sender, System.EventArgs e){

            TabPage temptab = tabControl1.SelectedTab;

            acc_list[Convert.ToInt32(temptab.Name)] = new Accessory(temptab.Controls.Find("pNameDropDownBox", true)[0].Text,
                                                                    temptab.Controls.Find("pNumberBox", true)[0].Text,
                                                                    temptab.Controls.Find("serialNumberBox", true)[0].Text,
                                                                    temptab.Controls.Find("processDropDownBox", true)[0].Text,
                                                                    temptab.Controls.Find("remarksBox", true)[0].Text);

        }
    }
}
