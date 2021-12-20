using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Kyrsach
{
    class CircleColor
    {
        //Делегат вызываемый при пересечении двух объектов
        private Action<Particle, CircleColor>? onOverlap;
        public float X = 60;
        public float Y = 60;
        public float Radius= 55;
        public Color color = Color.Red;
        public Random random = new();

        internal Action<Particle, CircleColor> OnOverlap { get => onOverlap; set => onOverlap = value; }

        //Рендер объекта
        public void Render(Graphics g) {
            g.DrawEllipse(new Pen(color,3), X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
        public GraphicsPath GetGraphicsPath()
        {
            var path = new GraphicsPath();
            path.AddEllipse(X - Radius, Y - Radius, Radius * 2, Radius * 2);
            return path;
        }
        public bool Overlaps(Particle obj, Graphics g)
        {
            // берем информацию о форме
            var path1 = this.GetGraphicsPath();
            var path2 = obj.GetGraphicsPath();

            // используем класс Region, который позволяет определить 
            // пересечение объектов в данном графическом контексте
            var region = new Region(path1);
            region.Intersect(path2); // пересекаем формы
            return !region.IsEmpty(g); // если полученная форма не пуста то значит было пересечение
        }
        public void ColorChange(int i)
        {
            switch (i)
            {
                case 1:
                    {
                        color = Color.Aqua;
                        break;
                    }
                case 2:
                    {
                        color = Color.BlueViolet;
                        break;
                    }
                case 3:
                    {
                        color = Color.OrangeRed;
                        break;
                    }
                case 4:
                    {
                        color = Color.CadetBlue;
                        break;
                    }
                case 5:
                    {
                        color = Color.Chocolate;
                        break;
                    }
                case 6:
                    {
                        color = Color.Coral;
                        break;
                    }
                case 7:
                    {
                        color = Color.Tan;
                        break;
                    }
                case 8:
                    {
                        color = Color.Black;
                        break;
                    }
                case 9:
                    {
                        color = Color.Chartreuse;
                        break;
                    }
                case 10:
                    {
                        color = Color.Magenta;
                        break;
                    }
                case 11:
                    {
                        color = Color.Yellow;
                        break;
                    }
                default:
                    {
                        color = Color.HotPink;
                        break;
                    }
            }
        }

    }
    
}
