namespace TrafficLight
{
    partial class FrmTopDownUrbanIntersection
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlTop_Down_Urban_Intersection1 = new TrafficLight.ctrlTop_Down_Urban_Intersection();
            this.SuspendLayout();
            // 
            // ctrlTop_Down_Urban_Intersection1
            // 
            this.ctrlTop_Down_Urban_Intersection1.Location = new System.Drawing.Point(-4, -2);
            this.ctrlTop_Down_Urban_Intersection1.Name = "ctrlTop_Down_Urban_Intersection1";
            this.ctrlTop_Down_Urban_Intersection1.Size = new System.Drawing.Size(1057, 651);
            this.ctrlTop_Down_Urban_Intersection1.TabIndex = 0;
            // 
            // FrmTopDownUrbanIntersection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 617);
            this.Controls.Add(this.ctrlTop_Down_Urban_Intersection1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTopDownUrbanIntersection";
            this.Text = "Top-Down Urban Intersection";
            this.Load += new System.EventHandler(this.FrmTopDownUrbanIntersection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTop_Down_Urban_Intersection ctrlTop_Down_Urban_Intersection1;
    }
}