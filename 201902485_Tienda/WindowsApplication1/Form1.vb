Public Class Form1
        Const precioArroz As Double = 2.0
        Const precioAzucar As Double = 2.5
        Const precioFrijol As Double = 1.75
        Const IVA As Double = 0.12

        Dim pagoSinIVA As Double = 0
        Dim valorIVA As Double = 0
        Dim pagoconIVA As Double = 0
        Dim descuento As Double = 0
        Dim pagototal As Double = 0


        Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
            pagoSinIVA = (Val(TextBox1.Text) * precioArroz) + (Val(TextBox2.Text) * (precioAzucar)) + (Val(TextBox3.Text) * (precioFrijol))
            valorIVA = pagoSinIVA * IVA
            pagoconIVA = pagoSinIVA + valorIVA
            descuento = pagoconIVA * 0.025
            pagototal = pagoconIVA - descuento

        LbR1.Text = pagoSinIVA
        LbR2.Text = valorIVA
        LbR3.Text = pagoconIVA
        LbR4.Text = descuento
        LbR5.Text = pagototal

    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        pagoSinIVA = 0
        valorIVA = 0
        pagoconIVA = 0
        descuento = 0
        pagototal = 0

        LbR1.Text = 0.0
        LbR2.Text = 0.0
        LbR3.Text = 0.0
        LbR4.Text = 0.0
        LbR5.Text = 0.0

        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        End
    End Sub
End Class
