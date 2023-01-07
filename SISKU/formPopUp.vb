Imports DotSpatial.Controls
Imports DotSpatial.Data
Imports DotSpatial.Symbology
Imports System.IO

Public Class formPopUp
    Private Sub cmdZoomIn_Click(sender As Object, e As EventArgs)
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn
    End Sub

    Private Sub cmdZoomOut_Click(sender As Object, e As EventArgs)
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut
    End Sub

    Private Sub cmdPan_Click(sender As Object, e As EventArgs)
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan
    End Sub

    Private Sub cmdFullExtent_Click(sender As Object, e As EventArgs)
        Map1.ZoomToMaxExtent()
    End Sub

    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
        formMainWindow.sedangload = True
        'formMainWindow.lyrFasilitas.ClearSelection()
        formMainWindow.lyrFasilitas.Select(CInt(txtShapeIndex.Text))
        formMainWindow.lyrFasilitas.RemoveSelectedFeatures()
        formMainWindow.sedangload = False
        formMainWindow.Map1.Refresh()
        Me.Close()
        MessageBox.Show("Data terhapus!")
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Browse Photo"
        ofd.InitialDirectory = ":D\"
        ofd.Filter = "All Images (*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.RestoreDirectory = True

        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim fileName As String = Path.GetFileName(ofd.FileName)
            Dim sourcePath As String = Path.GetDirectoryName(ofd.FileName)
            Dim targetPath As String = Path.Combine(formMainWindow.ResourcesPath, "Database/Non-spasial/Foto")
            Dim sourceFile As String = Path.Combine(sourcePath, fileName)
            Dim destFileName As String = Path.Combine(targetPath, fileName)
            File.Copy(sourceFile, destFileName, True)
            txtFoto.Text = fileName
            Map1.ClearLayers()
            Map1.AddLayer(destFileName)
        Else
            MessageBox.Show("Sudah memilih foto!", "Report", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Try
            formMainWindow.sedangload = True

            If cmdEdit.Text = "Edit" Then

                Dim input As String = Microsoft.VisualBasic.Interaction.InputBox(
          "Please enter your password!", "Password", "", -1, -1)

                If input = "ramjirenanda" Then
                    txtJenisFasilitas.ReadOnly = False
                    txtFoto.ReadOnly = False
                    cmdBrowse.Enabled = True
                    cmdHapus.Visible = True
                    cmdEdit.Visible = "Save"
                Else
                    txtJenisFasilitas.ReadOnly = False
                    txtJenisFasilitas.ReadOnly = True
                    cmdBrowse.Enabled = False
                    cmdHapus.Visible = True
                    cmdEdit.Visible = "Edit"
                    MessageBox.Show("Password salah!")
                End If
            ElseIf cmdEdit.Text = "Save" Then
                Dim featureEdited As IFeature = formMainWindow.lyrFasilitas.FeatureSet.GetFeature(CInt(txtShapeIndex.Text))
                featureEdited.DataRow.BeginEdit()
                featureEdited.DataRow("KETERANGAN") = txtJenisFasilitas.Text
                featureEdited.DataRow("Foto") = txtFoto.Text
                featureEdited.DataRow.EndEdit()

                cmdEdit.Text = "Edit"
                txtJenisFasilitas.ReadOnly = True
                txtFoto.ReadOnly = True
                cmdBrowse.Enabled = False
                Map1.Refresh()
                Me.Hide()
                MessageBox.Show("Data Saved")
            End If

            formMainWindow.sedangload = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub formPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdHapus.Visible = False
    End Sub
End Class