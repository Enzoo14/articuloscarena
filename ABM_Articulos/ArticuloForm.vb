Public Class ArticuloForm
    Dim operacion_ As String
    Dim Miarticulo As New ArticuloClass
    Dim indice_ As Byte
    Public Property operacion() As String
        Get
            Return operacion_

        End Get
        Set(ByVal value As String)
            operacion_ = value

        End Set
    End Property
    Public Property indice() As String
        Get
            Return indice_

        End Get
        Set(ByVal value As String)
            indice_ = value

        End Set
    End Property

    Private Sub Cod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod.TextChanged

    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Miarticulo.Codigo = (Codigo.Text)

        Miarticulo.Descripcion = Descripcion.Text
        Miarticulo.Unidad = Un.SelectedItem
        Miarticulo.iva = ComboBox2.SelectedIndex()
        Miarticulo.Stock = CInt (stock.Text)
        Miarticulo.Unidad = Unidad.Text
        Miarticulo.Costo = Costo.Text


        Select operacion_
            Case "Nuevo"
                lst.Add(Miarticulo)
            Case "Eliminar"
                lst.RemoveAt(indice_)
            Case "Modificar"
                lst.Item(indice_) = Miarticulo
        End Select

    End Sub



End Class
