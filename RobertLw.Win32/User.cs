#region File Descrption

// /////////////////////////////////////////////////////////////////////////////
// 
// Project: RobertLw.Win32
// File:    User.cs
// 
// Create by Robert.L at 2012/11/13 10:29
// 
// /////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Runtime.InteropServices;
using System.Text;


namespace RobertLw.Win32
{
    // ReSharper disable InconsistentNaming
    public struct CBTACTIVATESTRUCT
    {
        public int fMouse;
        public IntPtr hwndActive;
    }

    public struct EVENTMSG
    {
        public IntPtr hwnd;
        public int message;
        public int paramH;
        public int paramL;
        public int time;
    }

    public struct CWPSTRUCT
    {
        public IntPtr hwnd;
        public int lParam;
        public int message;
        public int wParam;
    }

    public struct DEBUGHOOKINFO
    {
        public int Reserved;
        public int code;
        public IntPtr hModuleHook;
        public int lParam;
        public int wParam;
    }

    public struct MOUSEHOOKSTRUCT
    {
        public int dwExtraInfo;
        public IntPtr hwnd;
        public POINT pt;
        public int wHitTestCode;
    }

    public struct MINMAXINFO
    {
        public POINT ptMaxPosition;
        public POINT ptMaxSize;
        public POINT ptMaxTrackSize;
        public POINT ptMinTrackSize;
        public POINT ptReserved;
    }

    public struct COPYDATASTRUCT
    {
        public int cbData;
        public int dwData;
        public int lpData;
    }

    public struct WINDOWPOS
    {
        public int cx;
        public int cy;
        public int flags;
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int x;
        public int y;
    }

    public struct ACCEL
    {
        public short cmd;
        public byte fVirt;
        public short key;
    }

    public struct PAINTSTRUCT
    {
        public int fErase;
        public int fIncUpdate;
        public int fRestore;
        public IntPtr hdc;
        public RECT rcPaint;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public byte rgbReserved;
    }

    public struct CREATESTRUCT
    {
        public int ExStyle;
        public int cx;
        public int cy;
        public IntPtr hInstance;
        public IntPtr hMenu;
        public IntPtr hwndParent;
        public int lpCreateParams;
        public string lpszClass;
        public string lpszName;
        public int style;
        public int x;
        public int y;
    }

    public struct CBT_CREATEWND
    {
        public IntPtr hwndInsertAfter;
        public CREATESTRUCT lpcs;
    }

    public struct WINDOWPLACEMENT
    {
        public int Length;
        public int flags;
        public POINT ptMaxPosition;
        public POINT ptMinPosition;
        public RECT rcNormalPosition;
        public int showCmd;
    }

    public struct MEASUREITEMSTRUCT
    {
        public int CtlID;
        public int CtlType;
        public int itemData;
        public int itemHeight;
        public int itemID;
        public int itemWidth;
    }

    public struct DRAWITEMSTRUCT
    {
        public int CtlID;
        public int CtlType;
        public IntPtr hdc;
        public IntPtr hwndItem;
        public int itemAction;
        public int itemData;
        public int itemID;
        public int itemState;
        public RECT rcItem;
    }

    public struct DELETEITEMSTRUCT
    {
        public int CtlID;
        public int CtlType;
        public IntPtr hwndItem;
        public int itemData;
        public int itemID;
    }

    public struct COMPAREITEMSTRUCT
    {
        public int CtlID;
        public int CtlType;
        public IntPtr hwndItem;
        public int itemData1;
        public int itemData2;
        public int itemID1;
        public int itemID2;
    }

    public struct MSG
    {
        public IntPtr hwnd;
        public int lParam;
        public int message;
        public POINT pt;
        public int time;
        public int wParam;
    }

    public struct WNDCLASS
    {
        public int cbClsextra;
        public int cbWndExtra2;
        public IntPtr hCursor;
        public IntPtr hIcon;
        public IntPtr hInstance;
        public IntPtr hbrBackground;
        public int lpfnwndproc;
        public string lpszClassName;
        public string lpszMenuName;
        public int style;
    }

    public struct DLGTEMPLATE
    {
        public short cdit;
        public short cx;
        public short cy;
        public int dwExtendedStyle;
        public int style;
        public short x;
        public short y;
    }

    public struct DLGITEMTEMPLATE
    {
        public short cx;
        public short cy;
        public int dwExtendedStyle;
        public short id;
        public int style;
        public short x;
        public short y;
    }

    public struct MENUITEMTEMPLATEHEADER
    {
        public short offset;
        public short versionNumber;
    }

    public struct MENUITEMTEMPLATE
    {
        public short mtID;
        public short mtOption;
        public byte mtString;
    }

    public struct ICONINFO
    {
        public int fIcon;
        public IntPtr hbmColor;
        public IntPtr hbmMask;
        public int xHotspot;
        public int yHotspot;
    }

    public struct MDICREATESTRUCT
    {
        public int cx;
        public int cy;
        public IntPtr hOwner;
        public int lParam;
        public int style;
        public string szClass;
        public string szTitle;
        public int x;
        public int y;
    }

    public struct CLIENTCREATESTRUCT
    {
        public IntPtr hWindowMenu;
        public int idFirstChild;
    }

    public struct MULTIKEYHELP
    {
        public byte mkKeylist;
        public int mkSize;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 253)] public string szKeyphrase;
    }

    public struct HELPWININFO
    {
        public int dx;
        public int dy;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)] public string rgchMember;
        public int wMax;
        public int wStructSize;
        public int x;
        public int y;
    }

    public struct DDEACK
    {
        public short Reserved;
        public short bAppReturnCode;
        public short fack;
        public short fbusy;
    }

    public struct DDEADVISE
    {
        public short Reserved;
        public short cfFormat;
        public short fAckReq;
        public short fDeferUpd;
    }

    public struct DDEDATA
    {
        public short Reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public byte Value;
        public short cfFormat;
        public short fAckReq;
        public short fRelease;
        public short fresponse;
        public short unused;
    }

    public struct DDEPOKE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public byte Value;
        public short cfFormat;
        public short fRelease;
        public short fReserved;
        public short unused;
    }

    public struct DDELN
    {
        public short cfFormat;
        public short fAckReq;
        public short fDeferUpd;
        public short fRelease;
        public short unused;
    }

    public struct DDEUP
    {
        public short cfFormat;
        public short fAck;
        public short fAckReq;
        public short fRelease;
        public short fReserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public byte rgb;
        public short unused;
    }

    public struct HSZPAIR
    {
        public IntPtr hszSvc;
        public IntPtr hszTopic;
    }

    public struct SECURITY_QUALITY_OF_SERVICE
    {
        public short ContextTrackingMode;
        public int EffectiveOnly;
        public short Impersonationlevel;
        public int Length;
    }

    public struct CONVCONTEXT
    {
        public int cb;
        public int dwLangID;
        public int dwSecurity;
        public int iCodePage;
        public SECURITY_QUALITY_OF_SERVICE qos;
        public int wCountryID;
        public int wFlags;
    }

    public struct CONVINFO
    {
        public CONVCONTEXT ConvCtxt;
        public int cb;
        public IntPtr hConvList;
        public IntPtr hConvPartner;
        public IntPtr hUser;
        public IntPtr hszItem;
        public IntPtr hszServiceReq;
        public IntPtr hszSvcPartner;
        public IntPtr hszTopic;
        public IntPtr hwnd;
        public IntPtr hwndPartner;
        public int wConvst;
        public int wFmt;
        public int wLastError;
        public int wStatus;
        public int wType;
    }

    public struct DDEML_MSG_HOOK_DATA
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int Data;
        public int cbData;
        public int uiHi;
        public int uiLo;
    }

    public struct MONMSGSTRUCT
    {
        public int cb;
        public DDEML_MSG_HOOK_DATA dmhd;
        public int dwTime;
        public IntPtr htask;
        public IntPtr hwndTo;
        public int lParam;
        public int wMsg;
        public int wParam;
    }

    public struct MONCBSTRUCT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int Data;
        public int cb;
        public int cbData;
        public CONVCONTEXT cc;
        public int dwData1;
        public int dwData2;
        public int dwRet;
        public int dwTime;
        public IntPtr hConv;
        public IntPtr hData;
        public IntPtr hsz1;
        public IntPtr hsz2;
        public IntPtr htask;
        public int wFmt;
        public int wType;
    }

    public struct MONHSZSTRUCT
    {
        public int cb;
        public int dwTime;
        public int fsAction;
        public IntPtr hsz;
        public IntPtr htask;
        public byte str;
    }

    public struct MONERRSTRUCT
    {
        public int cb;
        public int dwTime;
        public IntPtr htask;
        public int wLastError;
    }

    public struct MONLINKSTRUCT
    {
        public int cb;
        public int dwTime;
        public int fEstablished;
        public int fNoData;
        public int fServer;
        public IntPtr hConvClient;
        public IntPtr hConvServer;
        public IntPtr hszItem;
        public IntPtr hszSvc;
        public IntPtr hszTopic;
        public IntPtr htask;
        public int wFmt;
    }

    public struct MONCONVSTRUCT
    {
        public int cb;
        public int dwTime;
        public int fConnect;
        public IntPtr hConvClient;
        public IntPtr hConvServer;
        public IntPtr hszSvc;
        public IntPtr hszTopic;
        public IntPtr htask;
    }

    public struct DRAWTEXTPARAMS
    {
        public int cbSize;
        public int iLeftMargin;
        public int iRightMargin;
        public int iTabLength;
        public int uiLengthDrawn;
    }

    public struct MENUITEMINFO
    {
        public int cbSize;
        public int cch;
        public int dwItemData;
        public string dwTypeData;
        public int fMask;
        public int fState;
        public int fType;
        public IntPtr hSubMenu;
        public IntPtr hbmpChecked;
        public IntPtr hbmpUnchecked;
        public int wID;
    }

    public struct SCROLLINFO
    {
        public int cbSize;
        public int fMask;
        public int nMax;
        public int nMin;
        public int nPage;
        public int nPos;
        public int nTrackPos;
    }

    public struct MSGBOXPARAMS
    {
        public int cbSize;
        public int dwContextHelpId;
        public int dwLanguageId;
        public int dwStyle;
        public IntPtr hInstance;
        public IntPtr hwndOwner;
        public int lpfnMsgBoxCallback;
        public string lpszCaption;
        public string lpszIcon;
        public string lpszText;
    }

    public struct WNDCLASSEX
    {
        public int cbClsExtra;
        public int cbSize;
        public int cbWndExtra;
        public IntPtr hCursor;
        public IntPtr hIcon;
        public IntPtr hIconSm;
        public IntPtr hInstance;
        public IntPtr hbrBackground;
        public int lpfnWndProc;
        public string lpszClassName;
        public string lpszMenuName;
        public int style;
    }

    public struct TPMPARAMS
    {
        public int cbSize;
        public RECT rcExclude;
    }

    public struct BROWSEINFO
    {
        public IntPtr hwndOwner;
        public int iImage;
        public int lParam;
        public int lpfnCallback;
        public int lpszTitle;
        public int pIDLRoot;
        public int pszDisplayName;
        public int ulFlags;
    }

    public abstract class ComCtl
    {
        [DllImport("COMCTL32")]
        public static extern int ImageList_AddIcon(IntPtr himl, IntPtr hIcon);

        [DllImport("COMCTL32")]
        public static extern int ImageList_Create(int MinCx, int MinCy, int flags, int cInitial, int cGrow);

        [DllImport("COMCTL32")]
        public static extern int ImageList_Draw(IntPtr hIMAGELIST, int ImgIndex, IntPtr hdcDest, int xDest, int yDest,
                                                int lStyle);

        [DllImport("COMCTL32")]
        public static extern int ImageList_GetIcon(IntPtr hIMAGELIST, int ImgIndex, IntPtr hbmMask);

        [DllImport("COMCTL32")]
        public static extern int InitCommonControls();
    }

    public abstract class Ole
    {
        [DllImport("ole32")]
        public static extern int OleInitialize(IntPtr vbNullString);

        [DllImport("ole32")]
        public static extern void CoTaskMemFree(IntPtr hMem);

        [DllImport("ole32")]
        public static extern void OleUninitialize();
    }

    public class User
    {
        public const int APPCLASS_MASK = 0xF;
        public const int APPCLASS_MONITOR = 0x1;
        public const int APPCLASS_STANDARD = 0x0;
        public const int APPCMD_CLIENTONLY = 0x10;
        public const int APPCMD_FILTERINITS = 0x20;
        public const int APPCMD_MASK = 0xFF0;
        public const int BDR_INNER = 0xC;
        public const int BDR_OUTER = 0x3;
        public const int BDR_RAISED = 0x5;
        public const int BDR_RAISEDINNER = 0x4;
        public const int BDR_RAISEDOUTER = 0x1;
        public const int BDR_SUNKEN = 0xA;
        public const int BDR_SUNKENINNER = 0x8;
        public const int BDR_SUNKENOUTER = 0x2;
        public const int BF_ADJUST = 0x2000;
        public const int BF_BOTTOM = 0x8;
        public const int BF_BOTTOMLEFT = (BF_BOTTOM | BF_LEFT);
        public const int BF_BOTTOMRIGHT = (BF_BOTTOM | BF_RIGHT);
        public const int BF_DIAGONAL = 0x10;
        public const int BF_DIAGONAL_ENDBOTTOMLEFT = (BF_DIAGONAL | BF_BOTTOM | BF_LEFT);
        public const int BF_DIAGONAL_ENDBOTTOMRIGHT = (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT);
        public const int BF_DIAGONAL_ENDTOPLEFT = (BF_DIAGONAL | BF_TOP | BF_LEFT);
        public const int BF_DIAGONAL_ENDTOPRIGHT = (BF_DIAGONAL | BF_TOP | BF_RIGHT);
        public const int BF_FLAT = 0x4000;
        public const int BF_LEFT = 0x1;
        public const int BF_MIDDLE = 0x800;
        public const int BF_MONO = 0x8000;
        public const int BF_RECT = (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM);
        public const int BF_RIGHT = 0x4;
        public const int BF_SOFT = 0x1000;
        public const int BF_TOP = 0x2;
        public const int BF_TOPLEFT = (BF_TOP | BF_LEFT);
        public const int BF_TOPRIGHT = (BF_TOP | BF_RIGHT);
        public const int BIF_BROWSEFORCOMPUTER = 4096;
        public const int BIF_BROWSEFORPRINTER = 8192;
        public const int BIF_BROWSEINCLUDEFILES = 16384;
        public const int BIF_BROWSEINCLUDEURLS = 128;
        public const int BIF_DONTGOBELOWDOMAIN = 2;
        public const int BIF_EDITBOX = 16;
        public const int BIF_RETURNFSANCESTORS = 8;
        public const int BIF_RETURNONLYFSDIRS = 1;
        public const int BIF_SHAREABLE = 32768;
        public const int BIF_STATUSTEXT = 4;
        public const int BIF_USENEWUI = 64;
        public const int BIF_VALIDATE = 32;
        public const int BM_GETCHECK = 0xF0;
        public const int BM_GETSTATE = 0xF2;
        public const int BM_SETCHECK = 0xF1;
        public const int BM_SETSTATE = 0xF3;
        public const int BM_SETSTYLE = 0xF4;
        public const int BN_CLICKED = 0;
        public const int BN_DISABLE = 4;
        public const int BN_DOUBLECLICKED = 5;
        public const int BN_HILITE = 2;
        public const int BN_PAINT = 1;
        public const int BN_UNHILITE = 3;
        public const int BS_3STATE = 0x5;
        public const int BS_AUTO3STATE = 0x6;
        public const int BS_AUTOCHECKBOX = 0x3;
        public const int BS_AUTORADIOBUTTON = 0x9;
        public const int BS_CHECKBOX = 0x2;
        public const int BS_DEFPUSHBUTTON = 0x1;
        public const int BS_GROUPBOX = 0x7;
        public const int BS_LEFTTEXT = 0x20;
        public const int BS_OWNERDRAW = 0xB;
        public const int BS_PUSHBUTTON = 0x0;
        public const int BS_RADIOBUTTON = 0x4;
        public const int BS_USERBUTTON = 0x8;
        public const int CADV_LATEACK = 0xFFFF;
        public const int CBF_FAIL_ADVISES = 0x4000;
        public const int CBF_FAIL_ALLSVRXACTIONS = 0x3F000;
        public const int CBF_FAIL_CONNECTIONS = 0x2000;
        public const int CBF_FAIL_EXECUTES = 0x8000;
        public const int CBF_FAIL_POKES = 0x10000;
        public const int CBF_FAIL_REQUESTS = 0x20000;
        public const int CBF_FAIL_SELFCONNECTIONS = 0x1000;
        public const int CBF_SKIP_ALLNOTIFICATIONS = 0x3C0000;
        public const int CBF_SKIP_CONNECT_CONFIRMS = 0x40000;
        public const int CBF_SKIP_DISCONNECTS = 0x200000;
        public const int CBF_SKIP_REGISTRATIONS = 0x80000;
        public const int CBF_SKIP_UNREGISTRATIONS = 0x100000;
        public const int CBN_CLOSEUP = 8;
        public const int CBN_DBLCLK = 2;
        public const int CBN_DROPDOWN = 7;
        public const int CBN_EDITCHANGE = 5;
        public const int CBN_EDITUPDATE = 6;
        public const int CBN_ERRSPACE = (-1);
        public const int CBN_KILLFOCUS = 4;
        public const int CBN_SELCHANGE = 1;
        public const int CBN_SELENDCANCEL = 10;
        public const int CBN_SELENDOK = 9;
        public const int CBN_SETFOCUS = 3;
        public const int CBR_BLOCK = 0xFFFF;
        public const int CBS_AUTOHSCROLL = 0x40;
        public const int CBS_DISABLENOSCROLL = 0x800;
        public const int CBS_DROPDOWN = 0x2;
        public const int CBS_DROPDOWNLIST = 0x3;
        public const int CBS_HASSTRINGS = 0x200;
        public const int CBS_NOINTEGRALHEIGHT = 0x400;
        public const int CBS_OEMCONVERT = 0x80;
        public const int CBS_OWNERDRAWFIXED = 0x10;
        public const int CBS_OWNERDRAWVARIABLE = 0x20;
        public const int CBS_SIMPLE = 0x1;
        public const int CBS_SORT = 0x100;
        public const int CB_ADDSTRING = 0x143;
        public const int CB_DELETESTRING = 0x144;
        public const int CB_DIR = 0x145;
        public const int CB_ERR = (-1);
        public const int CB_ERRSPACE = (-2);
        public const int CB_FINDSTRING = 0x14C;
        public const int CB_FINDSTRINGEXACT = 0x158;
        public const int CB_GETCOUNT = 0x146;
        public const int CB_GETCURSEL = 0x147;
        public const int CB_GETDROPPEDCONTROLRECT = 0x152;
        public const int CB_GETDROPPEDSTATE = 0x157;
        public const int CB_GETEDITSEL = 0x140;
        public const int CB_GETEXTENDEDUI = 0x156;
        public const int CB_GETITEMDATA = 0x150;
        public const int CB_GETITEMHEIGHT = 0x154;
        public const int CB_GETLBTEXT = 0x148;
        public const int CB_GETLBTEXTLEN = 0x149;
        public const int CB_GETLOCALE = 0x15A;
        public const int CB_INSERTSTRING = 0x14A;
        public const int CB_LIMITTEXT = 0x141;
        public const int CB_MSGMAX = 0x15B;
        public const int CB_OKAY = 0;
        public const int CB_RESETCONTENT = 0x14B;
        public const int CB_SELECTSTRING = 0x14D;
        public const int CB_SETCURSEL = 0x14E;
        public const int CB_SETEDITSEL = 0x142;
        public const int CB_SETEXTENDEDUI = 0x155;
        public const int CB_SETITEMDATA = 0x151;
        public const int CB_SETITEMHEIGHT = 0x153;
        public const int CB_SETLOCALE = 0x159;
        public const int CB_SHOWDROPDOWN = 0x14F;
        public const int CF_BITMAP = 2;
        public const int CF_DIB = 8;
        public const int CF_DIF = 5;
        public const int CF_DSPBITMAP = 0x82;
        public const int CF_DSPENHMETAFILE = 0x8E;
        public const int CF_DSPMETAFILEPICT = 0x83;
        public const int CF_DSPTEXT = 0x81;
        public const int CF_ENHMETAFILE = 14;
        public const int CF_GDIOBJFIRST = 0x300;
        public const int CF_GDIOBJLAST = 0x3FF;
        public const int CF_METAFILEPICT = 3;
        public const int CF_OEMTEXT = 7;
        public const int CF_OWNERDISPLAY = 0x80;
        public const int CF_PALETTE = 9;
        public const int CF_PENDATA = 10;
        public const int CF_PRIVATEFIRST = 0x200;
        public const int CF_PRIVATELAST = 0x2FF;
        public const int CF_RIFF = 11;
        public const int CF_SYLK = 4;
        public const int CF_TEXT = 1;
        public const int CF_TIFF = 6;
        public const int CF_UNICODETEXT = 13;
        public const int CF_WAVE = 12;
        public const int CN_EVENT = 0x4;
        public const int CN_RECEIVE = 0x1;
        public const int CN_TRANSMIT = 0x2;
        public const int COLOR_ACTIVEBORDER = 10;
        public const int COLOR_ACTIVECAPTION = 2;
        public const int COLOR_APPWORKSPACE = 12;
        public const int COLOR_BACKGROUND = 1;
        public const int COLOR_BTNFACE = 15;
        public const int COLOR_BTNHIGHLIGHT = 20;
        public const int COLOR_BTNSHADOW = 16;
        public const int COLOR_BTNTEXT = 18;
        public const int COLOR_CAPTIONTEXT = 9;
        public const int COLOR_GRAYTEXT = 17;
        public const int COLOR_HIGHLIGHT = 13;
        public const int COLOR_HIGHLIGHTTEXT = 14;
        public const int COLOR_INACTIVEBORDER = 11;
        public const int COLOR_INACTIVECAPTION = 3;
        public const int COLOR_INACTIVECAPTIONTEXT = 19;
        public const int COLOR_MENU = 4;
        public const int COLOR_MENUTEXT = 7;
        public const int COLOR_SCROLLBAR = 0;
        public const int COLOR_WINDOW = 5;
        public const int COLOR_WINDOWFRAME = 6;
        public const int COLOR_WINDOWTEXT = 8;
        public const int CP_WINANSI = 1004;
        public const int CP_WINUNICODE = 1200;
        public const int CS_BYTEALIGNCLIENT = 0x1000;
        public const int CS_BYTEALIGNWINDOW = 0x2000;
        public const int CS_CLASSDC = 0x40;
        public const int CS_DBLCLKS = 0x8;
        public const int CS_HREDRAW = 0x2;
        public const int CS_KEYCVTWINDOW = 0x4;
        public const int CS_NOCLOSE = 0x200;
        public const int CS_NOKEYCVT = 0x100;
        public const int CS_OWNDC = 0x20;
        public const int CS_PARENTDC = 0x80;
        public const int CS_PUBLICCLASS = 0x4000;
        public const int CS_SAVEBITS = 0x800;
        public const int CS_VREDRAW = 0x1;
        public const int CTLCOLOR_BTN = 3;
        public const int CTLCOLOR_DLG = 4;
        public const int CTLCOLOR_EDIT = 1;
        public const int CTLCOLOR_LISTBOX = 2;
        public const int CTLCOLOR_MAX = 8;
        public const int CTLCOLOR_MSGBOX = 0;
        public const int CTLCOLOR_SCROLLBAR = 5;
        public const int CTLCOLOR_STATIC = 6;
        public const int CW_USEDEFAULT = unchecked((int) 0x80000000);
        public const int DCX_CACHE = 0x2;
        public const int DCX_CLIPCHILDREN = 0x8;
        public const int DCX_CLIPSIBLINGS = 0x10;
        public const int DCX_EXCLUDERGN = 0x40;
        public const int DCX_EXCLUDEUPDATE = 0x100;
        public const int DCX_INTERSECTRGN = 0x80;
        public const int DCX_INTERSECTUPDATE = 0x200;
        public const int DCX_LOCKWINDOWUPDATE = 0x400;
        public const int DCX_NORECOMPUTE = 0x100000;
        public const int DCX_NORESETATTRS = 0x4;
        public const int DCX_PARENTCLIP = 0x20;
        public const int DCX_VALIDATE = 0x200000;
        public const int DCX_WINDOW = 0x1;
        public const int DC_HASDEFID = 0x534;
        public const int DDE_FACK = 0x8000;
        public const int DDE_FACKREQ = 0x8000;
        public const int DDE_FACKRESERVED = (~ (DDE_FACK | DDE_FBUSY | DDE_FAPPSTATUS));
        public const int DDE_FADVRESERVED = (~ (DDE_FACKREQ | DDE_FDEFERUPD));
        public const int DDE_FAPPSTATUS = 0xFF;
        public const int DDE_FBUSY = 0x4000;
        public const int DDE_FDATRESERVED = (~ (DDE_FACKREQ | DDE_FRELEASE | DDE_FREQUESTED));
        public const int DDE_FDEFERUPD = 0x4000;
        public const int DDE_FNOTPROCESSED = 0x0;
        public const int DDE_FPOKRESERVED = (~ (DDE_FRELEASE));
        public const int DDE_FRELEASE = 0x2000;
        public const int DDE_FREQUESTED = 0x1000;
        public const int DDL_ARCHIVE = 0x20;
        public const int DDL_DIRECTORY = 0x10;
        public const int DDL_DRIVES = 0x4000;
        public const int DDL_EXCLUSIVE = 0x8000;
        public const int DDL_HIDDEN = 0x2;
        public const int DDL_POSTMSGS = 0x2000;
        public const int DDL_READONLY = 0x1;
        public const int DDL_READWRITE = 0x0;
        public const int DDL_SYSTEM = 0x4;
        public const int DESKTOP_CREATEMENU = 0x4;
        public const int DESKTOP_CREATEWINDOW = 0x2;
        public const int DESKTOP_ENUMERATE = 0x40;
        public const int DESKTOP_HOOKCONTROL = 0x8;
        public const int DESKTOP_JOURNALPLAYBACK = 0x20;
        public const int DESKTOP_JOURNALRECORD = 0x10;
        public const int DESKTOP_READOBJECTS = 0x1;
        public const int DESKTOP_WRITEOBJECTS = 0x80;
        public const int DLGC_BUTTON = 0x2000;
        public const int DLGC_DEFPUSHBUTTON = 0x10;
        public const int DLGC_HASSETSEL = 0x8;
        public const int DLGC_RADIOBUTTON = 0x40;
        public const int DLGC_STATIC = 0x100;
        public const int DLGC_UNDEFPUSHBUTTON = 0x20;
        public const int DLGC_WANTALLKEYS = 0x4;
        public const int DLGC_WANTARROWS = 0x1;
        public const int DLGC_WANTCHARS = 0x80;
        public const int DLGC_WANTMESSAGE = 0x4;
        public const int DLGC_WANTTAB = 0x2;
        public const int DLGWINDOWEXTRA = 30;
        public const int DMLERR_ADVACKTIMEOUT = 0x4000;
        public const int DMLERR_BUSY = 0x4001;
        public const int DMLERR_DATAACKTIMEOUT = 0x4002;
        public const int DMLERR_DLL_NOT_INITIALIZED = 0x4003;
        public const int DMLERR_DLL_USAGE = 0x4004;
        public const int DMLERR_EXECACKTIMEOUT = 0x4005;
        public const int DMLERR_FIRST = 0x4000;
        public const int DMLERR_INVALIDPARAMETER = 0x4006;
        public const int DMLERR_LAST = 0x4011;
        public const int DMLERR_LOW_MEMORY = 0x4007;
        public const int DMLERR_MEMORY_ERROR = 0x4008;
        public const int DMLERR_NOTPROCESSED = 0x4009;
        public const int DMLERR_NO_CONV_ESTABLISHED = 0x400A;
        public const int DMLERR_NO_ERROR = 0;
        public const int DMLERR_POKEACKTIMEOUT = 0x400B;
        public const int DMLERR_POSTMSG_FAILED = 0x400C;
        public const int DMLERR_REENTRANCY = 0x400D;
        public const int DMLERR_SERVER_DIED = 0x400E;
        public const int DMLERR_SYS_ERROR = 0x400F;
        public const int DMLERR_UNADVACKTIMEOUT = 0x4010;
        public const int DMLERR_UNFOUND_QUEUE_ID = 0x4011;
        public const int DM_GETDEFID = WM_USER + 0;
        public const int DM_SETDEFID = WM_USER + 1;
        public const int DNS_FILTEROFF = 0x8;
        public const int DNS_FILTERON = 0x4;
        public const int DNS_REGISTER = 0x1;
        public const int DNS_UNREGISTER = 0x2;
        public const int DS_ABSALIGN = 0x1;
        public const int DS_LOCALEDIT = 0x20;
        public const int DS_MODALFRAME = 0x80;
        public const int DS_NOIDLEMSG = 0x100;
        public const int DS_SETFONT = 0x40;
        public const int DS_SETFOREGROUND = 0x200;
        public const int DS_SYSMODAL = 0x2;
        public const int DT_BOTTOM = 0x8;
        public const int DT_CALCRECT = 0x400;
        public const int DT_CENTER = 0x1;
        public const int DT_EDITCONTROL = 0x2000;
        public const int DT_END_ELLIPSIS = 0x8000;
        public const int DT_EXPANDTABS = 0x40;
        public const int DT_EXTERNALLEADING = 0x200;
        public const int DT_INTERNAL = 0x1000;
        public const int DT_LEFT = 0x0;
        public const int DT_MODIFYSTRING = 0x10000;
        public const int DT_NOCLIP = 0x100;
        public const int DT_NOPREFIX = 0x800;
        public const int DT_PATH_ELLIPSIS = 0x4000;
        public const int DT_RIGHT = 0x2;
        public const int DT_RTLREADING = 0x20000;
        public const int DT_SINGLELINE = 0x20;
        public const int DT_TABSTOP = 0x80;
        public const int DT_TOP = 0x0;
        public const int DT_VCENTER = 0x4;
        public const int DT_WORDBREAK = 0x10;
        public const int DT_WORD_ELLIPSIS = 0x40000;
        public const int DWL_DLGPROC = 4;
        public const int DWL_MSGRESULT = 0;
        public const int DWL_USER = 8;
        public const int EC_DISABLE = ST_BLOCKED;
        public const int EC_ENABLEALL = 0;
        public const int EC_ENABLEONE = ST_BLOCKNEXT;
        public const int EC_QUERYWAITING = 2;
        public const int EDGE_BUMP = (BDR_RAISEDOUTER | BDR_SUNKENINNER);
        public const int EDGE_ETCHED = (BDR_SUNKENOUTER | BDR_RAISEDINNER);
        public const int EDGE_RAISED = (BDR_RAISEDOUTER | BDR_RAISEDINNER);
        public const int EDGE_SUNKEN = (BDR_SUNKENOUTER | BDR_SUNKENINNER);
        public const int EM_CANPASTE = 0x432;
        public const int EM_CANREDO = 0x455;
        public const int EM_CANUNDO = 0xC6;
        public const int EM_CHARFROMPOS = 0x427;
        public const int EM_DISPLAYBAND = 0x433;
        public const int EM_EMPTYUNDOBUFFER = 0xCD;
        public const int EM_EXGETSEL = 0x434;
        public const int EM_EXLIMITTEXT = 0x435;
        public const int EM_EXLINEFROMCHAR = 0x436;
        public const int EM_EXSETSEL = 0x437;
        public const int EM_FINDTEXT = 0x438;
        public const int EM_FINDTEXTEX = 0x44F;
        public const int EM_FINDWORDBREAK = 0x44C;
        public const int EM_FMTLINES = 0xC8;
        public const int EM_FORMATRANGE = 0x439;
        public const int EM_GETCHARFORMAT = 0x43A;
        public const int EM_GETEVENTMASK = 0x43B;
        public const int EM_GETFIRSTVISIBLELINE = 0xCE;
        public const int EM_GETLIMITTEXT = 0x425;
        public const int EM_GETLINE = 0xC4;
        public const int EM_GETLINECOUNT = 0xBA;
        public const int EM_GETMODIFY = 0xB8;
        public const int EM_GETOLEINTERFACE = 0x43C;
        public const int EM_GETOPTIONS = 0x44E;
        public const int EM_GETPARAFORMAT = 0x43D;
        public const int EM_GETPASSWORDCHAR = 0xD2;
        public const int EM_GETRECT = 0xB2;
        public const int EM_GETREDONAME = 0x457;
        public const int EM_GETSEL = 0xB0;
        public const int EM_GETSELTEXT = 0x43E;
        public const int EM_GETTEXTMODE = 0x45A;
        public const int EM_GETTEXTRANGE = 0x44B;
        public const int EM_GETTHUMB = 0xBE;
        public const int EM_GETUNDONAME = 0x456;
        public const int EM_GETWORDBREAKPROC = 0xD1;
        public const int EM_HIDESELECTION = 0x43F;
        public const int EM_LIMITTEXT = 0xC5;
        public const int EM_LINEFROMCHAR = 0xC9;
        public const int EM_LINEINDEX = 0xBB;
        public const int EM_LINELENGTH = 0xC1;
        public const int EM_LINESCROLL = 0xB6;
        public const int EM_PASTESPECIAL = 0x440;
        public const int EM_POSFROMCHAR = 0x426;
        public const int EM_REDO = 0x454;
        public const int EM_REPLACESEL = 0xC2;
        public const int EM_REQUESTRESIZE = 0x441;
        public const int EM_SCROLL = 0xB5;
        public const int EM_SCROLLCARET = 0xB7;
        public const int EM_SELECTIONTYPE = 0x442;
        public const int EM_SETBKGNDCOLOR = 0x443;
        public const int EM_SETCHARFORMAT = 0x444;
        public const int EM_SETEVENTMASK = 0x445;
        public const int EM_SETMODIFY = 0xB9;
        public const int EM_SETOLECALLBACK = 0x446;
        public const int EM_SETOPTIONS = 0x44D;
        public const int EM_SETPARAFORMAT = 0x447;
        public const int EM_SETPASSWORDCHAR = 0xCC;
        public const int EM_SETREADONLY = 0xCF;
        public const int EM_SETRECT = 0xB3;
        public const int EM_SETRECTNP = 0xB4;
        public const int EM_SETSEL = 0xB1;
        public const int EM_SETTABSTOPS = 0xCB;
        public const int EM_SETTARGETDEVICE = 0x448;
        public const int EM_SETTEXTMODE = 0x459;
        public const int EM_SETUNDOLIMIT = 0x452;
        public const int EM_SETWORDBREAKPROC = 0xD0;
        public const int EM_STOPGROUPTYPING = 0x458;
        public const int EM_STREAMIN = 0x449;
        public const int EM_STREAMOUT = 0x44A;
        public const int EM_UNDO = 0xC7;
        public const int EN_CHANGE = 0x300;
        public const int EN_ERRSPACE = 0x500;
        public const int EN_HSCROLL = 0x601;
        public const int EN_KILLFOCUS = 0x200;
        public const int EN_MAXTEXT = 0x501;
        public const int EN_SETFOCUS = 0x100;
        public const int EN_UPDATE = 0x400;
        public const int EN_VSCROLL = 0x602;
        public const int ESB_DISABLE_BOTH = 0x3;
        public const int ESB_DISABLE_DOWN = 0x2;
        public const int ESB_DISABLE_LEFT = 0x1;
        public const int ESB_DISABLE_LTUP = ESB_DISABLE_LEFT;
        public const int ESB_DISABLE_RIGHT = 0x2;
        public const int ESB_DISABLE_RTDN = ESB_DISABLE_RIGHT;
        public const int ESB_DISABLE_UP = 0x1;
        public const int ESB_ENABLE_BOTH = 0x0;
        public const int ES_AUTOHSCROLL = 0x80;
        public const int ES_AUTOVSCROLL = 0x40;
        public const int ES_CENTER = 0x1;
        public const int ES_LEFT = 0x0;
        public const int ES_LOWERCASE = 0x10;
        public const int ES_MULTILINE = 0x4;
        public const int ES_NOHIDESEL = 0x100;
        public const int ES_OEMCONVERT = 0x400;
        public const int ES_PASSWORD = 0x20;
        public const int ES_READONLY = 0x800;
        public const int ES_RIGHT = 0x2;
        public const int ES_UPPERCASE = 0x8;
        public const int ES_WANTRETURN = 0x1000;
        public const int EWX_FORCE = 4;
        public const int EWX_LOGOFF = 0;
        public const int EWX_REBOOT = 2;
        public const int EWX_SHUTDOWN = 1;
        public const int FALT = 0x10;
        public const int FCONTROL = 0x8;
        public const int FNOINVERT = 0x2;
        public const int FSHIFT = 0x4;
        public const int FVIRTKEY = 0x1;
        public const int GCL_CBCLSEXTRA = (-20);
        public const int GCL_CBWNDEXTRA = (-18);
        public const int GCL_HBRBACKGROUND = (-10);
        public const int GCL_HCURSOR = (-12);
        public const int GCL_HICON = (-14);
        public const int GCL_HMODULE = (-16);
        public const int GCL_MENUNAME = (-8);
        public const int GCL_STYLE = (-26);
        public const int GCL_WNDPROC = (-24);
        public const int GCW_ATOM = (-32);
        public const int GWL_EXSTYLE = (-20);
        public const int GWL_HINSTANCE = (-6);
        public const int GWL_HWNDPARENT = (-8);
        public const int GWL_ID = (-12);
        public const int GWL_STYLE = (-16);
        public const int GWL_USERDATA = (-21);
        public const int GWL_WNDPROC = (-4);
        public const int GW_CHILD = 5;
        public const int GW_HWNDFIRST = 0;
        public const int GW_HWNDLAST = 1;
        public const int GW_HWNDNEXT = 2;
        public const int GW_HWNDPREV = 3;
        public const int GW_MAX = 5;
        public const int GW_OWNER = 4;
        public const int HCBT_ACTIVATE = 5;
        public const int HCBT_CLICKSKIPPED = 6;
        public const int HCBT_CREATEWND = 3;
        public const int HCBT_DESTROYWND = 4;
        public const int HCBT_KEYSKIPPED = 7;
        public const int HCBT_MINMAX = 1;
        public const int HCBT_MOVESIZE = 0;
        public const int HCBT_QS = 2;
        public const int HCBT_SETFOCUS = 9;
        public const int HCBT_SYSCOMMAND = 8;
        public const int HC_ACTION = 0;
        public const int HC_GETNEXT = 1;
        public const int HC_NOREM = HC_NOREMOVE;
        public const int HC_NOREMOVE = 3;
        public const int HC_SKIP = 2;
        public const int HC_SYSMODALOFF = 5;
        public const int HC_SYSMODALON = 4;
        public const int HDATA_APPOWNED = 0x1;
        public const int HELP_COMMAND = 0x102;
        public const int HELP_CONTENTS = 0x3;
        public const int HELP_CONTEXT = 0x1;
        public const int HELP_CONTEXTPOPUP = 0x8;
        public const int HELP_FORCEFILE = 0x9;
        public const int HELP_HELPONHELP = 0x4;
        public const int HELP_INDEX = 0x3;
        public const int HELP_KEY = 0x101;
        public const int HELP_MULTIKEY = 0x201;
        public const int HELP_PARTIALKEY = 0x105;
        public const int HELP_QUIT = 0x2;
        public const int HELP_SETCONTENTS = 0x5;
        public const int HELP_SETINDEX = 0x5;
        public const int HELP_SETWINPOS = 0x203;
        public const int HIDE_WINDOW = 0;
        public const int HKL_NEXT = 1;
        public const int HKL_PREV = 0;
        public const int HSHELL_ACTIVATESHELLWINDOW = 3;
        public const int HSHELL_WINDOWCREATED = 1;
        public const int HSHELL_WINDOWDESTROYED = 2;
        public const int HTBORDER = 18;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 16;
        public const int HTBOTTOMRIGHT = 17;
        public const int HTCAPTION = 2;
        public const int HTCLIENT = 1;
        public const int HTERROR = (-2);
        public const int HTGROWBOX = 4;
        public const int HTHSCROLL = 6;
        public const int HTLEFT = 10;
        public const int HTMAXBUTTON = 9;
        public const int HTMENU = 5;
        public const int HTMINBUTTON = 8;
        public const int HTNOWHERE = 0;
        public const int HTREDUCE = HTMINBUTTON;
        public const int HTRIGHT = 11;
        public const int HTSIZE = HTGROWBOX;
        public const int HTSIZEFIRST = HTLEFT;
        public const int HTSIZELAST = HTBOTTOMRIGHT;
        public const int HTSYSMENU = 3;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTTRANSPARENT = (-1);
        public const int HTVSCROLL = 7;
        public const int HTZOOM = HTMAXBUTTON;

        public const int IDABORT = 3;
        public const int IDCANCEL = 2;
        public const int IDC_APPSTARTING = 32650;
        public const int IDC_ARROW = 32512;
        public const int IDC_CROSS = 32515;
        public const int IDC_IBEAM = 32513;
        public const int IDC_ICON = 32641;
        public const int IDC_NO = 32648;
        public const int IDC_SIZE = 32640;
        public const int IDC_SIZEALL = 32646;
        public const int IDC_SIZENESW = 32643;
        public const int IDC_SIZENS = 32645;
        public const int IDC_SIZENWSE = 32642;
        public const int IDC_SIZEWE = 32644;
        public const int IDC_UPARROW = 32516;
        public const int IDC_WAIT = 32514;
        public const int IDHOT_SNAPDESKTOP = (-2);
        public const int IDHOT_SNAPWINDOW = (-1);
        public const int IDIGNORE = 5;
        public const int IDI_APPLICATION = 32512;
        public const int IDI_ASTERISK = 32516;
        public const int IDI_EXCLAMATION = 32515;
        public const int IDI_HAND = 32513;
        public const int IDI_QUESTION = 32514;
        public const int IDNO = 7;
        public const int IDOK = 1;
        public const int IDRETRY = 4;
        public const int IDYES = 6;
        public const int INVALID_HANDLE_VALUE = -1;
        public const int KEYEVENTF_EXTENDEDKEY = 0x1;
        public const int KEYEVENTF_KEYUP = 0x2;
        public const int KF_ALTDOWN = 0x2000;
        public const int KF_DLGMODE = 0x800;
        public const int KF_EXTENDED = 0x100;
        public const int KF_MENUMODE = 0x1000;
        public const int KF_REPEAT = 0x4000;
        public const int KF_UP = 0x8000;
        public const int KLF_ACTIVATE = 0x1;
        public const int KLF_REORDER = 0x8;
        public const int KLF_SUBSTITUTE_OK = 0x2;
        public const int KLF_UNLOADPREVIOUS = 0x4;
        public const int KL_NAMELENGTH = 9;
        public const int LBN_DBLCLK = 2;
        public const int LBN_ERRSPACE = (-2);
        public const int LBN_KILLFOCUS = 5;
        public const int LBN_SELCANCEL = 3;
        public const int LBN_SELCHANGE = 1;
        public const int LBN_SETFOCUS = 4;
        public const int LBS_DISABLENOSCROLL = 0x1000;
        public const int LBS_EXTENDEDSEL = 0x800;
        public const int LBS_HASSTRINGS = 0x40;
        public const int LBS_MULTICOLUMN = 0x200;
        public const int LBS_MULTIPLESEL = 0x8;
        public const int LBS_NODATA = 0x2000;
        public const int LBS_NOINTEGRALHEIGHT = 0x100;
        public const int LBS_NOREDRAW = 0x4;
        public const int LBS_NOTIFY = 0x1;
        public const int LBS_OWNERDRAWFIXED = 0x10;
        public const int LBS_OWNERDRAWVARIABLE = 0x20;
        public const int LBS_SORT = 0x2;
        public const int LBS_STANDARD = (LBS_NOTIFY | LBS_SORT | WS_VSCROLL | WS_BORDER);
        public const int LBS_USETABSTOPS = 0x80;
        public const int LBS_WANTKEYBOARDINPUT = 0x400;
        public const int LB_ADDFILE = 0x196;
        public const int LB_ADDSTRING = 0x180;
        public const int LB_CTLCODE = 0;
        public const int LB_DELETESTRING = 0x182;
        public const int LB_DIR = 0x18D;
        public const int LB_ERR = (-1);
        public const int LB_ERRSPACE = (-2);
        public const int LB_FINDSTRING = 0x18F;
        public const int LB_FINDSTRINGEXACT = 0x1A2;
        public const int LB_GETANCHORINDEX = 0x19D;
        public const int LB_GETCARETINDEX = 0x19F;
        public const int LB_GETCOUNT = 0x18B;
        public const int LB_GETCURSEL = 0x188;
        public const int LB_GETHORIZONTALEXTENT = 0x193;
        public const int LB_GETITEMDATA = 0x199;
        public const int LB_GETITEMHEIGHT = 0x1A1;
        public const int LB_GETITEMRECT = 0x198;
        public const int LB_GETLOCALE = 0x1A6;
        public const int LB_GETSEL = 0x187;
        public const int LB_GETSELCOUNT = 0x190;
        public const int LB_GETSELITEMS = 0x191;
        public const int LB_GETTEXT = 0x189;
        public const int LB_GETTEXTLEN = 0x18A;
        public const int LB_GETTOPINDEX = 0x18E;
        public const int LB_INSERTSTRING = 0x181;
        public const int LB_MSGMAX = 0x1A8;
        public const int LB_OKAY = 0;
        public const int LB_RESETCONTENT = 0x184;
        public const int LB_SELECTSTRING = 0x18C;
        public const int LB_SELITEMRANGE = 0x19B;
        public const int LB_SELITEMRANGEEX = 0x183;
        public const int LB_SETANCHORINDEX = 0x19C;
        public const int LB_SETCARETINDEX = 0x19E;
        public const int LB_SETCOLUMNWIDTH = 0x195;
        public const int LB_SETCOUNT = 0x1A7;
        public const int LB_SETCURSEL = 0x186;
        public const int LB_SETHORIZONTALEXTENT = 0x194;
        public const int LB_SETITEMDATA = 0x19A;
        public const int LB_SETITEMHEIGHT = 0x1A0;
        public const int LB_SETLOCALE = 0x1A5;
        public const int LB_SETSEL = 0x185;
        public const int LB_SETTABSTOPS = 0x192;
        public const int LB_SETTOPINDEX = 0x197;
        public const int MAX_MONITORS = 4;
        public const int MA_ACTIVATE = 1;
        public const int MA_ACTIVATEANDEAT = 2;
        public const int MA_NOACTIVATE = 3;
        public const int MA_NOACTIVATEANDEAT = 4;
        public const int MB_ABORTRETRYIGNORE = 0x2;
        public const int MB_APPLMODAL = 0x0;
        public const int MB_DEFAULT_DESKTOP_ONLY = 0x20000;
        public const int MB_DEFBUTTON1 = 0x0;
        public const int MB_DEFBUTTON2 = 0x100;
        public const int MB_DEFBUTTON3 = 0x200;
        public const int MB_DEFMASK = 0xF00;
        public const int MB_ICONASTERISK = 0x40;
        public const int MB_ICONEXCLAMATION = 0x30;
        public const int MB_ICONHAND = 0x10;
        public const int MB_ICONINFORMATION = MB_ICONASTERISK;
        public const int MB_ICONMASK = 0xF0;
        public const int MB_ICONQUESTION = 0x20;
        public const int MB_ICONSTOP = MB_ICONHAND;
        public const int MB_MISCMASK = 0xC000;
        public const int MB_MODEMASK = 0x3000;
        public const int MB_NOFOCUS = 0x8000;
        public const int MB_OK = 0x0;
        public const int MB_OKCANCEL = 0x1;
        public const int MB_RETRYCANCEL = 0x5;
        public const int MB_SETFOREGROUND = 0x10000;
        public const int MB_SYSTEMMODAL = 0x1000;
        public const int MB_TASKMODAL = 0x2000;
        public const int MB_TYPEMASK = 0xF;
        public const int MB_YESNO = 0x4;
        public const int MB_YESNOCANCEL = 0x3;
        public const int MDIS_ALLCHILDSTYLES = 0x1;
        public const int MDITILE_HORIZONTAL = 0x1;
        public const int MDITILE_SKIPDISABLED = 0x2;
        public const int MDITILE_VERTICAL = 0x0;
        public const int MF_APPEND = 0x100;
        public const int MF_BITMAP = 0x4;
        public const int MF_BYCOMMAND = 0x0;
        public const int MF_BYPOSITION = 0x400;
        public const int MF_CALLBACKS = 0x8000000;
        public const int MF_CHANGE = 0x80;
        public const int MF_CHECKED = 0x8;
        public const int MF_CONV = 0x40000000;
        public const int MF_DELETE = 0x200;
        public const int MF_DISABLED = 0x2;
        public const int MF_ENABLED = 0x0;
        public const int MF_END = 0x80;
        public const int MF_ERRORS = 0x10000000;
        public const int MF_GRAYED = 0x1;
        public const int MF_HELP = 0x4000;
        public const int MF_HILITE = 0x80;
        public const int MF_HSZ_INFO = 0x1000000;
        public const int MF_INSERT = 0x0;
        public const int MF_LINKS = 0x20000000;
        public const int MF_MASK = unchecked((int) 0xFF000000);
        public const int MF_MENUBARBREAK = 0x20;
        public const int MF_MENUBREAK = 0x40;
        public const int MF_MOUSESELECT = 0x8000;
        public const int MF_OWNERDRAW = 0x100;
        public const int MF_POPUP = 0x10;
        public const int MF_POSTMSGS = 0x4000000;
        public const int MF_REMOVE = 0x1000;
        public const int MF_SENDMSGS = 0x2000000;
        public const int MF_SEPARATOR = 0x800;
        public const int MF_STRING = 0x0;
        public const int MF_SYSMENU = 0x2000;
        public const int MF_UNCHECKED = 0x0;
        public const int MF_UNHILITE = 0x0;
        public const int MF_USECHECKBITMAPS = 0x200;
        public const int MH_CLEANUP = 4;
        public const int MH_CREATE = 1;
        public const int MH_DELETE = 3;
        public const int MH_KEEP = 2;
        public const int MK_CONTROL = 0x8;
        public const int MK_LBUTTON = 0x1;
        public const int MK_MBUTTON = 0x10;
        public const int MK_RBUTTON = 0x2;
        public const int MK_SHIFT = 0x4;
        public const int MOD_ALT = 0x1;
        public const int MOD_CONTROL = 0x2;
        public const int MOD_SHIFT = 0x4;
        public const int MOD_WIN = 0x8;
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public const int MOUSEEVENTF_LEFTDOWN = 0x2;
        public const int MOUSEEVENTF_LEFTUP = 0x4;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        public const int MOUSEEVENTF_MIDDLEUP = 0x40;
        public const int MOUSEEVENTF_MOVE = 0x1;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public const int MSGF_DDEMGR = 0x8001;
        public const int MSGF_DIALOGBOX = 0;
        public const int MSGF_MAINLOOP = 8;
        public const int MSGF_MAX = 8;
        public const int MSGF_MENU = 2;
        public const int MSGF_MESSAGEBOX = 1;
        public const int MSGF_MOVE = 3;
        public const int MSGF_NEXTWINDOW = 6;
        public const int MSGF_SCROLLBAR = 5;
        public const int MSGF_SIZE = 4;
        public const int MSGF_USER = 4096;
        public const int OBM_BTNCORNERS = 32758;
        public const int OBM_BTSIZE = 32761;
        public const int OBM_CHECK = 32760;
        public const int OBM_CHECKBOXES = 32759;
        public const int OBM_CLOSE = 32754;
        public const int OBM_COMBO = 32738;
        public const int OBM_DNARROW = 32752;
        public const int OBM_DNARROWD = 32742;
        public const int OBM_DNARROWI = 32736;
        public const int OBM_LFARROW = 32750;
        public const int OBM_LFARROWD = 32740;
        public const int OBM_LFARROWI = 32734;
        public const int OBM_MNARROW = 32739;
        public const int OBM_OLD_CLOSE = 32767;
        public const int OBM_OLD_DNARROW = 32764;
        public const int OBM_OLD_LFARROW = 32762;
        public const int OBM_OLD_REDUCE = 32757;
        public const int OBM_OLD_RESTORE = 32755;
        public const int OBM_OLD_RGARROW = 32763;
        public const int OBM_OLD_UPARROW = 32765;
        public const int OBM_OLD_ZOOM = 32756;
        public const int OBM_REDUCE = 32749;
        public const int OBM_REDUCED = 32746;
        public const int OBM_RESTORE = 32747;
        public const int OBM_RESTORED = 32744;
        public const int OBM_RGARROW = 32751;
        public const int OBM_RGARROWD = 32741;
        public const int OBM_RGARROWI = 32735;
        public const int OBM_SIZE = 32766;
        public const int OBM_UPARROW = 32753;
        public const int OBM_UPARROWD = 32743;
        public const int OBM_UPARROWI = 32737;
        public const int OBM_ZOOM = 32748;
        public const int OBM_ZOOMD = 32745;
        public const int OCR_CROSS = 32515;
        public const int OCR_IBEAM = 32513;
        public const int OCR_ICOCUR = 32647;
        public const int OCR_ICON = 32641;
        public const int OCR_NO = 32648;
        public const int OCR_NORMAL = 32512;
        public const int OCR_SIZE = 32640;
        public const int OCR_SIZEALL = 32646;
        public const int OCR_SIZENESW = 32643;
        public const int OCR_SIZENS = 32645;
        public const int OCR_SIZENWSE = 32642;
        public const int OCR_SIZEWE = 32644;
        public const int OCR_UP = 32516;
        public const int OCR_WAIT = 32514;
        public const int ODA_DRAWENTIRE = 0x1;
        public const int ODA_FOCUS = 0x4;
        public const int ODA_SELECT = 0x2;
        public const int ODS_CHECKED = 0x8;
        public const int ODS_DISABLED = 0x4;
        public const int ODS_FOCUS = 0x10;
        public const int ODS_GRAYED = 0x2;
        public const int ODS_SELECTED = 0x1;
        public const int ODT_BUTTON = 4;
        public const int ODT_COMBOBOX = 3;
        public const int ODT_LISTBOX = 2;
        public const int ODT_MENU = 1;
        public const int OIC_BANG = 32515;
        public const int OIC_HAND = 32513;
        public const int OIC_NOTE = 32516;
        public const int OIC_QUES = 32514;
        public const int OIC_SAMPLE = 32512;
        public const int ORD_LANGDRIVER = 1;
        public const int PAGE_EXECUTE = 0x10;
        public const int PAGE_EXECUTE_READ = 0x20;
        public const int PAGE_EXECUTE_READWRITE = 0x40;
        public const int PAGE_EXECUTE_WRITECOPY = 0x80;
        public const int PAGE_GUARD = 0x100;
        public const int PAGE_NOACCESS = 0x1;
        public const int PAGE_NOCACHE = 0x200;
        public const int PAGE_READONLY = 0x2;
        public const int PAGE_READWRITE = 0x4;
        public const int PAGE_WRITECOPY = 0x8;
        public const int PM_NOREMOVE = 0x0;
        public const int PM_NOYIELD = 0x2;
        public const int PM_REMOVE = 0x1;
        public const int PWR_CRITICALRESUME = 3;
        public const int PWR_FAIL = (-1);
        public const int PWR_OK = 1;
        public const int PWR_SUSPENDREQUEST = 1;
        public const int PWR_SUSPENDRESUME = 2;
        public const int QID_SYNC = 0xFFFF;
        public const int QS_ALLEVENTS = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY);

        public const int QS_ALLINPUT =
            (QS_SENDMESSAGE | QS_PAINT | QS_TIMER | QS_POSTMESSAGE | QS_MOUSEBUTTON | QS_MOUSEMOVE | QS_HOTKEY | QS_KEY);

        public const int QS_HOTKEY = 0x80;
        public const int QS_INPUT = (QS_MOUSE | QS_KEY);
        public const int QS_KEY = 0x1;
        public const int QS_MOUSE = (QS_MOUSEMOVE | QS_MOUSEBUTTON);
        public const int QS_MOUSEBUTTON = 0x4;
        public const int QS_MOUSEMOVE = 0x2;
        public const int QS_PAINT = 0x20;
        public const int QS_POSTMESSAGE = 0x8;
        public const int QS_SENDMESSAGE = 0x40;
        public const int QS_TIMER = 0x10;
        public const int RDW_ALLCHILDREN = 0x80;
        public const int RDW_ERASE = 0x4;
        public const int RDW_ERASENOW = 0x200;
        public const int RDW_FRAME = 0x400;
        public const int RDW_INTERNALPAINT = 0x2;
        public const int RDW_INVALIDATE = 0x1;
        public const int RDW_NOCHILDREN = 0x40;
        public const int RDW_NOERASE = 0x20;
        public const int RDW_NOFRAME = 0x800;
        public const int RDW_NOINTERNALPAINT = 0x10;
        public const int RDW_UPDATENOW = 0x100;
        public const int RDW_VALIDATE = 0x8;
        public const int READ = 0;
        public const int READ_WRITE = 2;
        public const int SBM_ENABLE_ARROWS = 0xE4;
        public const int SBM_GETPOS = 0xE1;
        public const int SBM_GETRANGE = 0xE3;
        public const int SBM_SETPOS = 0xE0;
        public const int SBM_SETRANGE = 0xE2;
        public const int SBM_SETRANGEREDRAW = 0xE6;
        public const int SBS_BOTTOMALIGN = 0x4;
        public const int SBS_HORZ = 0x0;
        public const int SBS_LEFTALIGN = 0x2;
        public const int SBS_RIGHTALIGN = 0x4;
        public const int SBS_SIZEBOX = 0x8;
        public const int SBS_SIZEBOXBOTTOMRIGHTALIGN = 0x4;
        public const int SBS_SIZEBOXTOPLEFTALIGN = 0x2;
        public const int SBS_TOPALIGN = 0x2;
        public const int SBS_VERT = 0x1;
        public const int SB_BOTH = 3;
        public const int SB_BOTTOM = 7;
        public const int SB_CTL = 2;
        public const int SB_ENDSCROLL = 8;
        public const int SB_HORZ = 0;
        public const int SB_LEFT = 6;
        public const int SB_LINEDOWN = 1;
        public const int SB_LINELEFT = 0;
        public const int SB_LINERIGHT = 1;
        public const int SB_LINEUP = 0;
        public const int SB_PAGEDOWN = 3;
        public const int SB_PAGELEFT = 2;
        public const int SB_PAGERIGHT = 3;
        public const int SB_PAGEUP = 2;
        public const int SB_RIGHT = 7;
        public const int SB_THUMBPOSITION = 4;
        public const int SB_THUMBTRACK = 5;
        public const int SB_TOP = 6;
        public const int SB_VERT = 1;
        public const int SC_ARRANGE = 0xF110;
        public const int SC_CLOSE = 0xF060;
        public const int SC_HOTKEY = 0xF150;
        public const int SC_HSCROLL = 0xF080;
        public const int SC_ICON = SC_MINIMIZE;
        public const int SC_KEYMENU = 0xF100;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MOUSEMENU = 0xF090;
        public const int SC_MOVE = 0xF010;
        public const int SC_NEXTWINDOW = 0xF040;
        public const int SC_PREVWINDOW = 0xF050;
        public const int SC_RESTORE = 0xF120;
        public const int SC_SCREENSAVE = 0xF140;
        public const int SC_SIZE = 0xF000;
        public const int SC_TASKLIST = 0xF130;
        public const int SC_VSCROLL = 0xF070;
        public const int SC_ZOOM = SC_MAXIMIZE;
        public const int SHOW_FULLSCREEN = 3;
        public const int SHOW_ICONWINDOW = 2;
        public const int SHOW_OPENNOACTIVATE = 4;
        public const int SHOW_OPENWINDOW = 1;
        public const int SIZEFULLSCREEN = SIZE_MAXIMIZED;
        public const int SIZEICONIC = SIZE_MINIMIZED;
        public const int SIZENORMAL = SIZE_RESTORED;
        public const int SIZEZOOMHIDE = SIZE_MAXHIDE;
        public const int SIZEZOOMSHOW = SIZE_MAXSHOW;
        public const int SIZE_MAXHIDE = 4;
        public const int SIZE_MAXIMIZED = 2;
        public const int SIZE_MAXSHOW = 3;
        public const int SIZE_MINIMIZED = 1;
        public const int SIZE_RESTORED = 0;
        public const int SMTO_ABORTIFHUNG = 0x2;
        public const int SMTO_BLOCK = 0x1;
        public const int SMTO_NORMAL = 0x0;
        public const int SM_CMETRICS = 44;
        public const int SM_CMOUSEBUTTONS = 43;
        public const int SM_CXBORDER = 5;
        public const int SM_CXCURSOR = 13;
        public const int SM_CXDLGFRAME = 7;
        public const int SM_CXDOUBLECLK = 36;
        public const int SM_CXFIXEDFRAME = SM_CXDLGFRAME;
        public const int SM_CXFRAME = 32;
        public const int SM_CXFULLSCREEN = 16;
        public const int SM_CXHSCROLL = 21;
        public const int SM_CXHTHUMB = 10;
        public const int SM_CXICON = 11;
        public const int SM_CXICONSPACING = 38;
        public const int SM_CXMIN = 28;
        public const int SM_CXMINTRACK = 34;
        public const int SM_CXSCREEN = 0;
        public const int SM_CXSIZE = 30;
        public const int SM_CXSIZEFRAME = SM_CXFRAME;
        public const int SM_CXVSCROLL = 2;
        public const int SM_CYBORDER = 6;
        public const int SM_CYCAPTION = 4;
        public const int SM_CYCURSOR = 14;
        public const int SM_CYDLGFRAME = 8;
        public const int SM_CYDOUBLECLK = 37;
        public const int SM_CYFIXEDFRAME = SM_CYDLGFRAME;
        public const int SM_CYFRAME = 33;
        public const int SM_CYFULLSCREEN = 17;
        public const int SM_CYHSCROLL = 3;
        public const int SM_CYICON = 12;
        public const int SM_CYICONSPACING = 39;
        public const int SM_CYKANJIWINDOW = 18;
        public const int SM_CYMENU = 15;
        public const int SM_CYMIN = 29;
        public const int SM_CYMINTRACK = 35;
        public const int SM_CYSCREEN = 1;
        public const int SM_CYSIZE = 31;
        public const int SM_CYSIZEFRAME = SM_CYFRAME;
        public const int SM_CYVSCROLL = 20;
        public const int SM_CYVTHUMB = 9;
        public const int SM_DBCSENABLED = 42;
        public const int SM_DEBUG = 22;
        public const int SM_MENUDROPALIGNMENT = 40;
        public const int SM_MOUSEPRESENT = 19;
        public const int SM_PENWINDOWS = 41;
        public const int SM_RESERVED1 = 24;
        public const int SM_RESERVED2 = 25;
        public const int SM_RESERVED3 = 26;
        public const int SM_RESERVED4 = 27;
        public const int SM_SWAPBUTTON = 23;
        public const int SPIF_SENDWININICHANGE = 0x2;
        public const int SPIF_UPDATEINIFILE = 0x1;
        public const int SPI_GETACCESSTIMEOUT = 60;
        public const int SPI_GETANIMATION = 72;
        public const int SPI_GETBEEP = 1;
        public const int SPI_GETBORDER = 5;
        public const int SPI_GETDEFAULTINPUTLANG = 89;
        public const int SPI_GETDRAGFULLWINDOWS = 38;
        public const int SPI_GETFASTTASKSWITCH = 35;
        public const int SPI_GETFILTERKEYS = 50;
        public const int SPI_GETFONTSMOOTHING = 74;
        public const int SPI_GETGRIDGRANULARITY = 18;
        public const int SPI_GETHIGHCONTRAST = 66;
        public const int SPI_GETICONMETRICS = 45;
        public const int SPI_GETICONTITLELOGFONT = 31;
        public const int SPI_GETICONTITLEWRAP = 25;
        public const int SPI_GETKEYBOARDDELAY = 22;
        public const int SPI_GETKEYBOARDPREF = 68;
        public const int SPI_GETKEYBOARDSPEED = 10;
        public const int SPI_GETLOWPOWERACTIVE = 83;
        public const int SPI_GETLOWPOWERTIMEOUT = 79;
        public const int SPI_GETMENUDROPALIGNMENT = 27;
        public const int SPI_GETMINIMIZEDMETRICS = 43;
        public const int SPI_GETMOUSE = 3;
        public const int SPI_GETMOUSEKEYS = 54;
        public const int SPI_GETMOUSETRAILS = 94;
        public const int SPI_GETNONCLIENTMETRICS = 41;
        public const int SPI_GETPOWEROFFACTIVE = 84;
        public const int SPI_GETPOWEROFFTIMEOUT = 80;
        public const int SPI_GETSCREENREADER = 70;
        public const int SPI_GETSCREENSAVEACTIVE = 16;
        public const int SPI_GETSCREENSAVETIMEOUT = 14;
        public const int SPI_GETSERIALKEYS = 62;
        public const int SPI_GETSHOWSOUNDS = 56;
        public const int SPI_GETSOUNDSENTRY = 64;
        public const int SPI_GETSTICKYKEYS = 58;
        public const int SPI_GETTOGGLEKEYS = 52;
        public const int SPI_GETWINDOWSEXTENSION = 92;
        public const int SPI_GETWORKAREA = 48;
        public const int SPI_ICONHORIZONTALSPACING = 13;
        public const int SPI_ICONVERTICALSPACING = 24;
        public const int SPI_LANGDRIVER = 12;
        public const int SPI_SCREENSAVERRUNNING = 97;
        public const int SPI_SETACCESSTIMEOUT = 61;
        public const int SPI_SETANIMATION = 73;
        public const int SPI_SETBEEP = 2;
        public const int SPI_SETBORDER = 6;
        public const int SPI_SETCURSORS = 87;
        public const int SPI_SETDEFAULTINPUTLANG = 90;
        public const int SPI_SETDESKPATTERN = 21;
        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPI_SETDOUBLECLICKTIME = 32;
        public const int SPI_SETDOUBLECLKHEIGHT = 30;
        public const int SPI_SETDOUBLECLKWIDTH = 29;
        public const int SPI_SETDRAGFULLWINDOWS = 37;
        public const int SPI_SETDRAGHEIGHT = 77;
        public const int SPI_SETDRAGWIDTH = 76;
        public const int SPI_SETFASTTASKSWITCH = 36;
        public const int SPI_SETFILTERKEYS = 51;
        public const int SPI_SETFONTSMOOTHING = 75;
        public const int SPI_SETGRIDGRANULARITY = 19;
        public const int SPI_SETHANDHELD = 78;
        public const int SPI_SETHIGHCONTRAST = 67;
        public const int SPI_SETICONMETRICS = 46;
        public const int SPI_SETICONS = 88;
        public const int SPI_SETICONTITLELOGFONT = 34;
        public const int SPI_SETICONTITLEWRAP = 26;
        public const int SPI_SETKEYBOARDDELAY = 23;
        public const int SPI_SETKEYBOARDPREF = 69;
        public const int SPI_SETKEYBOARDSPEED = 11;
        public const int SPI_SETLANGTOGGLE = 91;
        public const int SPI_SETLOWPOWERACTIVE = 85;
        public const int SPI_SETLOWPOWERTIMEOUT = 81;
        public const int SPI_SETMENUDROPALIGNMENT = 28;
        public const int SPI_SETMINIMIZEDMETRICS = 44;
        public const int SPI_SETMOUSE = 4;
        public const int SPI_SETMOUSEBUTTONSWAP = 33;
        public const int SPI_SETMOUSEKEYS = 55;
        public const int SPI_SETMOUSETRAILS = 93;
        public const int SPI_SETNONCLIENTMETRICS = 42;
        public const int SPI_SETPENWINDOWS = 49;
        public const int SPI_SETPOWEROFFACTIVE = 86;
        public const int SPI_SETPOWEROFFTIMEOUT = 82;
        public const int SPI_SETSCREENREADER = 71;
        public const int SPI_SETSCREENSAVEACTIVE = 17;
        public const int SPI_SETSCREENSAVETIMEOUT = 15;
        public const int SPI_SETSERIALKEYS = 63;
        public const int SPI_SETSHOWSOUNDS = 57;
        public const int SPI_SETSOUNDSENTRY = 65;
        public const int SPI_SETSTICKYKEYS = 59;
        public const int SPI_SETTOGGLEKEYS = 53;
        public const int SPI_SETWORKAREA = 47;
        public const int SS_BLACKFRAME = 0x7;
        public const int SS_BLACKRECT = 0x4;
        public const int SS_CENTER = 0x1;
        public const int SS_GRAYFRAME = 0x8;
        public const int SS_GRAYRECT = 0x5;
        public const int SS_ICON = 0x3;
        public const int SS_LEFT = 0x0;
        public const int SS_LEFTNOWORDWRAP = 0xC;
        public const int SS_NOPREFIX = 0x80;
        public const int SS_RIGHT = 0x2;
        public const int SS_SIMPLE = 0xB;
        public const int SS_USERITEM = 0xA;
        public const int SS_WHITEFRAME = 0x9;
        public const int SS_WHITERECT = 0x6;
        public const int STM_GETICON = 0x171;
        public const int STM_MSGMAX = 0x172;
        public const int STM_SETICON = 0x170;
        public const int ST_ADVISE = 0x2;
        public const int ST_BEGINSWP = 0;
        public const int ST_BLOCKED = 0x8;
        public const int ST_BLOCKNEXT = 0x80;
        public const int ST_CLIENT = 0x10;
        public const int ST_CONNECTED = 0x1;
        public const int ST_ENDSWP = 1;
        public const int ST_INLIST = 0x40;
        public const int ST_ISLOCAL = 0x4;
        public const int ST_ISSELF = 0x100;
        public const int ST_TERMINATED = 0x20;
        public const int SWP_DRAWFRAME = SWP_FRAMECHANGED;
        public const int SWP_FRAMECHANGED = 0x20;
        public const int SWP_HIDEWINDOW = 0x80;
        public const int SWP_NOACTIVATE = 0x10;
        public const int SWP_NOCOPYBITS = 0x100;
        public const int SWP_NOMOVE = 0x2;
        public const int SWP_NOOWNERZORDER = 0x200;
        public const int SWP_NOREDRAW = 0x8;
        public const int SWP_NOREPOSITION = SWP_NOOWNERZORDER;
        public const int SWP_NOSIZE = 0x1;
        public const int SWP_NOZORDER = 0x4;
        public const int SWP_SHOWWINDOW = 0x40;
        public const int SW_ERASE = 0x4;
        public const int SW_HIDE = 0;
        public const int SW_INVALIDATE = 0x2;
        public const int SW_MAX = 10;
        public const int SW_MAXIMIZE = 3;
        public const int SW_MINIMIZE = 6;
        public const int SW_NORMAL = 1;
        public const int SW_OTHERUNZOOM = 4;
        public const int SW_OTHERZOOM = 2;
        public const int SW_PARENTCLOSING = 1;
        public const int SW_PARENTOPENING = 3;
        public const int SW_RESTORE = 9;
        public const int SW_SCROLLCHILDREN = 0x1;
        public const int SW_SHOW = 5;
        public const int SW_SHOWDEFAULT = 10;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMINNOACTIVE = 7;
        public const int SW_SHOWNA = 8;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SHOWNORMAL = 1;
        public const int TIMEOUT_ASYNC = 0xFFFF;
        public const int TPM_CENTERALIGN = 0x4;
        public const int TPM_LEFTALIGN = 0x0;
        public const int TPM_LEFTBUTTON = 0x0;
        public const int TPM_RIGHTALIGN = 0x8;
        public const int TPM_RIGHTBUTTON = 0x2;
        public const int VK_ADD = 0x6B;
        public const int VK_ATTN = 0xF6;
        public const int VK_BACK = 0x8;
        public const int VK_CANCEL = 0x3;
        public const int VK_CAPITAL = 0x14;
        public const int VK_CLEAR = 0xC;
        public const int VK_CONTROL = 0x11;
        public const int VK_CRSEL = 0xF7;
        public const int VK_DECIMAL = 0x6E;
        public const int VK_DELETE = 0x2E;
        public const int VK_DIVIDE = 0x6F;
        public const int VK_DOWN = 0x28;
        public const int VK_END = 0x23;
        public const int VK_EREOF = 0xF9;
        public const int VK_ESCAPE = 0x1B;
        public const int VK_EXECUTE = 0x2B;
        public const int VK_EXSEL = 0xF8;
        public const int VK_F1 = 0x70;
        public const int VK_F10 = 0x79;
        public const int VK_F11 = 0x7A;
        public const int VK_F12 = 0x7B;
        public const int VK_F13 = 0x7C;
        public const int VK_F14 = 0x7D;
        public const int VK_F15 = 0x7E;
        public const int VK_F16 = 0x7F;
        public const int VK_F17 = 0x80;
        public const int VK_F18 = 0x81;
        public const int VK_F19 = 0x82;
        public const int VK_F2 = 0x71;
        public const int VK_F20 = 0x83;
        public const int VK_F21 = 0x84;
        public const int VK_F22 = 0x85;
        public const int VK_F23 = 0x86;
        public const int VK_F24 = 0x87;
        public const int VK_F3 = 0x72;
        public const int VK_F4 = 0x73;
        public const int VK_F5 = 0x74;
        public const int VK_F6 = 0x75;
        public const int VK_F7 = 0x76;
        public const int VK_F8 = 0x77;
        public const int VK_F9 = 0x78;
        public const int VK_HELP = 0x2F;
        public const int VK_HOME = 0x24;
        public const int VK_INSERT = 0x2D;
        public const int VK_LBUTTON = 0x1;
        public const int VK_LCONTROL = 0xA2;
        public const int VK_LEFT = 0x25;
        public const int VK_LMENU = 0xA4;
        public const int VK_LSHIFT = 0xA0;
        public const int VK_MBUTTON = 0x4;
        public const int VK_MENU = 0x12;
        public const int VK_MULTIPLY = 0x6A;
        public const int VK_NEXT = 0x22;
        public const int VK_NONAME = 0xFC;
        public const int VK_NUMLOCK = 0x90;
        public const int VK_NUMPAD0 = 0x60;
        public const int VK_NUMPAD1 = 0x61;
        public const int VK_NUMPAD2 = 0x62;
        public const int VK_NUMPAD3 = 0x63;
        public const int VK_NUMPAD4 = 0x64;
        public const int VK_NUMPAD5 = 0x65;
        public const int VK_NUMPAD6 = 0x66;
        public const int VK_NUMPAD7 = 0x67;
        public const int VK_NUMPAD8 = 0x68;
        public const int VK_NUMPAD9 = 0x69;
        public const int VK_OEM_CLEAR = 0xFE;
        public const int VK_PA1 = 0xFD;
        public const int VK_PAUSE = 0x13;
        public const int VK_PLAY = 0xFA;
        public const int VK_PRINT = 0x2A;
        public const int VK_PRIOR = 0x21;
        public const int VK_RBUTTON = 0x2;
        public const int VK_RCONTROL = 0xA3;
        public const int VK_RETURN = 0xD;
        public const int VK_RIGHT = 0x27;
        public const int VK_RMENU = 0xA5;
        public const int VK_RSHIFT = 0xA1;
        public const int VK_SCROLL = 0x91;
        public const int VK_SELECT = 0x29;
        public const int VK_SEPARATOR = 0x6C;
        public const int VK_SHIFT = 0x10;
        public const int VK_SNAPSHOT = 0x2C;
        public const int VK_SPACE = 0x20;
        public const int VK_SUBTRACT = 0x6D;
        public const int VK_TAB = 0x9;
        public const int VK_UP = 0x26;
        public const int VK_ZOOM = 0xFB;
        public const int WA_ACTIVE = 1;
        public const int WA_CLICKACTIVE = 2;
        public const int WA_INACTIVE = 0;
        public const int WB_ISDELIMITER = 2;
        public const int WB_LEFT = 0;
        public const int WB_RIGHT = 1;
        public const int WC_DIALOG = 8002;
        public const int WH_CALLWNDPROC = 4;
        public const int WH_CBT = 5;
        public const int WH_DEBUG = 9;
        public const int WH_FOREGROUNDIDLE = 11;
        public const int WH_GETMESSAGE = 3;
        public const int WH_HARDWARE = 8;
        public const int WH_JOURNALPLAYBACK = 1;
        public const int WH_JOURNALRECORD = 0;
        public const int WH_KEYBOARD = 2;
        public const int WH_MAX = 11;
        public const int WH_MIN = (-1);
        public const int WH_MOUSE = 7;
        public const int WH_MSGFILTER = (-1);
        public const int WH_SHELL = 10;
        public const int WH_SYSMSGFILTER = 6;
        public const int WINSTA_ACCESSCLIPBOARD = 0x4;
        public const int WINSTA_ACCESSPUBLICATOMS = 0x20;
        public const int WINSTA_CREATEDESKTOP = 0x8;
        public const int WINSTA_ENUMDESKTOPS = 0x1;
        public const int WINSTA_ENUMERATE = 0x100;
        public const int WINSTA_EXITWINDOWS = 0x40;
        public const int WINSTA_READATTRIBUTES = 0x2;
        public const int WINSTA_READSCREEN = 0x200;
        public const int WINSTA_WRITEATTRIBUTES = 0x10;
        public const int WM_ACTIVATE = 0x6;
        public const int WM_ACTIVATEAPP = 0x1C;
        public const int WM_ASKCBFORMATNAME = 0x30C;
        public const int WM_CANCELJOURNAL = 0x4B;
        public const int WM_CANCELMODE = 0x1F;
        public const int WM_CHANGECBCHAIN = 0x30D;
        public const int WM_CHAR = 0x102;
        public const int WM_CHARTOITEM = 0x2F;
        public const int WM_CHILDACTIVATE = 0x22;
        public const int WM_CLEAR = 0x303;
        public const int WM_CLOSE = 0x10;
        public const int WM_COMMAND = 0x111;
        public const int WM_COMMNOTIFY = 0x44;
        public const int WM_COMPACTING = 0x41;
        public const int WM_COMPAREITEM = 0x39;
        public const int WM_COPY = 0x301;
        public const int WM_COPYDATA = 0x4A;
        public const int WM_CREATE = 0x1;
        public const int WM_CTLCOLORBTN = 0x135;
        public const int WM_CTLCOLORDLG = 0x136;
        public const int WM_CTLCOLOREDIT = 0x133;
        public const int WM_CTLCOLORLISTBOX = 0x134;
        public const int WM_CTLCOLORMSGBOX = 0x132;
        public const int WM_CTLCOLORSCROLLBAR = 0x137;
        public const int WM_CTLCOLORSTATIC = 0x138;
        public const int WM_CUT = 0x300;
        public const int WM_DDE_ACK = (WM_DDE_FIRST + 4);
        public const int WM_DDE_ADVISE = (WM_DDE_FIRST + 2);
        public const int WM_DDE_DATA = (WM_DDE_FIRST + 5);
        public const int WM_DDE_EXECUTE = (WM_DDE_FIRST + 8);
        public const int WM_DDE_FIRST = 0x3E0;
        public const int WM_DDE_INITIATE = (WM_DDE_FIRST);
        public const int WM_DDE_LAST = (WM_DDE_FIRST + 8);
        public const int WM_DDE_POKE = (WM_DDE_FIRST + 7);
        public const int WM_DDE_REQUEST = (WM_DDE_FIRST + 6);
        public const int WM_DDE_TERMINATE = (WM_DDE_FIRST + 1);
        public const int WM_DDE_UNADVISE = (WM_DDE_FIRST + 3);
        public const int WM_DEADCHAR = 0x103;
        public const int WM_DELETEITEM = 0x2D;
        public const int WM_DESTROY = 0x2;
        public const int WM_DESTROYCLIPBOARD = 0x307;
        public const int WM_DEVMODECHANGE = 0x1B;
        public const int WM_DRAWCLIPBOARD = 0x308;
        public const int WM_DRAWITEM = 0x2B;
        public const int WM_DROPFILES = 0x233;
        public const int WM_ENABLE = 0xA;
        public const int WM_ENDSESSION = 0x16;
        public const int WM_ENTERIDLE = 0x121;
        public const int WM_ENTERMENULOOP = 0x211;
        public const int WM_ERASEBKGND = 0x14;
        public const int WM_EXITMENULOOP = 0x212;
        public const int WM_FONTCHANGE = 0x1D;
        public const int WM_GETDLGCODE = 0x87;
        public const int WM_GETFONT = 0x31;
        public const int WM_GETHOTKEY = 0x33;
        public const int WM_GETMINMAXINFO = 0x24;
        public const int WM_GETTEXT = 0xD;
        public const int WM_GETTEXTLENGTH = 0xE;
        public const int WM_HOTKEY = 0x312;
        public const int WM_HSCROLL = 0x114;
        public const int WM_HSCROLLCLIPBOARD = 0x30E;
        public const int WM_ICONERASEBKGND = 0x27;
        public const int WM_INITDIALOG = 0x110;
        public const int WM_INITMENU = 0x116;
        public const int WM_INITMENUPOPUP = 0x117;
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYFIRST = 0x100;
        public const int WM_KEYLAST = 0x108;
        public const int WM_KEYUP = 0x101;
        public const int WM_KILLFOCUS = 0x8;
        public const int WM_LBUTTONDBLCLK = 0x203;
        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_MBUTTONDBLCLK = 0x209;
        public const int WM_MBUTTONDOWN = 0x207;
        public const int WM_MBUTTONUP = 0x208;
        public const int WM_MDIACTIVATE = 0x222;
        public const int WM_MDICASCADE = 0x227;
        public const int WM_MDICREATE = 0x220;
        public const int WM_MDIDESTROY = 0x221;
        public const int WM_MDIGETACTIVE = 0x229;
        public const int WM_MDIICONARRANGE = 0x228;
        public const int WM_MDIMAXIMIZE = 0x225;
        public const int WM_MDINEXT = 0x224;
        public const int WM_MDIREFRESHMENU = 0x234;
        public const int WM_MDIRESTORE = 0x223;
        public const int WM_MDISETMENU = 0x230;
        public const int WM_MDITILE = 0x226;
        public const int WM_MEASUREITEM = 0x2C;
        public const int WM_MENUCHAR = 0x120;
        public const int WM_MENUSELECT = 0x11F;
        public const int WM_MOUSEACTIVATE = 0x21;
        public const int WM_MOUSEFIRST = 0x200;
        public const int WM_MOUSELAST = 0x209;
        public const int WM_MOUSEMOVE = 0x200;
        public const int WM_MOVE = 0x3;
        public const int WM_NCACTIVATE = 0x86;
        public const int WM_NCCALCSIZE = 0x83;
        public const int WM_NCCREATE = 0x81;
        public const int WM_NCDESTROY = 0x82;
        public const int WM_NCHITTEST = 0x84;
        public const int WM_NCLBUTTONDBLCLK = 0xA3;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int WM_NCLBUTTONUP = 0xA2;
        public const int WM_NCMBUTTONDBLCLK = 0xA9;
        public const int WM_NCMBUTTONDOWN = 0xA7;
        public const int WM_NCMBUTTONUP = 0xA8;
        public const int WM_NCMOUSEMOVE = 0xA0;
        public const int WM_NCPAINT = 0x85;
        public const int WM_NCRBUTTONDBLCLK = 0xA6;
        public const int WM_NCRBUTTONDOWN = 0xA4;
        public const int WM_NCRBUTTONUP = 0xA5;
        public const int WM_NEXTDLGCTL = 0x28;
        public const int WM_NULL = 0x0;
        public const int WM_OTHERWINDOWCREATED = 0x42;
        public const int WM_OTHERWINDOWDESTROYED = 0x43;
        public const int WM_PAINT = 0xF;
        public const int WM_PAINTCLIPBOARD = 0x309;
        public const int WM_PAINTICON = 0x26;
        public const int WM_PALETTECHANGED = 0x311;
        public const int WM_PALETTEISCHANGING = 0x310;
        public const int WM_PARENTNOTIFY = 0x210;
        public const int WM_PASTE = 0x302;
        public const int WM_PENWINFIRST = 0x380;
        public const int WM_PENWINLAST = 0x38F;
        public const int WM_POWER = 0x48;
        public const int WM_QUERYDRAGICON = 0x37;
        public const int WM_QUERYENDSESSION = 0x11;
        public const int WM_QUERYNEWPALETTE = 0x30F;
        public const int WM_QUERYOPEN = 0x13;
        public const int WM_QUEUESYNC = 0x23;
        public const int WM_QUIT = 0x12;
        public const int WM_RBUTTONDBLCLK = 0x206;
        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_RBUTTONUP = 0x205;
        public const int WM_RENDERALLFORMATS = 0x306;
        public const int WM_RENDERFORMAT = 0x305;
        public const int WM_SETCURSOR = 0x20;
        public const int WM_SETFOCUS = 0x7;
        public const int WM_SETFONT = 0x30;
        public const int WM_SETHOTKEY = 0x32;
        public const int WM_SETREDRAW = 0xB;
        public const int WM_SETTEXT = 0xC;
        public const int WM_SHOWWINDOW = 0x18;
        public const int WM_SIZE = 0x5;
        public const int WM_SIZECLIPBOARD = 0x30B;
        public const int WM_SPOOLERSTATUS = 0x2A;
        public const int WM_SYSCHAR = 0x106;
        public const int WM_SYSCOLORCHANGE = 0x15;
        public const int WM_SYSCOMMAND = 0x112;
        public const int WM_SYSDEADCHAR = 0x107;
        public const int WM_SYSKEYDOWN = 0x104;
        public const int WM_SYSKEYUP = 0x105;
        public const int WM_TIMECHANGE = 0x1E;
        public const int WM_TIMER = 0x113;
        public const int WM_UNDO = 0x304;
        public const int WM_USER = 0x400;
        public const int WM_VKEYTOITEM = 0x2E;
        public const int WM_VSCROLL = 0x115;
        public const int WM_VSCROLLCLIPBOARD = 0x30A;
        public const int WM_WINDOWPOSCHANGED = 0x47;
        public const int WM_WINDOWPOSCHANGING = 0x46;
        public const int WM_WININICHANGE = 0x1A;
        public const int WPF_RESTORETOMAXIMIZED = 0x2;
        public const int WPF_SETMINPOSITION = 0x1;
        public const int WRITE = 1;
        public const int WS_BORDER = 0x800000;
        public const int WS_CAPTION = 0xC00000;
        public const int WS_CHILD = 0x40000000;
        public const int WS_CHILDWINDOW = (WS_CHILD);
        public const int WS_CLIPCHILDREN = 0x2000000;
        public const int WS_CLIPSIBLINGS = 0x4000000;
        public const int WS_DISABLED = 0x8000000;
        public const int WS_DLGFRAME = 0x400000;
        /// <summary> Extended Window Styles </summary>
        /// <seealso cref="http://msdn.microsoft.com/en-us/library/windows/desktop/ff700543(v=vs.85).aspx"/>
        public const int WS_EX_ACCEPTFILES = 0x10;
        public const int WS_EX_LAYERED = 0x00080000;
        public const int WS_EX_DLGMODALFRAME = 0x1;
        public const int WS_EX_NOPARENTNOTIFY = 0x4;
        public const int WS_EX_TOPMOST = 0x8;
        public const int WS_EX_TRANSPARENT = 0x20;

        public const int WS_GROUP = 0x20000;
        public const int WS_HSCROLL = 0x100000;
        public const int WS_ICONIC = WS_MINIMIZE;
        public const int WS_MAXIMIZE = 0x1000000;
        public const int WS_MAXIMIZEBOX = 0x10000;
        public const int WS_MINIMIZE = 0x20000000;
        public const int WS_MINIMIZEBOX = 0x20000;
        public const int WS_OVERLAPPED = 0x0;

        public const int WS_OVERLAPPEDWINDOW =
            (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);

        public const int WS_POPUP = unchecked((int) 0x80000000);
        public const int WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU);
        public const int WS_SIZEBOX = WS_THICKFRAME;
        public const int WS_SYSMENU = 0x80000;
        public const int WS_TABSTOP = 0x10000;
        public const int WS_THICKFRAME = 0x40000;
        public const int WS_TILED = WS_OVERLAPPED;
        public const int WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;
        public const int WS_VISIBLE = 0x10000000;
        public const int WS_VSCROLL = 0x200000;
        public const int WVR_ALIGNBOTTOM = 0x40;
        public const int WVR_ALIGNLEFT = 0x20;
        public const int WVR_ALIGNRIGHT = 0x80;
        public const int WVR_ALIGNTOP = 0x10;
        public const int WVR_HREDRAW = 0x100;
        public const int WVR_REDRAW = (WVR_HREDRAW | WVR_VREDRAW);
        public const int WVR_VALIDRECTS = 0x400;
        public const int WVR_VREDRAW = 0x200;
        public const int XCLASS_BOOL = 0x1000;
        public const int XCLASS_DATA = 0x2000;
        public const int XCLASS_FLAGS = 0x4000;
        public const int XCLASS_MASK = 0xFC00;
        public const int XCLASS_NOTIFICATION = 0x8000;
        public const int XST_ADVACKRCVD = 13;
        public const int XST_ADVDATAACKRCVD = 16;
        public const int XST_ADVDATASENT = 15;
        public const int XST_ADVSENT = 11;
        public const int XST_CONNECTED = 2;
        public const int XST_DATARCVD = 6;
        public const int XST_EXECACKRCVD = 10;
        public const int XST_EXECSENT = 9;
        public const int XST_INCOMPLETE = 1;
        public const int XST_INIT1 = 3;
        public const int XST_INIT2 = 4;
        public const int XST_NULL = 0;
        public const int XST_POKEACKRCVD = 8;
        public const int XST_POKESENT = 7;
        public const int XST_REQSENT = 5;
        public const int XST_UNADVACKRCVD = 14;
        public const int XST_UNADVSENT = 12;
        public const int XTYPF_ACKREQ = 0x8;
        public const int XTYPF_NOBLOCK = 0x2;
        public const int XTYPF_NODATA = 0x4;
        public const int XTYP_ADVDATA = (0x10 | XCLASS_FLAGS);
        public const int XTYP_ADVREQ = (0x20 | XCLASS_DATA | XTYPF_NOBLOCK);
        public const int XTYP_ADVSTART = (0x30 | XCLASS_BOOL);
        public const int XTYP_ADVSTOP = (0x40 | XCLASS_NOTIFICATION);
        public const int XTYP_CONNECT = (0x60 | XCLASS_BOOL | XTYPF_NOBLOCK);
        public const int XTYP_CONNECT_CONFIRM = (0x70 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK);
        public const int XTYP_DISCONNECT = (0xC0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK);
        public const int XTYP_ERROR = (0x0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK);
        public const int XTYP_EXECUTE = (0x50 | XCLASS_FLAGS);
        public const int XTYP_MASK = 0xF0;
        public const int XTYP_MONITOR = (0xF0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK);
        public const int XTYP_POKE = (0x90 | XCLASS_FLAGS);
        public const int XTYP_REGISTER = (0xA0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK);
        public const int XTYP_REQUEST = (0xB0 | XCLASS_DATA);
        public const int XTYP_SHIFT = 4;
        public const int XTYP_UNREGISTER = (0xD0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK);
        public const int XTYP_WILDCONNECT = (0xE0 | XCLASS_DATA | XTYPF_NOBLOCK);
        public const int XTYP_XACT_COMPLETE = (0x80 | XCLASS_NOTIFICATION);
        public const string SZDDESYS_ITEM_FORMATS = "Formats";
        public const string SZDDESYS_ITEM_HELP = "Help";
        public const string SZDDESYS_ITEM_RTNMSG = "ReturnMessage";
        public const string SZDDESYS_ITEM_STATUS = "Status";
        public const string SZDDESYS_ITEM_SYSITEMS = "SysItems";
        public const string SZDDESYS_ITEM_TOPICS = "Topics";
        public const string SZDDESYS_TOPIC = "System";
        public const string SZDDE_ITEM_ITEMLIST = "TopicItemList";

        public IntPtr HWND_BOTTOM
        {
            get { return (IntPtr) 1; }
        }

        public IntPtr HWND_BROADCAST
        {
            get { return (IntPtr) 0xFFFF; }
        }

        public IntPtr HWND_DESKTOP
        {
            get { return (IntPtr) 0; }
        }

        public IntPtr HWND_TOP
        {
            get { return (IntPtr) 0; }
        }

        public IntPtr HWND_NOTOPMOST
        {
            get { return (IntPtr) (-2); }
        }

        public IntPtr HWND_TOPMOST
        {
            get { return (IntPtr) (-2); }
        }

        [DllImport("advapi32")]
        public static extern int SetServiceBits(IntPtr hServiceStatus, int dwServiceBits, int bSetBitsOn,
                                                int bUpdateImmediately);

        [DllImport("kernel32")]
        public static extern int SetSystemTimeAdjustment(int dwTimeAdjustment, int bTimeAdjustmentDisabled);

        [DllImport("mpr")]
        public static extern int WNetGetUniversalName(string lpLocalPath, int dwInfoLevel, StringBuilder lpBuffer,
                                                      ref int lpBufferSize);

        [DllImport("user32")]
        public static extern int ActivateKeyboardLayout(IntPtr hKL, int flags);

        [DllImport("user32")]
        public static extern int AdjustWindowRect(ref RECT lpRect, int dwStyle, int bMenu);

        [DllImport("user32")]
        public static extern int AdjustWindowRectEx(ref RECT lpRect, int dsStyle, int bMenu, int dwEsStyle);

        [DllImport("user32")]
        public static extern int AnyPopup();

        [DllImport("user32")]
        public static extern int AppendMenu(IntPtr hMenu, int wFlags, int wIDNewItem, IntPtr lpNewItem);

        [DllImport("user32")]
        public static extern int ArrangeIconicWindows(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int AttachThreadInput(int idAttach, int idAttachTo, int fAttach);

        [DllImport("user32")]
        public static extern int BeginDeferWindowPos(int nNumWindows);

        [DllImport("user32")]
        public static extern int BeginPaint(IntPtr hwnd, ref PAINTSTRUCT lpPaint);

        [DllImport("user32")]
        public static extern int BringWindowToTop(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int BroadcastSystemMessage(int dw, ref int pdw, int un, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int CallMsgFilter(ref MSG lpMsg, int ncode);

        [DllImport("user32")]
        public static extern int CallNextHookEx(IntPtr hHook, int ncode, int wParam, IntPtr lParam);

        [DllImport("user32")]
        public static extern int CallWindowProc(int lpPrevWndFunc, IntPtr hwnd, int Msg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int ChangeClipboardChain(IntPtr hwnd, IntPtr hwndNext);

        [DllImport("user32")]
        public static extern int ChangeMenu(IntPtr hMenu, int cmd, string lpszNewItem, int cmdInsert, int flags);

        [DllImport("user32")]
        public static extern int CharLowerBuff(string lpsz, int cchLength);

        [DllImport("user32")]
        public static extern int CharToOem(string lpszSrc, string lpszDst);

        [DllImport("user32")]
        public static extern int CharToOemBuff(string lpszSrc, string lpszDst, int cchDstLength);

        [DllImport("user32")]
        public static extern int CharUpperBuff(string lpsz, int cchLength);

        [DllImport("user32")]
        public static extern int CheckDlgButton(IntPtr hDlg, int nIDButton, int wCheck);

        [DllImport("user32")]
        public static extern int CheckMenuItem(IntPtr hMenu, int wIDCheckItem, int wCheck);

        [DllImport("user32")]
        public static extern int CheckMenuRadioItem(IntPtr hMenu, int un1, int un2, int un3, int un4);

        [DllImport("user32")]
        public static extern int CheckRadioButton(IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

        [DllImport("user32")]
        public static extern int ChildWindowFromPoint(IntPtr hwnd, int xPoint, int yPoint);

        [DllImport("user32")]
        public static extern int ChildWindowFromPointEx(IntPtr hwnd, int xPoint, int yPoint, int un);

        [DllImport("user32")]
        public static extern int ClientToScreen(IntPtr hwnd, ref POINT lpPoint);

        [DllImport("user32")]
        public static extern int ClipCursor(ref RECT lpRect);

        [DllImport("user32")]
        public static extern int CloseClipboard();

        [DllImport("user32")]
        public static extern int CloseDesktop(IntPtr hDesktop);

        [DllImport("user32")]
        public static extern int CloseWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int CloseWindowStation(IntPtr hWinSta);

        [DllImport("user32")]
        public static extern int CopyAcceleratorTable(IntPtr hAccelSrc, ACCEL[] lpAccelDst, int cAccelEntries);

        [DllImport("user32")]
        public static extern int CopyCursor(IntPtr hcur);

        [DllImport("user32")]
        public static extern int CopyIcon(IntPtr hIcon);

        [DllImport("user32")]
        public static extern int CopyImage(IntPtr handle, int un1, int n1, int n2, int un2);

        [DllImport("user32")]
        public static extern int CopyRect(ref RECT lpDestRect, ref RECT lpSourceRect);

        [DllImport("user32")]
        public static extern int CountClipboardFormats();

        [DllImport("user32")]
        public static extern int CreateAcceleratorTable(ref ACCEL lpaccl, int cEntries);

        [DllImport("user32")]
        public static extern int CreateCaret(IntPtr hwnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32")]
        public static extern int CreateCursor(IntPtr hInstance, int nXhotspot, int nYhotspot, int nWidth, int nHeight,
                                              IntPtr lpANDbitPlane, IntPtr lpXORbitPlane);

        [DllImport("user32")]
        public static extern int CreateDesktop(string lpszDesktop, string lpszDevice, ref DEVMODE pDevmode, int dwFlags,
                                               int dwDesiredAccess, ref SECURITY_ATTRIBUTES lpsa);

        [DllImport("user32")]
        public static extern int CreateDialogIndirectParam(IntPtr hInstance, ref DLGTEMPLATE lpTemplate,
                                                           IntPtr hwndParent, ref int lpDialogFunc, int dwInitParam);

        [DllImport("user32")]
        public static extern int CreateDialogParam(IntPtr hInstance, string lpName, IntPtr hwndParent,
                                                   ref int lpDialogFunc, int lParamInit);

        [DllImport("user32")]
        public static extern int CreateIcon(IntPtr hInstance, int nWidth, int nHeight, Byte nPlanes, Byte nBitsPixel,
                                            Byte lpANDbits, Byte lpXORbits);

        [DllImport("user32")]
        public static extern int CreateIconFromResource(Byte presbits, int dwResSize, int fIcon, int dwVer);

        [DllImport("user32")]
        public static extern int CreateIconIndirect(ref ICONINFO piconinfo);

        [DllImport("user32")]
        public static extern int CreateMDIWindow(string lpClassName, string lpWindowName, int dwStyle, int x, int y,
                                                 int nWidth, int nHeight, IntPtr hwndParent, IntPtr hInstance,
                                                 int lParam);

        [DllImport("user32")]
        public static extern int CreateMenu();

        [DllImport("user32")]
        public static extern int CreatePopupMenu();

        [DllImport("user32")]
        public static extern int CreateWindowEx(int dwExStyle, string lpClassName, string lpWindowName, int dwStyle,
                                                int x, int y, int nWidth, int nHeight, IntPtr hwndParent, IntPtr hMenu,
                                                IntPtr hInstance, IntPtr lpParam);

        [DllImport("user32")]
        public static extern int DdeAbandonTransaction(int idInst, IntPtr hConv, int idTransaction);

        [DllImport("user32")]
        public static extern int DdeAccessData(IntPtr hData, ref int pcbDataSize);

        [DllImport("user32")]
        public static extern int DdeAddData(IntPtr hData, Byte pSrc, int cb, int cbOff);

        [DllImport("user32")]
        public static extern int DdeClientTransaction(Byte pData, int cbData, IntPtr hConv, IntPtr hszItem, int wFmt,
                                                      int wType, int dwTimeout, ref int pdwResult);

        [DllImport("user32")]
        public static extern int DdeCmpStringHandles(IntPtr hsz1, IntPtr hsz2);

        [DllImport("user32")]
        public static extern int DdeConnect(int idInst, IntPtr hszService, IntPtr hszTopic, ref CONVCONTEXT pCC);

        [DllImport("user32")]
        public static extern int DdeConnectList(int idInst, IntPtr hszService, IntPtr hszTopic, IntPtr hConvList,
                                                ref CONVCONTEXT pCC);

        [DllImport("user32")]
        public static extern int DdeCreateDataHandle(int idInst, Byte pSrc, int cb, int cbOff, IntPtr hszItem, int wFmt,
                                                     int afCmd);

        [DllImport("user32")]
        public static extern int DdeCreateStringHandle(int idInst, string psz, int iCodePage);

        [DllImport("user32")]
        public static extern int DdeDisconnect(IntPtr hConv);

        [DllImport("user32")]
        public static extern int DdeDisconnectList(IntPtr hConvList);

        [DllImport("user32")]
        public static extern int DdeEnableCallback(int idInst, IntPtr hConv, int wCmd);

        [DllImport("user32")]
        public static extern int DdeFreeDataHandle(IntPtr hData);

        [DllImport("user32")]
        public static extern int DdeFreeStringHandle(int idInst, IntPtr hsz);

        [DllImport("user32")]
        public static extern int DdeGetData(IntPtr hData, Byte pDst, int cbMax, int cbOff);

        [DllImport("user32")]
        public static extern int DdeGetLastError(int idInst);

        [DllImport("user32")]
        public static extern int DdeImpersonateClient(IntPtr hConv);

        [DllImport("user32")]
        public static extern int DdeKeepStringHandle(int idInst, IntPtr hsz);

        [DllImport("user32")]
        public static extern int DdeNameService(int idInst, IntPtr hsz1, IntPtr hsz2, int afCmd);

        [DllImport("user32")]
        public static extern int DdePostAdvise(int idInst, IntPtr hszTopic, IntPtr hszItem);

        [DllImport("user32")]
        public static extern int DdeQueryConvInfo(IntPtr hConv, int idTransaction, ref CONVINFO pConvInfo);

        [DllImport("user32")]
        public static extern int DdeQueryNextServer(IntPtr hConvList, IntPtr hConvPrev);

        [DllImport("user32")]
        public static extern int DdeQueryString(int idInst, IntPtr hsz, string psz, int cchMax, int iCodePage);

        [DllImport("user32")]
        public static extern int DdeReconnect(IntPtr hConv);

        [DllImport("user32")]
        public static extern int DdeSetQualityOfService(IntPtr hwndClient, ref SECURITY_QUALITY_OF_SERVICE pqosNew,
                                                        ref SECURITY_QUALITY_OF_SERVICE pqosPrev);

        [DllImport("user32")]
        public static extern int DdeSetUserHandle(IntPtr hConv, int id, IntPtr hUser);

        [DllImport("user32")]
        public static extern int DdeUnaccessData(IntPtr hData);

        [DllImport("user32")]
        public static extern int DdeUninitialize(int idInst);

        [DllImport("user32")]
        public static extern int DefDlgProc(IntPtr hDlg, int wMsg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int DefFrameProc(IntPtr hwnd, IntPtr hwndMDIClient, int wMsg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int DefMDIChildProc(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int DefWindowProc(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int DeferWindowPos(IntPtr hWinPosInfo, IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y,
                                                int cx, int cy, int wFlags);

        [DllImport("user32")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32")]
        public static extern int DestroyAcceleratorTable(IntPtr haccel);

        [DllImport("user32")]
        public static extern int DestroyCaret();

        [DllImport("user32")]
        public static extern int DestroyCursor(IntPtr hCursor);

        [DllImport("user32")]
        public static extern int DestroyIcon(IntPtr hIcon);

        [DllImport("user32")]
        public static extern int DestroyMenu(IntPtr hMenu);

        [DllImport("user32")]
        public static extern int DestroyWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int DialogBoxIndirectParam(IntPtr hInstance, DLGTEMPLATE hDialogTemplate, IntPtr hwndParent,
                                                        ref int lpDialogFunc, int dwInitParam);

        [DllImport("user32")]
        public static extern int DispatchMessage(ref MSG lpMsg);

        [DllImport("user32")]
        public static extern int DlgDirList(IntPtr hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath,
                                            int wFileType);

        [DllImport("user32")]
        public static extern int DlgDirListComboBox(IntPtr hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath,
                                                    int wFileType);

        [DllImport("user32")]
        public static extern int DlgDirSelectComboBoxEx(IntPtr hwndDlg, string lpszPath, int cbPath, int idComboBox);

        [DllImport("user32")]
        public static extern int DlgDirSelectEx(IntPtr hwndDlg, string lpszPath, int cbPath, int idListBox);

        [DllImport("user32")]
        public static extern int DragDetect(IntPtr hwnd, POINT pt);

        [DllImport("user32")]
        public static extern int DragObject(IntPtr hwnd1, IntPtr hwnd2, int un, int dw, IntPtr hCursor);

        [DllImport("user32")]
        public static extern int DrawAnimatedRects(IntPtr hwnd, int idAni, ref RECT lprcFrom, ref RECT lprcTo);

        [DllImport("user32")]
        public static extern int DrawCaption(IntPtr hwnd, IntPtr hdc, ref RECT pcRect, int un);

        [DllImport("user32")]
        public static extern int DrawEdge(IntPtr hdc, ref RECT qrc, int edge, int grfFlags);

        [DllImport("user32")]
        public static extern int DrawFocusRect(IntPtr hdc, ref RECT lpRect);

        [DllImport("user32")]
        public static extern int DrawFrameControl(IntPtr hdc, ref RECT lpRect, int un1, int un2);

        [DllImport("user32")]
        public static extern int DrawIcon(IntPtr hdc, int x, int y, IntPtr hIcon);

        [DllImport("user32")]
        public static extern int DrawIconEx(IntPtr hdc, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyWidth,
                                            int istepIfAniCur, IntPtr hbrFlickerFreeDraw, int diFlags);

        [DllImport("user32")]
        public static extern int DrawMenuBar(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int DrawState(IntPtr hdc, IntPtr hBrush, ref int lpDrawStateProc, int lParam, int wParam,
                                           int n1, int n2, int n3, int n4, int un);

        [DllImport("user32")]
        public static extern int DrawText(IntPtr hdc, string lpStr, int nCount, ref RECT lpRect, int wFormat);

        [DllImport("user32")]
        public static extern int DrawTextEx(IntPtr hdc, string lpsz, int n, ref RECT lpRect, int un,
                                            ref DRAWTEXTPARAMS lpDrawTextParams);

        [DllImport("user32")]
        public static extern int EmptyClipboard();

        [DllImport("user32")]
        public static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);

        [DllImport("user32")]
        public static extern int EnableScrollBar(IntPtr hwnd, int wSBflags, int wArrows);

        [DllImport("user32")]
        public static extern int EnableWindow(IntPtr hwnd, int fEnable);

        [DllImport("user32")]
        public static extern int EndDeferWindowPos(IntPtr hWinPosInfo);

        [DllImport("user32")]
        public static extern int EndDialog(IntPtr hDlg, int nResult);

        [DllImport("user32")]
        public static extern int EndPaint(IntPtr hwnd, ref PAINTSTRUCT lpPaint);

        [DllImport("user32")]
        public static extern int EnumChildWindows(IntPtr hwndParent, ref int lpEnumFunc, int lParam);

        [DllImport("user32")]
        public static extern int EnumClipboardFormats(int wFormat);

        [DllImport("user32")]
        public static extern int EnumDesktopWindows(IntPtr hDesktop, ref int lpfn, int lParam);

        [DllImport("user32")]
        public static extern int EnumDesktops(IntPtr hwinsta, ref int lpEnumFunc, int lParam);

        [DllImport("user32")]
        public static extern int EnumProps(IntPtr hwnd, ref int lpEnumFunc);

        [DllImport("user32")]
        public static extern int EnumPropsEx(IntPtr hwnd, ref int lpEnumFunc, int lParam);

        [DllImport("user32")]
        public static extern int EnumThreadWindows(int dwThreadId, ref int lpfn, int lParam);

        [DllImport("user32")]
        public static extern int EnumWindowStations(int lpEnumFunc, int lParam);

        [DllImport("user32")]
        public static extern int EnumWindows(int lpEnumFunc, int lParam);

        [DllImport("user32")]
        public static extern int EqualRect(ref RECT lpRect1, ref RECT lpRect2);

        [DllImport("user32")]
        public static extern int ExcludeUpdateRgn(IntPtr hdc, IntPtr hwnd);

        [DllImport("user32")]
        public static extern int ExitWindows(int dwReserved, int uReturnCode);

        [DllImport("user32")]
        public static extern int ExitWindowsEx(int uFlags, int dwReserved);

        [DllImport("user32")]
        public static extern int FillRect(IntPtr hdc, ref RECT lpRect, IntPtr hBrush);

        [DllImport("user32")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32")]
        public static extern int FindWindowEx(IntPtr hwnd1, IntPtr hwnd2, string lpsz1, string lpsz2);

        [DllImport("user32")]
        public static extern int FlashWindow(IntPtr hwnd, int bInvert);

        [DllImport("user32")]
        public static extern int FrameRect(IntPtr hdc, ref RECT lpRect, IntPtr hBrush);

        [DllImport("user32")]
        public static extern int FreeDDElParam(int msg, int lParam);

        [DllImport("user32")]
        public static extern int GetActiveWindow();

        [DllImport("user32")]
        public static extern int GetCapture();

        [DllImport("user32")]
        public static extern int GetCaretBlinkTime();

        [DllImport("user32")]
        public static extern int GetCaretPos(ref POINT lpPoint);

        [DllImport("user32")]
        public static extern int GetClassInfo(IntPtr hInstance, string lpClassName, out WNDCLASS lpWndClass);

        [DllImport("user32")]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        [DllImport("user32")]
        public static extern int GetClassName(IntPtr hwnd, string lpClassName, int nMaxCount);

        [DllImport("user32")]
        public static extern int GetClassWord(IntPtr hwnd, int nIndex);

        [DllImport("user32")]
        public static extern int GetClientRect(IntPtr hwnd, ref RECT lpRect);

        [DllImport("user32")]
        public static extern int GetClipCursor(out RECT lprc);

        [DllImport("user32")]
        public static extern int GetClipboardData(int wFormat);

        [DllImport("user32")]
        public static extern int GetClipboardFormatName(int wFormat, string lpString, int nMaxCount);

        [DllImport("user32")]
        public static extern int GetClipboardOwner();

        [DllImport("user32")]
        public static extern int GetClipboardViewer();

        [DllImport("user32")]
        public static extern int GetCursor();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32")]
        public static extern int GetDCEx(IntPtr hwnd, IntPtr hrgnclip, int fdwOptions);

        [DllImport("user32")]
        public static extern int GetDesktopWindow();

        [DllImport("user32")]
        public static extern int GetDialogBaseUnits();

        [DllImport("user32")]
        public static extern int GetDlgCtrlID(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32")]
        public static extern int GetDlgItemInt(IntPtr hDlg, int nIDDlgItem, ref int lpTranslated, int bSigned);

        [DllImport("user32")]
        public static extern int GetDlgItemText(IntPtr hDlg, int nIDDlgItem, StringBuilder lpString, int nMaxCount);

        [DllImport("user32")]
        public static extern int GetDoubleClickTime();

        [DllImport("user32")]
        public static extern int GetFocus();

        [DllImport("user32")]
        public static extern int GetForegroundWindow();

        [DllImport("user32")]
        public static extern int GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);

        [DllImport("user32")]
        public static extern int GetInputState();

        [DllImport("user32")]
        public static extern int GetKBCodePage();

        [DllImport("user32")]
        public static extern int GetKeyNameText(int lParam, StringBuilder lpBuffer, int nSize);

        [DllImport("user32")]
        public static extern int GetKeyboardLayout(int dwLayout);

        [DllImport("user32")]
        public static extern int GetKeyboardLayoutList(int nBuff, ref int lpList);

        [DllImport("user32")]
        public static extern int GetKeyboardLayoutName(string pwszKLID);

        [DllImport("user32")]
        public static extern int GetKeyboardState(Byte pbKeyState);

        [DllImport("user32")]
        public static extern int GetKeyboardType(int nTypeFlag);

        [DllImport("user32")]
        public static extern int GetLastActivePopup(IntPtr hwndOwnder);

        [DllImport("user32")]
        public static extern int GetMenu(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetMenuCheckMarkDimensions();

        [DllImport("user32")]
        public static extern int GetMenuContextHelpId(IntPtr hMenu);

        [DllImport("user32")]
        public static extern int GetMenuDefaultItem(IntPtr hMenu, int fByPos, int gmdiFlags);

        [DllImport("user32")]
        public static extern int GetMenuItemCount(IntPtr hMenu);

        [DllImport("user32")]
        public static extern int GetMenuItemID(IntPtr hMenu, int nPos);

        [DllImport("user32")]
        public static extern int GetMenuItemInfo(IntPtr hMenu, int un, int b, ref MENUITEMINFO lpMenuItemInfo);

        [DllImport("user32")]
        public static extern int GetMenuItemRect(IntPtr hwnd, IntPtr hMenu, int uItem, ref RECT lprcItem);

        [DllImport("user32")]
        public static extern int GetMenuState(IntPtr hMenu, int wID, int wFlags);

        [DllImport("user32")]
        public static extern int GetMenuString(IntPtr hMenu, int wIDItem, StringBuilder lpString, int nMaxCount,
                                               int wFlag);

        [DllImport("user32")]
        public static extern int GetMessage(ref MSG lpMsg, IntPtr hwnd, int wMsgFilterMin, int wMsgFilterMax);

        [DllImport("user32")]
        public static extern int GetMessageExtraInfo();

        [DllImport("user32")]
        public static extern int GetMessagePos();

        [DllImport("user32")]
        public static extern int GetMessageTime();

        [DllImport("user32")]
        public static extern int GetNextDlgGroupItem(IntPtr hDlg, IntPtr hCtl, int bPrevious);

        [DllImport("user32")]
        public static extern int GetNextDlgTabItem(IntPtr hDlg, IntPtr hCtl, int bPrevious);

        [DllImport("user32")]
        public static extern int GetNextWindow(IntPtr hwnd, int wFlag);

        [DllImport("user32")]
        public static extern int GetOpenClipboardWindow();

        [DllImport("user32")]
        public static extern int GetParent(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetPriorityClipboardFormat(int lpPriorityList, int nCount);

        [DllImport("user32")]
        public static extern int GetProcessWindowStation();

        [DllImport("user32")]
        public static extern int GetProp(IntPtr hwnd, string lpString);

        [DllImport("user32")]
        public static extern int GetQueueStatus(int fuFlags);

        [DllImport("user32")]
        public static extern int GetScrollInfo(IntPtr hwnd, int n, ref SCROLLINFO lpScrollInfo);

        [DllImport("user32")]
        public static extern int GetScrollPos(IntPtr hwnd, int nBar);

        [DllImport("user32")]
        public static extern int GetScrollRange(IntPtr hwnd, int nBar, ref int lpMinPos, ref int lpMaxPos);

        [DllImport("user32")]
        public static extern int GetSubMenu(IntPtr hMenu, int nPos);

        [DllImport("user32")]
        public static extern int GetSysColor(int nIndex);

        [DllImport("user32")]
        public static extern int GetSysColorBrush(int nIndex);

        [DllImport("user32")]
        public static extern int GetSystemMenu(IntPtr hwnd, int bRevert);

        [DllImport("user32")]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32")]
        public static extern int GetTabbedTextExtent(IntPtr hdc, string lpString, int nCount, int nTabPositions,
                                                     ref int lpnTabStopPositions);

        [DllImport("user32")]
        public static extern int GetThreadDesktop(int dwThread);

        [DllImport("user32")]
        public static extern int GetTopWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetUpdateRect(IntPtr hwnd, ref RECT lpRect, int bErase);

        [DllImport("user32")]
        public static extern int GetUpdateRgn(IntPtr hwnd, IntPtr hRgn, int fErase);

        [DllImport("user32")]
        public static extern int GetUserObjectInformation(IntPtr hObj, int nIndex, IntPtr pvInfo, int nLength,
                                                          ref int lpnLengthNeeded);

        [DllImport("user32")]
        public static extern int GetUserObjectSecurity(IntPtr hObj, ref int pSIRequested, ref SECURITY_DESCRIPTOR pSd,
                                                       int nLength, ref int lpnLengthNeeded);

        [DllImport("user32")]
        public static extern int GetWindow(IntPtr hwnd, int wCmd);

        [DllImport("user32")]
        public static extern int GetWindowContextHelpId(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetWindowDC(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32")]
        public static extern int GetWindowPlacement(IntPtr hwnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32")]
        public static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);

        [DllImport("user32")]
        public static extern int GetWindowRgn(IntPtr hwnd, IntPtr hRgn);

        [DllImport("user32")]
        public static extern int GetWindowText(IntPtr hwnd, StringBuilder lpString, int cch);

        [DllImport("user32")]
        public static extern int GetWindowTextLength(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessId);

        [DllImport("user32")]
        public static extern int GrayString(IntPtr hdc, IntPtr hBrush, ref int lpOutputFunc, ref int lpData, int nCount,
                                            int X, int Y, int nWidth, int nHeight);

        [DllImport("user32")]
        public static extern int HideCaret(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int HiliteMenuItem(IntPtr hwnd, IntPtr hMenu, int wIDHiliteItem, int wHilite);

        [DllImport("user32")]
        public static extern int ImpersonateDdeClientWindow(IntPtr hwndClient, IntPtr hwndServer);

        [DllImport("user32")]
        public static extern int InSendMessage();

        [DllImport("user32")]
        public static extern int InflateRect(ref RECT lpRect, int x, int y);

        [DllImport("user32")]
        public static extern int InsertMenu(IntPtr hMenu, int nPosition, int wFlags, int wIDNewItem, IntPtr lpNewItem);

        [DllImport("user32")]
        public static extern int InsertMenuItem(IntPtr hMenu, int un, bool b, ref MENUITEMINFO lpcMenuItemInfo);

        [DllImport("user32")]
        public static extern int IntersectRect(ref RECT lpDestRect, ref RECT lpSrc1Rect, ref RECT lpSrc2Rect);

        [DllImport("user32")]
        public static extern int InvalidateRect(IntPtr hwnd, ref RECT lpRect, int bErase);

        [DllImport("user32")]
        public static extern int InvalidateRgn(IntPtr hwnd, IntPtr hRgn, int bErase);

        [DllImport("user32")]
        public static extern int InvertRect(IntPtr hdc, ref RECT lpRect);

        [DllImport("user32")]
        public static extern int IsCharAlpha(Byte cChar);

        [DllImport("user32")]
        public static extern int IsCharAlphaNumeric(Byte cChar);

        [DllImport("user32")]
        public static extern int IsCharLower(Byte cChar);

        [DllImport("user32")]
        public static extern int IsCharUpper(Byte cChar);

        [DllImport("user32")]
        public static extern int IsChild(IntPtr hwndParent, IntPtr hwnd);

        [DllImport("user32")]
        public static extern int IsClipboardFormatAvailable(int wFormat);

        [DllImport("user32")]
        public static extern int IsDialogMessage(IntPtr hDlg, ref MSG lpMsg);

        [DllImport("user32")]
        public static extern int IsDlgButtonChecked(IntPtr hDlg, int nIDButton);

        [DllImport("user32")]
        public static extern int IsIconic(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int IsMenu(IntPtr hMenu);

        [DllImport("user32")]
        public static extern int IsRectEmpty(ref RECT lpRect);

        [DllImport("user32")]
        public static extern int IsWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int IsWindowEnabled(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int IsWindowUnicode(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int IsWindowVisible(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int IsZoomed(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int KillTimer(IntPtr hwnd, int nIDEvent);

        [DllImport("user32")]
        public static extern int LoadAccelerators(IntPtr hInstance, string lpTableName);

        [DllImport("user32")]
        public static extern int LoadBitmap(IntPtr hInstance, string lpBitmapName);

        [DllImport("user32")]
        public static extern int LoadCursor(IntPtr hInstance, string lpCursorName);

        [DllImport("user32")]
        public static extern int LoadCursorFromFile(string lpFileName);

        [DllImport("user32")]
        public static extern int LoadIcon(IntPtr hInstance, string lpIconName);

        [DllImport("user32")]
        public static extern int LoadImage(IntPtr hInst, string lpsz, int un1, int n1, int n2, int un2);

        [DllImport("user32")]
        public static extern int LoadKeyboardLayout(string pwszKLID, int flags);

        [DllImport("user32")]
        public static extern int LoadMenu(IntPtr hInstance, string lpString);

        [DllImport("user32")]
        public static extern int LoadMenuIndirect(int lpMenuTemplate);

        [DllImport("user32")]
        public static extern int LoadString(IntPtr hInstance, int wID, string lpBuffer, int nBufferMax);

        [DllImport("user32")]
        public static extern int LockWindowUpdate(IntPtr hwndLock);

        [DllImport("user32")]
        public static extern int LookupIconIdFromDirectory(Byte presbits, int fIcon);

        [DllImport("user32")]
        public static extern int LookupIconIdFromDirectoryEx(Byte presbits, int fIcon, int cxDesired, int cyDesired,
                                                             int Flags);

        [DllImport("user32")]
        public static extern int MapDialogRect(IntPtr hDlg, ref RECT lpRect);

        [DllImport("user32")]
        public static extern int MapVirtualKey(int wCode, int wMapType);

        [DllImport("user32")]
        public static extern int MapVirtualKeyEx(int uCode, int uMapType, int dwhkl);

        [DllImport("user32")]
        public static extern int MapWindowPoints(IntPtr hwndFrom, IntPtr hwndTo, POINT[] lppt, int cPoints);

        [DllImport("user32")]
        public static extern int MenuItemFromPoint(IntPtr hwnd, IntPtr hMenu, POINT ptScreen);

        [DllImport("user32")]
        public static extern int MessageBeep(int wType);

        [DllImport("user32")]
        public static extern int MessageBox(IntPtr hwnd, string lpText, string lpCaption, int wType);

        [DllImport("user32")]
        public static extern int MessageBoxEx(IntPtr hwnd, string lpText, string lpCaption, int uType, int wLanguageId);

        [DllImport("user32")]
        public static extern int MessageBoxIndirect(ref MSGBOXPARAMS lpMsgBoxParams);

        [DllImport("user32")]
        public static extern int ModifyMenu(IntPtr hMenu, int nPosition, int wFlags, int wIDNewItem, IntPtr lpString);

        [DllImport("user32")]
        public static extern int MoveWindow(IntPtr hwnd, int x, int y, int nWidth, int nHeight, int bRepaint);

        [DllImport("user32")]
        public static extern int MsgWaitForMultipleObjects(int nCount, ref int pHandles, int fWaitAll,
                                                           int dwMilliseconds, int dwWakeMask);

        [DllImport("user32")]
        public static extern int OemKeyScan(int wOemChar);

        [DllImport("user32")]
        public static extern int OemToChar(string lpszSrc, string lpszDst);

        [DllImport("user32")]
        public static extern int OemToCharBuff(string lpszSrc, string lpszDst, int cchDstLength);

        [DllImport("user32")]
        public static extern int OffsetRect(ref RECT lpRect, int x, int y);

        [DllImport("user32")]
        public static extern int OpenClipboard(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int OpenDesktop(string lpszDesktop, int dwFlags, int fInherit, int dwDesiredAccess);

        [DllImport("user32")]
        public static extern int OpenIcon(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int OpenInputDesktop(int dwFlags, int fInherit, int dwDesiredAccess);

        [DllImport("user32")]
        public static extern int OpenWindowStation(string lpszWinSta, int fInherit, int dwDesiredAccess);

        [DllImport("user32")]
        public static extern int PackDDElParam(int msg, int uiLo, int uiHi);

        [DllImport("user32")]
        public static extern int PaintDesktop(IntPtr hdc);

        [DllImport("user32")]
        public static extern int PeekMessage(ref MSG lpMsg, IntPtr hwnd, int wMsgFilterMin, int wMsgFilterMax,
                                             int wRemoveMsg);

        [DllImport("user32")]
        public static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int PostThreadMessage(int idThread, int msg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int PtInRect(ref RECT lpRect, int ptX, int ptY);

        [DllImport("user32")]
        public static extern int RedrawWindow(IntPtr hwnd, ref RECT lprcUpdate, IntPtr hrgnUpdate, int fuRedraw);

        [DllImport("user32")]
        public static extern int RegisterClass(ref WNDCLASS Class);

        [DllImport("user32")]
        public static extern int RegisterClipboardFormat(string lpString);

        /// <summary> The RegisterHotKey function defines a system-wide hot key </summary>
        /// <param name="hWnd">Handle to the window that will receive WM_HOTKEY messages  generated by the hot key.</param>
        /// <param name="id">Specifies the identifier of the hot key.</param>
        /// <param name="fsModifiers">Specifies keys that must be pressed in combination with the key  specified by the 'vk' parameter in order to generate the WM_HOTKEY message.</param>
        /// <param name="vk">Specifies the virtual-key code of the hot key</param>
        /// <returns><c>true</c> if the function succeeds, otherwise <c>false</c></returns>
        /// <seealso cref="http://msdn.microsoft.com/en-us/library/ms646309(VS.85).aspx"/>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string lpString);

        [DllImport("user32")]
        public static extern int ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32")]
        public static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32")]
        public static extern int RemoveProp(IntPtr hwnd, string lpString);

        [DllImport("user32")]
        public static extern int ReplyMessage(int lReply);

        [DllImport("user32")]
        public static extern int ReuseDDElParam(int lParam, int msgIn, int msgOut, int uiLo, int uiHi);

        [DllImport("user32")]
        public static extern int ScreenToClient(IntPtr hwnd, ref POINT lpPoint);

        [DllImport("user32")]
        public static extern int ScrollDC(IntPtr hdc, int dx, int dy, ref RECT lprcScroll, ref RECT lprcClip,
                                          IntPtr hrgnUpdate, ref RECT lprcUpdate);

        [DllImport("user32")]
        public static extern int ScrollWindow(IntPtr hwnd, int XAmount, int YAmount, ref RECT lpRect,
                                              ref RECT lpClipRect);

        [DllImport("user32")]
        public static extern int ScrollWindowEx(IntPtr hwnd, int dx, int dy, ref RECT lprcScroll, ref RECT lprcClip,
                                                IntPtr hrgnUpdate, ref RECT lprcUpdate, int fuScroll);

        [DllImport("user32")]
        public static extern int SendDlgItemMessage(IntPtr hDlg, int nIDDlgItem, int wMsg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);

        [DllImport("user32")]
        public static extern int SendMessageCallback(IntPtr hwnd, int msg, int wParam, int lParam,
                                                     ref int lpResultCallBack, int dwData);

        [DllImport("user32")]
        public static extern int SendMessageTimeout(IntPtr hwnd, int msg, int wParam, int lParam, int fuFlags,
                                                    int uTimeout, ref int lpdwResult);

        [DllImport("user32")]
        public static extern int SendNotifyMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern int SetActiveWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int SetCapture(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int SetCaretBlinkTime(int wMSeconds);

        [DllImport("user32")]
        public static extern int SetCaretPos(int x, int y);

        [DllImport("user32")]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);

        [DllImport("user32")]
        public static extern int SetClassWord(IntPtr hwnd, int nIndex, int wNewWord);

        [DllImport("user32")]
        public static extern int SetClipboardData(int wFormat, IntPtr hMem);

        [DllImport("user32")]
        public static extern int SetClipboardViewer(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int SetCursor(IntPtr hCursor);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32")]
        public static extern int SetDlgItemInt(IntPtr hDlg, int nIDDlgItem, int wValue, int bSigned);

        [DllImport("user32")]
        public static extern int SetDlgItemText(IntPtr hDlg, int nIDDlgItem, string lpString);

        [DllImport("user32")]
        public static extern int SetDoubleClickTime(int wCount);

        [DllImport("user32")]
        public static extern int SetFocus(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int SetKeyboardState(Byte lppbKeyState);

        [DllImport("user32")]
        public static extern int SetMenu(IntPtr hwnd, IntPtr hMenu);

        [DllImport("user32")]
        public static extern int SetMenuContextHelpId(IntPtr hMenu, int dw);

        [DllImport("user32")]
        public static extern int SetMenuDefaultItem(IntPtr hMenu, int uItem, int fByPos);

        [DllImport("user32")]
        public static extern int SetMenuItemBitmaps(IntPtr hMenu, int nPosition, int wFlags, IntPtr hBitmapUnchecked,
                                                    IntPtr hBitmapChecked);

        [DllImport("user32")]
        public static extern int SetMenuItemInfo(IntPtr hMenu, int un, bool b, ref MENUITEMINFO lpcMenuItemInfo);

        [DllImport("user32")]
        public static extern int SetMessageExtraInfo(int lParam);

        [DllImport("user32")]
        public static extern int SetMessageQueue(int cMessagesMax);

        [DllImport("user32")]
        public static extern int SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

        [DllImport("user32")]
        public static extern int SetProcessWindowStation(IntPtr hWinSta);

        [DllImport("user32")]
        public static extern int SetProp(IntPtr hwnd, string lpString, IntPtr hData);

        [DllImport("user32")]
        public static extern int SetRect(ref RECT lpRect, int X1, int Y1, int X2, int Y2);

        [DllImport("user32")]
        public static extern int SetRectEmpty(ref RECT lpRect);

        [DllImport("user32")]
        public static extern int SetScrollInfo(IntPtr hwnd, int n, ref SCROLLINFO lpcScrollInfo, bool redraw);

        [DllImport("user32")]
        public static extern int SetScrollPos(IntPtr hwnd, int nBar, int nPos, int bRedraw);

        [DllImport("user32")]
        public static extern int SetScrollRange(IntPtr hwnd, int nBar, int nMinPos, int nMaxPos, int bRedraw);

        [DllImport("user32")]
        public static extern int SetSysColors(int nChanges, ref int lpSysColor, ref int lpColorValues);

        [DllImport("user32")]
        public static extern int SetSystemCursor(IntPtr hcur, int id);

        [DllImport("user32")]
        public static extern int SetThreadDesktop(IntPtr hDesktop);

        [DllImport("user32")]
        public static extern int SetTimer(IntPtr hwnd, int nIDEvent, int uElapse, ref int lpTimerFunc);

        [DllImport("user32")]
        public static extern int SetUserObjectInformation(IntPtr hObj, int nIndex, IntPtr pvInfo, int nLength);

        [DllImport("user32")]
        public static extern int SetUserObjectSecurity(IntPtr hObj, ref int pSIRequested, ref SECURITY_DESCRIPTOR pSd);

        [DllImport("user32")]
        public static extern int SetWindowContextHelpId(IntPtr hwnd, int dw);

        [DllImport("user32")]
        public static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

        [DllImport("user32")]
        public static extern int SetWindowPlacement(IntPtr hwnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32")]
        public static extern int SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int cx, int cy,
                                              int wFlags);

        [DllImport("user32")]
        public static extern int SetWindowRgn(IntPtr hwnd, IntPtr hRgn, int bRedraw);

        [DllImport("user32")]
        public static extern int SetWindowText(IntPtr hwnd, string lpString);

        [DllImport("user32")]
        public static extern int SetWindowWord(IntPtr hwnd, int nIndex, int wNewWord);

        [DllImport("user32")]
        public static extern int SetWindowsHook(int nFilterType, ref int pfnFilterProc);

        [DllImport("user32")]
        public static extern int SetWindowsHookEx(int idHook, ref int lpfn, IntPtr hmod, int dwThreadId);

        [DllImport("user32")]
        public static extern int ShowCaret(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int ShowCursor(int bShow);

        [DllImport("user32")]
        public static extern int ShowOwnedPopups(IntPtr hwnd, int fShow);

        [DllImport("user32")]
        public static extern int ShowScrollBar(IntPtr hwnd, int wBar, int bShow);

        [DllImport("user32")]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32")]
        public static extern int ShowWindowAsync(IntPtr hwnd, int nCmdShow);

        [DllImport("user32")]
        public static extern int SubtractRect(ref RECT lprcDst, ref RECT lprcSrc1, ref RECT lprcSrc2);

        [DllImport("user32")]
        public static extern int SwapMouseButton(int bSwap);

        [DllImport("user32")]
        public static extern int SwitchDesktop(IntPtr hDesktop);

        [DllImport("user32")]
        public static extern int SystemParametersInfo(int uAction, int uParam, ref IntPtr lpvParam, int fuWinIni);

        [DllImport("user32")]
        public static extern int TabbedTextOut(IntPtr hdc, int x, int y, string lpString, int nCount, int nTabPositions,
                                               ref int lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32")]
        public static extern int ToAscii(int uVirtKey, int uScanCode, Byte lpbKeyState, ref int lpwTransKey, int fuState);

        [DllImport("user32")]
        public static extern int ToAsciiEx(int uVirtKey, int uScanCode, Byte lpKeyState, short lpChar, int uFlags,
                                           int dwhkl);

        [DllImport("user32")]
        public static extern int ToUnicode(int wVirtKey, int wScanCode, Byte lpKeyState, string pwszBuff, int cchBuff,
                                           int wFlags);

        [DllImport("user32")]
        public static extern int TrackPopupMenu(IntPtr hMenu, int wFlags, int x, int y, int nReserved, IntPtr hwnd,
                                                ref RECT lprc);

        [DllImport("user32")]
        public static extern int TrackPopupMenuEx(IntPtr hMenu, int un, int n1, int n2, IntPtr hwnd,
                                                  ref TPMPARAMS lpTPMParams);

        [DllImport("user32")]
        public static extern int TranslateAccelerator(IntPtr hwnd, IntPtr hAccTable, ref MSG lpMsg);

        [DllImport("user32")]
        public static extern int TranslateMDISysAccel(IntPtr hwndClient, ref MSG lpMsg);

        [DllImport("user32")]
        public static extern int TranslateMessage(ref MSG lpMsg);

        [DllImport("user32")]
        public static extern int UnhookWindowsHook(int nCode, ref int pfnFilterProc);

        [DllImport("user32")]
        public static extern int UnhookWindowsHookEx(IntPtr hHook);

        [DllImport("user32")]
        public static extern int UnionRect(ref RECT lpDestRect, ref RECT lpSrc1Rect, ref RECT lpSrc2Rect);

        [DllImport("user32")]
        public static extern int UnloadKeyboardLayout(IntPtr hKL);

        [DllImport("user32")]
        public static extern int UnpackDDElParam(int msg, int lParam, ref int puiLo, ref int puiHi);

        [DllImport("user32")]
        public static extern int UnregisterClass(string lpClassName, IntPtr hInstance);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32")]
        public static extern int UpdateWindow(IntPtr hwnd);

        [DllImport("user32")]
        public static extern int ValidateRect(IntPtr hwnd, ref RECT lpRect);

        [DllImport("user32")]
        public static extern int ValidateRgn(IntPtr hwnd, IntPtr hRgn);

        [DllImport("user32")]
        public static extern int WaitForInputIdle(IntPtr hProcess, int dwMilliseconds);

        [DllImport("user32")]
        public static extern int WaitMessage();

        [DllImport("user32")]
        public static extern int WinHelp(IntPtr hwnd, string lpHelpFile, int wCommand, int dwData);

        [DllImport("user32")]
        public static extern int WindowFromDC(IntPtr hdc);

        [DllImport("user32")]
        public static extern int WindowFromPoint(int xPoint, int yPoint);

        [DllImport("user32")]
        public static extern short CascadeWindows(IntPtr hwndParent, int wHow, ref RECT lpRect, int cKids,
                                                  ref int lpkids);

        [DllImport("user32")]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32")]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32")]
        public static extern short GetWindowWord(IntPtr hwnd, int nIndex);

        [DllImport("user32")]
        public static extern short RegisterClassEx(ref WNDCLASSEX pcWndClassEx);

        [DllImport("user32")]
        public static extern short TileWindows(IntPtr hwndParent, int wHow, ref RECT lpRect, int cKids, ref int lpKids);

        [DllImport("user32")]
        public static extern short VkKeyScan(Byte cChar);

        [DllImport("user32")]
        public static extern short VkKeyScanEx(Byte ch, int dwhkl);

        [DllImport("user32")]
        public static extern string CharLower(string lpsz);

        [DllImport("user32")]
        public static extern string CharNext(string lpsz);

        [DllImport("user32")]
        public static extern string CharPrev(string lpszStart, string lpszCurrent);

        [DllImport("user32")]
        public static extern string CharUpper(string lpsz);

        [DllImport("user32")]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32")]
        public static extern void keybd_event(Byte bVk, Byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        [DllImport("user32")]
        public static extern void SetDebugErrorLevel(int dwLevel);

        [DllImport("user32")]
        public static extern void SetLastErrorEx(int dwErrCode, int dwType);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst,
                                                      ref POINT pptDst, ref SIZE psize, IntPtr hdcSrc, ref POINT pptSrc,
                                                      uint crKey,
                                                      [In] ref BLENDFUNCTION pblend, uint dwFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;

            public BLENDFUNCTION(byte op, byte flags, byte alpha, byte format)
            {
                BlendOp = op;
                BlendFlags = flags;
                SourceConstantAlpha = alpha;
                AlphaFormat = format;
            }
        }
        public const int ULW_COLORKEY = 0x1;
        public const int ULW_ALPHA = 0x2;
        public const int ULW_OPAQUE = 0x4;
        public const byte AC_SRC_OVER = 0x0;
        public const byte AC_SRC_ALPHA = 0x1;
    }
}