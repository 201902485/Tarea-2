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
        Me.RadioButtonLarge = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMedium = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonLona = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSeda = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAlgodon = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxUPVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxUPCosto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTPVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxTPCosto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Peru
        Me.GroupBox1.Controls.Add(Me.RadioButtonLarge)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMedium)
        Me.GroupBox1.Controls.Add(Me.RadioButtonSmall)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(213, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'RadioButtonLarge
        '
        Me.RadioButtonLarge.AutoSize = True
        Me.RadioButtonLarge.Location = New System.Drawing.Point(55, 65)
        Me.RadioButtonLarge.Name = "RadioButtonLarge"
        Me.RadioButtonLarge.Size = New System.Drawing.Size(52, 17)
        Me.RadioButtonLarge.TabIndex = 3
        Me.RadioButtonLarge.TabStop = True
        Me.RadioButtonLarge.Text = "Large"
        Me.RadioButtonLarge.UseVisualStyleBackColor = True
        '
        'RadioButtonMedium
        '
        Me.RadioButtonMedium.AutoSize = True
        Me.RadioButtonMedium.Location = New System.Drawing.Point(55, 42)
        Me.RadioButtonMedium.Name = "RadioButtonMedium"
        Me.RadioButtonMedium.Size = New System.Drawing.Size(62, 17)
        Me.RadioButtonMedium.TabIndex = 2
        Me.RadioButtonMedium.TabStop = True
        Me.RadioButtonMedium.Text = "Medium"
        Me.RadioButtonMedium.UseVisualStyleBackColor = True
        '
        'RadioButtonSmall
        '
        Me.RadioButtonSmall.AutoSize = True
        Me.RadioButtonSmall.Location = New System.Drawing.Point(55, 19)
        Me.RadioButtonSmall.Name = "RadioButtonSmall"
        Me.RadioButtonSmall.Size = New System.Drawing.Size(50, 17)
        Me.RadioButtonSmall.TabIndex = 1
        Me.RadioButtonSmall.TabStop = True
        Me.RadioButtonSmall.Text = "Small"
        Me.RadioButtonSmall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Peru
        Me.GroupBox2.Controls.Add(Me.RadioButtonLona)
        Me.GroupBox2.Controls.Add(Me.RadioButtonSeda)
        Me.GroupBox2.Controls.Add(Me.RadioButtonAlgodon)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(42, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'RadioButtonLona
        '
        Me.RadioButtonLona.AutoSize = True
        Me.RadioButtonLona.Location = New System.Drawing.Point(50, 65)
        Me.RadioButtonLona.Name = "RadioButtonLona"
        Me.RadioButtonLona.Size = New System.Drawing.Size(49, 17)
        Me.RadioButtonLona.TabIndex = 2
        Me.RadioButtonLona.TabStop = True
        Me.RadioButtonLona.Text = "Lona"
        Me.RadioButtonLona.UseVisualStyleBackColor = True
        '
        'RadioButtonSeda
        '
        Me.RadioButtonSeda.AutoSize = True
        Me.RadioButtonSeda.Location = New System.Drawing.Point(50, 42)
        Me.RadioButtonSeda.Name = "RadioButtonSeda"
        Me.RadioButtonSeda.Size = New System.Drawing.Size(50, 17)
        Me.RadioButtonSeda.TabIndex = 1
        Me.RadioButtonSeda.TabStop = True
        Me.RadioButtonSeda.Text = "Seda"
        Me.RadioButtonSeda.UseVisualStyleBackColor = True
        '
        'RadioButtonAlgodon
        '
        Me.RadioButtonAlgodon.AutoSize = True
        Me.RadioButtonAlgodon.Location = New System.Drawing.Point(50, 19)
        Me.RadioButtonAlgodon.Name = "RadioButtonAlgodon"
        Me.RadioButtonAlgodon.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonAlgodon.TabIndex = 0
        Me.RadioButtonAlgodon.TabStop = True
        Me.RadioButtonAlgodon.Text = "Algodón"
        Me.RadioButtonAlgodon.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Peru
        Me.GroupBox3.Controls.Add(Me.TextBoxCantidad)
        Me.GroupBox3.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(90, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 89)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos a Ingresar "
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxCantidad.Location = New System.Drawing.Point(118, 52)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCantidad.TabIndex = 11
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxNombre.Location = New System.Drawing.Point(118, 24)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad de Chumpas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre del Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(146, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FABRICA DE CHUMPAS"
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.Chocolate
        Me.ButtonCalcular.ForeColor = System.Drawing.Color.Black
        Me.ButtonCalcular.Location = New System.Drawing.Point(66, 279)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 10
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.Chocolate
        Me.ButtonSalir.ForeColor = System.Drawing.Color.Black
        Me.ButtonSalir.Location = New System.Drawing.Point(268, 279)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 11
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.Chocolate
        Me.ButtonLimpiar.ForeColor = System.Drawing.Color.Black
        Me.ButtonLimpiar.Location = New System.Drawing.Point(164, 279)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 12
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Peru
        Me.GroupBox4.Controls.Add(Me.TextBoxUPVenta)
        Me.GroupBox4.Controls.Add(Me.TextBoxUPCosto)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(523, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 89)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL POR UNIDAD"
        '
        'TextBoxUPVenta
        '
        Me.TextBoxUPVenta.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxUPVenta.Location = New System.Drawing.Point(94, 52)
        Me.TextBoxUPVenta.Name = "TextBoxUPVenta"
        Me.TextBoxUPVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUPVenta.TabIndex = 12
        '
        'TextBoxUPCosto
        '
        Me.TextBoxUPCosto.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxUPCosto.Location = New System.Drawing.Point(94, 24)
        Me.TextBoxUPCosto.Name = "TextBoxUPCosto"
        Me.TextBoxUPCosto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUPCosto.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Precio de Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio de Costo"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Peru
        Me.GroupBox5.Controls.Add(Me.TextBoxTPVenta)
        Me.GroupBox5.Controls.Add(Me.TextBoxTPCosto)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(561, 335)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(156, 125)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TOTAL "
        '
        'TextBoxTPVenta
        '
        Me.TextBoxTPVenta.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxTPVenta.Location = New System.Drawing.Point(26, 86)
        Me.TextBoxTPVenta.Name = "TextBoxTPVenta"
        Me.TextBoxTPVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTPVenta.TabIndex = 12
        '
        'TextBoxTPCosto
        '
        Me.TextBoxTPCosto.BackColor = System.Drawing.Color.BurlyWood
        Me.TextBoxTPCosto.Location = New System.Drawing.Point(26, 32)
        Me.TextBoxTPCosto.Name = "TextBoxTPCosto"
        Me.TextBoxTPCosto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTPCosto.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Precio de Costo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio de venta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_02_18_at_15_53_55
        Me.ClientSize = New System.Drawing.Size(752, 489)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.Label1)
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
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonLarge As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMedium As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSmall As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonLona As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSeda As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAlgodon As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCalcular As System.Windows.Forms.Button
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxUPVenta As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUPCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTPVenta As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTPCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
