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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvRestaurants = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtFoodType = New System.Windows.Forms.TextBox()
        Me.txtBusiness = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtDriveThru = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriveThruDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestaurantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantsDataSet = New AVB_Final_Project.RestaurantsDataSet()
        Me.RestaurantsTableAdapter = New AVB_Final_Project.RestaurantsDataSetTableAdapters.RestaurantsTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvRestaurants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(885, 127)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RestaurantsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1056, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'RestaurantsToolStripMenuItem
        '
        Me.RestaurantsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.RestaurantsToolStripMenuItem.Name = "RestaurantsToolStripMenuItem"
        Me.RestaurantsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.RestaurantsToolStripMenuItem.Text = "&Modify"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'dgvRestaurants
        '
        Me.dgvRestaurants.AutoGenerateColumns = False
        Me.dgvRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestaurants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FoodTypeDataGridViewTextBoxColumn, Me.BusinessDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DriveThruDataGridViewTextBoxColumn})
        Me.dgvRestaurants.DataSource = Me.RestaurantsBindingSource
        Me.dgvRestaurants.Location = New System.Drawing.Point(12, 206)
        Me.dgvRestaurants.Name = "dgvRestaurants"
        Me.dgvRestaurants.Size = New System.Drawing.Size(1012, 275)
        Me.dgvRestaurants.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(929, 487)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(885, 94)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(0, 530)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(1056, 22)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "StatusStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Food Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Business"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Hours"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(588, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Drive Thru"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(414, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Phone"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(138, 92)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(179, 20)
        Me.txtId.TabIndex = 15
        '
        'txtFoodType
        '
        Me.txtFoodType.Location = New System.Drawing.Point(138, 124)
        Me.txtFoodType.Name = "txtFoodType"
        Me.txtFoodType.Size = New System.Drawing.Size(179, 20)
        Me.txtFoodType.TabIndex = 16
        '
        'txtBusiness
        '
        Me.txtBusiness.Location = New System.Drawing.Point(138, 160)
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Size = New System.Drawing.Size(179, 20)
        Me.txtBusiness.TabIndex = 17
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(459, 91)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(364, 20)
        Me.txtAddress.TabIndex = 18
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(459, 124)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 19
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(459, 160)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 20
        '
        'txtDriveThru
        '
        Me.txtDriveThru.Location = New System.Drawing.Point(651, 124)
        Me.txtDriveThru.Name = "txtDriveThru"
        Me.txtDriveThru.Size = New System.Drawing.Size(100, 20)
        Me.txtDriveThru.TabIndex = 21
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(885, 163)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'RestaurantsTableAdapter
        '
        Me.RestaurantsTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(367, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "All Restaurants Available"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(444, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Type in the informations in the selected fields and then you may chose to Add, Ed" &
    "it or Delete."
        '
        'AllRestaurantsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 552)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtDriveThru)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtBusiness)
        Me.Controls.Add(Me.txtFoodType)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvRestaurants)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AllRestaurantsForm"
        Me.Text = "All Restaurants"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvRestaurants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvRestaurants As DataGridView
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblStatus As StatusStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtFoodType As TextBox
    Friend WithEvents txtBusiness As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtDriveThru As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
