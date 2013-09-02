Public Class version_info
    'by design this file will often show up in git conflicts. Please combine verion comments in a sensible manor and use our conventions to select a new version number

    'version coments go here
    '20130902JP-CMF: To be continue
    '2013083113B-JP-CMF: To be continue
    '2013082813B-JP-CMF: fixed many bug with remote sign configuration 
    '2013082813-JP-CMF: (version date not changed in code!) Modify remote sign IP txt validate, some bug remain,  not finish.
    '2013082613-JP: REMOVED COMBO TAP BY COMMNET OUT .  Test easy-line-text saving and re-opening OK.
    '2013082513-JP: now use list of FTP servers (instead of single) read list from local or global file or use harcoded default if neither file exist. 
    '2013081413-CMF-JP: Remove debugging msgs. 
    '20130730-CMF: put applu but in invisible and add colors of OK/Cancel buttons.
    '20130729-jp-CMF: implement advanced form etc.
    '20130727-jpmodified to have files uploaded to default directory instead of root of FTP server
    '20130725-jp FTP works! 
    '20130724B-JP-CMF working on using FTP to send sign data. encounterd thread issues. Next step is to marshal
    '20130724-JP-CMF Remote SIgn config mod+neww calss of verion_info
    'end version coments

    Public Const ApplicationName = "TiniWindow-3.01.exe"
    Public Const TiniWindowVersionStandard As Int16 = 1 'first used with version 1.01.005 its abscence warns the update process of inconsistencies in other value
    Public Const TiniWindowMajorVersion As Int16 = 3
    Public Const TiniWindowMinorVersion As String = "01.001"
    Public Const TiniWindoCompileDate As String = "20130902"
    Public Shared TiniWindowVersion As String = TiniWindowMajorVersion.ToString() + "." + TiniWindowMinorVersion.ToString()
    Public Shared TiniWindowVersion_display_string As String = TiniWindowVersion + "." + TiniWindoCompileDate.ToString + " (Tini-Pi-Lite supported) " ' not used in update process


End Class
