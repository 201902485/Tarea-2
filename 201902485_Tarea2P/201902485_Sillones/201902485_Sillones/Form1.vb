Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub DatosDeEntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosDeEntradaToolStripMenuItem.Click
        TextBoxVenta.Clear()
        ComboBoxTamaño.Text = ""
        ComboBoxTela.Text = ""
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        If Indice < 8 Then
            Venta(Indice) = TextBoxVenta.Text
            Tamaño(Indice) = ComboBoxTamaño.SelectedItem
            Tela(Indice) = ComboBoxTela.SelectedItem

            DataGridView1.Rows.Add(Venta(Indice), Tamaño(Indice), Tela(Indice))
        Else
            MessageBox.Show("Ya se llegó al límite de Inscripciones")
        End If

        If TextBoxVenta.Text = ("") Then
            MessageBox.Show("Ingrese un número de venta")
        End If

        If ComboBoxTamaño.Text = ("") Then
            MessageBox.Show("Seleccione un tamaño")
        End If

        If ComboBoxTela.Text = ("") Then
            MessageBox.Show("Seleccione un tipo de tela")
        End If


    End Sub

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        If ComboBoxTamaño.Text = "Sofá" And ComboBoxTela.Text = "Cuero" Then
            Costo(Indice2) = PSofa + PCuero * YrdSofa
        End If

        If ComboBoxTamaño.Text = "Sofá" And ComboBoxTela.Text = "Cuerina" Then
            Costo(Indice2) = PSofa + PCuerina * YrdSofa
        End If

        If ComboBoxTamaño.Text = "Individual" And ComboBoxTela.Text = "Cuero" Then
            Costo(Indice2) = PIndivual + PCuero * YrdIndiviual
        End If

        If ComboBoxTamaño.Text = "Individual" And ComboBoxTela.Text = "Cuerina" Then
            Costo(Indice2) = PIndivual + PCuerina * YrdIndiviual
        End If

        If ComboBoxTamaño.Text = "Doble" And ComboBoxTela.Text = "Cuero" Then
            Costo(Indice2) = PDoble + PCuero * YrdDoble
        End If

        If ComboBoxTamaño.Text = "Doble" And ComboBoxTela.Text = "Cuerina" Then
            Costo(Indice2) = PDoble + PCuerina * YrdDoble
        End If

        PVenta(Indice2) = Costo(Indice2) * PorcentajeVenta

        DataGridView2.Rows.Add(Costo(Indice2), PVenta(Indice2))

    End Sub
End Class
