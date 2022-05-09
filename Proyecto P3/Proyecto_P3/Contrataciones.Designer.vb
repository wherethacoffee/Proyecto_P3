<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contrataciones
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
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.DgvContrataciones = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.CboContrataciones = New System.Windows.Forms.ComboBox()
        CType(Me.DgvContrataciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(395, 276)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizar.TabIndex = 17
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(0, 0)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(80, 23)
        Me.btnRegresar.TabIndex = 14
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'DgvContrataciones
        '
        Me.DgvContrataciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContrataciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Descripcion, Me.Precio, Me.Disponible})
        Me.DgvContrataciones.Location = New System.Drawing.Point(34, 61)
        Me.DgvContrataciones.Name = "DgvContrataciones"
        Me.DgvContrataciones.Size = New System.Drawing.Size(463, 201)
        Me.DgvContrataciones.TabIndex = 13
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 60
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre del Producto"
        Me.Nombre.Name = "Nombre"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 80
        '
        'Disponible
        '
        Me.Disponible.HeaderText = "Disponible"
        Me.Disponible.Name = "Disponible"
        Me.Disponible.Width = 80
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(160, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(185, 26)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Contrataciones"
        '
        'CboContrataciones
        '
        Me.CboContrataciones.FormattingEnabled = True
        Me.CboContrataciones.Location = New System.Drawing.Point(34, 276)
        Me.CboContrataciones.Name = "CboContrataciones"
        Me.CboContrataciones.Size = New System.Drawing.Size(258, 21)
        Me.CboContrataciones.TabIndex = 18
        '
        'Contrataciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_P3.My.Resources.Resources.SOLID_COLOR
        Me.ClientSize = New System.Drawing.Size(550, 334)
        Me.Controls.Add(Me.CboContrataciones)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.DgvContrataciones)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Contrataciones"
        Me.Text = "Contrataciones"
        CType(Me.DgvContrataciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents DgvContrataciones As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Disponible As DataGridViewTextBoxColumn
    Friend WithEvents lblTitulo As Label
    Friend WithEvents CboContrataciones As ComboBox
End Class
