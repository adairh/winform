using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace SubmitWindow
{
    public partial class ComboBox : Form
    {
        
        string a = "Please choose one in combo box";

        public ComboBox()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            int index = lstBox.SelectedIndex;
           
                lstBox.Items.RemoveAt(index);
            
                lstBox.Focus();
          
          
                
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBox.Items.Add((comboBox1.SelectedItem));
            comboBox1.Items.Remove(comboBox1.SelectedItem);
         
        }
    }
    
}
