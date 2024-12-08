using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class ConvolutionMatrix

    {

        public int TopLeft = 0, TopMid = 0, TopRight = 0;

        public int MidLeft = 0, Pixel = 1, MidRight = 0;

        public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;

        public int Factor = 1;

        public int Offset = 0;

        public void SetAll(int nVal)

        {

            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight =

                      BottomLeft = BottomMid = BottomRight = nVal;

        }
        public void setSharpen(int nVal)

        {

            TopLeft = 0; TopMid = -1; TopRight = 0;

            MidLeft = 5; Pixel = -1; MidRight = 5;

            BottomLeft = 0; BottomMid = -2; BottomRight = 0;

    }

        public void setBlur(int nVal)

        {

            TopLeft = 1; TopMid = 1; TopRight = 1;

            MidLeft = 1; Pixel = 1; MidRight = 1;

            BottomLeft = 1; BottomMid = 1; BottomRight =1;

        }
        public void setEdgeDetect(int nVal)

        {

            TopLeft = 0; TopMid = 0; TopRight = 0;

            MidLeft = -1; Pixel = 1; MidRight = 0;

            BottomLeft = 0; BottomMid = 0; BottomRight =0;

        }
        public void setEmboss(int nVal)

        {

            TopLeft = -1; TopMid = -1; TopRight = 0;

            MidLeft = -1; Pixel = 1; MidRight = 1;

            BottomLeft = 0; BottomMid = 1; BottomRight = 2;

        }

       

    }

   

    public class ConvolutionMatrixMethods
    {
        public static bool Conv3x3(Bitmap b, ConvolutionMatrix m)

        {

            // Avoid divide by zero errors 



            if (0 == m.Factor)

                return false; Bitmap



            // GDI+ still lies to us - the return format is BGR, NOT RGB.  



            bSrc = (Bitmap)b.Clone();

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),

                                ImageLockMode.ReadWrite,

                                PixelFormat.Format24bppRgb);

            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),

                               ImageLockMode.ReadWrite,

                               PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;

            int stride2 = stride * 2;



            System.IntPtr Scan0 = bmData.Scan0;

            System.IntPtr SrcScan0 = bmSrc.Scan0;



            unsafe
            {

                byte* p = (byte*)(void*)Scan0;

                byte* pSrc = (byte*)(void*)SrcScan0;

                int nOffset = stride - b.Width * 3;

                int nWidth = b.Width - 2;

                int nHeight = b.Height - 2;



                int nPixel;



                for (int y = 0; y < nHeight; ++y)

                {

                    for (int x = 0; x < nWidth; ++x)

                    {

                        nPixel = ((((pSrc[2] * m.TopLeft) +

                            (pSrc[5] * m.TopMid) +

                            (pSrc[8] * m.TopRight) +

                            (pSrc[2 + stride] * m.MidLeft) +

                            (pSrc[5 + stride] * m.Pixel) +

                            (pSrc[8 + stride] * m.MidRight) +

                            (pSrc[2 + stride2] * m.BottomLeft) +

                            (pSrc[5 + stride2] * m.BottomMid) +

                            (pSrc[8 + stride2] * m.BottomRight))

                            / m.Factor) + m.Offset);



                        if (nPixel < 0) nPixel = 0;

                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;



                        nPixel = ((((pSrc[1] * m.TopLeft) +

                            (pSrc[4] * m.TopMid) +

                            (pSrc[7] * m.TopRight) +

                            (pSrc[1 + stride] * m.MidLeft) +

                            (pSrc[4 + stride] * m.Pixel) +

                            (pSrc[7 + stride] * m.MidRight) +

                            (pSrc[1 + stride2] * m.BottomLeft) +

                            (pSrc[4 + stride2] * m.BottomMid) +

                            (pSrc[7 + stride2] * m.BottomRight))

                            / m.Factor) + m.Offset);



                        if (nPixel < 0) nPixel = 0;

                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;



                        nPixel = ((((pSrc[0] * m.TopLeft) +

                                       (pSrc[3] * m.TopMid) +

                                       (pSrc[6] * m.TopRight) +

                                       (pSrc[0 + stride] * m.MidLeft) +

                                       (pSrc[3 + stride] * m.Pixel) +

                                       (pSrc[6 + stride] * m.MidRight) +

                                       (pSrc[0 + stride2] * m.BottomLeft) +

                                       (pSrc[3 + stride2] * m.BottomMid) +

                                       (pSrc[6 + stride2] * m.BottomRight))

                            / m.Factor) + m.Offset);



                        if (nPixel < 0) nPixel = 0;

                        if (nPixel > 255) nPixel = 255;

                        p[3 + stride] = (byte)nPixel;



                        p += 3;

                        pSrc += 3;

                    }



                    p += nOffset;

                    pSrc += nOffset;

                }

            }



            b.UnlockBits(bmData);

            bSrc.UnlockBits(bmSrc);

            return true;

        }

        public static bool Smooth(Bitmap b, int nWeight /* default to 1 */)
        {
            ConvolutionMatrix m = new ConvolutionMatrix();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.Factor = nWeight + 8;

            return Conv3x3(b, m);
        }

        public static bool GaussianBlur(Bitmap b, int nWeight /* default to 4*/)
        {
            ConvolutionMatrix m = new ConvolutionMatrix();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
            m.Factor = nWeight + 12;

            return Conv3x3(b, m);
        }
        public static bool Sharpen(Bitmap b, int nWeight /* default to 11*/ )
        {
            ConvolutionMatrix m = new ConvolutionMatrix();
            m.SetAll(0);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -2;
            m.Factor = nWeight - 8;

            return Conv3x3(b, m);
        }

        public static bool MeanRemoval(Bitmap b, int nWeight /* default to 9*/ )
        {
            ConvolutionMatrix m = new ConvolutionMatrix();
            m.SetAll(-1);
            m.Pixel = nWeight;
            m.Factor = nWeight - 8;

            return Conv3x3(b, m);
        }

        public static bool EmbossLaplacian(Bitmap b)
        {
            ConvolutionMatrix m = new ConvolutionMatrix();
            m.SetAll(-1);
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 0;
            m.Pixel = 4;
            m.Offset = 127;

            return Conv3x3(b, m);
        }



    }

}
