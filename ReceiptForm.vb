Public Class ReceiptForm
    Dim cart As New List(Of CartItem)
    Dim totalPrice As Double
    Public Sub New(ByVal _cart As List(Of CartItem))
        InitializeComponent()

        cart = _cart
    End Sub
    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim finalReceipt As String = ""

        For Each item In cart
            totalPrice += item.Price

            finalReceipt += item.Name & " x" & item.Count & ".00" & vbCrLf
        Next

        lbl_receipt.Text = finalReceipt
        lbl_total.Text = "TOTAL: ₱ " & totalPrice & ".00"
    End Sub

End Class