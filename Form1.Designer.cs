
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DirectionTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SpreadingTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpreadingTrack)).BeginInit();
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DirectionTrack
            // 
            this.DirectionTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirectionTrack.Location = new System.Drawing.Point(804, 43);
            this.DirectionTrack.Maximum = 359;
            this.DirectionTrack.Name = "DirectionTrack";
            this.DirectionTrack.Size = new System.Drawing.Size(200, 56);
            this.DirectionTrack.TabIndex = 1;
            this.DirectionTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DirectionTrack.Value = 90;
            this.DirectionTrack.Scroll += new System.EventHandler(this.DirectionTrack_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(835, 12);
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
            this.SpreadingTrack.Size = new System.Drawing.Size(200, 56);
            this.SpreadingTrack.TabIndex = 3;
            this.SpreadingTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SpreadingTrack.Value = 50;
            this.SpreadingTrack.Scroll += new System.EventHandler(this.SpreadingTrack_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(861, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Разброс";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpreadingTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectionTrack);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpreadingTrack)).EndInit();
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
    }
}

