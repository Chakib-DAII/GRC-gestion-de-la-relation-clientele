<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auth
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Login = New System.Windows.Forms.Label()
        Me.Logint = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Password = New System.Windows.Forms.Label()
        Me.Mpasst = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.connect = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPassUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GRCDataSet = New GRC.GRCDataSet()
        Me.CompteTableAdapter = New GRC.GRCDataSetTableAdapters.CompteTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(36, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(207, 129)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Login)
        Me.FlowLayoutPanel1.Controls.Add(Me.Logint)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 26)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.Location = New System.Drawing.Point(3, 0)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(78, 13)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Login :             "
        '
        'Logint
        '
        Me.Logint.Location = New System.Drawing.Point(87, 3)
        Me.Logint.Name = "Logint"
        Me.Logint.Size = New System.Drawing.Size(110, 20)
        Me.Logint.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Password)
        Me.FlowLayoutPanel2.Controls.Add(Me.Mpasst)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 35)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 26)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(3, 0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(77, 13)
        Me.Password.TabIndex = 1
        Me.Password.Text = "Mot de passe :"
        '
        'Mpasst
        '
        Me.Mpasst.Location = New System.Drawing.Point(86, 3)
        Me.Mpasst.Name = "Mpasst"
        Me.Mpasst.Size = New System.Drawing.Size(111, 20)
        Me.Mpasst.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.connect)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 99)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(197, 27)
        Me.FlowLayoutPanel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "              "
        '
        'connect
        '
        Me.connect.Location = New System.Drawing.Point(58, 3)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(90, 23)
        Me.connect.TabIndex = 2
        Me.connect.Text = "Connecter"
        Me.connect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.connect.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUserDataGridViewTextBoxColumn, Me.LoginUserDataGridViewTextBoxColumn, Me.MPassUserDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CompteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(200, 39)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'IdUserDataGridViewTextBoxColumn
        '
        Me.IdUserDataGridViewTextBoxColumn.DataPropertyName = "IdUser"
        Me.IdUserDataGridViewTextBoxColumn.HeaderText = "IdUser"
        Me.IdUserDataGridViewTextBoxColumn.Name = "IdUserDataGridViewTextBoxColumn"
        Me.IdUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginUserDataGridViewTextBoxColumn
        '
        Me.LoginUserDataGridViewTextBoxColumn.DataPropertyName = "LoginUser"
        Me.LoginUserDataGridViewTextBoxColumn.HeaderText = "LoginUser"
        Me.LoginUserDataGridViewTextBoxColumn.Name = "LoginUserDataGridViewTextBoxColumn"
        Me.LoginUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MPassUserDataGridViewTextBoxColumn
        '
        Me.MPassUserDataGridViewTextBoxColumn.DataPropertyName = "MPassUser"
        Me.MPassUserDataGridViewTextBoxColumn.HeaderText = "MPassUser"
        Me.MPassUserDataGridViewTextBoxColumn.Name = "MPassUserDataGridViewTextBoxColumn"
        Me.MPassUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompteBindingSource
        '
        Me.CompteBindingSource.DataMember = "Compte"
        Me.CompteBindingSource.DataSource = Me.GRCDataSet
        '
        'GRCDataSet
        '
        Me.GRCDataSet.DataSetName = "GRCDataSet"
        Me.GRCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompteTableAdapter
        '
        Me.CompteTableAdapter.ClearBeforeFill = True
        '
        'auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "auth"
        Me.Text = "Autnentification"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents connect As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Login As System.Windows.Forms.Label
    Friend WithEvents Logint As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents Mpasst As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GRCDataSet As GRC.GRCDataSet
    Friend WithEvents CompteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompteTableAdapter As GRC.GRCDataSetTableAdapters.CompteTableAdapter
    Friend WithEvents IdUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MPassUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
