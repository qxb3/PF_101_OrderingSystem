Imports System.Drawing.Printing

Public Class Form2
    Public cart As List(Of CartItem)
    Public Sub New(ByVal _me As Form1)
        InitializeComponent()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In cart
            Dim mainPanel As New FlowLayoutPanel()
            mainPanel.FlowDirection = RightToLeft
            mainPanel.BackColor = Color.White
            mainPanel.Width = 378

            Dim image As New PictureBox()
            image.Image = item.Image
            image.SizeMode = PictureBoxSizeMode.Zoom
            image.Size = New Size(100, 100)
            image.Margin = New Padding(8, 8, 8, 8)

            Dim name As New Label()
            name.Text = item.Name

            mainPanel.Controls.Add(image)
            mainPanel.Controls.Add(name)

            cart_panel.Controls.Add(mainPanel)
        Next
    End Sub
End Class