<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contactos.aspx.cs" Inherits="Contactos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <!--scripts lado del cliente-->
    <script>
    function validaLargoMultiLinea(oSrc, args){
       args.IsValid = (args.Value.length >= 10 && args.Value.length <= 140);
    }
    </script>

    <style type="text/css">
        .auto-style11 {
            width: 476px;
        }
        .auto-style12 {
        width: 40px;
    }
        .auto-style13 {
            width: 325px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style11">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style13">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style13">Contacte al staff de CloudBook</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style13">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style11">
                <table style="width:100%;">
                    <tr>
                        <td>Email:</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCorreo" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCorreo" ErrorMessage="(*) Campo obligatorio"></asp:RequiredFieldValidator>
                            <br />
                    <asp:RegularExpressionValidator ID="valREVCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="No contiene formato de correo" ValidationExpression="[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:TextBox ID="txtEscribanos" runat="server" Height="80px" MaxLength="140" TextMode="MultiLine" Width="400px" style="resize:none"></asp:TextBox>
                <br />
                <h6>Máx. 140, Mín. 10 caracteres</h6></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEscribanos" ErrorMessage="(*) Campo obligatorio"></asp:RequiredFieldValidator>
                <br />
    <asp:CustomValidator id="customValEscribanos" runat="server"
      ControlToValidate = "txtEscribanos"
      ErrorMessage = "Máx. 140, Mín. 10 carácteres"
   ClientValidationFunction="validaLargoMultiLinea" ></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style11">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                <br />
                <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </asp:Content>

