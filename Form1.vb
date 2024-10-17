Public Class Form1
    Dim cart As New List(Of CartItem)
    Dim cartForm As New Form2(Me)
    Private Sub btn_addtpcart_Click(sender As Object, e As EventArgs) Handles btn_addtpcart.Click
        cartForm.cart = cart
        cartForm.Show()
        Me.Hide()
    End Sub

    Private Sub atc_keyboard_Click(sender As Object, e As EventArgs) Handles atc_keyboard.Click
        cart.Add(New CartItem("Keyboard", 780.0, pic_keyboard.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_monitor_Click(sender As Object, e As EventArgs) Handles atc_monitor.Click
        cart.Add(New CartItem("Monitor", 3500.0, pic_monitor.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_mouse_Click(sender As Object, e As EventArgs) Handles atc_mouse.Click
        cart.Add(New CartItem("Mouse", 560.0, pic_mouse.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_hdmi_Click(sender As Object, e As EventArgs) Handles atc_hdmi.Click
        cart.Add(New CartItem("HDMI Cable", 230.0, pic_hdmi.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_usb_Click(sender As Object, e As EventArgs) Handles atc_usb.Click
        cart.Add(New CartItem("USB Stick", 120.0, pic_usb.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_harddrive_Click(sender As Object, e As EventArgs) Handles atc_harddrive.Click
        cart.Add(New CartItem("Hard Drive", 600.0, pic_harddrive.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_headphone_Click(sender As Object, e As EventArgs) Handles atc_headphone.Click
        cart.Add(New CartItem("Headphone", 120.0, pic_headphone.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_webcam_Click(sender As Object, e As EventArgs) Handles atc_webcam.Click
        cart.Add(New CartItem("Webcam", 450.0, pic_webcam.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_ram_Click(sender As Object, e As EventArgs) Handles atc_ram.Click
        cart.Add(New CartItem("RAM", 580.0, pic_ram.Image))
        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub
End Class

Public Class CartItem
    Public Name As String
    Public Price As Double
    Public Image As Image
    Public Sub New(ByVal _name As String, ByVal _price As Double, ByVal _image As Image)
        Name = _name
        Price = _price
        Image = _image
    End Sub
End Class