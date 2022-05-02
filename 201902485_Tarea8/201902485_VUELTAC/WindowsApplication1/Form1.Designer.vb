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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarAscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxNacio = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEquipo = New System.Windows.Forms.ComboBox()
        Me.TextBoxTiempoR = New System.Windows.Forms.TextBox()
        Me.TextBoxKmR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTNac = New System.Windows.Forms.TextBox()
        Me.TextBoxTEx = New System.Windows.Forms.TextBox()
        Me.TextBoxKmTe = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxKmCy = New System.Windows.Forms.TextBox()
        Me.TextBoxKmMo = New System.Windows.Forms.TextBox()
        Me.TextBoxKmSky = New System.Windows.Forms.TextBox()
        Me.TextBoxKmNacio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadísticasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBoxEtapa = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.OrdenarAscToolStripMenuItem, Me.EstadísticasToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'OrdenarAscToolStripMenuItem
        '
        Me.OrdenarAscToolStripMenuItem.Name = "OrdenarAscToolStripMenuItem"
        Me.OrdenarAscToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.OrdenarAscToolStripMenuItem.Text = "Ordenar Asc"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VectoresToolStripMenuItem, Me.EntradasToolStripMenuItem, Me.EstadísticasToolStripMenuItem1})
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'VectoresToolStripMenuItem
        '
        Me.VectoresToolStripMenuItem.BackColor = System.Drawing.Color.Gold
        Me.VectoresToolStripMenuItem.Name = "VectoresToolStripMenuItem"
        Me.VectoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VectoresToolStripMenuItem.Text = "Vectores"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.BackColor = System.Drawing.Color.Gold
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.ComboBoxEtapa)
        Me.GroupBox1.Controls.Add(Me.ComboBoxNacio)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEquipo)
        Me.GroupBox1.Controls.Add(Me.TextBoxTiempoR)
        Me.GroupBox1.Controls.Add(Me.TextBoxKmR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Registro"
        '
        'ComboBoxNacio
        '
        Me.ComboBoxNacio.FormattingEnabled = True
        Me.ComboBoxNacio.Items.AddRange(New Object() {"Guatemalteco", "Extranjero"})
        Me.ComboBoxNacio.Location = New System.Drawing.Point(94, 132)
        Me.ComboBoxNacio.Name = "ComboBoxNacio"
        Me.ComboBoxNacio.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNacio.TabIndex = 10
        '
        'ComboBoxEquipo
        '
        Me.ComboBoxEquipo.FormattingEnabled = True
        Me.ComboBoxEquipo.Items.AddRange(New Object() {"Sky", "Movistar", "Pro Cycling ", "Pro Team "})
        Me.ComboBoxEquipo.Location = New System.Drawing.Point(94, 48)
        Me.ComboBoxEquipo.Name = "ComboBoxEquipo"
        Me.ComboBoxEquipo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxEquipo.TabIndex = 3
        '
        'TextBoxTiempoR
        '
        Me.TextBoxTiempoR.Location = New System.Drawing.Point(103, 102)
        Me.TextBoxTiempoR.Name = "TextBoxTiempoR"
        Me.TextBoxTiempoR.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTiempoR.TabIndex = 9
        '
        'TextBoxKmR
        '
        Me.TextBoxKmR.Location = New System.Drawing.Point(103, 75)
        Me.TextBoxKmR.Name = "TextBoxKmR"
        Me.TextBoxKmR.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxKmR.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nacionalidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tiempo (min)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Km Recorridos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Etapa"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox2.Controls.Add(Me.TextBoxTNac)
        Me.GroupBox2.Controls.Add(Me.TextBoxTEx)
        Me.GroupBox2.Controls.Add(Me.TextBoxKmTe)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBoxKmCy)
        Me.GroupBox2.Controls.Add(Me.TextBoxKmMo)
        Me.GroupBox2.Controls.Add(Me.TextBoxKmSky)
        Me.GroupBox2.Controls.Add(Me.TextBoxKmNacio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(266, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 166)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estadísticas"
        '
        'TextBoxTNac
        '
        Me.TextBoxTNac.Location = New System.Drawing.Point(393, 95)
        Me.TextBoxTNac.Name = "TextBoxTNac"
        Me.TextBoxTNac.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxTNac.TabIndex = 18
        '
        'TextBoxTEx
        '
        Me.TextBoxTEx.Location = New System.Drawing.Point(393, 62)
        Me.TextBoxTEx.Name = "TextBoxTEx"
        Me.TextBoxTEx.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxTEx.TabIndex = 17
        '
        'TextBoxKmTe
        '
        Me.TextBoxKmTe.Location = New System.Drawing.Point(393, 27)
        Me.TextBoxKmTe.Name = "TextBoxKmTe"
        Me.TextBoxKmTe.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxKmTe.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(252, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Tiempo Total Nacionales"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(253, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tiempo Total Extranjeros"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(280, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Km Totales PTeam"
        '
        'TextBoxKmCy
        '
        Me.TextBoxKmCy.Location = New System.Drawing.Point(137, 127)
        Me.TextBoxKmCy.Name = "TextBoxKmCy"
        Me.TextBoxKmCy.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxKmCy.TabIndex = 12
        '
        'TextBoxKmMo
        '
        Me.TextBoxKmMo.Location = New System.Drawing.Point(137, 95)
        Me.TextBoxKmMo.Name = "TextBoxKmMo"
        Me.TextBoxKmMo.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxKmMo.TabIndex = 11
        '
        'TextBoxKmSky
        '
        Me.TextBoxKmSky.Location = New System.Drawing.Point(136, 62)
        Me.TextBoxKmSky.Name = "TextBoxKmSky"
        Me.TextBoxKmSky.Size = New System.Drawing.Size(79, 20)
        Me.TextBoxKmSky.TabIndex = 10
        '
        'TextBoxKmNacio
        '
        Me.TextBoxKmNacio.Location = New System.Drawing.Point(136, 27)
        Me.TextBoxKmNacio.Name = "TextBoxKmNacio"
        Me.TextBoxKmNacio.Size = New System.Drawing.Size(79, 20)
        Me.TextBoxKmNacio.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Km Totales PCycling"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Km Totales Movistar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Km Totales Sky "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nacionales (+45km)"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Khaki
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 176)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. de Etapa"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Equipo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Km Recorridos"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tiempo (min)"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nacionalidad"
        Me.Column5.Name = "Column5"
        '
        'EstadísticasToolStripMenuItem1
        '
        Me.EstadísticasToolStripMenuItem1.BackColor = System.Drawing.Color.Gold
        Me.EstadísticasToolStripMenuItem1.Name = "EstadísticasToolStripMenuItem1"
        Me.EstadísticasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EstadísticasToolStripMenuItem1.Text = "Estadísticas"
        '
        'ComboBoxEtapa
        '
        Me.ComboBoxEtapa.FormattingEnabled = True
        Me.ComboBoxEtapa.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBoxEtapa.Location = New System.Drawing.Point(90, 21)
        Me.ComboBoxEtapa.Name = "ComboBoxEtapa"
        Me.ComboBoxEtapa.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxEtapa.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_05_02_at_11_23_06_AM
        Me.ClientSize = New System.Drawing.Size(766, 474)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenarAscToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxNacio As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxTiempoR As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKmR As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTNac As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTEx As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKmTe As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKmCy As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKmMo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKmSky As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKmNacio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadísticasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBoxEtapa As System.Windows.Forms.ComboBox

End Class
