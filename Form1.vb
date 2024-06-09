Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtvMostrarDatos.ColumnCount = 10
        dtvMostrarDatos.Rows.Add(4)
        For i = 0 To 9
            dtvMostrarDatos.Columns(i).Width = 45
        Next
        dtvIngresarDatos.ColumnCount = 10
        dtvIngresarDatos.Rows.Add(4)
        For i = 0 To 9
            dtvIngresarDatos.Columns(i).Width = 45
        Next
        dtvMostrarVector.ColumnCount = 10
        dtvMostrarVector.Rows.Add(4)
        For i = 0 To 9
            dtvMostrarVector.Columns(i).Width = 45

        Next
    End Sub




    Private Sub cmdEjecutar_Click_1(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim VectorIngresar(0 To 9) As Integer
        Dim vectorInvertido(0 To 9) As Integer
        Dim Contador As Integer
        Dim Mayor As Integer
        Dim NumeroN As Integer
        Dim Posicion As Integer
        Dim RestoPar As Integer
        Dim RestoN As Integer
        Dim x As Integer
        Dim c As Integer
        Mayor = 0
        For c = 0 To 9

            VectorIngresar(c) = dtvIngresarDatos.Item(c, 0).Value

        Next
        NumeroN = txtNumeroN.Text
        For c = 0 To 9
            dtvMostrarDatos.Item(c, 0).Value = VectorIngresar(c)
            RestoPar = VectorIngresar(c) Mod 2
            If RestoPar = 0 Then
                lstPares.Items.Add(VectorIngresar(c))
            Else
                lstImpares.Items.Add(VectorIngresar(c))
            End If

            RestoN = VectorIngresar(c) Mod NumeroN
            If RestoN = 0 Then
                lstMultiplos.Items.Add(VectorIngresar(c))
            End If
            If VectorIngresar(c) > Mayor Then
                Mayor = VectorIngresar(c)
                Posicion = c + 1

            End If
            txtMayor.Text = Mayor
            txtUbicacionMayor.Text = Posicion


        Next

        For c = 0 To 9

            vectorInvertido(c) = VectorIngresar(c)
        Next
        For c = 0 To 9
            Dim d As Integer
            Contador = 9 - c
            dtvMostrarVector.Item(c, 0).Value = vectorInvertido(Contador)
        Next
    End Sub


End Class
