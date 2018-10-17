<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ModificarPublicacion.aspx.cs" Inherits="ModificarPublicacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style7 {
        width: 255px;
    }
    .auto-style8 {
        height: 26px;
        width: 255px;
    }
        .auto-style11 {
            height: 26px;
        }
        .auto-style13 {
            height: 26px;
            width: 256px;
        }
        .auto-style23 {
            height: 26px;
            width: 260px;
        }
        .auto-style24 {
            width: 260px;
        }
        .auto-style25 {
            width: 280px;
        }
        .auto-style26 {
            height: 26px;
            width: 280px;
        }
        .auto-style27 {
            width: 260px;
            height: 38px;
        }
        .auto-style28 {
            width: 280px;
            height: 38px;
        }
        .auto-style29 {
            height: 38px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlSubirLibro" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <h3>MODIFICANDO SU PUBLICACION</h3>
        </asp:Panel>
        <br />
        <asp:Panel ID="pnlDatosLibro" runat="server">
            <table style="width: 100%;">
            <tr>
                <td class="auto-style27">Nueva versión en pdf</td>
                <td class="auto-style28">
                    <asp:FileUpload ID="archivoPDF" runat="server" />
                    <br />
                    
                </td>
                <td class="auto-style29">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="archivoPDF" ErrorMessage="Solo pdf permitido" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.pdf)$"></asp:RegularExpressionValidator>
                    <br />
                    Deje en blanco si no sube pdf nuevo</td>
            </tr>
            <tr>
                <td class="auto-style24">Autor</td>
                <td class="auto-style25">
                    <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAutor" ErrorMessage="RequiredFieldValidator">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Cantidad de paginas</td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtCantPaginas" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCantPaginas" ErrorMessage="RequiredFieldValidator">(*) Campo obligatorio</asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="valPaginas" runat="server" ControlToValidate="txtCantPaginas" ErrorMessage="RangeValidator" MaximumValue="10000" MinimumValue="1" Type="Integer">Min:1 Max:10000 paginas</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Categoria</td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="128px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlCategoria" ErrorMessage="RequiredFieldValidator" InitialValue="Seleccionar">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Contenido</td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddlContenido" runat="server" Width="128px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlContenido" ErrorMessage="RequiredFieldValidator" InitialValue="Seleccionar">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Estado</td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddlEstado" runat="server" Height="16px" Width="128px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlEstado" ErrorMessage="RequiredFieldValidator" InitialValue="Seleccionar">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
                <tr>
                    <td class="auto-style23">Descripción</td>
                    <td class="auto-style26">
                        <asp:TextBox ID="txtDescripcion" runat="server" Height="80px" style="resize:none" TextMode="MultiLine" Width="250px"></asp:TextBox>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">Imagen de portada</td>
                    <td class="auto-style26">
                        <asp:FileUpload ID="archivoPortada" runat="server" />
                    </td>
                    <td class="auto-style1">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="archivoPortada" ErrorMessage="Debe ser formato jpg" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.jpg)$"></asp:RegularExpressionValidator>
                        <br />
                        Deje en blanco si no actualiza imagen</td>
                </tr>
        </table>
        </asp:Panel>

        <asp:Panel ID="pnlModificarEliminar" runat="server">
            <table style="width:100%;">
                <tr>
                    <td>
                        <br />
                        <h4>
                            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
                        </h4>
                        <br />
                        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
