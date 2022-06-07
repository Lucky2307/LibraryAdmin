<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTOS
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1. ACCEPTANCE THE USE OF LOREM IPSUM TERMS AND CONDITIONS")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2. CREDIT CARD DETAILS")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3. LEGAL ADVICE")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.1")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.2")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4. CHANGE OF USE", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5. LINKS TO THIRD PARTY APPS AND WEBSITES")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6.1")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6.2")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6. COPYRIGHT", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7.1")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7.2.(a)")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7.2.(b)")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7.2.(c)")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7.2", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7.3")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("7. LINKS TO AND FROM OTHER APPS AND WEBSITES", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8.1")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8.2")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8.3")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8.4")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8. DISCLAIMER AND LIMITATION OF LIABILITY", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9. INDEMNITY")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("10. SEVERANCE")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("11. WAIVER")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("12. GOVERNING LAW")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("13. OURCONTACT DETAILS")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Terms of Service", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode6, TreeNode7, TreeNode10, TreeNode17, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26, TreeNode27})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTOS))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.contentSplitcontainer = New System.Windows.Forms.SplitContainer()
        Me.TOSBrowser = New System.Windows.Forms.WebBrowser()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.treePanel = New System.Windows.Forms.Panel()
        Me.TermsAndServiceTree = New System.Windows.Forms.TreeView()
        CType(Me.contentSplitcontainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contentSplitcontainer.Panel1.SuspendLayout()
        Me.contentSplitcontainer.Panel2.SuspendLayout()
        Me.contentSplitcontainer.SuspendLayout()
        Me.treePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(260, 450)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'contentSplitcontainer
        '
        Me.contentSplitcontainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contentSplitcontainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.contentSplitcontainer.IsSplitterFixed = True
        Me.contentSplitcontainer.Location = New System.Drawing.Point(260, 0)
        Me.contentSplitcontainer.Name = "contentSplitcontainer"
        Me.contentSplitcontainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'contentSplitcontainer.Panel1
        '
        Me.contentSplitcontainer.Panel1.Controls.Add(Me.TOSBrowser)
        '
        'contentSplitcontainer.Panel2
        '
        Me.contentSplitcontainer.Panel2.Controls.Add(Me.exitButton)
        Me.contentSplitcontainer.Size = New System.Drawing.Size(540, 450)
        Me.contentSplitcontainer.SplitterDistance = 405
        Me.contentSplitcontainer.TabIndex = 1
        '
        'TOSBrowser
        '
        Me.TOSBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOSBrowser.Location = New System.Drawing.Point(0, 0)
        Me.TOSBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.TOSBrowser.Name = "TOSBrowser"
        Me.TOSBrowser.Size = New System.Drawing.Size(540, 405)
        Me.TOSBrowser.TabIndex = 0
        Me.TOSBrowser.Url = New System.Uri("file:///E:/tes2.html", System.UriKind.Absolute)
        '
        'exitButton
        '
        Me.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.exitButton.AutoSize = True
        Me.exitButton.Location = New System.Drawing.Point(414, 2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(114, 35)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'treePanel
        '
        Me.treePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.treePanel.Controls.Add(Me.TermsAndServiceTree)
        Me.treePanel.Location = New System.Drawing.Point(0, 0)
        Me.treePanel.Name = "treePanel"
        Me.treePanel.Size = New System.Drawing.Size(260, 450)
        Me.treePanel.TabIndex = 2
        '
        'TermsAndServiceTree
        '
        Me.TermsAndServiceTree.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TermsAndServiceTree.Location = New System.Drawing.Point(12, 12)
        Me.TermsAndServiceTree.Name = "TermsAndServiceTree"
        TreeNode1.Name = "1"
        TreeNode1.Text = "1. ACCEPTANCE THE USE OF LOREM IPSUM TERMS AND CONDITIONS"
        TreeNode2.Name = "2"
        TreeNode2.Text = "2. CREDIT CARD DETAILS"
        TreeNode3.Name = "3"
        TreeNode3.Text = "3. LEGAL ADVICE"
        TreeNode4.Name = "4.1"
        TreeNode4.Text = "4.1"
        TreeNode5.Name = "4.2"
        TreeNode5.Text = "4.2"
        TreeNode6.Name = "4"
        TreeNode6.Text = "4. CHANGE OF USE"
        TreeNode7.Name = "5"
        TreeNode7.Text = "5. LINKS TO THIRD PARTY APPS AND WEBSITES"
        TreeNode8.Name = "6.1"
        TreeNode8.Text = "6.1"
        TreeNode9.Name = "6.2"
        TreeNode9.Text = "6.2"
        TreeNode10.Name = "6"
        TreeNode10.Text = "6. COPYRIGHT"
        TreeNode11.Name = "7.1"
        TreeNode11.Text = "7.1"
        TreeNode12.Name = "7.2.(a)"
        TreeNode12.Text = "7.2.(a)"
        TreeNode13.Name = "7.2.(b)"
        TreeNode13.Text = "7.2.(b)"
        TreeNode14.Name = "7.2.(c)"
        TreeNode14.Text = "7.2.(c)"
        TreeNode15.Name = "7.2"
        TreeNode15.Text = "7.2"
        TreeNode16.Name = "7.3"
        TreeNode16.Text = "7.3"
        TreeNode17.Name = "7"
        TreeNode17.Text = "7. LINKS TO AND FROM OTHER APPS AND WEBSITES"
        TreeNode18.Name = "8.1"
        TreeNode18.Text = "8.1"
        TreeNode19.Name = "8.2"
        TreeNode19.Text = "8.2"
        TreeNode20.Name = "8.3"
        TreeNode20.Text = "8.3"
        TreeNode21.Name = "8.4"
        TreeNode21.Text = "8.4"
        TreeNode22.Name = "8"
        TreeNode22.Text = "8. DISCLAIMER AND LIMITATION OF LIABILITY"
        TreeNode23.Name = "9"
        TreeNode23.Text = "9. INDEMNITY"
        TreeNode24.Name = "10"
        TreeNode24.Text = "10. SEVERANCE"
        TreeNode25.Name = "11"
        TreeNode25.Text = "11. WAIVER"
        TreeNode26.Name = "12"
        TreeNode26.Text = "12. GOVERNING LAW"
        TreeNode27.Name = "13"
        TreeNode27.Text = "13. OURCONTACT DETAILS"
        TreeNode28.Checked = True
        TreeNode28.Name = "Terms of Service"
        TreeNode28.Text = "Terms of Service"
        Me.TermsAndServiceTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode28})
        Me.TermsAndServiceTree.Size = New System.Drawing.Size(239, 426)
        Me.TermsAndServiceTree.TabIndex = 0
        '
        'FormTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.treePanel)
        Me.Controls.Add(Me.contentSplitcontainer)
        Me.Controls.Add(Me.Splitter1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTOS"
        Me.Text = "FormTOS"
        Me.contentSplitcontainer.Panel1.ResumeLayout(False)
        Me.contentSplitcontainer.Panel2.ResumeLayout(False)
        Me.contentSplitcontainer.Panel2.PerformLayout()
        CType(Me.contentSplitcontainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contentSplitcontainer.ResumeLayout(False)
        Me.treePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents contentSplitcontainer As SplitContainer
    Friend WithEvents treePanel As Panel
    Friend WithEvents TermsAndServiceTree As TreeView
    Friend WithEvents TOSBrowser As WebBrowser
    Friend WithEvents exitButton As Button
End Class
