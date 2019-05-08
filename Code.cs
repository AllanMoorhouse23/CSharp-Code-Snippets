//Import Settings from XML file
using System.Configuration;

string settingString = ConfigurationManager.AppSettings["NameOfSetting"];
settingString = settingString.ToLower();
int settingInt = Convert.ToInt32(ConfigurationManager.AppSettings["NameOfSetting"]);

//Random Values
Random random = new Random();



//Screenshotting
using System.Drawing;

private void screenshot() {

    this.WindowState = FormWindowState.Minimized;
    Rectangle aRectangle = new Rectangle(0, 0, this.Width, this.Height);
    SolidBrush br = new SolidBrush(Color.FromArgb(105, 0, 0, 0));
    
	Bitmap bitmap = new Bitmap(this.Width, this.Height);
	Size s = this.Size;
    Graphics g = Graphics.FromImage(bitmap as Image);
    
	g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);    
	g.FillRectangle(br, aRectangle);
    this.WindowState = FormWindowState.Normal;
    pictureBox1.Image = bitmap;

}





