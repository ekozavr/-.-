namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.txtCity.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCity.Location = new System.Drawing.Point(20, 30);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 23);
            this.txtCity.TabIndex = 0;
           
            this.btnGetWeather.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGetWeather.Location = new System.Drawing.Point(230, 30);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(120, 23);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "Получить прогноз";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
           
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 10F);
            this.lblResult.Location = new System.Drawing.Point(20, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 2;
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtCity);
            this.Name = "Form1";
            this.Text = "Прогноз погоды";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblResult;
    }
}
