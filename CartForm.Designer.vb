﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartForm
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
        Panel1 = New Panel()
        btn_addtpcart = New Button()
        Label1 = New Label()
        lbl_totalprice = New Label()
        cart_panel = New FlowLayoutPanel()
        btn_buy = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SpringGreen
        Panel1.Controls.Add(btn_addtpcart)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(482, 55)
        Panel1.TabIndex = 1
        ' 
        ' btn_addtpcart
        ' 
        btn_addtpcart.BackColor = Color.White
        btn_addtpcart.Cursor = Cursors.Hand
        btn_addtpcart.FlatStyle = FlatStyle.Flat
        btn_addtpcart.Font = New Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_addtpcart.ForeColor = Color.Black
        btn_addtpcart.Location = New Point(814, 11)
        btn_addtpcart.Name = "btn_addtpcart"
        btn_addtpcart.Size = New Size(75, 34)
        btn_addtpcart.TabIndex = 1
        btn_addtpcart.Text = "CART"
        btn_addtpcart.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 24)
        Label1.TabIndex = 0
        Label1.Text = "Carts"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_totalprice
        ' 
        lbl_totalprice.AutoSize = True
        lbl_totalprice.BackColor = Color.Transparent
        lbl_totalprice.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_totalprice.ForeColor = Color.Black
        lbl_totalprice.Location = New Point(12, 530)
        lbl_totalprice.Name = "lbl_totalprice"
        lbl_totalprice.Size = New Size(70, 22)
        lbl_totalprice.TabIndex = 3
        lbl_totalprice.Text = "TOTAL:"
        lbl_totalprice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cart_panel
        ' 
        cart_panel.AutoScroll = True
        cart_panel.FlowDirection = FlowDirection.TopDown
        cart_panel.Location = New Point(12, 77)
        cart_panel.Name = "cart_panel"
        cart_panel.Size = New Size(400, 422)
        cart_panel.TabIndex = 2
        cart_panel.WrapContents = False
        ' 
        ' btn_buy
        ' 
        btn_buy.BackColor = Color.LightGreen
        btn_buy.Cursor = Cursors.Hand
        btn_buy.FlatStyle = FlatStyle.Flat
        btn_buy.Font = New Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_buy.Location = New Point(384, 519)
        btn_buy.Name = "btn_buy"
        btn_buy.Size = New Size(75, 33)
        btn_buy.TabIndex = 4
        btn_buy.Text = "BUY"
        btn_buy.UseVisualStyleBackColor = False
        ' 
        ' CartForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(484, 570)
        Controls.Add(btn_buy)
        Controls.Add(lbl_totalprice)
        Controls.Add(cart_panel)
        Controls.Add(Panel1)
        Name = "CartForm"
        Text = "Carts"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_addtpcart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cart_panel As FlowLayoutPanel
    Friend WithEvents lbl_totalprice As Label
    Friend WithEvents btn_buy As Button
End Class
