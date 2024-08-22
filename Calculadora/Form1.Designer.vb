<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.T7 = New System.Windows.Forms.Button()
        Me.T9 = New System.Windows.Forms.Button()
        Me.T8 = New System.Windows.Forms.Button()
        Me.T5 = New System.Windows.Forms.Button()
        Me.T2 = New System.Windows.Forms.Button()
        Me.T4 = New System.Windows.Forms.Button()
        Me.T6 = New System.Windows.Forms.Button()
        Me.T1 = New System.Windows.Forms.Button()
        Me.T3 = New System.Windows.Forms.Button()
        Me.T0 = New System.Windows.Forms.Button()
        Me.IGUAL = New System.Windows.Forms.Button()
        Me.SUMA = New System.Windows.Forms.Button()
        Me.MULTIPLICA = New System.Windows.Forms.Button()
        Me.DIVISION = New System.Windows.Forms.Button()
        Me.RESTA = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Calculadora.My.Resources.Resources.ip1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(6, 115)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(178, 39)
        Me.txtDisplay.TabIndex = 1
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T7
        '
        Me.T7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T7.Location = New System.Drawing.Point(12, 195)
        Me.T7.Name = "T7"
        Me.T7.Size = New System.Drawing.Size(40, 29)
        Me.T7.TabIndex = 2
        Me.T7.Text = "7"
        Me.T7.UseVisualStyleBackColor = True
        '
        'T9
        '
        Me.T9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T9.Location = New System.Drawing.Point(104, 195)
        Me.T9.Name = "T9"
        Me.T9.Size = New System.Drawing.Size(40, 29)
        Me.T9.TabIndex = 3
        Me.T9.Text = "9"
        Me.T9.UseVisualStyleBackColor = True
        '
        'T8
        '
        Me.T8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T8.Location = New System.Drawing.Point(58, 195)
        Me.T8.Name = "T8"
        Me.T8.Size = New System.Drawing.Size(40, 29)
        Me.T8.TabIndex = 4
        Me.T8.Text = "8"
        Me.T8.UseVisualStyleBackColor = True
        '
        'T5
        '
        Me.T5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T5.Location = New System.Drawing.Point(58, 235)
        Me.T5.Name = "T5"
        Me.T5.Size = New System.Drawing.Size(40, 29)
        Me.T5.TabIndex = 5
        Me.T5.Text = "5"
        Me.T5.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.Location = New System.Drawing.Point(58, 270)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(40, 29)
        Me.T2.TabIndex = 6
        Me.T2.Text = "2"
        Me.T2.UseVisualStyleBackColor = True
        '
        'T4
        '
        Me.T4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T4.Location = New System.Drawing.Point(12, 235)
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(40, 29)
        Me.T4.TabIndex = 7
        Me.T4.Text = "4"
        Me.T4.UseVisualStyleBackColor = True
        '
        'T6
        '
        Me.T6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T6.Location = New System.Drawing.Point(104, 235)
        Me.T6.Name = "T6"
        Me.T6.Size = New System.Drawing.Size(40, 29)
        Me.T6.TabIndex = 8
        Me.T6.Text = "6"
        Me.T6.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T1.Location = New System.Drawing.Point(12, 270)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(40, 29)
        Me.T1.TabIndex = 9
        Me.T1.Text = "1"
        Me.T1.UseVisualStyleBackColor = True
        '
        'T3
        '
        Me.T3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T3.Location = New System.Drawing.Point(104, 270)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(40, 29)
        Me.T3.TabIndex = 10
        Me.T3.Text = "3"
        Me.T3.UseVisualStyleBackColor = True
        '
        'T0
        '
        Me.T0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T0.Location = New System.Drawing.Point(12, 305)
        Me.T0.Name = "T0"
        Me.T0.Size = New System.Drawing.Size(86, 29)
        Me.T0.TabIndex = 11
        Me.T0.Text = "0"
        Me.T0.UseVisualStyleBackColor = True
        '
        'IGUAL
        '
        Me.IGUAL.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IGUAL.Location = New System.Drawing.Point(104, 305)
        Me.IGUAL.Name = "IGUAL"
        Me.IGUAL.Size = New System.Drawing.Size(86, 29)
        Me.IGUAL.TabIndex = 12
        Me.IGUAL.Text = "="
        Me.IGUAL.UseVisualStyleBackColor = True
        '
        'SUMA
        '
        Me.SUMA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUMA.Location = New System.Drawing.Point(150, 160)
        Me.SUMA.Name = "SUMA"
        Me.SUMA.Size = New System.Drawing.Size(40, 29)
        Me.SUMA.TabIndex = 13
        Me.SUMA.Text = "+"
        Me.SUMA.UseVisualStyleBackColor = True
        '
        'MULTIPLICA
        '
        Me.MULTIPLICA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MULTIPLICA.Location = New System.Drawing.Point(150, 270)
        Me.MULTIPLICA.Name = "MULTIPLICA"
        Me.MULTIPLICA.Size = New System.Drawing.Size(40, 29)
        Me.MULTIPLICA.TabIndex = 14
        Me.MULTIPLICA.Text = "*"
        Me.MULTIPLICA.UseVisualStyleBackColor = True
        '
        'DIVISION
        '
        Me.DIVISION.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIVISION.Location = New System.Drawing.Point(150, 235)
        Me.DIVISION.Name = "DIVISION"
        Me.DIVISION.Size = New System.Drawing.Size(40, 29)
        Me.DIVISION.TabIndex = 15
        Me.DIVISION.Text = "/"
        Me.DIVISION.UseVisualStyleBackColor = True
        '
        'RESTA
        '
        Me.RESTA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESTA.Location = New System.Drawing.Point(150, 195)
        Me.RESTA.Name = "RESTA"
        Me.RESTA.Size = New System.Drawing.Size(40, 29)
        Me.RESTA.TabIndex = 16
        Me.RESTA.Text = "-"
        Me.RESTA.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(12, 160)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(132, 29)
        Me.Button16.TabIndex = 17
        Me.Button16.Text = "Borrar"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Rata calculeitor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Rata calculeitor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 343)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.RESTA)
        Me.Controls.Add(Me.DIVISION)
        Me.Controls.Add(Me.MULTIPLICA)
        Me.Controls.Add(Me.SUMA)
        Me.Controls.Add(Me.IGUAL)
        Me.Controls.Add(Me.T0)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.T6)
        Me.Controls.Add(Me.T4)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T5)
        Me.Controls.Add(Me.T8)
        Me.Controls.Add(Me.T9)
        Me.Controls.Add(Me.T7)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Operaciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents T7 As Button
    Friend WithEvents T9 As Button
    Friend WithEvents T8 As Button
    Friend WithEvents T5 As Button
    Friend WithEvents T2 As Button
    Friend WithEvents T4 As Button
    Friend WithEvents T6 As Button
    Friend WithEvents T1 As Button
    Friend WithEvents T3 As Button
    Friend WithEvents T0 As Button
    Friend WithEvents IGUAL As Button
    Friend WithEvents SUMA As Button
    Friend WithEvents MULTIPLICA As Button
    Friend WithEvents DIVISION As Button
    Friend WithEvents RESTA As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
