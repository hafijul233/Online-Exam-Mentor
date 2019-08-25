<?php
defined('BASEPATH') OR exit('No direct script access allowed');
?>
<!DOCTYPE html>
<html dir="ltr">
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <meta name="description" content="">
  <meta name="author" content="">
  <!-- Favicon icon -->
  <link rel="icon" type="image/png" sizes="16x16" href="<?= base_url(); ?>resources/images/favicon.png">
  <title>Login - <?= APP_NAME; ?></title>
  <!-- BootStrap & Custom CSS -->
  <link rel="stylesheet" type="text/css" href="<?= base_url(); ?>resources/css/style.min.css">
  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
  <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>

<body style="overflow: hidden;">
<div class="main-wrapper">
  <!-- Preloader -->
  <div class="preloader">
    <div class="lds-ripple">
      <div class="lds-pos"></div>
      <div class="lds-pos"></div>
    </div>
  </div>
  <!-- Login box.scss -->
  <div class="auth-wrapper d-flex no-block justify-content-center align-items-center bg-dark">
    <div class="auth-box bg-dark border-top border-secondary">
      <div id="loginform">
        <div class="text-center p-t-20 p-b-20">
          <span class="db"><img src="<?= base_url(); ?>resources/images/logo.png" alt="logo"/></span>
        </div>
        <!-- Login Form -->
        <form class="form-horizontal m-t-20" id="loginform" action="<?= base_url(); ?>authenticate/login"
              method="post" accept-charset="utf8">
          <div class="row p-b-30">
            <div class="col-12">
              <div class="input-group mb-3">
                <div class="input-group-prepend">
                  <span class="input-group-text bg-success text-white" id="basic-addon1"><i class="ti-user"></i></span>
                </div>
                <input type="text" class="form-control form-control-lg" placeholder="Username or Email address"
                       aria-label="Username or Email"
                       aria-describedby="basic-addon1" name="username_email" tabindex="1" required autofocus>
                <span class="text-danger"><?= form_error('username_email'); ?></span>
              </div>
              <div class="input-group mb-3">
                <div class="input-group-prepend">
                  <span class="input-group-text bg-warning text-white" id="basic-addon2"><i
                      class="ti-pencil"></i></span>
                </div>
                <input type="password" class="form-control form-control-lg" placeholder="Password" aria-label="Password"
                       aria-describedby="basic-addon1" name="password" tabindex="2" required autofocus>
                <span class="text-danger"><?= form_error('password'); ?></span>
              </div>
            </div>
          </div>
          <div class="row border-top border-secondary">
            <div class="col-12">
              <div class="form-group">
                <div class="p-t-20">
                  <button class="btn btn-info" id="to-recover" type="button"><i class="fa fa-lock m-r-5"></i> Lost
                    password?
                  </button>
                  <button class="btn btn-success float-right" type="submit">Login</button>
                </div>
              </div>
            </div>
            <div class="col-12 text-center mt-3">
              <a href="<?= base_url(); ?>authenticate/register"><span class="text-decoration-none text-white">Register new Account ?</span></a>
            </div>
          </div>
        </form>
      </div>
      <div id="recoverform">
        <div class="text-center p-t-20 p-b-20">
          <span class="db"><img src="<?= base_url(); ?>resources/images/logo.png" alt="logo"/></span>
        </div>
        <div class="text-center">
          <span class="text-white">Enter your e-mail address below and we will send you instructions how to recover a password.</span>
        </div>
        <div class="row m-t-20">
          <!-- Form -->
          <form class="col-12" action="<?= base_url(); ?>authenticate/recovery" accept-charset="utf-8">
            <!-- email -->
            <div class="input-group mb-3">
              <div class="input-group-prepend">
                <span class="input-group-text bg-danger text-white" id="basic-addon1"><i class="ti-email"></i></span>
              </div>
              <input type="email" class="form-control form-control-lg" placeholder="Email Address"
                     aria-label="Email Address"
                     aria-describedby="basic-addon1" name="email" tabindex="3" required autofocus>

              <span class="text-danger"><?= form_error('email'); ?></span>
            </div>
            <!-- pwd -->
            <div class="row m-t-20 p-t-20 border-top border-secondary">
              <div class="col-12">
                <a class="btn btn-success" href="#" id="to-login">Back To Login</a>
                <button class="btn btn-info float-right" type="submit" name="action">Recover</button>
              </div>
              <div class="col-12 text-center mt-3">
                <a href="<?= base_url(); ?>authenticate/register"><span class="text-decoration-none text-white">Register new Account ?</span></a>
              </div>
            </div>
          </form>
        </div>
      </div>
    </div>
  </div>
</div>
<!-- All Required js -->
<script src="<?= base_url(); ?>plugins/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap tether Core JavaScript -->
<script src="<?= base_url(); ?>plugins/popper.js/dist/umd/popper.min.js"></script>
<script src="<?= base_url(); ?>plugins/bootstrap/dist/js/bootstrap.min.js"></script>
<script src="<?= base_url(); ?>resources/js/app.js"></script>
<!-- This page js -->
<script src="<?= base_url(); ?>resources/js/pages/login.js"></script>
</body>
</html>