using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SwatchBoutique;

public static class Methods 
{
    public static BitmapImage ChangePic(this BitmapImage t, string path)
    {
        t.BeginInit();
        t.UriSource = new Uri(path, UriKind.RelativeOrAbsolute);

        t.EndInit();
        return t;
    }
}
