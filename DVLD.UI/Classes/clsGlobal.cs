using System;
using System.IO;
using System.Windows.Forms;
using DVLD.Business;

namespace DVLD.Classes
{
    internal static class clsGlobal 
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                // Get the current project directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Define the file path for storing login data
                string filePath = currentDirectory + "\\data.txt";

                //If username is empty, delete the file (used for clearing saved credentials)
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }

                // concatonate username and password with a separator
                string dataToSave = Username + "#//#" + Password;

                // Write credentials to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {

            try
            {
                // Get the current project directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Define the file path for stored credentials
                string filePath = currentDirectory + "\\data.txt";

                // Check if the file exists before reading
                if (File.Exists(filePath))
                {
                    // Read credentials from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
    }
}
