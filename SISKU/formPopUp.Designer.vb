<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPopUp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJenisFasilitas = New System.Windows.Forms.TextBox()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtShapeIndex = New System.Windows.Forms.TextBox()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INFORMASI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jenis Fasilitas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Foto"
        '
        'txtJenisFasilitas
        '
        Me.txtJenisFasilitas.Location = New System.Drawing.Point(126, 302)
        Me.txtJenisFasilitas.Name = "txtJenisFasilitas"
        Me.txtJenisFasilitas.Size = New System.Drawing.Size(255, 22)
        Me.txtJenisFasilitas.TabIndex = 4
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(127, 334)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(179, 22)
        Me.txtFoto.TabIndex = 4
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(312, 328)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(70, 28)
        Me.cmdBrowse.TabIndex = 5
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtShapeIndex
        '
        Me.txtShapeIndex.Location = New System.Drawing.Point(17, 386)
        Me.txtShapeIndex.Name = "txtShapeIndex"
        Me.txtShapeIndex.Size = New System.Drawing.Size(80, 22)
        Me.txtShapeIndex.TabIndex = 6
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(117, 385)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 7
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(198, 385)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(279, 385)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
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
        Me.Map1.Location = New System.Drawing.Point(17, 60)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(295, 207)
        Me.Map1.TabIndex = 8
        Me.Map1.ZoomOutFartherThanMaxExtent = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Full Extent"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Move"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(328, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 27)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Zoom Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(328, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 31)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Zoom In"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'formPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.txtShapeIndex)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.txtJenisFasilitas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formPopUp"
        Me.Text = "Informasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJenisFasilitas As TextBox
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtShapeIndex As TextBox
    Friend WithEvents cmdHapus As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Map1 As DotSpatial.Controls.Map
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
