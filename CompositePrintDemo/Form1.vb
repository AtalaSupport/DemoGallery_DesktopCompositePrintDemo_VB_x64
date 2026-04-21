Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Atalasoft.Imaging
Imports Atalasoft.Imaging.WinControls

Namespace CompositePrintDemo
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private _imageFiles As String()
        Private _pages As Integer
        Private WithEvents imageCompositePrintDocument1 As Atalasoft.Imaging.WinControls.ImageCompositePrintDocument
        Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
        Private printPreviewControl1 As System.Windows.Forms.PrintPreviewControl
        Private pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
        Private printDialog1 As System.Windows.Forms.PrintDialog
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents btnSelectFolder As System.Windows.Forms.Button
        Private WithEvents btnPrint As System.Windows.Forms.Button
        Private WithEvents btnPageSetup As System.Windows.Forms.Button
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents AboutBtn As System.Windows.Forms.Button
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Me.comboBox1.SelectedIndex = 0
            Me.comboBox2.SelectedIndex = 0
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
            Me.printPreviewControl1 = New System.Windows.Forms.PrintPreviewControl
            Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
            Me.imageCompositePrintDocument1 = New Atalasoft.Imaging.WinControls.ImageCompositePrintDocument
            Me.printDialog1 = New System.Windows.Forms.PrintDialog
            Me.panel1 = New System.Windows.Forms.Panel
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.btnPrint = New System.Windows.Forms.Button
            Me.btnSelectFolder = New System.Windows.Forms.Button
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.btnPageSetup = New System.Windows.Forms.Button
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.AboutBtn = New System.Windows.Forms.Button
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' printPreviewControl1
            ' 
            Me.printPreviewControl1.AutoZoom = False
            Me.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.printPreviewControl1.Location = New System.Drawing.Point(0, 40)
            Me.printPreviewControl1.Name = "printPreviewControl1"
            Me.printPreviewControl1.Size = New System.Drawing.Size(680, 321)
            Me.printPreviewControl1.TabIndex = 1
            Me.printPreviewControl1.Zoom = 0.25
            ' 
            ' pageSetupDialog1
            ' 
            Me.pageSetupDialog1.Document = Me.imageCompositePrintDocument1
            ' 
            ' imageCompositePrintDocument1
            ' 
            Me.imageCompositePrintDocument1.CaptionAlignment = System.Drawing.StringAlignment.Center
            Me.imageCompositePrintDocument1.CaptionColor = System.Drawing.Color.Black
            Me.imageCompositePrintDocument1.CaptionFont = New System.Drawing.Font("Arial", 8.0F)
            ' 
            ' printDialog1
            ' 
            Me.printDialog1.Document = Me.imageCompositePrintDocument1
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.AboutBtn)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.btnPrint)
            Me.panel1.Controls.Add(Me.btnSelectFolder)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.btnPageSetup)
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(680, 40)
            Me.panel1.TabIndex = 2
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(488, 8)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.Text = "Crop To Fit"
            '			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
            ' 
            ' btnPrint
            ' 
            Me.btnPrint.Location = New System.Drawing.Point(224, 8)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.TabIndex = 2
            Me.btnPrint.Text = "Print"
            '			Me.btnPrint.Click += New System.EventHandler(Me.btnPrint_Click);
            ' 
            ' btnSelectFolder
            ' 
            Me.btnSelectFolder.Location = New System.Drawing.Point(8, 8)
            Me.btnSelectFolder.Name = "btnSelectFolder"
            Me.btnSelectFolder.Size = New System.Drawing.Size(80, 23)
            Me.btnSelectFolder.TabIndex = 1
            Me.btnSelectFolder.Text = "Select Folder"
            '			Me.btnSelectFolder.Click += New System.EventHandler(Me.btnSelectFolder_Click);
            ' 
            ' comboBox1
            ' 
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Items.AddRange(New Object() {"Full Page", "8 x 10 in", "20 x 25 cm", "5 x 7 in", "13 x 18 cm", "4 x 6 in", "10 x 15 cm", "4 x 6 in best fit", "10 x 15 cm best fit", "3.5 x 4 in", "9 x 13 cm", "Wallets", "Contact Sheet"})
            Me.comboBox1.Location = New System.Drawing.Point(96, 8)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 0
            '			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged);
            ' 
            ' btnPageSetup
            ' 
            Me.btnPageSetup.Location = New System.Drawing.Point(304, 8)
            Me.btnPageSetup.Name = "btnPageSetup"
            Me.btnPageSetup.TabIndex = 3
            Me.btnPageSetup.Text = "Page Setup"
            '			Me.btnPageSetup.Click += New System.EventHandler(Me.btnPageSetup_Click);
            ' 
            ' comboBox2
            ' 
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.Items.AddRange(New Object() {"25%", "50%", "75%", "100%", "200%"})
            Me.comboBox2.Location = New System.Drawing.Point(392, 8)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(80, 21)
            Me.comboBox2.TabIndex = 3
            '			Me.comboBox2.SelectedIndexChanged += New System.EventHandler(Me.comboBox2_SelectedIndexChanged);
            ' 
            ' AboutBtn
            ' 
            Me.AboutBtn.Location = New System.Drawing.Point(600, 8)
            Me.AboutBtn.Name = "AboutBtn"
            Me.AboutBtn.Size = New System.Drawing.Size(72, 24)
            Me.AboutBtn.TabIndex = 5
            Me.AboutBtn.Text = "About ..."
            '			Me.AboutBtn.Click += New System.EventHandler(Me.AboutBtn_Click);
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(680, 361)
            Me.Controls.Add(Me.printPreviewControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Composite Image Print Demo"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1)
        End Sub

        Private Sub imageCompositePrintDocument1_PrintImage(ByVal sender As Object, ByVal e As Atalasoft.Imaging.WinControls.PrintCompositeEventArgs) Handles imageCompositePrintDocument1.PrintImage
            If Not _imageFiles Is Nothing AndAlso _imageFiles.Length > e.ImageIndex Then
                Try
                    e.Image = New AtalaImage(_imageFiles(e.ImageIndex))
                    e.Caption = System.IO.Path.GetFileName(_imageFiles(e.ImageIndex))
                Catch
                End Try
            End If

            If e.ImageIndex >= _imageFiles.Length - 1 Then
                e.HasMorePages = False
                Me.printPreviewControl1.Rows = _pages
            Else
                e.HasMorePages = True
            End If
        End Sub

        Private Sub btnSelectFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectFolder.Click
            If Me.folderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                _imageFiles = System.IO.Directory.GetFiles(Me.folderBrowserDialog1.SelectedPath, "*.jpg")
                _pages = 0
                Me.printPreviewControl1.Document = Me.imageCompositePrintDocument1
                Me.printPreviewControl1.InvalidatePreview()
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            If Not _imageFiles Is Nothing Then
                _pages = 0
                Me.imageCompositePrintDocument1.Layout = CType(comboBox1.SelectedIndex, CompositePrintLayout)
                Me.printPreviewControl1.InvalidatePreview()
            End If
        End Sub

        Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
            If Me.printDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Me.imageCompositePrintDocument1.Print()
            End If
        End Sub

        Private Sub btnPageSetup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPageSetup.Click
            Me.pageSetupDialog1.ShowDialog(Me)
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            Select Case comboBox2.SelectedIndex
                Case 0
                    Me.printPreviewControl1.Zoom = 0.25
                Case 1
                    Me.printPreviewControl1.Zoom = 0.5
                Case 2
                    Me.printPreviewControl1.Zoom = 0.75
                Case 3
                    Me.printPreviewControl1.Zoom = 1.0
                Case 4
                    Me.printPreviewControl1.Zoom = 2.0
            End Select

        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.imageCompositePrintDocument1.CropImageToFit = checkBox1.Checked
            Me.printPreviewControl1.InvalidatePreview()
        End Sub

        'handle this event to dispose the image that's no longer needed
        Private Sub imageCompositePrintDocument1_AfterPrintImage(ByVal sender As Object, ByVal e As Atalasoft.Imaging.WinControls.PrintCompositeEventArgs) Handles imageCompositePrintDocument1.AfterPrintImage
            If Not e.Image Is Nothing Then
                e.Image.Dispose()
            End If
        End Sub

        Private Sub imageCompositePrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles imageCompositePrintDocument1.PrintPage
            _pages += 1
        End Sub

        Private Sub AboutBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutBtn.Click
            Dim aboutBox As AtalaDemos.AboutBox.About = New AtalaDemos.AboutBox.About("About Atalasoft DotImage Composite Print Demo", "DotImage Composite Print Demo")
            aboutBox.Description = "Demonstrates how to use the ImageCompositePrintDocument class to print multiple images on a single page.  This is useful for printing multiple photos or a photo collage.  It can be used to conserve expensive photo quality paper by efficiently orienting photos on the paper."
            aboutBox.ShowDialog()
        End Sub
    End Class
End Namespace
