Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace Q25403
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ApplyRules(ASPxFileManager1.SelectedFolder)
		End Sub

		Private Sub ApplyRules(ByVal folder As FileManagerFolder)
			Dim folders() As FileManagerFolder = folder.GetFolders()

			For i As Integer = 0 To folders.Length - 1
				Dim folderEditingRule As New FileManagerFolderAccessRule(folders(i).RelativeName)
				folderEditingRule.Edit = Rights.Deny
				Dim folderContentEditingRule As New FileManagerFolderAccessRule(folders(i).RelativeName)
				folderContentEditingRule.EditContents = Rights.Allow

				ASPxFileManager1.SettingsPermissions.AccessRules.Add(folderEditingRule)
				ASPxFileManager1.SettingsPermissions.AccessRules.Add(folderContentEditingRule)

				ApplyRules(folders(i))
			Next i
		End Sub
	End Class
End Namespace