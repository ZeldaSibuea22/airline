﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_cancle_ticket
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
        Me.txtPrint = New System.Windows.Forms.RichTextBox()
        Me.prndocPrintTicket = New System.Drawing.Printing.PrintDocument()
        Me.prndlgPrintTicket = New System.Windows.Forms.PrintDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrint
        '
        Me.txtPrint.Location = New System.Drawing.Point(330, 188)
        Me.txtPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.Size = New System.Drawing.Size(1072, 567)
        Me.txtPrint.TabIndex = 9
        Me.txtPrint.Text = ""
        '
        'prndocPrintTicket
        '
        '
        'prndlgPrintTicket
        '
        Me.prndlgPrintTicket.Document = Me.prndocPrintTicket
        Me.prndlgPrintTicket.UseEXDialog = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1112, 834)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 48)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(771, 834)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(663, 62)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(550, 85)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "CANCLE TICKET PRINT"
        '
        'print_cancle_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPrint)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "print_cancle_ticket"
        Me.Text = "print_cancle_ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrint As System.Windows.Forms.RichTextBox
    Friend WithEvents prndocPrintTicket As System.Drawing.Printing.PrintDocument
    Friend WithEvents prndlgPrintTicket As System.Windows.Forms.PrintDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
