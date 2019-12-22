using System;
using System.Text;

namespace Deliverable2
{

    class Program
    {
        static void Main()
        {
            
            //This is the second deliverable! This seems like a doozy.
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine();

            input = input.ToUpper(); // Makes the letter uppercase.

            //Encoding Process. Only done with 'System.Text' at the top.
            ASCIIEncoding ascii = new ASCIIEncoding();

            Byte[] encodedBytes = ascii.GetBytes(input); //This enodes the material to Bytes[]
            string message = "You encoded message is: ";
            Console.WriteLine(message);
            foreach (Byte a in encodedBytes)
            { 
                Console.Write("{0}-", a-64); //This does the math to make the numbers equal to their correct value.
            }
            
            string checkSum = "\nMessage checksum is: ";
            int sum = 0;
            for (int i = 0; i < encodedBytes.Length; i++)
            {
                sum += (int)encodedBytes[i]; //This does the summation of the numbers from the previous lines.
            }

            Console.Write(checkSum + "\n"+ sum +"\n");
            //Shows off that summation.
          

        }
    }
}

