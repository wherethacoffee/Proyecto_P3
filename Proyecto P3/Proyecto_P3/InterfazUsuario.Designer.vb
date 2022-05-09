<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazUsuario
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosContratadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.ServiciosContratadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.ServiciosToolStripMenuItem.Text = "Servicios disponibles"
        '
        'ServiciosContratadosToolStripMenuItem
        '
        Me.ServiciosContratadosToolStripMenuItem.Name = "ServiciosContratadosToolStripMenuItem"
        Me.ServiciosContratadosToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.ServiciosContratadosToolStripMenuItem.Text = "Servicios contratados"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(410, 276)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(109, 23)
        Me.btnCerrarSesion.TabIndex = 1
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.Color.Firebrick
        Me.lblBienvenida.Location = New System.Drawing.Point(241, 41)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(221, 29)
        Me.lblBienvenida.TabIndex = 3
        Me.lblBienvenida.Text = "¡Bienvenido user!"
        '
        'lblMsg
        '
        Me.lblMsg.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMsg.Location = New System.Drawing.Point(9, 251)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(146, 48)
        Me.lblMsg.TabIndex = 4
        Me.lblMsg.Text = "Recuerda siempre cerrar sesión antes de salir de la apliacación"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(276, 276)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Proyecto_P3.My.Resources.Resources.LOGO
        Me.picLogo.Location = New System.Drawing.Point(12, 41)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(143, 127)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'InterfazUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_P3.My.Resources.Resources.SOLID_COLOR
        Me.ClientSize = New System.Drawing.Size(531, 311)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InterfazUsuario"
        Me.Text = "Interfaz de Usuario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosContratadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnSalir As Button
End Class
