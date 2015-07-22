'****************************************************************************** 
' PROGRAM: Columbus Agency for Regional Travel 
' AUTHOR: Crystal Pendergrass
' DATE: 27 February 2015
' PURPOSE: Reservation which allows the receptionist to generate an invoice
' based on the number of people participating in each adventure.  The invoice 
' will include the total cost of all adventures, tax and service charge both 
' based on the total cost of adventure and a final total summing the total cost
' of all adventures, tax and service charge.  
'******************************************************************************

Option Strict On
Public Class frmReservationSystem
    ' constants for this application
    Const cdecPricePerWhitewaterClassic As Decimal = 32.5D
    Const cdecPricePerWhitewaterHighwater As Decimal = 48.5D
    Const cdecPricePerZipLine As Decimal = 16D
    Const cdecPricePerCanopyBoat As Decimal = 21D
    Const cdecTaxPercent As Decimal = 0.15D
    Const cdecServiceChargePercent As Decimal = 0.07D

    '****************************************************************************** 
    'When the Display Invoice button is clicked then the total cost of all 
    'adventures is calculated, as well as tax, service charge and the final total
    'of the entire reservation.  
    'If user does not enter booking number and passenger number for at least one
    'adventure, then warning is displayed and "Display Invoice" button is disabled
    '******************************************************************************
    Private Sub btnDisplayInvoice_Click(sender As Object, e As EventArgs) Handles btnDisplayInvoice.Click
        Dim decTotalPriceWhitewaterClassic As Decimal
        Dim decTotalPriceWhitewaterHighwater As Decimal
        Dim decTotalPriceZipLine As Decimal
        Dim decTotalPriceCanopyBoat As Decimal
        Dim decTax As Decimal
        Dim decServiceCharge As Decimal
        Dim decSubTotal As Decimal
        Dim decFinalTotal As Decimal



        'User must enter a booking number to perform calculation and number of
        'passengers for at least one adventure
        If (txtBookingNumber.TextLength > 0 And
             (txtWhitewaterClassicNumber.TextLength > 0 Or
              txtWhitewaterHighwaterNumber.TextLength > 0 Or
              txtZipLineNumber.TextLength > 0 Or
            txtCanopyBoatNumber.TextLength > 0)) Then
            'The following attempts to partially validate the input for how many
            'will be participating in each adventure. Validating that user has 
            'input some value and if that value is an integer it must be greater
            'than 0
            'There is no validation for type. 
            'This would be better handle as a separate validation function to 
            'reduce lines of code
            lblWarning1.Visible = False
            lblWarning2.Visible = False

            Dim intTempPassengerNumber As Integer

            If (txtWhitewaterClassicNumber.TextLength = 0) Then
                intTempPassengerNumber = 0
            Else
                intTempPassengerNumber = Convert.ToInt32(txtWhitewaterClassicNumber.Text)
                If (intTempPassengerNumber > 0) Then
                    decTotalPriceWhitewaterClassic = intTempPassengerNumber * cdecPricePerWhitewaterClassic
                Else
                    decTotalPriceWhitewaterClassic = 0
                End If
            End If

            If (txtWhitewaterHighwaterNumber.TextLength = 0) Then
                intTempPassengerNumber = 0
            Else
                intTempPassengerNumber = Convert.ToInt32(txtWhitewaterHighwaterNumber.Text)
                If (intTempPassengerNumber > 0) Then
                    decTotalPriceWhitewaterHighwater = intTempPassengerNumber * cdecPricePerWhitewaterHighwater
                Else
                    decTotalPriceWhitewaterHighwater = 0
                End If
            End If

            If (txtZipLineNumber.TextLength = 0) Then
                intTempPassengerNumber = 0
            Else
                intTempPassengerNumber = Convert.ToInt32(txtZipLineNumber.Text)
                If (intTempPassengerNumber > 0) Then
                    decTotalPriceZipLine = intTempPassengerNumber * cdecPricePerZipLine
                Else
                    decTotalPriceZipLine = 0
                End If
            End If

            If (txtCanopyBoatNumber.TextLength = 0) Then
                intTempPassengerNumber = 0
            Else
                intTempPassengerNumber = Convert.ToInt32(txtCanopyBoatNumber.Text)
                If (intTempPassengerNumber > 0) Then
                    decTotalPriceCanopyBoat = intTempPassengerNumber * cdecPricePerCanopyBoat
                Else
                    decTotalPriceCanopyBoat = 0
                End If
            End If

            decSubTotal = decTotalPriceWhitewaterClassic + decTotalPriceWhitewaterHighwater + decTotalPriceZipLine + decTotalPriceCanopyBoat
            decTax = decSubTotal * cdecTaxPercent
            decServiceCharge = decSubTotal * cdecServiceChargePercent

            decFinalTotal = decTax + decServiceCharge + decSubTotal

            lblSubTotal.Text = decSubTotal.ToString("C")
            lblTax.Text = decTax.ToString("C")
            lblServiceCharge.Text = decServiceCharge.ToString("C")
            lblFinalTotal.Text = decFinalTotal.ToString("C")
        Else
            ' User has deleted booking number.  No calculation performed. Display warning. 
            btnDisplayInvoice.Enabled = False
            lblWarning1.Visible = True
            lblWarning2.Visible = True
        End If

    End Sub
    '****************************************************************************** 
    'Exits window and closes application
    '******************************************************************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    '****************************************************************************** 
    'Reset textboxes to zero and erases any calculations for subtotal, tax, service
    'charge and final total
    '******************************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBookingNumber.Clear()
        txtWhitewaterClassicNumber.Clear()
        txtWhitewaterHighwaterNumber.Clear()
        txtZipLineNumber.Clear()
        txtCanopyBoatNumber.Clear()

        lblTax.Text = ""
        lblServiceCharge.Text = ""
        lblSubTotal.Text = ""
        lblFinalTotal.Text = ""

        lblWarning1.Visible = False
        lblWarning2.Visible = False

        btnDisplayInvoice.Enabled = False
    End Sub

    '****************************************************************************** 
    'When the formed is loaded the "Display Invoice" button is disabled textboxes 
    'and the values for subtotal, tax, service charge and final total are blank and
    'focus is set to booking number.  
    '******************************************************************************
    Private Sub frmReservationSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDisplayInvoice.Enabled = False

        txtWhitewaterClassicNumber.Clear()
        txtWhitewaterHighwaterNumber.Clear()
        txtZipLineNumber.Clear()
        txtCanopyBoatNumber.Clear()

        lblTax.Text = ""
        lblServiceCharge.Text = ""
        lblSubTotal.Text = ""
        lblFinalTotal.Text = ""

        lblWarning1.Visible = False
        lblWarning2.Visible = False

        txtBookingNumber.Focus()
    End Sub

    '****************************************************************************** 
    'When User enters booking number, the "Display Invoice" is enabled. 
    '******************************************************************************
    Private Sub txtBookingNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBookingNumber.TextChanged
        btnDisplayInvoice.Enabled = True
    End Sub

    '****************************************************************************** 
    'When User enters passenger number and has already entered booking number 
    'the "Display Invoice" is enabled. 
    '******************************************************************************
    Private Sub txtWhitewaterClassicNumber_TextChanged(sender As Object, e As EventArgs) Handles txtWhitewaterClassicNumber.TextChanged
        If (txtBookingNumber.TextLength > 0) Then
            btnDisplayInvoice.Enabled = True
        End If
    End Sub

    '****************************************************************************** 
    'When User enters passenger number and has already entered booking number 
    'the "Display Invoice" is enabled. 
    '******************************************************************************
    Private Sub txtWhitewaterHighwaterNumber_TextChanged(sender As Object, e As EventArgs) Handles txtWhitewaterHighwaterNumber.TextChanged
        If (txtBookingNumber.TextLength > 0) Then
            btnDisplayInvoice.Enabled = True
        End If
    End Sub

    '****************************************************************************** 
    'When User enters passenger number and has already entered booking number 
    'the "Display Invoice" is enabled. 
    '******************************************************************************
    Private Sub txtZipLineNumber_TextChanged(sender As Object, e As EventArgs) Handles txtZipLineNumber.TextChanged
        If (txtBookingNumber.TextLength > 0) Then
            btnDisplayInvoice.Enabled = True
        End If
    End Sub

    '****************************************************************************** 
    'When User enters passenger number and has already entered booking number 
    'the "Display Invoice" is enabled. 
    '******************************************************************************
    Private Sub txtCanopyBoatNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCanopyBoatNumber.TextChanged
        If (txtBookingNumber.TextLength > 0) Then
            btnDisplayInvoice.Enabled = True
        End If
    End Sub
End Class
