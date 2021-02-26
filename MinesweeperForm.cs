using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logikai_jatekok
{
    public partial class MinesweeperForm : Form
    {
        Field[,] fields = new Field[15, 14];
        bool isFirstClick = true;

        public MinesweeperForm()
        {
            InitializeComponent();

            SetUpFields();
        }

        private void SetUpFields()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Panel panel = new Panel();
                    panel.Location = new Point(20+i*30, 20+j*30);
                    panel.Size = new Size(25, 25);
                    panel.Click += new EventHandler(Field_Click);
                    panel.Name = $"{i}.{j}";
                    panel.BackColor = Color.Yellow;
                    panel.Font = new Font("Times New Roman", 5);

                    Label lb = new Label();
                    lb.Text = "idk";
                    panel.Controls.Add(lb);

                    Controls.Add(panel);

                    fields[i, j].panel = panel;
                    fields[i, j].isRevealed = false;
                    fields[i, j].minesNearby = 0;
                }
            }
        }

        private void Field_Click(object sender, EventArgs args)
        {
            Panel panel = (Panel)sender;
            string[] coords = panel.Name.Split('.');
            if (isFirstClick)
            {
                GenerateMines(int.Parse(coords[0]), int.Parse(coords[1]));
                isFirstClick = false;

                DiscoverEmptyNeighbours(int.Parse(coords[0]), int.Parse(coords[1]));
            }
        }

        private void DiscoverEmptyNeighbours(int x, int y)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i + x < 15 && j + y < 14 && i + x > -1 && j + y > -1 && i != j)
                    {
                        if(!fields[i + x, j + y].isRevealed)
                        {
                            if (fields[i + x, j + y].minesNearby == 0)
                            {
                                fields[i + x, j + y].panel.BackColor = Color.Blue;
                                fields[i + x, j + y].isRevealed = true;
                                DiscoverEmptyNeighbours(i + x, j + y);
                            }
                            else
                            {
                                fields[i + x, j + y].panel.BackColor = Color.Pink;
                                fields[i + x, j + y].panel.Text = $"{fields[i + x, j + y].minesNearby}";
                            }
                        }
                    }
                }
            }
        }

        private void GenerateMines(int x, int y)
        {
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (random.Next(0, 7) == 6)
                    {
                        if(Math.Sqrt(Math.Pow(x-i,2)+ Math.Pow(y - j, 2)) > 4) fields[i, j].minesNearby = -1;
                    }

                    if (fields[i, j].minesNearby == -1)
                    {
                        fields[i, j].panel.BackColor = Color.Red;
                        IncreaseNeighbours(i, j);
                    }
                    else fields[i, j].panel.BackColor = Color.Green;
                }
            }
        }

        private void IncreaseNeighbours(int i, int j)
        {
            for (int y = -1; y < 2; y++)
            {
                for (int x = -1; x < 2; x++)
                {
                    if (i + x < 15 && j + y < 14 && i + x > -1 && j + y > -1)
                    {
                        if (fields[i + x, j + y].minesNearby != -1) fields[i + x, j + y].minesNearby += 1;
                    }
                }
            }
        }
    }
}
