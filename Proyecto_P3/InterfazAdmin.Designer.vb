<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazAdmin
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminstrarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(276, 282)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMsg.Location = New System.Drawing.Point(9, 257)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(146, 48)
        Me.lblMsg.TabIndex = 10
        Me.lblMsg.Text = "Recuerda siempre cerrar sesión antes de salir de la aplicación."
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.Color.Firebrick
        Me.lblBienvenida.Location = New System.Drawing.Point(241, 47)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(242, 29)
        Me.lblBienvenida.TabIndex = 9
        Me.lblBienvenida.Text = "¡Bienvenido admin!"
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(12, 47)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(143, 127)
        Me.picLogo.TabIndex = 8
        Me.picLogo.TabStop = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(410, 282)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(109, 23)
        Me.btnCerrarSesion.TabIndex = 7
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminstrarProductosToolStripMenuItem, Me.AdministrarServiciosToolStripMenuItem, Me.ContratacionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminstrarProductosToolStripMenuItem
        '
        Me.AdminstrarProductosToolStripMenuItem.Name = "AdminstrarProductosToolStripMenuItem"
        Me.AdminstrarProductosToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.AdminstrarProductosToolStripMenuItem.Text = "Adminstrar productos"
        '
        'AdministrarServiciosToolStripMenuItem
        '
        Me.AdministrarServiciosToolStripMenuItem.Name = "AdministrarServiciosToolStripMenuItem"
        Me.AdministrarServiciosToolStripMenuItem.Size = New System.Drawing.Size(130, 20)
        Me.AdministrarServiciosToolStripMenuItem.Text = "Administrar Servicios"
        '
        'ContratacionesToolStripMenuItem
        '
        Me.ContratacionesToolStripMenuItem.Name = "ContratacionesToolStripMenuItem"
        Me.ContratacionesToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ContratacionesToolStripMenuItem.Text = "Contrataciones"
        '
        'InterfazAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 311)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InterfazAdmin"
        Me.Text = "Interfaz de Administrador"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminstrarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratacionesToolStripMenuItem As ToolStripMenuItem
End Class
