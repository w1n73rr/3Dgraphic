namespace _3Dgraphic
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
            picbox = new PictureBox();
            tb_RR = new TextBox();
            tb_A = new TextBox();
            tb_B = new TextBox();
            trackbar_movement = new TrackBar();
            trackbar_turn_x = new TrackBar();
            trackbar_turn_y = new TrackBar();
            trackbar_turn_z = new TrackBar();
            trackbar_size = new TrackBar();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_movement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_z).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_size).BeginInit();
            SuspendLayout();
            // 
            // picbox
            // 
            picbox.Location = new Point(12, 12);
            picbox.Name = "picbox";
            picbox.Size = new Size(776, 426);
            picbox.TabIndex = 0;
            picbox.TabStop = false;
            picbox.Click += pictureBox1_Click;
            // 
            // tb_RR
            // 
            tb_RR.Location = new Point(185, 461);
            tb_RR.Name = "tb_RR";
            tb_RR.Size = new Size(125, 27);
            tb_RR.TabIndex = 2;
            tb_RR.Text = "0,1";
            // 
            // tb_A
            // 
            tb_A.Location = new Point(330, 461);
            tb_A.Name = "tb_A";
            tb_A.Size = new Size(125, 27);
            tb_A.TabIndex = 3;
            tb_A.Text = "0,5";
            // 
            // tb_B
            // 
            tb_B.Location = new Point(475, 461);
            tb_B.Name = "tb_B";
            tb_B.Size = new Size(125, 27);
            tb_B.TabIndex = 4;
            tb_B.Text = "0,1";
            // 
            // trackbar_movement
            // 
            trackbar_movement.Location = new Point(34, 494);
            trackbar_movement.Maximum = 200;
            trackbar_movement.Minimum = -200;
            trackbar_movement.Name = "trackbar_movement";
            trackbar_movement.Size = new Size(130, 56);
            trackbar_movement.TabIndex = 5;
            trackbar_movement.Scroll += trackbar_movement_Scroll;
            // 
            // trackbar_turn_x
            // 
            trackbar_turn_x.Location = new Point(185, 494);
            trackbar_turn_x.Maximum = 360;
            trackbar_turn_x.Minimum = -360;
            trackbar_turn_x.Name = "trackbar_turn_x";
            trackbar_turn_x.Size = new Size(130, 56);
            trackbar_turn_x.TabIndex = 6;
            trackbar_turn_x.Scroll += trackbar_turn_x_Scroll;
            // 
            // trackbar_turn_y
            // 
            trackbar_turn_y.Location = new Point(325, 494);
            trackbar_turn_y.Maximum = 360;
            trackbar_turn_y.Minimum = -360;
            trackbar_turn_y.Name = "trackbar_turn_y";
            trackbar_turn_y.Size = new Size(130, 56);
            trackbar_turn_y.TabIndex = 7;
            trackbar_turn_y.Scroll += trackbar_turn_y_Scroll;
            // 
            // trackbar_turn_z
            // 
            trackbar_turn_z.Location = new Point(475, 494);
            trackbar_turn_z.Maximum = 360;
            trackbar_turn_z.Minimum = -360;
            trackbar_turn_z.Name = "trackbar_turn_z";
            trackbar_turn_z.Size = new Size(130, 56);
            trackbar_turn_z.TabIndex = 8;
            trackbar_turn_z.Scroll += trackbar_turn_z_Scroll;
            // 
            // trackbar_size
            // 
            trackbar_size.Location = new Point(632, 494);
            trackbar_size.Maximum = 9;
            trackbar_size.Minimum = 1;
            trackbar_size.Name = "trackbar_size";
            trackbar_size.Size = new Size(130, 56);
            trackbar_size.TabIndex = 9;
            trackbar_size.Value = 1;
            trackbar_size.Scroll += trackbar_size_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(668, 459);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(button1);
            Controls.Add(trackbar_size);
            Controls.Add(trackbar_turn_z);
            Controls.Add(trackbar_turn_y);
            Controls.Add(trackbar_turn_x);
            Controls.Add(trackbar_movement);
            Controls.Add(tb_B);
            Controls.Add(tb_A);
            Controls.Add(tb_RR);
            Controls.Add(picbox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_movement).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_x).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_y).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_z).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_size).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbox;
        private TextBox tb_RR;
        private TextBox tb_A;
        private TextBox tb_B;
        private TrackBar trackbar_movement;
        private TrackBar trackbar_turn_x;
        private TrackBar trackbar_turn_y;
        private TrackBar trackbar_turn_z;
        private TrackBar trackbar_size;
        private Button button1;
    }
}
