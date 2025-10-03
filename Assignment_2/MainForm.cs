using System.Xml.Linq;

namespace Assignment_2
{
    public partial class MainForm : Form
    {
        private color selectedColor;
        public MainForm()
        {
            InitializeComponent();
            lstBox.Items.Add("Chevy Silerado");
            lstBox.Items.Add("Ford F-150");
            lstBox.Items.Add("Toyota Yaris");
            lstBox.Items.Add("Honda Element");

        }
        public enum color
        {
            Red, Blue, Black, White
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            if (lstBox.SelectedItem == null)
                {
                    lblSummary.ForeColor = Color.Red;
                    lblSummary.Text = "Error: Please Choose a make and model";
                return;
                }
                string make = lstBox.SelectedItem!.ToString();

            if (!int.TryParse(txtYear.Text, out int year))
                {
                    lblSummary.ForeColor = Color.Red;
                    lblSummary.Text = "Error: Please enter a valid year";
                return;

                }
                
                string strColor = selectedColor switch
                {
                    color.Red => "red",
                    color.Blue => "blue",
                    color.Black => "black",
                    color.White => "white",
                    _ => "unknown color"
                };

                List<string> features = new List<string>();
                if (chkAC.Checked) features.Add("AC");
                if (chkPowerWindows.Checked) features.Add("power windows");
                if (chkSiriusRadio.Checked) features.Add("Sirius radio");
                if (chkLaneAssist.Checked) features.Add("lane assistance");

                string featureText = string.Join(", ", features);

                lblSummary.ForeColor = System.Drawing.Color.Black;
                lblSummary.Text = $"You have purchased a {strColor} {year} {make} with the following features: {featureText}";
            }
           
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked) selectedColor = color.Red;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked) selectedColor = color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked) selectedColor = color.Black;
        }

        private void radWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (radWhite.Checked) selectedColor = color.White;
        }
    }
}
