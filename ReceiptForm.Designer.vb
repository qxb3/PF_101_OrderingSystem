<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptForm
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
        dawidawdwa = New Label()
        lbl_receipt = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lbl_total = New Label()
        SuspendLayout()
        ' 
        ' dawidawdwa
        ' 
        dawidawdwa.AutoSize = True
        dawidawdwa.Font = New Font("Castellar", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dawidawdwa.Location = New Point(82, 43)
        dawidawdwa.Name = "dawidawdwa"
        dawidawdwa.Size = New Size(104, 25)
        dawidawdwa.TabIndex = 0
        dawidawdwa.Text = "receipt"
        dawidawdwa.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_receipt
        ' 
        lbl_receipt.Font = New Font("Castellar", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_receipt.Location = New Point(0, 134)
        lbl_receipt.Name = "lbl_receipt"
        lbl_receipt.Size = New Size(273, 200)
        lbl_receipt.TabIndex = 1
        lbl_receipt.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Castellar", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 415)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 19)
        Label1.TabIndex = 2
        Label1.Text = "thank you for shopping"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Castellar", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(273, 16)
        Label2.TabIndex = 3
        Label2.Text = "--------------------------------------"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Castellar", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(0, 390)
        Label3.Name = "Label3"
        Label3.Size = New Size(273, 16)
        Label3.TabIndex = 4
        Label3.Text = "--------------------------------------"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Font = New Font("Castellar", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_total.Location = New Point(7, 359)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(74, 19)
        lbl_total.TabIndex = 5
        lbl_total.Text = "TOTAL:"
        lbl_total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ReceiptForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(274, 470)
        Controls.Add(lbl_total)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_receipt)
        Controls.Add(dawidawdwa)
        Name = "ReceiptForm"
        Text = "Receipt"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dawidawdwa As Label
    Friend WithEvents lbl_receipt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_total As Label
End Class
