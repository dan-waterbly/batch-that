﻿using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace BatchThat
{
    public class ConvertBitmapToBitmapImage
    {
        //source: http://stackoverflow.com/questions/26260654/wpf-converting-bitmap-to-imagesource
        public BitmapImage Convert(Bitmap src)
        {
            var ms = new MemoryStream();
            src.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            var image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
    }
}
