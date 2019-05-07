//Import Settings
	
	using System.Configuration;
	
	string settingString = ConfigurationManager.AppSettings["NameOfSetting"];
	settingString = settingString.ToLower();
	int settingInt = Convert.ToInt32(ConfigurationManager.AppSettings["NameOfSetting"]);

	
	private void updateBackground() {

		string alpha = ConfigurationManager.AppSettings["Alpha"];
            string red = ConfigurationManager.AppSettings["Red"];
            string green = ConfigurationManager.AppSettings["Green"];
            string blue = ConfigurationManager.AppSettings["Blue"];

            this.WindowState = FormWindowState.Minimized;
            Rectangle aRectangle = new Rectangle(0, 0, this.Width, this.Height);
            SolidBrush br = new SolidBrush(Color.FromArgb(Convert.ToInt32(alpha), Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue)));
            //SolidBrush br = new SolidBrush(Color.FromArgb(105, 0, 0, 0));
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            Size s = this.Size;
            Graphics g = Graphics.FromImage(bitmap as Image);
            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            g.FillRectangle(br, aRectangle);
            this.WindowState = FormWindowState.Normal;
           
            pictureBox1.Image = bitmap;

    }
