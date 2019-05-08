//Catching specific keystrokes
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppNameSpace{
	
	class ShortcutKey{

		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(Keys key);
		
		//Single specific key
		public bool singleKeyPressed() {
			//Dash Key
			if (GetAsyncKeyState(Keys.OemMinus) != 0){
				return true;
			}else{
				return false;
			}
		}
		
		
		//Polls characters
		public string characterPolling(){
			//A
			if (GetAsyncKeyState(Keys.A) != 0)
			{
				return "A";
			}

			//S
			if (GetAsyncKeyState(Keys.S) != 0)
			{
				return "S";
			}

			//D
			if (GetAsyncKeyState(Keys.D) != 0)
			{
				return "D";
			}

			//F
			if (GetAsyncKeyState(Keys.F) != 0)
			{
				return "F";
			}

			//G
			if (GetAsyncKeyState(Keys.G) != 0)
			{
				return "G";
			}

			//H
			if (GetAsyncKeyState(Keys.H) != 0)
			{
				return "H";
			}

			//J
			if (GetAsyncKeyState(Keys.J) != 0)
			{
				return "J";
			}

			//K
			if (GetAsyncKeyState(Keys.K) != 0)
			{
				return "K";
			}

			//L
			if (GetAsyncKeyState(Keys.L) != 0)
			{
				return "L";
			}

			//Q
			if (GetAsyncKeyState(Keys.Q) != 0)
			{
				return "Q";
			}

			//W
			if (GetAsyncKeyState(Keys.W) != 0)
			{
				return "W";
			}

			//E
			if (GetAsyncKeyState(Keys.E) != 0)
			{
				return "E";
			}

			//R
			if (GetAsyncKeyState(Keys.R) != 0)
			{
				return "R";
			}

			//T
			if (GetAsyncKeyState(Keys.T) != 0)
			{
				return "T";
			}

			//Y
			if (GetAsyncKeyState(Keys.Y) != 0)
			{
				return "Y";
			}

			//U
			if (GetAsyncKeyState(Keys.U) != 0)
			{
				return "U";
			}

			//I
			if (GetAsyncKeyState(Keys.I) != 0)
			{
				return "T";
			}

			//O
			if (GetAsyncKeyState(Keys.O) != 0)
			{
				return "O";
			}

			//P
			if (GetAsyncKeyState(Keys.P) != 0)
			{
				return "P";
			}

			//Z
			if (GetAsyncKeyState(Keys.Z) != 0)
			{
				return "Z";
			}

			//X
			if (GetAsyncKeyState(Keys.X) != 0)
			{
				return "X";
			}

			//C
			if (GetAsyncKeyState(Keys.C) != 0)
			{
				return "C";
			}

			//V
			if (GetAsyncKeyState(Keys.V) != 0)
			{
				return "V";
			}

			//B
			if (GetAsyncKeyState(Keys.B) != 0)
			{
				return "B";
			}

			//N
			if (GetAsyncKeyState(Keys.N) != 0)
			{
				return "N";
			}

			//M
			if (GetAsyncKeyState(Keys.M) != 0)
			{
				return "M";
			}

			//0
			if (GetAsyncKeyState(Keys.D0) != 0)
			{
				return "0";
			}

			//1
			if (GetAsyncKeyState(Keys.D1) != 0)
			{
				return "1";
			}

			//2
			if (GetAsyncKeyState(Keys.D2) != 0)
			{
				return "2";
			}

			//3
			if (GetAsyncKeyState(Keys.D3) != 0)
			{
				return "3";
			}

			//4
			if (GetAsyncKeyState(Keys.D4) != 0)
			{
				return "4";
			}

			//5
			if (GetAsyncKeyState(Keys.D5) != 0)
			{
				return "5";
			}

			//6
			if (GetAsyncKeyState(Keys.D6) != 0)
			{
				return "6";
			}

			//7
			if (GetAsyncKeyState(Keys.D7) != 0)
			{
				return "7";
			}

			//8
			if (GetAsyncKeyState(Keys.D8) != 0)
			{
				return "8";
			}

			//9
			if (GetAsyncKeyState(Keys.D9) != 0)
			{
				return "9";
			}
			
			//NumPad0
			if (GetAsyncKeyState(Keys.NumPad0) != 0)
			{
				return "0";
			}

			//NumPad1
			if (GetAsyncKeyState(Keys.NumPad1) != 0)
			{
				return "1";
			}

			//NumPad2
			if (GetAsyncKeyState(Keys.NumPad2) != 0)
			{
				return "2";
			}

			//NumPad3
			if (GetAsyncKeyState(Keys.NumPad3) != 0)
			{
				return "3";
			}

			//NumPad4
			if (GetAsyncKeyState(Keys.NumPad4) != 0)
			{
				return "4";
			}

			//NumPad5
			if (GetAsyncKeyState(Keys.NumPad5) != 0)
			{
				return "5";
			}

			//NumPad6
			if (GetAsyncKeyState(Keys.NumPad6) != 0)
			{
				return "6";
			}

			//NumPad7
			if (GetAsyncKeyState(Keys.NumPad7) != 0)
			{
				return "7";
			}

			//NumPad8
			if (GetAsyncKeyState(Keys.NumPad8) != 0)
			{
				return "8";
			}

			//NumPad9
			if (GetAsyncKeyState(Keys.NumPad9) != 0)
			{
				return "9";
			}
			
			//Spacebar
			if (GetAsyncKeyState(Keys.Space) != 0)
			{
				return " ";
			}
			
		}	

		
		//Polls for special characters
		public string specialCharacterPolling(){
			
			

			//Tab Key
			if (GetAsyncKeyState(Keys.Tab) != 0)
			{
				return "";
			}

			//F1
			if (GetAsyncKeyState(Keys.F1) != 0)
			{
				return "";
			}

			//F2
			if (GetAsyncKeyState(Keys.F2) != 0)
			{
				return "";
			}

			//F3
			if (GetAsyncKeyState(Keys.F3) != 0)
			{
				return "";
			}

			//F4
			if (GetAsyncKeyState(Keys.F4) != 0)
			{
				return "";
			}

			//F5
			if (GetAsyncKeyState(Keys.F5) != 0)
			{
				return "";
			}

			//F6
			if (GetAsyncKeyState(Keys.F6) != 0)
			{
				return "";
			}

			//F7
			if (GetAsyncKeyState(Keys.F7) != 0)
			{
				return "";
			}

			//F8
			if (GetAsyncKeyState(Keys.F8) != 0)
			{
				return "";
			}

			//F9
			if (GetAsyncKeyState(Keys.F9) != 0)
			{
				return "";
			}

			//F10
			if (GetAsyncKeyState(Keys.F10) != 0)
			{
				return "";
			}

			//F11
			if (GetAsyncKeyState(Keys.F11) != 0)
			{
				return "";
			}

			//F12
			if (GetAsyncKeyState(Keys.F12) != 0)
			{
				return "";
			}

			//Enter
			if (GetAsyncKeyState(Keys.Enter) != 0)
			{
				return "";
				return "";
			}

			
			
			//`
			if (GetAsyncKeyState(Keys.Oem3) != 0)
			{
				return "`";
			}

			//-
			if (GetAsyncKeyState(Keys.OemMinus) != 0)
			{
				return "-";
			}

			//=
			if (GetAsyncKeyState(Keys.Oemplus) != 0)
			{
				return "=";
			}

			//{
			if (GetAsyncKeyState(Keys.OemOpenBrackets) != 0)
			{
				return "{";
			}

			//}
			if (GetAsyncKeyState(Keys.OemCloseBrackets) != 0)
			{
				return "}";
			}

			//;
			if (GetAsyncKeyState(Keys.OemSemicolon) != 0)
			{
				return ";";
			}

			//'
			if (GetAsyncKeyState(Keys.OemQuotes) != 0)
			{
				return "'";
			}

			//,
			if (GetAsyncKeyState(Keys.Oemcomma) != 0)
			{
				return ",";
			}

			//.
			if (GetAsyncKeyState(Keys.OemPeriod) != 0)
			{
				return ".";
			}

			//Forward Slash
			if (GetAsyncKeyState(Keys.OemQuestion) != 0)
			{
				return "/";
			}

			//Back Slash
			if (GetAsyncKeyState(Keys.Oem5) != 0)
			{
				return "\\";
			}

			
			
			

			

			
			
			
			
			

			//Divide
			if (GetAsyncKeyState(Keys.Divide) != 0)
			{
				return "/";
			}

			//Multiply
			if (GetAsyncKeyState(Keys.Multiply) != 0)
			{
				return "*";
			}

			//Subtract
			if (GetAsyncKeyState(Keys.Subtract) != 0)
			{
				return "-";
			}

			//Addition
			if (GetAsyncKeyState(Keys.Add) != 0)
			{
				return "+";
			}

			//Decimal
			if (GetAsyncKeyState(Keys.Decimal) != 0)
			{
				return ".";
			}
		}
		
		//Polls modifier keys
		public string modifierKeysPolling(){
			//Control Keys
			if (GetAsyncKeyState(Keys.ControlKey) != 0)
			{
				return "CTRL";		
			}

			//Windows Keys
			if (GetAsyncKeyState(Keys.LWin) != 0 || GetAsyncKeyState(Keys.RWin) != 0)
			{
				return "WIN";
			}

			//Alt Key
			if (GetAsyncKeyState(Keys.Menu) != 0)
			{
				return "ALT";
			}

			//Shift Keys
			if (GetAsyncKeyState(Keys.ShiftKey) != 0)
			{
				return "SHIFT";
			}
		}
		
		//Polls other non character keys
		public string otherKeysPolling(){
			//Escape Key
			if (GetAsyncKeyState(Keys.Escape) != 0)
			{
				return "ESC";
			}
			//Spacebar
			if (GetAsyncKeyState(Keys.Space) != 0)
			{
				return " ";
			}
			//Backspace
			if (GetAsyncKeyState(Keys.Back) != 0)
			{
				return "BACK";
			}

			//Print Screen
			if (GetAsyncKeyState(Keys.PrintScreen) != 0)
			{
				return "PRINT";
			}

			//Pause
			if (GetAsyncKeyState(Keys.Pause) != 0)
			{
				return "PAUSE";
			}

			//Insert
			if (GetAsyncKeyState(Keys.Insert) != 0)
			{
				return "INSERT";
			}

			//Home
			if (GetAsyncKeyState(Keys.Home) != 0)
			{
				return "HOME";
			}

			//Page Up
			if (GetAsyncKeyState(Keys.PageUp) != 0)
			{
				return "PAGEUP";
			}

			//Page Down
			if (GetAsyncKeyState(Keys.PageDown) != 0)
			{
				return "PAGEDOWN";
			}

			//Delete
			if (GetAsyncKeyState(Keys.Delete) != 0)
			{
				return "DEL";
			}

			//End
			if (GetAsyncKeyState(Keys.End) != 0)
			{
				return "END";
			}
		}
		
		
		//Polls arrow keys
		public string arrowKeysPolling(){
			//Up Arrow
			if (GetAsyncKeyState(Keys.Up) != 0)
			{
				return "UP";
			}

			//Down Arrow
			if (GetAsyncKeyState(Keys.Down) != 0)
			{
				return "DOWN";
			}

			//Left Arrow
			if (GetAsyncKeyState(Keys.Left) != 0)
			{
				return "LEFT";
			}

			//Right Arrow
			if (GetAsyncKeyState(Keys.Right) != 0)
			{
				return "RIGHT";
			}
		}
		
		
		
	}
}