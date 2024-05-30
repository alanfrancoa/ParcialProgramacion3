Public Class Form1
#Region "Dependencias"
    Private dtPinturas As DataTable 'Creamos nuestro DataTable'
#End Region

#Region "Inicializar"
    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Color")
        dt.Columns.Add("Litros")

        Me.setDtPinturas(dt)
    End Sub

#End Region

#Region "Acciones"
    Private Sub setDtPinturas(dt As DataTable)
        dtPinturas = dt
        'relacionamos dataTable'
        DataGridView1.DataSource = dt
        'Cargamos datatable en DataGridView1'
    End Sub

    Private Sub recargarInformacion()
        Dim acumuladorRojo As Double = 0
        Dim acumuladorAzul As Double = 0
        Dim contadorAzul As Double = 0
        For Each renglon As DataRow In dtPinturas.Rows
            Dim color As String = renglon("Color")

            If color.IndexOf("rojo", StringComparison.OrdinalIgnoreCase) >= 0 Then
                Dim litrosRojos As Double = Convert.ToDouble(renglon("Litros"))
                acumuladorRojo += litrosRojos
            End If

            If color.IndexOf("azul", StringComparison.OrdinalIgnoreCase) >= 0 Then
                Dim litrosAzul As Double = Convert.ToDouble(renglon("Litros"))
                acumuladorAzul += litrosAzul
                contadorAzul += 1
            End If

            SumatoriaPinturaRojaResultado.Text = acumuladorRojo.ToString("#0.00")

            If contadorAzul > 0 Then
                Dim promedioAzul As Double = acumuladorAzul / contadorAzul
                PromedioPinturaAzulResultado.Text = promedioAzul.ToString("#0.00")
            Else
                PromedioPinturaAzulResultado.Text = "0.00"
            End If

        Next
    End Sub
#End Region

#Region "Eventos"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InicializarDataTable()
    End Sub

    Private Sub Limpiar()
        TextBoxCodigo.Clear()
        TextBoxColor.Clear()
        TextBoxLitros.Clear()
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            Dim codigo As Integer
            If Not Integer.TryParse(TextBoxCodigo.Text, codigo) Then
                MessageBox.Show("El codigo debe ser un numero entero.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxCodigo.Clear()
                TextBoxCodigo.Focus()
            End If

            If codigo <= 0 Then
                MessageBox.Show("El codigo debe ser un numero entero mayor a 0.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxCodigo.Clear()
                TextBoxCodigo.Focus()
            End If

            Dim existe As Boolean = False
            For Each renglon As DataRow In dtPinturas.Rows
                If renglon("Codigo") = codigo Then
                    MessageBox.Show("El codigo ingresado ya existe. Por favor, ingrese nuevamente.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBoxCodigo.Clear()
                    TextBoxCodigo.Focus()
                    existe = True
                    Return
                End If
            Next

            Dim litros As Double
            If Not Double.TryParse(TextBoxLitros.Text, litros) Then
                MessageBox.Show("Los litros ingresados deben ser un numero.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)

                TextBoxLitros.Clear()
                TextBoxLitros.Focus()
            End If
            If litros <= 0 Then
                MessageBox.Show("Los litros ingresados deben ser un numero mayor a 0.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxLitros.Clear()
                TextBoxLitros.Focus()
            End If

            Dim nombreColor As String = TextBoxColor.Text
            If nombreColor = "" Then
                MessageBox.Show("Ingrese un color.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If nombreColor <> "" AndAlso codigo > 0 AndAlso existe = False AndAlso litros > 0 Then

                dtPinturas.Rows.Add(codigo, nombreColor, litros)
                recargarInformacion()
                Limpiar()

            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un error. Por favor, ingrese nuevamente.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Limpiar()
        End Try

    End Sub

#End Region
End Class
