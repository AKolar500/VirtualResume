<%@ Page Language="VB" AutoEventWireup="false" CodeFile="prjStadiumSeating2.aspx.vb" Inherits="prjStadiumSeating2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="2">
                    Tickets Sold</td>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    Revenue Generator</td>
            </tr>
            <tr>
                <td colspan="5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    Enter the number of tickets sold for each class of seats.</td>
                <td>
                    &nbsp;</td>
                <td>
                    Class A:</td>
                <td>
                    <asp:Label ID="lblClassA" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        Width="50%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td width="10%">
                    Class A:</td>
                <td width="20%">
                    <asp:TextBox ID="txtClassA" runat="server"></asp:TextBox>
                </td>
                <td width="20%">
                    &nbsp;</td>
                <td width="10%">
                    Class B:</td>
                <td width="20%">
                    <asp:Label ID="lblClassB" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        Width="50%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Class B:</td>
                <td>
                    <asp:TextBox ID="txtClassB" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Class C:</td>
                <td>
                    <asp:Label ID="lblClassC" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        Width="50%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Class C:</td>
                <td>
                    <asp:TextBox ID="txtClassC" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Total Revenue:</td>
                <td>
                    <asp:Label ID="lblTotal" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        Width="50%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate Revenue" />
                </td>
                <td>
                    <asp:Button ID="btnClear" runat="server" Text="Clear Fields" />
                </td>
                <td>
                    <asp:Button ID="btnExit" runat="server" Text="Exit" Width="130px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Errors (If Any):</td>
                <td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
