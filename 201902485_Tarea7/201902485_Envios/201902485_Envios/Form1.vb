Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBoxPaquete.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("Debe Colocar un nombre")
        End If
        If TextBox2.Text = "" Then
            MsgBox("Debe colocar el valor del paquete")
        End If
        If TextBox3.Text = "" Then
            MsgBox("Debe colocar el peso del paquete")
        End If
        If ComboBoxPaquete.Text = "" Then
            MsgBox("Elija un tipo de paquete")
        End If
        If ComboBox2.Text = "" Then
            MsgBox("Elija una forma de envío")
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBoxPaquete.Text = ""
        ComboBox2.Text = ""

    End Sub


    Private Sub VectoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem1.Click
        If (Indice <= 10) Then
            Nombre(Indice) = TextBox1.Text
            TipoPaquete(Indice) = ComboBoxPaquete.SelectedItem
            ValorPaquete(Indice) = Val(TextBox2.Text)

            If ComboBoxPaquete.Text = "Documentos" And ComboBox2.Text = "Camion" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.015 * Val(TextBox3.Text) + 50
            End If

            If ComboBoxPaquete.Text = "Documentos" And ComboBox2.Text = "Motocicleta" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.015 * Val(TextBox3.Text) + 15
            End If

            If ComboBoxPaquete.Text = "Ropa" And ComboBox2.Text = "Camion" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.06 * Val(TextBox3.Text) + 50
            End If

            If ComboBoxPaquete.Text = "Ropa" And ComboBox2.Text = "Motocicleta" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.06 * Val(TextBox3.Text) + 15
            End If

            If ComboBoxPaquete.Text = "Articulos No Pedecederos" And ComboBox2.Text = "Camion" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.055 * Val(TextBox3.Text) + 50
            End If

            If ComboBoxPaquete.Text = "Articulos No Pedecederos" And ComboBox2.Text = "Motocicleta" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.055 * Val(TextBox3.Text) + 15
            End If

            If ComboBoxPaquete.Text = "Articulos de Plastico" And ComboBox2.Text = "Camion" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.045 * Val(TextBox3.Text) + 50
            End If

            If ComboBoxPaquete.Text = "Articulos de Plastico" And ComboBox2.Text = "Motocicleta" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.045 * Val(TextBox3.Text) + 15
            End If

            If ComboBoxPaquete.Text = "Lociones" And ComboBox2.Text = "Camion" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.02 * Val(TextBox3.Text) + 50
            End If

            If ComboBoxPaquete.Text = "Lociones" And ComboBox2.Text = "Motocicleta" Then
                PagoParcial(Indice) = ValorPaquete(Indice) + 0.02 * Val(TextBox3.Text) + 15
            End If

            Impuesto(Indice) = Val(PagoParcial(Indice)) * 0.1
            PagoTotal(Indice) = Val(PagoParcial(Indice)) + Val(Impuesto(Indice))

            DataGridView1.Rows.Add(Nombre(Indice), TipoPaquete(Indice), ValorPaquete(Indice), PagoParcial(Indice), Impuesto(Indice), PagoTotal(Indice))
        End If
    End Sub

    Private Sub ListasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListasToolStripMenuItem.Click
        ListBox1.Items.Add(Nombre(Indice))
        ListBox2.Items.Add(PagoTotal(Indice))
    End Sub

    Private Sub EstadísticasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadísticasToolStripMenuItem1.Click
        Dim I As Byte
        Dim TL As Byte = 0
        Dim CP As Byte = 0
        Dim TD As Byte = 0
        Dim CR As Byte = 0

        For I = 0 To 10
            If ComboBoxPaquete.Text = "Locion" Then
                TL = PagoTotal(I) + 1
            End If

            If ComboBoxPaquete.Text = "Articulos de Plastico" Then
                CP = I + 1
            End If

            If ComboBoxPaquete.Text = "Documentos" Then
                TD = PagoTotal(I) + 1
            End If

            If ComboBoxPaquete.Text = "Ropa" Then
                CR = I + 1
            End If
        Next
        TextBox4.Text = Str(TL)
        TextBox5.Text = Str(CP)
        TextBox6.Text = Str(TD)
        TextBox7.Text = Str(CR)
    End Sub

End Class
