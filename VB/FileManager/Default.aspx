<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Q25403.Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxFileManager ID="ASPxFileManager1" runat="server">
				<Settings RootFolder="~\" ThumbnailFolder="~\Thumb\" />
				<SettingsEditing AllowDelete="true" AllowRename="true" AllowCreate="true" AllowMove="true" />
			</dx:ASPxFileManager>
		</div>
	</form>
</body>
</html>
