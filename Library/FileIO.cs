using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library

{
    class FileIO : IFileInterface
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            List<string> mediaFile = new List<string>();

            try
            {
                //check to see whether the file exists
                if (!File.Exists(path))
                {
                    throw new Exception ("File does not exist!");
                }

                //initialize the empty string we'll be using for each line
                string line;

                
                using (StreamReader reader = new StreamReader(path))
                {
                    line = reader.ReadLine();
                }
                Console.WriteLine(line);

                int counter = 0;
                // Read file display line by line
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\library-teller\Library\Media.txt");

                while ((line = file.ReadLine()) !=null)
                    {
                        Console.WriteLine(line);
                        counter++;
                    }
                
                    file.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown error occured.");
            }

            return mediaFile;
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}
