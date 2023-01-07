Imports DotSpatial.Controls
Imports DotSpatial.Symbology
Imports DotSpatial.Topology
Imports DotSpatial.Data
Imports System.IO

Public Class formAddPoint
    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Browse Foto"
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "JPG (*.jpg|*.jpg|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|All files(*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.RestoreDirectory = True

        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim filename As String = Path.GetFileName(ofd.FileName)
            Dim sourcepath As String = Path.GetDirectoryName(ofd.FileName)
            Dim targetpath As String = Path.Combine(formMainWindow.ResourcesPath, "Database/Non-Spasial/Foto/")
            Dim sourcefile As String = Path.Combine(sourcepath, filename)
            Dim destfile As String = Path.Combine(targetpath, filename)
            File.Copy(sourcefile, destfile, True)
            txtFoto.Text = filename
            Map1.ClearLayers()
            Map1.AddLayer(destfile)
        Else
            MessageBox.Show("No File of Picture!", "Report", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim fasumfeature As FeatureSet = formMainWindow.lyrFasilitas.FeatureSet
        Dim asetpoint As New Point(CDbl(txtTitik_X.Text), CDbl(txtTitik_Y.Text))
        Dim featureinserted As IFeature = fasumfeature.AddFeature(asetpoint)

        featureinserted.DataRow.BeginEdit()
        featureinserted.DataRow("KETERANGAN") = txtJenisFasilitas.Text
        featureinserted.DataRow("Foto") = txtFoto.Text
        featureinserted.DataRow.EndEdit()

        fasumfeature.InitializeVertices()
        fasumfeature.UpdateExtent()
        fasumfeature.Save()

        formMainWindow.lyrFasilitas.DataSet.InitializeVertices()
        'Form1.lyrFasum.DataSet.AssignFastDrawnState()
        formMainWindow.lyrFasilitas.DataSet.UpdateExtent()

        Dim table As DataTable
        table = formMainWindow.lyrFasilitas.DataSet.DataTable
        table.Columns.RemoveAt((table.Columns.Count - 1))
        table.AcceptChanges()
        formMainWindow.lyrFasilitas.DataSet.Save()
        formMainWindow.lyrFasilitas.FeatureSet.AddFid()
        formMainWindow.lyrFasilitas.FeatureSet.Save()

        formMainWindow.newpoint.SelectAll()
        formMainWindow.newpoint.RemoveSelectedFeatures()

        formMainWindow.newfeature.InitializeVertices()
        formMainWindow.newfeature.UpdateExtent()
        formMainWindow.newpoint.DataSet.InitializeVertices()
        formMainWindow.newpoint.AssignFastDrawnStates()
        formMainWindow.newpoint.DataSet.UpdateExtent()

        Map1.Refresh()
        Map1.ResetBuffer()

        MessageBox.Show("Featured Data Save!")

        Me.Close()
    End Sub

    Private Sub cmdZoomIn_Click(sender As Object, e As EventArgs) Handles cmdZoomIn.Click
        Map1.ZoomIn()
    End Sub

    Private Sub cmdZoomOut_Click(sender As Object, e As EventArgs) Handles cmdZoomOut.Click
        Map1.ZoomOut()
    End Sub

    Private Sub cmdPan_Click(sender As Object, e As EventArgs) Handles cmdPan.Click
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan
    End Sub

    Private Sub cmdFullExtent_Click(sender As Object, e As EventArgs) Handles cmdFullExtent.Click
        Map1.ZoomToMaxExtent()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub formAddPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class