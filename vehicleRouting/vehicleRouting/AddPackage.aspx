<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPackage.aspx.cs" Inherits="vehicleRouting.AddPackage" %>

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
                <td>
                    <asp:PlaceHolder ID="customerName" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td>Package Height</td>
                <td>
                    <asp:TextBox ID="packageHeight" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Package Width</td>
                <td>
                    <asp:TextBox ID="packageWidth" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="package" runat="server" OnClick="Button1_Click" Text="Add Package" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
