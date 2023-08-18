Imports System.ComponentModel

Public Class FrmWebScraper


    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub

    Private Sub btnFeedback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeedback.Click
        frmfeedback.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        trmDown.Stop()
        chkboxAllyear.Text = "Select All"
        chkboxYear1.Text = "Winter 2018"
        chkboxYear2.Text = "Summer 2018"
        chkboxYear3.Text = "Winter 2019"
        chkboxYear4.Text = "Summer 2019"
        chkboxYear5.Text = "Winter 2020"
        chkboxYear6.Text = "Summer 2020"
        chkboxAllSyllabus.Text = "Select All"
        chkboxSub1.Text = "Basic Mathematics"
        chkboxSub2.Text = "English"
        chkboxSub3.Text = "ECHM"
        chkboxSub4.Text = "CP"
        chkboxSub5.Text = "FDE"
        chkboxSub6.Text = "FCA"

        chkboxAllSyllabus.Enabled = True
        chkboxSub1.Enabled = True
        chkboxSub2.Enabled = True
        chkboxSub3.Enabled = True
        chkboxSub4.Enabled = True
        chkboxSub5.Enabled = True
        chkboxSub6.Enabled = True

        chkboxAllsub.Text = "Select All"
        chkboxPap1.Text = "Basic Mathematics"
        chkboxPap2.Text = "English"
        chkboxPap3.Text = "ECHM"
        chkboxPap4.Text = "CP"
        chkboxPap5.Text = "FDE"
        chkboxPap5.Enabled = True
        chkboxPap6.Text = "FCA"
        chkboxPap6.Enabled = False

        chkboxPap1.Enabled = True
        chkboxPap2.Enabled = True
        chkboxPap3.Enabled = True
        chkboxPap4.Enabled = True



    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        If cmbSemester.SelectedIndex = 0 Then

            chkboxAllSyllabus.Text = "Select All"
            chkboxSub1.Text = "Basic Mathematics"
            chkboxSub2.Text = "English"
            chkboxSub3.Text = "ECHM"
            chkboxSub4.Text = "CP"
            chkboxSub5.Text = "FDE"
            chkboxSub6.Text = "FCA"

            chkboxAllSyllabus.Enabled = True
            chkboxSub1.Enabled = True
            chkboxSub2.Enabled = True
            chkboxSub3.Enabled = True
            chkboxSub4.Enabled = True
            chkboxSub5.Enabled = True
            chkboxSub6.Enabled = True

            chkboxAllsub.Text = "Select All"
            chkboxPap1.Text = "Basic Mathematics"
            chkboxPap2.Text = "English"
            chkboxPap3.Text = "ECHM"
            chkboxPap4.Text = "CP"
            chkboxPap5.Text = "FDE"
            chkboxPap5.Enabled = True
            chkboxPap6.Text = "FCA"
            chkboxPap6.Enabled = False

            chkboxPap1.Enabled = True
            chkboxPap2.Enabled = True
            chkboxPap3.Enabled = True
            chkboxPap4.Enabled = True


        ElseIf cmbSemester.SelectedIndex = 1 Then

            chkboxAllSyllabus.Text = "Select All"
            chkboxSub1.Text = "CPD"
            chkboxSub2.Text = "Advanced Mathematics"
            chkboxSub3.Text = "Basic Physics"
            chkboxSub4.Text = "Basic Electronics"
            chkboxSub5.Text = "ACP"
            chkboxSub6.Text = "SWPD"

            chkboxAllSyllabus.Enabled = True
            chkboxSub1.Enabled = True
            chkboxSub2.Enabled = True
            chkboxSub3.Enabled = True
            chkboxSub4.Enabled = True
            chkboxSub5.Enabled = True
            chkboxSub6.Enabled = True

            chkboxAllsub.Text = "Select All"
            chkboxPap1.Text = "CPD"
            chkboxPap1.Enabled = False
            chkboxPap2.Text = "Advanced Mathematics"
            chkboxPap3.Text = "Basic Physics"
            chkboxPap4.Text = "Basic Electronics"
            chkboxPap5.Text = "ACP"
            chkboxPap5.Enabled = True
            chkboxPap6.Text = "SWPD"
            chkboxPap6.Enabled = False

            chkboxPap2.Enabled = True
            chkboxPap3.Enabled = True
            chkboxPap4.Enabled = True


        ElseIf cmbSemester.SelectedIndex = 2 Then

            chkboxAllSyllabus.Text = "Select All"
            chkboxSub1.Text = "OS"
            chkboxSub2.Text = "C++"
            chkboxSub3.Text = "DBMS"
            chkboxSub4.Text = "DS"
            chkboxSub5.Text = "MALP"
            chkboxSub6.Text = "----"
            chkboxSub6.Enabled = False

            chkboxAllSyllabus.Enabled = True
            chkboxSub1.Enabled = True
            chkboxSub2.Enabled = True
            chkboxSub3.Enabled = True
            chkboxSub4.Enabled = True
            chkboxSub5.Enabled = True

            chkboxAllsub.Text = "Select All"
            chkboxPap1.Text = "OS"
            chkboxPap2.Text = "C++"
            chkboxPap3.Text = "DBMS"
            chkboxPap4.Text = "DS"
            chkboxPap5.Text = "MALP"
            chkboxPap5.Enabled = True
            chkboxPap6.Text = "----"
            chkboxPap6.Enabled = False

            chkboxPap1.Enabled = True
            chkboxPap2.Enabled = True
            chkboxPap3.Enabled = True
            chkboxPap4.Enabled = True


        ElseIf cmbSemester.SelectedIndex = 3 Then

            chkboxAllSyllabus.Text = "Select All"
            chkboxSub1.Text = "ADBMS"
            chkboxSub2.Text = "CN"
            chkboxSub3.Text = "FSD"
            chkboxSub4.Text = "COA"
            chkboxSub5.Text = ".NET"
            chkboxSub6.Text = "WDT"

            chkboxAllSyllabus.Enabled = True
            chkboxSub1.Enabled = True
            chkboxSub2.Enabled = True
            chkboxSub3.Enabled = True
            chkboxSub4.Enabled = True
            chkboxSub5.Enabled = True
            chkboxSub6.Enabled = True




            chkboxAllsub.Text = "Select All"
            chkboxPap1.Text = "ADBMS"
            chkboxPap2.Text = "CN"
            chkboxPap3.Text = "FSD"
            chkboxPap4.Text = "COA"
            chkboxPap5.Text = ".NET"
            chkboxPap5.Enabled = True
            chkboxPap6.Text = "WDT"
            chkboxPap6.Enabled = False

            chkboxPap1.Enabled = True
            chkboxPap2.Enabled = True
            chkboxPap3.Enabled = True
            chkboxPap4.Enabled = True


        ElseIf cmbSemester.SelectedIndex = 4 Then

            chkboxAllSyllabus.Text = "Select All"
            chkboxSub1.Text = "CMTS"
            chkboxSub2.Text = "DWPD"
            chkboxSub3.Text = "Java Programming"
            chkboxSub4.Text = "CNS"
            chkboxSub5.Text = "----"
            chkboxSub5.Enabled = False
            chkboxSub6.Enabled = False
            chkboxSub6.Text = "----"

            chkboxAllSyllabus.Enabled = True
            chkboxSub1.Enabled = True
            chkboxSub2.Enabled = True
            chkboxSub3.Enabled = True
            chkboxSub4.Enabled = True


            chkboxAllsub.Text = "Select All"
            chkboxPap1.Text = "CMTS"
            chkboxPap2.Text = "DWPD"
            chkboxPap3.Text = "Java Progarmming"
            chkboxPap4.Text = "CNS"
            chkboxPap5.Text = "----"
            chkboxPap5.Enabled = False
            chkboxPap6.Text = "----"
            chkboxPap6.Enabled = False
            chkboxPap2.Enabled = True
            chkboxPap3.Enabled = True
            chkboxPap4.Enabled = True

        ElseIf cmbSemester.SelectedIndex = 5 Then

            chkboxAllSyllabus.Text = "Select All"
            chkboxSub1.Text = "AJAVA"
            chkboxSub2.Text = "PPUD"
            chkboxSub3.Text = "NMA"
            chkboxSub4.Text = "MCAD"
            chkboxSub5.Text = "----"
            chkboxSub5.Enabled = False
            chkboxSub6.Enabled = False
            chkboxSub6.Text = "----"

            chkboxAllSyllabus.Enabled = True
            chkboxSub1.Enabled = True
            chkboxSub2.Enabled = True
            chkboxSub3.Enabled = True
            chkboxSub4.Enabled = True

            chkboxAllsub.Text = "Select All"
            chkboxPap1.Text = "AJAVA"
            chkboxPap2.Text = "PPUD"
            chkboxPap2.Enabled = False
            chkboxPap3.Text = "NMA"
            chkboxPap4.Text = "MCAD"
            chkboxPap5.Text = "----"
            chkboxPap5.Enabled = False
            chkboxPap6.Text = "----"
            chkboxPap6.Enabled = False

            chkboxPap1.Enabled = True
            chkboxPap3.Enabled = True
            chkboxPap4.Enabled = True



        End If
    End Sub




    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        About.Show()
        frmfeedback.Hide()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        frmfeedback.Show()
        About.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub OthersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OthersToolStripMenuItem.Click

    End Sub

    Private Sub SentFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SentFeedbackToolStripMenuItem.Click
        Sent_Feedback.Show()

    End Sub

    Private Sub TechnicalSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnicalSupportToolStripMenuItem.Click
        Technical_Support.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        ' For Each chk1 As CheckBox In grpboxSyllabus.Controls
        'chk1.Checked = False
        'Next
        'For Each chk7 As CheckBox In grpboxSub.Controls
        'chk7.Checked = False
        'Next
        'For Each chk12 As CheckBox In grpboxYear.Controls
        'chk12.Checked = False
        'Next

        trmDown.Start()
        Dim sem As Integer = cmbSemester.SelectedIndex

        Select Case sem
            Case 0
                'syllabus
                If chkboxSub1.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3300001.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub2.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3300002.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub3.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3300003.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub4.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3310701.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub5.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3310702.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub6.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3310703.pdf >> url.txt ")
                    'Close()
                End If

                'papers
                If chkboxYear1.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/w2018/DI/3300001.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/w2018/DI/3300002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3300003.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3310701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3310702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap6.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3310703.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear2.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3300001.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3300002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3300003.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3310701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3310702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap6.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3310703.pdf>> url.txt ")
                        'Close()
                    End If
                End If
                If chkboxYear3.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3300001.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3300002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3300003.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3310701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3310702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap6.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3310703.pdf>> url.txt ")
                        'Close()
                    End If
                End If
                If chkboxYear4.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3300001.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3300002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3300003.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3310701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3310702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap6.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3310703.pdf>> url.txt ")
                        'Close()
                    End If
                End If
                If chkboxYear5.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3300001.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3300002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3300003.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3310701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3310702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap6.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3310703.pdf>> url.txt ")
                        'Close()
                    End If
                End If
                If chkboxYear6.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3300001.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3300002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3300003.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3310701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3310702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap6.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3310703.pdf>> url.txt ")
                        'Close()
                    End If
                End If


            Case 1
                'syllabus
                If chkboxSub1.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320002.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub2.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320705.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub3.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320701.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub4.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320702.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub5.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320703.pdf >> url.txt ")
                    'Close()
                End If

                'PAPERS
                If chkboxYear1.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320703.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear2.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320703.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear3.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320703.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear4.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320703.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear5.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320703.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear6.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320002.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320703.pdf>> url.txt ")
                        'Close()
                    End If
                End If

    'assignment

            Case 2
                'syllabus
                If chkboxSub1.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330701.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub2.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330702.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub3.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330703.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub4.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330704.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub5.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330705.pdf >> url.txt ")
                    'Close()
                End If

                'PAPERS
                If chkboxYear1.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330704.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330705.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear2.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330704.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330705.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear3.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330704.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330705.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear4.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330704.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330705.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear5.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330704.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330705.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear6.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330704.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330705.pdf>> url.txt ")
                        'Close()
                    End If
                End If

            Case 3
                'syllabus
                If chkboxSub1.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340701.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub2.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340702.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub3.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3341603.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub4.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340705.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub5.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340704.pdf >> url.txt ")
                    'Close()
                End If

                'PAPER
                If chkboxYear1.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3341603.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear2.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3341603.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear3.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3341603.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear4.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3341603.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear5.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3341603.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear6.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3341603.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340705.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap5.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

            Case 4
                'syllabus
                If chkboxSub1.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350701.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub2.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350702.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub3.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350703.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub4.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350704.pdf >> url.txt ")
                    'Close()
                End If

                'PAPER
                If chkboxYear1.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear2.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear3.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear4.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear5.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear6.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

            Case 5
                'syllabus
                If chkboxSub1.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360701.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub2.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360702.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub3.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360703.pdf >> url.txt ")
                    'Close()
                End If
                If chkboxSub4.Checked = True Then
                    Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360704.pdf >> url.txt ")
                    'Close()
                End If

                'PAPERS
                If chkboxYear1.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360704.pdf>> url.txt ")
                        'Close()
                    End If
                End If

                If chkboxYear2.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear3.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear4.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear5.Checked = True Then
                    If chkboxPap1.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360704.pdf>> url.txt ")
                        'Close()
                    End If
                End If


                If chkboxYear6.Checked = True Then
                    If chkboxPap1.Checked = True Then

                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360701.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap2.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360702.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap3.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360703.pdf>> url.txt ")
                        'Close()
                    End If
                    If chkboxPap4.Checked = True Then
                        Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360704.pdf>> url.txt ")
                        'Close()
                    End If
                End If
            Case Else
                Me.Show()
        End Select

        Shell("GnuWin32\bin\wget.exe --no-check-certificate -i url.txt -x", AppWinStyle.NormalFocus)

        Shell("cmd.exe erase C:\Users\DELL\Documents\Visual Studio 2019\ProjectAnktVvk\ProjectAnktVvk\bin\Debug\url.txt")


        '  MessageBox.Show("Files Are Downloaded", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub




    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnDown.MouseEnter
        btnDown.BackColor = Color.SteelBlue
        btnDown.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnDown.MouseLeave
        btnDown.BackColor = Color.Empty
        btnDown.ForeColor = Color.Black

    End Sub


    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles chkboxAllSyllabus.Click
        For Each chk1 As CheckBox In grpboxSyllabus.Controls

            If chkboxAllSyllabus.Checked Then

                chk1.Checked = True
            Else
                chk1.Checked = False
            End If

        Next

    End Sub

    Private Sub CheckBox7_Click(sender As Object, e As EventArgs) Handles chkboxAllsub.Click
        For Each chk7 As CheckBox In grpboxSub.Controls
            If chkboxAllsub.Checked Then
                chk7.Checked = True
            Else
                chk7.Checked = False
            End If
        Next

    End Sub

    Private Sub CheckBox12_Click(sender As Object, e As EventArgs) Handles chkboxAllyear.Click
        For Each chk12 As CheckBox In grpboxYear.Controls
            If chkboxAllyear.Checked Then
                chk12.Checked = True
            Else
                chk12.Checked = False
            End If
        Next

    End Sub

    Private Sub trmDown_Tick(sender As Object, e As EventArgs) Handles trmDown.Tick
        pbarDown.Visible = True
        lblDown.Visible = True
        lblpercentage.Visible = True
        pbarDown.Increment(1)
        lblDown.Text = pbarDown.Value
        If (pbarDown.Value = 100) Then
            trmDown.Stop()
            pbarDown.Visible = False
            lblDown.Visible = False
            lblpercentage.Visible = False
            MessageBox.Show("Files Are Downloaded", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Me.Show()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tmrProgress_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick

    End Sub
End Class
