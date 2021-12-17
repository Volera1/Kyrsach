using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kyrsach
{
    class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public float PositionX;
        public float PositionY;
        public float GravitationX = 0;
        public float GravitationY = 0.25f; // пусть гравитация будет силой один пиксель за такт, нам хватит

        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1; // уменьшаю здоровье
                                    // если здоровье кончилось
                if (particle.Life < 0)
                {
                    // восстанавливаю здоровье
                    particle.Life = 20 + Particle.rand.Next(100);
                    // перемещаю частицу в центр
                    particle.X = PositionX;
                    particle.Y = PositionY;
                    // делаю рандомное направление, скорость и размер
                    var direction = (double)Particle.rand.Next(360);
                    var speed = 1 + Particle.rand.Next(9);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
                    
                    particle.Radius = 4 + Particle.rand.Next(10);
                }
                else
                {

                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                    // гравитация воздействует на вектор скорости, поэтому пересчитываем его
                  

                }

            }
            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 100)
                {
                    // а у тут уже наш новый класс используем
                    var particle = new ParticleColorful();
                    // ну и цвета меняем
                    particle.FromColor = Color.Green;
                    particle.ToColor = Color.FromArgb(0, Color.YellowGreen);
                    particle.X = PositionX;
                    particle.Y = PositionY;
                    particles.Add(particle);
                }
                else
                {
                    break;
                }

            }
        }
        // функция рендеринга
        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }
    }
}
