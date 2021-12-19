using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Kyrsach
{
    class Emitter
    {
        public List<Particle> particles = new List<Particle>();
        public float PositionX;
        public float PositionY;
        public int Direction = 90; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 50; // разброс частиц относительно Direction
        public int Speed = 9; //Контроль скорости
        public int SpeedMin =0; // начальная минимальная скорость движения частицы
        public int SpeedMax = 4; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы

        public Color ColorFrom = Color.Green; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.White); // конечный цвет частиц
        public float GravitationX = 0;
        public float GravitationY = 0.25f; // пусть гравитация будет силой один пиксель за такт, нам хватит

        public int ParticlesPerTick = 1; // количество частиц в такт
        public int DeadInside = 0; //количество мертых частиц

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick; // фиксируем счетчик сколько частиц нам создавать за тик
            DeadInside = 0;
            foreach (ParticleColorful particle in particles)
            {
                particle.Life -= 1; // уменьшаю здоровье
                // если здоровье кончилось
                if (particle.Life < 0)
                {
                    particle.FromColor = Color.Green;
                    DeadInside += 1;//умер
                    CreateParticle();
                    if (particlesToCreate > 0)
                    {
                        /* у нас как сброс частицы равносилен созданию частицы */
                        particlesToCreate -= 1; // поэтому уменьшаем счётчик созданных частиц на 1
                        ResetParticle(particle);
                    }
                    else
                    { particle.Life = 0;}
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
            while (particlesToCreate >= 1)
                {
                    particlesToCreate -= 1;
                    var particle = CreateParticle();
                    ResetParticle(particle);
                    particles.Add(particle);
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

            var speed =  Speed + Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }
        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;
            return particle;

        }

    }
}
