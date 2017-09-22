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
    public partial class EditParamForm : Form
    {
        public SetObjectParam Param;
        public SetObjectTypeParam ParamType;
        public Type Type;
        
        public EditParamForm()
        {
            InitializeComponent();
            Theme.ApplyDarkThemeToAll(this);
        }

        public EditParamForm(SetObjectParam param, SetObjectTypeParam paramType) : this()
        {
            Param = param;
            Type = param.DataType;
            ParamType = paramType;
            
            titleLbl.Text += param.DataType.Name;

            if (paramType != null && paramType.Enums.Count > 0)
            {
                CheckBox_UseEnum.Enabled = true;
                foreach (var tempEnum in paramType.Enums)
                {
                    ComboBox_Enum.Items.Add(tempEnum);
                }
                ComboBox_Enum.SelectedItem = ComboBox_Enum.Items[0];
            }
            UpdateTypes();
            Read();
        }

        public void UpdateTypes()
        {
            // Hide things
            textBox1.Visible = numericUpDown1.Visible = numericUpDown2.Visible = numericUpDown3.Visible =
                button1.Visible = ComboBox_Enum.Visible = false;

            var type = Type;

            if (CheckBox_UseEnum.Checked)
            {
                ComboBox_Enum.Visible = true;
                return;
            }

            if (type == typeof(string))
            {
                textBox1.Visible = true;
            }
            else if (type == typeof(bool))
            {
                button1.Visible = true;
            }
            else if (type == typeof(byte))
            {
                numericUpDown1.Visible = true;
                numericUpDown1.DecimalPlaces = 0;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = 0xFF;
            }
            else if (type == typeof(uint))
            {
                numericUpDown1.Visible = true;
                numericUpDown1.DecimalPlaces = 0;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = 0xFFFFFFFF;
            }
            else if (type == typeof(int))
            {
                numericUpDown1.Visible = true;
                numericUpDown1.DecimalPlaces = 0;
                numericUpDown1.Minimum = -0x7FFFFFFF;
                numericUpDown1.Maximum = 0x7FFFFFFF;
            }
            else if (type == typeof(float))
            {
                numericUpDown1.Visible = true;
                numericUpDown1.DecimalPlaces = 6;
                numericUpDown1.Minimum = -0x7FFFFFFF;
                numericUpDown1.Maximum = 0x7FFFFFFF;
            }
            else if (type == typeof(Vector3))
            {
                numericUpDown1.Visible = true;
                numericUpDown1.DecimalPlaces = 6;
                numericUpDown1.Minimum = -0x7FFFFFFF;
                numericUpDown1.Maximum = 0x7FFFFFFF;

                numericUpDown2.Visible = true;
                numericUpDown2.DecimalPlaces = 6;
                numericUpDown2.Minimum = -0x7FFFFFFF;
                numericUpDown2.Maximum = 0x7FFFFFFF;

                numericUpDown3.Visible = true;
                numericUpDown3.DecimalPlaces = 6;
                numericUpDown3.Minimum = -0x7FFFFFFF;
                numericUpDown3.Maximum = 0x7FFFFFFF;
            }
            else if (type == typeof(Quaternion))
            {
                // NOPE
            }
            else if (type == typeof(object))
            {
                MessageBox.Show("WHAT HAVE YOU DONE?");
                Close();
            }
            else if (type == null)
            {
                MessageBox.Show("NULL?");
                Close();
            }
            else
            {
                MessageBox.Show($"Whats a \"{type}\"?");
                Close();
            }

        }

        public void Read()
        {
            var type = Type;

            if (type == typeof(string))
            {
                textBox1.Text = Param.Data as string;
            }
            else if (type == typeof(bool))
            {
                button1.Text = ((bool)Param.Data) ? "True" : "False";
            }
            else if (type == typeof(byte))
            {
                numericUpDown1.Value = (byte)Param.Data;
            }
            else if (type == typeof(uint))
            {
                numericUpDown1.Value = (uint)Param.Data;
            }
            else if (type == typeof(uint))
            {
                numericUpDown1.Value = (int)Param.Data;
            }
            else if (type == typeof(float))
            {
                numericUpDown1.Value = (decimal)(float)Param.Data;
            }
            else if (type == typeof(Vector3))
            {
                numericUpDown1.Value = (decimal)((Vector3)Param.Data).X;
                numericUpDown1.Visible = true;
                numericUpDown1.DecimalPlaces = 6;
                numericUpDown1.Minimum = -0x7FFFFFFF;
                numericUpDown1.Maximum = 0x7FFFFFFF;

                numericUpDown2.Value = (decimal)((Vector3)Param.Data).Y;
                numericUpDown2.Visible = true;
                numericUpDown2.DecimalPlaces = 6;
                numericUpDown2.Minimum = -0x7FFFFFFF;
                numericUpDown2.Maximum = 0x7FFFFFFF;

                numericUpDown3.Value = (decimal)((Vector3)Param.Data).Z;
                numericUpDown3.Visible = true;
                numericUpDown3.DecimalPlaces = 6;
                numericUpDown3.Minimum = -0x7FFFFFFF;
                numericUpDown3.Maximum = 0x7FFFFFFF;
            }
            else if (type == typeof(Quaternion))
            {
                // NOPE
            }
            else if (type == typeof(object))
            {
                MessageBox.Show("WHAT HAVE YOU DONE?");
                Close();
            }
            else if (type == null)
            {
                MessageBox.Show("NULL?");
                Close();
            }
            else
            {
                MessageBox.Show($"Whats a \"{type}\"?");
                Close();
            }

        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            var type = Type;

            if (CheckBox_UseEnum.Checked)
            {
                if (ComboBox_Enum.SelectedItem != null)
                {
                    Param.Data = Helpers.ChangeType(((SetObjectTypeParamEnum)ComboBox_Enum.SelectedItem).Value, type);
                    return;
                }
            }

            if (type == typeof(string))
            {
                Param.Data = textBox1.Text;
            }
            else if (type == typeof(bool))
            {
                Param.Data = button1.Text == "True";
            }
            else if (type == typeof(byte))
            {
                Param.Data = (byte)numericUpDown1.Value;
            }
            else if (type == typeof(uint))
            {
                Param.Data = (int)numericUpDown1.Value;
            }
            else if (type == typeof(uint))
            {
                Param.Data = (uint)numericUpDown1.Value;
            }
            else if (type == typeof(float))
            {
                Param.Data = (float)numericUpDown1.Value;
            }
            else if (type == typeof(Vector3))
            {
                Param.Data = new Vector3(
                    (float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value);
            }
            else if (type == typeof(Quaternion))
            {
                // NOPE
            }
            else if (type == typeof(object))
            {
                Close();
            }
            else if (type == null)
            {
                MessageBox.Show("NULL?");
                Close();
            }
            else
            {
                MessageBox.Show($"Whats a \"{type}\"?");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "True")
                button1.Text = "False";
            else if (button1.Text == "False")
                button1.Text = "True";
        }

        private void CheckBox_UseEnum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTypes();
        }
    }
}
