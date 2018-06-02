using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingTools.View
{
    interface IFileDialogView
    {
        OpenFileDialog OpenFileDialog { get; }

        SaveFileDialog SaveFileDialog { get; }

    }
}
