<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="AdminComment.aspx.cs" Inherits="Blog.Admin.AdminComment" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/AdminPost.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>评论</h1>
        <div class="form">
            <table class="list-table">
                <thead>
                    <tr>
                        <th class="list-table-commentTime">评论时间</th>
                        <th class="list-table-UserName">评论人</th>
                        <th class="list-table-commentDesc">评论内容</th>
                        <th class="list-table-Post">评论至</th>
                        <th class="list-table-del">操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="CommentList" runat="server" OnItemDataBound="CommentList_ItemDataBound">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("CommentsTime") %></td>
                                <td>
                                    <asp:HiddenField ID="UserId" runat="server" Value='<%#Eval("UserId") %>' />
                                    <asp:Label ID="userName" runat="server"></asp:Label></td>
                                <td><%#Eval("Commentsmeta") %></td>
                                <td>
                                    <asp:HiddenField ID="PostId" runat="server" Value='<%#Eval("PostId") %>' />
                                    <asp:Label ID="PostTitle" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <a href="AdminComment.aspx?commentid=<%#Eval("CommentId") %>">删除</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div class="pager">
                <webdiyer:AspNetPager ID="CommentPager" runat="server" PageSize="10" OnPageChanged="CommentPager_PageChanged" FirstPageText="首页"
                    LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" CurrentPageButtonPosition="Center"
                    Width="100%" HorizontalAlign="center" AlwaysShowFirstLastPageNumber="true" PagingButtonSpacing="10">
                </webdiyer:AspNetPager>
            </div>
        </div>
    </div>
</asp:Content>
