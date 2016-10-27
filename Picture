<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Picture Upload</title>
</head>
<body>
 <form id="form1" runat="server">
   <div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="True"
        OnRowCancelingEdit="GridView1_RowCancelingEdit" DataKeyNames="ID" 
        OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" >
        <Columns>
        <asp:TemplateField HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:LinkButton ID="LkB1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:LinkButton ID="LkB2" runat="server" CommandName="Update">Update</asp:LinkButton>
                <asp:LinkButton ID="LkB3" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>
        </asp:TemplateField>
 
        <asp:TemplateField HeaderText="Name" HeaderStyle-Width="200px">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txt_Name" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
              
        <asp:TemplateField HeaderText="Image" HeaderStyle-Width="200px">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Image") %>'
                     Height="80px" Width="100px" />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:Image ID="img_user" runat="server" ImageUrl='<%# Eval("Image") %>'
                     Height="80px" Width="100px" /><br />

                <asp:FileUpload ID="FileUpload1" runat="server" />
            </EditItemTemplate>
        </asp:TemplateField>
        </Columns> 
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:GridView>
   </div>
 </form>
</body>
</html>
 
