﻿using System;

namespace Chromely.BrowserWindow
{
    public class SizeChangedEventArgs : EventArgs
    {
        public SizeChangedEventArgs(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public IntPtr GdkHandle { get; }
        public int Width { get; }
        public int Height { get; }
    }
}
