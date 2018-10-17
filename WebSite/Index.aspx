<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style7 {
        width: 345px;
    }
        .auto-style12 {
            width: 219px;
            height: 43px;
        }
        .auto-style14 {
            width: 219px;
            height: 21px;
        }
        .auto-style15 {
            width: 100%;
        }
        .auto-style16 {
            width: 219px;
            height: 60px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4><asp:Label ID="lblNombreUsuario" runat="server" Text=""></asp:Label></h4>
    <br />
    <br />
    <br />
    <br />
    <asp:Panel ID="pnlIngresar" runat="server" Width="777px" BackColor="White">
        <table class="auto-style15">
            <tr>
                <td class="auto-style16">
                    ID de la cuenta<br /> <asp:TextBox ID="txtNombreUsuario" runat="server" Width="210px"></asp:TextBox>
                    <br />
                    <br />
                    Contraseña<br />
                    <asp:TextBox ID="txtClave" runat="server" Width="210px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:Image ID="Image1" runat="server" Height="157px" ImageUrl="~/bookDigital.png" Width="180px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <br />
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                    &nbsp;<asp:Button ID="btnCerrarSesion" runat="server" OnClick="btnCerrarSesion_Click" Text="Cerrar Sesion" />
                    &nbsp;<asp:Button ID="btnRegistrar" runat="server" Text="Registrarse" OnClick="btnRegistrar_Click" />
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
            </tr>
        </table>
    </asp:Panel>

</asp:Content>

