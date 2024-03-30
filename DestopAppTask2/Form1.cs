namespace DestopAppTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.MouseHover+=mouse_Hover;
        }
        Random random = new Random();


        private void mouse_Hover(object sender, EventArgs e)
        {
            button1.Location = new Point(random.Next(this.ClientSize.Width-button1.Width), random.Next(this.ClientSize.Height-button1.Size.Height));
        }

       

     
    }
}
