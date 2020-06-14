<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="Prueba.Log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>

    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <div class="d-flex flex-column justify-content-between bg-dark" style="height:100vh">    
        <header></header>
        <main>
            <div class="container">
                <div class="row">
                    <div class="col-12 col-sm-10 col-lg-6 mx-auto">
                        <div class="card">
                            <h2 class="card-header display-5 text-center">Login</h2>
                            <div class="card-body">
                                <form id="form1" runat="server" >                       
                                        
                                        <div class="form-group">
                                            <h6 class="text-center"><asp:Label ID="lbl_contador" runat="server" Text="" ForeColor="Red" ></asp:Label></h6>

                                        </div>
                                        <div class="form-group">
                                            <label for="txt_name">Nombre</label>
                                            <asp:TextBox ID="txt_name" runat="server" class="form-control bg-white shadow-sm is-invalid"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label for="txt_pass">Contrasena</label>
                                            <asp:TextBox ID="txt_pass" type="password" runat="server" class="form-control bg-white shadow-sm is-invalid"></asp:TextBox>                    
                                        </div>
                                         <div class="form-group">
                                            <asp:Button ID="Ingreso" runat="server" Text="Ingresar" OnClick="Ingreso_Click" class="btn btn-success btn-lg btn-block"/>                                       
                                        </div>                        
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
        <footer></footer>
    </div>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
