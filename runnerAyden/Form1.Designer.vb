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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtRun3 = New System.Windows.Forms.TextBox()
        Me.txtRun2 = New System.Windows.Forms.TextBox()
        Me.txtRun1 = New System.Windows.Forms.TextBox()
        Me.lblRun3 = New System.Windows.Forms.Label()
        Me.lblRun2 = New System.Windows.Forms.Label()
        Me.lblRun1 = New System.Windows.Forms.Label()
        Me.lblRaceTimes = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(339, 172)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(132, 20)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "Total Race Time: "
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(339, 94)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(205, 37)
        Me.btnTotal.TabIndex = 16
        Me.btnTotal.Text = "Calculate Total Race Time"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'txtRun3
        '
        Me.txtRun3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRun3.Location = New System.Drawing.Point(154, 172)
        Me.txtRun3.Name = "txtRun3"
        Me.txtRun3.Size = New System.Drawing.Size(100, 26)
        Me.txtRun3.TabIndex = 15
        '
        'txtRun2
        '
        Me.txtRun2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRun2.Location = New System.Drawing.Point(154, 133)
        Me.txtRun2.Name = "txtRun2"
        Me.txtRun2.Size = New System.Drawing.Size(100, 26)
        Me.txtRun2.TabIndex = 14
        '
        'txtRun1
        '
        Me.txtRun1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRun1.Location = New System.Drawing.Point(154, 94)
        Me.txtRun1.Name = "txtRun1"
        Me.txtRun1.Size = New System.Drawing.Size(100, 26)
        Me.txtRun1.TabIndex = 13
        '
        'lblRun3
        '
        Me.lblRun3.AutoSize = True
        Me.lblRun3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRun3.Location = New System.Drawing.Point(32, 172)
        Me.lblRun3.Name = "lblRun3"
        Me.lblRun3.Size = New System.Drawing.Size(75, 20)
        Me.lblRun3.TabIndex = 12
        Me.lblRun3.Text = "Runner 3"
        '
        'lblRun2
        '
        Me.lblRun2.AutoSize = True
        Me.lblRun2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRun2.Location = New System.Drawing.Point(32, 133)
        Me.lblRun2.Name = "lblRun2"
        Me.lblRun2.Size = New System.Drawing.Size(75, 20)
        Me.lblRun2.TabIndex = 11
        Me.lblRun2.Text = "Runner 2"
        '
        'lblRun1
        '
        Me.lblRun1.AutoSize = True
        Me.lblRun1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRun1.Location = New System.Drawing.Point(32, 94)
        Me.lblRun1.Name = "lblRun1"
        Me.lblRun1.Size = New System.Drawing.Size(75, 20)
        Me.lblRun1.TabIndex = 10
        Me.lblRun1.Text = "Runner 1"
        '
        'lblRaceTimes
        '
        Me.lblRaceTimes.AutoSize = True
        Me.lblRaceTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaceTimes.Location = New System.Drawing.Point(12, 9)
        Me.lblRaceTimes.Name = "lblRaceTimes"
        Me.lblRaceTimes.Size = New System.Drawing.Size(159, 31)
        Me.lblRaceTimes.TabIndex = 9
        Me.lblRaceTimes.Text = "Race Times"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(12, 423)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(0, 13)
        Me.lblMin.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 445)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtRun3)
        Me.Controls.Add(Me.txtRun2)
        Me.Controls.Add(Me.txtRun1)
        Me.Controls.Add(Me.lblRun3)
        Me.Controls.Add(Me.lblRun2)
        Me.Controls.Add(Me.lblRun1)
        Me.Controls.Add(Me.lblRaceTimes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents txtRun3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRun2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRun1 As System.Windows.Forms.TextBox
    Friend WithEvents lblRun3 As System.Windows.Forms.Label
    Friend WithEvents lblRun2 As System.Windows.Forms.Label
    Friend WithEvents lblRun1 As System.Windows.Forms.Label
    Friend WithEvents lblRaceTimes As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label

End Class
