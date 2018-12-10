using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	public class Draw
	{
		int xStart = 50; // ������� ������� ��������� �����
		int xFinal = 240; // ������� ������� ��������� ������
		int yStart = 50; // ������� ������� ������� ���������
		int yFinal = 250; // ������ ������� ������� ���������
		int xStep = 30; // ���������� ����� ������� ����� �� ��� �
		int yStep = 40; // ���������� ����� ������� ����� �� ��� �
		int fillEllipseWidth = 15; //������������� ������ �����
		int fillEllipseHeight = 15; //������������� ������ �����
		

		/// <summary>
		/// ������� ������� ������� ���� � ��������� ����� �� ��������� ��������������
		/// </summary>
		/// <param name="x">���������� ������� � ������ ����� �� ��� �</param>
		/// <param name="y">���������� ������� � ������ ����� �� ��� �</param>
		/// <param name="g">���������� �������</param>
		/// <returns>���������� ��������� ��������� ����� �������</returns>
		public Coordinates Point (int x, int y, Graphics g)
		{
			int xPointCorrect = 13; //������������ ��������� ����� �� ����� �� ��� � ������������ ����� �������
			int yPointCorrect = 16; //������������ ��������� ����� �� ����� �� ��� � ������������ ������� �������
			while (xStart < xFinal)
			{
				while (yStart <= yFinal)
				{
					if (x > xStart && x < xStart + xStart && y > yStart && y < yStart + yStep)
					{
						g.FillEllipse(Brushes.Black, xStart + xPointCorrect, yStart + yPointCorrect, fillEllipseWidth, fillEllipseHeight);
						return new Coordinates(xStart + xPointCorrect, yStart + yPointCorrect);
					}
					else
					{
						if (yStart == yFinal)
						{
							yStart = 50; //��������� � ��������� ���������
							xStart += xStep;
						}
						else
						{
							yStart += yStep;
						}
					}
				}
			}
			return new Coordinates(0,0);
		}

		/// <summary>
		/// ��������� ����� �����
		/// </summary>
		/// <param name="bitmap">������ �� ������� ���������� ���� �����</param>
		/// <param name="g">���������� �������</param>
		/// <param name="pictureBox">������� � ������� ����� ������� Bitmap</param>
		/// <param name="x">����� �� ��� � � ������� ���������� ��������� �� ��� �</param>
		/// <param name="y">����� �� ��� � � ������� ���������� ��������� �� ��� �</param>
		public void DrawGrid(Bitmap bitmap, Graphics g, PictureBox pictureBox, int x, int y)
		{
			using (g = Graphics.FromImage(bitmap))
			{
				Pen pen = new Pen(Color.Black, 2);
				int x1 = x;
				int y1 = y;
				//������������ �����
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x1, y1, x1, y1 + 200);
					x1 += xStep;
				}
				//��������������
				x1 = x-1;
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x1, y1, x1 + 152, y1);
					y1 += yStep;
				}
			}
			pictureBox.Image = bitmap;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="graphic"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void DrawPoint(Graphics graphic, int x, int y)
		{
			int xPointCorrect = 40; //������������ ��������� ����� �� ����� �� ��� � ������������ ����� �������
			int yPointCorrect = 49; //������������ ��������� ����� �� ����� �� ��� � ������������ ������� �������
			graphic.FillEllipse(Brushes.Black, x - xPointCorrect, y - yPointCorrect, fillEllipseWidth, fillEllipseHeight);
		}

	}
}