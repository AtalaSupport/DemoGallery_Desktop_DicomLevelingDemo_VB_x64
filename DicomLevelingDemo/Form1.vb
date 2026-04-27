Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Atalasoft.Imaging
Imports Atalasoft.Imaging.Codec
Imports Atalasoft.Imaging.Codec.Dicom
Imports Atalasoft.Imaging.WinControls
Imports System.IO

Namespace DicomLevelingDemo
    Partial Public Class Form1
        Inherits Form
        Private _stm As Stream
        Private _dImage As DicomImage
        Private _dataSet As DicomDataset
        Private _image As AtalaImage

        Public Sub New()
            InitializeComponent()

            ' Add the DicomDecoder to the registered decoders
            RegisteredDecoders.Decoders.Add(New DicomDecoder())

            ' hook into form closing so we can clean up
            AddHandler Me.FormClosing, AddressOf Form1_FormClosing
        End Sub

        Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            ' close all open items
            CloseCurrentItems()
        End Sub

        Private Sub openToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripMenuItem.Click
            Dim oifd As New OpenImageFileDialog()
            oifd.Title = "Select a Dicom Image"

            If oifd.ShowDialog() = DialogResult.OK Then
                Dim stm As FileStream = Nothing
                Try
                    ' open the file read-only
                    stm = New FileStream(oifd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read)

                    ' Ensure that the file is a Dicom file
                    Dim decoder As ImageDecoder = RegisteredDecoders.GetDecoder(stm)
                    If decoder IsNot Nothing AndAlso TypeOf decoder Is DicomDecoder Then
                        ' close anything open
                        CloseCurrentItems()

                        ' open new file
                        OpenItems(stm)
                    Else
                        stm.Close()
                        MessageBox.Show("Please choose a Dicom image instead.")
                    End If
                Catch
                    If stm Is Nothing Then
                        stm.Close()
                    End If
                End Try
            End If
        End Sub

        Sub SetSliders()
            windowSlider.Value = _dImage.DefaultWindow
            levelSlider.Value = _dImage.DefaultLeveling
        End Sub

        Private Sub OpenItems(ByVal stm As Stream)
            _stm = stm
            If _stm Is Nothing Then
                Return
            End If
            Try
                ' Get the dataset
                _dataSet = New DicomDataset(_stm)

                ' Get the modality image
                _dImage = _dataSet.GetModalityTransformedImage(0)

                ' set the sliders to the values in the file
                SetSliders()

                ' get initial image, transformed to default window and leveling
                Dim window As Integer = windowSlider.Value
                If _dImage.ImageCameFromSignedSamples Then
                    window += _dImage.ImageDataShiftedBy
                End If
                _image = _dImage.GetAtalaImage(window, Me.levelSlider.Value)
                Me.imageViewer1.Image = _image
            Catch err As Exception
                CloseCurrentItems()
                MessageBox.Show("Unable to open file: " + err.Message)
            End Try
        End Sub

        Private Sub CloseCurrentItems()
            ' Dispose and nullify everything
            If _image IsNot Nothing Then
                Me.imageViewer1.Image = Nothing
                _image.Dispose()
                _image = Nothing
            End If
            If _dImage IsNot Nothing Then
                _dImage.Dispose()
                _dImage = Nothing
            End If
            If _dataSet IsNot Nothing Then
                _dataSet.Dispose()
                _dataSet = Nothing
            End If
            If _stm IsNot Nothing Then
                _stm.Close()
                _stm = Nothing
            End If
        End Sub

        Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
            Me.Close()
        End Sub

        Private Sub UpdateImage()
            If _dImage IsNot Nothing AndAlso _image IsNot Nothing Then
                ' get the window
                Dim window As Integer = windowSlider.Value
                If _dImage.ImageCameFromSignedSamples Then
                    window += _dImage.ImageDataShiftedBy
                End If

                ' Get the image transformed by the window and level.
                ' NOTE: this variant of GetAtalaImage does NOT allocate a new
                ' AtalaImage, but instead writes into the one passed in, so
                ' there is no need to call Dispose on the image
                _dImage.GetAtalaImage(_image, window, Me.levelSlider.Value)

                ' For images that may require a backing store of a more optimal
                ' pixel format, Refresh() forces that backing store to be dropped,
                ' if necessary, then it will call Invalidate()
                imageViewer1.Refresh()
            End If
        End Sub

        Private Sub windowSlider_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles windowSlider.ValueChanged
            UpdateImage()
        End Sub

        Private Sub levelSlider_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles levelSlider.ValueChanged
            UpdateImage()
        End Sub

        Private Sub HelpAboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpAboutToolStripMenuItem.Click
            Dim aboutBox As AtalaDemos.AboutBox.About = New AtalaDemos.AboutBox.About("About Atalasoft Dicom Leveling Demo", "DotImage Dicom Leveling")
            aboutBox.Description = "This is a very basic demo that shows how to open and view a DICOM image using our DicomImage and DicomDataset classes to enable Window and Level control in a Winforms app.  " & vbCrLf & vbCrLf &
                                    "If you're looking for display controls on DICOM images such as zoom, magnify and panning, or if you're looking for examples of viewing metadata on DICOM images, check out our Dicom Viewer Demo.  " & vbCrLf & vbCrLf &
                                    "Requires evaluation or purchased licenses of DotImage Document Imaging or Photo Pro, as well as our Dicom Decoder addon."
            aboutBox.ShowDialog()


        End Sub
    End Class
End Namespace
