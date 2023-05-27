namespace WinFormsApp1
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
            TemperatureLabel = new Label();
            DescriptionLabel = new Label();
            CityTextBox = new TextBox();
            SuspendLayout();
            // 
            // GetWeatherButton_Click
            // 
          
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Location = new Point(281, 33);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(50, 20);
            TemperatureLabel.TabIndex = 1;
            TemperatureLabel.Text = "label1";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(518, 148);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(50, 20);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "label2";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(147, 72);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_cartoon_black_atmospheric_weather_forecast_illustration_background_image_948665;
            ClientSize = new Size(701, 403);
            Controls.Add(CityTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(TemperatureLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetWeatherButton_Click;
        private Label TemperatureLabel;
        private Label DescriptionLabel;
        private TextBox CityTextBox;
    }
}