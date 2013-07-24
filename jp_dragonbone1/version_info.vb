Public Class version_info
    'by design this file will often show up in git conflicts. Please combine verion comments in a sensible manor and use our conventions to select a new version number

    'version coments go here
    '072413-JP-CMF Remote SIgn config mod+neww calss of verion_info
    'end version coments

    Public Const ApplicationName = "TiniWindow-3.01.exe"
    Public Const TiniWindowVersionStandard As Int16 = 1 'first used with version 1.01.005 its abscence warns the update process of inconsistencies in other value
    Public Const TiniWindowMajorVersion As Int16 = 3
    Public Const TiniWindowMinorVersion As String = "01.001"
    Public Const TiniWindoCompileDate As String = "20130724"
    Public Shared TiniWindowVersion As String = TiniWindowMajorVersion.ToString() + "." + TiniWindowMinorVersion.ToString()
    Public Shared TiniWindowVersion_display_string As String = TiniWindowVersion + "." + TiniWindoCompileDate.ToString + " (Tini-Pi-Lite supported) " ' not used in update process


End Class
