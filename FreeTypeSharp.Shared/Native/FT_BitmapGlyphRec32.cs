﻿using System;
using System.Runtime.InteropServices;

namespace FreeTypeSharp.Native
{
#pragma warning disable 1591
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_BitmapGlyphRec32
    {
        public FT_GlyphRec32 root;
        public Int32 left;
        public Int32 top;
        public FT_Bitmap bitmap;
    }
#pragma warning restore 1591
}
