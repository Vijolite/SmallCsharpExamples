namespace FirstWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int _counter = 0;
        private void IncreaseCounterButton_Click(object sender, EventArgs e)
        {
            _counter++;
            CounterLabel.Text = _counter.ToString();
        }

        private void HideButtonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IncreaseCounterButton.Visible = !IncreaseCounterButton.Visible;
        }

        private void YesrOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValid(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsValid(char keyChar)
        {
            return (char.IsDigit(keyChar) || char.IsControl(keyChar)) && YesrOfBirthTextBox.Text.Length<4;
        }
    }
}