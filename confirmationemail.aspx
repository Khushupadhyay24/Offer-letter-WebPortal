<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmationemail.aspx.cs" Inherits="EmployeeOL.confirmationemail" %>

<!DOCTYPE html>
<html>
<head>
<title>Send Mail</title>
<%--<script src="https://smtpjs.com/v3/smtp.js">
</script>

<script type="text/javascript">
	function sendEmail() {
	Email.send({
		Host: "smtp.gmail.com",
        Username: "khushupadhyay5020@gmail.com",
        Password: "nbpubsfvnvdrqhcv",
        To: 'khushupadhyay5020@gmail.com',  
		From: "pariupadhyay456@gmail.com",
		Subject: "Sending Email using javascript",
		Body: "Well that was easy!!",
	})
		.then(function (message) {
		alert("mail sent successfully")
		});
	}
</script>--%>
</head>

<body>
<%--<form method="post">
	<input type="button" value="Send Email"
		onclick="sendEmail()" />
</form>--%>
</body>
</html>

<%--<script type = "text/javascript">
    function Confirm() {
        var confirm_value = document.createElement("INPUT");
        confirm_value.type = "hidden";
        confirm_value.name = "confirm_value";
        if (confirm("Do you want to save data?")) {
            confirm_value.value = "Yes";
        } else {
            confirm_value.value = "No";
        }
        document.forms[0].appendChild(confirm_value);
    }
</script>--%>
