<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbOptions = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewAllRecipes = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.radBurgers = New System.Windows.Forms.RadioButton()
        Me.radTacos = New System.Windows.Forms.RadioButton()
        Me.radPizza = New System.Windows.Forms.RadioButton()
        Me.radChinese = New System.Windows.Forms.RadioButton()
        Me.radPasta = New System.Windows.Forms.RadioButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lstRestaurants = New System.Windows.Forms.ListBox()
        Me.radSubs = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.CloseToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.HelpToolStripMenuItem.Text = "help"
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
        Me.CloseToolStripMenuItem1.Text = "close"
        '
        'lbOptions
        '
        Me.lbOptions.AutoSize = True
        Me.lbOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOptions.Location = New System.Drawing.Point(32, 87)
        Me.lbOptions.Name = "lbOptions"
        Me.lbOptions.Size = New System.Drawing.Size(153, 25)
        Me.lbOptions.TabIndex = 2
        Me.lbOptions.Text = "Food Options"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(62, 274)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnViewAllRecipes
        '
        Me.btnViewAllRecipes.Location = New System.Drawing.Point(554, 306)
        Me.btnViewAllRecipes.Name = "btnViewAllRecipes"
        Me.btnViewAllRecipes.Size = New System.Drawing.Size(101, 23)
        Me.btnViewAllRecipes.TabIndex = 9
        Me.btnViewAllRecipes.Text = "View All Recipes"
        Me.btnViewAllRecipes.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(189, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'radBurgers
        '
        Me.radBurgers.AutoSize = True
        Me.radBurgers.Location = New System.Drawing.Point(62, 125)
        Me.radBurgers.Name = "radBurgers"
        Me.radBurgers.Size = New System.Drawing.Size(61, 17)
        Me.radBurgers.TabIndex = 11
        Me.radBurgers.TabStop = True
        Me.radBurgers.Text = "Burgers"
        Me.radBurgers.UseVisualStyleBackColor = True
        '
        'radTacos
        '
        Me.radTacos.AutoSize = True
        Me.radTacos.Location = New System.Drawing.Point(62, 148)
        Me.radTacos.Name = "radTacos"
        Me.radTacos.Size = New System.Drawing.Size(55, 17)
        Me.radTacos.TabIndex = 12
        Me.radTacos.TabStop = True
        Me.radTacos.Text = "Tacos"
        Me.radTacos.UseVisualStyleBackColor = True
        '
        'radPizza
        '
        Me.radPizza.AutoSize = True
        Me.radPizza.Location = New System.Drawing.Point(62, 171)
        Me.radPizza.Name = "radPizza"
        Me.radPizza.Size = New System.Drawing.Size(50, 17)
        Me.radPizza.TabIndex = 13
        Me.radPizza.TabStop = True
        Me.radPizza.Text = "Pizza"
        Me.radPizza.UseVisualStyleBackColor = True
        '
        'radChinese
        '
        Me.radChinese.AutoSize = True
        Me.radChinese.Location = New System.Drawing.Point(62, 194)
        Me.radChinese.Name = "radChinese"
        Me.radChinese.Size = New System.Drawing.Size(63, 17)
        Me.radChinese.TabIndex = 14
        Me.radChinese.TabStop = True
        Me.radChinese.Text = "Chinese"
        Me.radChinese.UseVisualStyleBackColor = True
        '
        'radPasta
        '
        Me.radPasta.AutoSize = True
        Me.radPasta.Location = New System.Drawing.Point(62, 217)
        Me.radPasta.Name = "radPasta"
        Me.radPasta.Size = New System.Drawing.Size(52, 17)
        Me.radPasta.TabIndex = 15
        Me.radPasta.TabStop = True
        Me.radPasta.Text = "Pasta"
        Me.radPasta.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(551, 40)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 13)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "(Date)"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(668, 306)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lstRestaurants
        '
        Me.lstRestaurants.FormattingEnabled = True
        Me.lstRestaurants.Location = New System.Drawing.Point(208, 98)
        Me.lstRestaurants.Name = "lstRestaurants"
        Me.lstRestaurants.Size = New System.Drawing.Size(555, 199)
        Me.lstRestaurants.TabIndex = 23
        '
        'radSubs
        '
        Me.radSubs.AutoSize = True
        Me.radSubs.Location = New System.Drawing.Point(62, 241)
        Me.radSubs.Name = "radSubs"
        Me.radSubs.Size = New System.Drawing.Size(104, 17)
        Me.radSubs.TabIndex = 24
        Me.radSubs.TabStop = True
        Me.radSubs.Text = "Sandwich/ Subs"
        Me.radSubs.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 408)
        Me.Controls.Add(Me.radSubs)
        Me.Controls.Add(Me.lstRestaurants)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.radPasta)
        Me.Controls.Add(Me.radChinese)
        Me.Controls.Add(Me.radPizza)
        Me.Controls.Add(Me.radTacos)
        Me.Controls.Add(Me.radBurgers)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnViewAllRecipes)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lbOptions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForn"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbOptions As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewAllRecipes As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents radPasta As RadioButton
    Friend WithEvents radChinese As RadioButton
    Friend WithEvents radPizza As RadioButton
    Friend WithEvents radTacos As RadioButton
    Friend WithEvents radBurgers As RadioButton
    Friend WithEvents lblDate As Label
    Friend WithEvents lstRestaurants As ListBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents radSubs As RadioButton
End Class
