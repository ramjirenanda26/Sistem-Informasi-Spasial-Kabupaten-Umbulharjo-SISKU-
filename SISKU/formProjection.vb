'Required namespces
Imports DotSpatial.Projections
Imports DotSpatial.Data
Imports DotSpatial.Controls
Imports DotSpatial.Symbology
Imports BruTile
Imports DotSpatial.Topology
Imports DotSpatial.Plugins.WebMap

Public Class formProjection
    Public lyrAdmin As MapPolygonLayer
    Private Sub btnLoadShapefile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadShapefile.Click

        'define projection
        Map1.Projection = KnownCoordinateSystems.Projected.UtmNad1983.NAD1983UTMZone12N
        Map2.Projection = KnownCoordinateSystems.Projected.UtmWgs1984.WGS1984UTMZone49S
        Map3.Projection = KnownCoordinateSystems.Projected.NorthAmerica.USAContiguousLambertConformalConic
        Map4.Projection = KnownCoordinateSystems.Projected.World.CylindricalEqualAreaworld
        Map5.Projection = KnownCoordinateSystems.Projected.Polar.NorthPoleAzimuthalEquidistant
        Map6.Projection = KnownCoordinateSystems.Projected.NorthAmerica.USAContiguousAlbersEqualAreaConic


        'add layer
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "Shapefile|*.shp"
        If fileDialog.ShowDialog = DialogResult.OK Then

            'add layer to first map
            Dim featureSet1 As New FeatureSet
            featureSet1.Open(fileDialog.FileName)

            'Populate the FiledName dropdownlist with the help of featureset1.
            'We need to pass featureset as an input paramter to FillColumnNames method.
            FillColumnNames(featureSet1)


            'set the projections
            featureSet1.Reproject(Map1.Projection)
            Map1.Layers.Add(featureSet1)

            'add layer to second map
            Dim featureSet2 As New FeatureSet
            featureSet2.Open(fileDialog.FileName)
            featureSet2.Reproject(Map2.Projection)
            Map2.Layers.Add(featureSet2)

            'add layer to map3
            Dim featureSet3 As New FeatureSet
            featureSet3.Open(fileDialog.FileName)
            featureSet3.Reproject(Map3.Projection)
            Map3.Layers.Add(featureSet3)

            'add layer to map4
            Dim featureSet4 As New FeatureSet
            featureSet4.Open(fileDialog.FileName)
            featureSet4.Reproject(Map4.Projection)
            Map4.Layers.Add(featureSet4)

            'add layer to map6
            Dim featureSet5 As New FeatureSet
            featureSet5.Open(fileDialog.FileName)
            featureSet5.Reproject(Map5.Projection)
            Map6.Layers.Add(featureSet5)

            'add layer to map6
            Dim featureSet6 As New FeatureSet
            featureSet6.Open(fileDialog.FileName)
            featureSet6.Reproject(Map6.Projection)
            Map6.Layers.Add(featureSet6)
        End If
    End Sub

    Private Sub btnGetTotalArea_Click(sender As Object, e As EventArgs) Handles btnGetTotalArea.Click
        lbltotalAreaMap1.Text = "Total area in sq meters: " + _getTotalArea(Map1).ToString()
        lbltotalAreaMap2.Text = "Total area in sq meters: " + _getTotalArea(Map2).ToString()
        lbltotalAreaMap3.Text = "Total area in sq meters: " + _getTotalArea(Map3).ToString()
        lbltotalAreaMap4.Text = "Total area in sq meters: " + _getTotalArea(Map4).ToString()
        lbltotalAreaMap5.Text = "Total area in sq meters: " + _getTotalArea(Map5).ToString()
        lbltotalAreaMap6.Text = "Total area in sq meters: " + _getTotalArea(Map6).ToString()
    End Sub

    Private Function _getTotalArea(ByVal mapInput As DotSpatial.Controls.Map) As Double
        Dim stateArea As Double
        If (mapInput.Layers.Count > 0) Then
            Dim stateLayer As MapPolygonLayer
            stateLayer = CType(mapInput.Layers(0), MapPolygonLayer)
            If (stateLayer Is Nothing) Then
                MessageBox.Show("The layer is not a polygon layer.")
            Else
                For Each stateFeature As IFeature In stateLayer.DataSet.Features
                    stateArea += stateFeature.Area
                Next
            End If
        End If
        Return stateArea
    End Function

    Private Sub formProjection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FillColumnNames(ByVal featureSet As IFeatureSet)
        For Each column As DataColumn In featureSet.DataTable.Columns
            cmbFieldName.Items.Add(column.ColumnName)
        Next
    End Sub
    Private Sub FillUniqueValues(ByVal uniqueField As String, ByVal mapInput As DotSpatial.Controls.Map)
        Dim fieldList As New List(Of String)
        If (mapInput.Layers.Count > 0) Then
            Dim currentLayer As MapPolygonLayer
            currentLayer = CType(mapInput.Layers(0), MapPolygonLayer)
            If (currentLayer Is Nothing) Then
                MessageBox.Show("The layer is not a polygon layer.")
            Else
                Dim dt As DataTable = currentLayer.DataSet.DataTable
                cmbSelectedRegion.Items.Clear()
                For Each rows As DataRow In dt.Rows
                    cmbSelectedRegion.Items.Add(rows(uniqueField))
                Next
            End If
        End If
    End Sub


    Private Sub cmbFieldName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFieldName.SelectedIndexChanged
        FillUniqueValues(cmbFieldName.Text, Map1)
    End Sub

    Private Sub setVisible(ByVal lbl As Label, ByVal vis As Boolean)
        lbl.Visible = vis
    End Sub

    Private Function _getArea(ByVal uniqueColumnName As String, ByVal uniqueValue As String, ByVal mapInput As DotSpatial.Controls.Map) As Double
        Dim stateArea As Double
        If (mapInput.Layers.Count > 0) Then
            Dim stateLayer As MapPolygonLayer
            stateLayer = CType(mapInput.Layers(0), MapPolygonLayer)
            If (stateLayer Is Nothing) Then
                MessageBox.Show("The layer is not a polygon layer.")
            Else
                stateLayer.SelectByAttribute("[" + uniqueColumnName + "] =" + "'" + uniqueValue + "'")
                For Each stateFeature As IFeature In stateLayer.DataSet.Features
                    If uniqueValue = stateFeature.DataRow(uniqueColumnName) Then
                        stateArea = stateFeature.Area
                        Exit For
                    End If
                Next
            End If
        End If
        Return stateArea
    End Function

    Private Sub btnRegionArea_Click(sender As Object, e As EventArgs) Handles btnRegionArea.Click
        setVisible(lblmap1selectedinfo, True)
        setVisible(lblmap2selectedinfo, True)
        setVisible(lblmap3selectedinfo, True)
        setVisible(lblmap4selectedinfo, True)
        setVisible(lblmap5selectedinfo, True)
        setVisible(lblmap6selectedinfo, True)
        lblMap1SelectedArea.Text = _getArea(cmbFieldName.Text, cmbSelectedRegion.Text, Map1)
        lblMap2SelectedArea.Text = _getArea(cmbFieldName.Text, cmbSelectedRegion.Text, Map2)
        lblMap3SelectedArea.Text = _getArea(cmbFieldName.Text, cmbSelectedRegion.Text, Map3)
        lblMap4SelectedArea.Text = _getArea(cmbFieldName.Text, cmbSelectedRegion.Text, Map4)
        lblMap5SelectedArea.Text = _getArea(cmbFieldName.Text, cmbSelectedRegion.Text, Map5)
        lblMap6SelectedArea.Text = _getArea(cmbFieldName.Text, cmbSelectedRegion.Text, Map6)
    End Sub

    Private Function _calculateDifference(ByVal area1 As Double, ByVal area2 As Double) As Double
        Dim areadiff As Double
        areadiff = area1 - area2
        Return areadiff
    End Function

    Private Sub btnCompareProjections_Click(sender As Object, e As EventArgs) Handles btnCompareProjections.Click
        lblmap1difference.Text = _calculateDifference(CDbl(lblMap2SelectedArea.Text), CDbl(lblMap1SelectedArea.Text)).ToString()
        lblmap3difference.Text = _calculateDifference(CDbl(lblMap2SelectedArea.Text), CDbl(lblMap3SelectedArea.Text)).ToString()
        lblmap4difference.Text = _calculateDifference(CDbl(lblMap2SelectedArea.Text), CDbl(lblMap4SelectedArea.Text)).ToString()
        lblmap5difference.Text = _calculateDifference(CDbl(lblMap2SelectedArea.Text), CDbl(lblMap5SelectedArea.Text)).ToString()

        setVisible(lblmap1difference, True)
        setVisible(lblmap1info, True)
        setVisible(lblmap3difference, True)
        setVisible(lblmap3info, True)
        setVisible(lblmap4difference, True)
        setVisible(lblmap4info, True)
        setVisible(lblmap5difference, True)
        setVisible(lblmap5info, True)
    End Sub
End Class