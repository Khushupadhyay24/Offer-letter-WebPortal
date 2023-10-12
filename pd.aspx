
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pd.aspx.cs" Inherits="EmployeeOL.pd" %>


<!DOCTYPE>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
<link rel="stylesheet" href="https://code.jquery.com/ui/1.11.1/themes/smoothness/jquery-ui.css"/>

</head>
<body>
   <script src="https://code.jquery.com/jquery-1.11.1.min.js"></script>
 
<script src="https://code.jquery.com/ui/1.11.1/jquery-ui.min.js"></script>
    <script src="https://smtpjs.com/v2/smtp.js"></script>

    <script type="text/javascript">
        $(function () {
            var filename = '<%=Session["txtemail"]%>'+'.txt';
            $("#btnShow").click(function () {
                $("#dialog").dialog({
               
                    modal: true,
                    title: filename,
                    width: 540,
                    height: 450,
                    buttons: {
                        "Accept": function() {
                            $.ajax({
                                type: "POST",
                                url: "confirmationemail.aspx/btnAccept",
                                contentType: "application/json; charset=utf-8",
                                dataType: "json",
                                success: function (response) {
                                   
                                    $("dialog").html(response);
                                   /* $('dialog').modal('Accept');*/
                                   
                                    alert("Successfully sent the email to the HR");
                                    
                                   
                                }
                                
                            });
                        },
                    "Reject": function () {
                        $.ajax({
                            type: "POST",
                            url: "confirmationemail.aspx/btnReject",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                
                                $("dialog").html(response);
                               // $('dialog').modal('Reject');
                                alert("Successfully sent the email to the HR");
                               
                            }
                        });
                    }
                },
                    
                    open: function () {
                        var object = "<object data=\"{FileName}\" type=\"application/txt\" width=\"500px\" height=\"300px\">";
                       /* object += "If you are unable to view file, you can download from <a href=\"{FileName}\">here</a>";*/
                        //object += " <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
                        //object += "</object>";
                        object = object.replace(/{FileName}/g, "PdfFiles/" + filename);
                        $("#dialog").html(object);
                    }
                });
            });
        });
      
    </script>
    <input id="btnShow" type="button" value="Show PDF" />
    <div id="dialog" style="display: none">
        <input id="btnAccept" type="button" value="Accept" />
         <input id="btnReject" type="button" value="Reject" />
    </div>
     
    
</body>
</html>

