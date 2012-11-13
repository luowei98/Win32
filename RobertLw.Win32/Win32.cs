#region File Descrption

// /////////////////////////////////////////////////////////////////////////////
// 
// Project: RobertLw.Win32
// File:    Win32.cs
// 
// Create by Robert.L at 2012/11/13 10:29
// 
// /////////////////////////////////////////////////////////////////////////////

#endregion

namespace RobertLw.Win32
{
    // ReSharper disable InconsistentNaming
    public struct RECT
    {
        public int Bottom;
        public int Left;
        public int Right;
        public int Top;
    }

    public struct POINT
    {
        public int x;
        public int y;
    }

    public struct SIZE
    {
        public int cx;
        public int cy;
    }

    public struct FILETIME
    {
        public int dwHighDateTime;
        public int dwLowDateTime;
    }

    public struct SYSTEMTIME
    {
        public short wDay;
        public short wDayOfWeek;
        public short wHour;
        public short wMilliseconds;
        public short wMinute;
        public short wMonth;
        public short wSecond;
        public short wYear;
    }
}