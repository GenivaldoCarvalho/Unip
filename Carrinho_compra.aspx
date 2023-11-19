
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Carrinho de compra</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            
            <h1>Selecione o Cliente</h1>
                    
            <br />
            <asp:TextBox ID="TextBox_Cliente" runat="server"></asp:TextBox>
            <asp:Button ID="Button_cliente" runat="server" Text="Buscar ID" />

            <h1>Selecione o Produto</h1>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Buscar Produto" />


            <h1>Selecione o Produto</h1>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Enviar Carrinho" />




        </div>
    </form>
</body>
</html>
