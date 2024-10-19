<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFitness
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        lblAverageLoss = New Label()
        lstWeightLoss = New ListBox()
        btnEnterWeight = New Button()
        lblTitle = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(867, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuClear, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "&File"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(101, 22)
        mnuClear.Text = "&Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(101, 22)
        mnuExit.Text = "E&xit"
        ' 
        ' lblAverageLoss
        ' 
        lblAverageLoss.AutoSize = True
        lblAverageLoss.BackColor = Color.YellowGreen
        lblAverageLoss.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAverageLoss.Location = New Point(460, 393)
        lblAverageLoss.Name = "lblAverageLoss"
        lblAverageLoss.Size = New Size(401, 29)
        lblAverageLoss.TabIndex = 7
        lblAverageLoss.Text = "Average Weight Loss is XX.X lbs." & vbCrLf
        lblAverageLoss.Visible = False
        ' 
        ' lstWeightLoss
        ' 
        lstWeightLoss.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstWeightLoss.FormattingEnabled = True
        lstWeightLoss.ItemHeight = 23
        lstWeightLoss.Location = New Point(635, 192)
        lstWeightLoss.Name = "lstWeightLoss"
        lstWeightLoss.RightToLeft = RightToLeft.Yes
        lstWeightLoss.Size = New Size(50, 188)
        lstWeightLoss.TabIndex = 6
        ' 
        ' btnEnterWeight
        ' 
        btnEnterWeight.BackColor = Color.YellowGreen
        btnEnterWeight.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnterWeight.Location = New Point(563, 139)
        btnEnterWeight.Name = "btnEnterWeight"
        btnEnterWeight.Size = New Size(194, 35)
        btnEnterWeight.TabIndex = 5
        btnEnterWeight.Text = "Enter Weight Loss"
        btnEnterWeight.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(465, 36)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(390, 84)
        lblTitle.TabIndex = 4
        lblTitle.Text = "FITNESS CHALLENGE" & vbCrLf & "TEAM WEIGHT LOSS" & vbCrLf
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmFitness
        ' 
        AcceptButton = btnEnterWeight
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Health
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(867, 438)
        Controls.Add(lblAverageLoss)
        Controls.Add(lstWeightLoss)
        Controls.Add(btnEnterWeight)
        Controls.Add(lblTitle)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmFitness"
        Text = "Fitness Challenge"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblAverageLoss As Label
    Friend WithEvents lstWeightLoss As ListBox
    Friend WithEvents btnEnterWeight As Button
    Friend WithEvents lblTitle As Label

End Class
