Public Class ArticulosGrid


    Private Sub AlumnoGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst

    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        ArticuloForm.operacion = "Nuevo"
        ArticuloForm.Text = "Alta de Alumno"
        ArticuloForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        ArticuloForm.operacion = "Eliminar"
        ArticuloForm.Text = "Elimina Alumno"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        LlenarForm()
        ArticuloForm.Show()



    End Sub
    Private Sub Llenarform()
        ArticuloForm.Codigo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ArticuloForm.Unidad.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ArticuloForm.Costo.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ArticuloForm.Descripcion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ArticuloForm.Stock.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        ArticuloForm.iva.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        ArticuloForm.Utilidad.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        ArticuloForm.Venta.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        ArticuloForm.operacion = "Modificar"
        ArticuloForm.Text = "Modificar Alumno"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        Llenarform()
        ArticuloForm.Show()
    End Sub
End Class