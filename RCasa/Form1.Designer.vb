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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lblIngresado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Te casarias conmigo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(201, 38)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(114, 20)
        Me.txtValor.TabIndex = 1
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(191, 64)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(134, 23)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar texto ingresado"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lblIngresado
        '
        Me.lblIngresado.AutoSize = True
        Me.lblIngresado.Location = New System.Drawing.Point(198, 107)
        Me.lblIngresado.Name = "lblIngresado"
        Me.lblIngresado.Size = New System.Drawing.Size(19, 13)
        Me.lblIngresado.TabIndex = 3
        Me.lblIngresado.Text = "¿?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 146)
        Me.Controls.Add(Me.lblIngresado)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents lblIngresado As System.Windows.Forms.Label

End Class
