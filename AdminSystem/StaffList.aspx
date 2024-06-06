<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="381px" Width="848px" ></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="50px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" Height="24px" OnClick="Button1_Click" Text="Edit" Width="51px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
