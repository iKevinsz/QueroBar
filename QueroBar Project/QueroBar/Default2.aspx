<%@ Page Title="QueroBar" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <!-- mudar o ID -->

    <div class="content-wrapper px-5 py-2">
        <div class="content-header">
            <div class="container-fluid">
                <div class="card-body">
                    <center>
                        <h1>Cadastrar aluno</h1>
                    </center>
                    <br />
                    <asp:Table runat="server" style="width:60%; margin:0 auto;">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" CssClass="input-group mb-3">
                                <asp:TextBox CssClass="form-control" placeholder="Nome" ID="txtNome" runat="server" TextMode="SingleLine"/> 
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" CssClass="input-group mb-3">
                                <asp:TextBox CssClass="form-control" placeholder="Data de Nascimento" ID="txtNascimento" runat="server" TextMode="Date" />
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" CssClass="input-group mb-3">
                                <asp:TextBox CssClass="form-control" placeholder="RA" ID="txtRA" runat="server" TextMode="Number" />
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" CssClass="input-group mb-3">
                                <asp:TextBox CssClass="form-control" placeholder="Data do Vestibular" ID="txtDataVest" runat="server" TextMode="Date" />
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" Cssclass="input-group mb-3">
                                <asp:TextBox CssClass="form-control" placeholder="Email" ID="txtEmail" runat="server" TextMode="Email" />
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" CssClass="input-group mb-3">
                                <asp:TextBox CssClass="form-control" placeholder="Senha" ID="txtSenha" runat="server" TextMode="Password" />
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" ColumnSpan="2">
                                <asp:Button runat="server" Text="Cadastrar" type="submit" class="btn btn-warning" OnClick="btnCadastrar_Click" />
                            </asp:TableCell>
                        </asp:TableRow>

                    </asp:Table>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
