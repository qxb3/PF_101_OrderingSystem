Imports System.Drawing.Printing
Imports System.Drawing.Text

Public Class CartForm
    Public cart As List(Of CartItem)
    Dim totalPrice As Double
    Public Sub New(ByVal _cart As List(Of CartItem))
        InitializeComponent()

        cart = _cart
    End Sub
    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In cart
            totalPrice += item.Price

            Dim mainPanel As New FlowLayoutPanel()
            mainPanel.FlowDirection = FlowDirection.LeftToRight
            mainPanel.BackColor = Color.White
            mainPanel.Width = 378
            mainPanel.Padding = New Padding(10)

            Dim image As New PictureBox()
            image.Image = item.Image
            image.SizeMode = PictureBoxSizeMode.Zoom
            image.Size = New Size(80, 80)
            image.Margin = New Padding(0, 0, 0, 100)

            Dim detailsPanel As New FlowLayoutPanel()
            detailsPanel.FlowDirection = FlowDirection.TopDown
            detailsPanel.Margin = New Padding(10, 15, 0, 15)

            Dim name_font As New Font("Consolas", 14, FontStyle.Bold)
            Dim name As New Label()
            name.Text = item.Name & " x" & item.Count
            name.Font = Font

            Dim price_font As New Font("Consolas", 10, FontStyle.Italic)
            Dim price As New Label()
            price.Text = "₱ " & item.Price * item.Count & ".00"
            price.Font = price_font

            detailsPanel.Controls.Add(name)
            detailsPanel.Controls.Add(price)

            mainPanel.Controls.Add(image)
            mainPanel.Controls.Add(detailsPanel)

            cart_panel.Controls.Add(mainPanel)
        Next

        lbl_totalprice.Text = "TOTAL: ₱ " & totalPrice & ".00"
    End Sub

    Private Sub btn_buy_Click(sender As Object, e As EventArgs) Handles btn_buy.Click
        Dim receiptForm As New ReceiptForm(cart)
        receiptForm.Show()
    End Sub
End Class