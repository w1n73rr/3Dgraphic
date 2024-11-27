namespace _3Dgraphic
{
    public partial class Form1 : Form
    {


        private double angleX = 0, angleY = 0, angleZ = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private double  R = 0;
        private double r = 0;
        private double A = 0;
        private double B = 0;
        int dl = 0;
        double degree_a = 0;
        double degree_b = 0;
        double degree_c = 0;
        int measure = 1;

        public void Draw_Spiral()
        {
            // Считываем данные
            r = double.Parse(tb_RR.Text);  // Малый радиус
            A = double.Parse(tb_A.Text);  // Начальный радиус
            B = double.Parse(tb_B.Text);  // Постоянная
            dl = trackbar_movement.Value;  // Дистанция
            degree_a = trackbar_turn_x.Value * Math.PI / 180;  // Поворот по оси X
            degree_b = trackbar_turn_y.Value * Math.PI / 180;  // Поворот по оси Y
            degree_c = trackbar_turn_z.Value * Math.PI / 180;  // Поворот по оси Z
            measure = trackbar_size.Value;  // Масштаб

            // Стартовые значения рисунка
            Bitmap mbit = new Bitmap(picbox.Width, picbox.Height);
            Graphics gr = Graphics.FromImage(mbit);
            gr.Clear(Color.Black);
            Pen MyPen = new Pen(Color.White);

            // Количество точек
            int numPoints = 20;
            double[] spiral_x = new double[numPoints];
            double[] spiral_y = new double[numPoints];
            double[] spiral_z = new double[numPoints];

            // Начальные углы
            double alpha = 0;
            double beta = -2 * Math.PI;

            // Шаг изменения углов
            double dalpha = Math.PI / 360;  // Шаг для alpha
            double dbeta = Math.PI / 4; // Шаг для beta

            // Генерация точек спирали
            for (int i = 0; i < numPoints; i++)
            {
                R = A + B * beta;  // Вычисление радиуса

                // Координаты в пространстве
                spiral_x[i] = (R + r * Math.Cos(alpha)) * Math.Sin(beta);
                spiral_y[i] = (R + r * Math.Cos(alpha)) * Math.Cos(beta);
                spiral_z[i] = r * Math.Sin(alpha);

                // Обновление углов
                alpha += dalpha;
                beta += dbeta;
            }

            // Аффинные преобразования (масштабирование, повороты, смещение)
            for (int i = 0; i < numPoints; i++)
            {
                double sina = Math.Sin(degree_a);
                double sinb = Math.Sin(degree_b);
                double sinc = Math.Sin(degree_c);
                double cosa = Math.Cos(degree_a);
                double cosb = Math.Cos(degree_b);
                double cosc = Math.Cos(degree_c);

                double x = spiral_x[i];
                double y = spiral_y[i];
                double z = spiral_z[i];

                // Преобразование координат
                spiral_x[i] = (x * cosb * cosc + y * sina * sinb * cosc - y * sinc * cosa + z * sinc * sina + z * sinb * cosa * cosc) * measure * 10;
                spiral_y[i] = ((x * sinc * cosb + y * cosa * cosc + y * sinb * sina * sinc - z * sina * cosc + z * sinb * sinc * cosa) * measure * 10) + dl + 263;
                spiral_z[i] = (-x * sinb + y * cosb * sina + z * cosa * cosb) * measure * 10 + 159;
            }

            // Рисуем линии между точками
            for (int i = 0; i < numPoints - 1; i++)
            {
                int screenX1 = Convert.ToInt32(spiral_y[i]);
                int screenY1 = Convert.ToInt32(spiral_z[i]);

                int screenX2 = Convert.ToInt32(spiral_y[i + 1]);
                int screenY2 = Convert.ToInt32(spiral_z[i + 1]);

                int circleRadius = 10;
                int numCirclePoints = 36;

                bresenharmCircle(screenX1, screenY1, circleRadius, mbit);
                bresenharmCircle(screenX2, screenY2, circleRadius, mbit);

                List<Point> points1 = GetCirclePoints(screenX1, screenY1, circleRadius, numCirclePoints);
                List<Point> points2 = GetCirclePoints(screenX2, screenY2, circleRadius, numCirclePoints);

                // Соединяем соответствующие точки двух окружностей
                for (int j = 0; j < numCirclePoints; j++)
                {
                    int nextIndex = (j + 1) % numCirclePoints; // Для замыкания окружности

                    // Соединяем точки между окружностями
                    gr.DrawLine(MyPen, points1[j], points2[j]);

                    // Соединяем соседние точки в каждой окружности
                    gr.DrawLine(MyPen, points1[j], points1[nextIndex]);
                    gr.DrawLine(MyPen, points2[j], points2[nextIndex]);
                }
            }

            // Отображение результата
            picbox.Image = mbit;
            picbox.Invalidate();
        }

        public List<Point> GetCirclePoints(int centerX, int centerY, int radius, int numPoints)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < numPoints; i++)
            {
                double angle = 2 * Math.PI * i / numPoints; // Угол текущей точки
                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY + (int)(radius * Math.Sin(angle));
                points.Add(new Point(x, y));
            }
            return points;
        }

        public void draw8Pixels(int x, int y, int x0, int y0, Color color, Bitmap map)
        {
            map.SetPixel(x + x0, y + y0, color);
            map.SetPixel(x + x0, -y + y0, color);
            map.SetPixel(-x + x0, y + y0, color);
            map.SetPixel(-x + x0, -y + y0, color);
            map.SetPixel(y + x0, x + y0, color);
            map.SetPixel(y + x0, -x + y0, color);
            map.SetPixel(-y + x0, x + y0, color);
            map.SetPixel(-y + x0, -x + y0, color);
        }
        //Алгоритм Брезенхама рисования окружности
        public void bresenharmCircle(int x0, int y0, int R, Bitmap map)
        {
            int x = 0; int y = R; int d = 3 - 2 * R;
            while (y >= x)
            {
                draw8Pixels(x, y, x0, y0, Color.White, map);
                if (d <= 0) d = d + 4 * x + 6;
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }
        }
        private void TimerTick(object sender, EventArgs e)
        {
            angleX += 0.01;
            angleY += 0.01;
            Draw_Spiral();
        }
        private void trackbar_size_Scroll(object sender, EventArgs e)
        {
            Draw_Spiral();
        }

        private void trackbar_turn_Scroll(object sender, EventArgs e)
        {
            Draw_Spiral();
        }

        private void trackbar_movement_Scroll(object sender, EventArgs e)
        {
            Draw_Spiral();
        }

        private void trackbar_turn_y_Scroll(object sender, EventArgs e)
        {
            Draw_Spiral();
        }

        private void trackbar_turn_z_Scroll(object sender, EventArgs e)
        {
            Draw_Spiral();
        }
        private void trackbar_turn_x_Scroll(object sender, EventArgs e)
        {
            Draw_Spiral();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tb_RR.Text != ""))
            {
                //Отображаем элементы преобразования


                trackbar_movement.Value = 0;
                trackbar_turn_x.Value = 0;
                trackbar_turn_y.Value = 0;
                trackbar_turn_z.Value = 0;
                trackbar_size.Value = 5;

                Draw_Spiral();


            }
        }
    }
}
