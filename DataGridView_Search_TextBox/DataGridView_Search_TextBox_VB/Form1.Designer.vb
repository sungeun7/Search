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
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(54, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 20)
        Me.txtName.TabIndex = 4
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(6, 41)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(460, 180)
        Me.dataGridView1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 233)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView

End Class
