Option Explicit On
Module StandardRegional

    '
    ' ModRegionalSetting.BAS
    '


    Const LOCALE_SDECIMAL = &HE ' decimal separator
    Const LOCALE_STHOUSAND = &HF ' thousand separator
    Const LOCALE_SGROUPING = &H10 ' digit grouping

    Const LOCALE_IDIGITS = &H11 ' number of fractional digits
    Const LOCALE_ILZERO = &H12 ' leading zeros for decimal
    Const LOCALE_SNATIVEDIGITS = &H13 ' native ascii 0-9

    Const LOCALE_SCURRENCY = &H14 ' local monetary symbol
    Const LOCALE_SINTLSYMBOL = &H15 ' intl monetary symbol
    Const LOCALE_SMONDECIMALSEP = &H16 ' monetary decimal separator
    Const LOCALE_SMONTHOUSANDSEP = &H17 ' monetary thousand separator
    Const LOCALE_SMONGROUPING = &H18 ' monetary grouping

    Const LOCALE_ICURRDIGITS = &H19 ' # local monetary digits
    Const LOCALE_IINTLCURRDIGITS = &H1A ' # intl monetary digits
    Const LOCALE_ICURRENCY = &H1B ' positive currency mode
    Const LOCALE_INEGCURR = &H1C ' negative currency mode

    Const LOCALE_SDATE = &H1D ' date separator
    Const LOCALE_STIME = &H1E ' time separator
    Const LOCALE_SSHORTDATE = &H1F ' short date format string
    Const LOCALE_SLONGDATE = &H20 ' long date format string
    Const LOCALE_STIMEFORMAT = &H1003 ' time format string

    Const LOCALE_IDATE = &H21 ' short date format ordering
    Const LOCALE_ILDATE = &H22 ' long date format ordering
    Const LOCALE_ITIME = &H23 ' time format specifier
    Const LOCALE_ICENTURY = &H24 ' century format specifier

    Private Declare Function GetSystemDefaultLCID Lib "Kernel32" () As Int32
    Private Declare Function GetUserDefaultLCID Lib "Kernel32" () As Int32
    Private Declare Function GetLocaleInfo Lib "Kernel32" Alias "GetLocaleInfoA" (ByVal Locale As Long, ByVal LCType As Long, ByVal lpLCData As String, ByVal cchData As Long) As Int32
    Private Declare Function SetLocaleInfo Lib "Kernel32" Alias "SetLocaleInfoA" (ByVal Locale As Long, ByVal LCType As Long, ByVal lpLCData As String) As Int32

    Public DataRegional(11) As String

    Private Function GetRegional(nFormat As Long, Optional SetValue As String = "-1") As String
        Dim vNilai As String, vLcid As Long, Ret As Long
        vLcid = GetUserDefaultLCID()
        vNilai = Space(vLcid)
        Ret = GetLocaleInfo(vLcid, nFormat, vNilai, Len(vNilai))
        If Ret Then
            If SetValue <> "-1" Then
                Call SetLocaleInfo(vLcid, nFormat, CStr(SetValue))
            End If
            GetRegional = Left$(vNilai, Ret - 1)
        End If
    End Function

    Public Sub SimpenRegional()
        DataRegional(0) = GetRegional(LOCALE_SDECIMAL)
        DataRegional(1) = GetRegional(LOCALE_STHOUSAND)
        DataRegional(2) = GetRegional(LOCALE_SCURRENCY)
        DataRegional(3) = GetRegional(LOCALE_SMONDECIMALSEP)
        DataRegional(4) = GetRegional(LOCALE_SMONTHOUSANDSEP)
        DataRegional(5) = GetRegional(LOCALE_ICURRENCY)
        DataRegional(6) = GetRegional(LOCALE_INEGCURR)
        DataRegional(7) = GetRegional(LOCALE_SDATE)
        DataRegional(8) = GetRegional(LOCALE_STIME)
        DataRegional(9) = GetRegional(LOCALE_SSHORTDATE)
        DataRegional(10) = GetRegional(LOCALE_SLONGDATE)
        DataRegional(11) = GetRegional(LOCALE_STIMEFORMAT)
    End Sub

    Public Sub BalikinRegional()
        Call GetRegional(LOCALE_SDECIMAL, DataRegional(0))
        Call GetRegional(LOCALE_STHOUSAND, DataRegional(1))
        Call GetRegional(LOCALE_SCURRENCY, DataRegional(2))
        Call GetRegional(LOCALE_SMONDECIMALSEP, DataRegional(3))
        Call GetRegional(LOCALE_SMONTHOUSANDSEP, DataRegional(4))
        Call GetRegional(LOCALE_ICURRENCY, DataRegional(5))
        Call GetRegional(LOCALE_INEGCURR, DataRegional(6))
        Call GetRegional(LOCALE_SDATE, DataRegional(7))
        Call GetRegional(LOCALE_STIME, DataRegional(8))
        Call GetRegional(LOCALE_SSHORTDATE, DataRegional(9))
        Call GetRegional(LOCALE_SLONGDATE, DataRegional(10))
        Call GetRegional(LOCALE_STIMEFORMAT, DataRegional(11))
    End Sub

    Public Sub StandardRegionalSetting()
        Call GetRegional(LOCALE_SDECIMAL, ",")
        Call GetRegional(LOCALE_STHOUSAND, ".")
        Call GetRegional(LOCALE_SCURRENCY, "Rp")
        Call GetRegional(LOCALE_SMONDECIMALSEP, ",")
        Call GetRegional(LOCALE_SMONTHOUSANDSEP, ".")
        Call GetRegional(LOCALE_ICURRENCY, 2)
        Call GetRegional(LOCALE_INEGCURR, 14)
        Call GetRegional(LOCALE_SDATE, "/")
        Call GetRegional(LOCALE_STIME, ":")
        Call GetRegional(LOCALE_SSHORTDATE, "dd/MM/yyyy")
        Call GetRegional(LOCALE_SLONGDATE, "dddd, d MMMM yyyy")
        Call GetRegional(LOCALE_STIMEFORMAT, "HH:mm:ss")
    End Sub
End Module
