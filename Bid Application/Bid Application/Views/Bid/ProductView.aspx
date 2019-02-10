<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%--<asp:FormView ID="productDetail" runat="server" ItemType="WingtipToys.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
    --%>
    
    <h2>
        ProductView</h2>
    
    <asp:ListView ID="ListView1" runat="server" DataSourceID="MyProduct" ItemType="BidServiceLib.Class.Product">
        <%--<AlternatingItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="ProductImageLabel" runat="server" 
                        Text='<%# Eval("ProductImage") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductBidValueLabel" runat="server" 
                        Text='<%# Eval("ProductBidValue") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductDescriptionLabel" runat="server" 
                        Text='<%# Eval("ProductDescription") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductNameLabel" runat="server" 
                        Text='<%# Eval("ProductName") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>--%>
       <%-- <EditItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                        Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Cancel" />
                </td>
                <td>
                    <asp:TextBox ID="ProductImageTextBox" runat="server" 
                        Text='<%# Bind("ProductImage") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductBidValueTextBox" runat="server" 
                        Text='<%# Bind("ProductBidValue") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductDescriptionTextBox" runat="server" 
                        Text='<%# Bind("ProductDescription") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductNameTextBox" runat="server" 
                        Text='<%# Bind("ProductName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductIDTextBox" runat="server" 
                        Text='<%# Bind("ProductID") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>
                        No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                        Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="ProductImageTextBox" runat="server" 
                        Text='<%# Bind("ProductImage") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductBidValueTextBox" runat="server" 
                        Text='<%# Bind("ProductBidValue") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductDescriptionTextBox" runat="server" 
                        Text='<%# Bind("ProductDescription") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductNameTextBox" runat="server" 
                        Text='<%# Bind("ProductName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProductIDTextBox" runat="server" 
                        Text='<%# Bind("ProductID") %>' />
                </td>
            </tr>
        </InsertItemTemplate>--%>
        <ItemTemplate>
            <tr style="">
                <td>
                    <img alt="" src="http://localhost:61891/BidServiceIIS/Images/F3.jpg" />
                
              <%--      <asp:Label ID="ProductImageLabel" runat="server" 
                        Text='<%# Eval("ProductImage") %>' />--%>
                </td>
                <td>
                    <asp:Label ID="ProductBidValueLabel" runat="server" 
                        Text='<%# Eval("ProductBidValue") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductDescriptionLabel" runat="server" 
                        Text='<%# Eval("ProductDescription") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductNameLabel" runat="server" 
                        Text='<%# Eval("ProductName") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="itemPlaceholderContainer" runat="server" border="0" style="">
                            <tr runat="server" style="">
                                <th runat="server">
                                    ProductImage</th>
                                <th runat="server">
                                    ProductBidValue</th>
                                <th runat="server">
                                    ProductDescription</th>
                                <th runat="server">
                                    ProductName</th>
                                <th runat="server">
                                    ProductID</th>
                            </tr>
                            <tr ID="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
       <%-- <SelectedItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="ProductImageLabel" runat="server" 
                        Text='<%# Eval("ProductImage") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductBidValueLabel" runat="server" 
                        Text='<%# Eval("ProductBidValue") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductDescriptionLabel" runat="server" 
                        Text='<%# Eval("ProductDescription") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductNameLabel" runat="server" 
                        Text='<%# Eval("ProductName") %>' />
                </td>
                <td>
                    <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>--%>
    </asp:ListView>
    <asp:ObjectDataSource ID="MyProduct" runat="server" SelectMethod="getProducts" TypeName="BidServiceLib.BidService">
    </asp:ObjectDataSource>



    <%--</asp:FormView>--%>
</asp:Content>
