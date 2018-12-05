using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	public class Draw
	{
		int xStart = 50; // Граница области рисования слева
		int xFinal = 240; // Граница области рисования справа
		int yStart = 50; // Верхняя граница области рисования
		int yFinal = 250; // Нижняя граница области рисования
		int xStep = 30; // Расстояние между линиями сетки по оси Х
		int yStep = 40; // Расстояние между линиями сетки по оси У
		int fillEllipseWidth = 15; //Устанавливает Ширину точки
		int fillEllipseHeight = 15; //Устанавливает Высоту точки
		

		/// <summary>
		/// Провека области нажатия мыши и отрисовка точки на ближайшее местоположение
		/// </summary>
		/// <param name="x">Координата курсора в момент клика по оси Х</param>
		/// <param name="y">Коориданта курсора в момент клика по оси У</param>
		/// <param name="g">Инструмент графики</param>
		/// <returns>Возвращает структуру координат точки зажатия</returns>
		public Coordinates Point (int x, int y, Graphics g)
		{
			int xPointCorrect = 13; //Кооректирует положение точки на сетке по оси Х относительно левой границы
			int yPointCorrect = 16; //Корректирует положение точки на сетке по оси У относительно верхней границы
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
							yStart = 50; //Установка в Начальное состояние
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
					x1 += xStep;
				}
				//горизонтальные
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
			int xPointCorrect = 40; //Кооректирует положение точки на сетке по оси Х относительно левой границы
			int yPointCorrect = 49; //Корректирует положение точки на сетке по оси У относительно верхней границы
			graphic.FillEllipse(Brushes.Black, x - xPointCorrect, y - yPointCorrect, fillEllipseWidth, fillEllipseHeight);
		}

	}
}