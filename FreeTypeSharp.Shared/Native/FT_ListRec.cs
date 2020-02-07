﻿using System.Runtime.InteropServices;

namespace FreeTypeSharp.Native
{
#pragma warning disable 1591
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_ListRec
    {
        public FT_ListNodeRec* head;
        public FT_ListNodeRec* tail;
    }
#pragma warning restore 1591
}
