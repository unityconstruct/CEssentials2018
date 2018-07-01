<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceAggregator.aspx.cs" Inherits="ProtoClient.WebServiceAggregator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Temperature:
                <asp:TextBox ID="txtTemperatureInput" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Convert" />
            </p>
            <p>
                Result: <asp:Label ID="lblResult" runat="server" Text="0.00"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
