<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmdEjecutar = New Button()
        dtvMostrarDatos = New DataGridView()
        dtvIngresarDatos = New DataGridView()
        Label1 = New Label()
        Label4 = New Label()
        dtvMostrarVector = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        txtNumeroN = New TextBox()
        txtMayor = New TextBox()
        txtUbicacionMayor = New TextBox()
        lstPares = New ListBox()
        Label9 = New Label()
        Label10 = New Label()
        lstImpares = New ListBox()
        lstMultiplos = New ListBox()
        CType(dtvMostrarDatos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvIngresarDatos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvMostrarVector, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.BackColor = Color.YellowGreen
        cmdEjecutar.Font = New Font("Rockwell", 16F, FontStyle.Bold)
        cmdEjecutar.Location = New Point(1071, 646)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(185, 52)
        cmdEjecutar.TabIndex = 0
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = False
        ' 
        ' dtvMostrarDatos
        ' 
        dtvMostrarDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dtvMostrarDatos.BackgroundColor = SystemColors.GradientInactiveCaption
        dtvMostrarDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvMostrarDatos.Location = New Point(728, 60)
        dtvMostrarDatos.Name = "dtvMostrarDatos"
        dtvMostrarDatos.RowHeadersWidth = 51
        dtvMostrarDatos.Size = New Size(528, 54)
        dtvMostrarDatos.TabIndex = 1
        ' 
        ' dtvIngresarDatos
        ' 
        dtvIngresarDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dtvIngresarDatos.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        dtvIngresarDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvIngresarDatos.Location = New Point(22, 60)
        dtvIngresarDatos.Name = "dtvIngresarDatos"
        dtvIngresarDatos.RowHeadersWidth = 51
        dtvIngresarDatos.Size = New Size(528, 54)
        dtvIngresarDatos.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label1.Location = New Point(20, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 25)
        Label1.TabIndex = 3
        Label1.Text = "Carga de Vector"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 316)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 6
        ' 
        ' dtvMostrarVector
        ' 
        dtvMostrarVector.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dtvMostrarVector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvMostrarVector.Location = New Point(20, 646)
        dtvMostrarVector.Name = "dtvMostrarVector"
        dtvMostrarVector.RowHeadersWidth = 51
        dtvMostrarVector.Size = New Size(528, 54)
        dtvMostrarVector.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label2.Location = New Point(904, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 25)
        Label2.TabIndex = 10
        Label2.Text = " Vector Cargado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label3.Location = New Point(22, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 25)
        Label3.TabIndex = 11
        Label3.Text = "Carga Número N"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label7.Location = New Point(12, 352)
        Label7.Name = "Label7"
        Label7.Size = New Size(298, 25)
        Label7.TabIndex = 12
        Label7.Text = "Número Mayor del Vector"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label5.Location = New Point(12, 475)
        Label5.Name = "Label5"
        Label5.Size = New Size(341, 25)
        Label5.TabIndex = 13
        Label5.Text = " Ubicación del Número Mayor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label6.Location = New Point(444, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(386, 25)
        Label6.TabIndex = 14
        Label6.Text = " Multiplos del N° ""N"" en el vector"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label8.Location = New Point(22, 593)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 25)
        Label8.TabIndex = 15
        Label8.Text = "Vector Invertido"
        ' 
        ' txtNumeroN
        ' 
        txtNumeroN.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtNumeroN.Font = New Font("Verdana", 15F, FontStyle.Bold)
        txtNumeroN.Location = New Point(22, 160)
        txtNumeroN.Name = "txtNumeroN"
        txtNumeroN.Size = New Size(89, 38)
        txtNumeroN.TabIndex = 16
        txtNumeroN.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMayor
        ' 
        txtMayor.BackColor = SystemColors.GradientActiveCaption
        txtMayor.Font = New Font("Verdana", 15F, FontStyle.Bold)
        txtMayor.Location = New Point(12, 407)
        txtMayor.Name = "txtMayor"
        txtMayor.Size = New Size(89, 38)
        txtMayor.TabIndex = 18
        txtMayor.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtUbicacionMayor
        ' 
        txtUbicacionMayor.BackColor = SystemColors.GradientActiveCaption
        txtUbicacionMayor.Font = New Font("Verdana", 15F, FontStyle.Bold)
        txtUbicacionMayor.Location = New Point(12, 531)
        txtUbicacionMayor.Name = "txtUbicacionMayor"
        txtUbicacionMayor.Size = New Size(89, 38)
        txtUbicacionMayor.TabIndex = 19
        txtUbicacionMayor.TextAlign = HorizontalAlignment.Center
        ' 
        ' lstPares
        ' 
        lstPares.BackColor = SystemColors.GradientActiveCaption
        lstPares.Cursor = Cursors.No
        lstPares.Font = New Font("Verdana", 12F, FontStyle.Bold)
        lstPares.FormattingEnabled = True
        lstPares.ItemHeight = 25
        lstPares.Location = New Point(456, 390)
        lstPares.Name = "lstPares"
        lstPares.Size = New Size(94, 179)
        lstPares.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label9.Location = New Point(456, 352)
        Label9.Name = "Label9"
        Label9.Size = New Size(183, 25)
        Label9.TabIndex = 24
        Label9.Text = "Números Pares"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label10.Location = New Point(763, 352)
        Label10.Name = "Label10"
        Label10.Size = New Size(214, 25)
        Label10.TabIndex = 25
        Label10.Text = "Números Impares"
        ' 
        ' lstImpares
        ' 
        lstImpares.BackColor = SystemColors.GradientActiveCaption
        lstImpares.Cursor = Cursors.No
        lstImpares.Font = New Font("Verdana", 12F, FontStyle.Bold)
        lstImpares.FormattingEnabled = True
        lstImpares.ItemHeight = 25
        lstImpares.Location = New Point(770, 390)
        lstImpares.Name = "lstImpares"
        lstImpares.Size = New Size(121, 179)
        lstImpares.TabIndex = 26
        ' 
        ' lstMultiplos
        ' 
        lstMultiplos.BackColor = SystemColors.GradientActiveCaption
        lstMultiplos.Cursor = Cursors.No
        lstMultiplos.Font = New Font("Verdana", 12F, FontStyle.Bold)
        lstMultiplos.FormattingEnabled = True
        lstMultiplos.ItemHeight = 25
        lstMultiplos.Location = New Point(456, 158)
        lstMultiplos.Name = "lstMultiplos"
        lstMultiplos.Size = New Size(114, 179)
        lstMultiplos.TabIndex = 27
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1268, 712)
        Controls.Add(lstMultiplos)
        Controls.Add(lstImpares)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(lstPares)
        Controls.Add(txtUbicacionMayor)
        Controls.Add(txtMayor)
        Controls.Add(txtNumeroN)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dtvMostrarVector)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(dtvIngresarDatos)
        Controls.Add(dtvMostrarDatos)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Vectores"
        CType(dtvMostrarDatos, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvIngresarDatos, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvMostrarVector, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents dtvMostrarDatos As DataGridView
    Friend WithEvents dtvIngresarDatos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtvMostrarVector As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumeroN As TextBox
    Friend WithEvents txtMayor As TextBox
    Friend WithEvents txtUbicacionMayor As TextBox
    Friend WithEvents lstPares As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lstImpares As ListBox
    Friend WithEvents lstMultiplos As ListBox

End Class
