using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using iz_BibliotekaKomponentow;

namespace ComplexZiemiecki42601
{
    public partial class iz_MainWindow : Form
    {
        iz_Complex iz_Wynik;
        public iz_MainWindow()
        {
            InitializeComponent();
        }

        private void iz_redraw_pb1()
        {
            iz_pb1.Refresh();
            Graphics iz_Graphics = iz_pb1.CreateGraphics();
            iz_Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen iz_Pen = new Pen(Color.Black, 1);
            Point iz_Point1, iz_Point2;
            Font iz_Font = new Font(Font.Name, 10.0f);
            SolidBrush iz_Brush = new SolidBrush(Color.Black);

            {//drawing the vertical axis
                iz_Pen.EndCap = LineCap.NoAnchor;
                int iz_unit = 0;

                iz_Pen.DashStyle = DashStyle.Dash;
                //drawing unit lines
                for (int i = iz_pb1.Height / 2; i <= iz_pb1.Height - 10; i += iz_pb1.Height / 10)
                {

                    {   //drawing the 'long' lines with low opacity
                        iz_Pen.Color = Color.LightGray;
                        iz_Point1 = new Point(10, i);
                        iz_Point2 = new Point(iz_pb1.Width - 10, i);
                        iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);


                        iz_Point1 = new Point(10, iz_pb1.Height - i);
                        iz_Point2 = new Point(iz_pb1.Width - 10, iz_pb1.Height - i);
                        iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    }

                    iz_Pen.Color = Color.Black;
                    iz_Point1 = new Point(iz_pb1.Width / 2 - 5, i);
                    iz_Point2 = new Point(iz_pb1.Width / 2 + 5, i);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb1.Height / 2)
                        iz_Graphics.DrawString("-" + iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);

                    iz_Point1 = new Point(iz_pb1.Width / 2 - 5, iz_pb1.Height - i);
                    iz_Point2 = new Point(iz_pb1.Width / 2 + 5, iz_pb1.Height - i);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb1.Height / 2)
                        iz_Graphics.DrawString(iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);
                    iz_unit += 1;
                }

                iz_Pen.DashStyle = DashStyle.Solid;
                iz_Pen.EndCap = LineCap.ArrowAnchor;
                iz_Pen.Color = Color.Black;
                iz_Point1 = new Point(iz_pb1.Width / 2, iz_pb1.Height - 10);
                iz_Point2 = new Point(iz_pb1.Width / 2, 10);

                iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
            }

            {//drawing the horizontal axis
                int iz_unit = 0;
                iz_Pen.EndCap = LineCap.NoAnchor;
                for (int i = iz_pb1.Width / 2; i <= iz_pb1.Width - 10; i += iz_pb1.Width / 10)
                {
                    {   //drawing the 'long' lines with low opacity
                        iz_Pen.Color = Color.LightGray;
                        iz_Point1 = new Point(i, 10);
                        iz_Point2 = new Point(i, iz_pb1.Height - 10);
                        if (i != iz_pb1.Width / 2)
                            iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);


                        iz_Point1 = new Point(iz_pb1.Width - i, 10);
                        iz_Point2 = new Point(iz_pb1.Width - i, iz_pb1.Height - 10);
                        if (i != iz_pb1.Width / 2)
                            iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    }

                    iz_Pen.Color = Color.Black;
                    iz_Point1 = new Point(i, iz_pb1.Height / 2 - 5);
                    iz_Point2 = new Point(i, iz_pb1.Height / 2 + 5);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb1.Height / 2)
                        iz_Graphics.DrawString(iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);

                    iz_Point1 = new Point(iz_pb1.Width - i, iz_pb1.Height / 2 - 5);
                    iz_Point2 = new Point(iz_pb1.Width - i, iz_pb1.Height / 2 + 5);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb1.Height / 2)
                        iz_Graphics.DrawString("-" + iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);
                    iz_unit += 1;
                }

                iz_Pen.EndCap = LineCap.ArrowAnchor;
                iz_Pen.Color = Color.Black;
                iz_Point1 = new Point(10, iz_pb1.Height / 2);
                iz_Point2 = new Point(iz_pb1.Width - 10, iz_pb1.Height / 2);

                iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
            }


            //drawing the point representing our number
            iz_Brush.Color = Color.Red;
            iz_Graphics.FillEllipse(iz_Brush,
                iz_pb1.Width / 2 + ((float)iz_txt_z1_re.Value * iz_pb1.Width / 10) - 2.5f,
                iz_pb1.Height / 2 - ((float)iz_txt_z1_im.Value * iz_pb1.Height / 10) - 2.5f, 5, 5);
        }
        private void iz_redraw_pb2()
        {
            iz_pb2.Refresh();
            Graphics iz_Graphics = iz_pb2.CreateGraphics();
            iz_Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen iz_Pen = new Pen(Color.Black, 1);
            Point iz_Point1, iz_Point2;
            Font iz_Font = new Font(Font.Name, 10.0f);
            SolidBrush iz_Brush = new SolidBrush(Color.Black);

            {//drawing the vertical axis
                iz_Pen.EndCap = LineCap.NoAnchor;
                int iz_unit = 0;

                iz_Pen.DashStyle = DashStyle.Dash;
                //drawing unit lines
                for (int i = iz_pb2.Height / 2; i <= iz_pb2.Height - 10; i += iz_pb2.Height / 10)
                {

                    {   //drawing the 'long' lines with low opacity
                        iz_Pen.Color = Color.LightGray;
                        iz_Point1 = new Point(10, i);
                        iz_Point2 = new Point(iz_pb2.Width - 10, i);
                        iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);


                        iz_Point1 = new Point(10, iz_pb2.Height - i);
                        iz_Point2 = new Point(iz_pb2.Width - 10, iz_pb2.Height - i);
                        iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    }

                    iz_Pen.Color = Color.Black;
                    iz_Point1 = new Point(iz_pb2.Width / 2 - 5, i);
                    iz_Point2 = new Point(iz_pb2.Width / 2 + 5, i);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb2.Height / 2)
                        iz_Graphics.DrawString("-" + iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);

                    iz_Point1 = new Point(iz_pb2.Width / 2 - 5, iz_pb2.Height - i);
                    iz_Point2 = new Point(iz_pb2.Width / 2 + 5, iz_pb2.Height - i);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb2.Height / 2)
                        iz_Graphics.DrawString(iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);
                    iz_unit += 1;
                }

                iz_Pen.DashStyle = DashStyle.Solid;
                iz_Pen.EndCap = LineCap.ArrowAnchor;
                iz_Pen.Color = Color.Black;
                iz_Point1 = new Point(iz_pb2.Width / 2, iz_pb2.Height - 10);
                iz_Point2 = new Point(iz_pb2.Width / 2, 10);

                iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
            }

            {//drawing the horizontal axis
                int iz_unit = 0;
                iz_Pen.EndCap = LineCap.NoAnchor;
                for (int i = iz_pb2.Width / 2; i <= iz_pb2.Width - 10; i += iz_pb2.Width / 10)
                {
                    {   //drawing the 'long' lines with low opacity
                        iz_Pen.Color = Color.LightGray;
                        iz_Point1 = new Point(i, 10);
                        iz_Point2 = new Point(i, iz_pb2.Height - 10);
                        if (i != iz_pb2.Width / 2)
                            iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);


                        iz_Point1 = new Point(iz_pb2.Width - i, 10);
                        iz_Point2 = new Point(iz_pb2.Width - i, iz_pb2.Height - 10);
                        if (i != iz_pb2.Width / 2)
                            iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    }

                    iz_Pen.Color = Color.Black;
                    iz_Point1 = new Point(i, iz_pb2.Height / 2 - 5);
                    iz_Point2 = new Point(i, iz_pb2.Height / 2 + 5);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb2.Height / 2)
                        iz_Graphics.DrawString(iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);

                    iz_Point1 = new Point(iz_pb2.Width - i, iz_pb2.Height / 2 - 5);
                    iz_Point2 = new Point(iz_pb2.Width - i, iz_pb2.Height / 2 + 5);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb2.Height / 2)
                        iz_Graphics.DrawString("-" + iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);
                    iz_unit += 1;
                }

                iz_Pen.EndCap = LineCap.ArrowAnchor;
                iz_Pen.Color = Color.Black;
                iz_Point1 = new Point(10, iz_pb2.Height / 2);
                iz_Point2 = new Point(iz_pb2.Width - 10, iz_pb2.Height / 2);

                iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
            }

            //drawing the point representing our number
            iz_Brush.Color = Color.Blue;
            iz_Graphics.FillEllipse(iz_Brush,
                iz_pb2.Width / 2 + ((float)iz_txt_z2_re.Value * iz_pb2.Width / 10) - 2.5f,
                iz_pb2.Height / 2 - ((float)iz_txt_z2_im.Value * iz_pb2.Height / 10) - 2.5f, 5, 5);
        }
        private void iz_redraw_pb3()
        {
            iz_pb3.Refresh();
            Graphics iz_Graphics = iz_pb3.CreateGraphics();
            iz_Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen iz_Pen = new Pen(Color.Black, 1);
            Point iz_Point1, iz_Point2;
            Font iz_Font = new Font(Font.Name, 10.0f);
            SolidBrush iz_Brush = new SolidBrush(Color.Black);

            {//drawing the vertical axis
                iz_Pen.EndCap = LineCap.NoAnchor;
                int iz_unit = 0;

                iz_Pen.DashStyle = DashStyle.Dash;
                //drawing unit lines
                for (int i = iz_pb3.Height / 2; i <= iz_pb3.Height - 10; i += iz_pb3.Height / 10)
                {

                    {   //drawing the 'long' lines with low opacity
                        iz_Pen.Color = Color.LightGray;
                        iz_Point1 = new Point(10, i);
                        iz_Point2 = new Point(iz_pb3.Width - 10, i);
                        iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);


                        iz_Point1 = new Point(10, iz_pb3.Height - i);
                        iz_Point2 = new Point(iz_pb3.Width - 10, iz_pb3.Height - i);
                        iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    }

                    iz_Pen.Color = Color.Black;
                    iz_Point1 = new Point(iz_pb3.Width / 2 - 5, i);
                    iz_Point2 = new Point(iz_pb3.Width / 2 + 5, i);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb3.Height / 2)
                        iz_Graphics.DrawString("-" + iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);

                    iz_Point1 = new Point(iz_pb3.Width / 2 - 5, iz_pb3.Height - i);
                    iz_Point2 = new Point(iz_pb3.Width / 2 + 5, iz_pb3.Height - i);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb3.Height / 2)
                        iz_Graphics.DrawString(iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);
                    iz_unit += 1;
                }

                iz_Pen.DashStyle = DashStyle.Solid;
                iz_Pen.EndCap = LineCap.ArrowAnchor;
                iz_Pen.Color = Color.Black;
                iz_Point1 = new Point(iz_pb3.Width / 2, iz_pb3.Height - 10);
                iz_Point2 = new Point(iz_pb3.Width / 2, 10);

                iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
            }

            {//drawing the horizontal axis
                int iz_unit = 0;
                iz_Pen.EndCap = LineCap.NoAnchor;
                for (int i = iz_pb3.Width / 2; i <= iz_pb3.Width - 10; i += iz_pb3.Width / 10)
                {
                    {   //drawing the 'long' lines with low opacity
                        iz_Pen.Color = Color.LightGray;
                        iz_Point1 = new Point(i, 10);
                        iz_Point2 = new Point(i, iz_pb3.Height - 10);
                        if (i != iz_pb3.Width / 2)
                            iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);


                        iz_Point1 = new Point(iz_pb3.Width - i, 10);
                        iz_Point2 = new Point(iz_pb3.Width - i, iz_pb3.Height - 10);
                        if (i != iz_pb3.Width / 2)
                            iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    }

                    iz_Pen.Color = Color.Black;
                    iz_Point1 = new Point(i, iz_pb3.Height / 2 - 5);
                    iz_Point2 = new Point(i, iz_pb3.Height / 2 + 5);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb3.Height / 2)
                        iz_Graphics.DrawString(iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);

                    iz_Point1 = new Point(iz_pb3.Width - i, iz_pb3.Height / 2 - 5);
                    iz_Point2 = new Point(iz_pb3.Width - i, iz_pb3.Height / 2 + 5);
                    iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
                    if (i != iz_pb3.Height / 2)
                        iz_Graphics.DrawString("-" + iz_unit.ToString(), iz_Font, iz_Brush, iz_Point2);
                    iz_unit += 1;
                }

                iz_Pen.EndCap = LineCap.ArrowAnchor;
                iz_Pen.Color = Color.Black;
                iz_Point1 = new Point(10, iz_pb3.Height / 2);
                iz_Point2 = new Point(iz_pb3.Width - 10, iz_pb3.Height / 2);

                iz_Graphics.DrawLine(iz_Pen, iz_Point1, iz_Point2);
            }

            //drawing a point representing our number
            iz_Brush.Color = Color.LimeGreen;
            iz_Pen.EndCap = LineCap.NoAnchor;

            iz_Pen.Color = Color.LightBlue;
            iz_Pen.DashStyle = DashStyle.Dash;

            iz_Graphics.DrawLine(iz_Pen,
                iz_pb3.Width / 2,
                iz_pb3.Height / 2 - (float)(iz_Wynik.iz_im * iz_pb3.Height/10),
                iz_pb3.Width / 2 + (float)(iz_Wynik.iz_re * iz_pb3.Width / 10),
                iz_pb3.Height / 2 - (float)(iz_pb3.Height / 10 * iz_Wynik.iz_im));

            iz_Graphics.DrawLine(iz_Pen,
                iz_pb3.Width / 2 + (float)(iz_Wynik.iz_re * iz_pb3.Width / 10),
                iz_pb3.Height / 2,
                iz_pb3.Width / 2 + (float)(iz_Wynik.iz_re * iz_pb3.Width / 10),
                iz_pb3.Height / 2 - (float)(iz_pb3.Height / 10 * iz_Wynik.iz_im));
            iz_Pen.Color = Color.LimeGreen;
            iz_Pen.DashStyle = DashStyle.Solid;
            iz_Graphics.DrawLine(iz_Pen, iz_pb3.Width / 2, iz_pb3.Height / 2, iz_pb3.Width / 2 + ((float)(iz_Wynik.iz_re * iz_pb3.Width / 10)),
                iz_pb3.Height / 2 - ((float)iz_Wynik.iz_im * iz_pb3.Height / 10));

            iz_Graphics.FillEllipse(iz_Brush,
                iz_pb3.Width / 2 + ((float)(iz_Wynik.iz_re * iz_pb3.Width / 10) - 2.5f),
                iz_pb3.Height / 2 - ((float)iz_Wynik.iz_im * iz_pb3.Height / 10) - 2.5f, 5, 5);
            iz_Graphics.DrawString(iz_Wynik.ToString(), iz_Font, iz_Brush, iz_pb3.Width / 2 + ((float)(iz_Wynik.iz_re * iz_pb3.Width / 10)),
                iz_pb3.Height / 2 - ((float)iz_Wynik.iz_im * iz_pb3.Height / 10));
        }

        private void iz_GraphVisible()
        {
            iz_lblresult_title.Visible = false;
            iz_lbl_result.Visible = false;
            iz_pb3.Visible = true;
            iz_redraw_pb3();
        }
        private void iz_ResultsVisible()
        {
            iz_lblresult_title.Visible = true;
            iz_lbl_result.Visible = true;
            iz_pb3.Visible = false;
        }

        private void iz_txt_z1_re_ValueChanged(object sender, EventArgs e)
        {
            iz_redraw_pb1();
        }

        private void iz_txt_z1_im_ValueChanged(object sender, EventArgs e)
        {
            iz_redraw_pb1();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            iz_redraw_pb2();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            iz_redraw_pb2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = iz_Z1 + iz_Z2;
            iz_GraphVisible();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = iz_Z1 - iz_Z2;
            iz_GraphVisible();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = iz_Z1 / iz_Z2;
            iz_GraphVisible();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = iz_Z1 * iz_Z2;
            iz_GraphVisible();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_lblresult_title.Text = "Czy Z1 jest równe Z2?";
            iz_lbl_result.Text = "Nie jest.";
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            if (iz_Z1 == iz_Z2)
                iz_lbl_result.Text = "Tak, jest.";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_lblresult_title.Text = "Czy Z1 nie jest równe Z2?";
            iz_lbl_result.Text = "Nie, są równe.";
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            if (iz_Z1 != iz_Z2)
                iz_lbl_result.Text = "Nie są sobie równe.";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_lblresult_title.Text = "Czy Z1 jest mniejsze niż Z2?";
            iz_lbl_result.Text = "Nie.";
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            if (iz_Z1 < iz_Z2)
                iz_lbl_result.Text = "Tak.";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_lblresult_title.Text = "Czy Z1 jest większe niż Z2?";
            iz_lbl_result.Text = "Nie.";
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            if (iz_Z1 > iz_Z2)
                iz_lbl_result.Text = "Tak.";

        }

        private void button23_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_lblresult_title.Text = "Czy Z1 jest mniejsze\n lub równe Z2?";
            iz_lbl_result.Text = "Nie.";
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            if (iz_Z1 <= iz_Z2)
                iz_lbl_result.Text = "Tak.";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_lblresult_title.Text = "Czy Z1 jest większe\n lub równe Z2?";
            iz_lbl_result.Text = "Nie.";
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            if (iz_Z1 >= iz_Z2)
                iz_lbl_result.Text = "Tak.";

        }

        private void button32_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_lblresult_title.Text = "Jawna konwersja (float) Z:";
            iz_lbl_result.Text = "(float)Z1 = " + ((float)iz_Z1).ToString() + "\n(float)Z2 = " + ((float)iz_Z2).ToString();

        }

        private void button31_Click(object sender, EventArgs e)
        {
            iz_Wynik = (float)iz_txt_x.Value;
            iz_GraphVisible();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_lblresult_title.Text = "Rzeczywista część Z:";
            iz_lbl_result.Text = "(Re)Z1 = " + iz_Z1.iz_re.ToString() + "\n(Re)Z2 = " + iz_Z2.iz_re.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            iz_ResultsVisible();
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_lblresult_title.Text = "Urojona część Z:";
            iz_lbl_result.Text = "(Im)Z1 = " + iz_Z1.iz_im.ToString() + "\n(Im)Z2 = " + iz_Z2.iz_im.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Wynik = ~iz_Z1;
            iz_GraphVisible();
        }

        private void button6_Click(object sender, EventArgs e)
        {


            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = ~iz_Z2;
            iz_GraphVisible();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Wynik = iz_Z1 + (float)iz_txt_x.Value;
            iz_GraphVisible();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = iz_Z2 + (float)iz_txt_x.Value;
            iz_GraphVisible();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Wynik = -iz_Z1;
            iz_GraphVisible();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = -iz_Z2;
            iz_GraphVisible();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Wynik = 1 / iz_Z1;
            iz_GraphVisible();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = 1 / iz_Z2;
            iz_GraphVisible();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Wynik = !iz_Z1;
            iz_GraphVisible();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = !iz_Z2;
            iz_GraphVisible();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);

            //Podobnie w komentarzu dot. liczb zespolonych w bibliotece dll, z powodu braku wiedzy nt. liczb zespolonych
            //oraz wyniku samodzielnego poszukiwania odpowiedzi nt. potęgowania liczb zespolonych, 
            //po paru godzinach prób i błędów, które spełzły na niczym,
            //poddałem się i do potęg i pierwiastków użyję w części biblioteki System.Numerics

            System.Numerics.Complex iz_potega = new System.Numerics.Complex(iz_Z1.iz_re, iz_Z1.iz_im);
            iz_potega = System.Numerics.Complex.Pow(iz_potega, (double)iz_txt_x.Value);
            iz_Wynik = new iz_Complex(iz_potega.Real, iz_potega.Imaginary);
            iz_GraphVisible();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);

            //Podobnie w komentarzu dot. liczb zespolonych w bibliotece dll, z powodu braku wiedzy nt. liczb zespolonych
            //oraz wyniku samodzielnego poszukiwania odpowiedzi nt. potęgowania liczb zespolonych, 
            //po paru godzinach prób i błędów, które spełzły na niczym,
            //poddałem się i do potęg i pierwiastków użyję w części biblioteki System.Numerics

            System.Numerics.Complex iz_potega = new System.Numerics.Complex(iz_Z2.iz_re, iz_Z2.iz_im);
            iz_potega = System.Numerics.Complex.Pow(iz_potega, (double)iz_txt_x.Value);
            iz_Wynik = new iz_Complex(iz_potega.Real, iz_potega.Imaginary);
            iz_GraphVisible();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Wynik = !iz_Z1;
            iz_GraphVisible();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = !iz_Z2;
            iz_GraphVisible();
        }

        private void button28_Click(object sender, EventArgs e)
        {

            iz_Complex iz_Z1 = new iz_Complex((double)iz_txt_z1_re.Value, (double)iz_txt_z1_im.Value);
            iz_Wynik = iz_Z1 * (float)iz_txt_x.Value;
            iz_GraphVisible();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            iz_Complex iz_Z2 = new iz_Complex((double)iz_txt_z2_re.Value, (double)iz_txt_z2_im.Value);
            iz_Wynik = iz_Z2 * (float)iz_txt_x.Value;
            iz_GraphVisible();

        }





    }
}
