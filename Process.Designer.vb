<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcess
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
        Me.LblWho = New System.Windows.Forms.Label()
        Me.LblWhat = New System.Windows.Forms.Label()
        Me.LblWhere = New System.Windows.Forms.Label()
        Me.TBWhen = New System.Windows.Forms.TextBox()
        Me.LblWhen = New System.Windows.Forms.Label()
        Me.LblWhy = New System.Windows.Forms.Label()
        Me.LblHow = New System.Windows.Forms.Label()
        Me.TBHowMuch = New System.Windows.Forms.TextBox()
        Me.LblHowMuch = New System.Windows.Forms.Label()
        Me.LblProcess1 = New System.Windows.Forms.Label()
        Me.CBProcess1 = New System.Windows.Forms.ComboBox()
        Me.CBWho = New System.Windows.Forms.ComboBox()
        Me.CBWhat = New System.Windows.Forms.ComboBox()
        Me.BdElements1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_Elements1DataSet = New Process.bd_Elements1DataSet()
        Me.CBWhere = New System.Windows.Forms.ComboBox()
        Me.CBWhy = New System.Windows.Forms.ComboBox()
        Me.CBHow = New System.Windows.Forms.ComboBox()
        Me.CBPredecessors1 = New System.Windows.Forms.ComboBox()
        Me.LblPredecessors1 = New System.Windows.Forms.Label()
        Me.CBSuccessors1 = New System.Windows.Forms.ComboBox()
        Me.LblSuccessors1 = New System.Windows.Forms.Label()
        Me.CBAction1 = New System.Windows.Forms.ComboBox()
        Me.LblAction1 = New System.Windows.Forms.Label()
        Me.CBSideEffects1 = New System.Windows.Forms.ComboBox()
        Me.LblSideEffects1 = New System.Windows.Forms.Label()
        Me.CBEnergy1 = New System.Windows.Forms.ComboBox()
        Me.LblEnergy1 = New System.Windows.Forms.Label()
        Me.CBSubProcesses1 = New System.Windows.Forms.ComboBox()
        Me.LblSubProcesses1 = New System.Windows.Forms.Label()
        Me.CBSubProcesses3 = New System.Windows.Forms.ComboBox()
        Me.LblSubProcesses3 = New System.Windows.Forms.Label()
        Me.CBSideEffects3 = New System.Windows.Forms.ComboBox()
        Me.LblSideEffects3 = New System.Windows.Forms.Label()
        Me.CBEnergy3 = New System.Windows.Forms.ComboBox()
        Me.LblEnergy3 = New System.Windows.Forms.Label()
        Me.CBAction3 = New System.Windows.Forms.ComboBox()
        Me.LblAction3 = New System.Windows.Forms.Label()
        Me.CBSuccessors3 = New System.Windows.Forms.ComboBox()
        Me.LblSuccessors3 = New System.Windows.Forms.Label()
        Me.CBPredecessors3 = New System.Windows.Forms.ComboBox()
        Me.LblPredecessors3 = New System.Windows.Forms.Label()
        Me.CBProcess3 = New System.Windows.Forms.ComboBox()
        Me.LblProcess3 = New System.Windows.Forms.Label()
        Me.CBSubProcesses2 = New System.Windows.Forms.ComboBox()
        Me.LblSubProcesses2 = New System.Windows.Forms.Label()
        Me.CBSideEffects2 = New System.Windows.Forms.ComboBox()
        Me.LblSideEffects2 = New System.Windows.Forms.Label()
        Me.CBEnergy2 = New System.Windows.Forms.ComboBox()
        Me.LblEnergy2 = New System.Windows.Forms.Label()
        Me.CBAction2 = New System.Windows.Forms.ComboBox()
        Me.LblAction2 = New System.Windows.Forms.Label()
        Me.CBSuccessors2 = New System.Windows.Forms.ComboBox()
        Me.LblSuccessors2 = New System.Windows.Forms.Label()
        Me.CBPredecessors2 = New System.Windows.Forms.ComboBox()
        Me.LblPredecessors2 = New System.Windows.Forms.Label()
        Me.CBProcess2 = New System.Windows.Forms.ComboBox()
        Me.LblProcess2 = New System.Windows.Forms.Label()
        Me.LblRArrow1 = New System.Windows.Forms.Label()
        Me.LblRArrow2 = New System.Windows.Forms.Label()
        Me.LblLArrow1 = New System.Windows.Forms.Label()
        Me.LblLArrow2 = New System.Windows.Forms.Label()
        Me.LblRArrow3 = New System.Windows.Forms.Label()
        Me.LblRArrow4 = New System.Windows.Forms.Label()
        Me.LblLArrow3 = New System.Windows.Forms.Label()
        Me.LblLArrow4 = New System.Windows.Forms.Label()
        Me.RTBExplanations = New System.Windows.Forms.RichTextBox()
        Me.LblExplanations = New System.Windows.Forms.Label()
        CType(Me.BdElements1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd_Elements1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblWho
        '
        Me.LblWho.AutoSize = True
        Me.LblWho.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWho.Location = New System.Drawing.Point(10, 10)
        Me.LblWho.Name = "LblWho"
        Me.LblWho.Size = New System.Drawing.Size(47, 20)
        Me.LblWho.TabIndex = 0
        Me.LblWho.Text = "Who ?"
        '
        'LblWhat
        '
        Me.LblWhat.AutoSize = True
        Me.LblWhat.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWhat.Location = New System.Drawing.Point(10, 46)
        Me.LblWhat.Name = "LblWhat"
        Me.LblWhat.Size = New System.Drawing.Size(49, 20)
        Me.LblWhat.TabIndex = 8
        Me.LblWhat.Text = "What ?"
        '
        'LblWhere
        '
        Me.LblWhere.AutoSize = True
        Me.LblWhere.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWhere.Location = New System.Drawing.Point(10, 85)
        Me.LblWhere.Name = "LblWhere"
        Me.LblWhere.Size = New System.Drawing.Size(59, 20)
        Me.LblWhere.TabIndex = 10
        Me.LblWhere.Text = "Where ?"
        '
        'TBWhen
        '
        Me.TBWhen.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWhen.Location = New System.Drawing.Point(70, 126)
        Me.TBWhen.Name = "TBWhen"
        Me.TBWhen.Size = New System.Drawing.Size(100, 26)
        Me.TBWhen.TabIndex = 13
        '
        'LblWhen
        '
        Me.LblWhen.AutoSize = True
        Me.LblWhen.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWhen.Location = New System.Drawing.Point(10, 126)
        Me.LblWhen.Name = "LblWhen"
        Me.LblWhen.Size = New System.Drawing.Size(54, 20)
        Me.LblWhen.TabIndex = 12
        Me.LblWhen.Text = "When ?"
        '
        'LblWhy
        '
        Me.LblWhy.AutoSize = True
        Me.LblWhy.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWhy.Location = New System.Drawing.Point(10, 166)
        Me.LblWhy.Name = "LblWhy"
        Me.LblWhy.Size = New System.Drawing.Size(46, 20)
        Me.LblWhy.TabIndex = 14
        Me.LblWhy.Text = "Why ?"
        '
        'LblHow
        '
        Me.LblHow.AutoSize = True
        Me.LblHow.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHow.Location = New System.Drawing.Point(10, 207)
        Me.LblHow.Name = "LblHow"
        Me.LblHow.Size = New System.Drawing.Size(46, 20)
        Me.LblHow.TabIndex = 16
        Me.LblHow.Text = "How ?"
        '
        'TBHowMuch
        '
        Me.TBHowMuch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHowMuch.Location = New System.Drawing.Point(70, 245)
        Me.TBHowMuch.Name = "TBHowMuch"
        Me.TBHowMuch.Size = New System.Drawing.Size(100, 26)
        Me.TBHowMuch.TabIndex = 19
        '
        'LblHowMuch
        '
        Me.LblHowMuch.AutoSize = True
        Me.LblHowMuch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHowMuch.Location = New System.Drawing.Point(10, 245)
        Me.LblHowMuch.Name = "LblHowMuch"
        Me.LblHowMuch.Size = New System.Drawing.Size(40, 20)
        Me.LblHowMuch.TabIndex = 18
        Me.LblHowMuch.Text = "Qty ?"
        '
        'LblProcess1
        '
        Me.LblProcess1.AutoSize = True
        Me.LblProcess1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcess1.Location = New System.Drawing.Point(237, 8)
        Me.LblProcess1.Name = "LblProcess1"
        Me.LblProcess1.Size = New System.Drawing.Size(81, 20)
        Me.LblProcess1.TabIndex = 20
        Me.LblProcess1.Text = "Process 1 ?"
        '
        'CBProcess1
        '
        Me.CBProcess1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBProcess1.FormattingEnabled = True
        Me.CBProcess1.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBProcess1.Location = New System.Drawing.Point(232, 33)
        Me.CBProcess1.Name = "CBProcess1"
        Me.CBProcess1.Size = New System.Drawing.Size(121, 28)
        Me.CBProcess1.TabIndex = 22
        '
        'CBWho
        '
        Me.CBWho.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBWho.FormattingEnabled = True
        Me.CBWho.Items.AddRange(New Object() {"Me", "Helper", "Cook", "Technician"})
        Me.CBWho.Location = New System.Drawing.Point(70, 8)
        Me.CBWho.Name = "CBWho"
        Me.CBWho.Size = New System.Drawing.Size(100, 28)
        Me.CBWho.TabIndex = 23
        '
        'CBWhat
        '
        Me.CBWhat.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBWhat.FormattingEnabled = True
        Me.CBWhat.Location = New System.Drawing.Point(70, 46)
        Me.CBWhat.Name = "CBWhat"
        Me.CBWhat.Size = New System.Drawing.Size(100, 28)
        Me.CBWhat.TabIndex = 24
        '
        'BdElements1DataSetBindingSource
        '
        Me.BdElements1DataSetBindingSource.DataSource = Me.Bd_Elements1DataSet
        Me.BdElements1DataSetBindingSource.Position = 0
        '
        'Bd_Elements1DataSet
        '
        Me.Bd_Elements1DataSet.DataSetName = "bd_Elements1DataSet"
        Me.Bd_Elements1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CBWhere
        '
        Me.CBWhere.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBWhere.FormattingEnabled = True
        Me.CBWhere.Items.AddRange(New Object() {"House", "Garage", "Yard", "Kitchen", "Dining Room", "Hall", "Laundry", "Library", "Living Room", "Study", ""})
        Me.CBWhere.Location = New System.Drawing.Point(70, 85)
        Me.CBWhere.Name = "CBWhere"
        Me.CBWhere.Size = New System.Drawing.Size(100, 28)
        Me.CBWhere.TabIndex = 25
        '
        'CBWhy
        '
        Me.CBWhy.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBWhy.FormattingEnabled = True
        Me.CBWhy.Items.AddRange(New Object() {"Creativity", "Prestige", "Power", "Wealth", "Prosperity", "Comfort", "Education", "Fun", "Enjoyment", "Relationship", "Security", "Safety", "Health", "Food", "Water", "Warmth", "Rest", "Clothing"})
        Me.CBWhy.Location = New System.Drawing.Point(70, 163)
        Me.CBWhy.Name = "CBWhy"
        Me.CBWhy.Size = New System.Drawing.Size(100, 28)
        Me.CBWhy.TabIndex = 26
        '
        'CBHow
        '
        Me.CBHow.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBHow.FormattingEnabled = True
        Me.CBHow.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBHow.Location = New System.Drawing.Point(70, 204)
        Me.CBHow.Name = "CBHow"
        Me.CBHow.Size = New System.Drawing.Size(100, 28)
        Me.CBHow.TabIndex = 27
        '
        'CBPredecessors1
        '
        Me.CBPredecessors1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPredecessors1.FormattingEnabled = True
        Me.CBPredecessors1.Items.AddRange(New Object() {"None", "Prepare area", "Get equipment", "Get tools", "Get supplies", "Move, object", "Add, object", "Change, object", "Delete, object", "Assemble, object", "Disassemble, object", "Clean, object", "Clean, area", "Construct, object", "Cook, object", "Repair, object"})
        Me.CBPredecessors1.Location = New System.Drawing.Point(241, 144)
        Me.CBPredecessors1.Name = "CBPredecessors1"
        Me.CBPredecessors1.Size = New System.Drawing.Size(121, 28)
        Me.CBPredecessors1.TabIndex = 29
        '
        'LblPredecessors1
        '
        Me.LblPredecessors1.AutoSize = True
        Me.LblPredecessors1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredecessors1.Location = New System.Drawing.Point(246, 119)
        Me.LblPredecessors1.Name = "LblPredecessors1"
        Me.LblPredecessors1.Size = New System.Drawing.Size(94, 20)
        Me.LblPredecessors1.TabIndex = 28
        Me.LblPredecessors1.Text = "Predecessors"
        '
        'CBSuccessors1
        '
        Me.CBSuccessors1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSuccessors1.FormattingEnabled = True
        Me.CBSuccessors1.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBSuccessors1.Location = New System.Drawing.Point(241, 200)
        Me.CBSuccessors1.Name = "CBSuccessors1"
        Me.CBSuccessors1.Size = New System.Drawing.Size(121, 28)
        Me.CBSuccessors1.TabIndex = 31
        '
        'LblSuccessors1
        '
        Me.LblSuccessors1.AutoSize = True
        Me.LblSuccessors1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSuccessors1.Location = New System.Drawing.Point(246, 175)
        Me.LblSuccessors1.Name = "LblSuccessors1"
        Me.LblSuccessors1.Size = New System.Drawing.Size(80, 20)
        Me.LblSuccessors1.TabIndex = 30
        Me.LblSuccessors1.Text = "Successors"
        '
        'CBAction1
        '
        Me.CBAction1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAction1.FormattingEnabled = True
        Me.CBAction1.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBAction1.Location = New System.Drawing.Point(241, 87)
        Me.CBAction1.Name = "CBAction1"
        Me.CBAction1.Size = New System.Drawing.Size(121, 28)
        Me.CBAction1.TabIndex = 33
        '
        'LblAction1
        '
        Me.LblAction1.AutoSize = True
        Me.LblAction1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAction1.Location = New System.Drawing.Point(246, 62)
        Me.LblAction1.Name = "LblAction1"
        Me.LblAction1.Size = New System.Drawing.Size(46, 20)
        Me.LblAction1.TabIndex = 32
        Me.LblAction1.Text = "Action"
        '
        'CBSideEffects1
        '
        Me.CBSideEffects1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSideEffects1.FormattingEnabled = True
        Me.CBSideEffects1.Items.AddRange(New Object() {"TBD", "Insignificant", "Heat", "Light", "Hazardous", "Polution - Air", "Polution - Land", "Polution - Water", "Unknown"})
        Me.CBSideEffects1.Location = New System.Drawing.Point(241, 368)
        Me.CBSideEffects1.Name = "CBSideEffects1"
        Me.CBSideEffects1.Size = New System.Drawing.Size(121, 28)
        Me.CBSideEffects1.TabIndex = 37
        '
        'LblSideEffects1
        '
        Me.LblSideEffects1.AutoSize = True
        Me.LblSideEffects1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSideEffects1.Location = New System.Drawing.Point(246, 345)
        Me.LblSideEffects1.Name = "LblSideEffects1"
        Me.LblSideEffects1.Size = New System.Drawing.Size(81, 20)
        Me.LblSideEffects1.TabIndex = 36
        Me.LblSideEffects1.Text = "Side Effects"
        '
        'CBEnergy1
        '
        Me.CBEnergy1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEnergy1.FormattingEnabled = True
        Me.CBEnergy1.Items.AddRange(New Object() {"Electricity", "Gas", "Solar", "Chemical", "Nuclear", "Human", "Wood", "Coal", "Wind", "Heat", "Light"})
        Me.CBEnergy1.Location = New System.Drawing.Point(241, 314)
        Me.CBEnergy1.Name = "CBEnergy1"
        Me.CBEnergy1.Size = New System.Drawing.Size(121, 28)
        Me.CBEnergy1.TabIndex = 35
        '
        'LblEnergy1
        '
        Me.LblEnergy1.AutoSize = True
        Me.LblEnergy1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnergy1.Location = New System.Drawing.Point(246, 289)
        Me.LblEnergy1.Name = "LblEnergy1"
        Me.LblEnergy1.Size = New System.Drawing.Size(52, 20)
        Me.LblEnergy1.TabIndex = 34
        Me.LblEnergy1.Text = "Energy"
        '
        'CBSubProcesses1
        '
        Me.CBSubProcesses1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSubProcesses1.FormattingEnabled = True
        Me.CBSubProcesses1.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBSubProcesses1.Location = New System.Drawing.Point(241, 257)
        Me.CBSubProcesses1.Name = "CBSubProcesses1"
        Me.CBSubProcesses1.Size = New System.Drawing.Size(121, 28)
        Me.CBSubProcesses1.TabIndex = 39
        '
        'LblSubProcesses1
        '
        Me.LblSubProcesses1.AutoSize = True
        Me.LblSubProcesses1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubProcesses1.Location = New System.Drawing.Point(246, 232)
        Me.LblSubProcesses1.Name = "LblSubProcesses1"
        Me.LblSubProcesses1.Size = New System.Drawing.Size(97, 20)
        Me.LblSubProcesses1.TabIndex = 38
        Me.LblSubProcesses1.Text = "Subprocesses"
        '
        'CBSubProcesses3
        '
        Me.CBSubProcesses3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSubProcesses3.FormattingEnabled = True
        Me.CBSubProcesses3.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBSubProcesses3.Location = New System.Drawing.Point(623, 257)
        Me.CBSubProcesses3.Name = "CBSubProcesses3"
        Me.CBSubProcesses3.Size = New System.Drawing.Size(121, 28)
        Me.CBSubProcesses3.TabIndex = 53
        '
        'LblSubProcesses3
        '
        Me.LblSubProcesses3.AutoSize = True
        Me.LblSubProcesses3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubProcesses3.Location = New System.Drawing.Point(628, 232)
        Me.LblSubProcesses3.Name = "LblSubProcesses3"
        Me.LblSubProcesses3.Size = New System.Drawing.Size(97, 20)
        Me.LblSubProcesses3.TabIndex = 52
        Me.LblSubProcesses3.Text = "Subprocesses"
        '
        'CBSideEffects3
        '
        Me.CBSideEffects3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSideEffects3.FormattingEnabled = True
        Me.CBSideEffects3.Items.AddRange(New Object() {"TBD", "Insignificant", "Heat", "Light", "Hazardous", "Polution - Air", "Polution - Land", "Polution - Water", "Unknown"})
        Me.CBSideEffects3.Location = New System.Drawing.Point(623, 368)
        Me.CBSideEffects3.Name = "CBSideEffects3"
        Me.CBSideEffects3.Size = New System.Drawing.Size(121, 28)
        Me.CBSideEffects3.TabIndex = 51
        '
        'LblSideEffects3
        '
        Me.LblSideEffects3.AutoSize = True
        Me.LblSideEffects3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSideEffects3.Location = New System.Drawing.Point(628, 345)
        Me.LblSideEffects3.Name = "LblSideEffects3"
        Me.LblSideEffects3.Size = New System.Drawing.Size(81, 20)
        Me.LblSideEffects3.TabIndex = 50
        Me.LblSideEffects3.Text = "Side Effects"
        '
        'CBEnergy3
        '
        Me.CBEnergy3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEnergy3.FormattingEnabled = True
        Me.CBEnergy3.Items.AddRange(New Object() {"Electricity", "Gas", "Solar", "Chemical", "Nuclear", "Human", "Wood", "Coal", "Wind", "Heat", "Light"})
        Me.CBEnergy3.Location = New System.Drawing.Point(623, 314)
        Me.CBEnergy3.Name = "CBEnergy3"
        Me.CBEnergy3.Size = New System.Drawing.Size(121, 28)
        Me.CBEnergy3.TabIndex = 49
        '
        'LblEnergy3
        '
        Me.LblEnergy3.AutoSize = True
        Me.LblEnergy3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnergy3.Location = New System.Drawing.Point(628, 289)
        Me.LblEnergy3.Name = "LblEnergy3"
        Me.LblEnergy3.Size = New System.Drawing.Size(52, 20)
        Me.LblEnergy3.TabIndex = 48
        Me.LblEnergy3.Text = "Energy"
        '
        'CBAction3
        '
        Me.CBAction3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAction3.FormattingEnabled = True
        Me.CBAction3.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBAction3.Location = New System.Drawing.Point(623, 87)
        Me.CBAction3.Name = "CBAction3"
        Me.CBAction3.Size = New System.Drawing.Size(121, 28)
        Me.CBAction3.TabIndex = 47
        '
        'LblAction3
        '
        Me.LblAction3.AutoSize = True
        Me.LblAction3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAction3.Location = New System.Drawing.Point(628, 62)
        Me.LblAction3.Name = "LblAction3"
        Me.LblAction3.Size = New System.Drawing.Size(46, 20)
        Me.LblAction3.TabIndex = 46
        Me.LblAction3.Text = "Action"
        '
        'CBSuccessors3
        '
        Me.CBSuccessors3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSuccessors3.FormattingEnabled = True
        Me.CBSuccessors3.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBSuccessors3.Location = New System.Drawing.Point(623, 200)
        Me.CBSuccessors3.Name = "CBSuccessors3"
        Me.CBSuccessors3.Size = New System.Drawing.Size(121, 28)
        Me.CBSuccessors3.TabIndex = 45
        '
        'LblSuccessors3
        '
        Me.LblSuccessors3.AutoSize = True
        Me.LblSuccessors3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSuccessors3.Location = New System.Drawing.Point(628, 175)
        Me.LblSuccessors3.Name = "LblSuccessors3"
        Me.LblSuccessors3.Size = New System.Drawing.Size(80, 20)
        Me.LblSuccessors3.TabIndex = 44
        Me.LblSuccessors3.Text = "Successors"
        '
        'CBPredecessors3
        '
        Me.CBPredecessors3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPredecessors3.FormattingEnabled = True
        Me.CBPredecessors3.Items.AddRange(New Object() {"None", "Prepare area", "Get equipment", "Get tools", "Get supplies", "Move, object", "Add, object", "Change, object", "Delete, object", "Assemble, object", "Disassemble, object", "Clean, object", "Clean, area", "Construct, object", "Cook, object", "Repair, object"})
        Me.CBPredecessors3.Location = New System.Drawing.Point(623, 144)
        Me.CBPredecessors3.Name = "CBPredecessors3"
        Me.CBPredecessors3.Size = New System.Drawing.Size(121, 28)
        Me.CBPredecessors3.TabIndex = 43
        '
        'LblPredecessors3
        '
        Me.LblPredecessors3.AutoSize = True
        Me.LblPredecessors3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredecessors3.Location = New System.Drawing.Point(628, 119)
        Me.LblPredecessors3.Name = "LblPredecessors3"
        Me.LblPredecessors3.Size = New System.Drawing.Size(94, 20)
        Me.LblPredecessors3.TabIndex = 42
        Me.LblPredecessors3.Text = "Predecessors"
        '
        'CBProcess3
        '
        Me.CBProcess3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBProcess3.FormattingEnabled = True
        Me.CBProcess3.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBProcess3.Location = New System.Drawing.Point(614, 33)
        Me.CBProcess3.Name = "CBProcess3"
        Me.CBProcess3.Size = New System.Drawing.Size(121, 28)
        Me.CBProcess3.TabIndex = 41
        '
        'LblProcess3
        '
        Me.LblProcess3.AutoSize = True
        Me.LblProcess3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcess3.Location = New System.Drawing.Point(619, 8)
        Me.LblProcess3.Name = "LblProcess3"
        Me.LblProcess3.Size = New System.Drawing.Size(81, 20)
        Me.LblProcess3.TabIndex = 40
        Me.LblProcess3.Text = "Process 3 ?"
        '
        'CBSubProcesses2
        '
        Me.CBSubProcesses2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSubProcesses2.FormattingEnabled = True
        Me.CBSubProcesses2.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBSubProcesses2.Location = New System.Drawing.Point(424, 257)
        Me.CBSubProcesses2.Name = "CBSubProcesses2"
        Me.CBSubProcesses2.Size = New System.Drawing.Size(121, 28)
        Me.CBSubProcesses2.TabIndex = 67
        '
        'LblSubProcesses2
        '
        Me.LblSubProcesses2.AutoSize = True
        Me.LblSubProcesses2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubProcesses2.Location = New System.Drawing.Point(429, 232)
        Me.LblSubProcesses2.Name = "LblSubProcesses2"
        Me.LblSubProcesses2.Size = New System.Drawing.Size(97, 20)
        Me.LblSubProcesses2.TabIndex = 66
        Me.LblSubProcesses2.Text = "Subprocesses"
        '
        'CBSideEffects2
        '
        Me.CBSideEffects2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSideEffects2.FormattingEnabled = True
        Me.CBSideEffects2.Items.AddRange(New Object() {"TBD", "Insignificant", "Heat", "Light", "Hazardous", "Polution - Air", "Polution - Land", "Polution - Water", "Unknown"})
        Me.CBSideEffects2.Location = New System.Drawing.Point(424, 368)
        Me.CBSideEffects2.Name = "CBSideEffects2"
        Me.CBSideEffects2.Size = New System.Drawing.Size(121, 28)
        Me.CBSideEffects2.TabIndex = 65
        '
        'LblSideEffects2
        '
        Me.LblSideEffects2.AutoSize = True
        Me.LblSideEffects2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSideEffects2.Location = New System.Drawing.Point(429, 345)
        Me.LblSideEffects2.Name = "LblSideEffects2"
        Me.LblSideEffects2.Size = New System.Drawing.Size(81, 20)
        Me.LblSideEffects2.TabIndex = 64
        Me.LblSideEffects2.Text = "Side Effects"
        '
        'CBEnergy2
        '
        Me.CBEnergy2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEnergy2.FormattingEnabled = True
        Me.CBEnergy2.Items.AddRange(New Object() {"Electricity", "Gas", "Solar", "Chemical", "Nuclear", "Human", "Wood", "Coal", "Wind", "Heat", "Light"})
        Me.CBEnergy2.Location = New System.Drawing.Point(424, 314)
        Me.CBEnergy2.Name = "CBEnergy2"
        Me.CBEnergy2.Size = New System.Drawing.Size(121, 28)
        Me.CBEnergy2.TabIndex = 63
        '
        'LblEnergy2
        '
        Me.LblEnergy2.AutoSize = True
        Me.LblEnergy2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnergy2.Location = New System.Drawing.Point(429, 289)
        Me.LblEnergy2.Name = "LblEnergy2"
        Me.LblEnergy2.Size = New System.Drawing.Size(52, 20)
        Me.LblEnergy2.TabIndex = 62
        Me.LblEnergy2.Text = "Energy"
        '
        'CBAction2
        '
        Me.CBAction2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAction2.FormattingEnabled = True
        Me.CBAction2.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBAction2.Location = New System.Drawing.Point(424, 87)
        Me.CBAction2.Name = "CBAction2"
        Me.CBAction2.Size = New System.Drawing.Size(121, 28)
        Me.CBAction2.TabIndex = 61
        '
        'LblAction2
        '
        Me.LblAction2.AutoSize = True
        Me.LblAction2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAction2.Location = New System.Drawing.Point(429, 62)
        Me.LblAction2.Name = "LblAction2"
        Me.LblAction2.Size = New System.Drawing.Size(46, 20)
        Me.LblAction2.TabIndex = 60
        Me.LblAction2.Text = "Action"
        '
        'CBSuccessors2
        '
        Me.CBSuccessors2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSuccessors2.FormattingEnabled = True
        Me.CBSuccessors2.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBSuccessors2.Location = New System.Drawing.Point(424, 200)
        Me.CBSuccessors2.Name = "CBSuccessors2"
        Me.CBSuccessors2.Size = New System.Drawing.Size(121, 28)
        Me.CBSuccessors2.TabIndex = 59
        '
        'LblSuccessors2
        '
        Me.LblSuccessors2.AutoSize = True
        Me.LblSuccessors2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSuccessors2.Location = New System.Drawing.Point(429, 175)
        Me.LblSuccessors2.Name = "LblSuccessors2"
        Me.LblSuccessors2.Size = New System.Drawing.Size(80, 20)
        Me.LblSuccessors2.TabIndex = 58
        Me.LblSuccessors2.Text = "Successors"
        '
        'CBPredecessors2
        '
        Me.CBPredecessors2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPredecessors2.FormattingEnabled = True
        Me.CBPredecessors2.Items.AddRange(New Object() {"None", "Prepare area", "Get equipment", "Get tools", "Get supplies", "Move, object", "Add, object", "Change, object", "Delete, object", "Assemble, object", "Disassemble, object", "Clean, object", "Clean, area", "Construct, object", "Cook, object", "Repair, object"})
        Me.CBPredecessors2.Location = New System.Drawing.Point(424, 144)
        Me.CBPredecessors2.Name = "CBPredecessors2"
        Me.CBPredecessors2.Size = New System.Drawing.Size(121, 28)
        Me.CBPredecessors2.TabIndex = 57
        '
        'LblPredecessors2
        '
        Me.LblPredecessors2.AutoSize = True
        Me.LblPredecessors2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredecessors2.Location = New System.Drawing.Point(429, 119)
        Me.LblPredecessors2.Name = "LblPredecessors2"
        Me.LblPredecessors2.Size = New System.Drawing.Size(94, 20)
        Me.LblPredecessors2.TabIndex = 56
        Me.LblPredecessors2.Text = "Predecessors"
        '
        'CBProcess2
        '
        Me.CBProcess2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBProcess2.FormattingEnabled = True
        Me.CBProcess2.Items.AddRange(New Object() {"Add", "Change", "Delete", "Assemble", "Disassemble", "Clean", "Construct", "Cook", "Repair"})
        Me.CBProcess2.Location = New System.Drawing.Point(415, 33)
        Me.CBProcess2.Name = "CBProcess2"
        Me.CBProcess2.Size = New System.Drawing.Size(121, 28)
        Me.CBProcess2.TabIndex = 55
        '
        'LblProcess2
        '
        Me.LblProcess2.AutoSize = True
        Me.LblProcess2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcess2.Location = New System.Drawing.Point(420, 8)
        Me.LblProcess2.Name = "LblProcess2"
        Me.LblProcess2.Size = New System.Drawing.Size(81, 20)
        Me.LblProcess2.TabIndex = 54
        Me.LblProcess2.Text = "Process 2 ?"
        '
        'LblRArrow1
        '
        Me.LblRArrow1.AutoSize = True
        Me.LblRArrow1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRArrow1.Location = New System.Drawing.Point(369, 16)
        Me.LblRArrow1.Name = "LblRArrow1"
        Me.LblRArrow1.Size = New System.Drawing.Size(29, 20)
        Me.LblRArrow1.TabIndex = 68
        Me.LblRArrow1.Text = "--->"
        '
        'LblRArrow2
        '
        Me.LblRArrow2.AutoSize = True
        Me.LblRArrow2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRArrow2.Location = New System.Drawing.Point(561, 16)
        Me.LblRArrow2.Name = "LblRArrow2"
        Me.LblRArrow2.Size = New System.Drawing.Size(29, 20)
        Me.LblRArrow2.TabIndex = 69
        Me.LblRArrow2.Text = "--->"
        '
        'LblLArrow1
        '
        Me.LblLArrow1.AutoSize = True
        Me.LblLArrow1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLArrow1.Location = New System.Drawing.Point(369, 41)
        Me.LblLArrow1.Name = "LblLArrow1"
        Me.LblLArrow1.Size = New System.Drawing.Size(29, 20)
        Me.LblLArrow1.TabIndex = 70
        Me.LblLArrow1.Text = "<---"
        '
        'LblLArrow2
        '
        Me.LblLArrow2.AutoSize = True
        Me.LblLArrow2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLArrow2.Location = New System.Drawing.Point(561, 41)
        Me.LblLArrow2.Name = "LblLArrow2"
        Me.LblLArrow2.Size = New System.Drawing.Size(29, 20)
        Me.LblLArrow2.TabIndex = 71
        Me.LblLArrow2.Text = "<---"
        '
        'LblRArrow3
        '
        Me.LblRArrow3.AutoSize = True
        Me.LblRArrow3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRArrow3.Location = New System.Drawing.Point(378, 204)
        Me.LblRArrow3.Name = "LblRArrow3"
        Me.LblRArrow3.Size = New System.Drawing.Size(29, 20)
        Me.LblRArrow3.TabIndex = 72
        Me.LblRArrow3.Text = "--->"
        '
        'LblRArrow4
        '
        Me.LblRArrow4.AutoSize = True
        Me.LblRArrow4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRArrow4.Location = New System.Drawing.Point(561, 200)
        Me.LblRArrow4.Name = "LblRArrow4"
        Me.LblRArrow4.Size = New System.Drawing.Size(29, 20)
        Me.LblRArrow4.TabIndex = 73
        Me.LblRArrow4.Text = "--->"
        '
        'LblLArrow3
        '
        Me.LblLArrow3.AutoSize = True
        Me.LblLArrow3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLArrow3.Location = New System.Drawing.Point(369, 144)
        Me.LblLArrow3.Name = "LblLArrow3"
        Me.LblLArrow3.Size = New System.Drawing.Size(29, 20)
        Me.LblLArrow3.TabIndex = 74
        Me.LblLArrow3.Text = "<---"
        '
        'LblLArrow4
        '
        Me.LblLArrow4.AutoSize = True
        Me.LblLArrow4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLArrow4.Location = New System.Drawing.Point(561, 152)
        Me.LblLArrow4.Name = "LblLArrow4"
        Me.LblLArrow4.Size = New System.Drawing.Size(29, 20)
        Me.LblLArrow4.TabIndex = 75
        Me.LblLArrow4.Text = "<---"
        '
        'RTBExplanations
        '
        Me.RTBExplanations.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBExplanations.Location = New System.Drawing.Point(790, 34)
        Me.RTBExplanations.Name = "RTBExplanations"
        Me.RTBExplanations.Size = New System.Drawing.Size(206, 274)
        Me.RTBExplanations.TabIndex = 76
        Me.RTBExplanations.Text = ""
        '
        'LblExplanations
        '
        Me.LblExplanations.AutoSize = True
        Me.LblExplanations.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExplanations.Location = New System.Drawing.Point(786, 8)
        Me.LblExplanations.Name = "LblExplanations"
        Me.LblExplanations.Size = New System.Drawing.Size(85, 20)
        Me.LblExplanations.TabIndex = 77
        Me.LblExplanations.Text = "Explanations"
        '
        'FrmProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 450)
        Me.Controls.Add(Me.LblExplanations)
        Me.Controls.Add(Me.RTBExplanations)
        Me.Controls.Add(Me.LblLArrow4)
        Me.Controls.Add(Me.LblLArrow3)
        Me.Controls.Add(Me.LblRArrow4)
        Me.Controls.Add(Me.LblRArrow3)
        Me.Controls.Add(Me.LblLArrow2)
        Me.Controls.Add(Me.LblLArrow1)
        Me.Controls.Add(Me.LblRArrow2)
        Me.Controls.Add(Me.LblRArrow1)
        Me.Controls.Add(Me.CBSubProcesses2)
        Me.Controls.Add(Me.LblSubProcesses2)
        Me.Controls.Add(Me.CBSideEffects2)
        Me.Controls.Add(Me.LblSideEffects2)
        Me.Controls.Add(Me.CBEnergy2)
        Me.Controls.Add(Me.LblEnergy2)
        Me.Controls.Add(Me.CBAction2)
        Me.Controls.Add(Me.LblAction2)
        Me.Controls.Add(Me.CBSuccessors2)
        Me.Controls.Add(Me.LblSuccessors2)
        Me.Controls.Add(Me.CBPredecessors2)
        Me.Controls.Add(Me.LblPredecessors2)
        Me.Controls.Add(Me.CBProcess2)
        Me.Controls.Add(Me.LblProcess2)
        Me.Controls.Add(Me.CBSubProcesses3)
        Me.Controls.Add(Me.LblSubProcesses3)
        Me.Controls.Add(Me.CBSideEffects3)
        Me.Controls.Add(Me.LblSideEffects3)
        Me.Controls.Add(Me.CBEnergy3)
        Me.Controls.Add(Me.LblEnergy3)
        Me.Controls.Add(Me.CBAction3)
        Me.Controls.Add(Me.LblAction3)
        Me.Controls.Add(Me.CBSuccessors3)
        Me.Controls.Add(Me.LblSuccessors3)
        Me.Controls.Add(Me.CBPredecessors3)
        Me.Controls.Add(Me.LblPredecessors3)
        Me.Controls.Add(Me.CBProcess3)
        Me.Controls.Add(Me.LblProcess3)
        Me.Controls.Add(Me.CBSubProcesses1)
        Me.Controls.Add(Me.LblSubProcesses1)
        Me.Controls.Add(Me.CBSideEffects1)
        Me.Controls.Add(Me.LblSideEffects1)
        Me.Controls.Add(Me.CBEnergy1)
        Me.Controls.Add(Me.LblEnergy1)
        Me.Controls.Add(Me.CBAction1)
        Me.Controls.Add(Me.LblAction1)
        Me.Controls.Add(Me.CBSuccessors1)
        Me.Controls.Add(Me.LblSuccessors1)
        Me.Controls.Add(Me.CBPredecessors1)
        Me.Controls.Add(Me.LblPredecessors1)
        Me.Controls.Add(Me.CBHow)
        Me.Controls.Add(Me.CBWhy)
        Me.Controls.Add(Me.CBWhere)
        Me.Controls.Add(Me.CBWhat)
        Me.Controls.Add(Me.CBWho)
        Me.Controls.Add(Me.CBProcess1)
        Me.Controls.Add(Me.LblProcess1)
        Me.Controls.Add(Me.TBHowMuch)
        Me.Controls.Add(Me.LblHowMuch)
        Me.Controls.Add(Me.LblHow)
        Me.Controls.Add(Me.LblWhy)
        Me.Controls.Add(Me.TBWhen)
        Me.Controls.Add(Me.LblWhen)
        Me.Controls.Add(Me.LblWhere)
        Me.Controls.Add(Me.LblWhat)
        Me.Controls.Add(Me.LblWho)
        Me.Name = "FrmProcess"
        Me.Text = "Process Form"
        CType(Me.BdElements1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd_Elements1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblWho As Label
    Friend WithEvents LblWhat As Label
    Friend WithEvents LblWhere As Label
    Friend WithEvents TBWhen As TextBox
    Friend WithEvents LblWhen As Label
    Friend WithEvents LblWhy As Label
    Friend WithEvents LblHow As Label
    Friend WithEvents TBHowMuch As TextBox
    Friend WithEvents LblHowMuch As Label
    Friend WithEvents LblProcess1 As Label
    Friend WithEvents CBProcess1 As ComboBox
    Friend WithEvents CBWho As ComboBox
    Friend WithEvents CBWhat As ComboBox
    Friend WithEvents CBWhere As ComboBox
    Friend WithEvents CBWhy As ComboBox
    Friend WithEvents CBHow As ComboBox
    Friend WithEvents CBPredecessors1 As ComboBox
    Friend WithEvents LblPredecessors1 As Label
    Friend WithEvents CBSuccessors1 As ComboBox
    Friend WithEvents LblSuccessors1 As Label
    Friend WithEvents CBAction1 As ComboBox
    Friend WithEvents LblAction1 As Label
    Friend WithEvents CBSideEffects1 As ComboBox
    Friend WithEvents LblSideEffects1 As Label
    Friend WithEvents CBEnergy1 As ComboBox
    Friend WithEvents LblEnergy1 As Label
    Friend WithEvents CBSubProcesses1 As ComboBox
    Friend WithEvents LblSubProcesses1 As Label
    Friend WithEvents CBSubProcesses3 As ComboBox
    Friend WithEvents LblSubProcesses3 As Label
    Friend WithEvents CBSideEffects3 As ComboBox
    Friend WithEvents LblSideEffects3 As Label
    Friend WithEvents CBEnergy3 As ComboBox
    Friend WithEvents LblEnergy3 As Label
    Friend WithEvents CBAction3 As ComboBox
    Friend WithEvents LblAction3 As Label
    Friend WithEvents CBSuccessors3 As ComboBox
    Friend WithEvents LblSuccessors3 As Label
    Friend WithEvents CBPredecessors3 As ComboBox
    Friend WithEvents LblPredecessors3 As Label
    Friend WithEvents CBProcess3 As ComboBox
    Friend WithEvents LblProcess3 As Label
    Friend WithEvents CBSubProcesses2 As ComboBox
    Friend WithEvents LblSubProcesses2 As Label
    Friend WithEvents CBSideEffects2 As ComboBox
    Friend WithEvents LblSideEffects2 As Label
    Friend WithEvents CBEnergy2 As ComboBox
    Friend WithEvents LblEnergy2 As Label
    Friend WithEvents CBAction2 As ComboBox
    Friend WithEvents LblAction2 As Label
    Friend WithEvents CBSuccessors2 As ComboBox
    Friend WithEvents LblSuccessors2 As Label
    Friend WithEvents CBPredecessors2 As ComboBox
    Friend WithEvents LblPredecessors2 As Label
    Friend WithEvents CBProcess2 As ComboBox
    Friend WithEvents LblProcess2 As Label
    Friend WithEvents LblRArrow1 As Label
    Friend WithEvents LblRArrow2 As Label
    Friend WithEvents LblLArrow1 As Label
    Friend WithEvents LblLArrow2 As Label
    Friend WithEvents LblRArrow3 As Label
    Friend WithEvents LblRArrow4 As Label
    Friend WithEvents LblLArrow3 As Label
    Friend WithEvents LblLArrow4 As Label
    Friend WithEvents RTBExplanations As RichTextBox
    Friend WithEvents LblExplanations As Label
    Friend WithEvents BdElements1DataSetBindingSource As BindingSource
    Friend WithEvents Bd_Elements1DataSet As bd_Elements1DataSet
End Class
