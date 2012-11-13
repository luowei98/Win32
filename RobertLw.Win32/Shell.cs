#region File Descrption

// /////////////////////////////////////////////////////////////////////////////
// 
// Project: RobertLw.Win32
// File:    Shell.cs
// 
// Create by Robert.L at 2012/11/13 10:29
// 
// /////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Runtime.InteropServices;


namespace RobertLw.Win32
{
    // ReSharper disable InconsistentNaming
    public struct DRAGINFO
    {
        public int fNC;
        public int grfKeyState;
        public string lpFileList;
        public POINT pt;
        public int uSize;
    }

    public struct APPBARDATA
    {
        public int cbSize;
        public IntPtr hwnd;
        public int lParam;
        public RECT rc;
        public int uCallbackMessage;
        public int uEdge;
    }

    public struct SHFILEOPSTRUCT
    {
        public int fAnyOperationsAborted;
        public short fFlags;
        public IntPtr hNameMappings;
        public IntPtr hwnd;
        public string lpszProgressTitle;
        public string pFrom;
        public string pTo;
        public int wFunc;
    }

    public struct SHNAMEMAPPING
    {
        public int cchNewPath;
        public int cchOldPath;
        public string pszNewPath;
        public string pszOldPath;
    }

    public struct SHELLEXECUTEINFO
    {
        public int cbSize;
        public int dwHotKey;
        public int fMask;
        public IntPtr hIcon;
        public IntPtr hInstApp;
        public IntPtr hProcess;
        public IntPtr hkeyClass;
        public IntPtr hwnd;
        public string lpClass;
        public string lpDirectory;
        public string lpFile;
        public int lpIDList;
        public string lpParameters;
        public string lpVerb;
        public int nShow;
    }

    public struct NOTIFYICONDATA
    {
        public int cbSize;
        public IntPtr hIcon;
        public IntPtr hwnd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] public string szTip;
        public int uCallbackMessage;
        public int uFlags;
        public int uID;
    }

    public struct SHFILEINFO
    {
        public int dwAttributes;
        public IntPtr hIcon;
        public int iIcon;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Kernel.MAX_PATH)] public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)] public string szTypeName;
    }

    public abstract class Shell
    {
        public const int ABE_BOTTOM = 3;
        public const int ABE_LEFT = 0;
        public const int ABE_RIGHT = 2;
        public const int ABE_TOP = 1;
        public const int ABM_ACTIVATE = 0x6;
        public const int ABM_GETAUTOHIDEBAR = 0x7;
        public const int ABM_GETSTATE = 0x4;
        public const int ABM_GETTASKBARPOS = 0x5;
        public const int ABM_NEW = 0x0;
        public const int ABM_QUERYPOS = 0x2;
        public const int ABM_REMOVE = 0x1;
        public const int ABM_SETAUTOHIDEBAR = 0x8;
        public const int ABM_SETPOS = 0x3;
        public const int ABM_WINDOWPOSCHANGED = 0x9;
        public const int ABN_FULLSCREENAPP = 0x2;
        public const int ABN_POSCHANGED = 0x1;
        public const int ABN_STATECHANGE = 0x0;
        public const int ABN_WINDOWARRANGE = 0x3;
        public const int ABS_ALWAYSONTOP = 0x2;
        public const int ABS_AUTOHIDE = 0x1;
        public const int EIRESID = -1;
        public const int FOF_ALLOWUNDO = 0x40;
        public const int FOF_CONFIRMMOUSE = 0x2;
        public const int FOF_FILESONLY = 0x80;
        public const int FOF_MULTIDESTFILES = 0x1;
        public const int FOF_NOCONFIRMATION = 0x10;
        public const int FOF_NOCONFIRMMKDIR = 0x200;
        public const int FOF_RENAMEONCOLLISION = 0x8;
        public const int FOF_SILENT = 0x4;
        public const int FOF_SIMPLEPROGRESS = 0x100;
        public const int FOF_WANTMAPPINGHANDLE = 0x20;
        public const int FO_COPY = 0x2;
        public const int FO_DELETE = 0x3;
        public const int FO_MOVE = 0x1;
        public const int FO_RENAME = 0x4;
        public const int NIF_ICON = 0x2;
        public const int NIF_MESSAGE = 0x1;
        public const int NIF_TIP = 0x4;
        public const int NIM_ADD = 0x0;
        public const int NIM_DELETE = 0x2;
        public const int NIM_MODIFY = 0x1;
        public const int PO_DELETE = 0x13;
        public const int PO_PORTCHANGE = 0x20;
        public const int PO_RENAME = 0x14;
        public const int PO_REN_PORT = 0x34;
        public const int SEE_MASK_CLASSKEY = 0x3;
        public const int SEE_MASK_CLASSNAME = 0x1;
        public const int SEE_MASK_CONNECTNETDRV = 0x80;
        public const int SEE_MASK_DOENVSUBST = 0x200;
        public const int SEE_MASK_FLAG_DDEWAIT = 0x100;
        public const int SEE_MASK_FLAG_NO_UI = 0x400;
        public const int SEE_MASK_HOTKEY = 0x20;
        public const int SEE_MASK_ICON = 0x10;
        public const int SEE_MASK_IDLIST = 0x4;
        public const int SEE_MASK_INVOKEIDLIST = 0xC;
        public const int SEE_MASK_NOCLOSEPROCESS = 0x40;
        public const int SE_ERR_ACCESSDENIED = 5;
        public const int SE_ERR_ASSOCINCOMPLETE = 27;
        public const int SE_ERR_DDEBUSY = 30;
        public const int SE_ERR_DDEFAIL = 29;
        public const int SE_ERR_DDETIMEOUT = 28;
        public const int SE_ERR_DLLNOTFOUND = 32;
        public const int SE_ERR_FNF = 2;
        public const int SE_ERR_NOASSOC = 31;
        public const int SE_ERR_OOM = 8;
        public const int SE_ERR_PNF = 3;
        public const int SE_ERR_SHARE = 26;
        public const int SHGFI_ATTRIBUTES = 0x800;
        public const int SHGFI_DISPLAYNAME = 0x200;
        public const int SHGFI_EXETYPE = 0x2000;
        public const int SHGFI_ICON = 0x100;
        public const int SHGFI_ICONLOCATION = 0x1000;
        public const int SHGFI_LARGEICON = 0x0;
        public const int SHGFI_LINKOVERLAY = 0x8000;
        public const int SHGFI_OPENICON = 0x2;
        public const int SHGFI_PIDL = 0x8;
        public const int SHGFI_SELECTED = 0x10000;
        public const int SHGFI_SHELLICONSIZE = 0x4;
        public const int SHGFI_SMALLICON = 0x1;
        public const int SHGFI_SYSICONINDEX = 0x4000;
        public const int SHGFI_TYPENAME = 0x400;
        public const int SHGFI_USEFILEATTRIBUTES = 0x10;
        public const int SHGNLI_PIDL = 0x1;
        public const int SHGNLI_PREFIXNAME = 0x2;

        [DllImport("shell32")]
        public static extern int CommandLineToArgv(string lpCmdLine, short pNumArgs);

        [DllImport("shell32")]
        public static extern int DoEnvironmentSubst(string szString, int cbString);

        [DllImport("shell32")]
        public static extern int DragQueryFile(IntPtr hDROP, int UINT, string lpStr, int ch);

        [DllImport("shell32")]
        public static extern int DragQueryPoint(IntPtr hDROP, ref POINT lpPoint);

        [DllImport("shell32")]
        public static extern int DuplicateIcon(IntPtr hInst, IntPtr hIcon);

        [DllImport("shell32")]
        public static extern int ExtractAssociatedIcon(IntPtr hInst, string lpIconPath, ref int lpiIcon);

        [DllImport("shell32")]
        public static extern int ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);

        [DllImport("shell32")]
        public static extern int ExtractIconEx(string lpszFile, int nIconIndex, ref int phiconLarge, ref int phiconSmall,
                                               int nIcons);

        [DllImport("shell32")]
        public static extern int FindExecutable(string lpFile, string lpDirectory, string lpResult);

        [DllImport("shell32")]
        public static extern int SHAppBarMessage(int dwMessage, ref APPBARDATA pData);

        [DllImport("shell32")]
        public static extern int SHFileOperation(ref SHFILEOPSTRUCT lpFileOp);

        [DllImport("shell32")]
        public static extern int SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo,
                                               int uFlags);

        [DllImport("shell32")]
        public static extern int SHGetNewLinkInfo(string pszLinkto, string pszDir, string pszName, ref int pfMustCopy,
                                                  int uFlags);

        [DllImport("shell32")]
        public static extern int ShellAbout(IntPtr hwnd, string szApp, string szOtherStuff, IntPtr hIcon);

        [DllImport("shell32")]
        public static extern int ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters,
                                              string lpDirectory, int nShowCmd);

        [DllImport("shell32")]
        public static extern int Shell_NotifyIcon(int dwMessage, ref NOTIFYICONDATA lpData);

        [DllImport("shell32")]
        public static extern void DragAcceptFiles(IntPtr hwnd, int fAccept);

        [DllImport("shell32")]
        public static extern void DragFinish(IntPtr hDrop);

        [DllImport("shell32")]
        public static extern void SHFreeNameMappings(IntPtr hNameMappings);

        [DllImport("shell32")]
        public static extern void WinExecError(IntPtr hwnd, int error, string lpstrFileName, string lpstrTitle);

        [DllImport("shell32")]
        public static extern int SHBrowseForFolder(BROWSEINFO lpbi);

        [DllImport("shell32")]
        public static extern int SHGetPathFromIDList(int pidList, string lpBuffer);
    }
}