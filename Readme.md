# ASPxFileManager - How to restrict editing folders and allow editing files at the same time


<p>This example illustrates how to restrict editing folders in the ASPxFileManager control while supporting editing files.</p><p>This functionality may be implemented by creating <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxFileManagerFileManagerFolderAccessRuletopic"><u>FileManagerFolderAccessRule</u></a> rules with the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerFileManagerAccessRuleBase_Edittopic"><u>FileManagerAccessRuleBase.Edit Property</u></a> set to the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerRightsEnumtopic"><u>Rights.Deny</u></a> value and the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerFileManagerFolderAccessRule_EditContentstopic"><u>FileManagerFolderAccessRule.EditContents Property</u></a> set to the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerRightsEnumtopic"><u>Rights.Allow</u></a> value.</p><p>In this case, it is required to adjust these rules for all ASPxFileManager folders recursively.</p>

<br/>


