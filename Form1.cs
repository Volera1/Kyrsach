using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // добавим поле для эмиттера
        CircleColor CircleRed = new CircleColor(); //создаю круг для изменения цвета на красный
        CircleColor CircleAqua = new CircleColor()
        {
            color = Color.Aqua
        };
        CircleColor CircleYellow = new CircleColor()
        {
            color = Color.Yellow
        };
        CircleColor CircleTan = new CircleColor() {color=Color.Tan };
        CircleColor CircleChar = new CircleColor() { color = Color.Chartreuse };
        CircleColor Circle = new CircleColor() { color = Color.Coral };
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                ParticlesPerTick = 10,
                PositionX = picDisplay.Width / 2,
                PositionY = picDisplay.Height / 2,
            };
            
            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCenter();
            emitter.UpdateState();
            
            CountOfParticles.Text = $"Количество частиц: {emitter.particles.Count}";
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                CircleOver(CircleRed,g);
                CircleOver(CircleAqua, g);
                CircleOver(CircleYellow, g);
                CircleOver(CircleTan, g);
                CircleOver(CircleChar,g);
                CircleOver(Circle, g);

                g.Clear(Color.White);
                emitter.Render(g);
                CircleRed.Render(g);
                CircleAqua.Render(g);
                CircleYellow.Render(g);
                CircleTan.Render(g);
                CircleChar.Render(g);
                Circle.Render(g);
            }
                        // обновить picDisplay
            picDisplay.Invalidate();

        }
        private void CircleOver(CircleColor Circle, Graphics g)
        {
            foreach (ParticleColorful particle in emitter.particles)
            {
                if (Circle.Overlaps(particle, g))
                {
                    particle.FromColor = Circle.color;
                }

            }
        }
        private void DisplayCenter()
        {
            emitter.PositionX = picDisplay.Image.Width / 2;
            emitter.PositionY = picDisplay.Image.Height / 2;
            CircleAqua.Y = picDisplay.Image.Height / 2;
            CircleYellow.Y = picDisplay.Image.Height - 60;
            CircleTan.X = picDisplay.Image.Width - 60;
            CircleChar.X = picDisplay.Image.Width - 60;
            CircleChar.Y = picDisplay.Image.Height / 2;
            Circle.X = picDisplay.Image.Width - 60;
            Circle.Y = picDisplay.Image.Height - 60;
        }

        private void DirectionTrack_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = DirectionTrack.Value; // направлению эмиттера присваиваем значение ползунка 
        }

        private void SpreadingTrack_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = SpreadingTrack.Value;
        }

        private void SpeedTrack_Scroll(object sender, EventArgs e)
        {
            emitter.Speed = SpeedTrack.Value;
        }

        private void PartickleTrack_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = PartickleTrack.Value;
        }


        private void LifeTrack_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMax = LifeTrack.Value;

        }
    }
}
