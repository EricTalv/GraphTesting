using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphTesting
{
    public partial class Form1 : Form
    {
        private Pen CustomPen;

        Timer TATimer1 = new Timer();

        Bitmap Canvas;
        Pen GrayPen = new Pen(Color.Gray, 2);
        Pen BlackPen = new Pen(Color.Black, 2);
        Pen RedPen = new Pen(Color.Red, 2);
        Graphics g;

        int Yn = 4;
        int Xn = 4;

        public Form1()
        {
            InitializeComponent();

            Canvas = new Bitmap(TAPBxCanvas.Size.Width, TAPBxCanvas.Size.Height);

            g = Graphics.FromHwnd(TAPBxCanvas.Handle);

            CustomPen = new Pen(Color.Red, 2);

            TAPBxCanvas.Image = Canvas;

            Gridbox.Enabled = true;
        }

        private void TABDraw_Click(object sender, EventArgs e)
        {
            DrawAndCheck();
        }

        private void DrawAndCheck()
        {

            if (TACBxSuvalisedArvud.Checked)
            {
                randomNumbers(1, 20);
            }

            else
            {
                GridMain();
                DrawGraphic();
            }

            if (TARBSuvalineVärv.Checked)
            {
                SuvalineVärv();
                VärvPreview.BackColor = CustomPen.Color;
            }

            else
            {
                GridMain();
                DrawGraphic();
            }

            if (TACBxKustEelmine.Checked)
            {
                g.Clear(Color.WhiteSmoke);
                GridMain();
                DrawGraphic();
            }

            else
            {
                GridMain();
                DrawGraphic();
            }
        }

        private void DrawGraphic()
        {
            float dx = (float)TAPBxCanvas.Width / Xn;
            float dy = (float)TAPBxCanvas.Height / Yn;

            int nx0 = Xn / 2;
            int ny0 = Yn / 2;

            RedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

            try
            {

                float xAlg = Convert.ToSingle(TATBxAlg.Text);
                float xLopp = Convert.ToSingle(TATBxLopp.Text);


                float x1 = xAlg;
                float y1 = GetY(x1);

                for (float x2 = xAlg; x2 < xLopp; x2 += 0.01F)
                {
                    float y2 = GetY(x2);
                    g.DrawLine(CustomPen, (x1 + nx0) * dx, (ny0 - y1) * dy, (x2 + nx0) * dx, (ny0 - y2) * dy);
                    x1 = x2;
                    y1 = y2;
                }
            }

            catch (Exception error)
            {
                TATimer2.Stop();
                TATimer2.Enabled = false;

                TABAutoDraw.Text = "Joonista Automaatselt [Sisse]";
                TATimer2.Stop();
                TABDraw.Enabled = true;
                //TACBxSuvalisedArvud.Checked = false;

                MessageBox.Show(caption: "Error!", text: error.Message,
                                      buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private float GetY(float x)
        {
            double currentY = 0;
            double currentX = x;

            double a = Convert.ToDouble(TATBx0.Text);
            if (TALPlus0.Text == "-") a = -a;

            double b = Convert.ToDouble(TATBx1.Text);
            if (TALPlus1.Text == "-") b = -b;

            double c = Convert.ToDouble(TATBx2.Text);
            if (TALPlus2.Text == "-") c = -c;

            double newX = currentX + 10;

            ///VALEM 10 
            if (newX < 0 && b != 0)
            {
                currentY = (a * Math.Pow(currentX, 2)) + (c * currentX) + b;
            }
            else if (newX > 0 && c == 0)
            {
                currentY = (x - a) / (x - c);
            }
            else
            {
                currentY = (-x / (a - c));
            }

            return (float)currentY;
        }

        private void TALPlus1_Click(object sender, EventArgs e)
        {
            Label symbol = (Label)sender;
            if (symbol.Text == "+")
            {
                symbol.Text = "-";
            }
            else
            {
                symbol.Text = "+";
            }
        }

        private void TABClear_Click(object sender, EventArgs e)
        {
            TAPBxCanvas.Image = null;
            GridY.Text = "10";
            GridX.Text = "10";

            TATBx0.Text = "0";
            TATBx1.Text = "0";
            TATBx2.Text = "0";
        }

        private void Grid(int nx, int ny)
        {

            int Xn = Convert.ToInt32(GridX.Text);
            int Yn = Convert.ToInt32(GridY.Text);

            float dx = (float)TAPBxCanvas.Width / Xn;
            float dy = (float)TAPBxCanvas.Height / Yn;

            ///FOR MAIN GRID
            GrayPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            for (int ix = 0; ix <= Xn; ix++)
            {
                g.DrawLine(GrayPen, ix * dx, 0, ix * dx, TAPBxCanvas.Height);
            }
            for (int iy = 0; iy < Yn; iy++)
            {
                g.DrawLine(GrayPen, 0, iy * dy, TAPBxCanvas.Width, iy * dy);
            }

            ///FOR MIDDLE EMPHASIS
            BlackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            int nx0 = Xn / 2;
            int ny0 = Yn / 2;
            g.DrawLine(BlackPen, nx0 * dx, 0, nx0 * dx, TAPBxCanvas.Height);
            g.DrawLine(BlackPen, 0, ny0 * dy, TAPBxCanvas.Width, ny0 * dy);
        }

        private void GridMain()
        {
            try
            {
                int Xi = Convert.ToInt32(GridX.Text);
                int Yi = Convert.ToInt32(GridY.Text);

                Grid(Xi, Yi);
            }
            catch (Exception error)
            {
                MessageBox.Show(caption: "Error!", text: error.Message,
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

        }

        private void TABVärv_Click(object sender, EventArgs e)
        {
            ColorDialog ColorD = new ColorDialog();

            if (ColorD.ShowDialog() == DialogResult.OK)
            {
                VärvPreview.BackColor = ColorD.Color;
                CustomPen.Color = ColorD.Color;
            }
            else
            {
                VärvPreview.BackColor = Color.WhiteSmoke;
            }
        }

        private void TARBKindelVärv_CheckedChanged(object sender, EventArgs e)
        {
            if (TARBKindelVärv.Checked)
            {
                TABVärv.Enabled = true;
            }

            else
            {
                TABVärv.Enabled = false;
            }
        }

        private void SuvalineVärv()
        {
            //Declaring Random usage
            Random random = new Random();

            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            CustomPen.Color = Color.FromArgb(red, green, blue);

        }

        private void TATBSuurus_Scroll(object sender, EventArgs e)
        {
            CustomPen.Width = TATBSuurus.Value;
        }

        private void TABRandNum_Click(object sender, EventArgs e)
        {
            randomNumbers(1, 20);
        }

        private void randomNumbers(int min, int max)
        {
            Random random = new Random();

            int ran1 = random.Next(min, max);
            int ran2 = random.Next(min, max);
            int ran3 = random.Next(min, max);

            TATBx0.Text = ran1.ToString();
            TATBx1.Text = ran2.ToString();
            TATBx2.Text = ran3.ToString();

            bool isEqual = true;
            while (isEqual == true)
            {
                if (TATBx0.Text == TATBx2.Text)
                {
                    ran1 = random.Next(min, max);
                    TATBx0.Text = ran1.ToString();

                }
                else
                {
                    isEqual = false;
                }
            }

        }

        private void TATimer2_Tick(object sender, EventArgs e)
        {
            TATimer2.Interval = 1;

            DrawAndCheck();
        }

        private void TABAutoDraw_Click(object sender, EventArgs e)
        {
            TATimer2.Interval = 1;

            if (TATimer2.Enabled)
            {
                TABAutoDraw.Text = "Joonista Automaatselt [Sisse]";
                TATimer2.Stop();
                TABDraw.Enabled = true;
                TACBxSuvalisedArvud.Checked = false;
                //randomNumbers(0, 0);

            }
            else
            {
                TABAutoDraw.Text = "Joonista Automaatselt [Välja]";
                TATimer2.Start();
                TABDraw.Enabled = false;
                TACBxSuvalisedArvud.Checked = true;

                //randomNumbers(1, 20);
            }
        }

        private void TACBxSuvalisedArvud_CheckedChanged(object sender, EventArgs e)
        {
            if (TACBxSuvalisedArvud.Checked)
            {
                randomNumbers(1, 20);

            }
            else
            {
                randomNumbers(1, 20);
            }
        }
    }
}
