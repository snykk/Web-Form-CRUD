<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebForm.index" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <style>
        * {
            text-transform: capitalize;
        }
        .auto-style1 {
            height: 35px;
        }
    </style>
</head>
<body>
    <h1>sistem informasi</h1>
    <form id="form" runat="server">
        <table>
            <tr>
                <td class="auto-style1">
                    <h3>data mahasiswa</h3>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSelect" runat="server" Text="Select All Data" OnClick="btnSelect_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="selectAllData" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td colspan="2">
                    <h3>tambah dan ubah data</h3>
                    <br />
                </td>
            </tr>
            <tr>
                <td>id</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="intId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>firstname</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>lastname</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>username</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>gender</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="charGender" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>email</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>password</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnInsertion" runat="server" Text="Tambah" OnClick="btnInsertion_Click" Width="109px" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Ubah" OnClick="btnUpdate_Click" Width="109px" />
                    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td colspan="3">
                    <h3>hapus data</h3>
                </td>
            </tr>
            <tr>
                <td>mahasiswa ID</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnDelete" runat="server" Text="Hapus" OnClick="btnDelete_Click" />
                    <asp:Label ID="lblmessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </form>

</body>
</html>
