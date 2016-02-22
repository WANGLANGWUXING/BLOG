<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="AdminTaxWrite.aspx.cs" Inherits="Blog.Admin.AdminTaxWrite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/writepost.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>分类添加及编辑
            <a href="AdminTax.aspx" class="page-title">分类列表</a>
        </h1>
        <div class="form">
            <div class="titlediv">
                <label>分类名：</label>
                <asp:TextBox ID="txtTaxName" runat="server" CssClass="title"></asp:TextBox>
            </div>
            <div class="category">
                <label>分类描述：</label>
                <asp:TextBox ID="txtTaxDesc" runat="server" CssClass="title"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnaddTax" runat="server" CssClass="btnpostadd" Text="添加分类" OnClick="btnaddTax_Click" />
            </div>
        </div>
    </div>
</asp:Content>
