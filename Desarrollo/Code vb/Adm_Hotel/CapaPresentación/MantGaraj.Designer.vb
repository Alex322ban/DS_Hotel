<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantGaraj
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
        Me.dgv_garaj = New System.Windows.Forms.DataGridView()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_liberar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_slot = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_garaj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_garaj
        '
        Me.dgv_garaj.AllowUserToAddRows = False
        Me.dgv_garaj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_garaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_garaj.Location = New System.Drawing.Point(188, 15)
        Me.dgv_garaj.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_garaj.Name = "dgv_garaj"
        Me.dgv_garaj.ReadOnly = True
        Me.dgv_garaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_garaj.Size = New System.Drawing.Size(591, 284)
        Me.dgv_garaj.TabIndex = 2
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(8, 87)
        Me.txt_placa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(132, 22)
        Me.txt_placa.TabIndex = 4
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(8, 135)
        Me.txt_dni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(132, 22)
        Me.txt_dni.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Slot"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.btn_liberar)
        Me.GroupBox1.Controls.Add(Me.btn_actualizar)
        Me.GroupBox1.Controls.Add(Me.btn_Añadir)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_slot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_placa)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(168, 292)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Garaje"
        '
        'btn_liberar
        '
        Me.btn_liberar.Location = New System.Drawing.Point(8, 241)
        Me.btn_liberar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_liberar.Name = "btn_liberar"
        Me.btn_liberar.Size = New System.Drawing.Size(133, 28)
        Me.btn_liberar.TabIndex = 11
        Me.btn_liberar.Text = "Liberar"
        Me.btn_liberar.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(8, 204)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(133, 28)
        Me.btn_actualizar.TabIndex = 10
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Location = New System.Drawing.Point(8, 169)
        Me.btn_Añadir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(133, 28)
        Me.btn_Añadir.TabIndex = 9
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Placa"
        '
        'CB_slot
        '
        Me.CB_slot.FormattingEnabled = True
        Me.CB_slot.Location = New System.Drawing.Point(8, 38)
        Me.CB_slot.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_slot.Name = "CB_slot"
        Me.CB_slot.Size = New System.Drawing.Size(60, 24)
        Me.CB_slot.TabIndex = 3
        Me.CB_slot.ValueMember = "SLOT"
        '
        'MantGaraj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_garaj)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MantGaraj"
        CType(Me.dgv_garaj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_garaj As DataGridView
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_liberar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_Añadir As Button
    Private WithEvents CB_slot As ComboBox
End Class
