using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class ImageToASCIIConverter : IConsoleImage
    {
        private string[] _AsciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", " " };
        public bool Loaded { get; private set; }

        private Bitmap _image;

        public ImageToASCIIConverter(string imagePath) : this(new Bitmap(imagePath))
        {
        }

        public ImageToASCIIConverter(Bitmap image)
        {
            _image = image;
        }

        public ImageToASCIIConverter(): this(GetRandomImage())
        {        
        }

        private static Bitmap GetRandomImage()
        {
            byte[] imageBytes;

            using (WebClient wb = new WebClient())
            {
                imageBytes = wb.DownloadData("https://picsum.photos/50");
            }

            using(var ms = new MemoryStream(imageBytes))
            {
               return (Bitmap)Bitmap.FromStream(ms);
            }
            
        }

        public void Display()
        {
            Console.Clear();
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(_image.Width, _image.Height);
            Console.SetWindowSize(_image.Width, _image.Height);

            var imageASCII = ConvertToAscii(_image);

            foreach (var line in imageASCII)
            {
                Console.Write(line);
            }
        }


        private string[] ConvertToAscii(Bitmap image)
        {          

            string[] imageString = new string[image.Height];

            StringBuilder sb;

            for (int h = 0; h < image.Height; h++)

            {
                sb = new StringBuilder();

                for (int w = 0; w < image.Width; w++)

                {

                    Color pixelColor = image.GetPixel(w, h);

                    //Average out the RGB components to find the Gray Color

                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    Color grayColor = Color.FromArgb(red, green, blue);



                    //Use the toggle flag to minimize height-wise stretch



                    int index = (grayColor.R * 10) / 255;

                    sb.Append(_AsciiChars[index]);

                }

                imageString[h] = sb.ToString();
            }

            return imageString;
        }
    }
}
