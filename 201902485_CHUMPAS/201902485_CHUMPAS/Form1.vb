Public Class Form1

    Private Sub TextBoxCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ButtonCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalcular.Click
        If (RadioButtonAlgodon.Checked = False And RadioButtonLona.Checked = False And RadioButtonSeda.Checked = False) Then
            MsgBox("No se ha seleccionado tamano")
        End If

        If (RadioButtonSmall.Checked = False And RadioButtonMedium.Checked = False And RadioButtonLarge.Checked = False) Then
            MsgBox("No se ha seleccionado tamano")
        End If

        If TextBoxCantidad.Text = "" Then
            MsgBox("Ingrese una cantidad")
        End If

        If (RadioButtonSmall.Checked And RadioButtonAlgodon.Checked) Then
            TextBoxUPCosto.Text = PMOSmall + PYAlgodon * YardaSmall
        ElseIf (RadioButtonSmall.Checked And RadioButtonSeda.Checked) Then
            TextBoxUPCosto.Text = PMOSmall + PYSeda * YardaSmall
        ElseIf (RadioButtonSmall.Checked And RadioButtonLona.Checked) Then
            TextBoxUPCosto.Text = PMOSmall + PYLona * YardaSmall
        ElseIf (RadioButtonMedium.Checked And RadioButtonAlgodon.Checked) Then
            TextBoxUPCosto.Text = PMOMedium + PYAlgodon * YardaMedium
        ElseIf (RadioButtonMedium.Checked And RadioButtonSeda.Checked) Then
            TextBoxUPCosto.Text = PMOMedium + PYSeda * YardaMedium
        ElseIf (RadioButtonMedium.Checked And RadioButtonLona.Checked) Then
            TextBoxUPCosto.Text = PMOMedium + PYLona * YardaMedium
        ElseIf (RadioButtonLarge.Checked And RadioButtonAlgodon.Checked) Then
            TextBoxUPCosto.Text = PMOLarge + PYAlgodon * YardaLarge
        ElseIf (RadioButtonLarge.Checked And RadioButtonSeda.Checked) Then
            TextBoxUPCosto.Text = PMOLarge + PYSeda * YardaLarge
        ElseIf (RadioButtonLarge.Checked And RadioButtonLona.Checked) Then
            TextBoxUPCosto.Text = PMOLarge + PYLona * YardaLarge
        End If

        TextBoxUPVenta.Text = TextBoxUPCosto.Text + (TextBoxUPCosto.Text * Porcentaje)
        TextBoxTPCosto.Text = (TextBoxUPCosto.Text * TextBoxCantidad.Text)
        TextBoxTPVenta.Text = (TextBoxUPVenta.Text * TextBoxCantidad.Text)

    End Sub

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If

    End Sub

    Private Sub ButtonLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLimpiar.Click
        TextBoxCantidad.Clear()
        TextBoxNombre.Clear()
        TextBoxTPCosto.Clear()
        TextBoxTPVenta.Clear()
        TextBoxUPCosto.Clear()
        TextBoxUPVenta.Clear()
    End Sub
End Class
