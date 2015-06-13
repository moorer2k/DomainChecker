Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class FrmMain

#Region "Fields"

    Private WithEvents _bgw As New BackgroundWorker With {.WorkerSupportsCancellation = True, .WorkerReportsProgress = True}
    Private ReadOnly _regWords As Regex = New Regex("&w=\w+"">(\w+)</a>", RegexOptions.Singleline Or RegexOptions.CultureInvariant Or RegexOptions.Compiled)
    Private _startTime As String
    Private _strDic As KeyValuePair(Of String, String)()
    Private _strFirst As String = ""
    Private _strKeyWord As String
    Private _strTld As String = ""

    Private Shared ReadOnly Watch As New Stopwatch()

    Private ReadOnly _altwordLogs = Application.StartupPath & "\Alternate Words"
    Private ReadOnly _dnsLogs = Application.StartupPath & "\Domain Names"
    Private ReadOnly _listAltWords As New Dictionary(Of String, String)
    Private ReadOnly _listBad As New Dictionary(Of String, String)
    Private ReadOnly _listGood As New Dictionary(Of String, String)

    Private _iCurrWord As Integer = 0
    Private _iGood As Integer = 0
    Private _isKeyWordDone As Boolean
    Private _iTaken As Integer = 0
    Private _keyResults As Integer
    Private _nextPage = 1

#End Region 'Fields

#Region "Properties"

    Private ReadOnly Property TimeStamp As String
        Get
            Return "[" & Watch.Elapsed.Hours & ":" & Watch.Elapsed.Minutes & ":" & Watch.Elapsed.Seconds & "]"
        End Get
    End Property

#End Region 'Properties

#Region "Methods"

    Private Sub CheckDomains()
        Do

            If _iCurrWord >= _strDic.Length Then Exit Do

            Dim domain As String

            If chkReverse.Checked Then

                If _strFirst = "" Then
                    domain = String.Format("{0}", _strDic(_iCurrWord).Value)
                Else
                    domain = String.Format("{1}{0}", _strFirst, _strDic(_iCurrWord).Value)
                End If

            Else

                If _strFirst = "" Then
                    domain = String.Format("{0}", _strDic(_iCurrWord).Value)
                Else
                    domain = String.Format("{0}{1}", _strFirst, _strDic(_iCurrWord).Value)
                End If

            End If

            Dim url As String = domain

            'http://viewdns.info/dnsreport/?domain=1ten.com

            'Dim str As String = GetUrl("https://www.easywhois.com/guts.php?domain=" & url & "&mode=whois")

            Dim str As String = GetUrl("http://api.statdns.com/" & url & "." & _strTld & "/ns")

            'http://api.statdns.com/statdns.net/ns

            'Dim str As String = GetUrl("http://www.bigbiz.com/bigbiz/whois.pl?DOMAIN=" & url & "&TLD=" & StrTld & "&cmd=Show+my+domain+record")

            'Dim ff As Match = MyRegex2.Match(str)

            'If ff.Success Then

            If str.Contains("answer") Then

                _iCurrWord += 1

                If _listBad.ContainsKey(url) = False Then

                    _listBad.Add(url, url)
                    _keyResults -= 1

                    _iTaken += 1

                    SetStatusLabel(Me, MetroLabel5, "Invalid Domains: " & _iTaken)
                    SetStatusLabel(Me, MetroLabel6, "Domains Left: " & _keyResults)

                    ListboxAdd(Me, LstBoxTaken, url)

                    Save(url, False, _startTime)

                End If

                Debug.WriteLine(TimeStamp & "Not available - " & url)

                'Debug.WriteLine(timeStamp & "Not available - Expires " & ff.Groups(1).Value & " - " & url)

            End If

            If str.Contains("error") Then

                _iCurrWord += 1

                Debug.WriteLine(TimeStamp & " Available! - " & url)

                If _listGood.ContainsKey(url) = False Then

                    _listGood.Add(url, url)

                    _iGood += 1
                    _keyResults -= 1

                    SetStatusLabel(Me, MetroLabel4, "Valid Domains: " & _iGood)
                    SetStatusLabel(Me, MetroLabel6, "Domains Left: " & _keyResults)

                    ListboxAdd(Me, LstBoxValid, url)

                    Save(url, True, _startTime)

                End If

            End If

            MetroProgressBar(Me, metroProgressBar1, _iCurrWord, _keyResults)

        Loop
    End Sub

    Private Function GetUrl(ByVal url As String) As String
        Try

            Dim wc As New WebClient
            wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/35.0.1916.114 Safari/537.36")

            Return wc.DownloadString(url)

        Catch e As Exception
            Return "error"
        End Try
    End Function

    Private Sub Save(ByVal domain As String, ByVal isValidLog As Boolean, ByVal startT As String, Optional ByVal expires As String = "")
        Dim strPath As String

        Try
            If isValidLog Then
                If _strFirst = "" Then
                    strPath = String.Format("{0}\{2}-{1}+{3}+TLD=-ValidDomains.html", _dnsLogs, startT, _strKeyWord, _strTld)
                Else
                    strPath = String.Format("{0}\{2}-{1}+{3}+TLD={4}-ValidDomains.html", _dnsLogs, _strFirst, startT, _strKeyWord, _strTld)
                End If
            Else
                If _strFirst = "" Then
                    strPath = String.Format("{0}\{2}-{1}+{3}+TLD=-TakenDomains.html", _dnsLogs, startT, _strKeyWord, _strTld)
                Else
                    strPath = String.Format("{0}\{2}-{1}+{3}+TLD={4}-TakenDomains.html", _dnsLogs, _strFirst, startT, _strKeyWord, _strTld)
                End If
            End If

            Dim writer As New StreamWriter(strPath, True)

            If expires.Length <> 0 Then
                writer.WriteLine("<a href={0}http://{1}.{3}{0}>{1}.{3}</a> | {2}<br>", Chr(34), domain, expires, _strTld)
            Else
                writer.WriteLine("<a href={0}http://{1}.{2}{0}>{1}.{2}</a><br>", Chr(34), domain, _strTld)
            End If

            writer.Flush()
            writer.Close()
            writer.Dispose()

        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
    End Sub

    Private Sub Bgw_Disposed(sender As Object, e As EventArgs) Handles _bgw.Disposed
        MsgBox("Dtruly done")
    End Sub

    Private Sub Bgw_DoWork(sender As Object, e As DoWorkEventArgs) Handles _bgw.DoWork

        If _nextPage = 0 Then Exit Sub

        Dim strResults As String = DoWork(_strKeyWord, _nextPage)

        Dim rMatch As MatchCollection = _regWords.Matches(strResults)

        For Each m As Match In rMatch

            Dim word As String = m.Groups(1).Value

            If _listAltWords.ContainsKey(word) Then

            Else

                _listAltWords.Add(word, word)

                ListboxAdd(Me, ListBox1, word)

                Debug.WriteLine(word & " - " & ListBox1.Items.Count & " : " & _listAltWords.Count)

                _keyResults += 1

                MetroProgressBar(Me, metroProgressBar1, 1, _keyResults)

                SetStatusLabel(Me, LabelKeywords, "Keywords Found: " & _keyResults)

            End If

        Next

        If strResults.Contains("Next") Then
            _nextPage += 100
            _isKeyWordDone = False
        Else

            _isKeyWordDone = True
            _nextPage = 0

        End If
    End Sub

    Private Sub Bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles _bgw.RunWorkerCompleted

        If _isKeyWordDone Then

            Dim writer As New StreamWriter(_altwordLogs & "\" & _strKeyWord & ".txt", True)

            For Each word As KeyValuePair(Of String, String) In _listAltWords.Distinct()
                writer.WriteLine(word.Value)
            Next

            writer.Flush()
            writer.Close()
            writer.Dispose()

            If _listAltWords.Count <> 0 Then
                _strDic = Nothing
                _strDic = _listAltWords.ToArray()
            End If

            ButtonStart.Enabled = True

        Else

            If _nextPage <> 0 Then
                _bgw.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim writer As New StreamWriter(_altwordLogs & "\" & _strKeyWord & ".txt", True)

        For Each word As KeyValuePair(Of String, String) In _listAltWords.Distinct()
            writer.WriteLine(word.Value)
        Next

        writer.Flush()
        writer.Close()
        writer.Dispose()

    End Sub

    Private Sub ButtonLookup_Click(sender As Object, e As EventArgs) Handles ButtonLookup.Click

        _keyResults = 0

        _strKeyWord = TextKeyWord.Text

        If File.Exists(_altwordLogs & "\" & _strKeyWord & ".txt") Then File.Delete(_altwordLogs & "\" & _strKeyWord & ".txt")

        ListBox1.Items.Clear()
        _listAltWords.Clear()
        _nextPage = 1

        If _bgw.IsBusy = False Then _bgw.RunWorkerAsync()

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        _strTld = TextTLD.Text
        _strFirst = TextBox1.Text

        _startTime = DateTime.UtcNow.ToLocalTime.ToLocalTime().ToString.Replace(":", "-").Replace("/", "-")

        _listGood.Clear()
        _listBad.Clear()

        _iTaken = 0
        _iGood = 0
        _iCurrWord = 0

        Watch.Start()
        'SetStatusLabel(Me, MetroLabel4, "Status: Started!", 0)

        MetroTabControl1.SelectedTab = _MetroTabPage2

        For i = 0 To metroTrackBar1.Value

            Debug.WriteLine(i)

            Dim tStart As ThreadStart = Sub() CheckDomains()
            Call New Thread(tStart).Start()

        Next i

    End Sub

    Private Function DoWork(ByVal keyword As String, Optional ByVal page As Integer = 1) As String

        Dim wc As New WebClient

        Dim sUrl As String = "http://www.onelook.com/?w=*:" & keyword & "&ws1=1&scwo=1&first=" & page

        Dim strResults As String = wc.DownloadString(sUrl)

        Return strResults

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Directory.Exists(_altwordLogs) = False Then Directory.CreateDirectory(_altwordLogs)
        If Directory.Exists(_dnsLogs) = False Then Directory.CreateDirectory(_dnsLogs)

        'StrDic = File.ReadAllLines(Application.StartupPath & "\test.txt")

    End Sub

    Private Sub metroTrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles metroTrackBar1.Scroll
        MetroLabel2.Text = "Sockets [" & e.NewValue & "]:"
    End Sub

#End Region 'Methods


End Class