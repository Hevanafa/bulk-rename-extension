<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lsbFiles = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbNewExtension = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lsbFiles
        '
        Me.lsbFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lsbFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsbFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lsbFiles.FormattingEnabled = True
        Me.lsbFiles.HorizontalScrollbar = True
        Me.lsbFiles.ItemHeight = 16
        Me.lsbFiles.Location = New System.Drawing.Point(10, 35)
        Me.lsbFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lsbFiles.Name = "lsbFiles"
        Me.lsbFiles.ScrollAlwaysVisible = True
        Me.lsbFiles.Size = New System.Drawing.Size(465, 258)
        Me.lsbFiles.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Files to rename"
        '
        'txbNewExtension
        '
        Me.txbNewExtension.BackColor = System.Drawing.Color.Black
        Me.txbNewExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbNewExtension.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txbNewExtension.Location = New System.Drawing.Point(10, 330)
        Me.txbNewExtension.Name = "txbNewExtension"
        Me.txbNewExtension.Size = New System.Drawing.Size(100, 23)
        Me.txbNewExtension.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New extension"
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnApply.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.Black
        Me.btnApply.Location = New System.Drawing.Point(360, 295)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(115, 58)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "webp"
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.Location = New System.Drawing.Point(165, 110)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(161, 99)
        Me.lblHint.TabIndex = 6
        Me.lblHint.Text = "Drag & drop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblHint.UseMnemonic = False
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BackgroundImage = Global.BulkRenameExtension.My.Resources.Resources.hevanafa_subtle_purple_ambience_with_stars_shrunk
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbNewExtension)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsbFiles)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Bulk Extension Rename - By Hevanafa (Aug 2023)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsbFiles As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbNewExtension As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHint As Label
End Class
