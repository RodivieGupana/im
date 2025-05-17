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
        Me.TenantManagement = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Dashboard = New System.Windows.Forms.TabPage()
        Me.Profile = New System.Windows.Forms.TabPage()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblConfirmNewPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirmNewPassword = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTenantID = New System.Windows.Forms.TextBox()
        Me.lblTenantID = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmergencyContact = New System.Windows.Forms.Label()
        Me.txtEmergencyContact = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtEmergencyNumber = New System.Windows.Forms.TextBox()
        Me.lblEmergencyNumber = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblPersonalInformation = New System.Windows.Forms.Label()
        Me.Lease = New System.Windows.Forms.TabPage()
        Me.Payments = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtReceipt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPaymentMethod = New System.Windows.Forms.TextBox()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.txtReferenceNumber = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblReferenceNumber = New System.Windows.Forms.Label()
        Me.txtPaymentAmount = New System.Windows.Forms.TextBox()
        Me.lblPaymentAmount = New System.Windows.Forms.Label()
        Me.Maintenance = New System.Windows.Forms.TabPage()
        Me.gbSubmitMaintenanceRequest = New System.Windows.Forms.GroupBox()
        Me.lblIssueType = New System.Windows.Forms.Label()
        Me.cboIssueType = New System.Windows.Forms.ComboBox()
        Me.cboPriority = New System.Windows.Forms.ComboBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.Profile.SuspendLayout()
        Me.Payments.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Maintenance.SuspendLayout()
        Me.gbSubmitMaintenanceRequest.SuspendLayout()
        Me.SuspendLayout()
        '
        'TenantManagement
        '
        Me.TenantManagement.AutoSize = True
        Me.TenantManagement.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenantManagement.Location = New System.Drawing.Point(12, 9)
        Me.TenantManagement.Name = "TenantManagement"
        Me.TenantManagement.Size = New System.Drawing.Size(162, 24)
        Me.TenantManagement.TabIndex = 0
        Me.TenantManagement.Text = "Tenant Dashboard"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Dashboard)
        Me.TabControl1.Controls.Add(Me.Profile)
        Me.TabControl1.Controls.Add(Me.Lease)
        Me.TabControl1.Controls.Add(Me.Payments)
        Me.TabControl1.Controls.Add(Me.Maintenance)
        Me.TabControl1.Location = New System.Drawing.Point(12, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1009, 582)
        Me.TabControl1.TabIndex = 2
        '
        'Dashboard
        '
        Me.Dashboard.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard.Location = New System.Drawing.Point(4, 22)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.Dashboard.Size = New System.Drawing.Size(969, 465)
        Me.Dashboard.TabIndex = 0
        Me.Dashboard.Text = "Dashboard"
        Me.Dashboard.UseVisualStyleBackColor = True
        '
        'Profile
        '
        Me.Profile.Controls.Add(Me.lblNewPassword)
        Me.Profile.Controls.Add(Me.lblConfirmNewPassword)
        Me.Profile.Controls.Add(Me.Label2)
        Me.Profile.Controls.Add(Me.btnConfirmNewPassword)
        Me.Profile.Controls.Add(Me.TextBox1)
        Me.Profile.Controls.Add(Me.txtNewPassword)
        Me.Profile.Controls.Add(Me.txtCurrentPassword)
        Me.Profile.Controls.Add(Me.Label1)
        Me.Profile.Controls.Add(Me.Button1)
        Me.Profile.Controls.Add(Me.txtTenantID)
        Me.Profile.Controls.Add(Me.lblTenantID)
        Me.Profile.Controls.Add(Me.txtEmail)
        Me.Profile.Controls.Add(Me.lblEmergencyContact)
        Me.Profile.Controls.Add(Me.txtEmergencyContact)
        Me.Profile.Controls.Add(Me.lblEmail)
        Me.Profile.Controls.Add(Me.txtContactNumber)
        Me.Profile.Controls.Add(Me.lblContactNumber)
        Me.Profile.Controls.Add(Me.txtEmergencyNumber)
        Me.Profile.Controls.Add(Me.lblEmergencyNumber)
        Me.Profile.Controls.Add(Me.txtFullName)
        Me.Profile.Controls.Add(Me.lblFullName)
        Me.Profile.Controls.Add(Me.lblPersonalInformation)
        Me.Profile.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile.Location = New System.Drawing.Point(4, 22)
        Me.Profile.Name = "Profile"
        Me.Profile.Padding = New System.Windows.Forms.Padding(3)
        Me.Profile.Size = New System.Drawing.Size(969, 465)
        Me.Profile.TabIndex = 1
        Me.Profile.Text = "Profile"
        Me.Profile.UseVisualStyleBackColor = True
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(7, 311)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(89, 18)
        Me.lblNewPassword.TabIndex = 21
        Me.lblNewPassword.Text = "New Password"
        '
        'lblConfirmNewPassword
        '
        Me.lblConfirmNewPassword.AutoSize = True
        Me.lblConfirmNewPassword.Location = New System.Drawing.Point(7, 358)
        Me.lblConfirmNewPassword.Name = "lblConfirmNewPassword"
        Me.lblConfirmNewPassword.Size = New System.Drawing.Size(144, 18)
        Me.lblConfirmNewPassword.TabIndex = 20
        Me.lblConfirmNewPassword.Text = " Confirm New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Current Password"
        '
        'btnConfirmNewPassword
        '
        Me.btnConfirmNewPassword.BackColor = System.Drawing.Color.Blue
        Me.btnConfirmNewPassword.ForeColor = System.Drawing.Color.Transparent
        Me.btnConfirmNewPassword.Location = New System.Drawing.Point(10, 420)
        Me.btnConfirmNewPassword.Name = "btnConfirmNewPassword"
        Me.btnConfirmNewPassword.Size = New System.Drawing.Size(144, 37)
        Me.btnConfirmNewPassword.TabIndex = 18
        Me.btnConfirmNewPassword.Text = "Change Password"
        Me.btnConfirmNewPassword.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 385)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(671, 23)
        Me.TextBox1.TabIndex = 17
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(10, 332)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(671, 23)
        Me.txtNewPassword.TabIndex = 16
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Location = New System.Drawing.Point(10, 285)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(671, 23)
        Me.txtCurrentPassword.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Change Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(10, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Update Information"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtTenantID
        '
        Me.txtTenantID.Location = New System.Drawing.Point(372, 48)
        Me.txtTenantID.Name = "txtTenantID"
        Me.txtTenantID.Size = New System.Drawing.Size(309, 23)
        Me.txtTenantID.TabIndex = 12
        '
        'lblTenantID
        '
        Me.lblTenantID.AutoSize = True
        Me.lblTenantID.Location = New System.Drawing.Point(369, 27)
        Me.lblTenantID.Name = "lblTenantID"
        Me.lblTenantID.Size = New System.Drawing.Size(63, 18)
        Me.lblTenantID.TabIndex = 11
        Me.lblTenantID.Text = "Tenant ID"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(372, 96)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(309, 23)
        Me.txtEmail.TabIndex = 10
        '
        'lblEmergencyContact
        '
        Me.lblEmergencyContact.AutoSize = True
        Me.lblEmergencyContact.Location = New System.Drawing.Point(7, 122)
        Me.lblEmergencyContact.Name = "lblEmergencyContact"
        Me.lblEmergencyContact.Size = New System.Drawing.Size(120, 18)
        Me.lblEmergencyContact.TabIndex = 9
        Me.lblEmergencyContact.Text = "Emergency Contact"
        '
        'txtEmergencyContact
        '
        Me.txtEmergencyContact.Location = New System.Drawing.Point(10, 143)
        Me.txtEmergencyContact.Name = "txtEmergencyContact"
        Me.txtEmergencyContact.Size = New System.Drawing.Size(309, 23)
        Me.txtEmergencyContact.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(369, 75)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(40, 18)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(10, 96)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(309, 23)
        Me.txtContactNumber.TabIndex = 6
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(7, 74)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(102, 18)
        Me.lblContactNumber.TabIndex = 5
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtEmergencyNumber
        '
        Me.txtEmergencyNumber.Location = New System.Drawing.Point(372, 143)
        Me.txtEmergencyNumber.Name = "txtEmergencyNumber"
        Me.txtEmergencyNumber.Size = New System.Drawing.Size(309, 23)
        Me.txtEmergencyNumber.TabIndex = 4
        '
        'lblEmergencyNumber
        '
        Me.lblEmergencyNumber.AutoSize = True
        Me.lblEmergencyNumber.Location = New System.Drawing.Point(369, 122)
        Me.lblEmergencyNumber.Name = "lblEmergencyNumber"
        Me.lblEmergencyNumber.Size = New System.Drawing.Size(120, 18)
        Me.lblEmergencyNumber.TabIndex = 3
        Me.lblEmergencyNumber.Text = "Emergency Number"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(10, 48)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(309, 23)
        Me.txtFullName.TabIndex = 2
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(7, 27)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(65, 18)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Full Name"
        '
        'lblPersonalInformation
        '
        Me.lblPersonalInformation.AutoSize = True
        Me.lblPersonalInformation.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalInformation.Location = New System.Drawing.Point(6, 3)
        Me.lblPersonalInformation.Name = "lblPersonalInformation"
        Me.lblPersonalInformation.Size = New System.Drawing.Size(185, 24)
        Me.lblPersonalInformation.TabIndex = 0
        Me.lblPersonalInformation.Text = "Personal Information"
        '
        'Lease
        '
        Me.Lease.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lease.Location = New System.Drawing.Point(4, 22)
        Me.Lease.Name = "Lease"
        Me.Lease.Size = New System.Drawing.Size(969, 465)
        Me.Lease.TabIndex = 2
        Me.Lease.Text = "Lease"
        Me.Lease.UseVisualStyleBackColor = True
        '
        'Payments
        '
        Me.Payments.Controls.Add(Me.GroupBox2)
        Me.Payments.Controls.Add(Me.GroupBox1)
        Me.Payments.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payments.Location = New System.Drawing.Point(4, 22)
        Me.Payments.Name = "Payments"
        Me.Payments.Size = New System.Drawing.Size(1001, 556)
        Me.Payments.TabIndex = 3
        Me.Payments.Text = "Payment"
        Me.Payments.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 181)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment History"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtDate, Me.dtAmount, Me.dtMethod, Me.dtStatus, Me.dtReceipt})
        Me.DataGridView1.Location = New System.Drawing.Point(106, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 57)
        Me.DataGridView1.TabIndex = 0
        '
        'dtDate
        '
        Me.dtDate.HeaderText = "Date"
        Me.dtDate.Name = "dtDate"
        '
        'dtAmount
        '
        Me.dtAmount.HeaderText = "Amount"
        Me.dtAmount.Name = "dtAmount"
        '
        'dtMethod
        '
        Me.dtMethod.HeaderText = "Method"
        Me.dtMethod.Name = "dtMethod"
        '
        'dtStatus
        '
        Me.dtStatus.HeaderText = "Status"
        Me.dtStatus.Name = "dtStatus"
        '
        'dtReceipt
        '
        Me.dtReceipt.HeaderText = "Receipt"
        Me.dtReceipt.Name = "dtReceipt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPaymentMethod)
        Me.GroupBox1.Controls.Add(Me.lblPaymentMethod)
        Me.GroupBox1.Controls.Add(Me.txtReferenceNumber)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lblReferenceNumber)
        Me.GroupBox1.Controls.Add(Me.txtPaymentAmount)
        Me.GroupBox1.Controls.Add(Me.lblPaymentAmount)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 299)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Make Payment"
        '
        'txtPaymentMethod
        '
        Me.txtPaymentMethod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentMethod.Location = New System.Drawing.Point(106, 124)
        Me.txtPaymentMethod.Name = "txtPaymentMethod"
        Me.txtPaymentMethod.Size = New System.Drawing.Size(469, 23)
        Me.txtPaymentMethod.TabIndex = 13
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMethod.Location = New System.Drawing.Point(103, 103)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(104, 18)
        Me.lblPaymentMethod.TabIndex = 12
        Me.lblPaymentMethod.Text = "Payment Method"
        '
        'txtReferenceNumber
        '
        Me.txtReferenceNumber.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNumber.Location = New System.Drawing.Point(106, 180)
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.Size = New System.Drawing.Size(469, 23)
        Me.txtReferenceNumber.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(106, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 45)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Submit Payment"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblReferenceNumber
        '
        Me.lblReferenceNumber.AutoSize = True
        Me.lblReferenceNumber.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferenceNumber.Location = New System.Drawing.Point(103, 159)
        Me.lblReferenceNumber.Name = "lblReferenceNumber"
        Me.lblReferenceNumber.Size = New System.Drawing.Size(115, 18)
        Me.lblReferenceNumber.TabIndex = 10
        Me.lblReferenceNumber.Text = "Reference Number"
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentAmount.Location = New System.Drawing.Point(106, 68)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New System.Drawing.Size(469, 23)
        Me.txtPaymentAmount.TabIndex = 9
        '
        'lblPaymentAmount
        '
        Me.lblPaymentAmount.AutoSize = True
        Me.lblPaymentAmount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentAmount.Location = New System.Drawing.Point(103, 47)
        Me.lblPaymentAmount.Name = "lblPaymentAmount"
        Me.lblPaymentAmount.Size = New System.Drawing.Size(105, 18)
        Me.lblPaymentAmount.TabIndex = 8
        Me.lblPaymentAmount.Text = "Payment Amount"
        '
        'Maintenance
        '
        Me.Maintenance.Controls.Add(Me.gbSubmitMaintenanceRequest)
        Me.Maintenance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maintenance.Location = New System.Drawing.Point(4, 22)
        Me.Maintenance.Name = "Maintenance"
        Me.Maintenance.Size = New System.Drawing.Size(1001, 556)
        Me.Maintenance.TabIndex = 4
        Me.Maintenance.Text = "Maintenance"
        Me.Maintenance.UseVisualStyleBackColor = True
        '
        'gbSubmitMaintenanceRequest
        '
        Me.gbSubmitMaintenanceRequest.Controls.Add(Me.TextBox2)
        Me.gbSubmitMaintenanceRequest.Controls.Add(Me.Label3)
        Me.gbSubmitMaintenanceRequest.Controls.Add(Me.cboPriority)
        Me.gbSubmitMaintenanceRequest.Controls.Add(Me.lblPriority)
        Me.gbSubmitMaintenanceRequest.Controls.Add(Me.cboIssueType)
        Me.gbSubmitMaintenanceRequest.Controls.Add(Me.lblIssueType)
        Me.gbSubmitMaintenanceRequest.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSubmitMaintenanceRequest.Location = New System.Drawing.Point(11, 8)
        Me.gbSubmitMaintenanceRequest.Name = "gbSubmitMaintenanceRequest"
        Me.gbSubmitMaintenanceRequest.Size = New System.Drawing.Size(943, 293)
        Me.gbSubmitMaintenanceRequest.TabIndex = 0
        Me.gbSubmitMaintenanceRequest.TabStop = False
        Me.gbSubmitMaintenanceRequest.Text = "Submit Maintenace Request"
        '
        'lblIssueType
        '
        Me.lblIssueType.AutoSize = True
        Me.lblIssueType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueType.Location = New System.Drawing.Point(29, 37)
        Me.lblIssueType.Name = "lblIssueType"
        Me.lblIssueType.Size = New System.Drawing.Size(69, 18)
        Me.lblIssueType.TabIndex = 0
        Me.lblIssueType.Text = "Issue Type"
        '
        'cboIssueType
        '
        Me.cboIssueType.FormattingEnabled = True
        Me.cboIssueType.Items.AddRange(New Object() {"Electrical", "Plumbing", "Furniture", "Security", "Other"})
        Me.cboIssueType.Location = New System.Drawing.Point(32, 58)
        Me.cboIssueType.Name = "cboIssueType"
        Me.cboIssueType.Size = New System.Drawing.Size(452, 32)
        Me.cboIssueType.TabIndex = 2
        '
        'cboPriority
        '
        Me.cboPriority.FormattingEnabled = True
        Me.cboPriority.Items.AddRange(New Object() {"Urgent", "Normal"})
        Me.cboPriority.Location = New System.Drawing.Point(32, 119)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(452, 32)
        Me.cboPriority.TabIndex = 4
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriority.Location = New System.Drawing.Point(29, 98)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(50, 18)
        Me.lblPriority.TabIndex = 3
        Me.lblPriority.Text = "Priority"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(32, 175)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(452, 73)
        Me.TextBox2.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1033, 630)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TenantManagement)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.Profile.ResumeLayout(False)
        Me.Profile.PerformLayout()
        Me.Payments.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Maintenance.ResumeLayout(False)
        Me.gbSubmitMaintenanceRequest.ResumeLayout(False)
        Me.gbSubmitMaintenanceRequest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TenantManagement As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Dashboard As TabPage
    Friend WithEvents Profile As TabPage
    Friend WithEvents txtTenantID As TextBox
    Friend WithEvents lblTenantID As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmergencyContact As Label
    Friend WithEvents txtEmergencyContact As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtEmergencyNumber As TextBox
    Friend WithEvents lblEmergencyNumber As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblPersonalInformation As Label
    Friend WithEvents Lease As TabPage
    Friend WithEvents Payments As TabPage
    Friend WithEvents Maintenance As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirmNewPassword As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblConfirmNewPassword As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPaymentMethod As TextBox
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents txtReferenceNumber As TextBox
    Friend WithEvents lblReferenceNumber As Label
    Friend WithEvents txtPaymentAmount As TextBox
    Friend WithEvents lblPaymentAmount As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtDate As DataGridViewTextBoxColumn
    Friend WithEvents dtAmount As DataGridViewTextBoxColumn
    Friend WithEvents dtMethod As DataGridViewTextBoxColumn
    Friend WithEvents dtStatus As DataGridViewTextBoxColumn
    Friend WithEvents dtReceipt As DataGridViewTextBoxColumn
    Friend WithEvents gbSubmitMaintenanceRequest As GroupBox
    Friend WithEvents lblIssueType As Label
    Friend WithEvents cboIssueType As ComboBox
    Friend WithEvents cboPriority As ComboBox
    Friend WithEvents lblPriority As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
End Class
