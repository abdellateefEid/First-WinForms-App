namespace First_WinFormsApp
{
    public partial class Form1 : Form
    {
        private Color c = Color.Aquamarine;
        public Form1()
        {
            InitializeComponent();

            btnExit.Click += ((sender, args) => this.Close());

        }

        private void helloFrmResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            this.BackColor = Color.Aqua;
        }


        private void helloFrmResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.BackColor = Color.Azure;
        }
    }
}
