﻿namespace System.DirectoryServices.ActiveDirectory
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal sealed class DS_REPL_NEIGHBORS
    {
        public int cNumNeighbors;
        public int dwReserved;
    }
}

