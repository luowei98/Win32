#region File Descrption

// /////////////////////////////////////////////////////////////////////////////
// 
// Project: RobertLw.Win32
// File:    Kernel.cs
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
    public struct OVERLAPPED
    {
        public int Internal;
        public int InternalHigh;
        public int OffsetHigh;
        public IntPtr hEvent;
        public int offset;
    }

    public struct SECURITY_ATTRIBUTES
    {
        public int bInheritHandle;
        public int lpSecurityDescriptor;
        public int nLength;
    }

    public struct PROCESS_INFORMATION
    {
        public int dwProcessId;
        public int dwThreadId;
        public IntPtr hProcess;
        public IntPtr hThread;
    }

    public struct COMMPROP
    {
        public int dwCurrentRxQueue;
        public int dwCurrentTxQueue;
        public int dwMaxBaud;
        public int dwMaxRxQueue;
        public int dwMaxTxQueue;
        public int dwProvCapabilities;
        public int dwProvSpec1;
        public int dwProvSpec2;
        public int dwProvSubType;
        public int dwReserved1;
        public int dwServiceMask;
        public int dwSettableBaud;
        public int dwSettableParams;
        public short wPacketLength;
        public short wPacketVersion;
        public short wSettableData;
        public short wSettableStopParity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public short[] wcProvChar;
    }

    public struct COMSTAT
    {
        public int cbInQue;
        public int cbOutQue;
        public int fBitFields;
    }

    public struct DCB
    {
        public int BaudRate;
        public byte ByteSize;
        public int DCBlength;
        public byte EofChar;
        public byte ErrorChar;
        public byte EvtChar;
        public byte Parity;
        public byte StopBits;
        public byte XoffChar;
        public short XoffLim;
        public byte XonChar;
        public short XonLim;
        public int fBitFields;
        public short wReserved;
        public short wReserved1;
    }

    public struct COMMTIMEOUTS
    {
        public int ReadIntervalTimeout;
        public int ReadTotalTimeoutConstant;
        public int ReadTotalTimeoutMultiplier;
        public int WriteTotalTimeoutConstant;
        public int WriteTotalTimeoutMultiplier;
    }

    public struct SYSTEM_INFO
    {
        public int dwActiveProcessorMask;
        public int dwAllocationGranularity;
        public int dwNumberOrfProcessors;
        public int dwOemID;
        public int dwPageSize;
        public int dwProcessorType;
        public int dwReserved;
        public int lpMaximumApplicationAddress;
        public int lpMinimumApplicationAddress;
    }

    #region Global Memory Flags

    #endregion

    public struct MEMORYSTATUS
    {
        public int dwAvailPageFile;
        public int dwAvailPhys;
        public int dwAvailVirtual;
        public int dwLength;
        public int dwMemoryLoad;
        public int dwTotalPageFile;
        public int dwTotalPhys;
        public int dwTotalVirtual;
    }

    public struct GENERIC_MAPPING
    {
        public int GenericAll;
        public int GenericExecute;
        public int GenericRead;
        public int GenericWrite;
    }

    public struct LUID
    {
        public int HighPart;
        public int LowPart;
    }

    public struct LUID_AND_ATTRIBUTES
    {
        public int Attributes;
        public LUID pLuid;
    }

    public struct ACL
    {
        public short AceCount;
        public byte AclRevision;
        public short AclSize;
        public byte Sbz1;
        public short Sbz2;
    }

    public struct ACE_HEADER
    {
        public byte AceFlags;
        public int AceSize;
        public byte AceType;
    }

    public struct ACCESS_ALLOWED_ACE
    {
        public ACE_HEADER Header;
        public int Mask;
        public int SidStart;
    }

    public struct ACCESS_DENIED_ACE
    {
        public ACE_HEADER Header;
        public int Mask;
        public int SidStart;
    }

    public struct SYSTEM_AUDIT_ACE
    {
        public ACE_HEADER Header;
        public int Mask;
        public int SidStart;
    }

    public struct SYSTEM_ALARM_ACE
    {
        public ACE_HEADER Header;
        public int Mask;
        public int SidStart;
    }

    public struct ACL_REVISION_INFORMATION
    {
        public int AclRevision;
    }

    public struct ACL_SIZE_INFORMATION
    {
        public int AceCount;
        public int AclBytesFree;
        public int AclBytesInUse;
    }

    public struct SECURITY_DESCRIPTOR
    {
        public int Control;
        public ACL Dacl;
        public int Group;
        public int Owner;
        public byte Revision;
        public ACL Sacl;
        public byte Sbz1;
    }

    public struct PRIVILEGE_SET
    {
        public int Control;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public LUID_AND_ATTRIBUTES[] Privilege;
        public int PrivilegeCount;
    }

    public struct EXCEPTION_RECORD
    {
        public int ExceptionAddress;
        public int ExceptionCode;
        public int ExceptionFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)] public int[] ExceptionInformation;
        public int NumberParameters;
        public int pExceptionRecord;
    }

    public struct EXCEPTION_DEBUG_INFO
    {
        public int dwFirstChance;
        public EXCEPTION_RECORD pExceptionRecord;
    }

    public struct CREATE_THREAD_DEBUG_INFO
    {
        public IntPtr hThread;
        public int lpStartAddress;
        public int lpThreadLocalBase;
    }

    public struct CREATE_PROCESS_DEBUG_INFO
    {
        public int dwDebugInfoFileOffset;
        public short fUnicode;
        public IntPtr hFile;
        public IntPtr hProcess;
        public IntPtr hThread;
        public int lpBaseOfImage;
        public int lpImageName;
        public int lpStartAddress;
        public int lpThreadLocalBase;
        public int nDebugInfoSize;
    }

    public struct EXIT_THREAD_DEBUG_INFO
    {
        public int dwExitCode;
    }

    public struct EXIT_PROCESS_DEBUG_INFO
    {
        public int dwExitCode;
    }

    public struct LOAD_DLL_DEBUG_INFO
    {
        public int dwDebugInfoFileOffset;
        public short fUnicode;
        public IntPtr hFile;
        public int lpBaseOfDll;
        public int lpImageName;
        public int nDebugInfoSize;
    }

    public struct UNLOAD_DLL_DEBUG_INFO
    {
        public int lpBaseOfDll;
    }

    public struct OUTPUT_DEBUG_STRING_INFO
    {
        public short fUnicode;
        public string lpDebugStringData;
        public short nDebugStringLength;
    }

    public struct RIP_INFO
    {
        public int dwError;
        public int dwType;
    }

    public struct OFSTRUCT
    {
        public short Reserved1;
        public short Reserved2;
        public byte cBytes;
        public byte fFixedDisk;
        public short nErrCode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] public byte[] szPathName;
    }

    public struct CRITICAL_SECTION
    {
        public int LockCount;
        public int RecursionCount;
        public int Reserved;
        public int pDebugInfo;
        public int pLockSemaphore;
        public int pOwningThread;
    }

    public struct BY_HANDLE_FILE_INFORMATION
    {
        public int dwFileAttributes;
        public int dwVolumeSerialNumber;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public int nFileIndexHigh;
        public int nFileIndexLow;
        public int nFileSizeHigh;
        public int nFileSizeLow;
        public int nNumberOfLinks;
    }

    public struct MEMORY_BASIC_INFORMATION
    {
        public int AllocationBase;
        public int AllocationProtect;
        public int BaseAddress;
        public int Protect;
        public int RegionSize;
        public int State;
        public int lType;
    }

    public struct EVENTLOGRECORD
    {
        public int ClosingRecordNumber;
        public int DataLength;
        public int DataOffset;
        public short EventCategory;
        public int EventID;
        public short EventType;
        public int Length;
        public short NumStrings;
        public int RecordNumber;
        public int Reserved;
        public short ReservedFlags;
        public int StringOffset;
        public int TimeGenerated;
        public int TimeWritten;
        public int UserSidLength;
        public int UserSidOffset;
    }

    public struct TOKEN_GROUPS
    {
        public int GroupCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public SID_AND_ATTRIBUTES[] Groups;
    }

    public struct TOKEN_PRIVILEGES
    {
        public int PrivilegeCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public LUID_AND_ATTRIBUTES[] Privileges;
    }

    public struct CONTEXT
    {
        public int ContextFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] public int[] Fill;
        public double Fir;
        public double FltF0;
        public double FltF1;
        public double FltF10;
        public double FltF11;
        public double FltF12;
        public double FltF13;
        public double FltF14;
        public double FltF15;
        public double FltF16;
        public double FltF17;
        public double FltF18;
        public double FltF19;
        public double FltF2;
        public double FltF20;
        public double FltF21;
        public double FltF22;
        public double FltF23;
        public double FltF24;
        public double FltF25;
        public double FltF26;
        public double FltF27;
        public double FltF28;
        public double FltF29;
        public double FltF3;
        public double FltF30;
        public double FltF31;
        public double FltF4;
        public double FltF5;
        public double FltF6;
        public double FltF7;
        public double FltF8;
        public double FltF9;
        public double Fpcr;
        public double IntA0;
        public double IntA1;
        public double IntA2;
        public double IntA3;
        public double IntA4;
        public double IntA5;
        public double IntAt;
        public double IntFp;
        public double IntGp;
        public double IntRa;
        public double IntS0;
        public double IntS1;
        public double IntS2;
        public double IntS3;
        public double IntS4;
        public double IntS5;
        public double IntSp;
        public double IntT0;
        public double IntT1;
        public double IntT10;
        public double IntT11;
        public double IntT12;
        public double IntT2;
        public double IntT3;
        public double IntT4;
        public double IntT5;
        public double IntT6;
        public double IntT7;
        public double IntT8;
        public double IntT9;
        public double IntV0;
        public double IntZero;
        public int Psr;
        public double SoftFpcr;
    }

    public struct EXCEPTION_POINTERS
    {
        public CONTEXT ContextRecord;
        public EXCEPTION_RECORD pExceptionRecord;
    }

    public struct LDT_BYTES
    {
        public byte BaseHi;
        public byte BaseMid;
        public byte Flags1;
        public byte Flags2;
    }

    public struct LDT_ENTRY
    {
        public short BaseLow;
        public int HighWord;
        public short LimitLow;
    }

    public struct TIME_ZONE_INFORMATION
    {
        public int Bias;
        public int DaylightBias;
        public SYSTEMTIME DaylightDate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public short[] DaylightName;
        public int StandardBias;
        public SYSTEMTIME StandardDate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public short[] StandardName;
    }

    public struct WIN32_STREAM_ID
    {
        public byte cStreamName;
        public int dwStreamAttributes;
        public int dwStreamID;
        public int dwStreamNameSize;
        public int dwStreamSizeHigh;
        public int dwStreamSizeLow;
    }

    public struct STARTUPINFO
    {
        public int cb;
        public short cbReserved2;
        public int dwFillAttribute;
        public int dwFlags;
        public int dwX;
        public int dwXCountChars;
        public int dwXSize;
        public int dwY;
        public int dwYCountChars;
        public int dwYSize;
        public IntPtr hStdError;
        public IntPtr hStdInput;
        public IntPtr hStdOutput;
        public string lpDesktop;
        public string lpReserved;
        public int lpReserved2;
        public string lpTitle;
        public short wShowWindow;
    }

    public struct CPINFO
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Kernel.MAX_DEFAULTCHAR)] public byte[] DefaultChar;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Kernel.MAX_LEADBYTES)] public byte[] LeadByte;
        public int MaxCharSize;
    }

    public struct NUMBERFMT
    {
        public int Grouping;
        public int LeadingZero;
        public int NegativeOrder;
        public int NumDigits;
        public string lpDecimalSep;
        public string lpThousandSep;
    }

    public struct CURRENCYFMT
    {
        public int Grouping;
        public int LeadingZero;
        public int NegativeOrder;
        public int NumDigits;
        public int PositiveOrder;
        public string lpCurrencySymbol;
        public string lpDecimalSep;
        public string lpThousandSep;
    }

    public struct COORD
    {
        public short x;
        public short y;
    }

    public struct SMALL_RECT
    {
        public short Bottom;
        public short Left;
        public short Right;
        public short Top;
    }

    public struct KEY_EVENT_RECORD
    {
        public int bKeyDown;
        public int dwControlKeyState;
        public byte uChar;
        public short wRepeatCount;
        public short wVirtualKeyCode;
        public short wVirtualScanCode;
    }

    public struct MOUSE_EVENT_RECORD
    {
        public int dwButtonState;
        public int dwControlKeyState;
        public int dwEventFlags;
        public COORD dwMousePosition;
    }

    public struct WINDOW_BUFFER_SIZE_RECORD
    {
        public COORD dwSize;
    }

    public struct MENU_EVENT_RECORD
    {
        public int dwCommandId;
    }

    public struct FOCUS_EVENT_RECORD
    {
        public int bSetFocus;
    }

    public struct CHAR_INFO
    {
        public short Attributes;
        public short Char;
    }

    public struct CONSOLE_SCREEN_BUFFER_INFO
    {
        public COORD dwCursorPosition;
        public COORD dwMaximumWindowSize;
        public COORD dwSize;
        public SMALL_RECT srWindow;
        public short wAttributes;
    }

    public struct CONSOLE_CURSOR_INFO
    {
        public int bVisible;
        public int dwSize;
    }

    public struct SID_IDENTIFIER_AUTHORITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] public byte[] Value;
    }

    public struct SID_AND_ATTRIBUTES
    {
        public int Attributes;
        public int Sid;
    }

    public struct WIN32_FIND_DATA
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)] public string cAlternate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Kernel.MAX_PATH)] public string cFileName;
        public int dwFileAttributes;
        public int dwReserved0;
        public int dwReserved1;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public int nFileSizeHigh;
        public int nFileSizeLow;
    }

    public struct COMMCONFIG
    {
        public DCB dcbx;
        public int dwProviderOffset;
        public int dwProviderSize;
        public int dwProviderSubType;
        public int dwSize;
        public short wReserved;
        public short wVersion;
        public byte wcProviderData;
    }

    public struct SERVICE_STATUS
    {
        public int dwCheckPoint;
        public int dwControlsAccepted;
        public int dwCurrentState;
        public int dwServiceSpecificExitCode;
        public int dwServiceType;
        public int dwWaitHint;
        public int dwWin32ExitCode;
    }

    public struct ENUM_SERVICE_STATUS
    {
        public SERVICE_STATUS ServiceStatus;
        public string lpDisplayName;
        public string lpServiceName;
    }

    public struct QUERY_SERVICE_LOCK_STATUS
    {
        public int dwLockDuration;
        public int fIsLocked;
        public string lpLockOwner;
    }

    public struct QUERY_SERVICE_CONFIG
    {
        public int dwErrorControl;
        public int dwServiceType;
        public int dwStartType;
        public int dwTagId;
        public string lpBinaryPathName;
        public string lpDependencies;
        public string lpDisplayName;
        public string lpLoadOrderGroup;
        public string lpServiceStartName;
    }

    public struct SERVICE_TABLE_ENTRY
    {
        public string lpServiceName;
        public int lpServiceProc;
    }

    public struct LARGE_INTEGER
    {
        public int highpart;
        public int lowpart;
    }

    public struct PERF_DATA_BLOCK
    {
        public int DefaultObject;
        public int HeaderLength;
        public int LittleEndian;
        public int NumObjectTypes;
        public LARGE_INTEGER PerTime100nSec;
        public LARGE_INTEGER PerfFreq;
        public LARGE_INTEGER PerfTime;
        public int Revision;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)] public string Signature;
        public int SystemNameLength;
        public int SystemNameOffset;
        public SYSTEMTIME SystemTime;
        public int TotalByteLength;
        public int Version;
    }

    public struct PERF_OBJECT_TYPE
    {
        public int CodePage;
        public int DefaultCounter;
        public int DefinitionLength;
        public int DetailLevel;
        public int HeaderLength;
        public int NumCounters;
        public int NumInstances;
        public string ObjectHelpTitle;
        public int ObjectHelpTitleIndex;
        public string ObjectNameTitle;
        public int ObjectNameTitleIndex;
        public LARGE_INTEGER PerfFreq;
        public LARGE_INTEGER PerfTime;
        public int TotalByteLength;
    }

    public struct PERF_COUNTER_DEFINITION
    {
        public int ByteLength;
        public string CounterHelpTitle;
        public int CounterHelpTitleIndex;
        public string CounterNameTitle;
        public int CounterNameTitleIndex;
        public int CounterOffset;
        public int CounterSize;
        public int CounterType;
        public int DefaultScale;
        public int DetailLevel;
    }

    public struct PERF_INSTANCE_DEFINITION
    {
        public int ByteLength;
        public int NameLength;
        public int NameOffset;
        public int ParentObjectInstance;
        public int ParentObjectTitleIndex;
        public int UniqueID;
    }

    public struct PERF_COUNTER_BLOCK
    {
        public int ByteLength;
    }

    public struct OSVERSIONINFO
    {
        public int dwBuildNumber;
        public int dwMajorVersion;
        public int dwMinorVersion;
        public int dwOSVersionInfoSize;
        public int dwPlatformId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string szCSDVersion;
    }

    public struct SYSTEM_POWER_STATUS
    {
        public byte ACLineStatus;
        public byte BatteryFlag;
        public int BatteryFullLifeTime;
        public byte BatteryLifePercent;
        public int BatteryLifeTime;
        public byte Reserved1;
    }

    public abstract class AdvApi
    {
        [DllImport("AdvApi32")]
        public static extern int ImpersonateLoggedOnUser(IntPtr hToken);

        [DllImport("advapi32")]
        public static extern int IsTextUnicode(IntPtr lpBuffer, int cb, ref int lpi);

        [DllImport("advapi32")]
        public static extern int LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType,
                                           int dwLogonProvider, ref int phToken);

        [DllImport("advapi32")]
        public static extern int NotifyChangeEventLog(IntPtr hEventLog, IntPtr hEvent);

        [DllImport("advapi32")]
        public static extern int SetThreadToken(int Thread, int Token);

        [DllImport("advapi32")]
        public static extern Byte GetSidSubAuthorityCount(IntPtr pSid);

        [DllImport("advapi32")]
        public static extern SID_IDENTIFIER_AUTHORITY GetSidIdentifierAuthority(IntPtr pSid);

        [DllImport("advapi32")]
        public static extern int AbortSystemShutdown(string lpMachineName);

        [DllImport("advapi32")]
        public static extern int AccessCheck(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int ClientToken,
                                             int DesiredAccess, GENERIC_MAPPING GenericMapping,
                                             PRIVILEGE_SET PrivilegeSet, int PrivilegeSetLength, int GrantedAccess,
                                             int Status);

        [DllImport("advapi32")]
        public static extern int AccessCheckAndAuditAlarm(string SubsystemName, IntPtr HandleId, string ObjectTypeName,
                                                          string ObjectName, SECURITY_DESCRIPTOR SecurityDescriptor,
                                                          int DesiredAccess, GENERIC_MAPPING GenericMapping,
                                                          int ObjectCreation, int GrantedAccess, int AccessStatus,
                                                          ref int pfGenerateOnClose);

        [DllImport("advapi32")]
        public static extern int AddAccessAllowedAce(ref ACL pAcl, int dwAceRevision, int AccessMask, IntPtr pSid);

        [DllImport("advapi32")]
        public static extern int AddAccessDeniedAce(ref ACL pAcl, int dwAceRevision, int AccessMask, IntPtr pSid);

        [DllImport("advapi32")]
        public static extern int AddAce(ref ACL pAcl, int dwAceRevision, int dwStartingAceIndex, IntPtr pAceList,
                                        int nAceListLength);

        [DllImport("advapi32")]
        public static extern int AddAuditAccessAce(ref ACL pAcl, int dwAceRevision, int dwAccessMask, IntPtr pSid,
                                                   int bAuditSuccess, int bAuditFailure);

        [DllImport("advapi32")]
        public static extern int AdjustTokenGroups(int TokenHandle, int ResetToDefault, TOKEN_GROUPS NewState,
                                                   int BufferLength, TOKEN_GROUPS PreviousState, int ReturnLength);

        [DllImport("advapi32")]
        public static extern int AdjustTokenPrivileges(int TokenHandle, int DisableAllPrivileges,
                                                       TOKEN_PRIVILEGES NewState, int BufferLength,
                                                       TOKEN_PRIVILEGES PreviousState, int ReturnLength);

        [DllImport("advapi32")]
        public static extern int AllocateAndInitializeSid(ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority,
                                                          Byte nSubAuthorityCount, int nSubAuthority0,
                                                          int nSubAuthority1, int nSubAuthority2, int nSubAuthority3,
                                                          int nSubAuthority4, int nSubAuthority5, int nSubAuthority6,
                                                          int nSubAuthority7, ref int lpPSid);

        [DllImport("advapi32")]
        public static extern int AllocateLocallyUniqueId(LARGE_INTEGER Luid);

        [DllImport("advapi32")]
        public static extern int AreAllAccessesGranted(int GrantedAccess, int DesiredAccess);

        [DllImport("advapi32")]
        public static extern int AreAnyAccessesGranted(int GrantedAccess, int DesiredAccess);

        [DllImport("advapi32")]
        public static extern int BackupEventLog(IntPtr hEventLog, string lpBackupFileName);

        [DllImport("advapi32")]
        public static extern int ChangeServiceConfig(IntPtr hService, int dwServiceType, int dwStartType,
                                                     int dwErrorControl, string lpBinaryPathName,
                                                     string lpLoadOrderGroup, ref int lpdwTagId, string lpDependencies,
                                                     string lpServiceStartName, string lpPassword, string lpDisplayName);

        [DllImport("advapi32")]
        public static extern int ClearEventLog(IntPtr hEventLog, string lpBackupFileName);

        [DllImport("advapi32")]
        public static extern int CloseEventLog(IntPtr hEventLog);

        [DllImport("advapi32")]
        public static extern int CloseServiceHandle(IntPtr hSCObject);

        [DllImport("advapi32")]
        public static extern int ControlService(IntPtr hService, int dwControl, ref SERVICE_STATUS lpServiceStatus);

        [DllImport("advapi32")]
        public static extern int CopySid(int nDestinationSidLength, IntPtr pDestinationSid, IntPtr pSourceSid);

        [DllImport("advapi32")]
        public static extern int CreatePrivateObjectSecurity(ref SECURITY_DESCRIPTOR ParentDescriptor,
                                                             SECURITY_DESCRIPTOR CreatorDescriptor,
                                                             SECURITY_DESCRIPTOR NewDescriptor, int IsDirectoryObject,
                                                             int Token, GENERIC_MAPPING GenericMapping);

        [DllImport("advapi32")]
        public static extern int CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine,
                                                     ref SECURITY_ATTRIBUTES lpProcessAttributes,
                                                     ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles,
                                                     int dwCreationFlags, string lpEnvironment,
                                                     string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo,
                                                     ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport("advapi32")]
        public static extern int CreateService(IntPtr hSCManager, string lpServiceName, string lpDisplayName,
                                               int dwDesiredAccess, int dwServiceType, int dwStartType,
                                               int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup,
                                               ref int lpdwTagId, string lpDependencies, string lp, string lpPassword);

        [DllImport("advapi32")]
        public static extern int DeleteAce(ref ACL pAcl, int dwAceIndex);

        [DllImport("advapi32")]
        public static extern int DeleteService(IntPtr hService);

        [DllImport("advapi32")]
        public static extern int DeregisterEventSource(IntPtr hEventLog);

        [DllImport("advapi32")]
        public static extern int DestroyPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ObjectDescriptor);

        [DllImport("advapi32")]
        public static extern int DuplicateToken(int ExistingTokenHandle, short ImpersonationLevel,
                                                int DuplicateTokenHandle);

        [DllImport("advapi32")]
        public static extern int EnumDependentServices(IntPtr hService, int dwServiceState,
                                                       ref ENUM_SERVICE_STATUS lpServices, int cbBufSize,
                                                       ref int pcbBytesNeeded, ref int lpServicesReturned);

        [DllImport("advapi32")]
        public static extern int EnumServicesStatus(IntPtr hSCManager, int dwServiceType, int dwServiceState,
                                                    ref ENUM_SERVICE_STATUS lpServices, int cbBufSize,
                                                    ref int pcbBytesNeeded, ref int lpServicesReturned,
                                                    ref int lpResumeHandle);

        [DllImport("advapi32")]
        public static extern int EqualPrefixSid(IntPtr pSid1, IntPtr pSid2);

        [DllImport("advapi32")]
        public static extern int EqualSid(IntPtr pSid1, IntPtr pSid2);

        [DllImport("advapi32")]
        public static extern int FindFirstFreeAce(ref ACL pAcl, ref int pAce);

        [DllImport("advapi32")]
        public static extern int GetAce(ref ACL pAcl, int dwAceIndex, IntPtr pAce);

        [DllImport("advapi32")]
        public static extern int GetAclInformation(ref ACL pAcl, IntPtr pAclInformation, int nAclInformationLength,
                                                   short dwAclInformationClass);

        [DllImport("advapi32")]
        public static extern int GetFileSecurity(string lpFileName, int RequestedInformation,
                                                 ref SECURITY_DESCRIPTOR pSecurityDescriptor, int nLength,
                                                 ref int lpnLengthNeeded);

        [DllImport("advapi32")]
        public static extern int GetKernelObjectSecurity(IntPtr handle, int RequestedInformation,
                                                         ref SECURITY_DESCRIPTOR pSecurityDescriptor, int nLength,
                                                         ref int lpnLengthNeeded);

        [DllImport("advapi32")]
        public static extern int GetLengthSid(IntPtr pSid);

        [DllImport("advapi32")]
        public static extern int GetNumberOfEventLogRecords(IntPtr hEventLog, int NumberOfRecords);

        [DllImport("advapi32")]
        public static extern int GetOldestEventLogRecord(IntPtr hEventLog, int OldestRecord);

        [DllImport("advapi32")]
        public static extern int GetPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ObjectDescriptor,
                                                          int SecurityInformation,
                                                          SECURITY_DESCRIPTOR ResultantDescriptor, int DescriptorLength,
                                                          int ReturnLength);

        [DllImport("advapi32")]
        public static extern int GetSecurityDescriptorControl(ref SECURITY_DESCRIPTOR pSecurityDescriptor,
                                                              short pControl, ref int lpdwRevision);

        [DllImport("advapi32")]
        public static extern int GetSecurityDescriptorDacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor,
                                                           ref int lpbDaclPresent, ref ACL pDacl,
                                                           ref int lpbDaclDefaulted);

        [DllImport("advapi32")]
        public static extern int GetSecurityDescriptorGroup(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pGroup,
                                                            ref int lpbGroupDefaulted);

        [DllImport("advapi32")]
        public static extern int GetSecurityDescriptorLength(ref SECURITY_DESCRIPTOR pSecurityDescriptor);

        [DllImport("advapi32")]
        public static extern int GetSecurityDescriptorOwner(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pOwner,
                                                            ref int lpbOwnerDefaulted);

        [DllImport("advapi32")]
        public static extern int GetSecurityDescriptorSacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor,
                                                           ref int lpbSaclPresent, ref ACL pSacl,
                                                           ref int lpbSaclDefaulted);

        [DllImport("advapi32")]
        public static extern int GetServiceDisplayName(IntPtr hSCManager, string lpServiceName,
                                                       StringBuilder lpDisplayName, ref int cchBuffer);

        [DllImport("advapi32")]
        public static extern int GetServiceKeyName(IntPtr hSCManager, string lpDisplayName, StringBuilder lpServiceName,
                                                   ref int cchBuffer);

        [DllImport("advapi32")]
        public static extern int GetSidLengthRequired(Byte nSubAuthorityCount);

        [DllImport("advapi32")]
        public static extern int GetSidSubAuthority(IntPtr pSid, int nSubAuthority);

        [DllImport("advapi32")]
        public static extern int GetTokenInformation(int TokenHandle, short TokenInformationClass,
                                                     IntPtr TokenInformation, int TokenInformationLength,
                                                     int ReturnLength);

        [DllImport("advapi32")]
        public static extern int GetUserName(StringBuilder lpBuffer, int nSize);

        [DllImport("advapi32")]
        public static extern int ImpersonateNamedPipeClient(IntPtr hNamedPipe);

        [DllImport("advapi32")]
        public static extern int ImpersonateSelf(short ImpersonationLevel);

        [DllImport("advapi32")]
        public static extern int InitializeAcl(ref ACL pAcl, int nAclLength, int dwAclRevision);

        [DllImport("advapi32")]
        public static extern int InitializeSecurityDescriptor(ref SECURITY_DESCRIPTOR pSecurityDescriptor,
                                                              int dwRevision);

        [DllImport("advapi32")]
        public static extern int InitializeSid(IntPtr Sid, ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority,
                                               Byte nSubAuthorityCount);

        [DllImport("advapi32")]
        public static extern int InitiateSystemShutdown(string lpMachineName, string lpMessage, int dwTimeout,
                                                        int bForceAppsClosed, int bRebootAfterShutdown);

        [DllImport("advapi32")]
        public static extern int IsValidAcl(ref ACL pAcl);

        [DllImport("advapi32")]
        public static extern int IsValidSecurityDescriptor(ref SECURITY_DESCRIPTOR pSecurityDescriptor);

        [DllImport("advapi32")]
        public static extern int IsValidSid(IntPtr pSid);

        [DllImport("advapi32")]
        public static extern int LockServiceDatabase(IntPtr hSCManager);

        [DllImport("advapi32")]
        public static extern int LookupAccountName(string lpSystemName, string lpAccountName, int Sid, int cbSid,
                                                   string ReferencedDomainName, int cbReferencedDomainName, int peUse);

        [DllImport("advapi32")]
        public static extern int LookupAccountSid(string lpSystemName, IntPtr Sid, string name, int cbName,
                                                  string ReferencedDomainName, int cbReferencedDomainName, int peUse);

        [DllImport("advapi32")]
        public static extern int LookupPrivilegeDisplayName(string lpSystemName, string lpName, string lpDisplayName,
                                                            int cbDisplayName, ref int lpLanguageID);

        [DllImport("advapi32")]
        public static extern int LookupPrivilegeName(string lpSystemName, ref LARGE_INTEGER lpLuid, string lpName,
                                                     int cbName);

        [DllImport("advapi32")]
        public static extern int LookupPrivilegeValue(string lpSystemName, string lpName, ref LARGE_INTEGER lpLuid);

        [DllImport("advapi32")]
        public static extern int MakeAbsoluteSD(ref SECURITY_DESCRIPTOR pSelfRelativeSecurityDescriptor,
                                                ref SECURITY_DESCRIPTOR pAbsoluteSecurityDescriptor,
                                                ref int lpdwAbsoluteSecurityDescriptorSize, ref ACL pDacl,
                                                ref int lpdwDaclSize, ref ACL pSacl, ref int lpdwSaclSize, IntPtr pOwner,
                                                ref int lpdwOwnerSize, IntPtr pPrimaryGroup,
                                                ref int lpdwPrimaryGroupSize);

        [DllImport("advapi32")]
        public static extern int MakeSelfRelativeSD(ref SECURITY_DESCRIPTOR pAbsoluteSecurityDescriptor,
                                                    ref SECURITY_DESCRIPTOR pSelfRelativeSecurityDescriptor,
                                                    ref int lpdwBufferLength);

        [DllImport("advapi32")]
        public static extern int NotifyBootConfigStatus(int BootAcceptable);

        [DllImport("advapi32")]
        public static extern int ObjectCloseAuditAlarm(string SubsystemName, IntPtr HandleId, int GenerateOnClose);

        [DllImport("advapi32")]
        public static extern int ObjectPrivilegeAuditAlarm(string SubsystemName, IntPtr HandleId, int ClientToken,
                                                           int DesiredAccess, PRIVILEGE_SET Privileges,
                                                           int AccessGranted);

        [DllImport("advapi32")]
        public static extern int OpenBackupEventLog(string lpUNCServerName, string lpFileName);

        [DllImport("advapi32")]
        public static extern int OpenEventLog(string lpUNCServerName, string lpSourceName);

        [DllImport("advapi32")]
        public static extern int OpenSCManager(string lpMachineName, string lpDatabaseName, int dwDesiredAccess);

        [DllImport("advapi32")]
        public static extern int OpenService(IntPtr hSCManager, string lpServiceName, int dwDesiredAccess);

        [DllImport("advapi32")]
        public static extern int OpenThreadToken(int ThreadHandle, int DesiredAccess, int OpenAsSelf, int TokenHandle);

        [DllImport("advapi32")]
        public static extern int PrivilegeCheck(int ClientToken, PRIVILEGE_SET RequiredPrivileges, ref int pfResult);

        [DllImport("advapi32")]
        public static extern int PrivilegedServiceAuditAlarm(string SubsystemName, string ServiceName, int ClientToken,
                                                             PRIVILEGE_SET Privileges, int AccessGranted);

        [DllImport("advapi32")]
        public static extern int QueryServiceConfig(IntPtr hService, ref QUERY_SERVICE_CONFIG lpServiceConfig,
                                                    int cbBufSize, ref int pcbBytesNeeded);

        [DllImport("advapi32")]
        public static extern int QueryServiceLockStatus(IntPtr hSCManager, ref QUERY_SERVICE_LOCK_STATUS lpLockStatus,
                                                        int cbBufSize, ref int pcbBytesNeeded);

        [DllImport("advapi32")]
        public static extern int QueryServiceObjectSecurity(IntPtr hService, int dwSecurityInformation,
                                                            IntPtr lpSecurityDescriptor, int cbBufSize,
                                                            ref int pcbBytesNeeded);

        [DllImport("advapi32")]
        public static extern int QueryServiceStatus(IntPtr hService, ref SERVICE_STATUS lpServiceStatus);

        [DllImport("advapi32")]
        public static extern int ReadEventLog(IntPtr hEventLog, int dwReadFlags, int dwRecordOffset,
                                              ref EVENTLOGRECORD lpBuffer, int nNumberOfBytesToRead, ref int pnBytesRead,
                                              ref int pnMinNumberOfBytesNeeded);

        [DllImport("advapi32")]
        public static extern int RegCloseKey(IntPtr hKey);

        [DllImport("advapi32")]
        public static extern int RegConnectRegistry(string lpMachineName, IntPtr hKey, ref int phkResult);

        [DllImport("advapi32")]
        public static extern int RegCreateKey(IntPtr hKey, string lpSubKey, ref int phkResult);

        [DllImport("advapi32")]
        public static extern int RegCreateKeyEx(IntPtr hKey, string lpSubKey, int Reserved, string lpClass,
                                                int dwOptions, int samDesired,
                                                ref SECURITY_ATTRIBUTES lpSecurityAttributes, ref int phkResult,
                                                ref int lpdwDisposition);

        [DllImport("advapi32")]
        public static extern int RegDeleteKey(IntPtr hKey, string lpSubKey);

        [DllImport("advapi32")]
        public static extern int RegDeleteValue(IntPtr hKey, string lpValueName);

        [DllImport("advapi32")]
        public static extern int RegEnumKey(IntPtr hKey, int dwIndex, string lpName, int cbName);

        [DllImport("advapi32")]
        public static extern int RegEnumKeyEx(IntPtr hKey, int dwIndex, string lpName, ref int lpcbName,
                                              ref int lpReserved, string lpClass, ref int lpcbClass,
                                              ref FILETIME lpftLastWriteTime);

        [DllImport("advapi32")]
        public static extern int RegEnumValue(IntPtr hKey, int dwIndex, string lpValueName, ref int lpcbValueName,
                                              ref int lpReserved, ref int lpType, Byte lpData, ref int lpcbData);

        [DllImport("advapi32")]
        public static extern int RegFlushKey(IntPtr hKey);

        [DllImport("advapi32")]
        public static extern int RegGetKeySecurity(IntPtr hKey, int SecurityInformation,
                                                   ref SECURITY_DESCRIPTOR pSecurityDescriptor,
                                                   ref int lpcbSecurityDescriptor);

        [DllImport("advapi32")]
        public static extern int RegLoadKey(IntPtr hKey, string lpSubKey, string lpFile);

        [DllImport("advapi32")]
        public static extern int RegNotifyChangeKeyValue(IntPtr hKey, int bWatchSubtree, int dwNotifyFilter,
                                                         IntPtr hEvent, int fAsynchronus);

        [DllImport("advapi32")]
        public static extern int RegOpenKey(IntPtr hKey, string lpSubKey, ref int phkResult);

        [DllImport("advapi32")]
        public static extern int RegOpenKeyEx(IntPtr hKey, string lpSubKey, int ulOptions, int samDesired,
                                              ref int phkResult);

        [DllImport("advapi32")]
        public static extern int RegQueryInfoKey(IntPtr hKey, string lpClass, ref int lpcbClass, ref int lpReserved,
                                                 ref int lpcSubKeys, ref int lpcbMaxSubKeyLen, ref int lpcbMaxClassLen,
                                                 ref int lpcValues, ref int lpcbMaxValueNameLen, ref int lpcbMaxValueLen,
                                                 ref int lpcbSecurityDescriptor, ref FILETIME lpftLastWriteTime);

        [DllImport("advapi32")]
        public static extern int RegQueryValue(IntPtr hKey, string lpSubKey, string lpValue, ref int lpcbValue);

        [DllImport("advapi32")]
        public static extern int RegQueryValueEx(IntPtr hKey, string lpValueName, ref int lpReserved, ref int lpType,
                                                 IntPtr lpData, ref int lpcbData);

        [DllImport("advapi32")]
        public static extern int RegReplaceKey(IntPtr hKey, string lpSubKey, string lpNewFile, string lpOldFile);

        [DllImport("advapi32")]
        public static extern int RegRestoreKey(IntPtr hKey, string lpFile, int dwFlags);

        [DllImport("advapi32")]
        public static extern int RegSaveKey(IntPtr hKey, string lpFile, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport("advapi32")]
        public static extern int RegSetKeySecurity(IntPtr hKey, int SecurityInformation,
                                                   ref SECURITY_DESCRIPTOR pSecurityDescriptor);

        [DllImport("advapi32")]
        public static extern int RegSetValue(IntPtr hKey, string lpSubKey, int dwType, string lpData, int cbData);

        [DllImport("advapi32")]
        public static extern int RegSetValueEx(IntPtr hKey, string lpValueName, int Reserved, int dwType, IntPtr lpData,
                                               int cbData);

        [DllImport("advapi32")]
        public static extern int RegUnLoadKey(IntPtr hKey, string lpSubKey);

        [DllImport("advapi32")]
        public static extern int RegisterEventSource(string lpUNCServerName, string lpSourceName);

        [DllImport("advapi32")]
        public static extern int RegisterServiceCtrlHandler(string lpServiceName, ref int lpHandlerProc);

        [DllImport("advapi32")]
        public static extern int ReportEvent(IntPtr hEventLog, int wType, int wCategory, int dwEventID, IntPtr lpUserSid,
                                             int wNumStrings, int dwDataSize, ref int lpStrings, IntPtr lpRawData);

        [DllImport("advapi32")]
        public static extern int RevertToSelf();

        [DllImport("advapi32")]
        public static extern int SetAclInformation(ref ACL pAcl, IntPtr pAclInformation, int nAclInformationLength,
                                                   short dwAclInformationClass);

        [DllImport("advapi32")]
        public static extern int SetFileSecurity(string lpFileName, int SecurityInformation,
                                                 ref SECURITY_DESCRIPTOR pSecurityDescriptor);

        [DllImport("advapi32")]
        public static extern int SetKernelObjectSecurity(IntPtr handle, int SecurityInformation,
                                                         SECURITY_DESCRIPTOR SecurityDescriptor);

        [DllImport("advapi32")]
        public static extern int SetPrivateObjectSecurity(int SecurityInformation,
                                                          SECURITY_DESCRIPTOR ModificationDescriptor,
                                                          SECURITY_DESCRIPTOR ObjectsSecurityDescriptor,
                                                          GENERIC_MAPPING GenericMapping, int Token);

        [DllImport("advapi32")]
        public static extern int SetSecurityDescriptorDacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int bDaclPresent,
                                                           ref ACL pDacl, int bDaclDefaulted);

        [DllImport("advapi32")]
        public static extern int SetSecurityDescriptorGroup(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pGroup,
                                                            int bGroupDefaulted);

        [DllImport("advapi32")]
        public static extern int SetSecurityDescriptorOwner(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pOwner,
                                                            int bOwnerDefaulted);

        [DllImport("advapi32")]
        public static extern int SetSecurityDescriptorSacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int bSaclPresent,
                                                           ref ACL pSacl, int bSaclDefaulted);

        [DllImport("advapi32")]
        public static extern int SetServiceObjectSecurity(IntPtr hService, int dwSecurityInformation,
                                                          IntPtr lpSecurityDescriptor);

        [DllImport("advapi32")]
        public static extern int SetServiceStatus(IntPtr hServiceStatus, ref SERVICE_STATUS lpServiceStatus);

        [DllImport("advapi32")]
        public static extern int SetTokenInformation(int TokenHandle, short TokenInformationClass,
                                                     IntPtr TokenInformation, int TokenInformationLength);

        [DllImport("advapi32")]
        public static extern int StartService(IntPtr hService, int dwNumServiceArgs, ref int lpServiceArgVectors);

        [DllImport("advapi32")]
        public static extern int StartServiceCtrlDispatcher(ref SERVICE_TABLE_ENTRY lpServiceStartTable);

        [DllImport("advapi32")]
        public static extern int UnlockServiceDatabase(IntPtr ScLock);

        [DllImport("advapi32")]
        public static extern void FreeSid(IntPtr pSid);

        [DllImport("advapi32")]
        public static extern void MapGenericMask(int AccessMask, GENERIC_MAPPING GenericMapping);

        [DllImport("advapi32")]
        public static extern int GetUserNameW(Byte lpBuffer, int nSize);

        [DllImport("advapi32")]
        public static extern int OpenProcessToken(int ProcessHandle, int DesiredAccess, int TokenHandle);
    }

    public abstract class Version
    {
        [DllImport("version")]
        public static extern int GetFileVersionInfo(string lptstrFilename, int dwHandle, int dwLen, IntPtr lpData);

        [DllImport("version")]
        public static extern int GetFileVersionInfoSize(string lptstrFilename, ref int lpdwHandle);

        [DllImport("version")]
        public static extern int VerFindFile(int uFlags, string szFileName, string szWinDir, string szAppDir,
                                             string szCurDir, ref int lpuCurDirLen, string szDestDir,
                                             ref int lpuDestDirLen);

        [DllImport("version")]
        public static extern int VerInstallFile(int uFlags, string szSrcFileName, string szDestFileName, string szSrcDir,
                                                string szDestDir, string szCurDir, string szTmpFile,
                                                ref int lpuTmpFileLen);

        [DllImport("version")]
        public static extern int VerQueryValue(IntPtr pBlock, string lpSubBlock, ref int lplpBuffer, ref int puLen);
    }

    public abstract class Kernel
    {
        public const int ACCESS_ALLOWED_ACE_TYPE = 0x0;
        public const int ACCESS_DENIED_ACE_TYPE = 0x1;
        public const int ACCESS_SYSTEM_SECURITY = 0x1000000;
        public const int ACL_REVISION = (2);
        public const int ACL_REVISION1 = (1);
        public const int ACL_REVISION2 = (2);
        public const int AC_LINE_BACKUP_POWER = 0x2;
        public const int AC_LINE_OFFLINE = 0x0;
        public const int AC_LINE_ONLINE = 0x1;
        public const int AC_LINE_UNKNOWN = 0xFF;
        public const int APPLICATION_ERROR_MASK = 0x20000000;
        public const int AclRevisionInformation = 1;
        public const int AclSizeInformation = 2;
        public const int BACKGROUND_BLUE = 0x10;
        public const int BACKGROUND_GREEN = 0x20;
        public const int BACKGROUND_INTENSITY = 0x80;
        public const int BACKGROUND_RED = 0x40;
        public const int BACKUP_ALTERNATE_DATA = 0x4;
        public const int BACKUP_DATA = 0x1;
        public const int BACKUP_EA_DATA = 0x2;
        public const int BACKUP_LINK = 0x5;
        public const int BACKUP_SECURITY_DATA = 0x3;
        public const int BATTERY_FLAG_CHARGING = 0x8;
        public const int BATTERY_FLAG_CRITICAL = 0x4;
        public const int BATTERY_FLAG_HIGH = 0x1;
        public const int BATTERY_FLAG_LOW = 0x2;
        public const int BATTERY_FLAG_NO_BATTERY = 0x80;
        public const int BATTERY_FLAG_UNKNOWN = 0xFF;
        public const int BATTERY_LIFE_UNKNOWN = 0xFFFF;
        public const int BATTERY_PERCENTAGE_UNKNOWN = 0xFF;
        public const int BAUD_075 = 0x1;
        public const int BAUD_110 = 0x2;
        public const int BAUD_115200 = 0x20000;
        public const int BAUD_1200 = 0x40;
        public const int BAUD_128K = 0x10000;
        public const int BAUD_134_5 = 0x4;
        public const int BAUD_14400 = 0x1000;
        public const int BAUD_150 = 0x8;
        public const int BAUD_1800 = 0x80;
        public const int BAUD_19200 = 0x2000;
        public const int BAUD_2400 = 0x100;
        public const int BAUD_300 = 0x10;
        public const int BAUD_38400 = 0x4000;
        public const int BAUD_4800 = 0x200;
        public const int BAUD_56K = 0x8000;
        public const int BAUD_57600 = 0x40000;
        public const int BAUD_600 = 0x20;
        public const int BAUD_7200 = 0x400;
        public const int BAUD_9600 = 0x800;
        public const int BAUD_USER = 0x10000000;
        public const int C1_ALPHA = 0x100;
        public const int C1_BLANK = 0x40;
        public const int C1_CNTRL = 0x20;
        public const int C1_DIGIT = 0x4;
        public const int C1_LOWER = 0x2;
        public const int C1_PUNCT = 0x10;
        public const int C1_SPACE = 0x8;
        public const int C1_UPPER = 0x1;
        public const int C1_XDIGIT = 0x80;
        public const int C2_ARABICNUMBER = 0x6;
        public const int C2_BLOCKSEPARATOR = 0x8;
        public const int C2_COMMONSEPARATOR = 0x7;
        public const int C2_EUROPENUMBER = 0x3;
        public const int C2_EUROPESEPARATOR = 0x4;
        public const int C2_EUROPETERMINATOR = 0x5;
        public const int C2_LEFTTORIGHT = 0x1;
        public const int C2_NOTAPPLICABLE = 0x0;
        public const int C2_OTHERNEUTRAL = 0xB;
        public const int C2_RIGHTTOLEFT = 0x2;
        public const int C2_SEGMENTSEPARATOR = 0x9;
        public const int C2_WHITESPACE = 0xA;
        public const int C3_DIACRITIC = 0x2;
        public const int C3_NONSPACING = 0x1;
        public const int C3_NOTAPPLICABLE = 0x0;
        public const int C3_SYMBOL = 0x8;
        public const int C3_VOWELMARK = 0x4;
        public const int CAL_GREGORIAN = 1;
        public const int CAL_GREGORIAN_US = 2;
        public const int CAL_ICALINTVALUE = 0x1;
        public const int CAL_IYEAROFFSETRANGE = 0x3;
        public const int CAL_JAPAN = 3;
        public const int CAL_KOREA = 5;
        public const int CAL_SABBREVDAYNAME1 = 0xE;
        public const int CAL_SABBREVDAYNAME2 = 0xF;
        public const int CAL_SABBREVDAYNAME3 = 0x10;
        public const int CAL_SABBREVDAYNAME4 = 0x11;
        public const int CAL_SABBREVDAYNAME5 = 0x12;
        public const int CAL_SABBREVDAYNAME6 = 0x13;
        public const int CAL_SABBREVDAYNAME7 = 0x14;
        public const int CAL_SABBREVMONTHNAME1 = 0x22;
        public const int CAL_SABBREVMONTHNAME10 = 0x2B;
        public const int CAL_SABBREVMONTHNAME11 = 0x2C;
        public const int CAL_SABBREVMONTHNAME12 = 0x2D;
        public const int CAL_SABBREVMONTHNAME13 = 0x2E;
        public const int CAL_SABBREVMONTHNAME2 = 0x23;
        public const int CAL_SABBREVMONTHNAME3 = 0x24;
        public const int CAL_SABBREVMONTHNAME4 = 0x25;
        public const int CAL_SABBREVMONTHNAME5 = 0x26;
        public const int CAL_SABBREVMONTHNAME6 = 0x27;
        public const int CAL_SABBREVMONTHNAME7 = 0x28;
        public const int CAL_SABBREVMONTHNAME8 = 0x29;
        public const int CAL_SABBREVMONTHNAME9 = 0x2A;
        public const int CAL_SCALNAME = 0x2;
        public const int CAL_SDAYNAME1 = 0x7;
        public const int CAL_SDAYNAME2 = 0x8;
        public const int CAL_SDAYNAME3 = 0x9;
        public const int CAL_SDAYNAME4 = 0xA;
        public const int CAL_SDAYNAME5 = 0xB;
        public const int CAL_SDAYNAME6 = 0xC;
        public const int CAL_SDAYNAME7 = 0xD;
        public const int CAL_SERASTRING = 0x4;
        public const int CAL_SLONGDATE = 0x6;
        public const int CAL_SMONTHNAME1 = 0x15;
        public const int CAL_SMONTHNAME10 = 0x1E;
        public const int CAL_SMONTHNAME11 = 0x1F;
        public const int CAL_SMONTHNAME12 = 0x20;
        public const int CAL_SMONTHNAME13 = 0x21;
        public const int CAL_SMONTHNAME2 = 0x16;
        public const int CAL_SMONTHNAME3 = 0x17;
        public const int CAL_SMONTHNAME4 = 0x18;
        public const int CAL_SMONTHNAME5 = 0x19;
        public const int CAL_SMONTHNAME6 = 0x1A;
        public const int CAL_SMONTHNAME7 = 0x1B;
        public const int CAL_SMONTHNAME8 = 0x1C;
        public const int CAL_SMONTHNAME9 = 0x1D;
        public const int CAL_SSHORTDATE = 0x5;
        public const int CAL_TAIWAN = 4;
        public const int CAPSLOCK_ON = 0x80;
        public const int CBR_110 = 110;
        public const int CBR_115200 = 115200;
        public const int CBR_1200 = 1200;
        public const int CBR_128000 = 128000;
        public const int CBR_14400 = 14400;
        public const int CBR_19200 = 19200;
        public const int CBR_2400 = 2400;
        public const int CBR_256000 = 256000;
        public const int CBR_300 = 300;
        public const int CBR_38400 = 38400;
        public const int CBR_4800 = 4800;
        public const int CBR_56000 = 56000;
        public const int CBR_57600 = 57600;
        public const int CBR_600 = 600;
        public const int CBR_9600 = 9600;
        public const int CE_BREAK = 0x10;
        public const int CE_DNS = 0x800;
        public const int CE_FRAME = 0x8;
        public const int CE_IOE = 0x400;
        public const int CE_MODE = 0x8000;
        public const int CE_OOP = 0x1000;
        public const int CE_OVERRUN = 0x2;
        public const int CE_PTO = 0x200;
        public const int CE_RXOVER = 0x1;
        public const int CE_RXPARITY = 0x4;
        public const int CE_TXFULL = 0x100;
        public const int CLRBREAK = 9;
        public const int CLRDTR = 6;
        public const int CLRRTS = 4;
        public const int CONSOLE_TEXTMODE_BUFFER = 1;
        public const int CONTAINER_INHERIT_ACE = 0x2;
        public const int CP_ACP = 0;
        public const int CP_OEMCP = 1;
        public const int CREATE_ALWAYS = 2;
        public const int CREATE_NEW = 1;
        public const int CREATE_NEW_CONSOLE = 0x10;
        public const int CREATE_NEW_PROCESS_GROUP = 0x200;
        public const int CREATE_NO_WINDOW = 0x8000000;
        public const int CREATE_PROCESS_DEBUG_EVENT = 3;
        public const int CREATE_SUSPENDED = 0x4;
        public const int CREATE_THREAD_DEBUG_EVENT = 2;
        public const int CTRL_BREAK_EVENT = 1;
        public const int CTRL_CLOSE_EVENT = 2;
        public const int CTRL_C_EVENT = 0;
        public const int CTRL_LOGOFF_EVENT = 5;
        public const int CTRL_SHUTDOWN_EVENT = 6;
        public const int CTRY_AUSTRALIA = 61;
        public const int CTRY_AUSTRIA = 43;
        public const int CTRY_BELGIUM = 32;
        public const int CTRY_BRAZIL = 55;
        public const int CTRY_CANADA = 2;
        public const int CTRY_DEFAULT = 0;
        public const int CTRY_DENMARK = 45;
        public const int CTRY_FINLAND = 358;
        public const int CTRY_FRANCE = 33;
        public const int CTRY_GERMANY = 49;
        public const int CTRY_ICELAND = 354;
        public const int CTRY_IRELAND = 353;
        public const int CTRY_ITALY = 39;
        public const int CTRY_JAPAN = 81;
        public const int CTRY_MEXICO = 52;
        public const int CTRY_NETHERLANDS = 31;
        public const int CTRY_NEW_ZEALAND = 64;
        public const int CTRY_NORWAY = 47;
        public const int CTRY_PORTUGAL = 351;
        public const int CTRY_PRCHINA = 86;
        public const int CTRY_SOUTH_KOREA = 82;
        public const int CTRY_SPAIN = 34;
        public const int CTRY_SWEDEN = 46;
        public const int CTRY_SWITZERLAND = 41;
        public const int CTRY_TAIWAN = 886;
        public const int CTRY_UNITED_KINGDOM = 44;
        public const int CTRY_UNITED_STATES = 1;
        public const int CT_CTYPE1 = 0x1;
        public const int CT_CTYPE2 = 0x2;
        public const int CT_CTYPE3 = 0x4;
        public const int DATABITS_16 = 0x10;
        public const int DATABITS_16X = 0x20;
        public const int DATABITS_5 = 0x1;
        public const int DATABITS_6 = 0x2;
        public const int DATABITS_7 = 0x4;
        public const int DATABITS_8 = 0x8;
        public const int DATE_LONGDATE = 0x2;
        public const int DATE_SHORTDATE = 0x1;
        public const int DDD_EXACT_MATCH_ON_REMOVE = 0x4;
        public const int DDD_RAW_TARGET_PATH = 0x1;
        public const int DDD_REMOVE_DEFINITION = 0x2;
        public const int DEBUG_ONLY_THIS_PROCESS = 0x2;
        public const int DEBUG_PROCESS = 0x1;
        public const int DELETE = 0x10000;
        public const int DETACHED_PROCESS = 0x8;
        public const int DFCS_ADJUSTRECT = 0x2000;
        public const int DFCS_BUTTON3STATE = 0x8;
        public const int DFCS_BUTTONCHECK = 0x0;
        public const int DFCS_BUTTONPUSH = 0x10;
        public const int DFCS_BUTTONRADIO = 0x4;
        public const int DFCS_BUTTONRADIOIMAGE = 0x1;
        public const int DFCS_BUTTONRADIOMASK = 0x2;
        public const int DFCS_CAPTIONCLOSE = 0x0;
        public const int DFCS_CAPTIONHELP = 0x4;
        public const int DFCS_CAPTIONMAX = 0x2;
        public const int DFCS_CAPTIONMIN = 0x1;
        public const int DFCS_CAPTIONRESTORE = 0x3;
        public const int DFCS_CHECKED = 0x400;
        public const int DFCS_FLAT = 0x4000;
        public const int DFCS_INACTIVE = 0x100;
        public const int DFCS_MENUARROW = 0x0;
        public const int DFCS_MENUARROWRIGHT = 0x4;
        public const int DFCS_MENUBULLET = 0x2;
        public const int DFCS_MENUCHECK = 0x1;
        public const int DFCS_MONO = 0x8000;
        public const int DFCS_PUSHED = 0x200;
        public const int DFCS_SCROLLCOMBOBOX = 0x5;
        public const int DFCS_SCROLLDOWN = 0x1;
        public const int DFCS_SCROLLLEFT = 0x2;
        public const int DFCS_SCROLLRIGHT = 0x3;
        public const int DFCS_SCROLLSIZEGRIP = 0x8;
        public const int DFCS_SCROLLSIZEGRIPRIGHT = 0x10;
        public const int DFCS_SCROLLUP = 0x0;
        public const int DFC_BUTTON = 4;
        public const int DFC_CAPTION = 1;
        public const int DFC_MENU = 2;
        public const int DFC_SCROLL = 3;
        public const int DOMAIN_ALIAS_RID_ACCOUNT_OPS = 0x224;
        public const int DOMAIN_ALIAS_RID_ADMINS = 0x220;
        public const int DOMAIN_ALIAS_RID_BACKUP_OPS = 0x227;
        public const int DOMAIN_ALIAS_RID_GUESTS = 0x222;
        public const int DOMAIN_ALIAS_RID_POWER_USERS = 0x223;
        public const int DOMAIN_ALIAS_RID_PRINT_OPS = 0x226;
        public const int DOMAIN_ALIAS_RID_REPLICATOR = 0x228;
        public const int DOMAIN_ALIAS_RID_SYSTEM_OPS = 0x225;
        public const int DOMAIN_ALIAS_RID_USERS = 0x221;
        public const int DOMAIN_GROUP_RID_ADMINS = 0x200;
        public const int DOMAIN_GROUP_RID_GUESTS = 0x202;
        public const int DOMAIN_GROUP_RID_USERS = 0x201;
        public const int DOMAIN_USER_RID_ADMIN = 0x1F4;
        public const int DOMAIN_USER_RID_GUEST = 0x1F5;
        public const int DONT_RESOLVE_DLL_REFERENCES = 0x1;
        public const int DOUBLE_CLICK = 0x2;
        public const int DRIVE_CDROM = 5;
        public const int DRIVE_FIXED = 3;
        public const int DRIVE_RAMDISK = 6;
        public const int DRIVE_REMOTE = 4;
        public const int DRIVE_REMOVABLE = 2;
        public const int DTR_CONTROL_DISABLE = 0x0;
        public const int DTR_CONTROL_ENABLE = 0x1;
        public const int DTR_CONTROL_HANDSHAKE = 0x2;
        public const int DUPLICATE_CLOSE_SOURCE = 0x1;
        public const int DUPLICATE_SAME_ACCESS = 0x2;
        public const int ENABLE_ECHO_INPUT = 0x4;
        public const int ENABLE_LINE_INPUT = 0x2;
        public const int ENABLE_MOUSE_INPUT = 0x10;
        public const int ENABLE_PROCESSED_INPUT = 0x1;
        public const int ENABLE_PROCESSED_OUTPUT = 0x1;
        public const int ENABLE_WINDOW_INPUT = 0x8;
        public const int ENABLE_WRAP_AT_EOL_OUTPUT = 0x2;
        public const int ENHANCED_KEY = 0x100;
        public const int ENUM_ALL_CALENDARS = 0xFFFF;
        public const int ERROR_SEVERITY_ERROR = unchecked((int) 0xC0000000);
        public const int ERROR_SEVERITY_INFORMATIONAL = 0x40000000;
        public const int ERROR_SEVERITY_SUCCESS = 0x0;
        public const int ERROR_SEVERITY_WARNING = unchecked((int) 0x80000000);
        public const int EVENPARITY = 2;
        public const int EV_BREAK = 0x40;
        public const int EV_CTS = 0x8;
        public const int EV_DSR = 0x10;
        public const int EV_ERR = 0x80;
        public const int EV_EVENT1 = 0x800;
        public const int EV_EVENT2 = 0x1000;
        public const int EV_PERR = 0x200;
        public const int EV_RING = 0x100;
        public const int EV_RLSD = 0x20;
        public const int EV_RX80FULL = 0x400;
        public const int EV_RXCHAR = 0x1;
        public const int EV_RXFLAG = 0x2;
        public const int EV_TXEMPTY = 0x4;
        public const int EXCEPTION_CONTINUE_EXECUTION = -1;
        public const int EXCEPTION_CONTINUE_SEARCH = 0;
        public const int EXCEPTION_DEBUG_EVENT = 1;
        public const int EXCEPTION_EXECUTE_HANDLER = 1;
        public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;
        public const int EXIT_PROCESS_DEBUG_EVENT = 5;
        public const int EXIT_THREAD_DEBUG_EVENT = 4;
        public const int FAILED_ACCESS_ACE_FLAG = 0x80;
        public const int FILE_ADD_FILE = (0x2);
        public const int FILE_ADD_SUBDIRECTORY = (0x4);
        public const int FILE_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF);
        public const int FILE_APPEND_DATA = (0x4);
        public const int FILE_ATTRIBUTE_ARCHIVE = 0x20;
        public const int FILE_ATTRIBUTE_COMPRESSED = 0x800;
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x10;
        public const int FILE_ATTRIBUTE_HIDDEN = 0x2;
        public const int FILE_ATTRIBUTE_NORMAL = 0x80;
        public const int FILE_ATTRIBUTE_READONLY = 0x1;
        public const int FILE_ATTRIBUTE_SYSTEM = 0x4;
        public const int FILE_ATTRIBUTE_TEMPORARY = 0x100;
        public const int FILE_BEGIN = 0;
        public const int FILE_CASE_PRESERVED_NAMES = 0x2;
        public const int FILE_CASE_SENSITIVE_SEARCH = 0x1;
        public const int FILE_CREATE_PIPE_INSTANCE = (0x4);
        public const int FILE_CURRENT = 1;
        public const int FILE_DELETE_CHILD = (0x40);
        public const int FILE_END = 2;
        public const int FILE_EXECUTE = (0x20);
        public const int FILE_FILE_COMPRESSION = 0x10;
        public const int FILE_FLAG_BACKUP_SEMANTICS = 0x2000000;
        public const int FILE_FLAG_DELETE_ON_CLOSE = 0x4000000;
        public const int FILE_FLAG_NO_BUFFERING = 0x20000000;
        public const int FILE_FLAG_OVERLAPPED = 0x40000000;
        public const int FILE_FLAG_POSIX_SEMANTICS = 0x1000000;
        public const int FILE_FLAG_RANDOM_ACCESS = 0x10000000;
        public const int FILE_FLAG_SEQUENTIAL_SCAN = 0x8000000;
        public const int FILE_FLAG_WRITE_THROUGH = unchecked((int) 0x80000000);

        public const int FILE_GENERIC_EXECUTE =
            (STANDARD_RIGHTS_EXECUTE | FILE_READ_ATTRIBUTES | FILE_EXECUTE | SYNCHRONIZE);

        public const int FILE_GENERIC_READ =
            (STANDARD_RIGHTS_READ | FILE_READ_DATA | FILE_READ_ATTRIBUTES | FILE_READ_EA | SYNCHRONIZE);

        public const int FILE_GENERIC_WRITE =
            (STANDARD_RIGHTS_WRITE | FILE_WRITE_DATA | FILE_WRITE_ATTRIBUTES | FILE_WRITE_EA | FILE_APPEND_DATA |
             SYNCHRONIZE);

        public const int FILE_LIST_DIRECTORY = (0x1);
        public const int FILE_MAP_ALL_ACCESS = SECTION_ALL_ACCESS;
        public const int FILE_MAP_COPY = SECTION_QUERY;
        public const int FILE_MAP_READ = SECTION_MAP_READ;
        public const int FILE_MAP_WRITE = SECTION_MAP_WRITE;
        public const int FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x4;
        public const int FILE_NOTIFY_CHANGE_DIR_NAME = 0x2;
        public const int FILE_NOTIFY_CHANGE_FILE_NAME = 0x1;
        public const int FILE_NOTIFY_CHANGE_LAST_WRITE = 0x10;
        public const int FILE_NOTIFY_CHANGE_SECURITY = 0x100;
        public const int FILE_NOTIFY_CHANGE_SIZE = 0x8;
        public const int FILE_PERSISTENT_ACLS = 0x8;
        public const int FILE_READ_ATTRIBUTES = (0x80);
        public const int FILE_READ_DATA = (0x1);
        public const int FILE_READ_EA = (0x8);
        public const int FILE_READ_PROPERTIES = FILE_READ_EA;
        public const int FILE_SHARE_READ = 0x1;
        public const int FILE_SHARE_WRITE = 0x2;
        public const int FILE_TRAVERSE = (0x20);
        public const int FILE_TYPE_CHAR = 0x2;
        public const int FILE_TYPE_DISK = 0x1;
        public const int FILE_TYPE_PIPE = 0x3;
        public const int FILE_TYPE_REMOTE = 0x8000;
        public const int FILE_TYPE_UNKNOWN = 0x0;
        public const int FILE_UNICODE_ON_DISK = 0x4;
        public const int FILE_VOLUME_IS_COMPRESSED = 0x8000;
        public const int FILE_WRITE_ATTRIBUTES = (0x100);
        public const int FILE_WRITE_DATA = (0x2);
        public const int FILE_WRITE_EA = (0x10);
        public const int FILE_WRITE_PROPERTIES = FILE_WRITE_EA;
        public const int FOCUS_EVENT = 0x10;
        public const int FOREGROUND_BLUE = 0x1;
        public const int FOREGROUND_GREEN = 0x2;
        public const int FOREGROUND_INTENSITY = 0x8;
        public const int FOREGROUND_RED = 0x4;
        public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x100;
        public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x2000;
        public const int FORMAT_MESSAGE_FROM_HMODULE = 0x800;
        public const int FORMAT_MESSAGE_FROM_STRING = 0x400;
        public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;
        public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0xFF;
        public const int FROM_LEFT_1ST_BUTTON_PRESSED = 0x1;
        public const int FROM_LEFT_2ND_BUTTON_PRESSED = 0x4;
        public const int FROM_LEFT_3RD_BUTTON_PRESSED = 0x8;
        public const int FROM_LEFT_4TH_BUTTON_PRESSED = 0x10;
        public const int FS_CASE_IS_PRESERVED = FILE_CASE_PRESERVED_NAMES;
        public const int FS_CASE_SENSITIVE = FILE_CASE_SENSITIVE_SEARCH;
        public const int FS_PERSISTENT_ACLS = FILE_PERSISTENT_ACLS;
        public const int FS_UNICODE_STORED_ON_DISK = FILE_UNICODE_ON_DISK;
        public const int GENERIC_ALL = 0x10000000;
        public const int GENERIC_EXECUTE = 0x20000000;
        public const int GENERIC_READ = unchecked((int) 0x80000000);
        public const int GENERIC_WRITE = 0x40000000;
        public const int GET_TAPE_DRIVE_INFORMATION = 1;
        public const int GET_TAPE_MEDIA_INFORMATION = 0;
        public const int GHND = (GMEM_MOVEABLE | GMEM_ZEROINIT);
        public const int GMEM_DDESHARE = 0x2000;
        public const int GMEM_DISCARDABLE = 0x100;
        public const int GMEM_DISCARDED = 0x4000;
        public const int GMEM_FIXED = 0x0;
        public const int GMEM_INVALID_HANDLE = 0x8000;
        public const int GMEM_LOCKCOUNT = 0xFF;
        public const int GMEM_LOWER = GMEM_NOT_BANKED;
        public const int GMEM_MODIFY = 0x80;
        public const int GMEM_MOVEABLE = 0x2;
        public const int GMEM_NOCOMPACT = 0x10;
        public const int GMEM_NODISCARD = 0x20;
        public const int GMEM_NOTIFY = 0x4000;
        public const int GMEM_NOT_BANKED = 0x1000;
        public const int GMEM_SHARE = 0x2000;
        public const int GMEM_VALID_FLAGS = 0x7F72;
        public const int GMEM_ZEROINIT = 0x40;
        public const int GPTR = (GMEM_FIXED | GMEM_ZEROINIT);
        public const int HIGH_PRIORITY_CLASS = 0x80;
        public const int HKEY_CLASSES_ROOT = unchecked((int) 0x80000000);
        public const int HKEY_CURRENT_CONFIG = unchecked((int) 0x80000005);
        public const int HKEY_CURRENT_USER = unchecked((int) 0x80000001);
        public const int HKEY_DYN_DATA = unchecked((int) 0x80000006);
        public const int HKEY_LOCAL_MACHINE = unchecked((int) 0x80000002);
        public const int HKEY_PERFORMANCE_DATA = unchecked((int) 0x80000004);
        public const int HKEY_USERS = unchecked((int) 0x80000003);
        public const int IDLE_PRIORITY_CLASS = 0x40;
        public const int IE_BADID = (-1);
        public const int IE_BAUDRATE = (-12);
        public const int IE_BYTESIZE = (-11);
        public const int IE_DEFAULT = (-5);
        public const int IE_HARDWARE = (-10);
        public const int IE_MEMORY = (-4);
        public const int IE_NOPEN = (-3);
        public const int IE_OPEN = (-2);
        public const int IGNORE = 0;
        public const int INFINITE = 0xFFFF;
        public const int INHERIT_ONLY_ACE = 0x8;
        public const int IO_COMPLETION_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3);
        public const int IO_COMPLETION_MODIFY_STATE = 0x2;

        public const int KEY_ALL_ACCESS =
            ((STANDARD_RIGHTS_ALL | KEY_QUERY_VALUE | KEY_SET_VALUE | KEY_CREATE_SUB_KEY | KEY_ENUMERATE_SUB_KEYS |
              KEY_NOTIFY | KEY_CREATE_LINK) & (~ SYNCHRONIZE));

        public const int KEY_CREATE_LINK = 0x20;
        public const int KEY_CREATE_SUB_KEY = 0x4;
        public const int KEY_ENUMERATE_SUB_KEYS = 0x8;
        public const int KEY_EVENT = 0x1;
        public const int KEY_EXECUTE = ((KEY_READ) & (~ SYNCHRONIZE));
        public const int KEY_NOTIFY = 0x10;
        public const int KEY_QUERY_VALUE = 0x1;

        public const int KEY_READ =
            ((STANDARD_RIGHTS_READ | KEY_QUERY_VALUE | KEY_ENUMERATE_SUB_KEYS | KEY_NOTIFY) & (~ SYNCHRONIZE));

        public const int KEY_SET_VALUE = 0x2;
        public const int KEY_WRITE = ((STANDARD_RIGHTS_WRITE | KEY_SET_VALUE | KEY_CREATE_SUB_KEY) & (~ SYNCHRONIZE));
        public const int LANG_BULGARIAN = 0x2;
        public const int LANG_CHINESE = 0x4;
        public const int LANG_CROATIAN = 0x1A;
        public const int LANG_CZECH = 0x5;
        public const int LANG_DANISH = 0x6;
        public const int LANG_DUTCH = 0x13;
        public const int LANG_ENGLISH = 0x9;
        public const int LANG_FINNISH = 0xB;
        public const int LANG_FRENCH = 0xC;
        public const int LANG_GERMAN = 0x7;
        public const int LANG_GREEK = 0x8;
        public const int LANG_HUNGARIAN = 0xE;
        public const int LANG_ICELANDIC = 0xF;
        public const int LANG_ITALIAN = 0x10;
        public const int LANG_JAPANESE = 0x11;
        public const int LANG_KOREAN = 0x12;
        public const int LANG_NEUTRAL = 0x0;
        public const int LANG_NORWEGIAN = 0x14;
        public const int LANG_POLISH = 0x15;
        public const int LANG_PORTUGUESE = 0x16;
        public const int LANG_ROMANIAN = 0x18;
        public const int LANG_RUSSIAN = 0x19;
        public const int LANG_SLOVAK = 0x1B;
        public const int LANG_SLOVENIAN = 0x24;
        public const int LANG_SPANISH = 0xA;
        public const int LANG_SWEDISH = 0x1D;
        public const int LANG_TURKISH = 0x1F;
        public const int LCMAP_BYTEREV = 0x800;
        public const int LCMAP_LOWERCASE = 0x100;
        public const int LCMAP_SORTKEY = 0x400;
        public const int LCMAP_UPPERCASE = 0x200;
        public const int LEFT_ALT_PRESSED = 0x2;
        public const int LEFT_CTRL_PRESSED = 0x8;
        public const int LHND = (LMEM_MOVEABLE + LMEM_ZEROINIT);
        public const int LMEM_DISCARDABLE = 0xF00;
        public const int LMEM_DISCARDED = 0x4000;
        public const int LMEM_FIXED = 0x0;
        public const int LMEM_INVALID_HANDLE = 0x8000;
        public const int LMEM_LOCKCOUNT = 0xFF;
        public const int LMEM_MODIFY = 0x80;
        public const int LMEM_MOVEABLE = 0x2;
        public const int LMEM_NOCOMPACT = 0x10;
        public const int LMEM_NODISCARD = 0x20;
        public const int LMEM_VALID_FLAGS = 0xF72;
        public const int LMEM_ZEROINIT = 0x40;
        public const int LNOTIFY_DISCARD = 2;
        public const int LNOTIFY_MOVE = 1;
        public const int LNOTIFY_OUTOFMEM = 0;
        public const int LOAD_DLL_DEBUG_EVENT = 6;
        public const int LOCALE_ICENTURY = 0x24;
        public const int LOCALE_ICOUNTRY = 0x5;
        public const int LOCALE_ICURRDIGITS = 0x19;
        public const int LOCALE_ICURRENCY = 0x1B;
        public const int LOCALE_IDATE = 0x21;
        public const int LOCALE_IDAYLZERO = 0x26;
        public const int LOCALE_IDEFAULTCODEPAGE = 0xB;
        public const int LOCALE_IDEFAULTCOUNTRY = 0xA;
        public const int LOCALE_IDEFAULTLANGUAGE = 0x9;
        public const int LOCALE_IDIGITS = 0x11;
        public const int LOCALE_IINTLCURRDIGITS = 0x1A;
        public const int LOCALE_ILANGUAGE = 0x1;
        public const int LOCALE_ILDATE = 0x22;
        public const int LOCALE_ILZERO = 0x12;
        public const int LOCALE_IMEASURE = 0xD;
        public const int LOCALE_IMONLZERO = 0x27;
        public const int LOCALE_INEGCURR = 0x1C;
        public const int LOCALE_INEGSEPBYSPACE = 0x57;
        public const int LOCALE_INEGSIGNPOSN = 0x53;
        public const int LOCALE_INEGSYMPRECEDES = 0x56;
        public const int LOCALE_IPOSSEPBYSPACE = 0x55;
        public const int LOCALE_IPOSSIGNPOSN = 0x52;
        public const int LOCALE_IPOSSYMPRECEDES = 0x54;
        public const int LOCALE_ITIME = 0x23;
        public const int LOCALE_ITLZERO = 0x25;
        public const int LOCALE_NOUSEROVERRIDE = unchecked((int) 0x80000000);
        public const int LOCALE_S1159 = 0x28;
        public const int LOCALE_S2359 = 0x29;
        public const int LOCALE_SABBREVCTRYNAME = 0x7;
        public const int LOCALE_SABBREVDAYNAME1 = 0x31;
        public const int LOCALE_SABBREVDAYNAME2 = 0x32;
        public const int LOCALE_SABBREVDAYNAME3 = 0x33;
        public const int LOCALE_SABBREVDAYNAME4 = 0x34;
        public const int LOCALE_SABBREVDAYNAME5 = 0x35;
        public const int LOCALE_SABBREVDAYNAME6 = 0x36;
        public const int LOCALE_SABBREVDAYNAME7 = 0x37;
        public const int LOCALE_SABBREVLANGNAME = 0x3;
        public const int LOCALE_SABBREVMONTHNAME1 = 0x44;
        public const int LOCALE_SABBREVMONTHNAME10 = 0x4D;
        public const int LOCALE_SABBREVMONTHNAME11 = 0x4E;
        public const int LOCALE_SABBREVMONTHNAME12 = 0x4F;
        public const int LOCALE_SABBREVMONTHNAME13 = 0x100F;
        public const int LOCALE_SABBREVMONTHNAME2 = 0x45;
        public const int LOCALE_SABBREVMONTHNAME3 = 0x46;
        public const int LOCALE_SABBREVMONTHNAME4 = 0x47;
        public const int LOCALE_SABBREVMONTHNAME5 = 0x48;
        public const int LOCALE_SABBREVMONTHNAME6 = 0x49;
        public const int LOCALE_SABBREVMONTHNAME7 = 0x4A;
        public const int LOCALE_SABBREVMONTHNAME8 = 0x4B;
        public const int LOCALE_SABBREVMONTHNAME9 = 0x4C;
        public const int LOCALE_SCOUNTRY = 0x6;
        public const int LOCALE_SCURRENCY = 0x14;
        public const int LOCALE_SDATE = 0x1D;
        public const int LOCALE_SDAYNAME1 = 0x2A;
        public const int LOCALE_SDAYNAME2 = 0x2B;
        public const int LOCALE_SDAYNAME3 = 0x2C;
        public const int LOCALE_SDAYNAME4 = 0x2D;
        public const int LOCALE_SDAYNAME5 = 0x2E;
        public const int LOCALE_SDAYNAME6 = 0x2F;
        public const int LOCALE_SDAYNAME7 = 0x30;
        public const int LOCALE_SDECIMAL = 0xE;
        public const int LOCALE_SENGCOUNTRY = 0x1002;
        public const int LOCALE_SENGLANGUAGE = 0x1001;
        public const int LOCALE_SGROUPING = 0x10;
        public const int LOCALE_SINTLSYMBOL = 0x15;
        public const int LOCALE_SLANGUAGE = 0x2;
        public const int LOCALE_SLIST = 0xC;
        public const int LOCALE_SLONGDATE = 0x20;
        public const int LOCALE_SMONDECIMALSEP = 0x16;
        public const int LOCALE_SMONGROUPING = 0x18;
        public const int LOCALE_SMONTHNAME1 = 0x38;
        public const int LOCALE_SMONTHNAME10 = 0x41;
        public const int LOCALE_SMONTHNAME11 = 0x42;
        public const int LOCALE_SMONTHNAME12 = 0x43;
        public const int LOCALE_SMONTHNAME2 = 0x39;
        public const int LOCALE_SMONTHNAME3 = 0x3A;
        public const int LOCALE_SMONTHNAME4 = 0x3B;
        public const int LOCALE_SMONTHNAME5 = 0x3C;
        public const int LOCALE_SMONTHNAME6 = 0x3D;
        public const int LOCALE_SMONTHNAME7 = 0x3E;
        public const int LOCALE_SMONTHNAME8 = 0x3F;
        public const int LOCALE_SMONTHNAME9 = 0x40;
        public const int LOCALE_SMONTHOUSANDSEP = 0x17;
        public const int LOCALE_SNATIVECTRYNAME = 0x8;
        public const int LOCALE_SNATIVEDIGITS = 0x13;
        public const int LOCALE_SNATIVELANGNAME = 0x4;
        public const int LOCALE_SNEGATIVESIGN = 0x51;
        public const int LOCALE_SPOSITIVESIGN = 0x50;
        public const int LOCALE_SSHORTDATE = 0x1F;
        public const int LOCALE_STHOUSAND = 0xF;
        public const int LOCALE_STIME = 0x1E;
        public const int LOCALE_STIMEFORMAT = 0x1003;
        public const int LOCKFILE_EXCLUSIVE_LOCK = 0x2;
        public const int LOCKFILE_FAIL_IMMEDIATELY = 0x1;
        public const int LOGON32_LOGON_BATCH = 4;
        public const int LOGON32_LOGON_INTERACTIVE = 2;
        public const int LOGON32_LOGON_SERVICE = 5;
        public const int LOGON32_PROVIDER_DEFAULT = 0;
        public const int LOGON32_PROVIDER_WINNT35 = 1;
        public const int LPTR = (LMEM_FIXED + LMEM_ZEROINIT);
        public const int LPTx = 0x80;
        public const int MAILSLOT_NO_MESSAGE = (-1);
        public const int MAILSLOT_WAIT_FOREVER = (-1);
        public const int MAP_COMPOSITE = 0x40;
        public const int MAP_FOLDCZONE = 0x10;
        public const int MAP_FOLDDIGITS = 0x80;
        public const int MAP_PRECOMPOSED = 0x20;
        public const int MARKPARITY = 3;
        public const int MAXByte = 0xFF;
        public const int MAXCHAR = 0x7F;
        public const int MAXDWORD = unchecked((int) 0xFFFFFFFF);
        public const int MAXIMUM_ALLOWED = 0x2000000;
        public const int MAXLONG = 0x7FFFFFFF;
        public const int MAXSHORT = 0x7FFF;
        public const int MAXWORD = 0xFFFF;
        public const int MAX_DEFAULTCHAR = 2;
        public const int MAX_LEADBYTES = 12;
        public const int MAX_PATH = 260;
        public const int MB_COMPOSITE = 0x2;
        public const int MB_PRECOMPOSED = 0x1;
        public const int MB_USEGLYPHCHARS = 0x4;
        public const int MENU_EVENT = 0x8;
        public const int MINCHAR = 0x80;
        public const int MINLONG = unchecked((int) 0x80000000);
        public const int MINSHORT = 0x8000;
        public const int MOUSE_MOVED = 0x1;
        public const int MOVEFILE_COPY_ALLOWED = 0x2;
        public const int MOVEFILE_DELAY_UNTIL_REBOOT = 0x4;
        public const int MOVEFILE_REPLACE_EXISTING = 0x1;
        public const int MS_CTS_ON = 0x10;
        public const int MS_DSR_ON = 0x20;
        public const int MS_RING_ON = 0x40;
        public const int MS_RLSD_ON = 0x80;
        public const int NMPWAIT_NOWAIT = 0x1;
        public const int NMPWAIT_USE_DEFAULT_WAIT = 0x0;
        public const int NMPWAIT_WAIT_FOREVER = 0xFFFF;
        public const int NONZEROLHND = (LMEM_MOVEABLE);
        public const int NONZEROLPTR = (LMEM_FIXED);
        public const int NOPARITY = 0;
        public const int NORMAL_PRIORITY_CLASS = 0x20;
        public const int NORM_IGNORECASE = 0x1;
        public const int NORM_IGNORENONSPACE = 0x2;
        public const int NORM_IGNORESYMBOLS = 0x4;
        public const int NO_PROPAGATE_INHERIT_ACE = 0x4;
        public const int NUMLOCK_ON = 0x20;
        public const int OBJECT_INHERIT_ACE = 0x1;
        public const int ODDPARITY = 1;
        public const int OFS_MAXPATHNAME = 128;
        public const int OF_CANCEL = 0x800;
        public const int OF_CREATE = 0x1000;
        public const int OF_DELETE = 0x200;
        public const int OF_EXIST = 0x4000;
        public const int OF_PARSE = 0x100;
        public const int OF_PROMPT = 0x2000;
        public const int OF_READ = 0x0;
        public const int OF_READWRITE = 0x2;
        public const int OF_REOPEN = 0x8000;
        public const int OF_SHARE_COMPAT = 0x0;
        public const int OF_SHARE_DENY_NONE = 0x40;
        public const int OF_SHARE_DENY_READ = 0x30;
        public const int OF_SHARE_DENY_WRITE = 0x20;
        public const int OF_SHARE_EXCLUSIVE = 0x10;
        public const int OF_VERIFY = 0x400;
        public const int OF_WRITE = 0x1;
        public const int ONE5STOPBITS = 1;
        public const int ONESTOPBIT = 0;
        public const int OPEN_ALWAYS = 4;
        public const int OPEN_EXISTING = 3;
        public const int OUTPUT_DEBUG_STRING_EVENT = 8;
        public const int PARITY_EVEN = 0x400;
        public const int PARITY_MARK = 0x800;
        public const int PARITY_NONE = 0x100;
        public const int PARITY_ODD = 0x200;
        public const int PARITY_SPACE = 0x1000;
        public const int PCF_16BITMODE = 0x200;
        public const int PCF_DTRDSR = 0x1;
        public const int PCF_INTTIMEOUTS = 0x80;
        public const int PCF_PARITY_CHECK = 0x8;
        public const int PCF_RLSD = 0x4;
        public const int PCF_RTSCTS = 0x2;
        public const int PCF_SETXCHAR = 0x20;
        public const int PCF_SPECIALCHARS = 0x100;
        public const int PCF_TOTALTIMEOUTS = 0x40;
        public const int PCF_XONXOFF = 0x10;

        public const int PERF_100NSEC_MULTI_TIMER =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_DELTA_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_100NS |
             PERF_MULTI_COUNTER | PERF_DISPLAY_PERCENT);

        public const int PERF_100NSEC_MULTI_TIMER_INV =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_DELTA_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_100NS |
             PERF_MULTI_COUNTER | PERF_INVERSE_COUNTER | PERF_DISPLAY_PERCENT);

        public const int PERF_100NSEC_TIMER =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_100NS | PERF_DELTA_COUNTER |
             PERF_DISPLAY_PERCENT);

        public const int PERF_100NSEC_TIMER_INV =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_100NS | PERF_DELTA_COUNTER |
             PERF_INVERSE_COUNTER | PERF_DISPLAY_PERCENT);

        public const int PERF_AVERAGE_BASE =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_BASE | PERF_DISPLAY_NOSHOW | 0x2);

        public const int PERF_AVERAGE_BULK =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION | PERF_DISPLAY_NOSHOW);

        public const int PERF_AVERAGE_TIMER =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION | PERF_DISPLAY_SECONDS);

        public const int PERF_COUNTER_BASE = 0x30000;

        public const int PERF_COUNTER_BULK_COUNT =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_TICK | PERF_DELTA_COUNTER |
             PERF_DISPLAY_PER_SEC);

        public const int PERF_COUNTER_COUNTER =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_TICK | PERF_DELTA_COUNTER |
             PERF_DISPLAY_PER_SEC);

        public const int PERF_COUNTER_ELAPSED = 0x40000;
        public const int PERF_COUNTER_FRACTION = 0x20000;
        public const int PERF_COUNTER_HISTOGRAM = 0x60000;
        public const int PERF_COUNTER_HISTOGRAM_TYPE = unchecked((int) 0x80000000);

        public const int PERF_COUNTER_MULTI_BASE =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_BASE | PERF_MULTI_COUNTER | PERF_DISPLAY_NOSHOW);

        public const int PERF_COUNTER_MULTI_TIMER =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_DELTA_COUNTER | PERF_TIMER_TICK |
             PERF_MULTI_COUNTER | PERF_DISPLAY_PERCENT);

        public const int PERF_COUNTER_MULTI_TIMER_INV =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_DELTA_COUNTER | PERF_MULTI_COUNTER |
             PERF_TIMER_TICK | PERF_INVERSE_COUNTER | PERF_DISPLAY_PERCENT);

        public const int PERF_COUNTER_NODATA = (PERF_SIZE_ZERO | PERF_DISPLAY_NOSHOW);
        public const int PERF_COUNTER_QUEUELEN = 0x50000;

        public const int PERF_COUNTER_QUEUELEN_TYPE =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_QUEUELEN | PERF_TIMER_TICK | PERF_DELTA_COUNTER |
             PERF_DISPLAY_NO_SUFFIX);

        public const int PERF_COUNTER_RATE = 0x10000;

        public const int PERF_COUNTER_RAWCOUNT =
            (PERF_SIZE_DWORD | PERF_TYPE_NUMBER | PERF_NUMBER_DECIMAL | PERF_DISPLAY_NO_SUFFIX);

        public const int PERF_COUNTER_TEXT =
            (PERF_SIZE_VARIABLE_LEN | PERF_TYPE_TEXT | PERF_TEXT_UNICODE | PERF_DISPLAY_NO_SUFFIX);

        public const int PERF_COUNTER_TIMER =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_TICK | PERF_DELTA_COUNTER |
             PERF_DISPLAY_PERCENT);

        public const int PERF_COUNTER_TIMER_INV =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_TICK | PERF_DELTA_COUNTER |
             PERF_INVERSE_COUNTER | PERF_DISPLAY_PERCENT);

        public const int PERF_COUNTER_VALUE = 0x0;
        public const int PERF_DATA_REVISION = 1;
        public const int PERF_DATA_VERSION = 1;
        public const int PERF_DELTA_BASE = 0x800000;
        public const int PERF_DELTA_COUNTER = 0x400000;
        public const int PERF_DETAIL_ADVANCED = 200;
        public const int PERF_DETAIL_EXPERT = 300;
        public const int PERF_DETAIL_NOVICE = 100;
        public const int PERF_DETAIL_WIZARD = 400;
        public const int PERF_DISPLAY_NOSHOW = 0x40000000;
        public const int PERF_DISPLAY_NO_SUFFIX = 0x0;
        public const int PERF_DISPLAY_PERCENT = 0x20000000;
        public const int PERF_DISPLAY_PER_SEC = 0x10000000;
        public const int PERF_DISPLAY_SECONDS = 0x30000000;

        public const int PERF_ELAPSED_TIME =
            (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_ELAPSED | PERF_OBJECT_TIMER | PERF_DISPLAY_SECONDS);

        public const int PERF_INVERSE_COUNTER = 0x1000000;
        public const int PERF_MULTI_COUNTER = 0x2000000;
        public const int PERF_NO_INSTANCES = -1;
        public const int PERF_NO_UNIQUE_ID = -1;
        public const int PERF_NUMBER_DECIMAL = 0x10000;
        public const int PERF_NUMBER_DEC_1000 = 0x20000;
        public const int PERF_NUMBER_HEX = 0x0;
        public const int PERF_OBJECT_TIMER = 0x200000;

        public const int PERF_RAW_BASE =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_BASE | PERF_DISPLAY_NOSHOW | 0x3);

        public const int PERF_RAW_FRACTION =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION | PERF_DISPLAY_PERCENT);

        public const int PERF_SAMPLE_BASE =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_BASE | PERF_DISPLAY_NOSHOW | 0x1);

        public const int PERF_SAMPLE_COUNTER =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_RATE | PERF_TIMER_TICK | PERF_DELTA_COUNTER |
             PERF_DISPLAY_NO_SUFFIX);

        public const int PERF_SAMPLE_FRACTION =
            (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION | PERF_DELTA_COUNTER | PERF_DELTA_BASE |
             PERF_DISPLAY_PERCENT);

        public const int PERF_SIZE_DWORD = 0x0;
        public const int PERF_SIZE_LARGE = 0x100;
        public const int PERF_SIZE_VARIABLE_LEN = 0x300;
        public const int PERF_SIZE_ZERO = 0x200;
        public const int PERF_TEXT_ASCII = 0x10000;
        public const int PERF_TEXT_UNICODE = 0x0;
        public const int PERF_TIMER_100NS = 0x100000;
        public const int PERF_TIMER_TICK = 0x0;
        public const int PERF_TYPE_COUNTER = 0x400;
        public const int PERF_TYPE_NUMBER = 0x0;
        public const int PERF_TYPE_TEXT = 0x800;
        public const int PERF_TYPE_ZERO = 0xC00;
        public const int PIPE_ACCESS_DUPLEX = 0x3;
        public const int PIPE_ACCESS_INBOUND = 0x1;
        public const int PIPE_ACCESS_OUTBOUND = 0x2;
        public const int PIPE_CLIENT_END = 0x0;
        public const int PIPE_NOWAIT = 0x1;
        public const int PIPE_READMODE_BYTE = 0x0;
        public const int PIPE_READMODE_MESSAGE = 0x2;
        public const int PIPE_SERVER_END = 0x1;
        public const int PIPE_TYPE_BYTE = 0x0;
        public const int PIPE_TYPE_MESSAGE = 0x4;
        public const int PIPE_UNLIMITED_INSTANCES = 255;
        public const int PIPE_WAIT = 0x0;
        public const int PRIVILEGE_SET_ALL_NECESSARY = (1);
        public const int PROCESSOR_ALPHA_21064 = 21064;
        public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;
        public const int PROCESSOR_ARCHITECTURE_INTEL = 0;
        public const int PROCESSOR_ARCHITECTURE_MIPS = 1;
        public const int PROCESSOR_ARCHITECTURE_PPC = 3;
        public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;
        public const int PROCESSOR_INTEL_386 = 386;
        public const int PROCESSOR_INTEL_486 = 486;
        public const int PROCESSOR_INTEL_PENTIUM = 586;
        public const int PROCESSOR_MIPS_R4000 = 4000;
        public const int PROCESS_HEAP_ENTRY_BUSY = 0x4;
        public const int PROCESS_HEAP_ENTRY_DDESHARE = 0x20;
        public const int PROCESS_HEAP_ENTRY_MOVEABLE = 0x10;
        public const int PROCESS_HEAP_REGION = 0x1;
        public const int PROCESS_HEAP_UNCOMMITTED_RANGE = 0x2;
        public const int PROFILE_KERNEL = 0x20000000;
        public const int PROFILE_SERVER = 0x40000000;
        public const int PROFILE_USER = 0x10000000;
        public const int PST_FAX = 0x21;
        public const int PST_LAT = 0x101;
        public const int PST_NETWORK_BRIDGE = 0x100;
        public const int PST_PARALLELPORT = 0x2;
        public const int PST_RS232 = 0x1;
        public const int PST_RS422 = 0x3;
        public const int PST_RS423 = 0x4;
        public const int PST_RS449 = 0x5;
        public const int PST_SCANNER = 0x22;
        public const int PST_TCPIP_TELNET = 0x102;
        public const int PST_UNSPECIFIED = 0x0;
        public const int PST_X25 = 0x103;
        public const int PURGE_RXABORT = 0x2;
        public const int PURGE_RXCLEAR = 0x8;
        public const int PURGE_TXABORT = 0x1;
        public const int PURGE_TXCLEAR = 0x4;
        public const int READ_CONTROL = 0x20000;
        public const int REALTIME_PRIORITY_CLASS = 0x100;
        public const int REG_BINARY = 3;
        public const int REG_CREATED_NEW_KEY = 0x1;
        public const int REG_DWORD = 4;
        public const int REG_DWORD_BIG_ENDIAN = 5;
        public const int REG_DWORD_LITTLE_ENDIAN = 4;
        public const int REG_EXPAND_SZ = 2;
        public const int REG_FULL_RESOURCE_DESCRIPTOR = 9;

        public const int REG_LEGAL_CHANGE_FILTER =
            (REG_NOTIFY_CHANGE_NAME | REG_NOTIFY_CHANGE_ATTRIBUTES | REG_NOTIFY_CHANGE_LAST_SET |
             REG_NOTIFY_CHANGE_SECURITY);

        public const int REG_LEGAL_OPTION =
            (REG_OPTION_RESERVED | REG_OPTION_NON_VOLATILE | REG_OPTION_VOLATILE | REG_OPTION_CREATE_LINK |
             REG_OPTION_BACKUP_RESTORE);

        public const int REG_LINK = 6;
        public const int REG_MULTI_SZ = 7;
        public const int REG_NONE = 0;
        public const int REG_NOTIFY_CHANGE_ATTRIBUTES = 0x2;
        public const int REG_NOTIFY_CHANGE_LAST_SET = 0x4;
        public const int REG_NOTIFY_CHANGE_NAME = 0x1;
        public const int REG_NOTIFY_CHANGE_SECURITY = 0x8;
        public const int REG_OPENED_EXISTING_KEY = 0x2;
        public const int REG_OPTION_BACKUP_RESTORE = 4;
        public const int REG_OPTION_CREATE_LINK = 2;
        public const int REG_OPTION_NON_VOLATILE = 0;
        public const int REG_OPTION_RESERVED = 0;
        public const int REG_OPTION_VOLATILE = 1;
        public const int REG_REFRESH_HIVE = 0x2;
        public const int REG_RESOURCE_LIST = 8;
        public const int REG_RESOURCE_REQUIREMENTS_LIST = 10;
        public const int REG_SZ = 1;
        public const int REG_WHOLE_HIVE_VOLATILE = 0x1;
        public const int RESETDEV = 7;
        public const int RIGHTMOST_BUTTON_PRESSED = 0x2;
        public const int RIGHT_ALT_PRESSED = 0x1;
        public const int RIGHT_CTRL_PRESSED = 0x4;
        public const int RIP_EVENT = 9;
        public const int RTS_CONTROL_DISABLE = 0x0;
        public const int RTS_CONTROL_ENABLE = 0x1;
        public const int RTS_CONTROL_HANDSHAKE = 0x2;
        public const int RTS_CONTROL_TOGGLE = 0x3;
        public const int RT_ACCELERATOR = 9;
        public const int RT_BITMAP = 2;
        public const int RT_CURSOR = 1;
        public const int RT_DIALOG = 5;
        public const int RT_FONT = 8;
        public const int RT_FONTDIR = 7;
        public const int RT_ICON = 3;
        public const int RT_MENU = 4;
        public const int RT_RCDATA = 10;
        public const int RT_STRING = 6;
        public const int SCROLLLOCK_ON = 0x40;
        public const int SCS_32BIT_BINARY = 0;
        public const int SCS_DOS_BINARY = 1;
        public const int SCS_OS216_BINARY = 5;
        public const int SCS_PIF_BINARY = 3;
        public const int SCS_POSIX_BINARY = 4;
        public const int SCS_WOW_BINARY = 2;

        public const int SC_MANAGER_ALL_ACCESS =
            (STANDARD_RIGHTS_REQUIRED | SC_MANAGER_CONNECT | SC_MANAGER_CREATE_SERVICE | SC_MANAGER_ENUMERATE_SERVICE |
             SC_MANAGER_LOCK | SC_MANAGER_QUERY_LOCK_STATUS | SC_MANAGER_MODIFY_BOOT_CONFIG);

        public const int SC_MANAGER_CONNECT = 0x1;
        public const int SC_MANAGER_CREATE_SERVICE = 0x2;
        public const int SC_MANAGER_ENUMERATE_SERVICE = 0x4;
        public const int SC_MANAGER_LOCK = 0x8;
        public const int SC_MANAGER_MODIFY_BOOT_CONFIG = 0x20;
        public const int SC_MANAGER_QUERY_LOCK_STATUS = 0x10;

        public const int SECTION_ALL_ACCESS =
            STANDARD_RIGHTS_REQUIRED | SECTION_QUERY | SECTION_MAP_WRITE | SECTION_MAP_READ | SECTION_MAP_EXECUTE |
            SECTION_EXTEND_SIZE;

        public const int SECTION_EXTEND_SIZE = 0x10;
        public const int SECTION_MAP_EXECUTE = 0x8;
        public const int SECTION_MAP_READ = 0x4;
        public const int SECTION_MAP_WRITE = 0x2;
        public const int SECTION_QUERY = 0x1;
        public const int SECURITY_ANONYMOUS_LOGON_RID = 0x7;
        public const int SECURITY_BATCH_RID = 0x3;
        public const int SECURITY_BUILTIN_DOMAIN_RID = 0x20;
        public const int SECURITY_CONTEXT_TRACKING = 0x40000;
        public const int SECURITY_CREATOR_GROUP_RID = 0x1;
        public const int SECURITY_CREATOR_OWNER_RID = 0x0;
        public const int SECURITY_DESCRIPTOR_MIN_LENGTH = (20);
        public const int SECURITY_DESCRIPTOR_REVISION = (1);
        public const int SECURITY_DESCRIPTOR_REVISION1 = (1);
        public const int SECURITY_DIALUP_RID = 0x1;
        public const int SECURITY_EFFECTIVE_ONLY = 0x80000;
        public const int SECURITY_INTERACTIVE_RID = 0x4;
        public const int SECURITY_LOCAL_RID = 0x0;
        public const int SECURITY_LOCAL_SYSTEM_RID = 0x12;
        public const int SECURITY_LOGON_IDS_RID = 0x5;
        public const int SECURITY_NETWORK_RID = 0x2;
        public const int SECURITY_NT_NON_UNIQUE = 0x15;
        public const int SECURITY_NULL_RID = 0x0;
        public const int SECURITY_SERVICE_RID = 0x6;
        public const int SECURITY_SQOS_PRESENT = 0x100000;
        public const int SECURITY_VALID_SQOS_FLAGS = 0x1F0000;
        public const int SECURITY_WORLD_RID = 0x0;
        public const int SEM_FAILCRITICALERRORS = 0x1;
        public const int SEM_NOGPFAULTERRORBOX = 0x2;
        public const int SEM_NOOPENFILEERRORBOX = 0x8000;
        public const int SERVICE_ACCEPT_PAUSE_CONTINUE = 0x2;
        public const int SERVICE_ACCEPT_SHUTDOWN = 0x4;
        public const int SERVICE_ACCEPT_STOP = 0x1;
        public const int SERVICE_ACTIVE = 0x1;

        public const int SERVICE_ALL_ACCESS =
            (STANDARD_RIGHTS_REQUIRED | SERVICE_QUERY_CONFIG | SERVICE_CHANGE_CONFIG | SERVICE_QUERY_STATUS |
             SERVICE_ENUMERATE_DEPENDENTS | SERVICE_START | SERVICE_STOP | SERVICE_PAUSE_CONTINUE | SERVICE_INTERROGATE |
             SERVICE_USER_DEFINED_CONTROL);

        public const int SERVICE_CHANGE_CONFIG = 0x2;
        public const int SERVICE_CONTINUE_PENDING = 0x5;
        public const int SERVICE_CONTROL_CONTINUE = 0x3;
        public const int SERVICE_CONTROL_INTERROGATE = 0x4;
        public const int SERVICE_CONTROL_PAUSE = 0x2;
        public const int SERVICE_CONTROL_SHUTDOWN = 0x5;
        public const int SERVICE_CONTROL_STOP = 0x1;
        public const int SERVICE_ENUMERATE_DEPENDENTS = 0x8;
        public const int SERVICE_INACTIVE = 0x2;
        public const int SERVICE_INTERROGATE = 0x80;
        public const int SERVICE_NO_CHANGE = 0xFFFF;
        public const int SERVICE_PAUSED = 0x7;
        public const int SERVICE_PAUSE_CONTINUE = 0x40;
        public const int SERVICE_PAUSE_PENDING = 0x6;
        public const int SERVICE_QUERY_CONFIG = 0x1;
        public const int SERVICE_QUERY_STATUS = 0x4;
        public const int SERVICE_RUNNING = 0x4;
        public const int SERVICE_START = 0x10;
        public const int SERVICE_START_PENDING = 0x2;
        public const int SERVICE_STATE_ALL = (SERVICE_ACTIVE | SERVICE_INACTIVE);
        public const int SERVICE_STOP = 0x20;
        public const int SERVICE_STOPPED = 0x1;
        public const int SERVICE_STOP_PENDING = 0x3;
        public const int SERVICE_USER_DEFINED_CONTROL = 0x100;
        public const int SETBREAK = 8;
        public const int SETDTR = 5;
        public const int SETRTS = 3;
        public const int SETXOFF = 1;
        public const int SETXON = 2;
        public const int SET_TAPE_DRIVE_INFORMATION = 1;
        public const int SET_TAPE_MEDIA_INFORMATION = 0;
        public const int SE_DACL_DEFAULTED = 0x8;
        public const int SE_DACL_PRESENT = 0x4;
        public const int SE_GROUP_DEFAULTED = 0x2;
        public const int SE_GROUP_ENABLED = 0x4;
        public const int SE_GROUP_ENABLED_BY_DEFAULT = 0x2;
        public const int SE_GROUP_LOGON_ID = unchecked((int) 0xC0000000);
        public const int SE_GROUP_MANDATORY = 0x1;
        public const int SE_GROUP_OWNER = 0x8;
        public const int SE_OWNER_DEFAULTED = 0x1;
        public const int SE_PRIVILEGE_ENABLED = 0x2;
        public const int SE_PRIVILEGE_ENABLED_BY_DEFAULT = 0x1;
        public const int SE_PRIVILEGE_USED_FOR_ACCESS = unchecked((int) 0x80000000);
        public const int SE_SACL_DEFAULTED = 0x20;
        public const int SE_SACL_PRESENT = 0x10;
        public const int SE_SELF_RELATIVE = 0x8000;
        public const int SHIFT_PRESSED = 0x10;
        public const int SHUTDOWN_NORETRY = 0x1;
        public const int SID_MAX_SUB_AUTHORITIES = (15);
        public const int SID_RECOMMENDED_SUB_AUTHORITIES = (1);
        public const int SID_REVISION = (1);
        public const int SLE_ERROR = 0x1;
        public const int SLE_MINORERROR = 0x2;
        public const int SLE_WARNING = 0x3;
        public const int SORT_CHINESE_BIG5 = 0x0;
        public const int SORT_CHINESE_UNICODE = 0x1;
        public const int SORT_DEFAULT = 0x0;
        public const int SORT_JAPANESE_UNICODE = 0x1;
        public const int SORT_JAPANESE_XJIS = 0x0;
        public const int SORT_KOREAN_KSC = 0x0;
        public const int SORT_KOREAN_UNICODE = 0x1;
        public const int SORT_STRINGSORT = 0x1000;
        public const int SPACEPARITY = 4;
        public const int SPECIFIC_RIGHTS_ALL = 0xFFFF;
        public const int SP_BAUD = 0x2;
        public const int SP_DATABITS = 0x4;
        public const int SP_HANDSHAKING = 0x10;
        public const int SP_PARITY = 0x1;
        public const int SP_PARITY_CHECK = 0x20;
        public const int SP_RLSD = 0x40;
        public const int SP_SERIALCOMM = 0x1;
        public const int SP_STOPBITS = 0x8;
        public const int STANDARD_RIGHTS_ALL = 0x1F0000;
        public const int STANDARD_RIGHTS_EXECUTE = (READ_CONTROL);
        public const int STANDARD_RIGHTS_READ = (READ_CONTROL);
        public const int STANDARD_RIGHTS_REQUIRED = 0xF0000;
        public const int STANDARD_RIGHTS_WRITE = (READ_CONTROL);
        public const int STARTF_FORCEOFFFEEDBACK = 0x80;
        public const int STARTF_FORCEONFEEDBACK = 0x40;
        public const int STARTF_RUNFULLSCREEN = 0x20;
        public const int STARTF_USECOUNTCHARS = 0x8;
        public const int STARTF_USEFILLATTRIBUTE = 0x10;
        public const int STARTF_USEPOSITION = 0x4;
        public const int STARTF_USESHOWWINDOW = 0x1;
        public const int STARTF_USESIZE = 0x2;
        public const int STARTF_USESTDHANDLES = 0x100;
        public const int STD_ERROR_HANDLE = -12;
        public const int STD_INPUT_HANDLE = -10;
        public const int STD_OUTPUT_HANDLE = -11;
        public const int STOPBITS_10 = 0x1;
        public const int STOPBITS_15 = 0x2;
        public const int STOPBITS_20 = 0x4;
        public const int STREAM_CONTAINS_SECURITY = 0x2;
        public const int STREAM_MODIFIED_WHEN_READ = 0x1;
        public const int SUBLANG_CHINESE_HONGKONG = 0x3;
        public const int SUBLANG_CHINESE_SIMPLIFIED = 0x2;
        public const int SUBLANG_CHINESE_SINGAPORE = 0x4;
        public const int SUBLANG_CHINESE_TRADITIONAL = 0x1;
        public const int SUBLANG_DEFAULT = 0x1;
        public const int SUBLANG_DUTCH = 0x1;
        public const int SUBLANG_DUTCH_BELGIAN = 0x2;
        public const int SUBLANG_ENGLISH_AUS = 0x3;
        public const int SUBLANG_ENGLISH_CAN = 0x4;
        public const int SUBLANG_ENGLISH_EIRE = 0x6;
        public const int SUBLANG_ENGLISH_NZ = 0x5;
        public const int SUBLANG_ENGLISH_UK = 0x2;
        public const int SUBLANG_ENGLISH_US = 0x1;
        public const int SUBLANG_FRENCH = 0x1;
        public const int SUBLANG_FRENCH_BELGIAN = 0x2;
        public const int SUBLANG_FRENCH_CANADIAN = 0x3;
        public const int SUBLANG_FRENCH_SWISS = 0x4;
        public const int SUBLANG_GERMAN = 0x1;
        public const int SUBLANG_GERMAN_AUSTRIAN = 0x3;
        public const int SUBLANG_GERMAN_SWISS = 0x2;
        public const int SUBLANG_ITALIAN = 0x1;
        public const int SUBLANG_ITALIAN_SWISS = 0x2;
        public const int SUBLANG_NEUTRAL = 0x0;
        public const int SUBLANG_NORWEGIAN_BOKMAL = 0x1;
        public const int SUBLANG_NORWEGIAN_NYNORSK = 0x2;
        public const int SUBLANG_PORTUGUESE = 0x2;
        public const int SUBLANG_PORTUGUESE_BRAZILIAN = 0x1;
        public const int SUBLANG_SPANISH = 0x1;
        public const int SUBLANG_SPANISH_MEXICAN = 0x2;
        public const int SUBLANG_SPANISH_MODERN = 0x3;
        public const int SUBLANG_SYS_DEFAULT = 0x2;
        public const int SUCCESSFUL_ACCESS_ACE_FLAG = 0x40;
        public const int SYNCHRONIZE = 0x100000;
        public const int SYSTEM_ALARM_ACE_TYPE = 0x3;
        public const int SYSTEM_AUDIT_ACE_TYPE = 0x2;
        public const int S_ALLTHRESHOLD = 2;
        public const int S_LEGATO = 1;
        public const int S_NORMAL = 0;
        public const int S_PERIOD1024 = 1;
        public const int S_PERIOD2048 = 2;
        public const int S_PERIOD512 = 0;
        public const int S_PERIODVOICE = 3;
        public const int S_QUEUEEMPTY = 0;
        public const int S_SERBDNT = (-5);
        public const int S_SERDCC = (-7);
        public const int S_SERDDR = (-14);
        public const int S_SERDFQ = (-13);
        public const int S_SERDLN = (-6);
        public const int S_SERDMD = (-10);
        public const int S_SERDPT = (-12);
        public const int S_SERDSH = (-11);
        public const int S_SERDSR = (-15);
        public const int S_SERDST = (-16);
        public const int S_SERDTP = (-8);
        public const int S_SERDVL = (-9);
        public const int S_SERDVNA = (-1);
        public const int S_SERMACT = (-3);
        public const int S_SEROFM = (-2);
        public const int S_SERQFUL = (-4);
        public const int S_STACCATO = 2;
        public const int S_THRESHOLD = 1;
        public const int S_WHITE1024 = 5;
        public const int S_WHITE2048 = 6;
        public const int S_WHITE512 = 4;
        public const int S_WHITEVOICE = 7;
        public const int SecurityAnonymous = 1;
        public const int SecurityIdentification = 2;
        public const int SidTypeAlias = 4;
        public const int SidTypeDeletedAccount = 6;
        public const int SidTypeDomain = 3;
        public const int SidTypeGroup = 2;
        public const int SidTypeInvalid = 7;
        public const int SidTypeUnknown = 8;
        public const int SidTypeUser = 1;
        public const int SidTypeWellKnownGroup = 5;
        public const int TC_GP_TRAP = 2;
        public const int TC_HARDERR = 1;
        public const int TC_NORMAL = 0;
        public const int TC_SIGNAL = 3;
        public const int TF_FORCEDRIVE = 0x80;
        public const int THREAD_BASE_PRIORITY_IDLE = -15;
        public const int THREAD_BASE_PRIORITY_LOWRT = 15;
        public const int THREAD_BASE_PRIORITY_MAX = 2;
        public const int THREAD_BASE_PRIORITY_MIN = -2;
        public const int THREAD_PRIORITY_ABOVE_NORMAL = (THREAD_PRIORITY_HIGHEST - 1);
        public const int THREAD_PRIORITY_BELOW_NORMAL = (THREAD_PRIORITY_LOWEST + 1);
        public const int THREAD_PRIORITY_ERROR_RETURN = (MAXLONG);
        public const int THREAD_PRIORITY_HIGHEST = THREAD_BASE_PRIORITY_MAX;
        public const int THREAD_PRIORITY_IDLE = THREAD_BASE_PRIORITY_IDLE;
        public const int THREAD_PRIORITY_LOWEST = THREAD_BASE_PRIORITY_MIN;
        public const int THREAD_PRIORITY_NORMAL = 0;
        public const int THREAD_PRIORITY_TIME_CRITICAL = THREAD_BASE_PRIORITY_LOWRT;
        public const int TIME_FORCE24HOURFORMAT = 0x8;
        public const int TIME_NOMINUTESORSECONDS = 0x1;
        public const int TIME_NOSECONDS = 0x2;
        public const int TIME_NOTIMEMARKER = 0x4;
        public const int TLS_OUT_OF_INDEXES = 0xFFFF;
        public const int TRUNCATE_EXISTING = 5;
        public const int TWOSTOPBITS = 2;
        public const int TokenDefaultDacl = 6;
        public const int TokenGroups = 2;
        public const int TokenImpersonationLevel = 9;
        public const int TokenOwner = 4;
        public const int TokenPrimaryGroup = 5;
        public const int TokenPrivileges = 3;
        public const int TokenSource = 7;
        public const int TokenStatistics = 10;
        public const int TokenType = 8;
        public const int TokenUser = 1;
        public const int UNLOAD_DLL_DEBUG_EVENT = 7;
        public const int VALID_INHERIT_FLAGS = 0xF;
        public const int VER_PLATFORM_WIN32_NT = 2;
        public const int VER_PLATFORM_WIN32_WINDOWS = 1;
        public const int VER_PLATFORM_WIN32s = 0;
        public const int WC_COMPOSITECHECK = 0x200;
        public const int WC_DEFAULTCHAR = 0x40;
        public const int WC_DEFAULTCHECK = 0x100;
        public const int WC_DISCARDNS = 0x10;
        public const int WC_SEPCHARS = 0x20;
        public const int WINDOW_BUFFER_SIZE_EVENT = 0x4;
        public const int WRITE_DAC = 0x40000;
        public const int WRITE_OWNER = 0x80000;
        public const int mouse_eventC = 0x2;
        public const string SC_GROUP_IDENTIFIER = "+";
        public const string SERVICES_ACTIVE_DATABASE = "ServicesActive";
        public const string SERVICES_FAILED_DATABASE = "ServicesFailed";
        public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";
        public const string SE_AUDIT_NAME = "SeAuditPrivilege";
        public const string SE_BACKUP_NAME = "SeBackupPrivilege";
        public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";
        public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";
        public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";
        public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";
        public const string SE_DEBUG_NAME = "SeDebugPrivilege";
        public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";
        public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";
        public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";
        public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";
        public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";
        public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";
        public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";
        public const string SE_RESTORE_NAME = "SeRestorePrivilege";
        public const string SE_SECURITY_NAME = "SeSecurityPrivilege";
        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";
        public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";
        public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";
        public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";
        public const string SE_TCB_NAME = "SeTcbPrivilege";
        public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

        [DllImport("kernel32")]
        public static extern void OutputDebugString(string lpszOutputString);

        [DllImport("KERNEL32")]
        public static extern int ConvertDefaultLocale(int Locale);

        [DllImport("KERNEL32")]
        public static extern int EnumDateFormats(int lpDateFmtEnumProc, int Locale, int dwFlags);

        [DllImport("KERNEL32")]
        public static extern int EnumSystemCodePages(int lpCodePageEnumProc, int dwFlags);

        [DllImport("KERNEL32")]
        public static extern int EnumSystemLocales(int lpLocaleEnumProc, int dwFlags);

        [DllImport("KERNEL32")]
        public static extern int EnumTimeFormats(int lpTimeFmtEnumProc, int Locale, int dwFlags);

        [DllImport("KERNEL32")]
        public static extern int GetThreadLocale();

        [DllImport("KERNEL32")]
        public static extern int IsValidLocale(int Locale, int dwFlags);

        [DllImport("KERNEL32")]
        public static extern void ZeroMemory(IntPtr dest, int numBytes);

        [DllImport("kernel32")]
        public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);

        [DllImport("kernel32")]
        public static extern int AllocConsole();

        [DllImport("kernel32")]
        public static extern int BackupRead(IntPtr hFile, Byte lpBuffer, int nNumberOfBytesToRead,
                                            ref int lpNumberOfBytesRead, int bAbort, int bProcessSecurity,
                                            IntPtr lpContext);

        [DllImport("kernel32")]
        public static extern int BackupSeek(IntPtr hFile, int dwLowBytesToSeek, int dwHighBytesToSeek,
                                            ref int lpdwLowByteSeeked, ref int lpdwHighByteSeeked, ref int lpContext);

        [DllImport("kernel32")]
        public static extern int BackupWrite(IntPtr hFile, Byte lpBuffer, int nNumberOfBytesToWrite,
                                             ref int lpNumberOfBytesWritten, int bAbort, int bProcessSecurity,
                                             ref int lpContext);

        [DllImport("kernel32")]
        public static extern int Beep(int dwFreq, int dwDuration);

        [DllImport("kernel32")]
        public static extern int BeginUpdateResource(string pFileName, int bDeleteExistingResources);

        [DllImport("kernel32")]
        public static extern int BuildCommDCB(string lpDef, ref DCB lpDCB);

        [DllImport("kernel32")]
        public static extern int BuildCommDCBAndTimeouts(string lpDef, ref DCB lpDCB, ref COMMTIMEOUTS lpCommTimeouts);

        [DllImport("kernel32")]
        public static extern int CallNamedPipe(string lpNamedPipeName, IntPtr lpInBuffer, int nInBufferSize,
                                               IntPtr lpOutBuffer, int nOutBufferSize, ref int lpBytesRead, int nTimeOut);

        [DllImport("kernel32")]
        public static extern int ClearCommBreak(int nCid);

        [DllImport("kernel32")]
        public static extern int ClearCommError(IntPtr hFile, ref int lpErrors, ref COMSTAT lpStat);

        [DllImport("kernel32")]
        public static extern int CloseHandle(IntPtr hObject);

        [DllImport("kernel32")]
        public static extern int CommConfigDialog(string lpszName, IntPtr hwnd, ref COMMCONFIG lpCC);

        [DllImport("kernel32")]
        public static extern int CompareFileTime(ref FILETIME lpFileTime1, ref FILETIME lpFileTime2);

        [DllImport("kernel32")]
        public static extern int CompareString(int Locale, int dwCmpFlags, string lpString1, int cchCount1,
                                               string lpString2, int cchCount2);

        [DllImport("kernel32")]
        public static extern int ConnectNamedPipe(IntPtr hNamedPipe, ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int ContinueDebugEvent(int dwProcessId, int dwThreadId, int dwContinueStatus);

        [DllImport("kernel32")]
        public static extern int CopyFile(string lpExistingFileName, string lpNewFileName, int bFailIfExists);

        [DllImport("kernel32")]
        public static extern int CreateConsoleScreenBuffer(int dwDesiredAccess, int dwShareMode,
                                                           ref SECURITY_ATTRIBUTES lpSecurityAttributes, int dwFlags,
                                                           IntPtr lpScreenBufferData);

        [DllImport("kernel32")]
        public static extern int CreateDirectory(string lpPathName, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport("kernel32")]
        public static extern int CreateDirectoryEx(string lpTemplateDirectory, string lpNewDirectory,
                                                   ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport("kernel32")]
        public static extern int CreateEvent(ref SECURITY_ATTRIBUTES lpEventAttributes, int bManualReset,
                                             int bInitialState, string lpName);

        [DllImport("kernel32")]
        public static extern int CreateFile(string lpFileName, int dwDesiredAccess, int dwShareMode,
                                            ref SECURITY_ATTRIBUTES lpSecurityAttributes, int dwCreationDisposition,
                                            int dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32")]
        public static extern int CreateFileMapping(IntPtr hFile, ref SECURITY_ATTRIBUTES lpFileMappigAttributes,
                                                   int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow,
                                                   string lpName);

        [DllImport("kernel32")]
        public static extern int CreateIoCompletionPort(int FileHandle, int ExistingCompletionPort, int CompletionKey,
                                                        int NumberOfConcurrentThreads);

        [DllImport("kernel32")]
        public static extern int CreateMailslot(string lpName, int nMaxMessageSize, int lReadTimeout,
                                                ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport("kernel32")]
        public static extern int CreateMutex(ref SECURITY_ATTRIBUTES lpMutexAttributes, int bInitialOwner, string lpName);

        [DllImport("kernel32")]
        public static extern int CreateNamedPipe(string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances,
                                                 int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut,
                                                 ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport("kernel32")]
        public static extern int CreatePipe(int phReadPipe, int phWritePipe, ref SECURITY_ATTRIBUTES lpPipeAttributes,
                                            int nSize);

        [DllImport("kernel32")]
        public static extern int CreateProcess(string lpApplicationName, string lpCommandLine,
                                               ref SECURITY_ATTRIBUTES lpProcessAttributes,
                                               ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles,
                                               int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDriectory,
                                               ref STARTUPINFO lpStartupInfo,
                                               ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport("kernel32")]
        public static extern int CreateRemoteThread(IntPtr hProcess, ref SECURITY_ATTRIBUTES lpThreadAttributes,
                                                    int dwStackSize, ref int lpStartAddress, IntPtr lpParameter,
                                                    int dwCreationFlags, ref int lpThreadId);

        [DllImport("kernel32")]
        public static extern int CreateSemaphore(ref SECURITY_ATTRIBUTES lpSemaphoreAttributes, int lInitialCount,
                                                 int lMaximumCount, string lpName);

        [DllImport("kernel32")]
        public static extern int CreateTapePartition(IntPtr hDevice, int dwPartitionMethod, int dwCount, int dwSize);

        [DllImport("kernel32")]
        public static extern int CreateThread(ref SECURITY_ATTRIBUTES lpThreadAttributes, int dwStackSize,
                                              ref int lpStartAddress, IntPtr lpParameter, int dwCreationFlags,
                                              ref int lpThreadId);

        [DllImport("kernel32")]
        public static extern int DebugActiveProcess(int dwProcessId);

        [DllImport("kernel32")]
        public static extern int DefineDosDevice(int dwFlags, string lpDeviceName, string lpTargetPath);

        [DllImport("kernel32")]
        public static extern int DeleteFile(string lpFileName);

        [DllImport("kernel32")]
        public static extern int DeviceIoControl(IntPtr hDevice, int dwIoControlCode, IntPtr lpInBuffer,
                                                 int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize,
                                                 ref int lpBytesReturned, ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int DisableThreadLibraryCalls(IntPtr hLibModule);

        [DllImport("kernel32")]
        public static extern int DisconnectNamedPipe(IntPtr hNamedPipe);

        [DllImport("kernel32")]
        public static extern int DosDateTimeToFileTime(int wFatDate, int wFatTime, ref FILETIME lpFileTime);

        [DllImport("kernel32")]
        public static extern int DuplicateHandle(IntPtr hSourceProcessHandle, IntPtr hSourceHandle,
                                                 IntPtr hTargetProcessHandle, ref int lpTargetHandle,
                                                 int dwDesiredAccess, int bInheritHandle, int dwOptions);

        [DllImport("kernel32")]
        public static extern int EndUpdateResource(IntPtr hUpdate, int fDiscard);

        [DllImport("kernel32")]
        public static extern int EnumCalendarInfo(int lpCalInfoEnumProc, int Locale, int Calendar, int CalType);

        [DllImport("kernel32")]
        public static extern int EnumResourceLanguages(IntPtr hModule, string lpType, string lpName, ref int lpEnumFunc,
                                                       int lParam);

        [DllImport("kernel32")]
        public static extern int EnumResourceNames(IntPtr hModule, string lpType, ref int lpEnumFunc, int lParam);

        [DllImport("kernel32")]
        public static extern int EnumResourceTypes(IntPtr hModule, ref int lpEnumFunc, int lParam);

        [DllImport("kernel32")]
        public static extern int EraseTape(IntPtr hDevice, int dwEraseType, int bimmediate);

        [DllImport("kernel32")]
        public static extern int EscapeCommFunction(int nCid, int nFunc);

        [DllImport("kernel32")]
        public static extern int ExpandEnvironmentStrings(string lpSrc, string lpDst, int nSize);

        [DllImport("kernel32")]
        public static extern int FileTimeToDosDateTime(ref FILETIME lpFileTime, ref int lpFatDate, ref int lpFatTime);

        [DllImport("kernel32")]
        public static extern int FileTimeToLocalFileTime(ref FILETIME lpFileTime, ref FILETIME lpLocalFileTime);

        [DllImport("kernel32")]
        public static extern int FileTimeToSystemTime(ref FILETIME lpFileTime, ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32")]
        public static extern int FillConsoleOutputAttribute(IntPtr hConsoleOutput, int wAttribute, int nLength,
                                                            COORD dwWriteCoord, ref int lpNumberOfAttrsWritten);

        [DllImport("kernel32")]
        public static extern int FillConsoleOutputCharacter(IntPtr hConsoleOutput, Byte cCharacter, int nLength,
                                                            COORD dwWriteCoord, ref int lpNumberOfCharsWritten);

        [DllImport("kernel32")]
        public static extern int FindClose(IntPtr hFindFile);

        [DllImport("kernel32")]
        public static extern int FindCloseChangeNotification(IntPtr hChangeHandle);

        [DllImport("kernel32")]
        public static extern int FindFirstChangeNotification(string lpPathName, int bWatchSubtree, int dwNotifyFilter);

        [DllImport("kernel32")]
        public static extern int FindFirstFile(string lpFileName, WIN32_FIND_DATA lpFindFileData);

        [DllImport("kernel32")]
        public static extern int FindNextChangeNotification(IntPtr hChangeHandle);

        [DllImport("kernel32")]
        public static extern int FindNextFile(IntPtr hFindFile, WIN32_FIND_DATA lpFindFileData);

        [DllImport("kernel32")]
        public static extern int FindResource(IntPtr hInstance, string lpName, string lpType);

        [DllImport("kernel32")]
        public static extern int FindResourceEx(IntPtr hModule, string lpType, string lpName, int wLanguage);

        [DllImport("kernel32")]
        public static extern int FlushConsoleInputBuffer(IntPtr hConsoleInput);

        [DllImport("kernel32")]
        public static extern int FlushFileBuffers(IntPtr hFile);

        [DllImport("kernel32")]
        public static extern int FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, int dwSize);

        [DllImport("kernel32")]
        public static extern int FlushViewOfFile(IntPtr lpBaseAddress, int dwNumberOfBytesToFlush);

        [DllImport("kernel32")]
        public static extern int FoldString(int dwMapFlags, string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);

        [DllImport("kernel32")]
        public static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId,
                                               string lpBuffer, int nSize, int Arguments);

        [DllImport("kernel32")]
        public static extern int FreeConsole();

        [DllImport("kernel32")]
        public static extern int FreeEnvironmentStrings(string lpsz);

        [DllImport("kernel32")]
        public static extern int FreeLibrary(IntPtr hLibModule);

        [DllImport("kernel32")]
        public static extern int FreeResource(IntPtr hResData);

        [DllImport("kernel32")]
        public static extern int GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);

        [DllImport("kernel32")]
        public static extern int GetACP();

        [DllImport("kernel32")]
        public static extern int GetBinaryType(string lpApplicationName, ref int lpBinaryType);

        [DllImport("kernel32")]
        public static extern int GetCPInfo(int CodePage, ref CPINFO lpCPInfo);

        [DllImport("kernel32")]
        public static extern int GetCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, ref int lpdwSize);

        [DllImport("kernel32")]
        public static extern int GetCommMask(IntPtr hFile, ref int lpEvtMask);

        [DllImport("kernel32")]
        public static extern int GetCommModemStatus(IntPtr hFile, ref int lpModemStat);

        [DllImport("kernel32")]
        public static extern int GetCommProperties(IntPtr hFile, ref COMMPROP lpCommProp);

        [DllImport("kernel32")]
        public static extern int GetCommState(int nCid, ref DCB lpDCB);

        [DllImport("kernel32")]
        public static extern int GetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);

        [DllImport("kernel32")]
        public static extern int GetCommandLine();

        [DllImport("kernel32")]
        public static extern int GetCompressedFileSize(string lpFileName, ref int lpFileSizeHigh);

        [DllImport("kernel32")]
        public static extern int GetComputerName(string lpBuffer, int nSize);

        [DllImport("kernel32")]
        public static extern int GetConsoleCP();

        [DllImport("kernel32")]
        public static extern int GetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        [DllImport("kernel32")]
        public static extern int GetConsoleMode(IntPtr hConsoleHandle, ref int lpMode);

        [DllImport("kernel32")]
        public static extern int GetConsoleOutputCP();

        [DllImport("kernel32")]
        public static extern int GetConsoleScreenBufferInfo(IntPtr hConsoleOutput,
                                                            ref CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);

        [DllImport("kernel32")]
        public static extern int GetConsoleTitle(string lpConsoleTitle, int nSize);

        [DllImport("kernel32")]
        public static extern int GetCurrencyFormat(int Locale, int dwFlags, string lpValue, ref CURRENCYFMT lpFormat,
                                                   string lpCurrencyStr, int cchCurrency);

        [DllImport("kernel32")]
        public static extern int GetCurrentDirectory(int nBufferLength, string lpBuffer);

        [DllImport("kernel32")]
        public static extern int GetCurrentProcess();

        [DllImport("kernel32")]
        public static extern int GetCurrentProcessId();

        [DllImport("kernel32")]
        public static extern int GetCurrentThread();

        [DllImport("kernel32")]
        public static extern int GetCurrentThreadId();

        [DllImport("kernel32")]
        public static extern int GetCurrentTime();

        [DllImport("kernel32")]
        public static extern int GetDateFormat(int Locale, int dwFlags, ref SYSTEMTIME lpDate, string lpFormat,
                                               string lpDateStr, int cchDate);

        [DllImport("kernel32")]
        public static extern int GetDefaultCommConfig(string lpszName, ref COMMCONFIG lpCC, ref int lpdwSize);

        [DllImport("kernel32")]
        public static extern int GetDiskFreeSpace(string lpRootPathName, ref int lpSectorsPerCluster,
                                                  ref int lpBytesPerSector, ref int lpNumberOfFreeClusters,
                                                  ref int lpTotalNumberOfClusters);

        [DllImport("kernel32")]
        public static extern int GetDriveType(string nDrive);

        [DllImport("kernel32")]
        public static extern int GetEnvironmentVariable(string lpName, string lpBuffer, int nSize);

        [DllImport("kernel32")]
        public static extern int GetExitCodeProcess(IntPtr hProcess, ref int lpExitCode);

        [DllImport("kernel32")]
        public static extern int GetExitCodeThread(IntPtr hThread, ref int lpExitCode);

        [DllImport("kernel32")]
        public static extern int GetFileAttributes(string lpFileName);

        [DllImport("kernel32")]
        public static extern int GetFileInformationByHandle(IntPtr hFile,
                                                            ref BY_HANDLE_FILE_INFORMATION lpFileInformation);

        [DllImport("kernel32")]
        public static extern int GetFileSize(IntPtr hFile, ref int lpFileSizeHigh);

        [DllImport("kernel32")]
        public static extern int GetFileTime(IntPtr hFile, ref FILETIME lpCreationTime, ref FILETIME lpLastAccessTime,
                                             ref FILETIME lpLastWriteTime);

        [DllImport("kernel32")]
        public static extern int GetFileType(IntPtr hFile);

        [DllImport("kernel32")]
        public static extern int GetFullPathName(string lpFileName, int nBufferLength, StringBuilder lpBuffer,
                                                 string lpFilePart);

        [DllImport("kernel32")]
        public static extern int GetHandleInformation(IntPtr hObject, ref int lpdwFlags);

        [DllImport("kernel32")]
        public static extern int GetLastError();

        [DllImport("kernel32")]
        public static extern int GetLocaleInfo(int Locale, int LCType, string lpLCData, int cchData);

        [DllImport("kernel32")]
        public static extern int GetLogicalDriveStrings(int nBufferLength, StringBuilder lpBuffer);

        [DllImport("kernel32")]
        public static extern int GetLogicalDrives();

        [DllImport("kernel32")]
        public static extern int GetMailslotInfo(IntPtr hMailslot, ref int lpMaxMessageSize, ref int lpNextSize,
                                                 ref int lpMessageCount, ref int lpReadTimeout);

        [DllImport("kernel32")]
        public static extern int GetModuleFileName(IntPtr hModule, StringBuilder lpFileName, int nSize);

        [DllImport("kernel32")]
        public static extern int GetModuleHandle(string lpModuleName);

        [DllImport("kernel32")]
        public static extern int GetNamedPipeHandleState(IntPtr hNamedPipe, ref int lpState, ref int lpCurInstances,
                                                         ref int lpMaxCollectionCount, ref int lpCollectDataTimeout,
                                                         string lpUserName, int nMaxUserNameSize);

        [DllImport("kernel32")]
        public static extern int GetNamedPipeInfo(IntPtr hNamedPipe, ref int lpFlags, ref int lpOutBufferSize,
                                                  ref int lpInBufferSize, ref int lpMaxInstances);

        [DllImport("kernel32")]
        public static extern int GetNumberFormat(int Locale, int dwFlags, string lpValue, ref NUMBERFMT lpFormat,
                                                 string lpNumberStr, int cchNumber);

        [DllImport("kernel32")]
        public static extern int GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, ref int lpNumberOfEvents);

        [DllImport("kernel32")]
        public static extern int GetNumberOfConsoleMouseButtons(int lpNumberOfMouseButtons);

        [DllImport("kernel32")]
        public static extern int GetOEMCP();

        [DllImport("kernel32")]
        public static extern int GetOverlappedResult(IntPtr hFile, ref OVERLAPPED lpOverlapped,
                                                     ref int lpNumberOfBytesTransferred, int bWait);

        [DllImport("kernel32")]
        public static extern int GetPriorityClass(IntPtr hProcess);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault,
                                                      string lpFileName);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileSection(string lpAppName, StringBuilder lpReturnedString, int nSize,
                                                          string lpFileName);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpApplicationName, IntPtr lpKeyName, string lpDefault,
                                                         StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault,
                                                         StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32")]
        public static extern int GetProcessAffinityMask(IntPtr hProcess, ref int lpProcessAffinityMask,
                                                        int SystemAffinityMask);

        [DllImport("kernel32")]
        public static extern int GetProcessHeap();

        [DllImport("kernel32")]
        public static extern int GetProcessHeaps(int NumberOfHeaps, int ProcessHeaps);

        [DllImport("kernel32")]
        public static extern int GetProcessShutdownParameters(int lpdwLevel, ref int lpdwFlags);

        [DllImport("kernel32")]
        public static extern int GetProcessTimes(IntPtr hProcess, ref FILETIME lpCreationTime, ref FILETIME lpExitTime,
                                                 ref FILETIME lpKernelTime, ref FILETIME lpUserTime);

        [DllImport("kernel32")]
        public static extern int GetProcessWorkingSetSize(IntPtr hProcess, ref int lpMinimumWorkingSetSize,
                                                          ref int lpMaximumWorkingSetSize);

        [DllImport("kernel32")]
        public static extern int GetProfileInt(string lpAppName, string lpKeyName, int nDefault);

        [DllImport("kernel32")]
        public static extern int GetProfileSection(string lpAppName, string lpReturnedString, int nSize);

        [DllImport("kernel32")]
        public static extern int GetProfileString(string lpAppName, string lpKeyName, string lpDefault,
                                                  StringBuilder lpReturnedString, int nSize);

        [DllImport("kernel32")]
        public static extern int GetQueuedCompletionStatus(int CompletionPort, ref int lpNumberOfBytesTransferred,
                                                           ref int lpCompletionKey, ref int lpOverlapped,
                                                           int dwMilliseconds);

        [DllImport("kernel32")]
        public static extern int GetShortPathName(string lpszLongPath, string lpszShortPath, int cchBuffer);

        [DllImport("kernel32")]
        public static extern int GetStdHandle(int nStdHandle);

        [DllImport("kernel32")]
        public static extern int GetStringTypeA(int lcid, int dwInfoType, string lpSrcStr, int cchSrc,
                                                ref int lpCharType);

        [DllImport("kernel32")]
        public static extern int GetStringTypeEx(int Locale, int dwInfoType, string lpSrcStr, int cchSrc,
                                                 short lpCharType);

        [DllImport("kernel32")]
        public static extern int GetStringTypeW(int dwInfoType, string lpSrcStr, int cchSrc, short lpCharType);

        [DllImport("kernel32")]
        public static extern int GetSystemDefaultLCID();

        [DllImport("kernel32")]
        public static extern int GetSystemDirectory(StringBuilder lpBuffer, int nSize);

        [DllImport("kernel32")]
        public static extern int GetSystemPowerStatus(ref SYSTEM_POWER_STATUS lpSystemPowerStatus);

        [DllImport("kernel32")]
        public static extern int GetSystemTimeAdjustment(int lpTimeAdjustment, ref int lpTimeIncrement,
                                                         ref int lpTimeAdjustmentDisabled);

        [DllImport("kernel32")]
        public static extern int GetTapeParameters(IntPtr hDevice, int dwOperation, ref int lpdwSize,
                                                   IntPtr lpTapeInformation);

        [DllImport("kernel32")]
        public static extern int GetTapePosition(IntPtr hDevice, int dwPositionType, ref int lpdwPartition,
                                                 ref int lpdwOffsetLow, ref int lpdwOffsetHigh);

        [DllImport("kernel32")]
        public static extern int GetTapeStatus(IntPtr hDevice);

        [DllImport("kernel32")]
        public static extern int GetTempFileName(string lpszPath, string lpPrefixString, int wUnique,
                                                 StringBuilder lpTempFileName);

        [DllImport("kernel32")]
        public static extern int GetTempPath(int nBufferLength, StringBuilder lpBuffer);

        [DllImport("kernel32")]
        public static extern int GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

        [DllImport("kernel32")]
        public static extern int GetThreadPriority(IntPtr hThread);

        [DllImport("kernel32")]
        public static extern int GetThreadSelectorEntry(IntPtr hThread, int dwSelector, ref LDT_ENTRY lpSelectorEntry);

        [DllImport("kernel32")]
        public static extern int GetThreadTimes(IntPtr hThread, ref FILETIME lpCreationTime, ref FILETIME lpExitTime,
                                                ref FILETIME lpKernelTime, ref FILETIME lpUserTime);

        [DllImport("kernel32")]
        public static extern int GetTickCount();

        [DllImport("kernel32")]
        public static extern int GetTimeFormat(int Locale, int dwFlags, ref SYSTEMTIME lpTime, string lpFormat,
                                               string lpTimeStr, int cchTime);

        [DllImport("kernel32")]
        public static extern int GetTimeZoneInformation(ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

        [DllImport("kernel32")]
        public static extern int GetUserDefaultLCID();

        [DllImport("kernel32")]
        public static extern int GetVersion();

        [DllImport("kernel32")]
        public static extern int GetVersionEx(ref OSVERSIONINFO lpVersionInformation);

        [DllImport("kernel32")]
        public static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer,
                                                      int nVolumeNameSize, ref int lpVolumeSerialNumber,
                                                      ref int lpMaximumComponentLength, ref int lpFileSystemFlags,
                                                      string lpFileSystemNameBuffer, int nFileSystemNameSize);

        [DllImport("kernel32")]
        public static extern int GetWindowsDirectory(StringBuilder lpBuffer, int nSize);

        [DllImport("kernel32")]
        public static extern int GlobalAlloc(int wFlags, int dwBytes);

        [DllImport("kernel32")]
        public static extern int GlobalCompact(int dwMinFree);

        [DllImport("kernel32")]
        public static extern int GlobalFlags(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int GlobalFree(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int GlobalGetAtomName(short nAtom, string lpBuffer, int nSize);

        [DllImport("kernel32")]
        public static extern int GlobalHandle(IntPtr wMem);

        [DllImport("kernel32")]
        public static extern int GlobalLock(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int GlobalReAlloc(IntPtr hMem, int dwBytes, int wFlags);

        [DllImport("kernel32")]
        public static extern int GlobalSize(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int GlobalUnWire(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int GlobalUnlock(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int GlobalWire(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int HeapAlloc(IntPtr hHeap, int dwFlags, int dwBytes);

        [DllImport("kernel32")]
        public static extern int HeapCompact(IntPtr hHeap, int dwFlags);

        [DllImport("kernel32")]
        public static extern int HeapCreate(int flOptions, int dwInitialSize, int dwMaximumSize);

        [DllImport("kernel32")]
        public static extern int HeapDestroy(IntPtr hHeap);

        [DllImport("kernel32")]
        public static extern int HeapFree(IntPtr hHeap, int dwFlags, IntPtr lpMem);

        [DllImport("kernel32")]
        public static extern int HeapLock(IntPtr hHeap);

        [DllImport("kernel32")]
        public static extern int HeapReAlloc(IntPtr hHeap, int dwFlags, IntPtr lpMem, int dwBytes);

        [DllImport("kernel32")]
        public static extern int HeapSize(IntPtr hHeap, int dwFlags, IntPtr lpMem);

        [DllImport("kernel32")]
        public static extern int HeapUnlock(IntPtr hHeap);

        [DllImport("kernel32")]
        public static extern int HeapValidate(IntPtr hHeap, int dwFlags, IntPtr lpMem);

        [DllImport("kernel32")]
        public static extern int InitAtomTable(int nSize);

        [DllImport("kernel32")]
        public static extern int InterlockedDecrement(int lpAddend);

        [DllImport("kernel32")]
        public static extern int InterlockedExchange(int Target, int Value);

        [DllImport("kernel32")]
        public static extern int InterlockedIncrement(int lpAddend);

        [DllImport("kernel32")]
        public static extern int IsBadCodePtr(int lpfn);

        [DllImport("kernel32")]
        public static extern int IsBadHugeReadPtr(IntPtr lp, int ucb);

        [DllImport("kernel32")]
        public static extern int IsBadHugeWritePtr(IntPtr lp, int ucb);

        [DllImport("kernel32")]
        public static extern int IsBadReadPtr(IntPtr lp, int ucb);

        [DllImport("kernel32")]
        public static extern int IsBadStringPtr(string lpsz, int ucchMax);

        [DllImport("kernel32")]
        public static extern int IsBadWritePtr(IntPtr lp, int ucb);

        [DllImport("kernel32")]
        public static extern int IsDBCSLeadByte(Byte bTestChar);

        [DllImport("kernel32")]
        public static extern int IsValidCodePage(int CodePage);

        [DllImport("kernel32")]
        public static extern int LCMapString(int Locale, int dwMapFlags, string lpSrcStr, int cchSrc, string lpDestStr,
                                             int cchDest);

        [DllImport("kernel32")]
        public static extern int LoadLibrary(string lpLibFileName);

        [DllImport("kernel32")]
        public static extern int LoadLibraryEx(string lpLibFileName, IntPtr hFile, int dwFlags);

        [DllImport("kernel32")]
        public static extern int LoadModule(string lpModuleName, IntPtr lpParameterBlock);

        [DllImport("kernel32")]
        public static extern int LoadResource(IntPtr hInstance, IntPtr hResInfo);

        [DllImport("kernel32")]
        public static extern int LocalAlloc(int wFlags, int wBytes);

        [DllImport("kernel32")]
        public static extern int LocalCompact(int uMinFree);

        [DllImport("kernel32")]
        public static extern int LocalFileTimeToFileTime(ref FILETIME lpLocalFileTime, ref FILETIME lpFileTime);

        [DllImport("kernel32")]
        public static extern int LocalFlags(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int LocalFree(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int LocalHandle(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int LocalLock(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int LocalReAlloc(IntPtr hMem, int wBytes, int wFlags);

        [DllImport("kernel32")]
        public static extern int LocalShrink(IntPtr hMem, int cbNewSize);

        [DllImport("kernel32")]
        public static extern int LocalSize(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int LocalUnlock(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern int LockFile(IntPtr hFile, int dwFileOffsetLow, int dwFileOffsetHigh,
                                          int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh);

        [DllImport("kernel32")]
        public static extern int LockFileEx(IntPtr hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow,
                                            int nNumberOfBytesToLockHigh, ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int LockResource(IntPtr hResData);

        [DllImport("kernel32")]
        public static extern int MapViewOfFile(IntPtr hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh,
                                               int dwFileOffsetLow, int dwNumberOfBytesToMap);

        [DllImport("kernel32")]
        public static extern int MapViewOfFileEx(IntPtr hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh,
                                                 int dwFileOffsetLow, int dwNumberOfBytesToMap, IntPtr lpBaseAddress);

        [DllImport("kernel32")]
        public static extern int MoveFile(string lpExistingFileName, string lpNewFileName);

        [DllImport("kernel32")]
        public static extern int MoveFileEx(string lpExistingFileName, string lpNewFileName, int dwFlags);

        [DllImport("kernel32")]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

        [DllImport("kernel32")]
        public static extern int MultiByteToWideChar(int CodePage, int dwFlags, string lpMultiByteStr, int cchMultiByte,
                                                     string lpWideCharStr, int cchWideChar);

        [DllImport("kernel32")]
        public static extern int OpenEvent(int dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport("kernel32")]
        public static extern int OpenFile(string lpFileName, ref OFSTRUCT lpReOpenBuff, int wStyle);

        [DllImport("kernel32")]
        public static extern int OpenFileMapping(int dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport("kernel32")]
        public static extern int OpenMutex(int dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport("kernel32")]
        public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

        [DllImport("kernel32")]
        public static extern int OpenSemaphore(int dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport("kernel32")]
        public static extern int PeekNamedPipe(IntPtr hNamedPipe, IntPtr lpBuffer, int nBufferSize, ref int lpBytesRead,
                                               ref int lpTotalBytesAvail, ref int lpBytesLeftThisMessage);

        [DllImport("kernel32")]
        public static extern int PrepareTape(IntPtr hDevice, int dwOperation, int bimmediate);

        [DllImport("kernel32")]
        public static extern int PulseEvent(IntPtr hEvent);

        [DllImport("kernel32")]
        public static extern int PurgeComm(IntPtr hFile, int dwFlags);

        [DllImport("kernel32")]
        public static extern int QueryDosDevice(string lpDeviceName, string lpTargetPath, int ucchMax);

        [DllImport("kernel32")]
        public static extern int QueryPerformanceCounter(ref LARGE_INTEGER lpPerformanceCount);

        [DllImport("kernel32")]
        public static extern int QueryPerformanceFrequency(ref LARGE_INTEGER lpFrequency);

        [DllImport("kernel32")]
        public static extern int ReadConsole(IntPtr hConsoleInput, IntPtr lpBuffer, int nNumberOfCharsToRead,
                                             ref int lpNumberOfCharsRead, IntPtr lpReserved);

        [DllImport("kernel32")]
        public static extern int ReadConsoleOutput(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize,
                                                   COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

        [DllImport("kernel32")]
        public static extern int ReadConsoleOutputAttribute(IntPtr hConsoleOutput, ref int lpAttribute, int nLength,
                                                            COORD dwReadCoord, ref int lpNumberOfAttrsRead);

        [DllImport("kernel32")]
        public static extern int ReadConsoleOutputCharacter(IntPtr hConsoleOutput, string lpCharacter, int nLength,
                                                            COORD dwReadCoord, ref int lpNumberOfCharsRead);

        [DllImport("kernel32")]
        public static extern int ReadFile(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToRead,
                                          ref int lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int ReadFileEx(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToRead,
                                            ref OVERLAPPED lpOverlapped, ref int lpCompletionRoutine);

        [DllImport("kernel32")]
        public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize,
                                                   ref int lpNumberOfBytesWritten);

        [DllImport("kernel32")]
        public static extern int ReleaseMutex(IntPtr hMutex);

        [DllImport("kernel32")]
        public static extern int ReleaseSemaphore(IntPtr hSemaphore, int lReleaseCount, ref int lpPreviousCount);

        [DllImport("kernel32")]
        public static extern int RemoveDirectory(string lpPathName);

        [DllImport("kernel32")]
        public static extern int ResetEvent(IntPtr hEvent);

        [DllImport("kernel32")]
        public static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32")]
        public static extern int ScrollConsoleScreenBuffer(IntPtr hConsoleOutput, ref SMALL_RECT lpScrollRectangle,
                                                           ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin,
                                                           ref CHAR_INFO lpFill);

        [DllImport("kernel32")]
        public static extern int SearchPath(string lpPath, string lpFileName, string lpExtension, int nBufferLength,
                                            string lpBuffer, string lpFilePart);

        [DllImport("kernel32")]
        public static extern int SetCommBreak(int nCid);

        [DllImport("kernel32")]
        public static extern int SetCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, int dwSize);

        [DllImport("kernel32")]
        public static extern int SetCommMask(IntPtr hFile, int dwEvtMask);

        [DllImport("kernel32")]
        public static extern int SetCommState(IntPtr hCommDev, ref DCB lpDCB);

        [DllImport("kernel32")]
        public static extern int SetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);

        [DllImport("kernel32")]
        public static extern int SetComputerName(string lpComputerName);

        [DllImport("kernel32")]
        public static extern int SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);

        [DllImport("kernel32")]
        public static extern int SetConsoleCP(int wCodePageID);

        [DllImport("kernel32")]
        public static extern int SetConsoleCtrlHandler(int HandlerRoutine, int Add);

        [DllImport("kernel32")]
        public static extern int SetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        [DllImport("kernel32")]
        public static extern int SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);

        [DllImport("kernel32")]
        public static extern int SetConsoleMode(IntPtr hConsoleHandle, int dwMode);

        [DllImport("kernel32")]
        public static extern int SetConsoleOutputCP(int wCodePageID);

        [DllImport("kernel32")]
        public static extern int SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD dwSize);

        [DllImport("kernel32")]
        public static extern int SetConsoleTextAttribute(IntPtr hConsoleOutput, int wAttributes);

        [DllImport("kernel32")]
        public static extern int SetConsoleTitle(string lpConsoleTitle);

        [DllImport("kernel32")]
        public static extern int SetConsoleWindowInfo(IntPtr hConsoleOutput, int bAbsolute,
                                                      ref SMALL_RECT lpConsoleWindow);

        [DllImport("kernel32")]
        public static extern int SetCurrentDirectory(string lpPathName);

        [DllImport("kernel32")]
        public static extern int SetDefaultCommConfig(string lpszName, ref COMMCONFIG lpCC, int dwSize);

        [DllImport("kernel32")]
        public static extern int SetEndOfFile(IntPtr hFile);

        [DllImport("kernel32")]
        public static extern int SetEnvironmentVariable(string lpName, string lpValue);

        [DllImport("kernel32")]
        public static extern int SetErrorMode(int wMode);

        [DllImport("kernel32")]
        public static extern int SetEvent(IntPtr hEvent);

        [DllImport("kernel32")]
        public static extern int SetFileAttributes(string lpFileName, int dwFileAttributes);

        [DllImport("kernel32")]
        public static extern int SetFilePointer(IntPtr hFile, int lDistanceToMove, ref int lpDistanceToMoveHigh,
                                                int dwMoveMethod);

        [DllImport("kernel32")]
        public static extern int SetFileTime(IntPtr hFile, ref FILETIME lpCreationTime, ref FILETIME lpLastAccessTime,
                                             ref FILETIME lpLastWriteTime);

        [DllImport("kernel32")]
        public static extern int SetHandleCount(int wNumber);

        [DllImport("kernel32")]
        public static extern int SetHandleInformation(IntPtr hObject, int dwMask, int dwFlags);

        [DllImport("kernel32")]
        public static extern int SetLocalTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32")]
        public static extern int SetLocaleInfo(int Locale, int LCType, string lpLCData);

        [DllImport("kernel32")]
        public static extern int SetMailslotInfo(IntPtr hMailslot, int lReadTimeout);

        [DllImport("kernel32")]
        public static extern int SetNamedPipeHandleState(IntPtr hNamedPipe, ref int lpMode, ref int lpMaxCollectionCount,
                                                         ref int lpCollectDataTimeout);

        [DllImport("kernel32")]
        public static extern int SetPriorityClass(IntPtr hProcess, int dwPriorityClass);

        [DllImport("kernel32")]
        public static extern int SetProcessShutdownParameters(int dwLevel, int dwFlags);

        [DllImport("kernel32")]
        public static extern int SetProcessWorkingSetSize(IntPtr hProcess, int dwMinimumWorkingSetSize,
                                                          int dwMaximumWorkingSetSize);

        [DllImport("kernel32")]
        public static extern int SetStdHandle(int nStdHandle, int nHandle);

        [DllImport("kernel32")]
        public static extern int SetSystemPowerState(int fSuspend, int fForce);

        [DllImport("kernel32")]
        public static extern int SetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32")]
        public static extern int SetTapeParameters(IntPtr hDevice, int dwOperation, IntPtr lpTapeInformation);

        [DllImport("kernel32")]
        public static extern int SetTapePosition(IntPtr hDevice, int dwPositionMethod, int dwPartition, int dwOffsetLow,
                                                 int dwOffsetHigh, int bimmediate);

        [DllImport("kernel32")]
        public static extern int SetThreadAffinityMask(IntPtr hThread, int dwThreadAffinityMask);

        [DllImport("kernel32")]
        public static extern int SetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

        [DllImport("kernel32")]
        public static extern int SetThreadLocale(int Locale);

        [DllImport("kernel32")]
        public static extern int SetThreadPriority(IntPtr hThread, int nPriority);

        [DllImport("kernel32")]
        public static extern int SetTimeZoneInformation(ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

        [DllImport("kernel32")]
        public static extern int SetUnhandledExceptionFilter(int lpTopLevelExceptionFilter);

        [DllImport("kernel32")]
        public static extern int SetVolumeLabel(string lpRootPathName, string lpVolumeName);

        [DllImport("kernel32")]
        public static extern int SetupComm(IntPtr hFile, int dwInQueue, int dwOutQueue);

        [DllImport("kernel32")]
        public static extern int SizeofResource(IntPtr hInstance, IntPtr hResInfo);

        [DllImport("kernel32")]
        public static extern int SleepEx(int dwMilliseconds, int bAlertable);

        [DllImport("kernel32")]
        public static extern int SuspendThread(IntPtr hThread);

        [DllImport("kernel32")]
        public static extern int SystemTimeToFileTime(ref SYSTEMTIME lpSystemTime, ref FILETIME lpFileTime);

        [DllImport("kernel32")]
        public static extern int SystemTimeToTzSpecificLocalTime(ref TIME_ZONE_INFORMATION lpTimeZoneInformation,
                                                                 ref SYSTEMTIME lpUniversalTime,
                                                                 ref SYSTEMTIME lpLocalTime);

        [DllImport("kernel32")]
        public static extern int TerminateProcess(IntPtr hProcess, int uExitCode);

        [DllImport("kernel32")]
        public static extern int TerminateThread(IntPtr hThread, int dwExitCode);

        [DllImport("kernel32")]
        public static extern int TlsAlloc();

        [DllImport("kernel32")]
        public static extern int TlsFree(int dwTlsIndex);

        [DllImport("kernel32")]
        public static extern int TlsGetValue(int dwTlsIndex);

        [DllImport("kernel32")]
        public static extern int TlsSetValue(int dwTlsIndex, IntPtr lpTlsValue);

        [DllImport("kernel32")]
        public static extern int TransactNamedPipe(IntPtr hNamedPipe, IntPtr lpInBuffer, int nInBufferSize,
                                                   IntPtr lpOutBuffer, int nOutBufferSize, ref int lpBytesRead,
                                                   ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int TransmitCommChar(int nCid, Byte cChar);

        [DllImport("kernel32")]
        public static extern int UnhandledExceptionFilter(ref EXCEPTION_POINTERS ExceptionInfo);

        [DllImport("kernel32")]
        public static extern int UnlockFile(IntPtr hFile, int dwFileOffsetLow, int dwFileOffsetHigh,
                                            int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh);

        [DllImport("kernel32")]
        public static extern int UnlockFileEx(IntPtr hFile, int dwReserved, int nNumberOfBytesToUnlockLow,
                                              int nNumberOfBytesToUnlockHigh, ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int UnmapViewOfFile(IntPtr lpBaseAddress);

        [DllImport("kernel32")]
        public static extern int UpdateResource(IntPtr hUpdate, string lpType, string lpName, int wLanguage,
                                                IntPtr lpData, int cbData);

        [DllImport("kernel32")]
        public static extern int VerLanguageName(int wLang, string szLang, int nSize);

        [DllImport("kernel32")]
        public static extern int VirtualAlloc(IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32")]
        public static extern int VirtualFree(IntPtr lpAddress, int dwSize, int dwFreeType);

        [DllImport("kernel32")]
        public static extern int VirtualLock(IntPtr lpAddress, int dwSize);

        [DllImport("kernel32")]
        public static extern int VirtualProtect(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

        [DllImport("kernel32")]
        public static extern int VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int flNewProtect,
                                                  ref int lpflOldProtect);

        [DllImport("kernel32")]
        public static extern int VirtualQuery(IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);

        [DllImport("kernel32")]
        public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer,
                                                int dwLength);

        [DllImport("kernel32")]
        public static extern int VirtualUnlock(IntPtr lpAddress, int dwSize);

        [DllImport("kernel32")]
        public static extern int WaitCommEvent(IntPtr hFile, ref int lpEvtMask, ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int WaitForMultipleObjects(int nCount, ref int lpHandles, int bWaitAll, int dwMilliseconds);

        [DllImport("kernel32")]
        public static extern int WaitForMultipleObjectsEx(int nCount, ref int lpHandles, int bWaitAll,
                                                          int dwMilliseconds, int bAlertable);

        [DllImport("kernel32")]
        public static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);

        [DllImport("kernel32")]
        public static extern int WaitForSingleObjectEx(IntPtr hHandle, int dwMilliseconds, int bAlertable);

        [DllImport("kernel32")]
        public static extern int WaitNamedPipe(string lpNamedPipeName, int nTimeOut);

        [DllImport("kernel32")]
        public static extern int WideCharToMultiByte(int CodePage, int dwFlags, string lpWideCharStr, int cchWideChar,
                                                     string lpMultiByteStr, int cchMultiByte, string lpDefaultChar,
                                                     ref int lpUsedDefaultChar);

        [DllImport("kernel32")]
        public static extern int WinExec(string lpCmdLine, int nCmdShow);

        [DllImport("kernel32")]
        public static extern int WriteConsole(IntPtr hConsoleOutput, IntPtr lpBuffer, int nNumberOfCharsToWrite,
                                              ref int lpNumberOfCharsWritten, IntPtr lpReserved);

        [DllImport("kernel32")]
        public static extern int WriteConsoleOutput(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize,
                                                    COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

        [DllImport("kernel32")]
        public static extern int WriteConsoleOutputAttribute(IntPtr hConsoleOutput, short lpAttribute, int nLength,
                                                             COORD dwWriteCoord, ref int lpNumberOfAttrsWritten);

        [DllImport("kernel32")]
        public static extern int WriteConsoleOutputCharacter(IntPtr hConsoleOutput, string lpCharacter, int nLength,
                                                             COORD dwWriteCoord, ref int lpNumberOfCharsWritten);

        [DllImport("kernel32")]
        public static extern int WriteFile(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToWrite,
                                           ref int lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);

        [DllImport("kernel32")]
        public static extern int WriteFileEx(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToWrite,
                                             ref OVERLAPPED lpOverlapped, ref int lpCompletionRoutine);

        [DllImport("kernel32")]
        public static extern int WritePrivateProfileSection(string lpAppName, string lpString, string lpFileName);

        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string lpApplicationName, IntPtr lpKeyName, IntPtr lpString,
                                                           string lpFileName);

        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, IntPtr lpString,
                                                           string lpFileName);

        [DllImport("kernel32")]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize,
                                                    ref int lpNumberOfBytesWritten);

        [DllImport("kernel32")]
        public static extern int WriteProfileSection(string lpAppName, string lpString);

        [DllImport("kernel32")]
        public static extern int WriteProfileString(string lpszSection, string lpszKeyName, string lpszString);

        [DllImport("kernel32")]
        public static extern int WriteTapemark(IntPtr hDevice, int dwTapemarkType, int dwTapemarkCount, int bimmediate);

        [DllImport("kernel32")]
        public static extern int hread(IntPtr hFile, IntPtr lpBuffer, int lBytes);

        [DllImport("kernel32")]
        public static extern int hwrite(IntPtr hFile, string lpBuffer, int lBytes);

        [DllImport("kernel32")]
        public static extern int lclose(IntPtr hFile);

        [DllImport("kernel32")]
        public static extern int lcreat(string lpPathName, int iAttribute);

        [DllImport("kernel32")]
        public static extern int llseek(IntPtr hFile, int lOffset, int iOrigin);

        [DllImport("kernel32")]
        public static extern int lopen(string lpPathName, int iReadWrite);

        [DllImport("kernel32")]
        public static extern int lread(IntPtr hFile, IntPtr lpBuffer, int wBytes);

        [DllImport("kernel32")]
        public static extern int lstrcat(string lpString1, string lpString2);

        [DllImport("kernel32")]
        public static extern int lstrcmp(string lpString1, string lpString2);

        [DllImport("kernel32")]
        public static extern int lstrcmpi(string lpString1, string lpString2);

        [DllImport("kernel32")]
        public static extern int lstrcpy(string lpString1, string lpString2);

        [DllImport("kernel32")]
        public static extern int lstrcpyn(string lpString1, string lpString2, int iMaxLength);

        [DllImport("kernel32")]
        public static extern int lstrlen(string lpString);

        [DllImport("kernel32")]
        public static extern int lwrite(IntPtr hFile, string lpBuffer, int wBytes);

        [DllImport("kernel32")]
        public static extern short GetSystemDefaultLangID();

        [DllImport("kernel32")]
        public static extern short GetUserDefaultLangID();

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern short GlobalAddAtom(string lpString);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern ushort GlobalDeleteAtom(short nAtom);

        [DllImport("kernel32")]
        public static extern short GlobalFindAtom(string lpString);

        [DllImport("kernel32")]
        public static extern string GetEnvironmentStrings();

        [DllImport("kernel32")]
        public static extern void CopyMemory(IntPtr Destination, IntPtr Source, int Length);

        [DllImport("kernel32")]
        public static extern void DebugBreak();

        [DllImport("kernel32")]
        public static extern void DeleteCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

        [DllImport("kernel32")]
        public static extern void EnterCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

        [DllImport("kernel32")]
        public static extern void ExitProcess(int uExitCode);

        [DllImport("kernel32")]
        public static extern void ExitThread(int dwExitCode);

        [DllImport("kernel32")]
        public static extern void FatalAppExit(int uAction, string lpMessageText);

        [DllImport("kernel32")]
        public static extern void FatalExit(int code);

        [DllImport("kernel32")]
        public static extern void FreeLibraryAndExitThread(IntPtr hLibModule, int dwExitCode);

        [DllImport("kernel32")]
        public static extern void GetLocalTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32")]
        public static extern void GetStartupInfo(ref STARTUPINFO lpStartupInfo);

        [DllImport("kernel32")]
        public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32")]
        public static extern void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32")]
        public static extern void GlobalFix(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS lpBuffer);

        [DllImport("kernel32")]
        public static extern void GlobalUnfix(IntPtr hMem);

        [DllImport("kernel32")]
        public static extern void InitializeCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

        [DllImport("kernel32")]
        public static extern void LeaveCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

        [DllImport("kernel32")]
        public static extern void RaiseException(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments,
                                                 ref int lpArguments);

        [DllImport("kernel32")]
        public static extern void SetFileApisToANSI();

        [DllImport("kernel32")]
        public static extern void SetFileApisToOEM();

        [DllImport("kernel32")]
        public static extern void SetLastError(int dwErrCode);

        [DllImport("kernel32")]
        public static extern void Sleep(int dwMilliseconds);

        [DllImport("kernel32")]
        public static extern int GetComputerNameW(IntPtr lpBuffer, int nSize);

        [DllImport("kernel32")]
        public static extern int GetProcAddress(IntPtr hModule, string lpProcName);
    }
}