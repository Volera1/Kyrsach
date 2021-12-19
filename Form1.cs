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
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 90,
                Spreading = 50,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Black,
                ColorTo = Color.FromArgb(0, Color.Green),
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
                g.Clear(Color.White); 
                emitter.Render(g);
            }


            // обновить picDisplay
            picDisplay.Invalidate();
            
        }
        private void DisplayCenter()
        {
            emitter.PositionX = picDisplay.Image.Width / 2;
            emitter.PositionY = picDisplay.Image.Height / 2;
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
