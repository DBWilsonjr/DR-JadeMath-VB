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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label01 = New System.Windows.Forms.Label()
        Me.Label02 = New System.Windows.Forms.Label()
        Me.cmbStart = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbFin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbJade = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOwn = New System.Windows.Forms.ComboBox()
        Me.lblReq = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(224, 167)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label01
        '
        Me.Label01.AutoSize = True
        Me.Label01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label01.Location = New System.Drawing.Point(27, 210)
        Me.Label01.Name = "Label01"
        Me.Label01.Size = New System.Drawing.Size(154, 20)
        Me.Label01.TabIndex = 1
        Me.Label01.Text = "Lv 3 Jade Required: "
        '
        'Label02
        '
        Me.Label02.AutoSize = True
        Me.Label02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label02.Location = New System.Drawing.Point(27, 247)
        Me.Label02.Name = "Label02"
        Me.Label02.Size = New System.Drawing.Size(127, 20)
        Me.Label02.TabIndex = 2
        Me.Label02.Text = "Guild Coin Cost: "
        '
        'cmbStart
        '
        Me.cmbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStart.FormattingEnabled = True
        Me.cmbStart.Items.AddRange(New Object() {"0", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbStart.Location = New System.Drawing.Point(238, 55)
        Me.cmbStart.Name = "cmbStart"
        Me.cmbStart.Size = New System.Drawing.Size(44, 21)
        Me.cmbStart.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Starting Jade level:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Desired Jade level:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbFin
        '
        Me.cmbFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFin.FormattingEnabled = True
        Me.cmbFin.Location = New System.Drawing.Point(238, 117)
        Me.cmbFin.Name = "cmbFin"
        Me.cmbFin.Size = New System.Drawing.Size(44, 21)
        Me.cmbFin.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Select Jade Type:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbJade
        '
        Me.cmbJade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJade.FormattingEnabled = True
        Me.cmbJade.Items.AddRange(New Object() {"Life", "Armor", "HIt", "Attack", "Crit Rate", "Crit Dam", "True Dam", "Speed"})
        Me.cmbJade.Location = New System.Drawing.Point(214, 24)
        Me.cmbJade.Name = "cmbJade"
        Me.cmbJade.Size = New System.Drawing.Size(68, 21)
        Me.cmbJade.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Starting Jade owned:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbOwn
        '
        Me.cmbOwn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOwn.FormattingEnabled = True
        Me.cmbOwn.Items.AddRange(New Object() {"0", "1", "2"})
        Me.cmbOwn.Location = New System.Drawing.Point(238, 86)
        Me.cmbOwn.Name = "cmbOwn"
        Me.cmbOwn.Size = New System.Drawing.Size(44, 21)
        Me.cmbOwn.TabIndex = 9
        '
        'lblReq
        '
        Me.lblReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblReq.Location = New System.Drawing.Point(224, 210)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(81, 23)
        Me.lblReq.TabIndex = 11
        Me.lblReq.Text = "Waiting..."
        Me.lblReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbJade)
        Me.GroupBox1.Controls.Add(Me.cmbStart)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbOwn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbFin)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 149)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dungeon Rush Jade"
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblCost.Location = New System.Drawing.Point(224, 247)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(81, 22)
        Me.lblCost.TabIndex = 13
        Me.lblCost.Text = "Waiting..."
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 281)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblReq)
        Me.Controls.Add(Me.Label02)
        Me.Controls.Add(Me.Label01)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "How Many Jades?"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents Label01 As System.Windows.Forms.Label
    Friend WithEvents Label02 As System.Windows.Forms.Label
    Friend WithEvents cmbStart As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbFin As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbJade As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbOwn As System.Windows.Forms.ComboBox
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCost As System.Windows.Forms.Label

End Class
