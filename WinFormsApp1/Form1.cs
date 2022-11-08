namespace WinFormsApp1
{

    public interface IFMessage
    {
        void MessageB(string m);

    }
    public class RealMessage
    {
        public void MessageB(string m)
        {
            MessageBox.Show(m);
        }

    }
    public partial class Form1 : Form
    {

        RealMessage real;

        public Form1()
        {
            InitializeComponent();
            Message = "";
            real = new RealMessage();
        }

        public Form1(string message)
        {
            InitializeComponent();
            Message = message;
            txtName.Text = message;

        }

        public string Message { get; set; }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                Message = "You have to enter a name";
                real.MessageB(Message);
                return;
            }

            if (numBalance.Value < 10_000 || numBalance.Value > 1_000_000)
            {
                Message = "Must be between 10k and 1MM";
                real.MessageB(Message);
                return;
            }

            if (File.Exists("authkey.txt") is false)
            {
                Message = "Missing authorization key";
                real.MessageB(Message);
                return;
            }

            lblResults.Text = (numBalance.Value * numInterestRate.Value).ToString("c");
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}