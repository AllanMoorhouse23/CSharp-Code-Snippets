using System.IO;

//-------------------------------------------------------------Saving Files
//Requires saveFileDialog1 to be added to the form
private void buttonSave_Click(object sender, EventArgs e){
	
	//Create Stream writer
	StreamWriter writer;
	Random random = new Random();
	//Catch any errors that may occur
	try
	{
		//Create filter for save dialog
		const string FILTER = "Text Files|*.txt|All Files|*.*";
		//Set filter for save dialog
		saveFileDialog1.Filter = FILTER;
		//Open save file dialog and if the ok button was pressed
		if (saveFileDialog1.ShowDialog() == DialogResult.OK)
		{
			//Sets the write location to the save dialog file name
			writer = File.CreateText(saveFileDialog1.FileName);
			
			//Write on a line
			writer.WriteLine("Hello World");

			//Close the file
			writer.Close();
		}
	}
	//If any errors occured
	catch (Exception ex)
	{
		//Display error message
		MessageBox.Show(ex.Message);
	}
	
}

//------------------------------------------------------------Opening Files