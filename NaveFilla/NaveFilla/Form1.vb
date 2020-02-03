Imports System.Threading

Public Class Form1

    Dim PCI As PantallaCargaInicio

    'Busqueda páginas
    Dim TextoBusqueda As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub



    Private Sub BarraBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles BarraBusqueda.KeyDown

        If BarraBusqueda.Text <> "" And e.KeyCode = Keys.Enter Then

            TextoBusqueda = BarraBusqueda.Text

            BuscarPagina(TextoBusqueda)

        End If

    End Sub

    Public Sub BuscarPagina(Pagina As String)

        Browser.Navigate(Pagina)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
        Application.ExitThread()
    End Sub

End Class
