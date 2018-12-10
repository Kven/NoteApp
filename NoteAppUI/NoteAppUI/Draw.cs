using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	public class Draw
	{
		const int xStart = 50; // ������� ������� ��������� �����
		const int xFinal = 240; // ������� ������� ��������� ������
		const int yStart = 50; // ������� ������� ������� ���������
		const int yFinal = 250; // ������ ������� ������� ���������
		const int xStep = 30; // ���������� ����� ������� ����� �� ��� �
		const int yStep = 40; // ���������� ����� ������� ����� �� ��� �
		const int fillEllipseWidth = 15; //������������� ������ �����
		const int fillEllipseHeight = 15; //������������� ������ �����
		

		/// <summary>
		/// ������� ������� ������� ���� � ��������� ����� �� ��������� ��������������
		/// </summary>
		/// <param name="x">���������� ������� � ������ ����� �� ��� �</param>
		/// <param name="y">���������� ������� � ������ ����� �� ��� �</param>
		/// <param name="g">���������� �������</param>
		/// <returns>���������� ��������� ��������� ����� �������</returns>
		public Coordinates Point (int x, int y, Graphics g)
		{
		    int xTempStart = xStart; // ��������� ���������� ����� ������� ��� �
		    int yTempStart = yStart; // ��������� ���������� ������� ������� ��� �
			int xPointCorrect = 13; //������������ ��������� ����� �� ����� �� ��� � ������������ ����� �������
			int yPointCorrect = 16; //������������ ��������� ����� �� ����� �� ��� � ������������ ������� �������

			while (xTempStart < xFinal)
			{
				while (yTempStart <= yFinal)
				{
					if (x > xTempStart && x < xTempStart + xStep && y > yTempStart && y < yTempStart + yStep)
					{
						g.FillEllipse(Brushes.Black, xTempStart + xPointCorrect, yTempStart + yPointCorrect, fillEllipseWidth, fillEllipseHeight);
						return new Coordinates(xTempStart + xPointCorrect, yTempStart + yPointCorrect);
					}
					else
					{
						if (yTempStart == yFinal)
						{
							yTempStart = 50; //��������� � ��������� ���������
							xTempStart += xStep;
						}
						else
						{
							yTempStart += yStep;
						}
					}
				}
			}
		    throw new Exception("������ � ��������� �����");
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
		/// ����� ��������� ����� ��� ����� ��������� ��������
		/// </summary>
		/// <param name="graphic">���������� ���������</param>
		/// <param name="x">���������� ����� �� ��� �</param>
		/// <param name="y">���������� ����� �� ��� �</param>
		public void DrawPoint(Graphics graphic, int x, int y)
		{
			int xPointCorrect = 40; //������������ ��������� ����� �� ����� �� ��� � ������������ ����� �������
			int yPointCorrect = 49; //������������ ��������� ����� �� ����� �� ��� � ������������ ������� �������
			graphic.FillEllipse(Brushes.Black, x - xPointCorrect, y - yPointCorrect, fillEllipseWidth, fillEllipseHeight);
		}

	}
}