<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductsMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuppliersMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryOfItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BadOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupAndRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AuditTrailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoguotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblID = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblName = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMaintenanceToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.UtilitiesToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LoguotToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMaintenanceToolStripMenuItem
        '
        Me.FileMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsMaintenanceToolStripMenuItem, Me.SuppliersMaintenanceToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.DeliveryOfItemsToolStripMenuItem})
        Me.FileMaintenanceToolStripMenuItem.Name = "FileMaintenanceToolStripMenuItem"
        Me.FileMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.FileMaintenanceToolStripMenuItem.Text = "File Maintenance"
        '
        'ProductsMaintenanceToolStripMenuItem
        '
        Me.ProductsMaintenanceToolStripMenuItem.Name = "ProductsMaintenanceToolStripMenuItem"
        Me.ProductsMaintenanceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ProductsMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ProductsMaintenanceToolStripMenuItem.Text = "Products Maintenance"
        '
        'SuppliersMaintenanceToolStripMenuItem
        '
        Me.SuppliersMaintenanceToolStripMenuItem.Name = "SuppliersMaintenanceToolStripMenuItem"
        Me.SuppliersMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SuppliersMaintenanceToolStripMenuItem.Text = "Suppliers Maintenance "
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'DeliveryOfItemsToolStripMenuItem
        '
        Me.DeliveryOfItemsToolStripMenuItem.Name = "DeliveryOfItemsToolStripMenuItem"
        Me.DeliveryOfItemsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.DeliveryOfItemsToolStripMenuItem.Text = "Delivery / Out of Stock"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesInvoiceToolStripMenuItem, Me.ProductStockToolStripMenuItem, Me.BadOrderToolStripMenuItem, Me.InvoiceToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'SalesInvoiceToolStripMenuItem
        '
        Me.SalesInvoiceToolStripMenuItem.Name = "SalesInvoiceToolStripMenuItem"
        Me.SalesInvoiceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.SalesInvoiceToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SalesInvoiceToolStripMenuItem.Text = "Sales Invoice"
        '
        'ProductStockToolStripMenuItem
        '
        Me.ProductStockToolStripMenuItem.Name = "ProductStockToolStripMenuItem"
        Me.ProductStockToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ProductStockToolStripMenuItem.Text = "Product Stock"
        '
        'BadOrderToolStripMenuItem
        '
        Me.BadOrderToolStripMenuItem.Name = "BadOrderToolStripMenuItem"
        Me.BadOrderToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BadOrderToolStripMenuItem.Text = "Bad Order"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'UtilitiesToolStripMenuItem
        '
        Me.UtilitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupAndRestoreToolStripMenuItem, Me.UserMaintenanceToolStripMenuItem, Me.AuditTrailToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.UtilitiesToolStripMenuItem.Name = "UtilitiesToolStripMenuItem"
        Me.UtilitiesToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.UtilitiesToolStripMenuItem.Text = "Utilities "
        '
        'BackupAndRestoreToolStripMenuItem
        '
        Me.BackupAndRestoreToolStripMenuItem.Name = "BackupAndRestoreToolStripMenuItem"
        Me.BackupAndRestoreToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BackupAndRestoreToolStripMenuItem.Text = "Backup and Restore "
        '
        'UserMaintenanceToolStripMenuItem
        '
        Me.UserMaintenanceToolStripMenuItem.Name = "UserMaintenanceToolStripMenuItem"
        Me.UserMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.UserMaintenanceToolStripMenuItem.Text = "User Maintenance "
        '
        'AuditTrailToolStripMenuItem
        '
        Me.AuditTrailToolStripMenuItem.Name = "AuditTrailToolStripMenuItem"
        Me.AuditTrailToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AuditTrailToolStripMenuItem.Text = "Audit Trail "
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SystemInformationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SystemInformationToolStripMenuItem
        '
        Me.SystemInformationToolStripMenuItem.Name = "SystemInformationToolStripMenuItem"
        Me.SystemInformationToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SystemInformationToolStripMenuItem.Text = "System Information "
        '
        'LoguotToolStripMenuItem
        '
        Me.LoguotToolStripMenuItem.Name = "LoguotToolStripMenuItem"
        Me.LoguotToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LoguotToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblID, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblName, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.lblUser, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel8, Me.lblStatus, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel7, Me.lblTime})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 712)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel1.Text = "UserID :"
        '
        'lblID
        '
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(33, 17)
        Me.lblID.Text = "Temp"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel2.Text = "         "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel3.Text = "Name :"
        '
        'lblName
        '
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 17)
        Me.lblName.Text = "Temp"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel4.Text = "         "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatusLabel5.Text = "UserName :"
        '
        'lblUser
        '
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(33, 17)
        Me.lblUser.Text = "Temp"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel6.Text = "         "
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel8.Text = "UserType :"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(33, 17)
        Me.lblStatus.Text = "Temp"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel10.Text = "          "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel7.Text = "LoginTime :"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 17)
        Me.lblTime.Text = "Temp"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(11, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 98)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox1, "Calculator")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 369)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(92, 93)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox3, "Product Maintenance")
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(14, 490)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(92, 93)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox5, "Sales report")
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 249)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(92, 93)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox4, "POS")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(118, 688)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(118, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(898, 100)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(102, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(185, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 54)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "POINT OF SALE SYSTEM"
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS and Inventory System v 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupAndRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuditTrailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LoguotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryOfItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BadOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox

End Class
