Imports MetroFramework.Controls

Public Module ModTControl

#Region "Delegates"

    Private Delegate Sub ListboxAddDelegate(ByVal form As Form, ByVal listBox As ListBox, ByVal text As String)

    Private Delegate Sub MetroProgressDelegate(ByVal form As Form, ByVal metroProgress As MetroProgressBar, ByVal value As Integer, ByVal max As Integer)

    Private Delegate Sub StatusLabelDelegate(ByVal form As Form, ByVal toolstrip As MetroLabel, ByVal text As String)

#End Region 'Delegates

#Region "Methods"

    Public Sub ListboxAdd(ByVal form As Form, ByVal listBox As ListBox, ByVal text As String)
        If listBox.InvokeRequired Then
            Dim myDelegate As New ListboxAddDelegate(AddressOf ListboxAdd)
            form.Invoke(myDelegate, New Object() {form, listBox, text})
        Else
            listBox.Items.Add(text)
        End If
    End Sub

    Public Sub MetroProgressBar(ByVal form As Form, ByVal metroProgress As MetroProgressBar, ByVal value As Integer, Optional ByVal max As Integer = 0)
        If metroProgress.InvokeRequired Then
            Dim myDelegate As New MetroProgressDelegate(AddressOf MetroProgressBar)
            form.Invoke(myDelegate, New Object() {form, metroProgress, value, max})
        Else

            If max <> 0 Then
                metroProgress.Maximum = max

            End If

            metroProgress.Value = value

        End If
    End Sub

    Public Sub SetStatusLabel(ByVal form As Form, ByVal toolstrip As MetroLabel, ByVal text As String)
        Try

            If toolstrip.InvokeRequired Then
                Dim myDelegate As New StatusLabelDelegate(AddressOf SetStatusLabel)
                form.Invoke(myDelegate, New Object() {form, toolstrip, text})
            Else
                toolstrip.Text = (text)
            End If

        Catch ex As Exception

        End Try
    End Sub



#End Region 'Methods

End Module