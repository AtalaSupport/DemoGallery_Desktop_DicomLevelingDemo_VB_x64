Namespace DicomLevelingDemo
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If Not disposing AndAlso Not (components.Equals(Nothing)) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.imageViewer1 = New Atalasoft.Imaging.WinControls.ImageViewer
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip
            Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.windowSlider = New System.Windows.Forms.TrackBar
            Me.levelSlider = New System.Windows.Forms.TrackBar
            Me.windowLabel = New System.Windows.Forms.Label
            Me.levelLabel = New System.Windows.Forms.Label
            Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.HelpAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.menuStrip1.SuspendLayout()
            CType(Me.windowSlider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.levelSlider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'imageViewer1
            '
            Me.imageViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.imageViewer1.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ScaleToGray
            Me.imageViewer1.DisplayProfile = Nothing
            Me.imageViewer1.Location = New System.Drawing.Point(12, 27)
            Me.imageViewer1.Magnifier.BackColor = System.Drawing.Color.White
            Me.imageViewer1.Magnifier.BorderColor = System.Drawing.Color.Black
            Me.imageViewer1.Magnifier.Size = New System.Drawing.Size(100, 100)
            Me.imageViewer1.Name = "imageViewer1"
            Me.imageViewer1.OutputProfile = Nothing
            Me.imageViewer1.Selection = Nothing
            Me.imageViewer1.Size = New System.Drawing.Size(568, 444)
            Me.imageViewer1.TabIndex = 0
            Me.imageViewer1.Text = "imageViewer1"
            '
            'menuStrip1
            '
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.HelpToolStripMenuItem})
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Size = New System.Drawing.Size(592, 24)
            Me.menuStrip1.TabIndex = 1
            Me.menuStrip1.Text = "menuStrip1"
            '
            'fileToolStripMenuItem
            '
            Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.exitToolStripMenuItem})
            Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
            Me.fileToolStripMenuItem.Text = "File"
            '
            'openToolStripMenuItem
            '
            Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
            Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
            Me.openToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
            Me.openToolStripMenuItem.Text = "Open"
            '
            'exitToolStripMenuItem
            '
            Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            Me.exitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
            Me.exitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
            Me.exitToolStripMenuItem.Text = "Exit"
            '
            'windowSlider
            '
            Me.windowSlider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.windowSlider.LargeChange = 500
            Me.windowSlider.Location = New System.Drawing.Point(13, 495)
            Me.windowSlider.Maximum = 10000
            Me.windowSlider.Name = "windowSlider"
            Me.windowSlider.Size = New System.Drawing.Size(180, 42)
            Me.windowSlider.TabIndex = 2
            Me.windowSlider.TickFrequency = 500
            '
            'levelSlider
            '
            Me.levelSlider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.levelSlider.LargeChange = 500
            Me.levelSlider.Location = New System.Drawing.Point(400, 494)
            Me.levelSlider.Maximum = 10000
            Me.levelSlider.Name = "levelSlider"
            Me.levelSlider.Size = New System.Drawing.Size(180, 42)
            Me.levelSlider.TabIndex = 3
            Me.levelSlider.TickFrequency = 500
            '
            'windowLabel
            '
            Me.windowLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.windowLabel.Location = New System.Drawing.Point(13, 475)
            Me.windowLabel.Name = "windowLabel"
            Me.windowLabel.Size = New System.Drawing.Size(180, 20)
            Me.windowLabel.TabIndex = 4
            Me.windowLabel.Text = "Window"
            '
            'levelLabel
            '
            Me.levelLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.levelLabel.Location = New System.Drawing.Point(400, 474)
            Me.levelLabel.Name = "levelLabel"
            Me.levelLabel.Size = New System.Drawing.Size(180, 20)
            Me.levelLabel.TabIndex = 5
            Me.levelLabel.Text = "Level"
            '
            'HelpToolStripMenuItem
            '
            Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpAboutToolStripMenuItem})
            Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
            Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
            Me.HelpToolStripMenuItem.Text = "Help"
            '
            'HelpAboutToolStripMenuItem
            '
            Me.HelpAboutToolStripMenuItem.Name = "HelpAboutToolStripMenuItem"
            Me.HelpAboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.HelpAboutToolStripMenuItem.Text = "About ..."
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(592, 531)
            Me.Controls.Add(Me.levelSlider)
            Me.Controls.Add(Me.windowSlider)
            Me.Controls.Add(Me.windowLabel)
            Me.Controls.Add(Me.levelLabel)
            Me.Controls.Add(Me.imageViewer1)
            Me.Controls.Add(Me.menuStrip1)
            Me.MainMenuStrip = Me.menuStrip1
            Me.Name = "Form1"
            Me.Text = "Dicom Window and Leveling"
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            CType(Me.windowSlider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.levelSlider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private WithEvents imageViewer1 As Atalasoft.Imaging.WinControls.ImageViewer
        Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
        Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents windowSlider As System.Windows.Forms.TrackBar
        Private WithEvents levelSlider As System.Windows.Forms.TrackBar
        Private WithEvents windowLabel As System.Windows.Forms.Label
        Private WithEvents levelLabel As System.Windows.Forms.Label
        Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents HelpAboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace