using System;
using System.Drawing;
using System.IO;

namespace DRRMOFingerprintApp.ByteArrayToBitmap
{
    public class ByteArrayToBitmap
    {
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        // Sample usage
        //pictureBox.Image = ByteToImage(byteArr); // byteArr holds byte array value
    }
}
