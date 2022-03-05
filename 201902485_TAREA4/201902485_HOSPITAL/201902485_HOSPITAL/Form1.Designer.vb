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
        Me.GroupBoxIngreso = New System.Windows.Forms.GroupBox()
        Me.TextBoxHonorarios = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDias = New System.Windows.Forms.TextBox()
        Me.TextBoxNit = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPago = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNoPriv = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSemiPriv = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPrivada = New System.Windows.Forms.RadioButton()
        Me.GroupBoxServicio = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMaternidad = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperacion = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEncama = New System.Windows.Forms.CheckBox()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GaurdarVectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxIngreso.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxServicio.SuspendLayout()
        Me.GroupBoxClientes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxIngreso
        '
        Me.GroupBoxIngreso.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBoxIngreso.Controls.Add(Me.TextBoxHonorarios)
        Me.GroupBoxIngreso.Controls.Add(Me.Label4)
        Me.GroupBoxIngreso.Controls.Add(Me.TextBoxDias)
        Me.GroupBoxIngreso.Controls.Add(Me.TextBoxNit)
        Me.GroupBoxIngreso.Controls.Add(Me.TextBoxNombre)
        Me.GroupBoxIngreso.Controls.Add(Me.Label3)
        Me.GroupBoxIngreso.Controls.Add(Me.Label2)
        Me.GroupBoxIngreso.Controls.Add(Me.Label1)
        Me.GroupBoxIngreso.Location = New System.Drawing.Point(72, 80)
        Me.GroupBoxIngreso.Name = "GroupBoxIngreso"
        Me.GroupBoxIngreso.Size = New System.Drawing.Size(198, 131)
        Me.GroupBoxIngreso.TabIndex = 0
        Me.GroupBoxIngreso.TabStop = False
        Me.GroupBoxIngreso.Text = "Datos de Ingreso"
        '
        'TextBoxHonorarios
        '
        Me.TextBoxHonorarios.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxHonorarios.Location = New System.Drawing.Point(92, 100)
        Me.TextBoxHonorarios.Name = "TextBoxHonorarios"
        Me.TextBoxHonorarios.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHonorarios.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Honorarios M"
        '
        'TextBoxDias
        '
        Me.TextBoxDias.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxDias.Location = New System.Drawing.Point(92, 72)
        Me.TextBoxDias.Name = "TextBoxDias"
        Me.TextBoxDias.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDias.TabIndex = 4
        '
        'TextBoxNit
        '
        Me.TextBoxNit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxNit.Location = New System.Drawing.Point(92, 46)
        Me.TextBoxNit.Name = "TextBoxNit"
        Me.TextBoxNit.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNit.TabIndex = 3
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxNombre.Location = New System.Drawing.Point(92, 20)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Días Hosp."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Controls.Add(Me.ComboBoxPago)
        Me.GroupBox2.Location = New System.Drawing.Point(619, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'ComboBoxPago
        '
        Me.ComboBoxPago.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBoxPago.FormattingEnabled = True
        Me.ComboBoxPago.Location = New System.Drawing.Point(6, 22)
        Me.ComboBoxPago.Name = "ComboBoxPago"
        Me.ComboBoxPago.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPago.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox3.Controls.Add(Me.RadioButtonNoPriv)
        Me.GroupBox3.Controls.Add(Me.RadioButtonSemiPriv)
        Me.GroupBox3.Controls.Add(Me.RadioButtonPrivada)
        Me.GroupBox3.Location = New System.Drawing.Point(460, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(137, 74)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Habitación"
        '
        'RadioButtonNoPriv
        '
        Me.RadioButtonNoPriv.AutoSize = True
        Me.RadioButtonNoPriv.Location = New System.Drawing.Point(17, 47)
        Me.RadioButtonNoPriv.Name = "RadioButtonNoPriv"
        Me.RadioButtonNoPriv.Size = New System.Drawing.Size(78, 17)
        Me.RadioButtonNoPriv.TabIndex = 2
        Me.RadioButtonNoPriv.TabStop = True
        Me.RadioButtonNoPriv.Text = "No Privada"
        Me.RadioButtonNoPriv.UseVisualStyleBackColor = True
        '
        'RadioButtonSemiPriv
        '
        Me.RadioButtonSemiPriv.AutoSize = True
        Me.RadioButtonSemiPriv.Location = New System.Drawing.Point(17, 31)
        Me.RadioButtonSemiPriv.Name = "RadioButtonSemiPriv"
        Me.RadioButtonSemiPriv.Size = New System.Drawing.Size(87, 17)
        Me.RadioButtonSemiPriv.TabIndex = 1
        Me.RadioButtonSemiPriv.TabStop = True
        Me.RadioButtonSemiPriv.Text = "Semi Privada"
        Me.RadioButtonSemiPriv.UseVisualStyleBackColor = True
        '
        'RadioButtonPrivada
        '
        Me.RadioButtonPrivada.AutoSize = True
        Me.RadioButtonPrivada.Location = New System.Drawing.Point(17, 15)
        Me.RadioButtonPrivada.Name = "RadioButtonPrivada"
        Me.RadioButtonPrivada.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonPrivada.TabIndex = 0
        Me.RadioButtonPrivada.TabStop = True
        Me.RadioButtonPrivada.Text = "Privada"
        Me.RadioButtonPrivada.UseVisualStyleBackColor = True
        '
        'GroupBoxServicio
        '
        Me.GroupBoxServicio.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBoxServicio.Controls.Add(Me.CheckBoxMaternidad)
        Me.GroupBoxServicio.Controls.Add(Me.CheckBoxOperacion)
        Me.GroupBoxServicio.Controls.Add(Me.CheckBoxEncama)
        Me.GroupBoxServicio.Location = New System.Drawing.Point(304, 111)
        Me.GroupBoxServicio.Name = "GroupBoxServicio"
        Me.GroupBoxServicio.Size = New System.Drawing.Size(128, 74)
        Me.GroupBoxServicio.TabIndex = 3
        Me.GroupBoxServicio.TabStop = False
        Me.GroupBoxServicio.Text = "Tipo de Servicio "
        '
        'CheckBoxMaternidad
        '
        Me.CheckBoxMaternidad.AutoSize = True
        Me.CheckBoxMaternidad.Location = New System.Drawing.Point(19, 49)
        Me.CheckBoxMaternidad.Name = "CheckBoxMaternidad"
        Me.CheckBoxMaternidad.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxMaternidad.TabIndex = 2
        Me.CheckBoxMaternidad.Text = "Maternidad"
        Me.CheckBoxMaternidad.UseVisualStyleBackColor = True
        '
        'CheckBoxOperacion
        '
        Me.CheckBoxOperacion.AutoSize = True
        Me.CheckBoxOperacion.Location = New System.Drawing.Point(19, 32)
        Me.CheckBoxOperacion.Name = "CheckBoxOperacion"
        Me.CheckBoxOperacion.Size = New System.Drawing.Size(75, 17)
        Me.CheckBoxOperacion.TabIndex = 1
        Me.CheckBoxOperacion.Text = "Operación"
        Me.CheckBoxOperacion.UseVisualStyleBackColor = True
        '
        'CheckBoxEncama
        '
        Me.CheckBoxEncama.AutoSize = True
        Me.CheckBoxEncama.Location = New System.Drawing.Point(19, 16)
        Me.CheckBoxEncama.Name = "CheckBoxEncama"
        Me.CheckBoxEncama.Size = New System.Drawing.Size(96, 17)
        Me.CheckBoxEncama.TabIndex = 0
        Me.CheckBoxEncama.Text = "Encamamiento"
        Me.CheckBoxEncama.UseVisualStyleBackColor = True
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBoxClientes.Controls.Add(Me.DataGridView1)
        Me.GroupBoxClientes.Location = New System.Drawing.Point(16, 230)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(760, 216)
        Me.GroupBoxClientes.TabIndex = 4
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Resultados"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(747, 191)
        Me.DataGridView1.TabIndex = 0
        '
        'Column8
        '
        Me.Column8.HeaderText = "Nombre"
        Me.Column8.Name = "Column8"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nit"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DiasHosp"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Honorarios"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Habitacion"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "FPago"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Servicio"
        Me.Column6.Name = "Column6"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.GaurdarVectorToolStripMenuItem, Me.CalcularToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem, Me.VectoresToolStripMenuItem})
        Me.LimpiarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan
        Me.EntradasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'VectoresToolStripMenuItem
        '
        Me.VectoresToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan
        Me.VectoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VectoresToolStripMenuItem.Name = "VectoresToolStripMenuItem"
        Me.VectoresToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.VectoresToolStripMenuItem.Text = "Vectores"
        '
        'GaurdarVectorToolStripMenuItem
        '
        Me.GaurdarVectorToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan
        Me.GaurdarVectorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GaurdarVectorToolStripMenuItem.Name = "GaurdarVectorToolStripMenuItem"
        Me.GaurdarVectorToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.GaurdarVectorToolStripMenuItem.Text = "Guardar Dato"
        '
        'CalcularToolStripMenuItem1
        '
        Me.CalcularToolStripMenuItem1.BackColor = System.Drawing.Color.DarkCyan
        Me.CalcularToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CalcularToolStripMenuItem1.Name = "CalcularToolStripMenuItem1"
        Me.CalcularToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem1.Text = "Calcular"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_03_04_at_11_231
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.GroupBoxClientes)
        Me.Controls.Add(Me.GroupBoxServicio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxIngreso)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxIngreso.ResumeLayout(False)
        Me.GroupBoxIngreso.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBoxServicio.ResumeLayout(False)
        Me.GroupBoxServicio.PerformLayout()
        Me.GroupBoxClientes.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxIngreso As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxHonorarios As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDias As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNit As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxPago As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxServicio As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxMaternidad As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperacion As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxEncama As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxClientes As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButtonNoPriv As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSemiPriv As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPrivada As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalcularToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GaurdarVectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
