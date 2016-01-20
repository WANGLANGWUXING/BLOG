<%@ Page Title="无心的博客首页" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Blog.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/Index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rptPostList" runat="server" OnItemDataBound="rptPostList_ItemDataBound">
        <ItemTemplate>
            <div class="post">
                <header class="post-header">
                    <h2>
                        <a href="Details.aspx"><%#Eval("Title") %></a>
                    </h2>
                </header>
                <div class="post-content">
                    <p><%#Eval("Post") %></p>
                </div>
                <footer class="post-footer">
                    <span class="post-on">
                        <a href="#"><%#Eval("PublishTime") %></a>     </span>
                    <span class="cataegory-link">
                        <asp:HiddenField ID="CategoryID" runat="server" Value='<%#Eval("TaxonomyId") %>' />
                        <asp:LinkButton ID="CategoryName" runat="server"></asp:LinkButton>
                    </span>
                    <span class="comments-link">
                        <a href="#">评论</a>
                    </span>
                </footer>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
