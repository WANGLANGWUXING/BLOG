<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Blog.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="images/favicon.jpg" type="image/x-icon" rel="shortcut icon" />
    <title>登录</title>
    <link href="Style/Login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <div class="form">
                <p>
                    <label>
                        用户名<br />
                        <asp:TextBox ID="AdminName" runat="server" CssClass="input" Font-Size="20" MaxLength="20"></asp:TextBox>
                    </label>
                </p>
                <p>
                    <label>
                        密码<br />
                        <asp:TextBox ID="AdminPwd" runat="server" CssClass="input" TextMode="Password" Font-Size="20" MaxLength="20"></asp:TextBox>
                    </label>
                </p>
                <p class="remember">
                    <label>
                        <asp:CheckBox ID="rememberCB" runat="server" CssClass="checkbox" />
                        记住我的登录信息
                    </label>
                </p>
                <p>
                    <asp:Button ID="btnLogin" runat="server" CssClass="btnlogin" Text="登录" OnClick="btnLogin_Click" />
                </p>
            </div>
            <p class="nav">
                <a href="Register.aspx">注册</a>|
                <a href="#">找回密码</a>
            </p>
            <p class="backblog">
                <a href="Index.aspx" style="font-size: 13px; padding: 0 24px;">←回到博客首页</a>
            </p>
        </div>
    </form>
</body>
</html>
