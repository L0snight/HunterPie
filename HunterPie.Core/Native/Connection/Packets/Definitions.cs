﻿using System.Runtime.InteropServices;

namespace HunterPie.Native.Connection.Packets
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Header
    {
        public OPCODE opcode;
        public uint version;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct C_CONNECT
    {
        public Header header;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string hunterpiePath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct S_CONNECT
    {
        public Header header;
        [MarshalAs(UnmanagedType.Bool)]
        public bool success;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct C_DISCONNECT
    {
        public Header header;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct S_DISCONNECT
    {
        public Header header;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct C_QUEUE_INPUT
    {
        public Header header;
        public input inputs;
    }

    public struct S_QUEUE_INPUT
    {
        public Header header;
        public uint inputId;
    }

    #region Other Data structures

    [StructLayout(LayoutKind.Sequential)]
    public struct input
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public char[] inputArray;
        public int nFrames;
        public uint injectionId;
        [MarshalAs(UnmanagedType.Bool)]
        public bool ignoreOriginalInputs;
    }

    #endregion
}
