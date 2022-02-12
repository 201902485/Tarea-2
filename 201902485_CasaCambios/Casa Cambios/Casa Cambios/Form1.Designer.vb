<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxCompra = New System.Windows.Forms.TextBox()
        Me.RadioButtonVenta = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCompra = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxColon = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEuro = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPeso = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDolar = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTotalVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalCompra = New System.Windows.Forms.TextBox()
        Me.TotalVenta = New System.Windows.Forms.Label()
        Me.TotalCompra = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBoxComisionVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxComisionCompra = New System.Windows.Forms.TextBox()
        Me.LbVenta = New System.Windows.Forms.Label()
        Me.LbCompra = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox1.Controls.Add(Me.TextBoxVenta)
        Me.GroupBox1.Controls.Add(Me.TextBoxCompra)
        Me.GroupBox1.Controls.Add(Me.RadioButtonVenta)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCompra)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de transacción"
        '
        'TextBoxVenta
        '
        Me.TextBoxVenta.Location = New System.Drawing.Point(85, 63)
        Me.TextBoxVenta.Name = "TextBoxVenta"
        Me.TextBoxVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVenta.TabIndex = 7
        '
        'TextBoxCompra
        '
        Me.TextBoxCompra.Location = New System.Drawing.Point(85, 28)
        Me.TextBoxCompra.Name = "TextBoxCompra"
        Me.TextBoxCompra.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCompra.TabIndex = 5
        '
        'RadioButtonVenta
        '
        Me.RadioButtonVenta.AutoSize = True
        Me.RadioButtonVenta.Location = New System.Drawing.Point(9, 63)
        Me.RadioButtonVenta.Name = "RadioButtonVenta"
        Me.RadioButtonVenta.Size = New System.Drawing.Size(53, 17)
        Me.RadioButtonVenta.TabIndex = 6
        Me.RadioButtonVenta.TabStop = True
        Me.RadioButtonVenta.Text = "Venta"
        Me.RadioButtonVenta.UseVisualStyleBackColor = True
        '
        'RadioButtonCompra
        '
        Me.RadioButtonCompra.AutoSize = True
        Me.RadioButtonCompra.Location = New System.Drawing.Point(9, 28)
        Me.RadioButtonCompra.Name = "RadioButtonCompra"
        Me.RadioButtonCompra.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonCompra.TabIndex = 5
        Me.RadioButtonCompra.TabStop = True
        Me.RadioButtonCompra.Text = "Compra"
        Me.RadioButtonCompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox2.Controls.Add(Me.CheckBoxColon)
        Me.GroupBox2.Controls.Add(Me.CheckBoxEuro)
        Me.GroupBox2.Controls.Add(Me.CheckBoxPeso)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDolar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 140)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Moneda"
        '
        'CheckBoxColon
        '
        Me.CheckBoxColon.AutoSize = True
        Me.CheckBoxColon.Location = New System.Drawing.Point(25, 117)
        Me.CheckBoxColon.Name = "CheckBoxColon"
        Me.CheckBoxColon.Size = New System.Drawing.Size(137, 17)
        Me.CheckBoxColon.TabIndex = 8
        Me.CheckBoxColon.Text = "Colones Costarricences"
        Me.CheckBoxColon.UseVisualStyleBackColor = True
        '
        'CheckBoxEuro
        '
        Me.CheckBoxEuro.AutoSize = True
        Me.CheckBoxEuro.Location = New System.Drawing.Point(25, 87)
        Me.CheckBoxEuro.Name = "CheckBoxEuro"
        Me.CheckBoxEuro.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxEuro.TabIndex = 7
        Me.CheckBoxEuro.Text = "Euro"
        Me.CheckBoxEuro.UseVisualStyleBackColor = True
        '
        'CheckBoxPeso
        '
        Me.CheckBoxPeso.AutoSize = True
        Me.CheckBoxPeso.Location = New System.Drawing.Point(25, 52)
        Me.CheckBoxPeso.Name = "CheckBoxPeso"
        Me.CheckBoxPeso.Size = New System.Drawing.Size(99, 17)
        Me.CheckBoxPeso.TabIndex = 6
        Me.CheckBoxPeso.Text = "Peso Mexicano"
        Me.CheckBoxPeso.UseVisualStyleBackColor = True
        '
        'CheckBoxDolar
        '
        Me.CheckBoxDolar.AutoSize = True
        Me.CheckBoxDolar.Location = New System.Drawing.Point(25, 23)
        Me.CheckBoxDolar.Name = "CheckBoxDolar"
        Me.CheckBoxDolar.Size = New System.Drawing.Size(51, 17)
        Me.CheckBoxDolar.TabIndex = 5
        Me.CheckBoxDolar.Text = "Dolar"
        Me.CheckBoxDolar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox3.Controls.Add(Me.ButtonSalir)
        Me.GroupBox3.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox3.Controls.Add(Me.ButtonCalcular)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox3.Location = New System.Drawing.Point(237, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 115)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(62, 77)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(62, 48)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "Limpieza"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(62, 19)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 0
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox4.Controls.Add(Me.TextBoxTotalVenta)
        Me.GroupBox4.Controls.Add(Me.TextBoxTotalCompra)
        Me.GroupBox4.Controls.Add(Me.TotalVenta)
        Me.GroupBox4.Controls.Add(Me.TotalCompra)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox4.Location = New System.Drawing.Point(12, 285)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 98)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total "
        '
        'TextBoxTotalVenta
        '
        Me.TextBoxTotalVenta.Location = New System.Drawing.Point(85, 58)
        Me.TextBoxTotalVenta.Name = "TextBoxTotalVenta"
        Me.TextBoxTotalVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotalVenta.TabIndex = 9
        '
        'TextBoxTotalCompra
        '
        Me.TextBoxTotalCompra.Location = New System.Drawing.Point(85, 25)
        Me.TextBoxTotalCompra.Name = "TextBoxTotalCompra"
        Me.TextBoxTotalCompra.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotalCompra.TabIndex = 8
        '
        'TotalVenta
        '
        Me.TotalVenta.AutoSize = True
        Me.TotalVenta.Location = New System.Drawing.Point(6, 58)
        Me.TotalVenta.Name = "TotalVenta"
        Me.TotalVenta.Size = New System.Drawing.Size(62, 13)
        Me.TotalVenta.TabIndex = 6
        Me.TotalVenta.Text = "Total Venta"
        '
        'TotalCompra
        '
        Me.TotalCompra.AutoSize = True
        Me.TotalCompra.Location = New System.Drawing.Point(6, 25)
        Me.TotalCompra.Name = "TotalCompra"
        Me.TotalCompra.Size = New System.Drawing.Size(70, 13)
        Me.TotalCompra.TabIndex = 5
        Me.TotalCompra.Text = "Total Compra"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox5.Controls.Add(Me.TextBoxComisionVenta)
        Me.GroupBox5.Controls.Add(Me.TextBoxComisionCompra)
        Me.GroupBox5.Controls.Add(Me.LbVenta)
        Me.GroupBox5.Controls.Add(Me.LbCompra)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox5.Location = New System.Drawing.Point(237, 285)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 98)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total de Comisión"
        '
        'TextBoxComisionVenta
        '
        Me.TextBoxComisionVenta.Location = New System.Drawing.Point(94, 61)
        Me.TextBoxComisionVenta.Name = "TextBoxComisionVenta"
        Me.TextBoxComisionVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxComisionVenta.TabIndex = 10
        '
        'TextBoxComisionCompra
        '
        Me.TextBoxComisionCompra.Location = New System.Drawing.Point(94, 25)
        Me.TextBoxComisionCompra.Name = "TextBoxComisionCompra"
        Me.TextBoxComisionCompra.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxComisionCompra.TabIndex = 9
        '
        'LbVenta
        '
        Me.LbVenta.AutoSize = True
        Me.LbVenta.Location = New System.Drawing.Point(6, 61)
        Me.LbVenta.Name = "LbVenta"
        Me.LbVenta.Size = New System.Drawing.Size(83, 13)
        Me.LbVenta.TabIndex = 7
        Me.LbVenta.Text = "Comision Venta "
        '
        'LbCompra
        '
        Me.LbCompra.AutoSize = True
        Me.LbCompra.Location = New System.Drawing.Point(6, 28)
        Me.LbCompra.Name = "LbCompra"
        Me.LbCompra.Size = New System.Drawing.Size(88, 13)
        Me.LbCompra.TabIndex = 6
        Me.LbCompra.Text = "Comision Compra"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_02_11_at_08_50_24
        Me.ClientSize = New System.Drawing.Size(462, 407)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxVenta As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCompra As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonVenta As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCompra As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxColon As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxEuro As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPeso As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDolar As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpiar As System.Windows.Forms.Button
    Friend WithEvents ButtonCalcular As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTotalVenta As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotalCompra As System.Windows.Forms.TextBox
    Friend WithEvents TotalVenta As System.Windows.Forms.Label
    Friend WithEvents TotalCompra As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxComisionVenta As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxComisionCompra As System.Windows.Forms.TextBox
    Friend WithEvents LbVenta As System.Windows.Forms.Label
    Friend WithEvents LbCompra As System.Windows.Forms.Label

End Class
