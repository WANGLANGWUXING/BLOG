<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TaxPost.aspx.cs" Inherits="Blog.TaxPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/Index.css" rel="stylesheet" />
    <style type="text/css">
        .post {
            margin-top: 8.3333%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="page-header">
        <h1 class="page-title">分类：<asp:Label ID="txtTax" runat="server"></asp:Label></h1>
    </header>
    <asp:Repeater ID="rptPostList" runat="server" OnItemDataBound="rptPostList_ItemDataBound">
        <ItemTemplate>
            <div class="post">
                <header class="post-header">
                    <h2>
                        <a href="Details.aspx?PostId=<%#Eval("PostId") %>"><%#Eval("Title") %></a>
                    </h2>
                </header>
                <div class="post-content">
                    <p><%#Eval("Post") %></p>
                </div>
                <footer class="post-footer">
                    <span class="post-on">
                        <a href="Details.aspx?PostId=<%#Eval("PostId") %>"><%#Eval("PublishTime") %></a>     </span>
                    <span class="cataegory-link">
                        <asp:HiddenField ID="CategoryID" runat="server" Value='<%#Eval("TaxonomyId") %>' />
                        <asp:LinkButton ID="CategoryName" runat="server"></asp:LinkButton>
                    </span>
                    <span class="comments-link">
                        <a href="Details.aspx?PostId=<%#Eval("PostId") %>">评论</a>
                    </span>
                </footer>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
