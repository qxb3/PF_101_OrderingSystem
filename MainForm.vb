Public Class MainForm
    Dim cart As New List(Of CartItem)
    Private Sub btn_addtpcart_Click(sender As Object, e As EventArgs) Handles btn_addtpcart.Click
        Dim cartForm As New CartForm(cart)
        cartForm.Show()
    End Sub

    Private Sub atc_keyboard_Click(sender As Object, e As EventArgs) Handles atc_keyboard.Click
        Dim name = "Keyboard"
        Dim price = 780.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_keyboard.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_monitor_Click(sender As Object, e As EventArgs) Handles atc_monitor.Click
        Dim name = "Monitor"
        Dim price = 3500.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = Name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = Name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_monitor.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_mouse_Click(sender As Object, e As EventArgs) Handles atc_mouse.Click
        Dim name = "Mouse"
        Dim price = 560.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_mouse.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_hdmi_Click(sender As Object, e As EventArgs) Handles atc_hdmi.Click
        Dim name = "HDMI Cable"
        Dim price = 230.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_hdmi.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_usb_Click(sender As Object, e As EventArgs) Handles atc_usb.Click
        Dim name = "USB Stick"
        Dim price = 120.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_usb.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_harddrive_Click(sender As Object, e As EventArgs) Handles atc_harddrive.Click
        Dim name = "Hard Drive"
        Dim price = 600.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_harddrive.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_headphone_Click(sender As Object, e As EventArgs) Handles atc_headphone.Click
        Dim name = "Headphone"
        Dim price = 120.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_headphone.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_webcam_Click(sender As Object, e As EventArgs) Handles atc_webcam.Click
        Dim name = "Webcam"
        Dim price = 450.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_webcam.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub

    Private Sub atc_ram_Click(sender As Object, e As EventArgs) Handles atc_ram.Click
        Dim name = "RAM"
        Dim price = 580.0

        Dim existingItemIndex As Integer = cart.FindIndex(Function(ci) ci.Name = name)
        Dim existingItem As CartItem = cart.Find(Function(ci) ci.Name = name)

        If existingItem Is Nothing Then
            cart.Add(New CartItem(name, price, pic_ram.Image))
        Else
            existingItem.Count += 1
            cart(existingItemIndex) = existingItem
        End If

        MsgBox("Added to cart!", MsgBoxStyle.Information, "Cart")
    End Sub
End Class

Public Class CartItem
    Public Name As String
    Public Price As Double
    Public Image As Image
    Public Count As Integer
    Public Sub New(ByVal _name As String, ByVal _price As Double, ByVal _image As Image)
        Name = _name
        Price = _price
        Image = _image
        Count = 1
    End Sub
End Class