
namespace Kyrsach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DirectionTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SpreadingTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedTrack = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.CountOfParticles = new System.Windows.Forms.Label();
            this.PartickleTrack = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.LifeTrack = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpreadingTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartickleTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 426);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DirectionTrack
            // 
            this.DirectionTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirectionTrack.Location = new System.Drawing.Point(804, 43);
            this.DirectionTrack.Maximum = 359;
            this.DirectionTrack.Name = "DirectionTrack";
            this.DirectionTrack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DirectionTrack.Size = new System.Drawing.Size(229, 56);
            this.DirectionTrack.TabIndex = 1;
            this.DirectionTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DirectionTrack.Value = 90;
            this.DirectionTrack.Scroll += new System.EventHandler(this.DirectionTrack_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(861, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Направление";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpreadingTrack
            // 
            this.SpreadingTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpreadingTrack.Location = new System.Drawing.Point(804, 102);
            this.SpreadingTrack.Maximum = 359;
            this.SpreadingTrack.Name = "SpreadingTrack";
            this.SpreadingTrack.Size = new System.Drawing.Size(229, 56);
            this.SpreadingTrack.TabIndex = 3;
            this.SpreadingTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SpreadingTrack.Value = 50;
            this.SpreadingTrack.Scroll += new System.EventHandler(this.SpreadingTrack_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(885, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Разброс";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedTrack
            // 
            this.SpeedTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedTrack.LargeChange = 1;
            this.SpeedTrack.Location = new System.Drawing.Point(804, 164);
            this.SpeedTrack.Name = "SpeedTrack";
            this.SpeedTrack.Size = new System.Drawing.Size(229, 56);
            this.SpeedTrack.TabIndex = 5;
            this.SpeedTrack.Value = 9;
            this.SpeedTrack.Scroll += new System.EventHandler(this.SpeedTrack_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(875, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountOfParticles
            // 
            this.CountOfParticles.AutoSize = true;
            this.CountOfParticles.Location = new System.Drawing.Point(804, 407);
            this.CountOfParticles.Name = "CountOfParticles";
            this.CountOfParticles.Size = new System.Drawing.Size(144, 20);
            this.CountOfParticles.TabIndex = 7;
            this.CountOfParticles.Text = "Количество частиц:";
            // 
            // PartickleTrack
            // 
            this.PartickleTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PartickleTrack.LargeChange = 1;
            this.PartickleTrack.Location = new System.Drawing.Point(804, 240);
            this.PartickleTrack.Minimum = 1;
            this.PartickleTrack.Name = "PartickleTrack";
            this.PartickleTrack.Size = new System.Drawing.Size(229, 56);
            this.PartickleTrack.TabIndex = 8;
            this.PartickleTrack.Value = 1;
            this.PartickleTrack.Scroll += new System.EventHandler(this.PartickleTrack_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(804, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количетво частиц в тик";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LifeTrack
            // 
            this.LifeTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LifeTrack.LargeChange = 1;
            this.LifeTrack.Location = new System.Drawing.Point(804, 311);
            this.LifeTrack.Maximum = 100;
            this.LifeTrack.Minimum = 30;
            this.LifeTrack.Name = "LifeTrack";
            this.LifeTrack.Size = new System.Drawing.Size(229, 56);
            this.LifeTrack.TabIndex = 10;
            this.LifeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LifeTrack.Value = 100;
            this.LifeTrack.Scroll += new System.EventHandler(this.LifeTrack_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(817, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Длительность жизни";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorButton
            // 
            this.ColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorButton.Location = new System.Drawing.Point(804, 349);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(229, 42);
            this.ColorButton.TabIndex = 12;
            this.ColorButton.Text = "Изменить цвета";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LifeTrack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PartickleTrack);
            this.Controls.Add(this.CountOfParticles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpeedTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpreadingTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectionTrack);
            this.Controls.Add(this.picDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Шарики";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpreadingTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartickleTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar DirectionTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar SpreadingTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar SpeedTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CountOfParticles;
        private System.Windows.Forms.TrackBar PartickleTrack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar LifeTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ColorButton;
    }
}

