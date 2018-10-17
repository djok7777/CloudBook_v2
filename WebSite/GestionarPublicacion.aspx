<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestionarPublicacion.aspx.cs" Inherits="GestionarPublicacion" %>

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
        .auto-style12 {
            width: 219px;
            height: 26px;
        }
        .auto-style13 {
            height: 26px;
            width: 256px;
        }
        .auto-style14 {
            height: 26px;
            width: 220px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlSubirLibro" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <h3>GESTIÓN DE PUBLICACIONES</h3>
        </asp:Panel>
        <br />
        <asp:Panel ID="pnlDatosLibro" runat="server">
            <table style="width: 100%;">
            <tr>
                <td>Archivo pdf</td>
                <td class="auto-style7">
                    <asp:FileUpload ID="archivoSubido" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="archivoSubido" ErrorMessage="RequiredFieldValidator">(*) Campo obligatorio</asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Solo pdf permitido" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.pdf)$" ControlToValidate="archivoSubido"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Titulo</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitulo" ErrorMessage="RequiredFieldValidator">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Autor</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAutor" ErrorMessage="RequiredFieldValidator">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Cantidad de paginas</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtCantPaginas" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCantPaginas" ErrorMessage="RequiredFieldValidator">(*) Campo obligatorio</asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="valPaginas" runat="server" ControlToValidate="txtCantPaginas" ErrorMessage="RangeValidator" MaximumValue="10000" MinimumValue="1" Type="Integer">Min:1 Max:10000 paginas</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Categoria</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="128px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlCategoria" ErrorMessage="RequiredFieldValidator" InitialValue="Seleccionar">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contenido</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="ddlContenido" runat="server" Width="128px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlContenido" ErrorMessage="RequiredFieldValidator" InitialValue="Seleccionar">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">Estado</td>
                <td class="auto-style14">
                    <asp:DropDownList ID="ddlEstado" runat="server" Height="16px" Width="128px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlEstado" ErrorMessage="RequiredFieldValidator" InitialValue="Seleccionar">(*) Campo obligatorio</asp:RequiredFieldValidator>
                </td>
            </tr>
                <tr>
                    <td class="auto-style13">Descripcion (opcional)</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Height="80px" Width="250px" style="resize:none"></asp:TextBox>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Imagen de portada (opcional)</td>
                    <td class="auto-style8">
                        <asp:FileUpload ID="archivoPortada" runat="server" />
                    </td>
                    <td class="auto-style1">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="archivoPortada" ErrorMessage="Debe ser formato jpg" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.jpg)$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
        </table>
        </asp:Panel>

        <asp:Panel ID="pnlModificarEliminar" runat="server">
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Button ID="btnSubir" runat="server" OnClick="btnSubir_Click" Text="Subir" />
                        <br />
                        <h4>
                            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
                        </h4>
                        <br />
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" Visible="False" />
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Visible="False" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>

        <br />
        <h4>MIS PUBLICACIONES</h4>

        <asp:GridView ID="gdvMisPublicaciones" runat="server" Style="font-family:Arial" AutoGenerateSelectButton="True" AutoGenerateColumns="False" OnSelectedIndexChanged="gdvMisPublicaciones_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField ControlStyle-Height="100px" ControlStyle-Width="80px" HeaderText="Portada">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Portada") %>' />
                    </ItemTemplate>
                    <ControlStyle Height="100px" Width="80px" />
                </asp:TemplateField>
                <asp:BoundField DataField="Id_libro" HeaderText="ID" />
                <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                <asp:BoundField DataField="Autor" HeaderText="Autor" />
                <asp:BoundField DataField="Anno_publicacion" HeaderText="Fecha" />
                <asp:BoundField DataField="Cantidad_Votos" HeaderText="Votos" />
                <asp:BoundField DataField="Tipo_Periodicidad" HeaderText="Periodicidad" />
                <asp:BoundField DataField="Contenido" HeaderText="Tipo de contenido" />
                <asp:BoundField DataField="Cantidad_paginas" HeaderText="Paginas" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

    </asp:Panel>
</asp:Content>
