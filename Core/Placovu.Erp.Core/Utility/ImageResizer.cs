using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Placovu.Erp.Core.Utility
{
    public static class ImageResizer
    {
        private static Size ResizeKeepAspect(Size src, int maxWidth, int maxHeight)
        {
            decimal rnd = Math.Min(maxWidth / (decimal)src.Width, maxHeight / (decimal)src.Height);
            return new Size((int)Math.Round(src.Width * rnd), (int)Math.Round(src.Height * rnd));
        }
        public static byte[] ResizeBinaryImage(HttpPostedFileBase file, int canvasWidth, int canvasHeight)
        {
            Image image = Image.FromStream(file.InputStream);
            Size targerSize = ResizeKeepAspect(image.PhysicalDimension.ToSize(), canvasWidth, canvasHeight);
           
            var thumbnail = new Bitmap(image, targerSize.Width, targerSize.Height);

            //using (Graphics graphic = Graphics.FromImage(thumbnail))
            //{
            //    graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //    graphic.SmoothingMode = SmoothingMode.HighQuality;
            //    graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //    graphic.CompositingQuality = CompositingQuality.HighQuality;
            //    graphic.DrawImage(image, 0, 0);
            //}
            using (MemoryStream ms = new MemoryStream())
            {
                ImageCodecInfo codec = ImageCodecInfo.GetImageEncoders().FirstOrDefault(c => c.MimeType == file.ContentType);
                EncoderParameters jpegParms = new EncoderParameters(1);
                jpegParms.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
                thumbnail.Save(ms, codec, jpegParms);
                return ms.ToArray();
            }

            // do code
        }
    }
}
