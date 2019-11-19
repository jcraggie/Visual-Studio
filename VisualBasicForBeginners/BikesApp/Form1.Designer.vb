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
        Me.components = New System.ComponentModel.Container()
        Dim ModelIDLabel As System.Windows.Forms.Label
        Dim VersionIDLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BikesDBDataSet = New BikesApp.BikesDBDataSet()
        Me.BikesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BikesTableAdapter = New BikesApp.BikesDBDataSetTableAdapters.BikesTableAdapter()
        Me.TableAdapterManager = New BikesApp.BikesDBDataSetTableAdapters.TableAdapterManager()
        Me.ModelsTableAdapter = New BikesApp.BikesDBDataSetTableAdapters.ModelsTableAdapter()
        Me.VersionsTableAdapter = New BikesApp.BikesDBDataSetTableAdapters.VersionsTableAdapter()
        Me.BikesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BikesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BikeIDTextBox = New System.Windows.Forms.TextBox()
        Me.ModelIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ModelsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VersionIDComboBox = New System.Windows.Forms.ComboBox()
        Me.VersionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.GetAllToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GetAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GetClassicsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GetClassicsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GetCruisersToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GetCruisersToolStripButton = New System.Windows.Forms.ToolStripButton()
        ModelIDLabel = New System.Windows.Forms.Label()
        VersionIDLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.BikesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BikesBindingNavigator.SuspendLayout()
        CType(Me.ModelsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VersionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GetAllToolStrip.SuspendLayout()
        Me.GetClassicsToolStrip.SuspendLayout()
        Me.GetCruisersToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModelIDLabel
        '
        ModelIDLabel.AutoSize = True
        ModelIDLabel.Location = New System.Drawing.Point(196, 90)
        ModelIDLabel.Name = "ModelIDLabel"
        ModelIDLabel.Size = New System.Drawing.Size(39, 13)
        ModelIDLabel.TabIndex = 3
        ModelIDLabel.Text = "Model:"
        '
        'VersionIDLabel
        '
        VersionIDLabel.AutoSize = True
        VersionIDLabel.Location = New System.Drawing.Point(196, 117)
        VersionIDLabel.Name = "VersionIDLabel"
        VersionIDLabel.Size = New System.Drawing.Size(45, 13)
        VersionIDLabel.TabIndex = 5
        VersionIDLabel.Text = "Version:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(196, 144)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 7
        PriceLabel.Text = "Price:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(196, 170)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 9
        NoteLabel.Text = "Note:"
        '
        'BikesDBDataSet
        '
        Me.BikesDBDataSet.DataSetName = "BikesDBDataSet"
        Me.BikesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BikesBindingSource
        '
        Me.BikesBindingSource.DataMember = "Bikes"
        Me.BikesBindingSource.DataSource = Me.BikesDBDataSet
        '
        'BikesTableAdapter
        '
        Me.BikesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BikesTableAdapter = Me.BikesTableAdapter
        Me.TableAdapterManager.ModelsTableAdapter = Me.ModelsTableAdapter
        Me.TableAdapterManager.UpdateOrder = BikesApp.BikesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VersionsTableAdapter = Me.VersionsTableAdapter
        '
        'ModelsTableAdapter
        '
        Me.ModelsTableAdapter.ClearBeforeFill = True
        '
        'VersionsTableAdapter
        '
        Me.VersionsTableAdapter.ClearBeforeFill = True
        '
        'BikesBindingNavigator
        '
        Me.BikesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BikesBindingNavigator.BindingSource = Me.BikesBindingSource
        Me.BikesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BikesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BikesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BikesBindingNavigatorSaveItem})
        Me.BikesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BikesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BikesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BikesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BikesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BikesBindingNavigator.Name = "BikesBindingNavigator"
        Me.BikesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BikesBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.BikesBindingNavigator.TabIndex = 0
        Me.BikesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BikesBindingNavigatorSaveItem
        '
        Me.BikesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BikesBindingNavigatorSaveItem.Image = CType(resources.GetObject("BikesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BikesBindingNavigatorSaveItem.Name = "BikesBindingNavigatorSaveItem"
        Me.BikesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BikesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BikeIDTextBox
        '
        Me.BikeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BikesBindingSource, "BikeID", True))
        Me.BikeIDTextBox.Location = New System.Drawing.Point(261, 61)
        Me.BikeIDTextBox.Name = "BikeIDTextBox"
        Me.BikeIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BikeIDTextBox.TabIndex = 2
        Me.BikeIDTextBox.Visible = False
        '
        'ModelIDComboBox
        '
        Me.ModelIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BikesBindingSource, "ModelID", True))
        Me.ModelIDComboBox.DataSource = Me.ModelsBindingSource
        Me.ModelIDComboBox.DisplayMember = "Model"
        Me.ModelIDComboBox.FormattingEnabled = True
        Me.ModelIDComboBox.Location = New System.Drawing.Point(261, 87)
        Me.ModelIDComboBox.Name = "ModelIDComboBox"
        Me.ModelIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ModelIDComboBox.TabIndex = 4
        Me.ModelIDComboBox.ValueMember = "ModelID"
        '
        'ModelsBindingSource
        '
        Me.ModelsBindingSource.DataMember = "Models"
        Me.ModelsBindingSource.DataSource = Me.BikesDBDataSet
        '
        'VersionIDComboBox
        '
        Me.VersionIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BikesBindingSource, "VersionID", True))
        Me.VersionIDComboBox.DataSource = Me.VersionsBindingSource
        Me.VersionIDComboBox.DisplayMember = "Version"
        Me.VersionIDComboBox.FormattingEnabled = True
        Me.VersionIDComboBox.Location = New System.Drawing.Point(261, 114)
        Me.VersionIDComboBox.Name = "VersionIDComboBox"
        Me.VersionIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VersionIDComboBox.TabIndex = 6
        Me.VersionIDComboBox.ValueMember = "VersionsID"
        '
        'VersionsBindingSource
        '
        Me.VersionsBindingSource.DataMember = "Versions"
        Me.VersionsBindingSource.DataSource = Me.BikesDBDataSet
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BikesBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(261, 141)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PriceTextBox.TabIndex = 8
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BikesBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(261, 167)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NoteTextBox.TabIndex = 10
        '
        'GetAllToolStrip
        '
        Me.GetAllToolStrip.AutoSize = False
        Me.GetAllToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetAllToolStripButton})
        Me.GetAllToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.GetAllToolStrip.MaximumSize = New System.Drawing.Size(100, 30)
        Me.GetAllToolStrip.Name = "GetAllToolStrip"
        Me.GetAllToolStrip.Size = New System.Drawing.Size(100, 30)
        Me.GetAllToolStrip.TabIndex = 11
        Me.GetAllToolStrip.Text = "GetAllToolStrip"
        '
        'GetAllToolStripButton
        '
        Me.GetAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GetAllToolStripButton.Name = "GetAllToolStripButton"
        Me.GetAllToolStripButton.Size = New System.Drawing.Size(43, 27)
        Me.GetAllToolStripButton.Text = "GetAll"
        '
        'GetClassicsToolStrip
        '
        Me.GetClassicsToolStrip.AutoSize = False
        Me.GetClassicsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetClassicsToolStripButton})
        Me.GetClassicsToolStrip.Location = New System.Drawing.Point(0, 55)
        Me.GetClassicsToolStrip.MaximumSize = New System.Drawing.Size(100, 30)
        Me.GetClassicsToolStrip.Name = "GetClassicsToolStrip"
        Me.GetClassicsToolStrip.Size = New System.Drawing.Size(100, 30)
        Me.GetClassicsToolStrip.TabIndex = 12
        Me.GetClassicsToolStrip.Text = "GetClassicsToolStrip"
        '
        'GetClassicsToolStripButton
        '
        Me.GetClassicsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GetClassicsToolStripButton.Name = "GetClassicsToolStripButton"
        Me.GetClassicsToolStripButton.Size = New System.Drawing.Size(70, 27)
        Me.GetClassicsToolStripButton.Text = "GetClassics"
        '
        'GetCruisersToolStrip
        '
        Me.GetCruisersToolStrip.AutoSize = False
        Me.GetCruisersToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetCruisersToolStripButton})
        Me.GetCruisersToolStrip.Location = New System.Drawing.Point(0, 85)
        Me.GetCruisersToolStrip.MaximumSize = New System.Drawing.Size(100, 30)
        Me.GetCruisersToolStrip.Name = "GetCruisersToolStrip"
        Me.GetCruisersToolStrip.Size = New System.Drawing.Size(100, 30)
        Me.GetCruisersToolStrip.TabIndex = 13
        Me.GetCruisersToolStrip.Text = "GetCruisersToolStrip"
        '
        'GetCruisersToolStripButton
        '
        Me.GetCruisersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GetCruisersToolStripButton.Name = "GetCruisersToolStripButton"
        Me.GetCruisersToolStripButton.Size = New System.Drawing.Size(71, 22)
        Me.GetCruisersToolStripButton.Text = "GetCruisers"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GetCruisersToolStrip)
        Me.Controls.Add(Me.GetClassicsToolStrip)
        Me.Controls.Add(Me.GetAllToolStrip)
        Me.Controls.Add(Me.BikeIDTextBox)
        Me.Controls.Add(ModelIDLabel)
        Me.Controls.Add(Me.ModelIDComboBox)
        Me.Controls.Add(VersionIDLabel)
        Me.Controls.Add(Me.VersionIDComboBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.BikesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BikesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BikesBindingNavigator.ResumeLayout(False)
        Me.BikesBindingNavigator.PerformLayout()
        CType(Me.ModelsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VersionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GetAllToolStrip.ResumeLayout(False)
        Me.GetAllToolStrip.PerformLayout()
        Me.GetClassicsToolStrip.ResumeLayout(False)
        Me.GetClassicsToolStrip.PerformLayout()
        Me.GetCruisersToolStrip.ResumeLayout(False)
        Me.GetCruisersToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BikesDBDataSet As BikesDBDataSet
    Friend WithEvents BikesBindingSource As BindingSource
    Friend WithEvents BikesTableAdapter As BikesDBDataSetTableAdapters.BikesTableAdapter
    Friend WithEvents TableAdapterManager As BikesDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BikesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BikesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BikeIDTextBox As TextBox
    Friend WithEvents ModelIDComboBox As ComboBox
    Friend WithEvents VersionIDComboBox As ComboBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents ModelsTableAdapter As BikesDBDataSetTableAdapters.ModelsTableAdapter
    Friend WithEvents ModelsBindingSource As BindingSource
    Friend WithEvents VersionsTableAdapter As BikesDBDataSetTableAdapters.VersionsTableAdapter
    Friend WithEvents VersionsBindingSource As BindingSource
    Friend WithEvents GetAllToolStrip As ToolStrip
    Friend WithEvents GetAllToolStripButton As ToolStripButton
    Friend WithEvents GetClassicsToolStrip As ToolStrip
    Friend WithEvents GetClassicsToolStripButton As ToolStripButton
    Friend WithEvents GetCruisersToolStrip As ToolStrip
    Friend WithEvents GetCruisersToolStripButton As ToolStripButton
End Class
