Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        TextBoxPlaca.Text = ""
        TextBoxFinal.Text = ""
        TextBoxInicial.Text = ""
        ComboBoxTipo.Text = ""
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        If Indice <= 7 Then

        Else
            MessageBox.Show("Ya se llegó al límite de Inscripciones")
        End If


        If TextBoxPlaca.Text = ("") Then
            MessageBox.Show("Ingrese un número de placa")
        End If

        If TextBoxInicial.Text = ("") Then
            MessageBox.Show("Ingrese un valor inicial de kilometraje")
        End If

        If TextBoxFinal.Text = ("") Then
            MessageBox.Show("Ingrese un valor final de kilometraje")
        End If

        If ComboBoxTipo.Text = ("") Then
            MessageBox.Show("Seleccione un tipo de auto")
        End If

        Placa(Indice) = Val(TextBoxPlaca.Text)
        Tipo(Indice) = ComboBoxTipo.SelectedItem

        If ComboBoxTipo.Text = "Tipo 1" Then
            Cobrob(Indice) = 500
        End If

        If ComboBoxTipo.Text = "Tipo 2" Then
            Cobrob(Indice) = 400
        End If

        If ComboBoxTipo.Text = "Tipo 3" Then
            Cobrob(Indice) = 300
        End If

        If ComboBoxTipo.Text = "Tipo 4" Then
            Cobrob(Indice) = 200
        End If

        Kinicio(Indice) = Val(TextBoxInicial.Text)
        Kfinal(Indice) = Val(TextBoxFinal.Text)

        If TextBoxInicial.Text >= 0 And TextBoxFinal.Text <= 50 Then
            Pago(Indice) = Val(Cobrob(Indice)) + ((TextBoxFinal.Text - TextBoxInicial.Text) * 3)
        End If

        If TextBoxInicial.Text >= 51 And TextBoxFinal.Text <= 70 Then
            Pago(Indice) = Val(Cobrob(Indice)) + ((TextBoxFinal.Text - TextBoxInicial.Text) * 4)
        End If

        If TextBoxInicial.Text >= 70 Then
            Pago(Indice) = Val(Cobrob(Indice)) + ((TextBoxFinal.Text - TextBoxInicial.Text) * 5)
        End If


        DataGridView1.Rows.Add(Str(Placa(Indice)), Tipo(Indice), (Cobrob(Indice)), Str(Kinicio(Indice)), Str(Kfinal(Indice)), (Pago(Indice)))


    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        For I = 0 To 7
            If (Placa(Indice) <> Nothing) Then
                DataGridView1.Rows.Add(Str(Placa(Indice)), Tipo(Indice), Str(Cobrob(Indice)), Str(Kinicio(Indice)), Str(Kfinal(Indice)), Str(Pago(Indice)))
            Else
                Exit For
            End If
        Next I
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False

        Indice = 0

        While (Indice <= 7) And Not (existe)
            If (Placa(Indice) = Val(TextBoxPlaca.Text)) Then
                existe = True
            Else
                Indice = Indice + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            TextBoxPlaca.Text = Str(Placa(Indice))
            TextBoxInicial.Text = Str(Kinicio(Indice))
            TextBoxFinal.Text = Str(Kfinal(Indice))
            ComboBoxTipo.Text = Tipo(Indice)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Placa(Indice)), Tipo(Indice), (Cobrob(Indice)), Str(Kinicio(Indice)), Str(Kfinal(Indice)), (Pago(Indice)))
        Else
            MsgBox("Número de Placa no encontrado")
            TextBoxPlaca.Focus()
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        If Indice <= 7 Then

        Else
            MessageBox.Show("Ya se llegó al límite de Inscripciones")
        End If


        If TextBoxPlaca.Text = ("") Then
            MessageBox.Show("Ingrese un número de placa")
        End If

        If TextBoxInicial.Text = ("") Then
            MessageBox.Show("Ingrese un valor inicial de kilometraje")
        End If

        If TextBoxFinal.Text = ("") Then
            MessageBox.Show("Ingrese un valor final de kilometraje")
        End If

        If ComboBoxTipo.Text = ("") Then
            MessageBox.Show("Seleccione un tipo de auto")
        End If

        Placa(Indice) = Val(TextBoxPlaca.Text)
        Tipo(Indice) = ComboBoxTipo.SelectedItem

        If ComboBoxTipo.Text = "Tipo 1" Then
            Cobrob(Indice) = 500
        End If

        If ComboBoxTipo.Text = "Tipo 2" Then
            Cobrob(Indice) = 400
        End If

        If ComboBoxTipo.Text = "Tipo 3" Then
            Cobrob(Indice) = 300
        End If

        If ComboBoxTipo.Text = "Tipo 4" Then
            Cobrob(Indice) = 200
        End If

        Kinicio(Indice) = Val(TextBoxInicial.Text)
        Kfinal(Indice) = Val(TextBoxFinal.Text)

        If TextBoxInicial.Text >= 0 And TextBoxFinal.Text <= 50 Then
            Pago(Indice) = Val(Cobrob(Indice)) + ((TextBoxFinal.Text - TextBoxInicial.Text) * 3)
        End If

        If TextBoxInicial.Text >= 51 And TextBoxFinal.Text <= 70 Then
            Pago(Indice) = Val(Cobrob(Indice)) + ((TextBoxFinal.Text - TextBoxInicial.Text) * 4)
        End If

        If TextBoxInicial.Text >= 70 Then
            Pago(Indice) = Val(Cobrob(Indice)) + ((TextBoxFinal.Text - TextBoxInicial.Text) * 5)
        End If


        DataGridView1.Rows.Add(Str(Placa(Indice)), Tipo(Indice), (Cobrob(Indice)), Str(Kinicio(Indice)), Str(Kfinal(Indice)), (Pago(Indice)))

        MsgBox("Registro actualizado correctamente en los vectores")
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Placa(fila) = Nothing
        Tipo(fila) = Nothing
        Cobrob(fila) = Nothing
        Kinicio(fila) = Nothing
        Kfinal(fila) = Nothing
        Pago(fila) = Nothing

        For I = fila To 7
            Placa(Indice) = Placa(Indice + 1)
            Tipo(Indice) = Tipo(Indice + 1)
            Cobrob(Indice) = Cobrob(Indice + 1)
            Kinicio(Indice) = Kinicio(Indice + 1)
            Kfinal(Indice) = Kfinal(Indice + 1)
            Pago(Indice) = Pago(Indice + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        Placa(fila) = Nothing
        Tipo(fila) = Nothing
        Cobrob(fila) = Nothing
        Kinicio(fila) = Nothing
        Kfinal(fila) = Nothing
        Pago(fila) = Nothing

        fila = Indice
        DataGridView1.Rows.Clear()
        TextBoxPlaca.Text = ""
        TextBoxFinal.Text = ""
        TextBoxInicial.Text = ""
        ComboBoxTipo.Text = ""
    End Sub
End Class
