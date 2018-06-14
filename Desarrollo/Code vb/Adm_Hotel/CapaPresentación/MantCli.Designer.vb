<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantCli
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
        Me.dgv_cli = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_deltcli = New System.Windows.Forms.Button()
        Me.BTN_updcli = New System.Windows.Forms.Button()
        Me.BTN_addcli = New System.Windows.Forms.Button()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.txt_nomb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_pago = New System.Windows.Forms.Button()
        Me.dgv_habit = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_deasig = New System.Windows.Forms.Button()
        Me.BTN_asig = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_habit = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_habit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_cli
        '
        Me.dgv_cli.AllowUserToAddRows = False
        Me.dgv_cli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cli.Location = New System.Drawing.Point(173, 11)
        Me.dgv_cli.Name = "dgv_cli"
        Me.dgv_cli.ReadOnly = True
        Me.dgv_cli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cli.Size = New System.Drawing.Size(364, 213)
        Me.dgv_cli.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BTN_deltcli)
        Me.GroupBox1.Controls.Add(Me.BTN_updcli)
        Me.GroupBox1.Controls.Add(Me.BTN_addcli)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Controls.Add(Me.txt_ape)
        Me.GroupBox1.Controls.Add(Me.txt_nomb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 251)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_deltcli
        '
        Me.BTN_deltcli.Location = New System.Drawing.Point(7, 221)
        Me.BTN_deltcli.Name = "BTN_deltcli"
        Me.BTN_deltcli.Size = New System.Drawing.Size(82, 23)
        Me.BTN_deltcli.TabIndex = 12
        Me.BTN_deltcli.Text = "Eliminar"
        Me.BTN_deltcli.UseVisualStyleBackColor = True
        '
        'BTN_updcli
        '
        Me.BTN_updcli.Location = New System.Drawing.Point(7, 195)
        Me.BTN_updcli.Name = "BTN_updcli"
        Me.BTN_updcli.Size = New System.Drawing.Size(82, 23)
        Me.BTN_updcli.TabIndex = 11
        Me.BTN_updcli.Text = "Actualizar"
        Me.BTN_updcli.UseVisualStyleBackColor = True
        '
        'BTN_addcli
        '
        Me.BTN_addcli.Location = New System.Drawing.Point(7, 168)
        Me.BTN_addcli.Name = "BTN_addcli"
        Me.BTN_addcli.Size = New System.Drawing.Size(82, 23)
        Me.BTN_addcli.TabIndex = 10
        Me.BTN_addcli.Text = "Añadir"
        Me.BTN_addcli.UseVisualStyleBackColor = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(6, 38)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(143, 20)
        Me.txt_dni.TabIndex = 9
        '
        'txt_ape
        '
        Me.txt_ape.Location = New System.Drawing.Point(6, 115)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(143, 20)
        Me.txt_ape.TabIndex = 8
        '
        'txt_nomb
        '
        Me.txt_nomb.Location = New System.Drawing.Point(6, 77)
        Me.txt_nomb.Name = "txt_nomb"
        Me.txt_nomb.Size = New System.Drawing.Size(143, 20)
        Me.txt_nomb.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DNI"
        '
        'btn_pago
        '
        Me.btn_pago.Location = New System.Drawing.Point(387, 230)
        Me.btn_pago.Name = "btn_pago"
        Me.btn_pago.Size = New System.Drawing.Size(150, 23)
        Me.btn_pago.TabIndex = 4
        Me.btn_pago.Text = "Realizar Pago"
        Me.btn_pago.UseVisualStyleBackColor = True
        '
        'dgv_habit
        '
        Me.dgv_habit.AllowUserToAddRows = False
        Me.dgv_habit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_habit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_habit.Location = New System.Drawing.Point(173, 268)
        Me.dgv_habit.Name = "dgv_habit"
        Me.dgv_habit.ReadOnly = True
        Me.dgv_habit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_habit.Size = New System.Drawing.Size(364, 119)
        Me.dgv_habit.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.BTN_deasig)
        Me.GroupBox2.Controls.Add(Me.BTN_asig)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_habit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 119)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Habitación"
        '
        'BTN_deasig
        '
        Me.BTN_deasig.Location = New System.Drawing.Point(83, 96)
        Me.BTN_deasig.Name = "BTN_deasig"
        Me.BTN_deasig.Size = New System.Drawing.Size(70, 23)
        Me.BTN_deasig.TabIndex = 15
        Me.BTN_deasig.Text = "Desasignar"
        Me.BTN_deasig.UseVisualStyleBackColor = True
        '
        'BTN_asig
        '
        Me.BTN_asig.Location = New System.Drawing.Point(2, 96)
        Me.BTN_asig.Name = "BTN_asig"
        Me.BTN_asig.Size = New System.Drawing.Size(73, 23)
        Me.BTN_asig.TabIndex = 14
        Me.BTN_asig.Text = "Asignar"
        Me.BTN_asig.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "N° Habitación"
        '
        'txt_habit
        '
        Me.txt_habit.Location = New System.Drawing.Point(6, 40)
        Me.txt_habit.Name = "txt_habit"
        Me.txt_habit.Size = New System.Drawing.Size(143, 20)
        Me.txt_habit.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Disponible"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MantCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 398)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_habit)
        Me.Controls.Add(Me.btn_pago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_cli)
        Me.Name = "MantCli"
        Me.TransparencyKey = System.Drawing.Color.Indigo
        CType(Me.dgv_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_habit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_cli As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_deltcli As Button
    Friend WithEvents BTN_updcli As Button
    Friend WithEvents BTN_addcli As Button
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txt_ape As TextBox
    Friend WithEvents txt_nomb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_pago As Button
    Friend WithEvents dgv_habit As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_deasig As Button
    Friend WithEvents BTN_asig As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_habit As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
