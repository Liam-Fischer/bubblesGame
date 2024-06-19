using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace bubblesGame
{
    public partial class gameSpace : Form
    {
        bool wPressed = false;
        bool aPressed = false;
        bool sPressed = false;
        bool dPressed = false;

        bool endGame = false;

        int top = 120;
        int bottom = 475;
        int left = 57;
        int right = 618;
        Rectangle drainMiddle = new Rectangle(317 +12, 275, 56, 48);
        Rectangle drainCenter = new Rectangle(317 + 25, 275 + 13, 33, 25);
        Rectangle drainRight = new Rectangle(317 + 12 + 56, 283, 12, 48 - 14);
        Rectangle drainLeft = new Rectangle(317, 283, 12, 48 - 14);

        SolidBrush bubbleBrush = new SolidBrush(Color.FromArgb(0, 218, 255));
        int bubbleSize = 24;
        int bubbleSpeed = 15;
        Rectangle bubble = new Rectangle(345, 230, 24, 24);

        List<Rectangle> crumbList = new List<Rectangle>();
        List<Rectangle> greaseList = new List<Rectangle>();
        List<Rectangle> bladeList = new List<Rectangle>();
        List<Rectangle> verticalAntList = new List<Rectangle>();
        List<Rectangle> horizontalAntList = new List<Rectangle>();
        List<Rectangle> spongeList = new List<Rectangle>();
        List<Rectangle> scrubList = new List<Rectangle>();

        List<int> directionListH = new List<int>();
        List<int> directionListV = new List<int>();

        Random placer = new Random();

        SoundPlayer lose = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
        SoundPlayer takeItem = new SoundPlayer(Properties.Resources.Water_Drop_SoundBible_com_2039669379);
        
        int x = 0;
        int y = 0;
        int pointSpeed = 1;
        int antSpawn = 50;
        bool vAntReturn = false;
        bool hAntReturn = false;
        int crumbSize = 14;
        int points = 0;
        public gameSpace()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs m)
        {
            SolidBrush wallBrush = new SolidBrush(Color.FromArgb(255, 0, 3, 162));
            SolidBrush floorBrush = new SolidBrush(Color.FromArgb(255, 34, 39, 254));
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush drainBrush = new SolidBrush(Color.FromArgb(255, 80, 80, 161));
            SolidBrush crumbBrush = new SolidBrush(Color.FromArgb(255, 218, 107));
            SolidBrush greaseBrush = new SolidBrush(Color.FromArgb(30, 5, 0));
            Pen bladePen = new Pen(Color.FromArgb(15, 194, 255), 2);
            SolidBrush greyBrush = new SolidBrush(Color.Silver);
            SolidBrush scrubBrushBrush = new SolidBrush(Color.Goldenrod);
            SolidBrush spongeBrush = new SolidBrush(Color.FromArgb(255, 108, 1));

            //drawing the map
            m.Graphics.Clear(Color.FromArgb(0, 220, 255));
            m.Graphics.FillRectangle(wallBrush, 50, 80, 600, 430);
            m.Graphics.FillRectangle(floorBrush, 57, 120, 587, 380);
            m.Graphics.FillEllipse(drainBrush, 303, 266, 108, 68);
            m.Graphics.FillEllipse(blackBrush, 317, 275, 80, 48);

            if (gameTimer.Enabled == false && endGame == false)
            {
                m.Graphics.FillEllipse(bubbleBrush, bubble);
                m.Graphics.FillRectangle(crumbBrush, 180, 260, 14, 14);
                m.Graphics.FillRectangle(greaseBrush, 180, 325, 12, 12);
                m.Graphics.FillEllipse(greaseBrush, 175, 390, 22, 10);
                m.Graphics.FillPie(scrubBrushBrush, 500, 250, 25, 25, -70, 320);
                m.Graphics.FillEllipse(spongeBrush, 500, 320, 26, 19);
                m.Graphics.DrawRectangle(bladePen, 500, 390, 40, 25);
                m.Graphics.FillRectangle(greyBrush, 500, 390, 40, 25);
            }


            //drawing characters
            if (gameTimer.Enabled == true)
            {
                m.Graphics.FillEllipse(bubbleBrush, bubble.X, bubble.Y, bubbleSize, bubbleSize);

                for (int i = 0; i < crumbList.Count; i++)
                {
                    m.Graphics.FillRectangle(crumbBrush, crumbList[i].X, crumbList[i].Y, crumbSize, crumbSize);
                }
                for (int i = 0; i < greaseList.Count; i++)
                {
                    m.Graphics.FillRectangle(greaseBrush, greaseList[i].X, greaseList[i].Y, 12, 12);
                }
                for (int i = 0; i < bladeList.Count; i++)
                {
                    m.Graphics.FillRectangle(greyBrush, bladeList[i].X, bladeList[i].Y, bladeList[i].Width, bladeList[i].Height);
                    m.Graphics.DrawRectangle(bladePen, bladeList[i].X, bladeList[i].Y, bladeList[i].Width, bladeList[i].Height);
                }
                for (int i = 0; i < verticalAntList.Count; i++)
                {
                    m.Graphics.FillEllipse(greaseBrush, verticalAntList[i].X, verticalAntList[i].Y, 10, 22);
                }
                for (int i = 0; i < horizontalAntList.Count; i++)
                {
                    m.Graphics.FillEllipse(greaseBrush, horizontalAntList[i].X, horizontalAntList[i].Y, 22, 10);
                }
                for (int i = 0; i < scrubList.Count; i++)
                {
                    m.Graphics.FillPie(scrubBrushBrush, scrubList[i].X, scrubList[i].Y, 25, 25, -70, 320);
                }
                for (int i = 0; i < spongeList.Count; i++)
                {
                    m.Graphics.FillEllipse(spongeBrush, spongeList[i]);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.Space:
                    if (gameTimer.Enabled == false)
                    {
                        ClearStartScreen();
                    }
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pointMoveTimer.Enabled = true;
            antSpawn--;

            int xB = bubble.X;
            int yB = bubble.Y;
            bubble.Width = bubbleSize;
            bubble.Height = bubbleSize;
            pointLabel.Text = $"Points: {points}";
            

            MoveCharacter();

            for (int i = 0; i < crumbList.Count; i++)
            {
                if (bubble.IntersectsWith(crumbList[i]))
                {
                    takeItem.Play();
                    points += 50;
                    crumbList.RemoveAt(i);
                    if (bubbleSize < 36)
                    {
                        bubbleSize += 1;
                    }
                    else if (bubbleSize >= 36)
                    {
                        bubbleSize = 36;
                    }
                }
            }

            for (int i = 0; i < greaseList.Count; i++)
            {
                if (bubble.IntersectsWith(greaseList[i]))
                {
                    takeItem.Play();
                    points += 70;
                    greaseList.RemoveAt(i);
                    if (bubbleSize < 36)
                    {
                        bubbleSize += 1;
                    }
                    else if (bubbleSize >= 36)
                    {
                        bubbleSize = 36;
                    }
                }
            }

            for (int i = 0; i < verticalAntList.Count; i++)
            {
                if (bubble.IntersectsWith(verticalAntList[i]))
                {
                    takeItem.Play();
                    points += 90;
                    verticalAntList.RemoveAt(i);
                    directionListV.RemoveAt(i);
                    vAntReturn = false;
                    if (bubbleSize < 36)
                    {
                        bubbleSize += 1;
                    }
                    else if (bubbleSize >= 36)
                    {
                        bubbleSize = 36;
                    }
                }
            }

            for (int i = 0; i < horizontalAntList.Count; i++)
            {
                if (bubble.IntersectsWith(horizontalAntList[i]))
                {
                    takeItem.Play();
                    points += 90;
                    horizontalAntList.RemoveAt(i);
                    directionListH.RemoveAt(i);
                    hAntReturn = false;
                    if (bubbleSize < 36)
                    {
                        takeItem.Play();
                    }
                    else if (bubbleSize >= 36)
                    {
                        bubbleSize = 36;
                    }
                }
            }

            for (int i = 0; i< bladeList.Count; i++)
            {
                if(bubble.IntersectsWith(bladeList[i]))
                {
                    if(bubbleSize > 25)
                    {
                        bubbleSize--;
                        points--;
                        bubble.X = xB;
                        bubble.Y = yB;
                    }
                    else if(bubbleSize == 25)
                    {
                        lose.Play();
                        EndOfGame();
                    }
                }
            }

            for (int i = 0; i < spongeList.Count; i++)
            {
                if (bubble.IntersectsWith(spongeList[i]))
                {
                    if (bubbleSize < 36 && bubbleSize > 25)
                    {
                        bubbleSize--;
                        points--;
                    }
                    else if (bubbleSize == 36)
                    {
                        takeItem.Play();
                        spongeList.RemoveAt(i);
                        points += 110;
                    }
                    else if (bubbleSize == 25)
                    {
                        lose.Play();
                        EndOfGame();
                    }
                }
            }

            for (int i = 0; i < scrubList.Count; i++)
            {
                if (bubble.IntersectsWith(scrubList[i]))
                {
                    if (bubbleSize < 36 && bubbleSize > 25)
                    {
                        bubbleSize--;
                        points--;
                    }
                    else if (bubbleSize == 36)
                    {
                        takeItem.Play();
                        scrubList.RemoveAt(i);
                        points += 110;
                    }
                    else if (bubbleSize == 25)
                    {
                        lose.Play();
                        EndOfGame();
                    }
                }
            }

            if(bubble.IntersectsWith(drainCenter))
            {
                lose.Play();
                EndOfGame();
            }

            //spawning ants
            int a = placer.Next(4, 6);
            if (antSpawn == 0)
            {
                int vh = placer.Next(1, 3);
                if (vh == 1)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Rectangle vAnt = new Rectangle(351, 280, 10, 22);
                        verticalAntList.Add(vAnt);
                        int ud = placer.Next(1, 3);
                        if (ud == 1)
                        {
                            directionListV.Add(pointSpeed * 2);
                        }
                        else if (ud == 2)
                        {
                            directionListV.Add(pointSpeed * -2);
                        }

                    }
                }
                else if (vh == 2)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Rectangle hAnt = new Rectangle(351, 280, 22, 10);
                        horizontalAntList.Add(hAnt);
                        int ud= placer.Next(1, 3);
                        if (ud == 1)
                        {
                            directionListH.Add(pointSpeed * 2);
                        }
                        else if (ud == 2)
                        {
                            directionListH.Add(pointSpeed * -2);
                        }
                    }
                }
                antSpawn = placer.Next(25, 140);
            }

            //moving ants
            
            for(int i = 0; i < verticalAntList.Count; i++)
            {  
                int y = verticalAntList[i].Y + directionListV[i];
                verticalAntList[i] = new Rectangle(verticalAntList[i].X, y, 10, 22);
                if (y <= top || y >= bottom)
                {
                    directionListV[i] = -directionListV[i];
                    vAntReturn = true;
                }
                
            }
            for (int i = 0; i < horizontalAntList.Count; i++)
            {
                int x = horizontalAntList[i].X + directionListH[i];
                horizontalAntList[i] = new Rectangle(x, horizontalAntList[i].Y, 22, 10);
                if (x >= right || x <= left)
                {
                    directionListH[i] = -directionListH[i];
                    hAntReturn = true;
                }
            }

            //removing things at the drain
            for(int i = 0; i< crumbList.Count; i++)
            {
                if (crumbList[i].IntersectsWith(drainLeft)|| crumbList[i].IntersectsWith(drainRight)|| crumbList[i].IntersectsWith(drainMiddle))
                {
                    crumbList.RemoveAt(i);
                }
            }
            for (int i = 0; i < greaseList.Count; i++)
            {
                if (greaseList[i].IntersectsWith(drainLeft) || greaseList[i].IntersectsWith(drainRight) || greaseList[i].IntersectsWith(drainMiddle))
                {
                    greaseList.RemoveAt(i);
                }
            }
            for (int i = 0; i < verticalAntList.Count; i++)
            {
                if ((verticalAntList[i].IntersectsWith(drainLeft) || verticalAntList[i].IntersectsWith(drainRight) || verticalAntList[i].IntersectsWith(drainMiddle)) && vAntReturn == true)
                {
                    verticalAntList.RemoveAt(i);
                    directionListV.RemoveAt(i);
                }

            }
            for (int i = 0; i < horizontalAntList.Count; i++)
            {
                if ((horizontalAntList[i].IntersectsWith(drainLeft) || horizontalAntList[i].IntersectsWith(drainRight) || horizontalAntList[i].IntersectsWith(drainMiddle)) && hAntReturn == true)
                {
                    horizontalAntList.RemoveAt(i);
                    directionListH.RemoveAt(i);
                }

            }

            if (greaseList.Count == 0 && crumbList.Count == 0 && horizontalAntList.Count == 0 && verticalAntList.Count == 0)
            {
                EndOfGame();
            }

            Refresh();
        }
        public void MoveCharacter()
        {
            if (wPressed == true && bubble.Y > top)
            {
                bubble.Y = bubble.Y - bubbleSpeed;
            }
            if (sPressed == true && bubble.Y < bottom)
            {
                bubble.Y += bubbleSpeed;
            }

            if (aPressed == true && bubble.X > left)
            {
                bubble.X -= bubbleSpeed;
            }
            if (dPressed == true && bubble.X < right)
            {
                bubble.X += bubbleSpeed;
            }

            if (bubble.Y < top)
            {
                bubble.Y = top;
            }
            else if (bubble.Y > bottom)
            {
                bubble.Y = bottom;
            }
            if (bubble.X < left)
            {
                bubble.X = left;
            }
            else if (bubble.X > right)
            {
                bubble.X = right;
            }
        }
        public void PlaceItems()
        {
            int c = placer.Next(12, 25);
            for (int i = 0; i < c; i++)
            {
                    x = placer.Next(left, right);
                    y = placer.Next(top, bottom);
                if(x +crumbSize < drainRight.X && x +crumbSize > drainLeft.X + drainLeft.Width)
                {
                    x = placer.Next(left, right);
                }
                if(y +crumbSize < drainMiddle.Y && y +crumbSize > drainMiddle.Y + drainMiddle.Height)
                {
                    y = placer.Next(top, bottom);
                }

                Rectangle crumb = new Rectangle(x, y,crumbSize,crumbSize);
                crumbList.Add(crumb);
            }

            int g = placer.Next(9, 15);
            for (int i = 0; i < g; i++)
            {
                x = placer.Next(left, right);
                y = placer.Next(top, bottom);
                if (x + 12 < drainRight.X && x + 12 > drainLeft.X + drainLeft.Width)
                {
                    x = placer.Next(left, right);
                }
                if (y + 12 < drainMiddle.Y && y + 12 > drainMiddle.Y + drainMiddle.Height)
                {
                    y = placer.Next(top, bottom);
                }

                Rectangle grease = new Rectangle(x, y, 12, 12);
                greaseList.Add(grease);
            }

            int b = placer.Next(1, 5);
            for (int i = 0; i < b; i++)
            {
                x = placer.Next(left, right);
                y = placer.Next(top, bottom);

                Rectangle razorBlade = new Rectangle(x, y, 40, 25);
                if (razorBlade.IntersectsWith(drainMiddle) || razorBlade.IntersectsWith(drainRight) || razorBlade.IntersectsWith(drainLeft)|| razorBlade.IntersectsWith(bubble))
                {
                    razorBlade.X = placer.Next(left, right);
                    razorBlade.Y = placer.Next(top, bottom);
                }
                bladeList.Add(razorBlade);
            }

            int s = placer.Next(1, 4);
            for (int i = 0; i < s; i++)
            {
                x = placer.Next(left, right);
                y = placer.Next(top, bottom);

                Rectangle sponge = new Rectangle(x, y, 26, 19);
                if (sponge.IntersectsWith(drainMiddle) || sponge.IntersectsWith(drainRight) || sponge.IntersectsWith(drainLeft))
                {
                    sponge.X = placer.Next(left, right);
                    sponge.Y = placer.Next(top, bottom);
                }
                spongeList.Add(sponge);
            }

            int sB = placer.Next(1, 4);
            for (int i = 0; i < s; i++)
            {
                x = placer.Next(left, right);
                y = placer.Next(top, bottom);

                Rectangle scrubBrush = new Rectangle(x, y, 25, 25);
                if (scrubBrush.IntersectsWith(drainMiddle) || scrubBrush.IntersectsWith(drainRight) || scrubBrush.IntersectsWith(drainLeft))
                {
                    scrubBrush.X = placer.Next(left, right);
                    scrubBrush.Y = placer.Next(top, bottom);
                }
                scrubList.Add(scrubBrush);
            }
        }
        private void pointMoveTimer_Tick(object sender, EventArgs e)
        {
            // moving things towars the drain
            for (int i = 0; i < crumbList.Count; i++)
            {
                if (crumbList[i].X > 357)
                {
                    x = crumbList[i].X - pointSpeed;
                    crumbList[i] = new Rectangle(x, crumbList[i].Y, crumbList[i].Width, crumbList[i].Height);
                }
                else if (crumbList[i].X < 357)
                {
                    x = crumbList[i].X + pointSpeed;
                    crumbList[i] = new Rectangle(x, crumbList[i].Y, crumbList[i].Width, crumbList[i].Height);
                }

                if (crumbList[i].Y > 299)
                {
                    y = crumbList[i].Y - pointSpeed;
                    crumbList[i] = new Rectangle(crumbList[i].X, y, crumbList[i].Width, crumbList[i].Height);
                }
                else if (crumbList[i].Y < 299)
                {
                    y = crumbList[i].Y + pointSpeed;
                    crumbList[i] = new Rectangle(crumbList[i].X, y, crumbList[i].Width, crumbList[i].Height);
                }
            }

            for (int i = 0; i < greaseList.Count; i++)
            {
                if (greaseList[i].X > 357)
                {
                    x = greaseList[i].X - pointSpeed;
                    greaseList[i] = new Rectangle(x, greaseList[i].Y, greaseList[i].Width, greaseList[i].Height);
                }
                else if (greaseList[i].X < 357)
                {
                    x = greaseList[i].X + pointSpeed;
                    greaseList[i] = new Rectangle(x, greaseList[i].Y, greaseList[i].Width, greaseList[i].Height);
                }

                if (greaseList[i].Y > 299)
                {
                    y = greaseList[i].Y - pointSpeed;
                    greaseList[i] = new Rectangle(greaseList[i].X, y, greaseList[i].Width, greaseList[i].Height);
                }
                else if (greaseList[i].Y < 299)
                {
                    y = greaseList[i].Y + pointSpeed;
                    greaseList[i] = new Rectangle(greaseList[i].X, y, greaseList[i].Width, greaseList[i].Height);
                }
            }

            //chasing bubble
            for(int i = 0; i < scrubList.Count; i++)
            {
                if (scrubList[i].X > bubble.X)
                {
                    x = scrubList[i].X - pointSpeed * 4;
                    scrubList[i] = new Rectangle(x, scrubList[i].Y, scrubList[i].Width, scrubList[i].Height);
                }
                else if (scrubList[i].X < bubble.X)
                {
                    x = scrubList[i].X + pointSpeed * 4;
                    scrubList[i] = new Rectangle(x, scrubList[i].Y, scrubList[i].Width, scrubList[i].Height);
                }

                if (scrubList[i].Y > bubble.Y)
                {
                    y = scrubList[i].Y - pointSpeed * 4;
                    scrubList[i] = new Rectangle(scrubList[i].X, y, scrubList[i].Width, scrubList[i].Height);
                }
                else if (scrubList[i].Y < bubble.Y)
                {
                    y = scrubList[i].Y + pointSpeed * 4;
                    scrubList[i] = new Rectangle(scrubList[i].X, y, scrubList[i].Width, scrubList[i].Height);
                }
            }

            for (int i = 0; i < spongeList.Count; i++)
            {
                if (spongeList[i].X > bubble.X)
                {
                    x = spongeList[i].X - pointSpeed * 4;
                    spongeList[i] = new Rectangle(x, spongeList[i].Y, spongeList[i].Width, spongeList[i].Height);
                }
                else if (spongeList[i].X < bubble.X)
                {
                    x = spongeList[i].X + pointSpeed * 4;
                    spongeList[i] = new Rectangle(x, spongeList[i].Y, spongeList[i].Width, spongeList[i].Height);
                }

                if (spongeList[i].Y > bubble.Y)
                {
                    y = spongeList[i].Y - pointSpeed * 4;
                    spongeList[i] = new Rectangle(spongeList[i].X, y, spongeList[i].Width, spongeList[i].Height);
                }
                else if (spongeList[i].Y < bubble.Y)
                {
                    y = spongeList[i].Y + pointSpeed * 4;
                    spongeList[i] = new Rectangle(spongeList[i].X, y, spongeList[i].Width, spongeList[i].Height);
                }
            }
        }
        public void ClearStartScreen()
        {
            titleLabel.Visible = false;
            infoLabel1.Visible = false;
            infoLabel2.Visible = false;
            infoLabel3.Visible = false;
            infoLabel4.Visible = false;
            infoLabel5.Visible = false;
            infoLabel6.Visible = false;
            infoLabel7.Visible = false;
            infoLabel8.Visible = false;
            infoLabel9.Visible = false;
            infoLabel10.Visible = false;

            gameTimer.Enabled = true;
            PlaceItems();

            points = 0;
        }
        public void EndOfGame()
        {
            bubbleSize = 0; 
            endGame = true;
            gameTimer.Enabled = false;

            pointLabel.Text = "Points:";
            titleLabel.Text = "Game Over";
            titleLabel.Visible = true;
            infoLabel1.Text = $"your score: {points}";
            infoLabel1.Visible = true;
            infoLabel9.Text = "Play Again?";
            infoLabel9.Visible = true;

            //points = 0;
            bubble.X = 345;
            bubble.Y = 230;
            bubbleSize = 24;

            crumbList.Clear();
            greaseList.Clear();
            verticalAntList.Clear();
            horizontalAntList.Clear();
            bladeList.Clear();
            spongeList.Clear();
            scrubList.Clear();
        }
    }
}
