using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	static class Draw
	{
		public static void Check (int x, int y, Graphics g)
		{
			// первый столбец
			if (x > 58 && x < 80) //точки x+13  y+16
			{ 
				if (y > 50 && y < 90) 
				{
					g.FillEllipse(Brushes.Black, 63, 66, 15, 15);
				}
				else if (y> 90 && y < 130)
				{
					g.FillEllipse(Brushes.Black, 63, 106, 15, 15);
				}
				else if (y > 130 && y < 170)
				{
					g.FillEllipse(Brushes.Black, 63, 146, 15, 15);
				}
				else if (y > 170 && y < 210)
				{
					g.FillEllipse(Brushes.Black, 63, 186, 15, 15);
				}
				else if (y > 210 && y < 270)
				{
					g.FillEllipse(Brushes.Black, 63, 226, 15, 15);
				}
			}
			else if (x > 80 && x < 110) //второй столбец
			{
				if (y > 50 && y < 90)
				{
					g.FillEllipse(Brushes.Black, 93, 66, 15, 15);
				}
				else if (y > 90 && y < 130)
				{
					g.FillEllipse(Brushes.Black, 93, 106, 15, 15);
				}
				else if (y > 130 && y < 170)
				{
					g.FillEllipse(Brushes.Black, 93, 146, 15, 15);
				}
				else if (y > 170 && y < 210)
				{
					g.FillEllipse(Brushes.Black, 93, 186, 15, 15);
				}
				else if (y > 210 && y < 270)
				{
					g.FillEllipse(Brushes.Black, 93, 226, 15, 15);
				}
			}
			else if (x > 110 && x < 140) // третий столбец
			{
				if (y > 50 && y < 90)
				{
					g.FillEllipse(Brushes.Black, 123, 66, 15, 15);
				}
				else if (y > 90 && y < 130)
				{
					g.FillEllipse(Brushes.Black, 123, 106, 15, 15);
				}
				else if (y > 130 && y < 170)
				{
					g.FillEllipse(Brushes.Black, 123, 146, 15, 15);
				}
				else if (y > 170 && y < 210)
				{
					g.FillEllipse(Brushes.Black, 123, 186, 15, 15);
				}
				else if (y > 210 && y < 250)
				{
					g.FillEllipse(Brushes.Black, 123, 226, 15, 15);
				}
			}
			else if (x > 140 && x < 170) // четвертый столбец
			{
				if (y > 50 && y < 90)
				{
					g.FillEllipse(Brushes.Black, 153, 66, 15, 15);
				}
				else if (y > 90 && y < 130)
				{
					g.FillEllipse(Brushes.Black, 153, 106, 15, 15);
				}
				else if (y > 130 && y < 170)
				{
					g.FillEllipse(Brushes.Black, 153, 146, 15, 15);
				}
				else if (y > 170 && y < 210)
				{
					g.FillEllipse(Brushes.Black, 153, 186, 15, 15);
				}
				else if (y > 210 && y < 250)
				{
					g.FillEllipse(Brushes.Black, 153, 226, 15, 15);
				}
			}
			else if (x > 170 && x < 200) // пятый столбец
			{
				if (y > 50 && y < 90)
				{
					g.FillEllipse(Brushes.Black, 183, 66, 15, 15);
				}
				else if (y > 90 && y < 130)
				{
					g.FillEllipse(Brushes.Black, 183, 106, 15, 15);
				}
				else if (y > 130 && y < 170)
				{
					g.FillEllipse(Brushes.Black, 183, 146, 15, 15);
				}
				else if (y > 170 && y < 210)
				{
					g.FillEllipse(Brushes.Black, 183, 186, 15, 15);
				}
				else if (y > 210 && y < 250)
				{
					g.FillEllipse(Brushes.Black, 183, 226, 15, 15);
				}
			}
			else if (x > 200 && x < 240) // шестой столбец
			{
				if (y > 50 && y < 90)
				{
					g.FillEllipse(Brushes.Black, 213, 66, 15, 15);
				}
				else if (y > 90 && y < 130)
				{
					g.FillEllipse(Brushes.Black, 213, 106, 15, 15);
				}
				else if (y > 130 && y < 170)
				{
					g.FillEllipse(Brushes.Black, 213, 146, 15, 15);
				}
				else if (y > 170 && y < 210)
				{
					g.FillEllipse(Brushes.Black, 213, 186, 15, 15);
				}
				else if (y > 210 && y < 250)
				{
					g.FillEllipse(Brushes.Black, 213, 226, 15, 15);
				}
			}
		}

		public static void DrawString(int x, int y, Graphics g)
		{
			g.DrawString("" + x + " " + y, SystemFonts.DefaultFont, Brushes.Black, x - 7, y - 7);
		}

		public static void DrawGrid(Bitmap bitmap, Graphics g, PictureBox pictureBox)
		{
			using (g = Graphics.FromImage(bitmap))
			{
				Pen pen = new Pen(Color.Black, 2);
				int x = 70;
				int y = 55;
				//вертикальные линии
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x, y, x, y + 200);
					x += 30;
				}
				//горизонтальные
				x = 69;
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x, y, x + 152, y);
					y += 40;
				}
			}
			pictureBox.Image = bitmap;
		}









	}
}