/**********************
 * November 29, 2017 - Created
 * November 29, 2017 - Updated
 * 
 * Based on inputs, returns the setup for both the label and input box for a new AccTab class.
 * Input boxes can be text boxes, combo lists, or even rich text boxes.
 * This class attempts to copy exactly the second tab that was set up in the Form1[Design] page.
 * This includes location, name, text, font, and more.
 **********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PAAWorkOrdersApp {
    class LabelBoxSet {

        private Label _label;
        private TextBox _textbox;
        private ComboBox _combobox;
        private RichTextBox _richtextbox;

        public Label AccLabel { get { return _label; } set { _label = value; } }
        public TextBox AccTextBox { get { return _textbox; } set { _textbox = value; } }
        public ComboBox AccComboBox { get { return _combobox; } set { _combobox = value; } }
        public RichTextBox AccRichTextBox { get { return _richtextbox; } set { _richtextbox = value; } }

        public LabelBoxSet() {  }

        public LabelBoxSet(string lText, string bText, string box) {

            

        }
    }
}
