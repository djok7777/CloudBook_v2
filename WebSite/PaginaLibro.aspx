<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PaginaLibro.aspx.cs" Inherits="PaginaLibro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style14 {
            width: 200px;
        }
        .auto-style15 {
            width: 400px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlLibro" runat="server">
        <br/>
        <h4>
            <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
        </h4>
        <br/>
        <table style="width:100%;">
            <tr>
                <td class="auto-style14">
                    <asp:Image ID="imgPortada" runat="server" Height="200px" Width="140px" />
                </td>
                <td class="auto-style15">
                    <h4>Descripcion:</h4>
                    <p>
                        <asp:Label ID="lblDescripcion" runat="server" Text=""></asp:Label>
                    </p>
                </td>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>Año publicacion</td>
                            <td>
                                <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>Categoria</td>
                            <td>
                                <asp:Label ID="lblCategoria" runat="server" Text=""></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>Paginas</td>
                            <td>
                                <asp:Label ID="lblPaginas" runat="server" Text=""></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="lblAutor" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/Warp_Star.png" Width="28px" />
                    &nbsp;&nbsp; <asp:Label ID="lblVotos" runat="server"></asp:Label>
                    <br />
                </td>
                <td class="auto-style15">
                    <asp:Button ID="btnLeerPDF" runat="server" Text="Leer libro" OnClick="btnLeerPDF_Click" />
                </td>
                <td>&nbsp;
                    <audio id="audio_player" runat="server" controls="" controlslist="nodownload">
                    </audio>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

