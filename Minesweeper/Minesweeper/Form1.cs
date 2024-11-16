namespace MinesWeeper
{
    public partial class Form1 : Form
    {
        private const int gridSize = 20;
        private const int cellSize = 30;
        private const int mineCount = 50;
        private Button[,] buttons = new Button[gridSize, gridSize];
        private bool[,] mines = new bool[gridSize, gridSize];
        private bool[,] revealed = new bool[gridSize, gridSize];
        private bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeGame()
        {
            panelGameArea.Controls.Clear();
            gameOver = false;

            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    Button button = new Button
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(x * cellSize, y * cellSize),
                        Font = new Font("Arial", 10),
                        Tag = new Point(x, y)
                    };
                    button.MouseDown += Cell_MouseDown;
                    panelGameArea.Controls.Add(button);
                    buttons[x, y] = button;
                    mines[x, y] = false;
                    revealed[x, y] = false;
                }
            }

            Random rand = new Random();
            int placedMines = 0;
            while (placedMines < mineCount)
            {
                int x = rand.Next(gridSize);
                int y = rand.Next(gridSize);
                if (!mines[x, y])
                {
                    mines[x, y] = true;
                    placedMines++;
                }
            }
        }

        // Oyun Baþlat Butonuna Týklama Olayý
        private void btnStart_Click(object sender, EventArgs e)
        {
            InitializeGame(); // Oyunu baþtan baþlatýr.
        }

        // Hücreye Týklama Olayý
        private void Cell_MouseDown(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            Point location = (Point)clickedButton.Tag;
            int x = location.X;
            int y = location.Y;

            if (gameOver)
                return;

            if (e.Button == MouseButtons.Right)
            {
                // Sað týklama ile bayrak ekleme
                if (clickedButton.Text == "")
                {
                    clickedButton.Text = "??";
                }
                else if (clickedButton.Text == "??")
                {
                    clickedButton.Text = "";
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                // Sol týklama ile hücreyi açma
                RevealCell(x, y);

                if (mines[x, y])
                {
                    clickedButton.BackColor = Color.Red;
                    clickedButton.Text = "??";
                    GameOver(false);
                }
                else if (CheckWin())
                {
                    GameOver(true);
                }
            }
        }

        private void RevealCell(int x, int y)
        {
            if (x < 0 || y < 0 || x >= gridSize || y >= gridSize || revealed[x, y])
                return;

            revealed[x, y] = true;
            buttons[x, y].Enabled = false;

            int mineCount = CountAdjacentMines(x, y);
            if (mineCount > 0)
            {
                buttons[x, y].Text = mineCount.ToString();
                buttons[x, y].BackColor = Color.LightGray;
            }
            else
            {
                buttons[x, y].BackColor = Color.LightGray;
                RevealCell(x - 1, y);
                RevealCell(x + 1, y);
                RevealCell(x, y - 1);
                RevealCell(x, y + 1);
            }
        }

        private int CountAdjacentMines(int x, int y)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int nx = x + i;
                    int ny = y + j;
                    if (nx >= 0 && ny >= 0 && nx < gridSize && ny < gridSize && mines[nx, ny])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private bool CheckWin()
        {
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (!mines[x, y] && !revealed[x, y])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void GameOver(bool win)
        {
            gameOver = true;
            string message = win ? "Tebrikler, kazandýnýz!" : "Mayýna bastýnýz, kaybettiniz!";
            MessageBox.Show(message, "Oyun Bitti");

            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (mines[x, y])
                    {
                        buttons[x, y].Text = "??";
                    }
                }
            }
        }
    }
}
