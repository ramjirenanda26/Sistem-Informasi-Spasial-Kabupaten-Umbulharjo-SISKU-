<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddPoint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtShapeIndex = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.txtJenisFasilitas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdFullExtent = New System.Windows.Forms.Button()
        Me.cmdPan = New System.Windows.Forms.Button()
        Me.cmdZoomOut = New System.Windows.Forms.Button()
        Me.cmdZoomIn = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.rdoTitik_Cursor = New System.Windows.Forms.RadioButton()
        Me.rdoTitik_Keyboard = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitik_X = New System.Windows.Forms.TextBox()
        Me.txtTitik_Y = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.SuspendLayout()
        '
        'txtShapeIndex
        '
        Me.txtShapeIndex.Location = New System.Drawing.Point(28, 406)
        Me.txtShapeIndex.Name = "txtShapeIndex"
        Me.txtShapeIndex.Size = New System.Drawing.Size(80, 22)
        Me.txtShapeIndex.TabIndex = 21
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(426, 354)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(70, 28)
        Me.cmdBrowse.TabIndex = 20
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(138, 354)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(282, 22)
        Me.txtFoto.TabIndex = 18
        '
        'txtJenisFasilitas
        '
        Me.txtJenisFasilitas.Location = New System.Drawing.Point(138, 292)
        Me.txtJenisFasilitas.Name = "txtJenisFasilitas"
        Me.txtJenisFasilitas.Size = New System.Drawing.Size(358, 22)
        Me.txtJenisFasilitas.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Foto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Jenis Fasilitas"
        '
        'cmdFullExtent
        '
        Me.cmdFullExtent.Location = New System.Drawing.Point(439, 188)
        Me.cmdFullExtent.Name = "cmdFullExtent"
        Me.cmdFullExtent.Size = New System.Drawing.Size(88, 29)
        Me.cmdFullExtent.TabIndex = 13
        Me.cmdFullExtent.Text = "Full Extent"
        Me.cmdFullExtent.UseVisualStyleBackColor = True
        '
        'cmdPan
        '
        Me.cmdPan.Location = New System.Drawing.Point(439, 154)
        Me.cmdPan.Name = "cmdPan"
        Me.cmdPan.Size = New System.Drawing.Size(88, 28)
        Me.cmdPan.TabIndex = 12
        Me.cmdPan.Text = "Move"
        Me.cmdPan.UseVisualStyleBackColor = True
        '
        'cmdZoomOut
        '
        Me.cmdZoomOut.Location = New System.Drawing.Point(439, 121)
        Me.cmdZoomOut.Name = "cmdZoomOut"
        Me.cmdZoomOut.Size = New System.Drawing.Size(88, 27)
        Me.cmdZoomOut.TabIndex = 11
        Me.cmdZoomOut.Text = "Zoom Out"
        Me.cmdZoomOut.UseVisualStyleBackColor = True
        '
        'cmdZoomIn
        '
        Me.cmdZoomIn.Location = New System.Drawing.Point(439, 84)
        Me.cmdZoomIn.Name = "cmdZoomIn"
        Me.cmdZoomIn.Size = New System.Drawing.Size(88, 31)
        Me.cmdZoomIn.TabIndex = 10
        Me.cmdZoomIn.Text = "Zoom In"
        Me.cmdZoomIn.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(339, 406)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(421, 406)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 23
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'rdoTitik_Cursor
        '
        Me.rdoTitik_Cursor.AutoSize = True
        Me.rdoTitik_Cursor.Location = New System.Drawing.Point(28, 13)
        Me.rdoTitik_Cursor.Name = "rdoTitik_Cursor"
        Me.rdoTitik_Cursor.Size = New System.Drawing.Size(287, 21)
        Me.rdoTitik_Cursor.TabIndex = 24
        Me.rdoTitik_Cursor.TabStop = True
        Me.rdoTitik_Cursor.Text = "Digitasi On Screen menggunakan Cursor"
        Me.rdoTitik_Cursor.UseVisualStyleBackColor = True
        '
        'rdoTitik_Keyboard
        '
        Me.rdoTitik_Keyboard.AutoSize = True
        Me.rdoTitik_Keyboard.Location = New System.Drawing.Point(28, 39)
        Me.rdoTitik_Keyboard.Name = "rdoTitik_Keyboard"
        Me.rdoTitik_Keyboard.Size = New System.Drawing.Size(234, 21)
        Me.rdoTitik_Keyboard.TabIndex = 24
        Me.rdoTitik_Keyboard.TabStop = True
        Me.rdoTitik_Keyboard.Text = "Digitasi menggunakan Keyboard"
        Me.rdoTitik_Keyboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "X:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Y:"
        '
        'txtTitik_X
        '
        Me.txtTitik_X.Location = New System.Drawing.Point(288, 39)
        Me.txtTitik_X.Name = "txtTitik_X"
        Me.txtTitik_X.Size = New System.Drawing.Size(100, 22)
        Me.txtTitik_X.TabIndex = 26
        '
        'txtTitik_Y
        '
        Me.txtTitik_Y.Location = New System.Drawing.Point(414, 39)
        Me.txtTitik_Y.Name = "txtTitik_Y"
        Me.txtTitik_Y.Size = New System.Drawing.Size(100, 22)
        Me.txtTitik_Y.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama Fasilitas"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(138, 321)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(358, 22)
        Me.TextBox2.TabIndex = 17
        '
        'Map1
        '
        Me.Map1.AllowDrop = True
        Me.Map1.BackColor = System.Drawing.Color.White
        Me.Map1.CollectAfterDraw = False
        Me.Map1.CollisionDetection = False
        Me.Map1.ExtendBuffer = False
        Me.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map1.IsBusy = False
        Me.Map1.IsZoomedToMaxExtent = False
        Me.Map1.Legend = Nothing
        Me.Map1.Location = New System.Drawing.Point(28, 82)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(405, 187)
        Me.Map1.TabIndex = 28
        Me.Map1.ZoomOutFartherThanMaxExtent = False
        '
        'formAddPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 450)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.txtTitik_Y)
        Me.Controls.Add(Me.txtTitik_X)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdoTitik_Keyboard)
        Me.Controls.Add(Me.rdoTitik_Cursor)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtShapeIndex)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtJenisFasilitas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdFullExtent)
        Me.Controls.Add(Me.cmdPan)
        Me.Controls.Add(Me.cmdZoomOut)
        Me.Controls.Add(Me.cmdZoomIn)
        Me.Name = "formAddPoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Fasilitas Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtShapeIndex As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents txtJenisFasilitas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdFullExtent As Button
    Friend WithEvents cmdPan As Button
    Friend WithEvents cmdZoomOut As Button
    Friend WithEvents cmdZoomIn As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents rdoTitik_Cursor As RadioButton
    Friend WithEvents rdoTitik_Keyboard As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitik_X As TextBox
    Friend WithEvents txtTitik_Y As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Map1 As DotSpatial.Controls.Map
End Class
