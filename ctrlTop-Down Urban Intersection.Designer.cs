namespace TrafficLight
{
    partial class ctrlTop_Down_Urban_Intersection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbHighToBottom = new System.Windows.Forms.PictureBox();
            this.pbRightToLeft = new System.Windows.Forms.PictureBox();
            this.pbLeftToRight = new System.Windows.Forms.PictureBox();
            this.pbBottomToHigh = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHighToBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightToLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomToHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHighToBottom
            // 
            this.pbHighToBottom.Image = global::TrafficLight.Properties.Resources.Red2;
            this.pbHighToBottom.Location = new System.Drawing.Point(342, 130);
            this.pbHighToBottom.Name = "pbHighToBottom";
            this.pbHighToBottom.Size = new System.Drawing.Size(23, 29);
            this.pbHighToBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHighToBottom.TabIndex = 4;
            this.pbHighToBottom.TabStop = false;
            // 
            // pbRightToLeft
            // 
            this.pbRightToLeft.Image = global::TrafficLight.Properties.Resources.Green2_black_;
            this.pbRightToLeft.Location = new System.Drawing.Point(680, 130);
            this.pbRightToLeft.Name = "pbRightToLeft";
            this.pbRightToLeft.Size = new System.Drawing.Size(25, 29);
            this.pbRightToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRightToLeft.TabIndex = 3;
            this.pbRightToLeft.TabStop = false;
            // 
            // pbLeftToRight
            // 
            this.pbLeftToRight.Image = global::TrafficLight.Properties.Resources.Green2_black_;
            this.pbLeftToRight.Location = new System.Drawing.Point(327, 378);
            this.pbLeftToRight.Name = "pbLeftToRight";
            this.pbLeftToRight.Size = new System.Drawing.Size(16, 36);
            this.pbLeftToRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeftToRight.TabIndex = 2;
            this.pbLeftToRight.TabStop = false;
            // 
            // pbBottomToHigh
            // 
            this.pbBottomToHigh.Image = global::TrafficLight.Properties.Resources.Red2;
            this.pbBottomToHigh.Location = new System.Drawing.Point(699, 378);
            this.pbBottomToHigh.Name = "pbBottomToHigh";
            this.pbBottomToHigh.Size = new System.Drawing.Size(16, 36);
            this.pbBottomToHigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBottomToHigh.TabIndex = 1;
            this.pbBottomToHigh.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrafficLight.Properties.Resources.Road;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1042, 615);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlTop_Down_Urban_Intersection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbHighToBottom);
            this.Controls.Add(this.pbRightToLeft);
            this.Controls.Add(this.pbLeftToRight);
            this.Controls.Add(this.pbBottomToHigh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlTop_Down_Urban_Intersection";
            this.Size = new System.Drawing.Size(1042, 615);
            this.Load += new System.EventHandler(this.ctrlTop_Down_Urban_Intersection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHighToBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightToLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftToRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomToHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBottomToHigh;
        private System.Windows.Forms.PictureBox pbLeftToRight;
        private System.Windows.Forms.PictureBox pbRightToLeft;
        private System.Windows.Forms.PictureBox pbHighToBottom;
    }
}
