Public Class Form1

    Private _etapa As Double
    Private _equipo As String
    Private _kmReco As Double
    Private _tiempo As Double
    Private _nacionalidad As String

    Private Property Etapa(ByVal p1 As Object) As Double
        Get
            Return _etapa
        End Get
        Set(ByVal value As Double)
            _etapa = value
        End Set
    End Property

    Private Property Equipo(ByVal p1 As Object) As String
        Get
            Return _equipo
        End Get
        Set(ByVal value As String)
            _equipo = value
        End Set
    End Property

    Private Property KmReco(ByVal p1 As Object) As Double
        Get
            Return _kmReco
        End Get
        Set(ByVal value As Double)
            _kmReco = value
        End Set
    End Property

    Private Property Tiempo(ByVal p1 As Object) As Double
        Get
            Return _tiempo
        End Get
        Set(ByVal value As Double)
            _tiempo = value
        End Set
    End Property

    Private Property Nacionalidad(ByVal p1 As Object) As String
        Get
            Return _nacionalidad
        End Get
        Set(ByVal value As String)
            _nacionalidad = value
        End Set
    End Property

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim R = MsgBox("desea salir", vbQuestion + vbYesNo, "mensaje salida")
        If R = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        ComboBoxEtapa.Text = ""
        TextBoxKmR.Clear()
        TextBoxTiempoR.Clear()
        ComboBoxEquipo.Text = ""
        ComboBoxNacio.Text = ""
        ComboBoxEtapa.Focus()
    End Sub

    Private Sub EstadísticasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadísticasToolStripMenuItem1.Click
        TextBoxKmNacio.Clear()
        TextBoxKmSky.Clear()
        TextBoxKmMo.Clear()
        TextBoxKmCy.Clear()
        TextBoxKmTe.Clear()
        TextBoxTEx.Clear()
        TextBoxTNac.Focus()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        If (Indice <= 12) Then
            Etapa(Indice) = ComboBoxEtapa.Text
            Equipo(Indice) = ComboBoxEquipo.Text
            KmReco(Indice) = Val(TextBoxKmR.Text)

            If 120 < TextBoxTiempoR.Text < 140 Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) + 30
            End If

            If 140 < TextBoxTiempoR.Text < 160 Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) + 40
            End If

            If TextBoxTiempoR.Text < 85 And ComboBoxEquipo.Text = "Movistar" Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) - 15
            End If

            If TextBoxTiempoR.Text < 85 And ComboBoxEquipo.Text = "Pro Team" Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) - 10
            End If

            Nacionalidad(Indice) = ComboBoxNacio.Text
            DataGridView1.Rows.Add(Etapa(Indice), Equipo(Indice), KmReco(Indice), Tiempo(Indice), Nacionalidad(Indice))
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        Indice = 0
        While (Indice <= 12) And Not (existe)
            If (Etapa(Indice) = ComboBoxEtapa.Text) Then
                existe = True
            Else
                Indice = Indice + 1
            End If
        End While

        If (existe) Then
            Etapa(Indice) = ComboBoxEtapa.Text
            Equipo(Indice) = ComboBoxEquipo.Text
            KmReco(Indice) = Val(TextBoxKmR.Text)

            If 120 < TextBoxTiempoR.Text < 140 Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) + 30
            End If

            If 140 < TextBoxTiempoR.Text < 160 Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) + 40
            End If

            If TextBoxTiempoR.Text < 85 And ComboBoxEquipo.Text = "Movistar" Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) - 15
            End If

            If TextBoxTiempoR.Text < 85 And ComboBoxEquipo.Text = "Pro Team" Then
                Tiempo(Indice) = Val(TextBoxTiempoR.Text) - 10
            End If

            Nacionalidad(Indice) = ComboBoxNacio.Text
            DataGridView1.Rows.Add(Etapa(Indice), Equipo(Indice), KmReco(Indice), Tiempo(Indice), Nacionalidad(Indice))
        Else
            MsgBox("Registro no encontrado")
            ComboBoxEtapa.Focus()

            ComboBoxEtapa.Text = ""
            TextBoxKmR.Clear()
            TextBoxTiempoR.Clear()
            ComboBoxEquipo.Text = ""
            ComboBoxNacio.Text = ""
            ComboBoxEtapa.Focus()
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click

        Etapa(Indice) = ComboBoxEtapa.Text
        Equipo(Indice) = ComboBoxEquipo.Text
        KmReco(Indice) = Val(TextBoxKmR.Text)

        If 120 < TextBoxTiempoR.Text < 140 Then
            Tiempo(Indice) = Val(TextBoxTiempoR.Text) + 30
        End If

        If 140 < TextBoxTiempoR.Text < 160 Then
            Tiempo(Indice) = Val(TextBoxTiempoR.Text) + 40
        End If

        If TextBoxTiempoR.Text < 85 And ComboBoxEquipo.Text = "Movistar" Then
            Tiempo(Indice) = Val(TextBoxTiempoR.Text) - 15
        End If

        If TextBoxTiempoR.Text < 85 And ComboBoxEquipo.Text = "Pro Team" Then
            Tiempo(Indice) = Val(TextBoxTiempoR.Text) - 10
        End If

        Nacionalidad(Indice) = ComboBoxNacio.Text
        DataGridView1.Rows.Add(Etapa(Indice), Equipo(Indice), KmReco(Indice), Tiempo(Indice), Nacionalidad(Indice))
        MsgBox("Registro actualizado correctamente en los vectores")

        Indice = 12
    End Sub

    Private Sub OrdenarAscToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenarAscToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer

        For i = 0 To 11
            For j = i + 1 To 12
                If (Etapa(i) > Etapa(j)) Then
                    temp1 = Etapa(i)
                    Etapa(i) = Etapa(j)
                    Etapa(j) = temp1
                End If
            Next j
        Next i
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadísticasToolStripMenuItem.Click
        Dim I As Byte
        Dim KmNa As Byte = 0
        Dim Tiex As Byte = 0
        Dim Tinac As Byte = 0

        For I = 0 To 10
            If ComboBoxNacio.Text = "Guatemalteco" Then
                KmNa = KmReco(I) + 1
            End If

            If ComboBoxEquipo.Text = "Sky" Then
                TextBoxKmSky.Text = Str(KmReco(I) + 1)
            End If

            If ComboBoxEquipo.Text = "Movistar" Then
                TextBoxKmMo.Text = Str(KmReco(I) + 1)
            End If

            If ComboBoxEquipo.Text = "Pro Cycling" Then
                TextBoxKmCy.Text = Str(KmReco(I) + 1)
            End If

            If ComboBoxEquipo.Text = "Pro Team" Then
                TextBoxKmTe.Text = Str(KmReco(I) + 1)
            End If

            If ComboBoxNacio.Text = "Guatemalteco" Then
                Tinac = Tiempo(I) + 1
            End If

            If ComboBoxNacio.Text = "Extranjero" Then
                Tiex = Tiempo(I) + 1
            End If
        Next
        TextBoxKmNacio.Text = Str(KmNa)
        TextBoxTNac.Text = Str(Tinac)
        TextBoxTEx.Text = Str(Tiex)
    End Sub
End Class
