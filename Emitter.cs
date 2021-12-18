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
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц
        public float GravitationX = 0;
        public float GravitationY = 0.25f; // пусть гравитация будет силой один пиксель за такт, нам хватит

        public int ParticlesPerTick = 1; // количество частиц в такт

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick; // фиксируем счетчик сколько частиц нам создавать за тик

            foreach (var particle in particles)
            {
                particle.Life -= 1; // уменьшаю здоровье
                                    // если здоровье кончилось
                if (particle.Life < 0)
                {
                    CreateParticle();
                    ResetParticle(particle);
                    if (particlesToCreate > 0)
                    {
                        /* у нас как сброс частицы равносилен созданию частицы */
                        particlesToCreate -= 1; // поэтому уменьшаем счётчик созданных частиц на 1
                        ResetParticle(particle);
                    }
                }
                else
                {

                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                    // гравитация воздействует на вектор скорости, поэтому пересчитываем его

                }
                while (particlesToCreate >= 1)
                {
                    particlesToCreate -= 1;
                    CreateParticle();
                    ResetParticle(particle);
                }

            }
            for (var i = 0; i < 20; ++i)
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
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.X = PositionX;
            particle.Y = PositionY;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }
        public virtual void CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

        }

    }
}
