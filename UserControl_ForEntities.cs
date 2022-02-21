using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Films
{
    public partial class UserControl_ForEntities : UserControl
    {
        public string _GroupBoxName { get { return groupBox.Text; } set { groupBox.Text = value; } }
        public GroupBox _GroupBox = null;
        public ListBox  _ListBox = null;
        public TextBox  _TextBox = null;
        public Button   _ButtonDelete = null;
        public Button   _ButtonSave = null;
        
        public UserControl_ForEntities()
        {
            InitializeComponent();
            _GroupBox = groupBox;
            _ListBox = listBox;
            _TextBox = textBox;
            _ButtonDelete = BtnDelete;
            _ButtonSave = BtnSave;
        }
    }
}
