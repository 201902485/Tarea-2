Public Class Form1

    Private Sub CheckBoxNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxNormal.CheckedChanged
        If (CheckBoxNormal.Checked) Then
            TextBoxNormal.Visible = True
            TextBoxNormal.Focus()
        Else
            TextBoxNormal.Clear()
            TextBoxNormal.Visible = False
        End If
    End Sub

    Private Sub CheckBox3D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3D.CheckedChanged
        If (CheckBox3D.Checked) Then
            TextBox3D.Visible = True
            TextBox3D.Focus()
        Else
            TextBox3D.Clear()
            TextBox3D.Visible = False
        End If
    End Sub
    Private Sub CheckBox4DX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4DX.CheckedChanged
        If (CheckBox4DX.Checked) Then
            TextBox4DX.Visible = True
            TextBox4DX.Focus()
        Else
            TextBox4DX.Clear()
            TextBox4DX.Visible = False
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        TextBoxNIT.Text = ""
        TextBoxPeli.Text = ""
        TextBoxNormal.Text = ""
        TextBox3D.Text = ""
        TextBox4DX.Text = ""
        CheckBox3D.Checked = False
        CheckBoxNormal.Checked = False
        CheckBox4DX.Checked = False
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        If Indice <= 7 Then

            Nit(Indice) = Val(TextBoxNIT.Text)
            Peli(Indice) = TextBoxPeli.Text
            SalaNormal(Indice) = Val(TextBoxNormal.Text)
            Sala3D(Indice) = Val(TextBox3D.Text)
            Sala4DX(Indice) = Val(TextBox4DX.Text)

            If CheckBoxNormal.Checked Then
                SNormal = (44) * Val(TextBoxNormal.Text)
            Else : SNormal = 0
            End If

            If CheckBox3D.Checked Then
                S3D = (62) * Val(TextBox3D.Text)
            Else : S3D = 0
            End If

            If CheckBox4DX.Checked Then
                S4DX = (44) * Val(TextBox4DX.Text)
            Else : S4DX = 0
            End If

            Total(Indice) = Val(SNormal + S3D + S4DX)

            DataGridView1.Rows.Add(Nit(Indice), Peli(Indice), Str(SalaNormal(Indice)), Str(Sala3D(Indice)), Str(Sala4DX(Indice)), Str(Total(Indice)))

        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click

        Nit(Indice) = Val(TextBoxNIT.Text)
        Peli(Indice) = TextBoxPeli.Text
        SalaNormal(Indice) = Val(TextBoxNormal.Text)
        Sala3D(Indice) = Val(TextBox3D.Text)
        Sala4DX(Indice) = Val(TextBox4DX.Text)

        If CheckBoxNormal.Checked Then
            SNormal = (44) * Val(TextBoxNormal.Text)
        Else : SNormal = 0
        End If

        If CheckBox3D.Checked Then
            S3D = (62) * Val(TextBox3D.Text)
        Else : S3D = 0
        End If

        If CheckBox4DX.Checked Then
            S4DX = (44) * Val(TextBox4DX.Text)
        Else : S4DX = 0
        End If

        Total(Indice) = Val(SNormal + S3D + S4DX)

        If (CheckBoxNormal.Checked) Then
            SalaNormal(Indice) = Val(TextBoxNormal.Text)
        ElseIf (CheckBox3D.Checked) Then
            Sala3D(Indice) = Val(TextBox3D.Text)
        ElseIf (CheckBox4DX.Checked) Then
            Sala4DX(Indice) = Val(TextBox4DX.Text)
        End If

        DataGridView1.Rows.Add(Nit(Indice), Peli(Indice), Str(SalaNormal(Indice)), Str(Sala3D(Indice)), Str(Sala4DX(Indice)), Str(Total(Indice)))
        MsgBox("Registro actualizado correctamente en la matriz")
        Indice = 5

        DataGridView1.Rows.Clear()
        TextBoxNIT.Text = ""
        TextBoxPeli.Text = ""
        TextBoxNormal.Text = ""
        TextBox3D.Text = ""
        TextBox4DX.Text = ""
        CheckBox3D.Checked = False
        CheckBoxNormal.Checked = False
        CheckBox4DX.Checked = False
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If TextBoxNIT.Text = ("") Then
            MessageBox.Show("Ingrese un número de NIT")
        End If

        If TextBoxPeli.Text = ("") Then
            MessageBox.Show("Ingrese una Película")
        End If

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim existe As Boolean = True
        Indice = 0
        While (Indice <= 7) And (existe)
            If (Nit(Indice) <> Nothing) Then
                If (Val(Nit(Indice)) = Val(TextBoxNIT.Text)) Then
                    existe = False
                Else
                    Indice = Indice + 1
                End If
            Else
                Exit While
            End If
        End While
        If (existe) Then
            MsgBox("Número de NIT no encontrado")
            TextBoxNIT.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")


            Nit(Indice) = Val(TextBoxNIT.Text)
            Peli(Indice) = TextBoxPeli.Text
            SalaNormal(Indice) = Val(TextBoxNormal.Text)
            Sala3D(Indice) = Val(TextBox3D.Text)
            Sala4DX(Indice) = Val(TextBox4DX.Text)
            Total(Indice) = Val(SNormal + S3D + S4DX)


            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Nit(Indice), Peli(Indice), Str(SalaNormal(Indice)), Str(Sala3D(Indice)), Str(Sala4DX(Indice)), Str(Total(Indice)))
        End If
    End Sub
End Class
