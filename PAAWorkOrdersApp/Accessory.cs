/************************
 * November 29, 2017 - Created
 * November 29, 2017 - Updated
 * 
 * This class is our base for all accessories.  These can be Magnetos, Fuel Pumps, Manifold Valves, or even Starter Adapters.
 * Anything the shop works on shares the values in this class and so this class is the base for their construction in the Database.
 * All accessories have a Part Name, Part Number, Serial Number, and Process.
 * They also may or may not have a Remarks value.  This is basically an "anything else" notes section, and may be left blank in most cases.
 ************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAAWorkOrdersApp{

    class Accessory{


        //First set our private, in-house variables
        private string _pName;      //Part Name
        private string _pNum;       //Part Number
        private string _pSerial;    //Part Serial Number
        private string _process;    //Process (O/H, 500 Hour, IRAN, etc)
        private string _remarks;    //Notes, anything extra

        //Next, set up the getters and setters for accessible variables
        public string Part_Name { get { return _pName; } set { _pName = value; } }
        public string Part_Number { get { return _pNum; } set { _pNum = value; } }
        public string Part_Serial_Number { get { return _pSerial; } set { _pSerial = value; } }
        public string Process { get { return _process; } set { _process = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }


        #region Class_Constructors

        //Base constructor
        public Accessory() { }

        //Override constructor
        //Sets all 4 primary variables in our Accessory class
        public Accessory(string pName, string pNum, string pSerial, string process){

            Part_Name = pName;
            Part_Number = pNum;
            Part_Serial_Number = pSerial;
            Process = process;

        }

        //Override constructor
        //Set all 5 variables in our Accessory class, including the Remarks variable
        public Accessory(string pName, string pNum, string pSerial, string process, string remarks){

            Part_Name = pName;
            Part_Number = pNum;
            Part_Serial_Number = pSerial;
            Process = process;
            Remarks = remarks;

        }

        #endregion

    }

}
