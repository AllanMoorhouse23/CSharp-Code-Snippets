using System.IO;

//-------------------------------------------------------------Saving Files -TXT, SQL, CSV

//Requires saveFileDialog1 to be added to the form

private void buttonSave_Click(object sender, EventArgs e){
	
	//Create Stream writer
	StreamWriter writer;
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




//------------------------------------------------------------Opening Files -CSV

//Reads in a csv file and breaks it up into its repective data types
//Requires openFileDialog1 to be added to the form

//Initialize variables
List<string> StringEx = new List<string>{};
List<int> IntEx = new List<int>{};
List<double> DoubleEx = new List<double>{};
List<decimal> DecimalEx = new List<decimal>{};

private void openButton__Click(object sender, EventArgs e){
            
            //Create stream reader
            StreamReader reader;
            //Initialize variables
            string line = "";
            string[] csvArray;
            //Create filter for open file dialog
            const string FILTER = "CSV Files|*.csv|All Files|*.*";
            openFileDialog1.Filter = FILTER;
            //Handles any errors
            try
            {
                //Open file dialog and if OK button was pressed
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
					//Set file location for the read file
                    reader = File.OpenText(openFileDialog1.FileName);
                    //While not the end of stream
                    while (!reader.EndOfStream)
                    {
                        //Read line and store as string
                        line = reader.ReadLine();
                        
						//Split line up at every comma and store in a string array
                        csvArray = line.Split(',');
                        
						//Add each value to its respective list
						StringEx.add(csvArray[1]);
						IntEx.add(int.Parse(csvArray[2]));
						DoubleEx.add(double.Parse(csvArray[3]));
						DecimalEx.add(decimal.Parse(csvArray[4]));
                        
                    }
                    
					//Close the file
                    reader.Close();
                    
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
}




//------------------------------------------------------------Opening Files -TXT

//Reads in an entire text file and stores each line as a string in a list of strings
//Requires openFileDialog1 to be added to the form

//Initialize variables
List<string> lines = new List<string>{};
private void openButton__Click(object sender, EventArgs e){
            
            //Create stream reader
            StreamReader reader;
            //Initialize variables
            string line = "";
            //Create filter for open file dialog
            const string FILTER = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Filter = FILTER;
            //Handles any errors
            try
            {
                //Open file dialog and if OK button was pressed
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
					//Set file location for the read file
                    reader = File.OpenText(openFileDialog1.FileName);
                    //While not the end of stream
                    while (!reader.EndOfStream)
                    {
                        //Read line and store as string
                        line = reader.ReadLine();
                        lines.add(line);
						
                    }
                    
					//Close the file
                    reader.Close();
                    
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
}