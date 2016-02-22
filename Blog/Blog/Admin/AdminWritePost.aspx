<%@ Page Title="文章添加及编辑" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="AdminWritePost.aspx.cs" Inherits="Blog.Admin.AdminWritePost" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Style/writepost.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>文章添加及编辑
            <a href="AdminPost.aspx" class="page-title">文章列表</a>
        </h1>
        <div class="form">
            <div class="titlediv">
                <label>标题：</label>
                <asp:TextBox ID="txtTitle" runat="server" CssClass="title"></asp:TextBox>
            </div>
            <div class="category">
                <label>分类：</label>
                <asp:DropDownList ID="ddlcate" CssClass="cate" runat="server">
                </asp:DropDownList>
            </div>
            <div class="postdiv">
                <label>文章内容：</label>
                <CKEditor:CKEditorControl ID="postdesc" BasePath="~/ckeditor" runat="server"></CKEditor:CKEditorControl>
            </div>
            <div>
                <asp:Button ID="btnaddpost" runat="server" CssClass="btnpostadd" Text="发布文章" OnClick="btnaddpost_Click" />
            </div>
        </div>
    </div>
</asp:Content>
