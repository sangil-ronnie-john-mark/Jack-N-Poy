namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        private int player;
        int cpuTurn() { 
            Random verleeeen = new Random();
            int bryon = verleeeen.Next(1, 4);
            return bryon; 
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //scissors
            int result = cpuTurn();
            if (result == 1)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandPeace;
                lblResult.Text = "DRAW";
            } else if (result == 2)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
                lblResult.Text = "YOU WIN";
            } else if (result == 3)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandRock;
                lblResult.Text = "YOU LOSE";
            }
            pbxPlayer.IconChar = FontAwesome.Sharp.IconChar.HandPeace;
            player = 1;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //paper
            int result = cpuTurn();
            if (result == 1)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandPeace;
                lblResult.Text = "YOU LOSE";
            }
            else if (result == 2)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
                lblResult.Text = "DRAW";
            }
            else if (result == 3)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandRock;
                lblResult.Text = "YOU WIN";
            }
            pbxPlayer.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
            player = 2;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //stonecold
            int result = cpuTurn();
            if (result == 1)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandPeace;
                lblResult.Text = "YOU WIN";
            }
            else if (result == 2)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
                lblResult.Text = "YOU LOSE";
            }
            else if (result == 3)
            {
                pbxCPU.IconChar = FontAwesome.Sharp.IconChar.HandRock;
                lblResult.Text = "DRAW";
            }
            pbxPlayer.IconChar = FontAwesome.Sharp.IconChar.HandRock;
            player = 3;
        }
    }
}
