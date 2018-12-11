using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	public class Draw
	{
		const int XStart = 50; // ������� ������� ��������� �����
		const int XFinal = 240; // ������� ������� ��������� ������
		const int YStart = 50; // ������� ������� ������� ���������
		const int YFinal = 250; // ������ ������� ������� ���������
		const int XStep = 30; // ���������� ����� ������� ����� �� ��� �
		const int YStep = 40; // ���������� ����� ������� ����� �� ��� �
		const int FillEllipseWidth = 15; //������������� ������ �����
		const int FillEllipseHeight = 15; //������������� ������ �����
		

		/// <summary>
		/// ������� ������� ������� ���� � ��������� ����� �� ��������� ��������������
		/// </summary>
		/// <param name="x">���������� ������� � ������ ����� �� ��� �</param>
		/// <param name="y">���������� ������� � ������ ����� �� ��� �</param>
		/// <param name="g">���������� �������</param>
		/// <returns>���������� ��������� ��������� ����� �������</returns>
		public Coordinates Point (int x, int y, Graphics g)
		{
		    int xTempStart = XStart; // ��������� ���������� ����� ������� ��� �
		    int yTempStart = YStart; // ��������� ���������� ������� ������� ��� �
			int xPointCorrect = 13; //������������ ��������� ����� �� ����� �� ��� � ������������ ����� �������
			int yPointCorrect = 16; //������������ ��������� ����� �� ����� �� ��� � ������������ ������� �������

			while (xTempStart < XFinal)
			{
				while (yTempStart <= YFinal)
				{
					if (x > xTempStart && x < xTempStart + XStep && y > yTempStart && y < yTempStart + YStep)
					{
						g.FillEllipse(Brushes.Black, xTempStart + xPointCorrect, yTempStart + yPointCorrect, FillEllipseWidth, FillEllipseHeight);
						return new Coordinates(xTempStart + xPointCorrect, yTempStart + yPointCorrect);
					}
					else
					{
						if (yTempStart == YFinal)
						{
							yTempStart = 50; //��������� � ��������� ���������
							xTempStart += XStep;
						}
						else
						{
							yTempStart += YStep;
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
					x1 += XStep;
				}
				//��������������
				x1 = x-1;
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x1, y1, x1 + 152, y1);
					y1 += YStep;
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
			graphic.FillEllipse(Brushes.Black, x - xPointCorrect, y - yPointCorrect, FillEllipseWidth, FillEllipseHeight);
		}

	}
}