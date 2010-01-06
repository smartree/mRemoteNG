﻿Imports WeifenLuo.WinFormsUI.Docking
Imports System.IO
Imports mRemote.App.Runtime

Namespace UI
    Namespace Window
        Public Class About
            Inherits UI.Window.Base

#Region "Form Init"
            Friend WithEvents lblCopyright As System.Windows.Forms.Label
            Friend WithEvents lblTitle As System.Windows.Forms.Label
            Friend WithEvents lblVersion As System.Windows.Forms.Label
            Friend WithEvents lblLicense As System.Windows.Forms.Label
            Friend WithEvents txtChangeLog As System.Windows.Forms.TextBox
            Friend WithEvents lblChangeLog As System.Windows.Forms.Label
            Friend WithEvents pnlBottom As System.Windows.Forms.Panel
            Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
            Friend WithEvents lblEdition As System.Windows.Forms.Label
            Friend WithEvents llblCopyright2 As System.Windows.Forms.LinkLabel
            Friend WithEvents llblCopyright3 As System.Windows.Forms.LinkLabel
            Friend WithEvents pnlTop As System.Windows.Forms.Panel

            Private Sub InitializeComponent()
                Me.pnlTop = New System.Windows.Forms.Panel
                Me.lblEdition = New System.Windows.Forms.Label
                Me.pbLogo = New System.Windows.Forms.PictureBox
                Me.pnlBottom = New System.Windows.Forms.Panel
                Me.llblCopyright3 = New System.Windows.Forms.LinkLabel
                Me.llblCopyright2 = New System.Windows.Forms.LinkLabel
                Me.txtChangeLog = New System.Windows.Forms.TextBox
                Me.lblTitle = New System.Windows.Forms.Label
                Me.lblVersion = New System.Windows.Forms.Label
                Me.lblChangeLog = New System.Windows.Forms.Label
                Me.lblLicense = New System.Windows.Forms.Label
                Me.lblCopyright = New System.Windows.Forms.Label
                Me.pnlTop.SuspendLayout()
                CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
                Me.pnlBottom.SuspendLayout()
                Me.SuspendLayout()
                '
                'pnlTop
                '
                Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.pnlTop.BackColor = System.Drawing.Color.Black
                Me.pnlTop.Controls.Add(Me.lblEdition)
                Me.pnlTop.Controls.Add(Me.pbLogo)
                Me.pnlTop.Location = New System.Drawing.Point(-1, -1)
                Me.pnlTop.Name = "pnlTop"
                Me.pnlTop.Size = New System.Drawing.Size(788, 174)
                Me.pnlTop.TabIndex = 2
                '
                'lblEdition
                '
                Me.lblEdition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.lblEdition.ForeColor = System.Drawing.Color.LightGray
                Me.lblEdition.Location = New System.Drawing.Point(464, 178)
                Me.lblEdition.Name = "lblEdition"
                Me.lblEdition.Size = New System.Drawing.Size(318, 24)
                Me.lblEdition.TabIndex = 2
                Me.lblEdition.Text = "Edition"
                Me.lblEdition.TextAlign = System.Drawing.ContentAlignment.BottomRight
                Me.lblEdition.Visible = False
                '
                'pbLogo
                '
                Me.pbLogo.Image = Global.mRemote.My.Resources.Resources.Logo
                Me.pbLogo.Location = New System.Drawing.Point(13, 22)
                Me.pbLogo.Name = "pbLogo"
                Me.pbLogo.Size = New System.Drawing.Size(409, 129)
                Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
                Me.pbLogo.TabIndex = 1
                Me.pbLogo.TabStop = False
                '
                'pnlBottom
                '
                Me.pnlBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                            Or System.Windows.Forms.AnchorStyles.Left) _
                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.pnlBottom.BackColor = System.Drawing.Color.DimGray
                Me.pnlBottom.Controls.Add(Me.llblCopyright3)
                Me.pnlBottom.Controls.Add(Me.llblCopyright2)
                Me.pnlBottom.Controls.Add(Me.txtChangeLog)
                Me.pnlBottom.Controls.Add(Me.lblTitle)
                Me.pnlBottom.Controls.Add(Me.lblVersion)
                Me.pnlBottom.Controls.Add(Me.lblChangeLog)
                Me.pnlBottom.Controls.Add(Me.lblLicense)
                Me.pnlBottom.Controls.Add(Me.lblCopyright)
                Me.pnlBottom.Location = New System.Drawing.Point(-1, 177)
                Me.pnlBottom.Name = "pnlBottom"
                Me.pnlBottom.Size = New System.Drawing.Size(788, 389)
                Me.pnlBottom.TabIndex = 0
                '
                'llblCopyright3
                '
                Me.llblCopyright3.AutoSize = True
                Me.llblCopyright3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.llblCopyright3.LinkColor = System.Drawing.Color.YellowGreen
                Me.llblCopyright3.Location = New System.Drawing.Point(29, 111)
                Me.llblCopyright3.Name = "llblCopyright3"
                Me.llblCopyright3.Size = New System.Drawing.Size(57, 13)
                Me.llblCopyright3.TabIndex = 5
                Me.llblCopyright3.TabStop = True
                Me.llblCopyright3.Text = "Copyright3"
                '
                'llblCopyright2
                '
                Me.llblCopyright2.AutoSize = True
                Me.llblCopyright2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.llblCopyright2.LinkColor = System.Drawing.Color.YellowGreen
                Me.llblCopyright2.Location = New System.Drawing.Point(29, 93)
                Me.llblCopyright2.Name = "llblCopyright2"
                Me.llblCopyright2.Size = New System.Drawing.Size(57, 13)
                Me.llblCopyright2.TabIndex = 5
                Me.llblCopyright2.TabStop = True
                Me.llblCopyright2.Text = "Copyright2"
                '
                'txtChangeLog
                '
                Me.txtChangeLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                            Or System.Windows.Forms.AnchorStyles.Left) _
                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.txtChangeLog.BackColor = System.Drawing.Color.DimGray
                Me.txtChangeLog.BorderStyle = System.Windows.Forms.BorderStyle.None
                Me.txtChangeLog.Cursor = System.Windows.Forms.Cursors.Default
                Me.txtChangeLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.txtChangeLog.ForeColor = System.Drawing.Color.White
                Me.txtChangeLog.Location = New System.Drawing.Point(115, 158)
                Me.txtChangeLog.Multiline = True
                Me.txtChangeLog.Name = "txtChangeLog"
                Me.txtChangeLog.ReadOnly = True
                Me.txtChangeLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
                Me.txtChangeLog.Size = New System.Drawing.Size(670, 229)
                Me.txtChangeLog.TabIndex = 4
                Me.txtChangeLog.TabStop = False
                '
                'lblTitle
                '
                Me.lblTitle.AutoSize = True
                Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblTitle.Location = New System.Drawing.Point(13, 19)
                Me.lblTitle.Name = "lblTitle"
                Me.lblTitle.Size = New System.Drawing.Size(120, 24)
                Me.lblTitle.TabIndex = 3
                Me.lblTitle.Text = "mRemoteNG"
                '
                'lblVersion
                '
                Me.lblVersion.AutoSize = True
                Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblVersion.Location = New System.Drawing.Point(17, 50)
                Me.lblVersion.Name = "lblVersion"
                Me.lblVersion.Size = New System.Drawing.Size(58, 18)
                Me.lblVersion.TabIndex = 2
                Me.lblVersion.Text = "Version"
                '
                'lblChangeLog
                '
                Me.lblChangeLog.AutoSize = True
                Me.lblChangeLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblChangeLog.Location = New System.Drawing.Point(16, 155)
                Me.lblChangeLog.Name = "lblChangeLog"
                Me.lblChangeLog.Size = New System.Drawing.Size(92, 18)
                Me.lblChangeLog.TabIndex = 2
                Me.lblChangeLog.Text = "Change Log:"
                '
                'lblLicense
                '
                Me.lblLicense.AutoSize = True
                Me.lblLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblLicense.Location = New System.Drawing.Point(28, 129)
                Me.lblLicense.Name = "lblLicense"
                Me.lblLicense.Size = New System.Drawing.Size(44, 13)
                Me.lblLicense.TabIndex = 2
                Me.lblLicense.Text = "License"
                '
                'lblCopyright
                '
                Me.lblCopyright.AutoSize = True
                Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblCopyright.Location = New System.Drawing.Point(17, 68)
                Me.lblCopyright.Name = "lblCopyright"
                Me.lblCopyright.Size = New System.Drawing.Size(71, 18)
                Me.lblCopyright.TabIndex = 2
                Me.lblCopyright.Text = "Copyright"
                '
                'About
                '
                Me.BackColor = System.Drawing.Color.White
                Me.ClientSize = New System.Drawing.Size(784, 564)
                Me.Controls.Add(Me.pnlTop)
                Me.Controls.Add(Me.pnlBottom)
                Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.ForeColor = System.Drawing.Color.White
                Me.Icon = Global.mRemote.My.Resources.Resources.mRemote_Tray_Icon
                Me.MaximumSize = New System.Drawing.Size(20000, 10000)
                Me.Name = "About"
                Me.TabText = "About"
                Me.Text = "About"
                Me.pnlTop.ResumeLayout(False)
                Me.pnlTop.PerformLayout()
                CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
                Me.pnlBottom.ResumeLayout(False)
                Me.pnlBottom.PerformLayout()
                Me.ResumeLayout(False)

            End Sub
#End Region

#Region "Public Methods"
            Public Sub New(ByVal Panel As DockContent)
                Me.WindowType = Type.About
                Me.DockPnl = Panel
                Me.InitializeComponent()
            End Sub
#End Region

#Region "Form Stuff"
            Private Sub About_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
                ApplyLanguage()
                ApplyEditions()

                Try
                    Me.lblVersion.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
                    Me.lblLicense.Text = Language.Base.ReleasedUnderGPL

                    Me.lblCopyright.Text = My.Application.Info.Copyright

                    Me.llblCopyright2.Text = "Contains VNC viewer software licensed from SmartCode Solutions"
                    Me.llblCopyright2.Links.Add(43, 100, (App.Info.General.SmartCodeURL))

                    Me.llblCopyright3.Text = "Some Icons by FAMFAMFAM"
                    Me.llblCopyright3.Links.Add(14, 100, (App.Info.General.FamFamFamURL))

                    If File.Exists(My.Application.Info.DirectoryPath & "\ChangeLog.txt") Then
                        Dim sR As New StreamReader(My.Application.Info.DirectoryPath & "\ChangeLog.txt")
                        Me.txtChangeLog.Text = sR.ReadToEnd
                        sR.Close()
                    End If
                Catch ex As Exception
                    mC.AddMessage(Messages.MessageClass.ErrorMsg, "Loading About failed" & vbNewLine & ex.Message, True)
                End Try
            End Sub

            Private Sub ApplyLanguage()
                lblChangeLog.Text = Language.Base.ChangeLog
                lblLicense.Text = Language.Base.License
                TabText = Language.Base.About
                Text = Language.Base.About
            End Sub

            Private Sub ApplyEditions()
                If App.Editions.Spanlink.Enabled Then
                    lblEdition.Text = "Spanlink Communications"
                    lblEdition.Visible = True
                End If
            End Sub

            Private Sub llblCopyright2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblCopyright2.LinkClicked
                Process.Start(App.Info.General.SmartCodeURL)
            End Sub

            Private Sub llblCopyright3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblCopyright3.LinkClicked
                Process.Start(App.Info.General.FamFamFamURL)
            End Sub
#End Region

        End Class
    End Namespace
End Namespace