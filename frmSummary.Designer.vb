<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal_SummaryRevenue = New System.Windows.Forms.Label()
        Me.lblClassC_SummaryRevenue = New System.Windows.Forms.Label()
        Me.lblClassB_SummaryRevenue = New System.Windows.Forms.Label()
        Me.lblClassA_SummaryRevenue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal_SummaryRevenue)
        Me.GroupBox1.Controls.Add(Me.lblClassC_SummaryRevenue)
        Me.GroupBox1.Controls.Add(Me.lblClassB_SummaryRevenue)
        Me.GroupBox1.Controls.Add(Me.lblClassA_SummaryRevenue)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary Ticket Revenue"
        '
        'lblTotal_SummaryRevenue
        '
        Me.lblTotal_SummaryRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal_SummaryRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_SummaryRevenue.Location = New System.Drawing.Point(206, 144)
        Me.lblTotal_SummaryRevenue.Name = "lblTotal_SummaryRevenue"
        Me.lblTotal_SummaryRevenue.Size = New System.Drawing.Size(81, 23)
        Me.lblTotal_SummaryRevenue.TabIndex = 7
        Me.lblTotal_SummaryRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClassC_SummaryRevenue
        '
        Me.lblClassC_SummaryRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC_SummaryRevenue.Location = New System.Drawing.Point(206, 104)
        Me.lblClassC_SummaryRevenue.Name = "lblClassC_SummaryRevenue"
        Me.lblClassC_SummaryRevenue.Size = New System.Drawing.Size(81, 23)
        Me.lblClassC_SummaryRevenue.TabIndex = 6
        Me.lblClassC_SummaryRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClassB_SummaryRevenue
        '
        Me.lblClassB_SummaryRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB_SummaryRevenue.Location = New System.Drawing.Point(206, 64)
        Me.lblClassB_SummaryRevenue.Name = "lblClassB_SummaryRevenue"
        Me.lblClassB_SummaryRevenue.Size = New System.Drawing.Size(81, 23)
        Me.lblClassB_SummaryRevenue.TabIndex = 5
        Me.lblClassB_SummaryRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClassA_SummaryRevenue
        '
        Me.lblClassA_SummaryRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA_SummaryRevenue.Location = New System.Drawing.Point(206, 24)
        Me.lblClassA_SummaryRevenue.Name = "lblClassA_SummaryRevenue"
        Me.lblClassA_SummaryRevenue.Size = New System.Drawing.Size(81, 23)
        Me.lblClassA_SummaryRevenue.TabIndex = 4
        Me.lblClassA_SummaryRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Grand Total Revenue:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Class C Ticket Revenue:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Class B Ticket Revenue:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Class A Ticket Revenue:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(146, 234)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 278)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stadium Seating - Summary Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal_SummaryRevenue As Label
    Friend WithEvents lblClassC_SummaryRevenue As Label
    Friend WithEvents lblClassB_SummaryRevenue As Label
    Friend WithEvents lblClassA_SummaryRevenue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
End Class
