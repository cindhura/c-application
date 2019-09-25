<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetrievePackage.aspx.cs" Inherits="vehicleRouting.RetrievePackage" %>
<form runat="server" >
    <table>
        <tr>
            <td><b>Customer Name:</b></td>
            <td>
               <asp:PlaceHolder ID="customerName" runat="server"></asp:PlaceHolder>
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="PackageID" HeaderText="Package ID" />
            <asp:BoundField ItemStyle-Width="150px" DataField="PackageWidth" HeaderText="Package Width" />
            <asp:BoundField ItemStyle-Width="150px" DataField="PackageHeight" HeaderText="Package Height" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="AddPackage" runat="server" OnClick="Button1_Click" Text="Add Package" />
</form>