<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128554555/13.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4838)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/FileManager/Default.aspx) (VB: [Default.aspx](./VB/FileManager/Default.aspx))
* [Default.aspx.cs](./CS/FileManager/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/FileManager/Default.aspx.vb))
<!-- default file list end -->
# ASPxFileManager - How to restrict editing folders and allow editing files at the same time
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4838/)**
<!-- run online end -->


<p>This example illustrates how to restrict editing folders in the ASPxFileManager control while supporting editing files.</p><p>This functionality may be implemented by creating <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxFileManagerFileManagerFolderAccessRuletopic"><u>FileManagerFolderAccessRule</u></a> rules with the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerFileManagerAccessRuleBase_Edittopic"><u>FileManagerAccessRuleBase.Edit Property</u></a> set to the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerRightsEnumtopic"><u>Rights.Deny</u></a> value and the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerFileManagerFolderAccessRule_EditContentstopic"><u>FileManagerFolderAccessRule.EditContents Property</u></a> set to the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerRightsEnumtopic"><u>Rights.Allow</u></a> value.</p><p>In this case, it is required to adjust these rules for all ASPxFileManager folders recursively.</p>

<br/>


