<%@ Page Title="无心的博客首页" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Blog.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/Index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="rptPostList" runat="server">
        <ItemTemplate>
            <div class="post">
                <div class="post-header">
                    <h2>
                        <a href="Details.aspx"><%#Eval("Title") %></a>
                    </h2>
                </div>
                <div class="post-content">
                    <p><%#Eval("Post") %></p>
                </div>
                <div class="post-footer">
                    <span class="post-on"><%#Eval("PublishTime") %></span>
                    <span class="cataegory-link">
                        <asp:LinkButton ID="categoryLink" runat="server" Text=""></asp:LinkButton>
                    </span>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
