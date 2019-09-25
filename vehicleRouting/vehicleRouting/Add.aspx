<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="vehicleRouting.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>Customer Name</td>
                <td id="name">
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email Address</td>
                <td id="emailAddress">
                    <asp:TextBox ID="emailAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td id="address">
                    <asp:TextBox ID="address" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Packages</td>
                <td id="packages">
                    <asp:TextBox ID="packages" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Delivery Date</td>
                <td id="deliveryDate">
                    <asp:TextBox ID="deliveryDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Due Date</td>
                <td id="dueDate">
                    <asp:TextBox ID="dueDate" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="create" runat="server" OnClick="Button1_Click" Text="Create" />
    </form>
</body>
</html>
