Imports System.Diagnostics




Public Class Form1

    Private Sub killRadeon()
        For Each p As Process In Process.GetProcessesByName("RadeonSoftware")
            p.Kill()
            p.Close()

        Next
    End Sub


    Private Sub killevernote()
        For Each p As Process In Process.GetProcessesByName("Evernote")
            p.Kill()
            p.Close()

        Next
    End Sub


    Private Sub killSkypeupdate()
        For Each p As Process In Process.GetProcessesByName("SkypeC2CAutoUpdateSvc")
            p.Kill()
            p.Close()

        Next
    End Sub


    Private Sub killSkypepnr()
        For Each p As Process In Process.GetProcessesByName("SkypeC2CPNRSvc")
            p.Kill()
            p.Close()

        Next
    End Sub


    Private Sub killSkype()
        For Each p As Process In Process.GetProcessesByName("Skype")
            p.Kill()
            p.Close()

        Next
    End Sub


    Private Sub KillSomething()
        For Each p As Process In Process.GetProcessesByName("chrome")
            p.Kill()
            p.Close()

        Next
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            killRadeon()
            killevernote()
            killSkype()
            killSkypepnr()
            killSkypeupdate()

            MessageBox.Show("Në Rregull ^_^")


        Else
            MessageBox.Show("Kliko te paktën njërin 👍")

        End If



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        MessageBox.Show("^_~  Hello   (●'◡'●)")




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Kontakto në : ReeNzoo124   ❤")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


End Class