using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	public class Draw
	{
		const int XStart = 50; // Граница области рисования слева
		const int XFinal = 240; // Граница области рисования справа
		const int YStart = 50; // Верхняя граница области рисования
		const int YFinal = 250; // Нижняя граница области рисования
		const int XStep = 30; // Расстояние между линиями сетки по оси Х
		const int YStep = 40; // Расстояние между линиями сетки по оси У
		const int FillEllipseWidth = 15; //Устанавливает Ширину точки
		const int FillEllipseHeight = 15; //Устанавливает Высоту точки
		

		/// <summary>
		/// Провека области нажатия мыши и отрисовка точки на ближайшее местоположение
		/// </summary>
		/// <param name="x">Координата курсора в момент клика по оси Х</param>
		/// <param name="y">Коориданта курсора в момент клика по оси У</param>
		/// <param name="g">Инструмент графики</param>
		/// <returns>Возвращает структуру координат точки зажатия</returns>
		public Coordinates Point (int x, int y, Graphics g)
		{
		    int xTempStart = XStart; // локальная переменная левой границы оси Х
		    int yTempStart = YStart; // локальная переменная верхней границы оси У
			int xPointCorrect = 13; //Кооректирует положение точки на сетке по оси Х относительно левой границы
			int yPointCorrect = 16; //Корректирует положение точки на сетке по оси У относительно верхней границы

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
							yTempStart = 50; //Установка в Начальное состояние
							xTempStart += XStep;
						}
						else
						{
							yTempStart += YStep;
						}
					}
				}
			}
		    throw new Exception("Ошибка в отрисовке точки");
		}

		/// <summary>
		/// Отрисовка сетки ладов
		/// </summary>
		/// <param name="bitmap">Битмап на котором отрисуется сама сетка</param>
		/// <param name="g">Инструмент графики</param>
		/// <param name="pictureBox">Контрол в который будет помещен Bitmap</param>
		/// <param name="x">Точка по оси Х с которой начинается отрисовка по оси Х</param>
		/// <param name="y">Точка по оси У с которой начинается отрисовка по оси У</param>
		public void DrawGrid(Bitmap bitmap, Graphics g, PictureBox pictureBox, int x, int y)
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
					x1 += XStep;
				}
				//горизонтальные
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
		/// Метод отрисовки точки для формы просмотра аккордов
		/// </summary>
		/// <param name="graphic">Инструмент рисования</param>
		/// <param name="x">Координата точки по оси Х</param>
		/// <param name="y">Координата точки по оси У</param>
		public void DrawPoint(Graphics graphic, int x, int y)
		{
			int xPointCorrect = 40; //Кооректирует положение точки на сетке по оси Х относительно левой границы
			int yPointCorrect = 49; //Корректирует положение точки на сетке по оси У относительно верхней границы
			graphic.FillEllipse(Brushes.Black, x - xPointCorrect, y - yPointCorrect, FillEllipseWidth, FillEllipseHeight);
		}

	}
}