<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Retrieve.aspx.cs" Inherits="vehicleRouting.Retrieve" %>
<form runat="server" >
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="CustomerID" HeaderText="Customer ID" />
            <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Customer Name" />
            <asp:BoundField ItemStyle-Width="150px" DataField="EmailAddress" HeaderText="Email Address" />
            <asp:BoundField ItemStyle-Width="150px" DataField="Address" HeaderText="Address" />
            <asp:TemplateField HeaderText = "Package Count" ItemStyle-Width="30">
            <ItemTemplate>
                <asp:HyperLink runat="server" NavigateUrl='<%# Eval("CustomerID", "~/RetrievePackage.aspx?CustomerID={0}") %>'
                    Text='<%# Eval("packages") %>' />
            </ItemTemplate>
        </asp:TemplateField>
             <asp:BoundField ItemStyle-Width="150px" DataField="DeliveryDate" HeaderText="Delivery Date" />
             <asp:BoundField ItemStyle-Width="150px" DataField="DueDate" HeaderText="Due Date" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="AddCustomer" runat="server" OnClick="Button1_Click" Text="Add Customer" />
</form>
