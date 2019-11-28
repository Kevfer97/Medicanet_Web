<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfLogin.aspx.cs" Inherits="wfLogin" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>MedicaNet | Login</title>
    <link rel="icon" type="image/png" href="assets/dist/img/icon.png" />

  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href="assets/bower_components/bootstrap/dist/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="assets/bower_components/font-awesome/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="assets/bower_components/Ionicons/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="assets/dist/css/AdminLTE.min.css">
  <!-- iCheck -->
  <link rel="stylesheet" href="assets/plugins/iCheck/square/blue.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition login-page">
    <form id="form1" runat="server">
    <div>
    <div class="login-box">
  <div class="login-logo">
    <a href="#">Medica<b>Net</b></a>
  </div>
  <!-- /.login-logo -->
  <div class="login-box-body">
    <p class="login-box-msg">Inicia sesión para comenzar
        <br />
          <asp:label runat="server" id="lblPantalla"></asp:label>

    </p>

      <div class="form-group has-feedback">
          <asp:textbox class="form-control"   runat="server" ID="txtEmail"></asp:textbox>
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div>
      <div class="form-group has-feedback">
          <asp:textbox class="form-control"  runat="server" ID="txtPassword"></asp:textbox>

        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
      </div>
      <div class="row">
        <div class="col-xs-8">
          <div class="checkbox icheck">
            <label>
              <input type="checkbox">Recordar contraseña
            </label>

          </div>
        </div>
        <!-- /.col -->
        <div class="col-xs-4">
            <asp:Button runat="server" ID="btnIngresar" class="btn btn-primary btn-block btn-flat" Text="Login" OnClick="btnIngresar_Click" />
        </div>
        <!-- /.col -->
      </div>
    <!-- /.social-auth-links -->


  </div>
  <!-- /.login-box-body -->
</div>
<!-- /.login-box -->

    </div>
    </form>
    <!-- jQuery 3 -->
<script src="assets/bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="assets/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- iCheck -->
<script src="assets/plugins/iCheck/icheck.min.js"></script>
<script>
  $(function () {
    $('input').iCheck({
      checkboxClass: 'icheckbox_square-blue',
      radioClass: 'iradio_square-blue',
      increaseArea: '20%' /* optional */
    });
  });
</script>
</body>
</html>
