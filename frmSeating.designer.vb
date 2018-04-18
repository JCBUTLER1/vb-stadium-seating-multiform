<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeating
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal_Revenue = New System.Windows.Forms.Label()
        Me.lblClassC_Revenue = New System.Windows.Forms.Label()
        Me.lblClassB_Revenue = New System.Windows.Forms.Label()
        Me.lblClassA_Revenue = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateRevenueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplaySummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(73, 120)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(50, 20)
        Me.txtClassB.TabIndex = 1
        Me.txtClassB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(73, 71)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(50, 20)
        Me.txtClassA.TabIndex = 0
        Me.txtClassA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtClassA.UseWaitCursor = True
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(73, 165)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(50, 20)
        Me.txtClassC.TabIndex = 2
        Me.txtClassC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class C:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class B:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Class A:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of tickets sold for each class of seats" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblTotal_Revenue)
        Me.GroupBox2.Controls.Add(Me.lblClassC_Revenue)
        Me.GroupBox2.Controls.Add(Me.lblClassB_Revenue)
        Me.GroupBox2.Controls.Add(Me.lblClassA_Revenue)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 247)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total Revenue:"
        '
        'lblTotal_Revenue
        '
        Me.lblTotal_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal_Revenue.Location = New System.Drawing.Point(118, 201)
        Me.lblTotal_Revenue.Name = "lblTotal_Revenue"
        Me.lblTotal_Revenue.Size = New System.Drawing.Size(81, 23)
        Me.lblTotal_Revenue.TabIndex = 7
        Me.lblTotal_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClassC_Revenue
        '
        Me.lblClassC_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC_Revenue.Location = New System.Drawing.Point(118, 162)
        Me.lblClassC_Revenue.Name = "lblClassC_Revenue"
        Me.lblClassC_Revenue.Size = New System.Drawing.Size(81, 23)
        Me.lblClassC_Revenue.TabIndex = 6
        Me.lblClassC_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClassB_Revenue
        '
        Me.lblClassB_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB_Revenue.Location = New System.Drawing.Point(118, 117)
        Me.lblClassB_Revenue.Name = "lblClassB_Revenue"
        Me.lblClassB_Revenue.Size = New System.Drawing.Size(81, 23)
        Me.lblClassB_Revenue.TabIndex = 5
        Me.lblClassB_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClassA_Revenue
        '
        Me.lblClassA_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA_Revenue.Location = New System.Drawing.Point(118, 68)
        Me.lblClassA_Revenue.Name = "lblClassA_Revenue"
        Me.lblClassA_Revenue.Size = New System.Drawing.Size(81, 23)
        Me.lblClassA_Revenue.TabIndex = 4
        Me.lblClassA_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Class C:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Class B:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Class A:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(320, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Programmed by Jerrodo Butler, 2018"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(510, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateRevenueToolStripMenuItem, Me.DisplaySummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateRevenueToolStripMenuItem
        '
        Me.CalculateRevenueToolStripMenuItem.Name = "CalculateRevenueToolStripMenuItem"
        Me.CalculateRevenueToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CalculateRevenueToolStripMenuItem.Text = "&Calculate Revenue"
        Me.CalculateRevenueToolStripMenuItem.ToolTipText = "Calculate and display current revenues"
        '
        'DisplaySummaryToolStripMenuItem
        '
        Me.DisplaySummaryToolStripMenuItem.Name = "DisplaySummaryToolStripMenuItem"
        Me.DisplaySummaryToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DisplaySummaryToolStripMenuItem.Text = "Display &Summary"
        Me.DisplaySummaryToolStripMenuItem.ToolTipText = "Display summary revenues"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Termnate project execution"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        Me.ClearToolStripMenuItem.ToolTipText = "Clear all textboxes and labels on this form"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clea&r All"
        Me.ClearAllToolStripMenuItem.ToolTipText = "Clear all textboxes and labels on this form and on the summary form and reinitial" &
    "ize totals to zero"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Display About Box"
        '
        'frmSeating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 379)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmSeating"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stadium Seating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClassB As TextBox
    Friend WithEvents txtClassA As TextBox
    Friend WithEvents txtClassC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblClassC_Revenue As Label
    Friend WithEvents lblClassB_Revenue As Label
    Friend WithEvents lblClassA_Revenue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal_Revenue As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateRevenueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaySummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
