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
        Me.components = New System.ComponentModel.Container()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.listViewStandardElements = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LLName = New System.Windows.Forms.Label()
        Me.LLMaterial = New System.Windows.Forms.Label()
        Me.LLNrOfConductors = New System.Windows.Forms.Label()
        Me.LLProjectNumber = New System.Windows.Forms.Label()
        Me.LLProjectName = New System.Windows.Forms.Label()
        Me.LLLineNumber = New System.Windows.Forms.Label()
        Me.LLLineName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Location = New System.Drawing.Point(12, 358)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(116, 23)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'listViewStandardElements
        '
        Me.listViewStandardElements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listViewStandardElements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.listViewStandardElements.FullRowSelect = True
        Me.listViewStandardElements.HideSelection = False
        Me.listViewStandardElements.Location = New System.Drawing.Point(12, 174)
        Me.listViewStandardElements.Name = "listViewStandardElements"
        Me.listViewStandardElements.Size = New System.Drawing.Size(442, 170)
        Me.listViewStandardElements.TabIndex = 4
        Me.listViewStandardElements.UseCompatibleStateImageBehavior = False
        Me.listViewStandardElements.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 144
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Spec.Item"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Current Rating"
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "X"
        Me.ColumnHeader5.Width = 37
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Y"
        Me.ColumnHeader6.Width = 41
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Z"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Line Layout Properties"
        '
        'LLName
        '
        Me.LLName.AutoSize = True
        Me.LLName.Location = New System.Drawing.Point(13, 44)
        Me.LLName.Name = "LLName"
        Me.LLName.Size = New System.Drawing.Size(87, 13)
        Me.LLName.TabIndex = 6
        Me.LLName.Text = "LineLayoutName"
        '
        'LLMaterial
        '
        Me.LLMaterial.AutoSize = True
        Me.LLMaterial.Location = New System.Drawing.Point(13, 71)
        Me.LLMaterial.Name = "LLMaterial"
        Me.LLMaterial.Size = New System.Drawing.Size(44, 13)
        Me.LLMaterial.TabIndex = 7
        Me.LLMaterial.Text = "Material"
        '
        'LLNrOfConductors
        '
        Me.LLNrOfConductors.AutoSize = True
        Me.LLNrOfConductors.Location = New System.Drawing.Point(13, 97)
        Me.LLNrOfConductors.Name = "LLNrOfConductors"
        Me.LLNrOfConductors.Size = New System.Drawing.Size(83, 13)
        Me.LLNrOfConductors.TabIndex = 8
        Me.LLNrOfConductors.Text = "NrOfConductors"
        '
        'LLProjectNumber
        '
        Me.LLProjectNumber.AutoSize = True
        Me.LLProjectNumber.Location = New System.Drawing.Point(209, 44)
        Me.LLProjectNumber.Name = "LLProjectNumber"
        Me.LLProjectNumber.Size = New System.Drawing.Size(80, 13)
        Me.LLProjectNumber.TabIndex = 9
        Me.LLProjectNumber.Text = "Project Number"
        '
        'LLProjectName
        '
        Me.LLProjectName.AutoSize = True
        Me.LLProjectName.Location = New System.Drawing.Point(213, 71)
        Me.LLProjectName.Name = "LLProjectName"
        Me.LLProjectName.Size = New System.Drawing.Size(71, 13)
        Me.LLProjectName.TabIndex = 10
        Me.LLProjectName.Text = "Project Name"
        '
        'LLLineNumber
        '
        Me.LLLineNumber.AutoSize = True
        Me.LLLineNumber.Location = New System.Drawing.Point(213, 97)
        Me.LLLineNumber.Name = "LLLineNumber"
        Me.LLLineNumber.Size = New System.Drawing.Size(64, 13)
        Me.LLLineNumber.TabIndex = 11
        Me.LLLineNumber.Text = "LineNumber"
        '
        'LLLineName
        '
        Me.LLLineName.AutoSize = True
        Me.LLLineName.Location = New System.Drawing.Point(213, 121)
        Me.LLLineName.Name = "LLLineName"
        Me.LLLineName.Size = New System.Drawing.Size(58, 13)
        Me.LLLineName.TabIndex = 12
        Me.LLLineName.Text = "Line Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Standard Elements"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LLLineName)
        Me.Controls.Add(Me.LLLineNumber)
        Me.Controls.Add(Me.LLProjectName)
        Me.Controls.Add(Me.LLProjectNumber)
        Me.Controls.Add(Me.LLNrOfConductors)
        Me.Controls.Add(Me.LLMaterial)
        Me.Controls.Add(Me.LLName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listViewStandardElements)
        Me.Controls.Add(Me.btnExport)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExport As Windows.Forms.Button
    Friend WithEvents listViewStandardElements As Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents ColumnHeader1 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LLName As Windows.Forms.Label
    Friend WithEvents LLMaterial As Windows.Forms.Label
    Friend WithEvents LLNrOfConductors As Windows.Forms.Label
    Friend WithEvents LLProjectNumber As Windows.Forms.Label
    Friend WithEvents LLProjectName As Windows.Forms.Label
    Friend WithEvents LLLineNumber As Windows.Forms.Label
    Friend WithEvents LLLineName As Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
