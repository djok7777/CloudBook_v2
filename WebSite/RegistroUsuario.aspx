<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistroUsuario.aspx.cs" Inherits="RegistroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style12 {
            width: 255px;
        }
        .auto-style13 {
            height: 26px;
            width: 255px;
        }
        .auto-style16 {
            height: 26px;
            width: 404px;
        }
        .auto-style17 {
            width: 404px;
        }
        .auto-style21 {
            width: 419px;
        }
        .auto-style22 {
            width: 290px;
        }
        .auto-style23 {
            width: 255px;
        }
        .auto-style24 {
            width: 227px;
        }
        .auto-style25 {
            width: 285px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlRegistroUsuario" runat="server">
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style24"><h3>Registro de nueva cuenta</h3> </td>
                <td class="auto-style21">&nbsp;</td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="88px" ImageUrl="~/Registrarse.png" Width="116px" />
                </td>
            </tr>
        </table>
        &nbsp;<hr/>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style23">Nombre de usuario</td>
                <td>
                    <asp:TextBox ID="txtNombreUsuario" runat="server" MaxLength="30"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombreUsuario">(*) Obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">Correo electrónico</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCorreo" ErrorMessage="RequiredFieldValidator">(*) Obligatorio</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="valREVCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="No contiene formato de correo" ValidationExpression="[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Contraseña</td>
                <td>
                    <asp:TextBox ID="txtClave" runat="server" MaxLength="21" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtClave" ErrorMessage="RequiredFieldValidator">(*) Obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Reingrese contraseña</td>
                <td>
                    <asp:TextBox ID="txtClave2" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtClave2" ErrorMessage="RequiredFieldValidator">(*) Obligatorio</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="valClave2" runat="server" ControlToCompare="txtClave" ControlToValidate="txtClave2" ErrorMessage="No son identicas">Las contraseñas deben ser identicas</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
        </table>
        
        <hr>
        &nbsp;<i>Datos opcionales</i><table style="width:100%;">
            <tr>
                <td class="auto-style25">Nombres</td>
                <td>
                    <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">Apellido Paterno</td>
                <td>
                    <asp:TextBox ID="txtPaterno" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">Apellido Materno</td>
                <td>
                    <asp:TextBox ID="txtMaterno" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </asp:Panel>

</asp:Content>
