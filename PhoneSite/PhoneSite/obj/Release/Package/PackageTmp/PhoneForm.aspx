<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhoneForm.aspx.cs" Inherits="PhoneSite.PhoneForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h1>PHONE LIST</h1>
       <asp:TextBox ID="txtKeyword" runat="server" />
       <asp:Button ID="bntSearch" runat="server" Text="SEARCH" OnClick="btnSearch_Click" /><br/><br/>
       <asp:GridView ID="gvPhones" runat="server" AutoGenerateSelectButton="true"
           OnSelectedIndexChanged="gvPhones_SelectedIndexChanged" /><br/>
        <h1>PHONE DETAILS</h1>
        <table>
            <tr>
                <td>Code</td>
                <td><asp:TextBox ID="txtCode" runat="server" ReadOnly="true"/></td>
            </tr>
            <tr>
                <td>Name</td>
                <td><asp:TextBox ID="txtName" runat="server"/></td>
            </tr>
            <tr>
                <td>Color</td>
                <td><asp:TextBox ID="txtColor" runat="server"/></td>
            </tr>
            <tr>
                <td>Price</td>
                <td><asp:TextBox ID="txtPrice" runat="server"/></td>
            </tr>
            <tr>
                <td>Quantity</td>
                <td><asp:TextBox ID="txtQuantity" runat="server"/></td>
            </tr>
        </table><br/>
        
        <asp:Button ID="btnAdd" runat="server" Text="ADD NEW" OnClick="btnAdd_Click"/>
        <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click"/>
        <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" OnClientClick="return confirm('Are You Sure?');"/>
    </form>
</body>
</html>
