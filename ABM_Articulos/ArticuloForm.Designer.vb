<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Codigo = New System.Windows.Forms.Label
        Me.Unidad = New System.Windows.Forms.Label
        Me.Costo = New System.Windows.Forms.Label
        Me.Cod = New System.Windows.Forms.TextBox
        Me.Cos = New System.Windows.Forms.TextBox
        Me.Desc = New System.Windows.Forms.TextBox
        Me.Descripcion = New System.Windows.Forms.Label
        Me.Stock = New System.Windows.Forms.Label
        Me.iva = New System.Windows.Forms.Label
        Me.Utilidad = New System.Windows.Forms.Label
        Me.Venta = New System.Windows.Forms.Label
        Me.Stoc = New System.Windows.Forms.TextBox
        Me.Uti = New System.Windows.Forms.TextBox
        Me.Ven = New System.Windows.Forms.TextBox
        Me.Un = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(24, 341)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 0
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(183, 341)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 1
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Codigo
        '
        Me.Codigo.AutoSize = True
        Me.Codigo.Location = New System.Drawing.Point(22, 21)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(40, 13)
        Me.Codigo.TabIndex = 2
        Me.Codigo.Text = "Codigo"
        '
        'Unidad
        '
        Me.Unidad.AutoSize = True
        Me.Unidad.Location = New System.Drawing.Point(20, 58)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Size = New System.Drawing.Size(41, 13)
        Me.Unidad.TabIndex = 4
        Me.Unidad.Text = "Unidad"
        '
        'Costo
        '
        Me.Costo.AutoSize = True
        Me.Costo.Location = New System.Drawing.Point(21, 91)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(34, 13)
        Me.Costo.TabIndex = 6
        Me.Costo.Text = "Costo"
        '
        'Cod
        '
        Me.Cod.Location = New System.Drawing.Point(151, 21)
        Me.Cod.Name = "Cod"
        Me.Cod.Size = New System.Drawing.Size(129, 20)
        Me.Cod.TabIndex = 8
        '
        'Cos
        '
        Me.Cos.Location = New System.Drawing.Point(151, 91)
        Me.Cos.Name = "Cos"
        Me.Cos.Size = New System.Drawing.Size(129, 20)
        Me.Cos.TabIndex = 10
        '
        'Desc
        '
        Me.Desc.Location = New System.Drawing.Point(151, 117)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(129, 20)
        Me.Desc.TabIndex = 11
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(21, 124)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 12
        Me.Descripcion.Text = "Descripcion"
        '
        'Stock
        '
        Me.Stock.AutoSize = True
        Me.Stock.Location = New System.Drawing.Point(20, 167)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(35, 13)
        Me.Stock.TabIndex = 13
        Me.Stock.Text = "Stock"
        '
        'iva
        '
        Me.iva.AutoSize = True
        Me.iva.Location = New System.Drawing.Point(22, 214)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(21, 13)
        Me.iva.TabIndex = 14
        Me.iva.Text = "iva"
        '
        'Utilidad
        '
        Me.Utilidad.AutoSize = True
        Me.Utilidad.Location = New System.Drawing.Point(22, 257)
        Me.Utilidad.Name = "Utilidad"
        Me.Utilidad.Size = New System.Drawing.Size(42, 13)
        Me.Utilidad.TabIndex = 15
        Me.Utilidad.Text = "Utilidad"
        '
        'Venta
        '
        Me.Venta.AutoSize = True
        Me.Venta.Location = New System.Drawing.Point(21, 296)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(35, 13)
        Me.Venta.TabIndex = 16
        Me.Venta.Text = "Venta"
        '
        'Stoc
        '
        Me.Stoc.Location = New System.Drawing.Point(151, 160)
        Me.Stoc.Name = "Stoc"
        Me.Stoc.Size = New System.Drawing.Size(129, 20)
        Me.Stoc.TabIndex = 17
        '
        'Uti
        '
        Me.Uti.Location = New System.Drawing.Point(151, 257)
        Me.Uti.Name = "Uti"
        Me.Uti.Size = New System.Drawing.Size(129, 20)
        Me.Uti.TabIndex = 19
        '
        'Ven
        '
        Me.Ven.Location = New System.Drawing.Point(151, 296)
        Me.Ven.Name = "Ven"
        Me.Ven.Size = New System.Drawing.Size(129, 20)
        Me.Ven.TabIndex = 20
        '
        'Un
        '
        Me.Un.FormattingEnabled = True
        Me.Un.Location = New System.Drawing.Point(151, 58)
        Me.Un.Name = "Un"
        Me.Un.Size = New System.Drawing.Size(121, 21)
        Me.Un.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(151, 205)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 22
        '
        'ArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 376)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Un)
        Me.Controls.Add(Me.Ven)
        Me.Controls.Add(Me.Uti)
        Me.Controls.Add(Me.Stoc)
        Me.Controls.Add(Me.Venta)
        Me.Controls.Add(Me.Utilidad)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Cos)
        Me.Controls.Add(Me.Cod)
        Me.Controls.Add(Me.Costo)
        Me.Controls.Add(Me.Unidad)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Name = "ArticuloForm"
        Me.Text = "ArticuloForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.Label
    Friend WithEvents Unidad As System.Windows.Forms.Label
    Friend WithEvents Costo As System.Windows.Forms.Label
    Friend WithEvents Cod As System.Windows.Forms.TextBox
    Friend WithEvents Cos As System.Windows.Forms.TextBox
    Friend WithEvents Desc As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.Label
    Friend WithEvents iva As System.Windows.Forms.Label
    Friend WithEvents Utilidad As System.Windows.Forms.Label
    Friend WithEvents Venta As System.Windows.Forms.Label
    Friend WithEvents Stoc As System.Windows.Forms.TextBox
    Friend WithEvents Uti As System.Windows.Forms.TextBox
    Friend WithEvents Ven As System.Windows.Forms.TextBox
    Friend WithEvents Un As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox

End Class
