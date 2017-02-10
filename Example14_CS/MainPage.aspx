<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Example14_CS.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CCIS 2645 Example 14 - CS</title>
    <meta name="author" content="CCIS2645 Class" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Main Page</h1>

        <span style="z-index: 1; left: 50px; top: 200px; position: absolute">Field 1:</span>
        <asp:TextBox ID="txtFirstField" runat="server" TabIndex="1"
            style="z-index: 1; left: 150px; top: 200px; position: absolute" />
        <span style="z-index: 1; left: 50px; top: 250px; position: absolute">Field 2:</span>
        <asp:TextBox ID="txtSecondField" runat="server" TabIndex="2"
            style="z-index: 1; left: 150px; top: 250px; position: absolute" />
        <asp:Button ID="btnSubmit" runat="server" TabIndex="3" Text="Submit"
            style="z-index: 1; left: 200px; top: 300px; position: absolute" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Bold="true" Text="(error)" 
            style="z-index: 1; left: 25px; top: 500px; position: absolute" />
    </div>
    </form>
</body>
</html>
