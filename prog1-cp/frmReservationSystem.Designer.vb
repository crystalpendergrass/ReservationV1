<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationSystem
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
        Me.lblHeading01 = New System.Windows.Forms.Label()
        Me.lblHeading03 = New System.Windows.Forms.Label()
        Me.lblBookingNumber = New System.Windows.Forms.Label()
        Me.txtBookingNumber = New System.Windows.Forms.TextBox()
        Me.lblWhitewaterClassicNumber = New System.Windows.Forms.Label()
        Me.txtWhitewaterClassicNumber = New System.Windows.Forms.TextBox()
        Me.lblZipLineNumber = New System.Windows.Forms.Label()
        Me.txtZipLineNumber = New System.Windows.Forms.TextBox()
        Me.txtCanopyBoatNumber = New System.Windows.Forms.TextBox()
        Me.lblCanopyBoatNumber = New System.Windows.Forms.Label()
        Me.lblTaxLabel = New System.Windows.Forms.Label()
        Me.lblSubTotalLabel = New System.Windows.Forms.Label()
        Me.lblServiceChargeLabel = New System.Windows.Forms.Label()
        Me.lblFinalTotalLabel = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblServiceCharge = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.lblWhitewaterHighwaterNumber = New System.Windows.Forms.Label()
        Me.txtWhitewaterHighwaterNumber = New System.Windows.Forms.TextBox()
        Me.btnDisplayInvoice = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblHeading02 = New System.Windows.Forms.Label()
        Me.lblWarning1 = New System.Windows.Forms.Label()
        Me.lblWarning2 = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading01
        '
        Me.lblHeading01.AutoSize = True
        Me.lblHeading01.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading01.Location = New System.Drawing.Point(188, 9)
        Me.lblHeading01.Name = "lblHeading01"
        Me.lblHeading01.Size = New System.Drawing.Size(232, 29)
        Me.lblHeading01.TabIndex = 0
        Me.lblHeading01.Text = "Columbus Agency "
        '
        'lblHeading03
        '
        Me.lblHeading03.AutoSize = True
        Me.lblHeading03.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading03.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblHeading03.Location = New System.Drawing.Point(204, 88)
        Me.lblHeading03.Name = "lblHeading03"
        Me.lblHeading03.Size = New System.Drawing.Size(200, 23)
        Me.lblHeading03.TabIndex = 1
        Me.lblHeading03.Text = "Reservation System"
        '
        'lblBookingNumber
        '
        Me.lblBookingNumber.AutoSize = True
        Me.lblBookingNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingNumber.Location = New System.Drawing.Point(51, 141)
        Me.lblBookingNumber.Name = "lblBookingNumber"
        Me.lblBookingNumber.Size = New System.Drawing.Size(157, 14)
        Me.lblBookingNumber.TabIndex = 2
        Me.lblBookingNumber.Text = "Customer Booking Number:"
        '
        'txtBookingNumber
        '
        Me.txtBookingNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingNumber.Location = New System.Drawing.Point(267, 138)
        Me.txtBookingNumber.Name = "txtBookingNumber"
        Me.txtBookingNumber.Size = New System.Drawing.Size(73, 22)
        Me.txtBookingNumber.TabIndex = 3
        '
        'lblWhitewaterClassicNumber
        '
        Me.lblWhitewaterClassicNumber.AutoSize = True
        Me.lblWhitewaterClassicNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhitewaterClassicNumber.Location = New System.Drawing.Point(51, 171)
        Me.lblWhitewaterClassicNumber.Name = "lblWhitewaterClassicNumber"
        Me.lblWhitewaterClassicNumber.Size = New System.Drawing.Size(179, 14)
        Me.lblWhitewaterClassicNumber.TabIndex = 4
        Me.lblWhitewaterClassicNumber.Text = "Number for Whitewater Classic:"
        '
        'txtWhitewaterClassicNumber
        '
        Me.txtWhitewaterClassicNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhitewaterClassicNumber.Location = New System.Drawing.Point(267, 168)
        Me.txtWhitewaterClassicNumber.Name = "txtWhitewaterClassicNumber"
        Me.txtWhitewaterClassicNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtWhitewaterClassicNumber.TabIndex = 5
        '
        'lblZipLineNumber
        '
        Me.lblZipLineNumber.AutoSize = True
        Me.lblZipLineNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipLineNumber.Location = New System.Drawing.Point(51, 233)
        Me.lblZipLineNumber.Name = "lblZipLineNumber"
        Me.lblZipLineNumber.Size = New System.Drawing.Size(119, 14)
        Me.lblZipLineNumber.TabIndex = 6
        Me.lblZipLineNumber.Text = "Number for Zip Line:"
        '
        'txtZipLineNumber
        '
        Me.txtZipLineNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipLineNumber.Location = New System.Drawing.Point(267, 230)
        Me.txtZipLineNumber.Name = "txtZipLineNumber"
        Me.txtZipLineNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtZipLineNumber.TabIndex = 7
        '
        'txtCanopyBoatNumber
        '
        Me.txtCanopyBoatNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCanopyBoatNumber.Location = New System.Drawing.Point(267, 260)
        Me.txtCanopyBoatNumber.Name = "txtCanopyBoatNumber"
        Me.txtCanopyBoatNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtCanopyBoatNumber.TabIndex = 8
        '
        'lblCanopyBoatNumber
        '
        Me.lblCanopyBoatNumber.AutoSize = True
        Me.lblCanopyBoatNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanopyBoatNumber.Location = New System.Drawing.Point(51, 263)
        Me.lblCanopyBoatNumber.Name = "lblCanopyBoatNumber"
        Me.lblCanopyBoatNumber.Size = New System.Drawing.Size(146, 14)
        Me.lblCanopyBoatNumber.TabIndex = 9
        Me.lblCanopyBoatNumber.Text = "Number for Canopy Boat:"
        '
        'lblTaxLabel
        '
        Me.lblTaxLabel.AutoSize = True
        Me.lblTaxLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxLabel.Location = New System.Drawing.Point(51, 311)
        Me.lblTaxLabel.Name = "lblTaxLabel"
        Me.lblTaxLabel.Size = New System.Drawing.Size(31, 14)
        Me.lblTaxLabel.TabIndex = 10
        Me.lblTaxLabel.Text = "Tax:"
        '
        'lblSubTotalLabel
        '
        Me.lblSubTotalLabel.AutoSize = True
        Me.lblSubTotalLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalLabel.Location = New System.Drawing.Point(51, 291)
        Me.lblSubTotalLabel.Name = "lblSubTotalLabel"
        Me.lblSubTotalLabel.Size = New System.Drawing.Size(122, 14)
        Me.lblSubTotalLabel.TabIndex = 11
        Me.lblSubTotalLabel.Text = "Adventure SubTotal:"
        '
        'lblServiceChargeLabel
        '
        Me.lblServiceChargeLabel.AutoSize = True
        Me.lblServiceChargeLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceChargeLabel.Location = New System.Drawing.Point(51, 331)
        Me.lblServiceChargeLabel.Name = "lblServiceChargeLabel"
        Me.lblServiceChargeLabel.Size = New System.Drawing.Size(92, 14)
        Me.lblServiceChargeLabel.TabIndex = 12
        Me.lblServiceChargeLabel.Text = "Service Charge:"
        '
        'lblFinalTotalLabel
        '
        Me.lblFinalTotalLabel.AutoSize = True
        Me.lblFinalTotalLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotalLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblFinalTotalLabel.Location = New System.Drawing.Point(51, 355)
        Me.lblFinalTotalLabel.Name = "lblFinalTotalLabel"
        Me.lblFinalTotalLabel.Size = New System.Drawing.Size(62, 18)
        Me.lblFinalTotalLabel.TabIndex = 13
        Me.lblFinalTotalLabel.Text = "TOTAL:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(264, 291)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(46, 14)
        Me.lblSubTotal.TabIndex = 14
        Me.lblSubTotal.Text = "$88.88"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(264, 311)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(46, 14)
        Me.lblTax.TabIndex = 15
        Me.lblTax.Text = "$88.88"
        '
        'lblServiceCharge
        '
        Me.lblServiceCharge.AutoSize = True
        Me.lblServiceCharge.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharge.Location = New System.Drawing.Point(264, 331)
        Me.lblServiceCharge.Name = "lblServiceCharge"
        Me.lblServiceCharge.Size = New System.Drawing.Size(46, 14)
        Me.lblServiceCharge.TabIndex = 16
        Me.lblServiceCharge.Text = "$88.88"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblFinalTotal.Location = New System.Drawing.Point(264, 355)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(63, 18)
        Me.lblFinalTotal.TabIndex = 17
        Me.lblFinalTotal.Text = "$88.88"
        '
        'lblWhitewaterHighwaterNumber
        '
        Me.lblWhitewaterHighwaterNumber.AutoSize = True
        Me.lblWhitewaterHighwaterNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhitewaterHighwaterNumber.Location = New System.Drawing.Point(51, 202)
        Me.lblWhitewaterHighwaterNumber.Name = "lblWhitewaterHighwaterNumber"
        Me.lblWhitewaterHighwaterNumber.Size = New System.Drawing.Size(197, 19)
        Me.lblWhitewaterHighwaterNumber.TabIndex = 18
        Me.lblWhitewaterHighwaterNumber.Text = "Number for Whitewater Highwater:"
        Me.lblWhitewaterHighwaterNumber.UseCompatibleTextRendering = True
        '
        'txtWhitewaterHighwaterNumber
        '
        Me.txtWhitewaterHighwaterNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhitewaterHighwaterNumber.Location = New System.Drawing.Point(267, 199)
        Me.txtWhitewaterHighwaterNumber.Name = "txtWhitewaterHighwaterNumber"
        Me.txtWhitewaterHighwaterNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtWhitewaterHighwaterNumber.TabIndex = 19
        '
        'btnDisplayInvoice
        '
        Me.btnDisplayInvoice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDisplayInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayInvoice.Location = New System.Drawing.Point(24, 387)
        Me.btnDisplayInvoice.Name = "btnDisplayInvoice"
        Me.btnDisplayInvoice.Size = New System.Drawing.Size(120, 25)
        Me.btnDisplayInvoice.TabIndex = 20
        Me.btnDisplayInvoice.Text = "Display Invoice"
        Me.btnDisplayInvoice.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(156, 387)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 25)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(290, 387)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 25)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.prog1_cp.My.Resources.Resources.White_Water_Rafting_Clipart
        Me.picLogo.Location = New System.Drawing.Point(21, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(138, 118)
        Me.picLogo.TabIndex = 23
        Me.picLogo.TabStop = False
        '
        'lblHeading02
        '
        Me.lblHeading02.AutoSize = True
        Me.lblHeading02.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading02.Location = New System.Drawing.Point(185, 42)
        Me.lblHeading02.Name = "lblHeading02"
        Me.lblHeading02.Size = New System.Drawing.Size(239, 29)
        Me.lblHeading02.TabIndex = 24
        Me.lblHeading02.Text = "for Regional Travel"
        '
        'lblWarning1
        '
        Me.lblWarning1.AutoSize = True
        Me.lblWarning1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning1.ForeColor = System.Drawing.Color.Red
        Me.lblWarning1.Location = New System.Drawing.Point(46, 428)
        Me.lblWarning1.Name = "lblWarning1"
        Me.lblWarning1.Size = New System.Drawing.Size(343, 16)
        Me.lblWarning1.TabIndex = 25
        Me.lblWarning1.Text = "Must enter booking number AND passenger number"
        '
        'lblWarning2
        '
        Me.lblWarning2.AutoSize = True
        Me.lblWarning2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning2.ForeColor = System.Drawing.Color.Red
        Me.lblWarning2.Location = New System.Drawing.Point(124, 445)
        Me.lblWarning2.Name = "lblWarning2"
        Me.lblWarning2.Size = New System.Drawing.Size(186, 16)
        Me.lblWarning2.TabIndex = 26
        Me.lblWarning2.Text = "for at least one adventure!"
        '
        'frmReservationSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 486)
        Me.Controls.Add(Me.lblWarning2)
        Me.Controls.Add(Me.lblWarning1)
        Me.Controls.Add(Me.lblHeading02)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayInvoice)
        Me.Controls.Add(Me.txtWhitewaterHighwaterNumber)
        Me.Controls.Add(Me.lblWhitewaterHighwaterNumber)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblServiceCharge)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblFinalTotalLabel)
        Me.Controls.Add(Me.lblServiceChargeLabel)
        Me.Controls.Add(Me.lblSubTotalLabel)
        Me.Controls.Add(Me.lblTaxLabel)
        Me.Controls.Add(Me.lblCanopyBoatNumber)
        Me.Controls.Add(Me.txtCanopyBoatNumber)
        Me.Controls.Add(Me.txtZipLineNumber)
        Me.Controls.Add(Me.lblZipLineNumber)
        Me.Controls.Add(Me.txtWhitewaterClassicNumber)
        Me.Controls.Add(Me.lblWhitewaterClassicNumber)
        Me.Controls.Add(Me.txtBookingNumber)
        Me.Controls.Add(Me.lblBookingNumber)
        Me.Controls.Add(Me.lblHeading03)
        Me.Controls.Add(Me.lblHeading01)
        Me.Name = "frmReservationSystem"
        Me.Text = "CART Reservation System"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading01 As System.Windows.Forms.Label
    Friend WithEvents lblHeading03 As System.Windows.Forms.Label
    Friend WithEvents lblBookingNumber As System.Windows.Forms.Label
    Friend WithEvents txtBookingNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblWhitewaterClassicNumber As System.Windows.Forms.Label
    Friend WithEvents txtWhitewaterClassicNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblZipLineNumber As System.Windows.Forms.Label
    Friend WithEvents txtZipLineNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCanopyBoatNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCanopyBoatNumber As System.Windows.Forms.Label
    Friend WithEvents lblTaxLabel As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblServiceChargeLabel As System.Windows.Forms.Label
    Friend WithEvents lblFinalTotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblServiceCharge As System.Windows.Forms.Label
    Friend WithEvents lblFinalTotal As System.Windows.Forms.Label
    Friend WithEvents lblWhitewaterHighwaterNumber As System.Windows.Forms.Label
    Friend WithEvents txtWhitewaterHighwaterNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayInvoice As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeading02 As System.Windows.Forms.Label
    Friend WithEvents lblWarning1 As System.Windows.Forms.Label
    Friend WithEvents lblWarning2 As System.Windows.Forms.Label

End Class
