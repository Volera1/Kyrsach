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
        Emitter emitter = new Emitter(); // добавили эмиттер
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCenter();
            emitter.UpdateState();
            
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
    }
}
