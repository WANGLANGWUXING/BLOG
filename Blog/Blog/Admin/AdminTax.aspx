<%@ Page Title="分类列表" Language="C#" MasterPageFile="~/Admin/AdminMain.Master" AutoEventWireup="true" CodeBehind="AdminTax.aspx.cs" Inherits="Blog.Admin.AdminTax" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/AdminPost.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>分类
            <a href="AdminTaxWrite.aspx" class="page-title">新分类</a>
        </h1>
        <div class="form">
            <table class="list-table">
                <thead>
                    <tr>
                        <th class="list-table-cateName">分类名称</th>
                        <th class="list-table-Catedesc">分类描述</th>
                        <th class="list-table-edit">操作
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="cateList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("TaxonomyName") %></td>
                                <td><%#Eval("Taxonomydesc") %></td>
                                <td>
                                    <a href="AdminTaxWrite.aspx?taxId=<%#Eval("TaxonomyId") %>">编辑</a>
                                    <a href="AdminTax.aspx?taxId=<%#Eval("TaxonomyId") %>">删除</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div class="pager">
                <webdiyer:AspNetPager ID="pagerCate" runat="server" OnPageChanged="pagerCate_PageChanged" PageSize="10" FirstPageText="首页"
                    LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" CurrentPageButtonPosition="Center"
                    Width="100%" HorizontalAlign="center" AlwaysShowFirstLastPageNumber="true" PagingButtonSpacing="10">
                </webdiyer:AspNetPager>
            </div>
        </div>
    </div>
</asp:Content>
