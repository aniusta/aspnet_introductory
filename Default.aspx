<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>mcl</title>
    <style>
        h1 {
            text-align: center;
        }
        fieldset{
            display: flex;
            justify-content: center;
            border: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculator</h1>
        </div>
        <p>
                <asp:Label ID="Label1" runat="server" Text="First Number">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:Label>
                </p>
        <p>
                <asp:Label ID="Label2" runat="server" Text="Second Number">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:Label>
                </p>
        <p>
                <asp:Label ID="Label3" runat="server" Text="Second Number">
                    <asp:TextBox ID="TextBox3" runat="server" disabled></asp:TextBox></asp:Label>
                </p>
        <p>
                <asp:Button runat="server" id="btnAdd" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button runat="server" id="btnSubtract" Text="Subtract" OnClick="btnSubtract_Click" />
            <asp:Button runat="server" id="btnDivide" Text="Divide" OnClick="btnDivide_Click" />
            <asp:Button runat="server" id="btnMultiply" Text="Multiply" OnClick="btnMultiply_Click" />
            </p>
    </form>
</body>
</html>
