using System.Windows.Forms;

namespace mealApp
{
    public partial class frmBurgers : Form
    {
        public frmBurgers()
        {
            InitializeComponent();
        }

        private bool button1clicked = false;
        private bool button2clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/45661993/picturebox-image-change-by-clicking-a-button-in-win-form-app
            if (button1clicked)
            {
                string picVego = "C:\\Users\\user\\Downloads\\veggie.jpg";
                picVeggie.Image = Image.FromFile(picVego);
                MessageBox.Show("Veggie Selected!");
            }
            else
            {
                button1clicked = true;
                btnPrime.Enabled = false;
            }
            
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            if(button2clicked)
            {
                string picPrimed = "C:\\Users\\user\\Downloads\\prime.jpg";
                picPrime.Image = Image.FromFile(picPrimed);
                MessageBox.Show("Beef Selected!");
            }
            else 
            {
                button2clicked = true;
                btnVeggie.Enabled=false;
                
            }

            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/12977924/how-do-i-properly-exit-a-c-sharp-application 
            System.Windows.Forms.Application.Exit();
        }

        private void picVeggie_Click(object sender, EventArgs e)
        {
            
        }
        private bool btnSelectClicked = false;
        private void btnSelectMeal_Click(object sender, EventArgs e)
        {
            if (btnSelectClicked)
            {
                MessageBox.Show("You have selected!");
                btnPrime.Enabled = false;
                btnVeggie.Enabled = false;
            }


        }
    }
}
