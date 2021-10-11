using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Utils
{
    public static class Utils
    {
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    return ms.ToArray();
                }
            }
            else
            {
                return null;
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if(byteArrayIn != null)
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    var returnImage = Image.FromStream(ms);

                    return returnImage;
                }
            }else
            {
                return null;
            }
        }
    }
}
