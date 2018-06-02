using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingTools.View
{
    interface IImageView
    {
        Bitmap SourceBitmap { get; set; }

        //OpenFileDialog OpenFileDialog { get; }

        Bitmap ResultBitmap { get; set; }
    }
}
