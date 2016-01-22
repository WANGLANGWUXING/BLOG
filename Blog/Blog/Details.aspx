<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Blog.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/Index.css" rel="stylesheet" />
    <link href="Style/Details.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="post">
        <header class="post-header">
            <h1>
                <asp:Label ID="lblTitle" runat="server" CssClass="title"></asp:Label>
            </h1>
        </header>
        <div class="post-content">
            <p>
                <asp:Label ID="PostDesc" runat="server"></asp:Label>
            </p>
        </div>
        <footer class="post-footer">
            <span class="post-on">
                <asp:LinkButton ID="PublishTime" runat="server"></asp:LinkButton>
            </span>
            <span class="cataegory-link">
                <asp:LinkButton ID="CategoryName" runat="server"></asp:LinkButton>
            </span>
        </footer>
    </div>
    <div class="comments-area">
        <div class="comment-respond">
            <h3 class="comment-reply-title">发表评论</h3>
            <div class="comment-form">
                <p class="comment-notes">
                    <span class="email-notes">电子邮件不会被公开。</span>
                    必填项已用
                    <span class="required">*</span>
                    标注
                </p>
                <p class="comment-form-comment">
                    <label>评论</label>
                    <textarea id="comment" name="comment" runat="server" cols="45" rows="8" required="required"></textarea>
                </p>
                <p class="comment-form-author">
                    <label>
                        姓名<span class="required">*</span>
                    </label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="input" require="require" size="30"></asp:TextBox>
                </p>
                <p class="comment-form-email">
                    <label>邮箱<span class="required">*</span></label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="input" require="require" size="30"></asp:TextBox>
                </p>
                <p class="submit">
                    <asp:Button ID="btnComment" CssClass="subBtn" Text="发表评论" runat="server" OnClick="btnComment_Click" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>
