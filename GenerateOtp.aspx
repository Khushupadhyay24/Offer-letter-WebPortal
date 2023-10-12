<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateOtp.aspx.cs" Inherits="EmployeeOL.GenerateOtp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Otp Login</title>
    <style>
        body{
  margin: 0;
  padding: 0;
  height: 30vh;
  background: #1c87c9;


}

.container{
  display: flex;
  flex-flow: column;
  height: 100%;
  /*//align-items:space-around;*/
  justify-content: center;
}

.userInput{
  display: flex;
  justify-content: center;
}

input{
  margin: 10px;
  height: 35px;
  width: 50px;
  border: none;
  border-radius: 5px;
  text-align: center;
  font-family: arimo;
  font-size: 1.2rem;
  background: #eef2f3;

}
.user{
    margin:0;
    padding:80px;
    color:honeydew;
    text-align:center;
    font-size:1.2rem;
    
}

h2{
  text-align: center;
  font-family: arimo;
  color: honeydew;
}


button{
  width: 150px;
  height: 40px;
  margin: 25px auto 0px auto;
  font-family: arimo;
  font-size: 1.1rem;
  border: none;
  border-radius: 5px;
  letter-spacing: 2px;
  cursor: pointer;
  background: #ffd800;
  
}
button:hover{
    color:azure;
}

    </style>
</head>


<body>
    <form id="form1" runat="server">
    <div class="user">
    
        <asp:Label runat="server" Text="Please Enter Email" Font-Bold="true"></asp:Label>
       
        <asp:TextBox id="txtEmail" runat="server" Width="250px"></asp:TextBox>
     <asp:Button runat="server" Text="Sent OTP" OnClick="btnSend_Click" Width="100px" BackColor="Yellow"></asp:Button>
   
</div>
            
    
     <div class="container">
         <div class="userInput">
          <h2>ENTER OTP</h2> <br />
             <asp:TextBox ID="txtotp" runat="server" Width="100px"></asp:TextBox><br/>
          <asp:Button runat="server" ID="btdown" Text="Verify" OnClick="btnVerify_Click" Width="100px" BackColor="Yellow"></asp:Button><br /><br />
              <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="submit_Click" Width="100px" BackColor="Yellow"></asp:Button>
    </div>
         
         </div>
         <br />  
    <asp:Label ID="Lbl1" runat="server" Font-Bold="true"></asp:Label>  
        </form>
      
</body>
</html>

