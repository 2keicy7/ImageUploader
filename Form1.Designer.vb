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
        Me.btnRetrieveImage = New System.Windows.Forms.Button()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.PB = New System.Windows.Forms.PictureBox()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRetrieveImage
        '
        Me.btnRetrieveImage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrieveImage.Image = CType(resources.GetObject("btnRetrieveImage.Image"), System.Drawing.Image)
        Me.btnRetrieveImage.Location = New System.Drawing.Point(24, 149)
        Me.btnRetrieveImage.Name = "btnRetrieveImage"
        Me.btnRetrieveImage.Size = New System.Drawing.Size(158, 40)
        Me.btnRetrieveImage.TabIndex = 126
        Me.btnRetrieveImage.TabStop = False
        Me.btnRetrieveImage.Text = "Retrieve Image"
        Me.btnRetrieveImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRetrieveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRetrieveImage.UseVisualStyleBackColor = True
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseImage.Image = CType(resources.GetObject("btnBrowseImage.Image"), System.Drawing.Image)
        Me.btnBrowseImage.Location = New System.Drawing.Point(24, 103)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(158, 40)
        Me.btnBrowseImage.TabIndex = 125
        Me.btnBrowseImage.TabStop = False
        Me.btnBrowseImage.Text = "Save Image"
        Me.btnBrowseImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrowseImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowseImage.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 22)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "ID :"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(66, 44)
        Me.txtID.MaxLength = 150
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(110, 29)
        Me.txtID.TabIndex = 128
        Me.txtID.TabStop = False
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(188, 12)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(356, 237)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 129
        Me.PB.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 261)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnRetrieveImage)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRetrieveImage As Button
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents PB As PictureBox
End Class
