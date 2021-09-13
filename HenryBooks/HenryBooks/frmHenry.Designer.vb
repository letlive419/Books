<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHenry
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
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cboTable = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.dgrInventory = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpDisplay.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpInventory.SuspendLayout()
        CType(Me.dgrInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.btnShow)
        Me.grpDisplay.Controls.Add(Me.cboTable)
        Me.grpDisplay.Controls.Add(Me.Label1)
        Me.grpDisplay.Location = New System.Drawing.Point(12, 12)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(281, 126)
        Me.grpDisplay.TabIndex = 0
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display Table Data"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(121, 78)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(141, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Data"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'cboTable
        '
        Me.cboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTable.FormattingEnabled = True
        Me.cboTable.Location = New System.Drawing.Point(121, 31)
        Me.cboTable.Name = "cboTable"
        Me.cboTable.Size = New System.Drawing.Size(141, 21)
        Me.cboTable.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Table:"
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtVal)
        Me.grpSearch.Controls.Add(Me.Label3)
        Me.grpSearch.Controls.Add(Me.cboSearch)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Location = New System.Drawing.Point(352, 16)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(601, 122)
        Me.grpSearch.TabIndex = 1
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(463, 93)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(155, 62)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(430, 20)
        Me.txtVal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Value:"
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(155, 33)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(430, 21)
        Me.cboSearch.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search inventory by:"
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.dgrInventory)
        Me.grpInventory.Location = New System.Drawing.Point(18, 160)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(934, 266)
        Me.grpInventory.TabIndex = 2
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "Inventory"
        '
        'dgrInventory
        '
        Me.dgrInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrInventory.Location = New System.Drawing.Point(10, 16)
        Me.dgrInventory.Name = "dgrInventory"
        Me.dgrInventory.Size = New System.Drawing.Size(923, 251)
        Me.dgrInventory.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(819, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmHenry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpInventory)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpDisplay)
        Me.Name = "frmHenry"
        Me.Text = "DataBase Sample"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpInventory.ResumeLayout(False)
        CType(Me.dgrInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents btnShow As Button
    Friend WithEvents cboTable As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtVal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents dgrInventory As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents errP As ErrorProvider
End Class
