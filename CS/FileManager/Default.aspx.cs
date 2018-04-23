using DevExpress.Web.ASPxFileManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q25403 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ApplyRules(ASPxFileManager1.SelectedFolder);
        }

        void ApplyRules(FileManagerFolder folder) {
            FileManagerFolder[] folders = folder.GetFolders();

            for (int i = 0; i < folders.Length; i++) {
                FileManagerFolderAccessRule folderEditingRule = new FileManagerFolderAccessRule(folders[i].RelativeName);
                folderEditingRule.Edit = Rights.Deny;
                FileManagerFolderAccessRule folderContentEditingRule = new FileManagerFolderAccessRule(folders[i].RelativeName);
                folderContentEditingRule.EditContents = Rights.Allow;

                ASPxFileManager1.SettingsPermissions.AccessRules.Add(folderEditingRule);
                ASPxFileManager1.SettingsPermissions.AccessRules.Add(folderContentEditingRule);

                ApplyRules(folders[i]);
            }
        }
    }
}