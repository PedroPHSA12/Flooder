Imports System.Runtime.InteropServices
Imports System.IO

Module TM_OverlayCheats__MEGA_CODES_ : Public form


    'IMPORTS
   Private Declare Function ReadMemoryByte Lib "kernel32" Alias "ReadProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Byte, Optional ByVal Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Byte
    Private Declare Function ReadMemory2Byte Lib "kernel32" Alias "ReadProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Long, Optional ByVal Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Short
    Private Declare Function ReadMemoryInteger Lib "kernel32" Alias "ReadProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Integer, Optional ByVal Size As Integer = 4, Optional ByRef Bytes As Integer = 0) As Integer
    Private Declare Function ReadMemoryFloat Lib "kernel32" Alias "ReadProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Single, Optional ByVal Size As Integer = 4, Optional ByRef Bytes As Integer = 0) As Single
    Private Declare Function ReadMemoryDouble Lib "kernel32" Alias "ReadProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Double, Optional ByVal Size As Integer = 8, Optional ByRef Bytes As Integer = 0) As Double
 
    Private Declare Function WriteMemoryByte Lib "kernel32" Alias "WriteProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Byte, Optional ByVal Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Byte
    Private Declare Function WriteMemory2Byte Lib "kernel32" Alias "WriteProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Long, Optional ByVal Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Short
    Private Declare Function WriteMemoryInteger Lib "kernel32" Alias "WriteProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Integer, Optional ByVal Size As Integer = 4, Optional ByRef Bytes As Integer = 0) As Integer
    Private Declare Function WriteMemoryFloat Lib "kernel32" Alias "WriteProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Single, Optional ByVal Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Single
    Private Declare Function WriteMemoryDouble Lib "kernel32" Alias "WriteProcessMemory" (ByVal Handle As Integer, ByVal Address As Integer, ByRef Value As Double, Optional ByVal Size As Integer = 8, Optional ByRef Bytes As Integer = 0) As Double

    Private Const PROCESS_VM_WRITE As UInteger = &H20
    Private Const PROCESS_VM_READ As UInteger = &H10
    Private Const PROCESS_VM_OPERATION As UInteger = &H8
    Private Const TargetProcess As String = "iw5sp"
    Private ProcessHandle As IntPtr = IntPtr.Zero
    Private LastKnownPID As Integer = -1

    Const PROCESS_ALL_ACCESS = &H1F0FF
    Public Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As IntPtr) As Long
    Public Declare Auto Function FindWindow Lib "user32.dll" ( _
    ByVal lpClassName As String, _
    ByVal lpWindowName As String _
    ) As IntPtr

    Public Declare Auto Function FindWindowEx Lib "user32.dll" ( _
    ByVal hwndParent As IntPtr, _
    ByVal hwndChildAfter As IntPtr, _
    ByVal lpszClass As String, _
    ByVal lpszWindow As String _
    ) As IntPtr
    Public Const WM_NCLBUTTONDOWN = &HA1
    Public Const HTCAPTION = 2

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
                 (ByVal hwnd As Integer, ByVal wMsg As Integer, _
                  ByVal wParam As Integer, ByVal lParam As String) As Integer
    Public Declare Sub ReleaseCapture Lib "user32" ()
    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")> _
    Public Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    '----------------------------------------------------------



    'Window functions
    Public Function getwindowbinaryindex(ByVal win As String, ByVal win2 As String) As Integer
        getwindowbinaryindex = FindWindow(win, win2)
    End Function
    '---------------------------------------------------------



    'Keys functions
    Public Function ptkey(ByVal K As Keys) As Boolean
        Dim hotkey As Boolean
        hotkey = GetAsyncKeyState(K)
        If hotkey = True Then
            ptkey = True
        Else
            ptkey = False
        End If
    End Function
    '----------------------------------------------------



    'form functions
    Public Function MoveForm(ByVal window As Form) As String
        Dim lHwnd As Int32
        Return window.Handle
        lHwnd = window.Handle
        If lHwnd = 0 Then Exit Function
        ReleaseCapture()
        SendMessage(lHwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Function
    '-----------------------------------------------------




    'Directory functions
    Public Function DE(ByVal dir As String) As Boolean
        If IO.Directory.Exists(dir) Then
            DE = True
        End If
        Return dir
    End Function
    Public Function DC(ByVal dir As String) As String
        If IO.Directory.Exists(dir) Then
        Else
            MkDir(dir)
        End If
        Return dir
    End Function
    Public Function DD(ByVal dir As String) As String
        If IO.Directory.Exists(dir) Then
            RmDir(dir)
        End If
        Return dir
    End Function
    Public Function DCP(ByVal dir As String, ByVal dir2 As String) As String
        If IO.Directory.Exists(dir) Then
        Else
            My.Computer.FileSystem.CopyDirectory(dir, dir2)
        End If
        Return dir
    End Function
    '---------------------------------------------------





    'File functions
    Public Function FE(ByVal file As String) As Boolean
        If IO.File.Exists(file) Then
            FE = True
        End If
        Return file
    End Function
    Public Function FC(ByVal file As String)
        If IO.File.Exists(file) Then
        Else
            IO.File.Create(file).Dispose()
        End If
        Return file
    End Function
    Public Function FD(ByVal file As String)
        If IO.File.Exists(file) Then
            IO.File.Delete(file)
        End If
        Return file
    End Function
    Public Function FCP(ByVal file As String, ByVal file2 As String) As String
        If IO.File.Exists(file) Then
        Else
            IO.File.Copy(file, file2)
        End If
        Return file
    End Function
    '--------------------------------------------------





    'Text functions
    Public Function WT(ByVal file As String, ByVal texto As Object)
        If IO.File.Exists(file) Then
            IO.File.WriteAllText(file, texto)
        End If
        Return file
    End Function
    Public Function RT(ByVal file As String) As String
        If IO.File.Exists(file) Then
            RT = IO.File.ReadAllText(file)
        End If
        Return file
    End Function
    '------------------------------------------------



    'MEMORY FUNCTIONS
    
    Public Function ReadByte(ByVal EXENAME As String, ByVal Address As Integer) As Byte
        Dim Value As Byte
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                ReadMemoryByte(Handle, Address, Value)
            End If
        End If
        Return Value
    End Function
 
        Public Function Read2Byte(ByVal EXENAME As String, ByVal Address As Integer) As short
        Dim Value As Short
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                ReadMemory2Byte(Handle, Address, Value)
            End If
        End If
        Return Value
    End Function
       
    Public Function ReadInteger(ByVal EXENAME As String, ByVal Address As Integer) As Integer
        Dim Value As Integer
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                ReadMemoryInteger(Handle, Address, Value)
            End If
        End If
        Return Value
    End Function
 
    Public Function ReadFloat(ByVal EXENAME As String, ByVal Address As Integer) As Single
        Dim Value As Single
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                ReadMemoryFloat(Handle, Address, Value)
            End If
        End If
        Return Value
    End Function
 
    Public Function ReadDouble(ByVal EXENAME As String, ByVal Address As Integer) As Double
        Dim Value As Double
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                ReadMemoryByte(Handle, Address, Value)
            End If
        End If
        Return Value
    End Function
 
   
 
 
    Public Function ReadPointerByte(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal ParamArray Offset As Integer()) As Byte
        Dim Value As Byte
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                ReadMemoryByte(Handle, Pointer, Value)
            End If
        End If
        Return Value
    End Function
       
        Public Function ReadPointer2Byte(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal ParamArray Offset As Integer()) As Short
        Dim Value As Short
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                ReadMemory2Byte(Handle, Pointer, Value)
            End If
        End If
        Return Value
    End Function
       
    Public Function ReadPointerInteger(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal ParamArray Offset As Integer()) As Integer
        Dim Value As Integer
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                ReadMemoryInteger(Handle, Pointer, Value)
            End If
        End If
        Return Value
    End Function
 
    Public Function ReadPointerFloat(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal ParamArray Offset As Integer()) As Single
        Dim Value As Single
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                ReadMemoryFloat(Handle, Pointer, Value)
            End If
        End If
        Return Value
    End Function
 
    Public Function ReadPointerDouble(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal ParamArray Offset As Integer()) As Double
        Dim Value As Double
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                ReadMemoryDouble(Handle, Pointer, Value)
            End If
        End If
        Return Value
    End Function
 
   
 
 
 
    Public Sub WriteByte(ByVal EXENAME As String, ByVal Address As Integer, ByVal Value As Byte)
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                WriteMemoryByte(Handle, Address, Value)
            End If
        End If
    End Sub
       
        Public Sub Write2Byte(ByVal EXENAME As String, ByVal Address As Integer, ByVal Value As short)
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                WriteMemory2Byte(Handle, Address, Value)
            End If
        End If
    End Sub
 
    Public Sub WriteInteger(ByVal EXENAME As String, ByVal Address As Integer, ByVal Value As Integer)
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                WriteMemoryInteger(Handle, Address, Value)
            End If
        End If
    End Sub
 
    Public Sub WriteFloat(ByVal EXENAME As String, ByVal Address As Integer, ByVal Value As Single)
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                WriteMemoryFloat(Handle, Address, Value)
            End If
        End If
    End Sub
 
 
 
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function WriteProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer As Byte(), ByVal nSize As System.UInt32, <Out()> ByRef lpNumberOfBytesWritten As Int32) As Boolean
    End Function
    Public Function WriteString(ByVal proc As String, ByVal target As Integer, ByVal data As String) As Boolean
 
        Return WriteProcessMemory(Process.GetProcessesByName(proc)(0).Handle, New IntPtr(target), StrToByteArray(data), data.Length, 0)
    End Function
    Public Function StrToByteArray(ByVal str As String)
        Dim encoding As New System.Text.UTF8Encoding()
        Return encoding.GetBytes(str)
 
    End Function
 
 
    Public Sub WriteDouble(ByVal EXENAME As String, ByVal Address As Integer, ByVal Value As Double)
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                WriteMemoryDouble(Handle, Address, Value)
            End If
        End If
    End Sub
 
   
 
    
    Public Sub WritePointerByte(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal Value As Byte, ByVal ParamArray Offset As Integer())
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                WriteMemoryByte(Handle, Pointer, Value)
            End If
        End If
    End Sub
       
        Public Sub WritePointer2Byte(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal Value As Short, ByVal ParamArray Offset As Integer())
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                WriteMemory2Byte(Handle, Pointer, Value)
            End If
        End If
    End Sub
       
    Public Sub WritePointerString(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal Value As String, ByVal ParamArray Offset As Integer())
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                WriteString(EXENAME, Pointer, Value)
            End If
        End If
    End Sub
 
 
    Public Sub WritePointerInteger(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal Value As Integer, ByVal ParamArray Offset As Integer())
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                WriteMemoryInteger(Handle, Pointer, Value)
            End If
        End If
    End Sub
 
    Public Sub WritePointerFloat(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal Value As Single, ByVal ParamArray Offset As Integer())
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                WriteMemoryFloat(Handle, Pointer, Value)
            End If
        End If
    End Sub
 
    Public Sub WritePointerDouble(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal Value As Double, ByVal ParamArray Offset As Integer())
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                WriteMemoryDouble(Handle, Pointer, Value)
            End If
        End If
    End Sub
 
 
    Public Function _Pointer(ByVal EXENAME As String, ByVal Pointer As Integer, ByVal ParamArray Offset As Integer()) As Integer
        Dim Value As Integer
        If Process.GetProcessesByName(EXENAME).Length <> 0 Then
            Dim Handle As Integer = Process.GetProcessesByName(EXENAME)(0).Handle
            If Handle <> 0 Then
                For Each I As Integer In Offset
                    ReadMemoryInteger(Handle, Pointer, Pointer)
                    Pointer += I
                Next
                ReadMemoryInteger(Handle, Pointer, Value)
            End If
        End If
        Return Pointer
    End Function
    '-----------------------------------------------
    Function GetModuleHandle(ByVal processx As String, ByVal modulex As String) As IntPtr
        Dim prs As Process() = Process.GetProcessesByName(processx)
        If prs.Length > 0 Then
            On Error Resume Next
            Dim pi As ProcessModuleCollection = prs(0).Modules
            For Each pmod As ProcessModule In pi
                If pmod.ModuleName = (modulex) Then
                    Return pmod.BaseAddress
                Else
                End If
            Next
        End If
    End Function

End Module
