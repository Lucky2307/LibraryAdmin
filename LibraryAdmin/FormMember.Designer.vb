<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMember))
        Me.memberMenustrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThisProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridPanel = New System.Windows.Forms.Panel()
        Me.memberDatagrid = New System.Windows.Forms.DataGridView()
        Me.gridContextstrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editContextmenustrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.memberToolstrip = New System.Windows.Forms.ToolStrip()
        Me.addButton = New System.Windows.Forms.ToolStripButton()
        Me.editButton = New System.Windows.Forms.ToolStripButton()
        Me.deleteButton = New System.Windows.Forms.ToolStripButton()
        Me.editTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableAdapterManager1 = New LibraryAdmin.LibraryAdminDataSetTableAdapters.TableAdapterManager()
        Me.editUC = New LibraryAdmin.editMemberUsercontrol()
        Me.addUC = New LibraryAdmin.addMemberUsercontrol()
        Me.viewUC = New LibraryAdmin.viewMemberUsercontrol()
        Me.memberMenustrip.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.memberDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridContextstrip.SuspendLayout()
        Me.memberToolstrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'memberMenustrip
        '
        Me.memberMenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.memberMenustrip.Location = New System.Drawing.Point(0, 0)
        Me.memberMenustrip.Name = "memberMenustrip"
        Me.memberMenustrip.Size = New System.Drawing.Size(800, 24)
        Me.memberMenustrip.TabIndex = 0
        Me.memberMenustrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThisProgramToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ThisProgramToolStripMenuItem
        '
        Me.ThisProgramToolStripMenuItem.Name = "ThisProgramToolStripMenuItem"
        Me.ThisProgramToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ThisProgramToolStripMenuItem.Text = "This Program"
        '
        'gridPanel
        '
        Me.gridPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gridPanel.Controls.Add(Me.memberDatagrid)
        Me.gridPanel.Controls.Add(Me.memberToolstrip)
        Me.gridPanel.Location = New System.Drawing.Point(0, 24)
        Me.gridPanel.Name = "gridPanel"
        Me.gridPanel.Size = New System.Drawing.Size(236, 426)
        Me.gridPanel.TabIndex = 2
        '
        'memberDatagrid
        '
        Me.memberDatagrid.AllowUserToAddRows = False
        Me.memberDatagrid.AllowUserToDeleteRows = False
        Me.memberDatagrid.AllowUserToResizeRows = False
        Me.memberDatagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memberDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.memberDatagrid.ContextMenuStrip = Me.gridContextstrip
        Me.memberDatagrid.Location = New System.Drawing.Point(0, 25)
        Me.memberDatagrid.MultiSelect = False
        Me.memberDatagrid.Name = "memberDatagrid"
        Me.memberDatagrid.ReadOnly = True
        Me.memberDatagrid.RowHeadersVisible = False
        Me.memberDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.memberDatagrid.Size = New System.Drawing.Size(233, 398)
        Me.memberDatagrid.TabIndex = 1
        '
        'gridContextstrip
        '
        Me.gridContextstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.editContextmenustrip, Me.DeleteToolStripMenuItem})
        Me.gridContextstrip.Name = "gridContextstrip"
        Me.gridContextstrip.Size = New System.Drawing.Size(108, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'editContextmenustrip
        '
        Me.editContextmenustrip.Name = "editContextmenustrip"
        Me.editContextmenustrip.Size = New System.Drawing.Size(107, 22)
        Me.editContextmenustrip.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'memberToolstrip
        '
        Me.memberToolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addButton, Me.editButton, Me.deleteButton})
        Me.memberToolstrip.Location = New System.Drawing.Point(0, 0)
        Me.memberToolstrip.Name = "memberToolstrip"
        Me.memberToolstrip.Size = New System.Drawing.Size(236, 25)
        Me.memberToolstrip.TabIndex = 0
        Me.memberToolstrip.Text = "ToolStrip1"
        '
        'addButton
        '
        Me.addButton.Font = New System.Drawing.Font("Bebas", 9.0!)
        Me.addButton.Image = Global.LibraryAdmin.My.Resources.Resources.addButton
        Me.addButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addButton.Name = "addButton"
        Me.addButton.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.addButton.Size = New System.Drawing.Size(57, 22)
        Me.addButton.Text = "Add"
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Bebas", 9.0!)
        Me.editButton.Image = Global.LibraryAdmin.My.Resources.Resources.editButton
        Me.editButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.editButton.Name = "editButton"
        Me.editButton.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.editButton.Size = New System.Drawing.Size(60, 22)
        Me.editButton.Text = "Edit"
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Bebas", 9.0!)
        Me.deleteButton.Image = Global.LibraryAdmin.My.Resources.Resources.deleteButton
        Me.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.deleteButton.Size = New System.Drawing.Size(72, 22)
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.ToolTipText = "Delete the selected member"
        '
        'editTooltip
        '
        Me.editTooltip.ToolTipTitle = "ToolTip:"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.authorTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.bookTableAdapter = Nothing
        Me.TableAdapterManager1.borrowTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.memberTableAdapter = Nothing
        Me.TableAdapterManager1.publisherTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = LibraryAdmin.LibraryAdminDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'editUC
        '
        Me.editUC.Location = New System.Drawing.Point(239, 24)
        Me.editUC.Name = "editUC"
        Me.editUC.Size = New System.Drawing.Size(558, 423)
        Me.editUC.TabIndex = 15
        Me.editUC.Visible = False
        '
        'addUC
        '
        Me.addUC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addUC.Location = New System.Drawing.Point(242, 27)
        Me.addUC.Name = "addUC"
        Me.addUC.Size = New System.Drawing.Size(558, 423)
        Me.addUC.TabIndex = 14
        Me.addUC.Visible = False
        '
        'viewUC
        '
        Me.viewUC.Location = New System.Drawing.Point(242, 27)
        Me.viewUC.Name = "viewUC"
        Me.viewUC.Size = New System.Drawing.Size(558, 423)
        Me.viewUC.TabIndex = 16
        '
        'FormMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gridPanel)
        Me.Controls.Add(Me.memberMenustrip)
        Me.Controls.Add(Me.editUC)
        Me.Controls.Add(Me.addUC)
        Me.Controls.Add(Me.viewUC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.memberMenustrip
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormMember"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Member Viewer"
        Me.memberMenustrip.ResumeLayout(False)
        Me.memberMenustrip.PerformLayout()
        Me.gridPanel.ResumeLayout(False)
        Me.gridPanel.PerformLayout()
        CType(Me.memberDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridContextstrip.ResumeLayout(False)
        Me.memberToolstrip.ResumeLayout(False)
        Me.memberToolstrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents memberMenustrip As MenuStrip
    Friend WithEvents gridPanel As Panel
    Friend WithEvents memberToolstrip As ToolStrip
    Friend WithEvents addButton As ToolStripButton
    Friend WithEvents editButton As ToolStripButton
    Friend WithEvents deleteButton As ToolStripButton
    Friend WithEvents addUC As addMemberUsercontrol
    Friend WithEvents memberDatagrid As DataGridView
    Friend WithEvents gridContextstrip As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents editTooltip As ToolTip
    Friend WithEvents TableAdapterManager1 As LibraryAdminDataSetTableAdapters.TableAdapterManager
    Friend WithEvents editUC As editMemberUsercontrol
    Friend WithEvents viewUC As viewMemberUsercontrol
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThisProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents editContextmenustrip As ToolStripMenuItem
End Class
