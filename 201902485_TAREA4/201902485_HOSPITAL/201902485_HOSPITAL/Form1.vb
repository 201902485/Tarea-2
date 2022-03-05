Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxPago.Items.Add("Efectivo")
        ComboBoxPago.Items.Add("Cheque")
        ComboBoxPago.Items.Add("Tarjeta Débito")
        ComboBoxPago.Items.Add("Tarjeta Crédito")


    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        TextBoxNombre.Clear()
        TextBoxNit.Clear()
        TextBoxDias.Clear()
        TextBoxHonorarios.Clear()
        CheckBoxEncama.Checked = False
        CheckBoxMaternidad.Checked = False
        CheckBoxOperacion.Checked = False
        RadioButtonNoPriv.Checked = False
        RadioButtonPrivada.Checked = False
        RadioButtonSemiPriv.Checked = False
        ComboBoxPago.Text = ""
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub GaurdarVectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GaurdarVectorToolStripMenuItem.Click
        Nombre(Index) = TextBoxNombre.Text
        Nit(Index) = Val(TextBoxNit.Text)
        DiasHops(Index) = Val(TextBoxDias.Text)
        Honorarios(Index) = Val(TextBoxHonorarios.Text)
        Habitacion(Index) = (RadioButtonPrivada.Checked Or RadioButtonSemiPriv.Checked Or RadioButtonNoPriv.Checked)
        FPago(Index) = ComboBoxPago.SelectedItem
        Servicio(Index) = (CheckBoxEncama.Checked Or CheckBoxOperacion.Checked Or CheckBoxMaternidad.Checked)
        DataGridView1.Rows.Add(Nombre(Index), Nit(Index), DiasHops(Index), Honorarios(Index), Habitacion(Index), FPago(Index), Servicio(Index))
    End Sub

    Private Sub CalcularToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem1.Click
        Form2.Show()
        Me.Hide()

        If (RadioButtonPrivada.Checked And CheckBoxEncama.Checked) Then
            SubTotal = PrivadaEncama * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonPrivada.Checked And CheckBoxOperacion.Checked) Then
            SubTotal = PrivadaOpera * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonPrivada.Checked And CheckBoxMaternidad.Checked) Then
            SubTotal = PrivadaMater * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonSemiPriv.Checked And CheckBoxEncama.Checked) Then
            SubTotal = SemiPrivEncama * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonSemiPriv.Checked And CheckBoxOperacion.Checked) Then
            SubTotal = SemiPrivOpera * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonSemiPriv.Checked And CheckBoxMaternidad.Checked) Then
            SubTotal = SemiPrivMater * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonNoPriv.Checked And CheckBoxEncama.Checked) Then
            SubTotal = NoPrivEncama * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonNoPriv.Checked And CheckBoxOperacion.Checked) Then
            SubTotal = NoPrivOpera * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (RadioButtonNoPriv.Checked And CheckBoxMaternidad.Checked) Then
            SubTotal = NoPrivMater * TextBoxDias.Text + TextBoxHonorarios.Text
        End If

        If (ComboBoxPago.Text = "Efectivo") Or (ComboBoxPago.Text = "Cheque") Then
            Total = SubTotal - (DescuentoCheEfe * SubTotal)
        ElseIf (ComboBoxPago.Text = "Tarjeta Débito") Then
            Total = SubTotal - (DescuentoDebito * SubTotal)
        ElseIf (ComboBoxPago.Text = "Tarjeta Crédito") Then
            Total = SubTotal + (RecargoCredito * SubTotal)
        End If

        Form2.ListBox1.Items.Add(Nombre(Index))
        Form2.ListBox2.Items.Add(Honorarios(Index))
        Form2.ListBox3.Items.Add(DiasHops(Index))
        Form2.ListBox11.Items.Add(SubTotal)
        Form2.ListBox12.Items.Add(Total)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

End Class
