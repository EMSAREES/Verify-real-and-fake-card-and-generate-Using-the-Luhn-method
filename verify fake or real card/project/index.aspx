<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="verify_fake_or_real_card.project.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Verify card</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
</head>
<body>
    <header class="header p-1 bg-dark">
        <div class="container">
            <h1 class="text-center fw-bold display-1 text-white">VERIFY</h1>
        </div>        
    </header>

    <form id="form1" runat="server" class="d-flex flex-column justify-content-center align-items-center full-height">
        <div class="w-50 p-3 mt-5 mb-5 d-flex justify-content-center gap-3">   
            <asp:TextBox class="form-control" ID="Tex_Number" runat="server" placeholder="Number" maxlength="16"></asp:TextBox>

            <!--<input onclick="But_Acept_Click" id="But_Acept" type="button" value="Acept"/>-->
            <asp:Button ID="But_Acept" class="btn btn-success" runat="server" Text="Acept" OnClick="But_Acept_Click1" />

            <asp:Button ID="But_Generate" class="btn btn-primary" runat="server" Text="generate " OnClick="But_Generate_Click" />
        </div>

        <div class="mt-5 text-center">
                                                            <!--CssClass="d-none"-->
            <asp:Label ID="Verify" runat="server" Text="Label" class="display-1"></asp:Label>
        </div>

    </form>
        
</body>
</html>
