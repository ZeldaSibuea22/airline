﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aircraft
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AirlineName1 = New System.Windows.Forms.ComboBox()
        Me.SearchByName = New System.Windows.Forms.Label()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.EconomyClassSeats = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BusinessClassSeats = New System.Windows.Forms.TextBox()
        Me.FirstClassSeats = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AirlineName = New System.Windows.Forms.TextBox()
        Me.AircraftTypeId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(525, 615)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1113, 454)
        Me.DataGridView1.TabIndex = 84
        '
        'AirlineName1
        '
        Me.AirlineName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AirlineName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AirlineName1.FormattingEnabled = True
        Me.AirlineName1.Location = New System.Drawing.Point(242, 671)
        Me.AirlineName1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AirlineName1.Name = "AirlineName1"
        Me.AirlineName1.Size = New System.Drawing.Size(240, 28)
        Me.AirlineName1.TabIndex = 72
        '
        'SearchByName
        '
        Me.SearchByName.AutoSize = True
        Me.SearchByName.BackColor = System.Drawing.Color.Transparent
        Me.SearchByName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByName.ForeColor = System.Drawing.Color.Black
        Me.SearchByName.Location = New System.Drawing.Point(236, 615)
        Me.SearchByName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchByName.Name = "SearchByName"
        Me.SearchByName.Size = New System.Drawing.Size(276, 32)
        Me.SearchByName.TabIndex = 83
        Me.SearchByName.Text = "Search By Airline Name"
        '
        'NewRecord
        '
        Me.NewRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.ImageKey = "(none)"
        Me.NewRecord.Location = New System.Drawing.Point(1668, 68)
        Me.NewRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(144, 72)
        Me.NewRecord.TabIndex = 76
        Me.NewRecord.Tag = ""
        Me.NewRecord.Text = "New"
        Me.NewRecord.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1668, 540)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 78)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Get Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Edit.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Location = New System.Drawing.Point(1668, 420)
        Me.Edit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(144, 75)
        Me.Edit.TabIndex = 79
        Me.Edit.Text = "Update"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Delete.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(1668, 298)
        Me.Delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(144, 75)
        Me.Delete.TabIndex = 78
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Add.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(1668, 186)
        Me.Add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(144, 74)
        Me.Add.TabIndex = 77
        Me.Add.Text = "Save"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(842, 140)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 43)
        Me.Cancel.TabIndex = 75
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Submit.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(693, 140)
        Me.Submit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(123, 43)
        Me.Submit.TabIndex = 73
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'EconomyClassSeats
        '
        Me.EconomyClassSeats.Location = New System.Drawing.Point(207, 228)
        Me.EconomyClassSeats.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EconomyClassSeats.Name = "EconomyClassSeats"
        Me.EconomyClassSeats.Size = New System.Drawing.Size(211, 30)
        Me.EconomyClassSeats.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EconomyClassSeats)
        Me.GroupBox1.Controls.Add(Me.BusinessClassSeats)
        Me.GroupBox1.Controls.Add(Me.FirstClassSeats)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(226, 280)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(447, 289)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seats"
        '
        'BusinessClassSeats
        '
        Me.BusinessClassSeats.Location = New System.Drawing.Point(207, 142)
        Me.BusinessClassSeats.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BusinessClassSeats.Name = "BusinessClassSeats"
        Me.BusinessClassSeats.Size = New System.Drawing.Size(211, 30)
        Me.BusinessClassSeats.TabIndex = 2
        '
        'FirstClassSeats
        '
        Me.FirstClassSeats.Location = New System.Drawing.Point(207, 60)
        Me.FirstClassSeats.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FirstClassSeats.Name = "FirstClassSeats"
        Me.FirstClassSeats.Size = New System.Drawing.Size(211, 30)
        Me.FirstClassSeats.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Business Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Economy Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 222)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Airline Name"
        '
        'AirlineName
        '
        Me.AirlineName.Location = New System.Drawing.Point(434, 215)
        Me.AirlineName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AirlineName.Multiline = True
        Me.AirlineName.Name = "AirlineName"
        Me.AirlineName.Size = New System.Drawing.Size(211, 38)
        Me.AirlineName.TabIndex = 69
        '
        'AircraftTypeId
        '
        Me.AircraftTypeId.Location = New System.Drawing.Point(434, 140)
        Me.AircraftTypeId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AircraftTypeId.Multiline = True
        Me.AircraftTypeId.Name = "AircraftTypeId"
        Me.AircraftTypeId.Size = New System.Drawing.Size(211, 41)
        Me.AircraftTypeId.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 149)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Aircraft Type ID"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1668, 669)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 74)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(851, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 74)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "ADD AIRCRAFT"
        '
        'Aircraft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AirlineName1)
        Me.Controls.Add(Me.SearchByName)
        Me.Controls.Add(Me.NewRecord)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AirlineName)
        Me.Controls.Add(Me.AircraftTypeId)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Aircraft"
        Me.Text = "Aircraft"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AirlineName1 As System.Windows.Forms.ComboBox
    Private WithEvents SearchByName As System.Windows.Forms.Label
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents EconomyClassSeats As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BusinessClassSeats As System.Windows.Forms.TextBox
    Friend WithEvents FirstClassSeats As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AirlineName As System.Windows.Forms.TextBox
    Friend WithEvents AircraftTypeId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
