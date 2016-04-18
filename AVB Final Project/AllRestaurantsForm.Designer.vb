<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllRestaurantsForm
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
        Me.btnModifyList = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriveThruDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestaurantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantsDataSet = New AVB_Final_Project.RestaurantsDataSet()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.RestaurantsTableAdapter = New AVB_Final_Project.RestaurantsDataSetTableAdapters.RestaurantsTableAdapter()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModifyList
        '
        Me.btnModifyList.Location = New System.Drawing.Point(640, 303)
        Me.btnModifyList.Name = "btnModifyList"
        Me.btnModifyList.Size = New System.Drawing.Size(75, 23)
        Me.btnModifyList.TabIndex = 1
        Me.btnModifyList.Text = "Modify List"
        Me.btnModifyList.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RestaurantsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1134, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.CloseToolStripMenuItem.Text = "close"
        '
        'RestaurantsToolStripMenuItem
        '
        Me.RestaurantsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.RestaurantsToolStripMenuItem.Name = "RestaurantsToolStripMenuItem"
        Me.RestaurantsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.RestaurantsToolStripMenuItem.Text = "Modify"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FoodTypeDataGridViewTextBoxColumn, Me.BusinessDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DriveThruDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RestaurantsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(36, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1017, 252)
        Me.DataGridView1.TabIndex = 4
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'FoodTypeDataGridViewTextBoxColumn
        '
        Me.FoodTypeDataGridViewTextBoxColumn.DataPropertyName = "FoodType"
        Me.FoodTypeDataGridViewTextBoxColumn.HeaderText = "FoodType"
        Me.FoodTypeDataGridViewTextBoxColumn.Name = "FoodTypeDataGridViewTextBoxColumn"
        '
        'BusinessDataGridViewTextBoxColumn
        '
        Me.BusinessDataGridViewTextBoxColumn.DataPropertyName = "Business"
        Me.BusinessDataGridViewTextBoxColumn.HeaderText = "Business"
        Me.BusinessDataGridViewTextBoxColumn.Name = "BusinessDataGridViewTextBoxColumn"
        Me.BusinessDataGridViewTextBoxColumn.Width = 200
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 300
        '
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DriveThruDataGridViewTextBoxColumn
        '
        Me.DriveThruDataGridViewTextBoxColumn.DataPropertyName = "DriveThru"
        Me.DriveThruDataGridViewTextBoxColumn.HeaderText = "DriveThru"
        Me.DriveThruDataGridViewTextBoxColumn.Name = "DriveThruDataGridViewTextBoxColumn"
        '
        'RestaurantsBindingSource
        '
        Me.RestaurantsBindingSource.DataMember = "Restaurants"
        Me.RestaurantsBindingSource.DataSource = Me.RestaurantsDataSet
        '
        'RestaurantsDataSet
        '
        Me.RestaurantsDataSet.DataSetName = "RestaurantsDataSet"
        Me.RestaurantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(757, 303)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'RestaurantsTableAdapter
        '
        Me.RestaurantsTableAdapter.ClearBeforeFill = True
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'AllRestaurantsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 338)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnModifyList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AllRestaurantsForm"
        Me.Text = "All Restaurants"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModifyList As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents RestaurantsDataSet As RestaurantsDataSet
    Friend WithEvents RestaurantsBindingSource As BindingSource
    Friend WithEvents RestaurantsTableAdapter As RestaurantsDataSetTableAdapters.RestaurantsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DriveThruDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestaurantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
