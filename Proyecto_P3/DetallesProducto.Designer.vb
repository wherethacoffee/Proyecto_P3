<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesProducto
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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.picProducto = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(2, 2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(80, 23)
        Me.btnRegresar.TabIndex = 0
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'picProducto
        '
        Me.picProducto.Location = New System.Drawing.Point(25, 41)
        Me.picProducto.Name = "picProducto"
        Me.picProducto.Size = New System.Drawing.Size(188, 183)
        Me.picProducto.TabIndex = 1
        Me.picProducto.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnComprar)
        Me.Panel1.Controls.Add(Me.lblUnidades)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Location = New System.Drawing.Point(289, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 201)
        Me.Panel1.TabIndex = 2
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(61, 163)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(68, 23)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(74, 136)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(0, 13)
        Me.lblUnidades.TabIndex = 3
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(74, 91)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(0, 13)
        Me.lblDescripcion.TabIndex = 2
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(74, 56)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(0, 13)
        Me.lblPrecio.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(74, 21)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblNombre.TabIndex = 0
        '
        'DetallesProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 292)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picProducto)
        Me.Controls.Add(Me.btnRegresar)
        Me.Name = "DetallesProducto"
        Me.Text = "Detalles del producto"
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents picProducto As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnComprar As Button
    Friend WithEvents lblUnidades As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblNombre As Label
End Class
