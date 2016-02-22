<%@ Page Title="博客后台首页" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="AdminIndex.aspx.cs" Inherits="Blog.Admin.AdminIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/AdminMain.css" rel="stylesheet" />
    <link href="Style/AdminIndex.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <div class="dashboard-widgets-wrap">
            <div class="holder">
                <div class="postbox">
                    <div class="meta-box">
                        <div class="postbox-container">
                            <h2 class="handle">
                                <span>概览
                                </span>
                            </h2>
                            <div class="inside">
                                <div class="main">
                                    <ul>
                                        <li>
                                            <a href="#" class="post count">
                                                <asp:Label ID="post" runat="server" Text="0篇文章"></asp:Label></a>
                                        </li>
                                        <li>
                                            <a href="#" class="cate count">
                                                <asp:Label ID="comment" runat="server" Text="0条评论"></asp:Label></a>
                                        </li>
                                        <li>
                                            <a href="#" class="comment count">
                                                <asp:Label ID="cate" runat="server" Text="0个分类"></asp:Label></a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
