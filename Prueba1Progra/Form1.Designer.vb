<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.txtBlue = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnRosado = New System.Windows.Forms.Button()
        Me.btnMarrón = New System.Windows.Forms.Button()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRojo.Location = New System.Drawing.Point(12, 47)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(128, 52)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlue.Location = New System.Drawing.Point(12, 105)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(128, 52)
        Me.txtBlue.TabIndex = 1
        Me.txtBlue.Text = "Azul"
        Me.txtBlue.UseVisualStyleBackColor = True
        '
        'btnAmarillo
        '
        Me.btnAmarillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmarillo.Location = New System.Drawing.Point(12, 163)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(128, 52)
        Me.btnAmarillo.TabIndex = 2
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = True
        '
        'btnRosado
        '
        Me.btnRosado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRosado.Location = New System.Drawing.Point(12, 221)
        Me.btnRosado.Name = "btnRosado"
        Me.btnRosado.Size = New System.Drawing.Size(128, 52)
        Me.btnRosado.TabIndex = 3
        Me.btnRosado.Text = "Rosado"
        Me.btnRosado.UseVisualStyleBackColor = True
        '
        'btnMarrón
        '
        Me.btnMarrón.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarrón.Location = New System.Drawing.Point(12, 279)
        Me.btnMarrón.Name = "btnMarrón"
        Me.btnMarrón.Size = New System.Drawing.Size(128, 52)
        Me.btnMarrón.TabIndex = 4
        Me.btnMarrón.Text = "Marrón"
        Me.btnMarrón.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(146, 12)
        Me.txtColor.Multiline = True
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(561, 362)
        Me.txtColor.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(723, 392)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.btnMarrón)
        Me.Controls.Add(Me.btnRosado)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "Form1"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents txtBlue As Button
    Friend WithEvents btnAmarillo As Button
    Friend WithEvents btnRosado As Button
    Friend WithEvents btnMarrón As Button
    Friend WithEvents txtColor As TextBox
End Class
