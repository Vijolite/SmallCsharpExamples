using System.Diagnostics;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Udemi_WinFormsApp_NumericTypeSuggestion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void checkBoxIntegralOnly_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMustBePrecise.Visible = !checkBoxIntegralOnly.Checked;
            SuggestedTypeCalculation(sender,e);
        }

        private bool IsValid(char keyChar, TextBox textBox)
        {
            return char.IsDigit(keyChar) || char.IsControl(keyChar) || (keyChar == '-' && textBox.SelectionStart == 0); //Number of cursor position
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender; // cast sender into the object we need
            if (!IsValid(e.KeyChar, textBox))
            {
                e.Handled = true;
            }
        }

        private void SuggestedTypeCalculation(object sender, EventArgs e)
        {
            const string txt = "Suggested type ";
            const string txtImpossible = "IMPOSSIBLE REPRESENTATION";

            var minValue = textBoxMinValue.Text;
            var maxValue = textBoxMaxValue.Text;
            var type = "NOT ENOUGH DATA";

            if (checkBoxIntegralOnly.Checked)
            {
                if (byte.TryParse(minValue, out byte minNum) && byte.TryParse(maxValue, out byte maxNum))
                {
                    type = minNum<=maxNum ? "byte" : txtImpossible;
                }
                else if (sbyte.TryParse(minValue, out sbyte minNum1) && sbyte.TryParse(maxValue, out sbyte maxNum1))
                {
                    type = minNum1<=maxNum1 ? "sbyte" : txtImpossible;
                }
                else if (short.TryParse(minValue, out short _) && short.TryParse(maxValue, out short _))
                {
                    type = "short";
                }
                else if (ushort.TryParse(minValue, out ushort _) && ushort.TryParse(maxValue, out ushort _))
                {
                    type = "ushort";
                }
                else if (int.TryParse(minValue, out int _) && int.TryParse(maxValue, out int _))
                {
                    type = "int";
                }
                else if (uint.TryParse(minValue, out uint _) && uint.TryParse(maxValue, out uint _))
                {
                    type = "uint";
                }
                else if (long.TryParse(minValue, out long _) && long.TryParse(maxValue, out long _))
                {
                    type = "long";
                }
                else if (ulong.TryParse(minValue, out ulong _) && ulong.TryParse(maxValue, out ulong _))
                {
                    type = "ulong";
                }
            }
            else
            {
                if (checkBoxMustBePrecise.Checked)
                {
                    if (decimal.TryParse(minValue, out decimal _) && decimal.TryParse(maxValue, out decimal _))
                    {
                        type = "decimal";
                    }
                }
                else
                {
                    if (float.TryParse(minValue, out float _) && float.TryParse(maxValue, out float _))
                    {
                        type = "float";
                    }
                    else if (double.TryParse(minValue, out double _) && double.TryParse(maxValue, out double _))
                    {
                        type = "double";
                    }
                }

            };
            labelSuggestedType.Text = txt + type;

        }


    }
}