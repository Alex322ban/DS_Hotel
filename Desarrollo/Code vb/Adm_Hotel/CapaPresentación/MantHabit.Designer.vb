<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantHabit
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_liberar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ESTADOIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_HOTELDataSet2 = New CapaPresentación.DB_HOTELDataSet2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_habitaN = New System.Windows.Forms.TextBox()
        Me.dgv_habit = New System.Windows.Forms.DataGridView()
        Me.ESTADOITableAdapter = New CapaPresentación.DB_HOTELDataSet2TableAdapters.ESTADOITableAdapter()
        Me.CB_Slot = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ESTADOIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_HOTELDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_habit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.CB_Slot)
        Me.GroupBox1.Controls.Add(Me.btn_liberar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_habitaN)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 239)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habitaciones"
        '
        'btn_liberar
        '
        Me.btn_liberar.Location = New System.Drawing.Point(6, 196)
        Me.btn_liberar.Name = "btn_liberar"
        Me.btn_liberar.Size = New System.Drawing.Size(100, 23)
        Me.btn_liberar.TabIndex = 11
        Me.btn_liberar.Text = "Liberar"
        Me.btn_liberar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Habitación"
        '
        'ESTADOIBindingSource
        '
        Me.ESTADOIBindingSource.DataMember = "ESTADOI"
        Me.ESTADOIBindingSource.DataSource = Me.DB_HOTELDataSet2
        '
        'DB_HOTELDataSet2
        '
        Me.DB_HOTELDataSet2.DataSetName = "DB_HOTELDataSet2"
        Me.DB_HOTELDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Estado"
        '
        'txt_habitaN
        '
        Me.txt_habitaN.Location = New System.Drawing.Point(6, 76)
        Me.txt_habitaN.Name = "txt_habitaN"
        Me.txt_habitaN.ReadOnly = True
        Me.txt_habitaN.Size = New System.Drawing.Size(100, 20)
        Me.txt_habitaN.TabIndex = 4
        '
        'dgv_habit
        '
        Me.dgv_habit.AllowUserToAddRows = False
        Me.dgv_habit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_habit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_habit.Location = New System.Drawing.Point(133, 11)
        Me.dgv_habit.Name = "dgv_habit"
        Me.dgv_habit.ReadOnly = True
        Me.dgv_habit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_habit.Size = New System.Drawing.Size(443, 231)
        Me.dgv_habit.TabIndex = 8
        '
        'ESTADOITableAdapter
        '
        Me.ESTADOITableAdapter.ClearBeforeFill = True
        '
        'CB_Slot
        '
        Me.CB_Slot.Location = New System.Drawing.Point(6, 36)
        Me.CB_Slot.Name = "CB_Slot"
        Me.CB_Slot.ReadOnly = True
        Me.CB_Slot.Size = New System.Drawing.Size(100, 20)
        Me.CB_Slot.TabIndex = 12
        '
        'MantHabit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 254)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_habit)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MantHabit"
        Me.Text = "MantHabit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ESTADOIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_HOTELDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_habit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_liberar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_habitaN As TextBox
    Friend WithEvents dgv_habit As DataGridView
    Friend WithEvents DB_HOTELDataSet2 As DB_HOTELDataSet2
    Friend WithEvents ESTADOIBindingSource As BindingSource
    Friend WithEvents ESTADOITableAdapter As DB_HOTELDataSet2TableAdapters.ESTADOITableAdapter
    Friend WithEvents CB_Slot As TextBox
End Class
