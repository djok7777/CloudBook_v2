<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Catalogo.aspx.cs" Inherits="Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style7 {
            width: 774px;
        }
        .auto-style15 {
            width: 150px;
        }
        .auto-style16 {
            width: 160px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlCatalogo" runat="server" BorderStyle="Outset">
        <table style="width:100%;">
            <tr>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style16">
                    <h4>
                        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
                        &nbsp;<asp:LinkButton ID="lbRegistro" runat="server" PostBackUrl="~/RegistroUsuario.aspx">Registrarse</asp:LinkButton>
                    </h4>
                    <h4>Oficiales</h4>
                    <asp:GridView ID="gdvLibrosComerciales" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gdvLibrosComerciales_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField ControlStyle-Height="100" ControlStyle-Width="80px" HeaderText="Imagen">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Portada") %>' />
                                </ItemTemplate>
                                <ControlStyle Height="110px" Width="100px" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="Id_Libro" HeaderText="ID" />
                            <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                            <asp:BoundField DataField="Autor" HeaderText="Autor" />
                            <asp:BoundField DataField="Cantidad_paginas" HeaderText="Paginas" />
                            <asp:BoundField DataField="Audio" HeaderText="Audio" />
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
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style16">
                    <hr/>
                    <h4>Publicados por la comunidad</h4>
                    <asp:GridView ID="gdvLibrosPublicados" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gdvLibrosPublicados_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField ControlStyle-Height="100" ControlStyle-Width="80px" HeaderText="Imagen">
                                <ItemTemplate>
                                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# Bind("Portada") %>' />
                                </ItemTemplate>
                                <ControlStyle Height="110px" Width="100px" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="Id_Libro" HeaderText="ID" />
                            <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                            <asp:BoundField DataField="Autor" HeaderText="Autor" />
                            <asp:BoundField DataField="Cantidad_Paginas" HeaderText="Paginas" />
                            <asp:BoundField DataField="Tipo_Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Tipo_Periodicidad" HeaderText="Periodicidad" />
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
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>

        <br/>
    </asp:Panel>
</asp:Content>

