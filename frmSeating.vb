'Project:	  Project 3 – Stadium Seating
'Description: Calculates the revenue of ticket sales using a validation sub-procedure for the user inputs
'Programmer:  Jerrodo Butler
'Date:		  Spring 2018

Option Strict On

Public Class frmSeating

    'Set Constant values for each ticket price at the Class Level.  
    Const decCLASS_A_PRICE As Decimal = 15D
    Const decCLASS_B_PRICE As Decimal = 12D
    Const decCLASS_C_PRICE As Decimal = 9D

    'Set Class Level variables for the Summary Form revenues to start at 0.
    Dim decClassA_SummaryRevenue As Decimal = 0
    Dim decClassB_SummaryRevenue As Decimal = 0
    Dim decClassC_SummaryRevenue As Decimal = 0
    Dim decTotal_SummaryRevenue As Decimal = 0


    'Procedure that is executed when the Calculate Revenue button is clicked to get the validate user input and calculate ticket revenue.
    Public Sub CalculateRevenueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateRevenueToolStripMenuItem.Click

        'Declare variables that will hold the revenue for each class of tickets and the total revenue on the Main Form.
        Dim decClassA_Revenue As Decimal
        Dim decClassB_Revenue As Decimal
        Dim decClassC_Revenue As Decimal
        Dim decTotal_Revenue As Decimal

        'Declare the Validation flag that determines if the input value has an error (True) of doesn't have a error (False).
        Dim blnErrorFlag As Boolean

        'Initialize the boolean variable used in the Validation sub-procedure if the input has an error (True).
        blnErrorFlag = True

        'Run Validation sub procedure to validate the textbox inputs.
        Call Validation(blnErrorFlag)

        'If the Validation doesn't have any errors, Then...
        If blnErrorFlag = False Then

            'Convert the textbox inputs to integers and assign them to the ticket number variables,
            Dim intClassA_tickets As Integer = CInt(txtClassA.Text)
            Dim intClassB_tickets As Integer = CInt(txtClassB.Text)
            Dim intClassC_tickets As Integer = CInt(txtClassC.Text)

            'Run calculations after input in all three textboxes are validated.
            decClassA_Revenue = (decCLASS_A_PRICE * intClassA_tickets)
            decClassB_Revenue = (decCLASS_B_PRICE * intClassB_tickets)
            decClassC_Revenue = (decCLASS_C_PRICE * intClassC_tickets)
            decTotal_Revenue = CDec(decClassA_Revenue + decClassB_Revenue + decClassC_Revenue)

            'Assign the calculated revenues, as string values and in currency format, to each Main Form revenue label.
            lblClassA_Revenue.Text = decClassA_Revenue.ToString("c")
            lblClassB_Revenue.Text = decClassB_Revenue.ToString("c")
            lblClassC_Revenue.Text = decClassC_Revenue.ToString("c")
            lblTotal_Revenue.Text = decTotal_Revenue.ToString("c")

            'Add the Main Form revenues to the current Summary Form revenues and assign each total value to the Class Level Summary Form revenue variables.
            decClassA_SummaryRevenue += decClassA_Revenue
            decClassB_SummaryRevenue += decClassB_Revenue
            decClassC_SummaryRevenue += decClassC_Revenue
            decTotal_SummaryRevenue += decTotal_Revenue

            'Assign the Class Level Summary Form revenue variables, as string values and in currency format, to each Summary Form revenue label.
            frmSummary.lblClassA_SummaryRevenue.Text = decClassA_SummaryRevenue.ToString("c")
            frmSummary.lblClassB_SummaryRevenue.Text = decClassB_SummaryRevenue.ToString("c")
            frmSummary.lblClassC_SummaryRevenue.Text = decClassC_SummaryRevenue.ToString("c")
            frmSummary.lblTotal_SummaryRevenue.Text = decTotal_SummaryRevenue.ToString("c")
        End If
    End Sub


    'Clear all textboxes on frmSeating.
    Private Sub ClearToolStripMenuItem_Click() Handles ClearToolStripMenuItem.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()

        lblClassA_Revenue.Text = String.Empty
        lblClassB_Revenue.Text = String.Empty
        lblClassC_Revenue.Text = String.Empty
        lblTotal_Revenue.Text = String.Empty

        txtClassA.Focus()
    End Sub

    'Clear all textboxes on the Main Form and the Summary Form.
    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click

        Call ClearToolStripMenuItem_Click()

        'Set the Summary Form revenue values back to 0. 
        decClassA_SummaryRevenue = 0
        decClassB_SummaryRevenue = 0
        decClassC_SummaryRevenue = 0
        decTotal_SummaryRevenue = 0

        frmSummary.lblClassA_SummaryRevenue.Text = String.Empty
        frmSummary.lblClassB_SummaryRevenue.Text = String.Empty
        frmSummary.lblClassC_SummaryRevenue.Text = String.Empty
        frmSummary.lblTotal_SummaryRevenue.Text = String.Empty
    End Sub


    'Display Revenues Summary form.
    Private Sub DisplaySummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplaySummaryToolStripMenuItem.Click
        frmSummary.ShowDialog()
    End Sub


    'Display About form.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub


    'End program.
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    ''''''''''''''VALIDATION SUB-PROCEDURE'''''''''''
    Private Sub Validation(ByRef blnErrorFlag As Boolean)

        Dim intClassA_tickets As Integer
        Dim intClassB_tickets As Integer
        Dim intClassC_tickets As Integer

        'Run validation on Class A textbox
        If txtClassA.Text <> "" Then
            Try
                intClassA_tickets = CInt(txtClassA.Text)

                'Run validation on Class B textbox
                If txtClassB.Text <> "" Then
                    Try
                        intClassB_tickets = CInt(txtClassB.Text)

                        'Run validation on Class C textbox
                        If txtClassC.Text <> "" Then
                            Try
                                intClassC_tickets = CInt(txtClassC.Text)

                                blnErrorFlag = False 'Run calculations because there are no input errors.

                            Catch ex As Exception
                                MessageBox.Show("Please enter a numeric value for Class C tickets", "Non-numeric Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtClassC.Focus()
                            End Try
                        Else
                            MessageBox.Show("Please enter number of Class C tickets sold.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtClassC.Focus()
                        End If

                    Catch ex As Exception

                        MessageBox.Show(" Please enter a numeric value for Class B tickets", "Non-numeric Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtClassB.Focus()
                    End Try
                Else

                    MessageBox.Show("Please enter number of Class B tickets sold.", "Missing Data.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtClassB.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Please enter a numeric value for Class A tickets.", "Non-numeric Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtClassA.Focus()
            End Try

        Else
            MessageBox.Show("Please enter number of Class A tickets sold.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClassA.Focus()
        End If
    End Sub
    ''''''''''''''VALIDATION SUB-PROCEDURE end'''''''''''


End Class
