namespace TrafficLight
{
    partial class Form1
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
            this.ctrlTrafficLight1 = new TrafficLight.ctrlTrafficLight();
            this.ctrlTrafficLight3 = new TrafficLight.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.CurrentLight = TrafficLight.enTrafficColor.Red;
            this.ctrlTrafficLight1.GreenTime = ((byte)(5));
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(69, 60);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.OrangeTime = ((byte)(3));
            this.ctrlTrafficLight1.RedTime = ((byte)(10));
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(176, 204);
            this.ctrlTrafficLight1.TabIndex = 0;
            // 
            // ctrlTrafficLight3
            // 
            this.ctrlTrafficLight3.CurrentLight = TrafficLight.enTrafficColor.Red;
            this.ctrlTrafficLight3.GreenTime = ((byte)(5));
            this.ctrlTrafficLight3.Location = new System.Drawing.Point(342, 60);
            this.ctrlTrafficLight3.Name = "ctrlTrafficLight3";
            this.ctrlTrafficLight3.OrangeTime = ((byte)(3));
            this.ctrlTrafficLight3.RedTime = ((byte)(10));
            this.ctrlTrafficLight3.Size = new System.Drawing.Size(153, 181);
            this.ctrlTrafficLight3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlTrafficLight3);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
        private ctrlTrafficLight ctrlTrafficLight3;
    }
}

