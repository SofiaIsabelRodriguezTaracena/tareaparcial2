Public Class Form1
    Private Sub ButtonCALCULAR_Click(sender As Object, e As EventArgs) Handles ButtonCALCULAR.Click

        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox(" Seleccione todos los campos por favor")
            Exit Sub
        End If

        If contador < 8 Then

            numeroventa(contador) = contador + 1
            tamaño(contador) = ComboBox1.SelectedItem
            material(contador) = ComboBox2.SelectedItem
            preciomanodeobra(contador) = preciomanodeobra
            preciocosto(contador) = preciocosto
            precioventa(contador) = precioventa

            Select Case tamaño(contador)
                Case "sofa"
                    Select Case material(contador)
                        Case "cuero"
                            preciomanodeobra(contador) = preciosofa
                            preciocosto(contador) = 8 * preciocuero * preciomanodeobra(contador)
                        Case "cuerina"
                            preciomanodeobra(contador) = preciosofa
                            preciocosto(contador) = 8 * preciocuerin * preciomanodeobra(contador)
                    End Select

                Case "individual"
                    Select Case material(contador)
                        Case "cuero"
                            preciomanodeobra(contador) = precioindividual
                            preciocosto(contador) = 3.5 * preciocuero * preciomanodeobra(contador)

                        Case "cuerina"
                            preciomanodeobra(contador) = precioindividual
                            preciocosto(contador) = 3.5 * preciocuerin * preciomanodeobra(contador)


                    End Select

                Case "doble"
                    Select Case material(contador)
                        Case "cuero"
                            preciomanodeobra(contador) = preciosoble
                            preciocosto(contador) = 6 * preciocuero * preciomanodeobra(contador)

                        Case "cuerina"
                            preciomanodeobra(contador) = preciosoble

                            preciocosto(contador) = 3.5 * preciocuerin * preciomanodeobra(contador)


                    End Select

                    precioventa(contador) = preciocosto(contador) * 1.65

            End Select
            ListBox1.Items.Add(numeroventa(contador))
            ListBox2.Items.Add(tamaño(contador))
            ListBox3.Items.Add(material(contador))

            ListBox4.Items.Add(preciomanodeobra(contador))

            ListBox5.Items.Add(preciocosto(contador))
            ListBox6.Items.Add(precioventa(contador))





        Else
            MsgBox("Se llegó al limite perdon :( ")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MsgBox("¿DESEA SALIR?", vbYesNo) = vbYes Then
            End
        End If
    End Sub
End Class
