using HedgeLib;
using HedgeLib.Sets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicColorsSetEditor
{
    public partial class AddParamForm : Form
    {

        public SetObject SetObject;

        public AddParamForm()
        {
            InitializeComponent();
        }

        public AddParamForm(SetObject setObject) : this()
        {
            SetObject = setObject;

            comboBox1.SelectedItem = typeof(uint);
            comboBox1.Items.Add(typeof(string));
            comboBox1.Items.Add(typeof(bool));
            comboBox1.Items.Add(typeof(byte));
            comboBox1.Items.Add(typeof(uint));
            comboBox1.Items.Add(typeof(int));
            comboBox1.Items.Add(typeof(float));
            comboBox1.Items.Add(typeof(Vector3));
            comboBox1.Items.Add(typeof(Quaternion));
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Type type = comboBox1.SelectedItem as Type;
            SetObject.Parameters.Add(new SetObjectParam(type, Activator.CreateInstance(type)));
        }
    }
}
