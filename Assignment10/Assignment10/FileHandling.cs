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

                string Path = "D:\\";
                string fPath = Path + fileName;

                if (File.Exists(fPath))
                {
                    Console.WriteLine("File Already there!!!");
                }

                else
                {
                    StreamWriter streamWriter = File.AppendText(fPath);
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

                string Path = "D:\\";
                string fPath = Path + fileName;

                if (File.Exists(fPath))
                {
                    string[] lines = File.ReadAllLines(fPath);
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

                string Path = "D:\\";
                string fPath = Path + fileName;
                StreamWriter streamWriter = File.AppendText(fPath);
                streamWriter.WriteLine(content);
                streamWriter.Dispose();
                streamWriter.Close();
                Console.WriteLine(content);
                Console.WriteLine("Content is added");

                //StreamReader sr = new StreamReader(fileName);
                // content = "";
                //while((content = sr.ReadLine())!=null)
                //{
                //    Console.WriteLine(content);
                //}
                //sr.Close();
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
                string Path = "D:\\";
                string fPath = Path + fileName;
                if (File.Exists(fPath))
                {
                    File.Delete(fPath); Console.WriteLine("File is deleted successfully");
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
