using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Assignment10
{
   public class FileHandling
    {
        public void Create(string fileName, string content)
        {

            try
            {
                //Console.WriteLine("Enter file path");
                //string Path = Console.ReadLine();
                //string fPath = Path + fileName;

                if (File.Exists(fileName))
                {
                    Console.WriteLine("File Already there");
                }

                else
                {
                    StreamWriter streamWriter = File.AppendText(fileName);
                    streamWriter.WriteLine(content);
                    streamWriter.Dispose();
                    streamWriter.Close();
                    Console.WriteLine("File is Created and Content is added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error While Creating the file: {ex.Message}");
            }

        }
        public void Read(string fileName) 
        {
            try
            {
                
                if(File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    foreach(string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("File not exists");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error while reading the file: {ex.Message}");
            }
        }
        public void AppendToFile(string fileName,string content)
        {
            try
            {

                StreamReader sr = new StreamReader(content);
                string text = "";
                while((text = sr.ReadLine())!=null)
                {
                    Console.WriteLine(text);
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while Appending the file: {ex.Message}");

            }
        }
        public void DeleteFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName); Console.WriteLine("File is deleted successfully");
                }
                else
                {
                    Console.WriteLine($"File '{fileName}' does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while Appending the file: {ex.Message}");

            }
        }
    }
}
