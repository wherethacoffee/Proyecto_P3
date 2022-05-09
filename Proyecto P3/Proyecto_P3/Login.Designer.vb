<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.LblError = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(195, 363)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(139, 36)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(195, 310)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(139, 36)
        Me.BtnIngresar.TabIndex = 15
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.BackColor = System.Drawing.Color.Transparent
        Me.LblError.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(139, 422)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(0, 24)
        Me.LblError.TabIndex = 14
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(195, 251)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(221, 23)
        Me.TxtContraseña.TabIndex = 13
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(195, 201)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(221, 23)
        Me.TxtCorreo.TabIndex = 12
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.BackColor = System.Drawing.Color.Transparent
        Me.LblContraseña.Font = New System.Drawing.Font("Franklin Gothic Book", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.ForeColor = System.Drawing.Color.White
        Me.LblContraseña.Location = New System.Drawing.Point(87, 251)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(102, 24)
        Me.LblContraseña.TabIndex = 11
        Me.LblContraseña.Text = "Contraseña"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LblCorreo.Font = New System.Drawing.Font("Franklin Gothic Book", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.ForeColor = System.Drawing.Color.White
        Me.LblCorreo.Location = New System.Drawing.Point(87, 201)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(63, 24)
        Me.LblCorreo.TabIndex = 10
        Me.LblCorreo.Text = "Correo"
        '
        'PicLogo
        '
        Me.PicLogo.Image = Global.Proyecto_P3.My.Resources.Resources.LOGO
        Me.PicLogo.Location = New System.Drawing.Point(-4, -3)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(558, 176)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogo.TabIndex = 9
        Me.PicLogo.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_P3.My.Resources.Resources.SOLID_COLOR
        Me.ClientSize = New System.Drawing.Size(553, 486)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.PicLogo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents LblError As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LblContraseña As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents PicLogo As PictureBox
End Class
