<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Blog.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="images/favicon.jpg" type="image/x-icon" rel="shortcut icon" />
    <link href="Style/Register.css" rel="stylesheet" />
    <link href="Style/Login.css" rel="stylesheet" />
    <title>注册</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register login">
            <p class="message">在这个站点注册</p>
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
                <p>
                    <asp:Button ID="btnReg" runat="server" CssClass="btnlogin" Text="注册" OnClick="btnReg_Click" />
                </p>
            </div>
            <p class="nav">
                <a href="Login.aspx">登录</a>
            </p>
            <p class="backblog">
                <a href="Index.aspx" style="font-size: 13px; padding: 0 24px;">←回到博客首页</a>
            </p>
        </div>
    </form>
</body>
</html>
