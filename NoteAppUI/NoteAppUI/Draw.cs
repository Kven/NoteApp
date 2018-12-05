using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	static class Draw
	{
		public static (int, int) Point (int x, int y, Graphics g)
		{

			int xStart = 50;
			int xFinal = 240;
			int yStart = 50;
			int yFinal = 250;
			while (xStart < xFinal)
			{
				while (yStart <= yFinal)
				{
					if (x > xStart && x < xStart+30 && y > yStart && y < yStart+40)
					{
						g.FillEllipse(Brushes.Black, xStart + 13, yStart + 16, 15, 15);
						return (xStart + 13, yStart + 16);
					}
					else
					{
						if (yStart == yFinal)
						{
							yStart = 50;
							xStart += 30;
						}
						else
						{
							yStart += 40;
						}
					}
				}
			}
			return (0, 0);
		}

		public static void DrawLabel(int x, int y, Graphics g)
		{
			g.DrawString("" + x + " " + y, SystemFonts.DefaultFont, Brushes.Black, x - 7, y - 7);
		}

		public static void DrawGrid(Bitmap bitmap, Graphics g, PictureBox pictureBox, int x, int y)
		{
			using (g = Graphics.FromImage(bitmap))
			{
				Pen pen = new Pen(Color.Black, 2);
				int x1 = x;
				int y1 = y;
				//вертикальные линии
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x1, y1, x1, y1 + 200);
					x1 += 30;
				}
				//горизонтальные
				x1 = x-1;
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x1, y1, x1 + 152, y1);
					y1 += 40;
				}
			}
			pictureBox.Image = bitmap;
		}


	}
}