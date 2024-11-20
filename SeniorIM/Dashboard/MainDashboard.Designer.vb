<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboard))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnMainDashboard = New Button()
        btnRegisteredUser = New Button()
        btnBaranggay = New Button()
        btnGraph = New Button()
        btnAccount = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Label1 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(btnMainDashboard)
        FlowLayoutPanel1.Controls.Add(btnRegisteredUser)
        FlowLayoutPanel1.Controls.Add(btnBaranggay)
        FlowLayoutPanel1.Controls.Add(btnGraph)
        FlowLayoutPanel1.Controls.Add(btnAccount)
        FlowLayoutPanel1.Dock = DockStyle.Left
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(150, 450)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources._1
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 141)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(3, 150)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(143, 32)
        Panel1.TabIndex = 1
        ' 
        ' btnMainDashboard
        ' 
        btnMainDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnMainDashboard.FlatAppearance.BorderSize = 0
        btnMainDashboard.FlatStyle = FlatStyle.Flat
        btnMainDashboard.Image = My.Resources.Resources.collage
        btnMainDashboard.Location = New Point(3, 188)
        btnMainDashboard.Name = "btnMainDashboard"
        btnMainDashboard.Size = New Size(143, 51)
        btnMainDashboard.TabIndex = 2
        btnMainDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnRegisteredUser
        ' 
        btnRegisteredUser.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnRegisteredUser.FlatAppearance.BorderSize = 0
        btnRegisteredUser.FlatStyle = FlatStyle.Flat
        btnRegisteredUser.Image = CType(resources.GetObject("btnRegisteredUser.Image"), Image)
        btnRegisteredUser.Location = New Point(3, 245)
        btnRegisteredUser.Name = "btnRegisteredUser"
        btnRegisteredUser.Size = New Size(143, 51)
        btnRegisteredUser.TabIndex = 2
        btnRegisteredUser.UseVisualStyleBackColor = True
        ' 
        ' btnBaranggay
        ' 
        btnBaranggay.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnBaranggay.FlatAppearance.BorderSize = 0
        btnBaranggay.FlatStyle = FlatStyle.Flat
        btnBaranggay.Image = CType(resources.GetObject("btnBaranggay.Image"), Image)
        btnBaranggay.Location = New Point(3, 302)
        btnBaranggay.Name = "btnBaranggay"
        btnBaranggay.Size = New Size(143, 51)
        btnBaranggay.TabIndex = 2
        btnBaranggay.UseVisualStyleBackColor = True
        ' 
        ' btnGraph
        ' 
        btnGraph.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnGraph.FlatAppearance.BorderSize = 0
        btnGraph.FlatStyle = FlatStyle.Flat
        btnGraph.Image = My.Resources.Resources.line_chart
        btnGraph.Location = New Point(3, 359)
        btnGraph.Name = "btnGraph"
        btnGraph.Size = New Size(143, 51)
        btnGraph.TabIndex = 2
        btnGraph.UseVisualStyleBackColor = True
        ' 
        ' btnAccount
        ' 
        btnAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnAccount.FlatAppearance.BorderSize = 0
        btnAccount.FlatStyle = FlatStyle.Flat
        btnAccount.Image = My.Resources.Resources.account
        btnAccount.Location = New Point(3, 416)
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(143, 51)
        btnAccount.TabIndex = 2
        btnAccount.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(Panel3, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel4, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel5, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel6, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel7, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel8, 1, 2)
        TableLayoutPanel1.Controls.Add(Panel9, 2, 2)
        TableLayoutPanel1.Controls.Add(Panel10, 2, 1)
        TableLayoutPanel1.Location = New Point(191, 147)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(525, 230)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(169, 70)
        Panel3.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(353, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(169, 70)
        Panel2.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.White
        Panel4.Location = New Point(178, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(169, 70)
        Panel4.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = Color.White
        Panel5.Location = New Point(178, 79)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(169, 70)
        Panel5.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel6.BackColor = Color.White
        Panel6.Location = New Point(3, 79)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(169, 70)
        Panel6.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel7.BackColor = Color.White
        Panel7.Location = New Point(3, 155)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(169, 72)
        Panel7.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel8.BackColor = Color.White
        Panel8.Location = New Point(178, 155)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(169, 72)
        Panel8.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.White
        Panel9.Location = New Point(353, 155)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(169, 72)
        Panel9.TabIndex = 0
        ' 
        ' Panel10
        ' 
        Panel10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel10.BackColor = Color.White
        Panel10.Location = New Point(353, 79)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(169, 70)
        Panel10.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(171, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 113)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        ' 
        ' MainDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(FlowLayoutPanel1)
        Name = "MainDashboard"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMainDashboard As Button
    Friend WithEvents btnRegisteredUser As Button
    Friend WithEvents btnBaranggay As Button
    Friend WithEvents btnGraph As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
End Class
