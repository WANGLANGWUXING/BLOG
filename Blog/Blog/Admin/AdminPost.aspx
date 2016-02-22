<%@ Page Title="文章列表" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="AdminPost.aspx.cs" Inherits="Blog.Admin.AdminPost" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Style/AdminPost.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>文章
            <a href="AdminWritePost.aspx" class="page-title">写文章</a>
        </h1>
        <div class="form">
            <table class="list-table">
                <thead>
                    <tr>
                        <th class="list-table-title">标题</th>
                        <th class="list-table-cate">分类</th>
                        <th class="list-table-comment">评论</th>
                        <th class="list-table-date">日期</th>
                        <th class="list-table-action">操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="postList" runat="server" OnItemDataBound="postList_ItemDataBound">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("Title") %></td>
                                <td>
                                    <asp:HiddenField ID="cateID" runat="server" Value='<%#Eval("TaxonomyId") %>' />
                                    <asp:Label ID="cateName" runat="server" Text="未分类"></asp:Label>
                                </td>
                                <td>
                                    <asp:HiddenField ID="postID" runat="server" Value='<%#Eval("PostId") %>' />
                                    <asp:Label ID="commentCount" runat="server" Text="0条评论"></asp:Label>
                                </td>
                                <td><%#Eval("PublishTime") %></td>
                                <td><a href="AdminWritePost.aspx?postId=<%#Eval("PostId") %>">编辑</a>|
                                    <a href="AdminPost.aspx?postId=<%#Eval("PostId")%>">删除</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>

            </table>
            <div class="pager">
                <webdiyer:AspNetPager ID="pagerPost" runat="server" PageSize="10" OnPageChanged="pagerPost_PageChanged" FirstPageText="首页"
                    LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" CurrentPageButtonPosition="Center"
                    Width="100%" HorizontalAlign="center" AlwaysShowFirstLastPageNumber="true" PagingButtonSpacing="10">
                </webdiyer:AspNetPager>
            </div>
        </div>
    </div>
</asp:Content>
