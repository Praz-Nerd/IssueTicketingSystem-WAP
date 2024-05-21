using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IssueTicketingSystem
{
    [DefaultEvent(nameof(TextChanged))]
    [ToolboxItem(true)]
    public partial class EnhancedTextBox : UserControl
    {
        public EnhancedTextBox()
        {
            InitializeComponent();
            txtValue.TextChanged += txtValue_TextChanged;
            btnClear.Click += btnClear_Click;
        }

        private int maxCharacters = 100;
        [Category("Behavior")]
        [Description("Specifies the maximum number of characters allowed in the text box.")]
        public int MaxCharacters
        {
            get { return maxCharacters; }
            set
            {
                maxCharacters = value;
                // Ensure the current text does not exceed the new limit
                if (txtValue.Text.Length > maxCharacters)
                {
                    txtValue.Text = txtValue.Text.Substring(0, maxCharacters);
                }
            }
        }

        public string getText()
        {
            return txtValue.Text;
        }
        public void setText(string text)
        {
            txtValue.Text = text;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (txtValue.Text.Length > maxCharacters)
            {
                txtValue.Text = txtValue.Text.Substring(0, maxCharacters);
                txtValue.SelectionStart = maxCharacters; // Set the cursor at the end
                txtValue.SelectionLength = 0; // Ensure no text is selected
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
        }
    }
}
