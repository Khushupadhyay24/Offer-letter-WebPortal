<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wb.aspx.cs" Inherits="EmployeeOL.wb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>body {
    padding:50px;
background-color: #f4f4f4;
color: #ffd800;
font-family: 'Open Sans', Arial, Helvetica, sans-serif;
font-size: 20px;
line-height: 1.5em;

}
a { text-decoration: none; }
/*h1 { font-size: 1em; }
h1, p {
margin-bottom: 10px;
}*/
strong {
font-weight: bold;
font-size:1.2rem;
text-align:center;
}
.uppercase { text-transform: uppercase; }

/* ---------- LOGIN ---------- */
#login {
margin: 50px auto;
width: 300px;
height:100vh;
}
form fieldset input[type="text"], input[type="password"] {
background-color: #e5e5e5;
border: none;
border-radius: 3px;
-moz-border-radius: 3px;
-webkit-border-radius: 3px;
color: #5a5656;
font-family: 'Open Sans', Arial, Helvetica, sans-serif;
font-size: 14px;
height: 50px;
outline: none;
padding: 0px 10px;
width: 280px;
-webkit-appearance:none;
}
form fieldset input[type="submit"] {
background-color: #ffd800;
border: none;
border-radius: 3px;
-moz-border-radius: 3px;
-webkit-border-radius: 3px;
color: #000000;
cursor: pointer;
font-family: 'Open Sans', Arial, Helvetica, sans-serif;
height: 50px;
text-transform: uppercase;
width: 300px;
-webkit-appearance:none;
}
form fieldset input[type="submit"]:hover{
    color:azure;
}
form fieldset a {
color: #5a5656;
font-size: 10px;
}
form fieldset a:hover { text-decoration: underline; }
.btn-round {
background-color: #ffd800;
border-radius: 50%;
-moz-border-radius: 50%;
-webkit-border-radius: 50%;
color: #ffd800;
display: block;
font-size: 12px;
height: 50px;
line-height: 50px;
margin: 30px 125px;
text-align: center;
text-transform: uppercase;
width: 50px;
}
lb1 {
    text-align:left;
}

    </style>
</head>
<body style="background-color:#1c87c9">
     <form id="form1" runat="server">
    <div id="login" align="center">
    <fieldset style ="width:300px;">
        
    <legend> <strong>Admin Login</strong></legend>
         <asp:Label ID="lb1" Text="Name" runat="server"></asp:Label>
        <asp:TextBox ID="txtusername" placeholder="username" runat="server"
            Width="280px"></asp:TextBox>
       
        <br />
        <br />
        <asp:TextBox ID="txtpassword" placeholder="password" runat="server"
            Width="280px" TextMode="Password"></asp:TextBox>
       
        <br />
        <br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit"
           Width="280px" onclick="btnsubmit_Click" />
            <br />
           
    </fieldset>
    </div>

    </form>
</body>
</html>
