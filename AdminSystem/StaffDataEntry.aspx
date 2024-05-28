<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 97px; top: 15px; position: absolute; width: 168px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblNameId" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Name "></asp:Label>
            <asp:TextBox ID="txtNameId" runat="server" style="z-index: 1; left: 95px; top: 53px; position: absolute; width: 169px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPositionId" runat="server" style="z-index: 1; left: 10px; top: 94px; position: absolute; bottom: 563px" Text="Position"></asp:Label>
        <asp:TextBox ID="txtPositionId" runat="server" style="z-index: 1; left: 96px; top: 91px; position: absolute; width: 168px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEmailId" runat="server" style="z-index: 1; left: 11px; top: 126px; position: absolute; height: 29px" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmailId" runat="server" style="z-index: 1; left: 96px; top: 126px; position: absolute; width: 168px; height: 18px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPhoneId" runat="server" style="z-index: 1; top: 168px; position: absolute; left: 11px" Text="Phone"></asp:Label>
        <asp:TextBox ID="txtPhoneId" runat="server" style="z-index: 1; left: 96px; top: 167px; position: absolute; width: 170px"></asp:TextBox>
        <asp:Label ID="lblHiredateId" runat="server" style="z-index: 1; left: 11px; top: 209px; position: absolute" Text="Hiredate "></asp:Label>
        <asp:TextBox ID="txtHiredateId" runat="server" style="z-index: 1; left: 101px; top: 206px; position: absolute; width: 169px; height: 18px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 217px; top: 242px; position: absolute; height: 52px; width: 76px" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 273px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 106px; top: 331px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 30px; top: 330px; position: absolute" Text="OK" />
        </p>
    </form>
</body>
</html>
