<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SumatoriaPinturaRojaResultado = New System.Windows.Forms.Label()
        Me.PromedioPinturaAzulResultado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.TextBoxColor = New System.Windows.Forms.TextBox()
        Me.TextBoxLitros = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(321, 392)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonAdd)
        Me.GroupBox1.Controls.Add(Me.TextBoxLitros)
        Me.GroupBox1.Controls.Add(Me.TextBoxColor)
        Me.GroupBox1.Controls.Add(Me.TextBoxCodigo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(386, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 246)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de pinturas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad Litros Pintura Roja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(422, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Promedio Litros Pintura Azul"
        '
        'SumatoriaPinturaRojaResultado
        '
        Me.SumatoriaPinturaRojaResultado.AutoSize = True
        Me.SumatoriaPinturaRojaResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumatoriaPinturaRojaResultado.Location = New System.Drawing.Point(674, 345)
        Me.SumatoriaPinturaRojaResultado.Name = "SumatoriaPinturaRojaResultado"
        Me.SumatoriaPinturaRojaResultado.Size = New System.Drawing.Size(31, 16)
        Me.SumatoriaPinturaRojaResultado.TabIndex = 4
        Me.SumatoriaPinturaRojaResultado.Text = "0.00"
        '
        'PromedioPinturaAzulResultado
        '
        Me.PromedioPinturaAzulResultado.AutoSize = True
        Me.PromedioPinturaAzulResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromedioPinturaAzulResultado.Location = New System.Drawing.Point(674, 378)
        Me.PromedioPinturaAzulResultado.Name = "PromedioPinturaAzulResultado"
        Me.PromedioPinturaAzulResultado.Size = New System.Drawing.Size(31, 16)
        Me.PromedioPinturaAzulResultado.TabIndex = 5
        Me.PromedioPinturaAzulResultado.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pinturerias Chicho"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Codigo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Color:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Litros:"
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(24, 46)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(342, 20)
        Me.TextBoxCodigo.TabIndex = 3
        '
        'TextBoxColor
        '
        Me.TextBoxColor.Location = New System.Drawing.Point(24, 102)
        Me.TextBoxColor.Name = "TextBoxColor"
        Me.TextBoxColor.Size = New System.Drawing.Size(342, 20)
        Me.TextBoxColor.TabIndex = 4
        '
        'TextBoxLitros
        '
        Me.TextBoxLitros.Location = New System.Drawing.Point(24, 158)
        Me.TextBoxLitros.Name = "TextBoxLitros"
        Me.TextBoxLitros.Size = New System.Drawing.Size(342, 20)
        Me.TextBoxLitros.TabIndex = 5
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(126, 196)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(140, 30)
        Me.ButtonAdd.TabIndex = 6
        Me.ButtonAdd.Text = "Agregar"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PromedioPinturaAzulResultado)
        Me.Controls.Add(Me.SumatoriaPinturaRojaResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SumatoriaPinturaRojaResultado As Label
    Friend WithEvents PromedioPinturaAzulResultado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxLitros As TextBox
    Friend WithEvents TextBoxColor As TextBox
    Friend WithEvents TextBoxCodigo As TextBox
End Class
