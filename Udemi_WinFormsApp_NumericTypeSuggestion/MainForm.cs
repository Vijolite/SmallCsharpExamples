using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using Udemi_WinFormsApp_NumericTypeSuggestion.Methods;
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

        private static bool IsValidInput(char keyChar, TextBox textBox)
        {
            return char.IsDigit(keyChar) || char.IsControl(keyChar) || (keyChar == '-' && textBox.SelectionStart == 0); //Number of cursor position
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender; // cast sender into the object we need
            if (!IsValidInput(e.KeyChar, textBox))
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

            if (BigInteger.TryParse(minValue, out BigInteger minNum) && BigInteger.TryParse(maxValue, out BigInteger maxNum))
            {
                if (minNum > maxNum)
                {
                    type = txtImpossible;
                }

                else
                {
                    type = NumericTypeSuggestor.SuggestNumericType(minNum, maxNum, checkBoxIntegralOnly.Checked, checkBoxMustBePrecise.Checked);
                }
            }


            labelSuggestedType.Text = txt + type;

        }


    }
}