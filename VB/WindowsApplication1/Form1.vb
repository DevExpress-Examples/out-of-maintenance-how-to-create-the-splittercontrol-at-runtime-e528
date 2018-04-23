Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.CreateMySplitControls()
		End Sub

		Private Sub CreateMySplitControls()
			Dim memoEdit1 As MemoEdit = New MemoEdit()
			memoEdit1.Text = "MemoEdit1"
			Dim memoEdit2 As MemoEdit = New MemoEdit()
			memoEdit2.Text = "MemoEdit2"
			Dim memoEdit3 As MemoEdit = New MemoEdit()
			memoEdit3.Text = "MemoEdit3"
			Dim splitter1 As SplitterControl = New SplitterControl()
			Dim splitter2 As SplitterControl = New SplitterControl()
			memoEdit1.Dock = DockStyle.Left
			splitter1.Dock = DockStyle.Left
			memoEdit2.Dock = DockStyle.Fill
			splitter2.Dock = DockStyle.Right
			memoEdit3.Dock = DockStyle.Right
			Me.Controls.AddRange(New Control() { memoEdit2, splitter1, memoEdit1, splitter2, memoEdit3 })
		End Sub

	End Class
End Namespace