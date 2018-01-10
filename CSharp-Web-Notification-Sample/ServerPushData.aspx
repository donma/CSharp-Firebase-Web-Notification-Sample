<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerPushData.aspx.cs" Inherits="CSharp_Web_Notification_Sample.ServerPushData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnPushAllUsers" runat="server" Text="推送給所有用戶" OnClick="btnPushAllUsers_Click" />
        </div>
    </form>
</body>
</html>
