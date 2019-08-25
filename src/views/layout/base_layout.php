<?php
defined('BASEPATH') OR exit('No direct script access allowed');
?>
<!DOCTYPE html>
<html dir="ltr" lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Favicon icon -->
    <link rel="icon" type="image/png" sizes="16x16" href="<?= base_url(); ?>resources/images/favicon.png">
    <title><?= ucwords($this->uri->segment(2)) . ' - ' . APP_NAME; ?></title>
    <!-- Chart CSS -->
    <link href="<?= base_url(); ?>plugins/flot/css/float-chart.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="<?= base_url(); ?>resources/css/style.min.css" rel="stylesheet">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
<!-- Preloader -->
<div class="preloader">
    <div class="lds-ripple">
        <div class="lds-pos"></div>
        <div class="lds-pos"></div>
    </div>
</div>
<!-- Main wrapper -->
<div id="main-wrapper">
    <!-- Topbar header -->
    <?php
    $this->load->view('layout/header');
    ?>
    <!-- Sidebar -->
    <?php
    $this->load->view('layout/sidebar');
    ?>
    <!-- Page wrapper  -->
    <div class="page-wrapper">
        <!-- Bread crumb and right sidebar toggle -->
        <div class="page-breadcrumb">
            <div class="row">
                <div class="col-12 d-flex no-block align-items-center">
                    <h4 class="page-title"><?= strtoupper($this->uri->segment(2)); ?></h4>
                    <div class="ml-auto text-right">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item"><a href="<?= base_url().$this->uri->segment(1); ?>"><?= ucwords($this->uri->segment(1)); ?></a></li>
                                <li class="breadcrumb-item active" aria-current="page"><?= ucwords($this->uri->segment(2)); ?></li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <!-- Container fluid  -->
        <?php
        $this->load->view(isset($view_path) ? $view_path : 'errors/blank');
        ?>
        <!-- footer -->
        <?php
        $this->load->view('layout/footer');
        ?>
        <!-- End footer -->
    </div>
    <!-- End Page wrapper  -->
</div>
<!-- End Wrapper -->
<!-- All Jquery -->
<script src="<?= base_url(); ?>plugins/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap tether Core JavaScript -->
<script src="<?= base_url(); ?>plugins/popper.js/dist/umd/popper.min.js"></script>
<script src="<?= base_url(); ?>plugins/bootstrap/dist/js/bootstrap.min.js"></script>
<script src="<?= base_url(); ?>plugins/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js"></script>
<script src="<?= base_url(); ?>plugins/sparkline/sparkline.js"></script>
<!--Wave Effects -->
<script src="<?= base_url(); ?>resources/js/waves.js"></script>
<!--Menu sidebar -->
<script src="<?= base_url(); ?>resources/js/sidebarmenu.js"></script>
<!--Custom JavaScript -->
<script src="<?= base_url(); ?>resources/js/custom.min.js"></script>
<!--This page JavaScript -->
<script src="<?= base_url(); ?>resources/js/pages/dashboards/dashboard1.js"></script>
<!-- Charts js Files -->
<script src="<?= base_url(); ?>plugins/flot/excanvas.js"></script>
<script src="<?= base_url(); ?>plugins/flot/jquery.flot.js"></script>
<script src="<?= base_url(); ?>plugins/flot/jquery.flot.pie.js"></script>
<script src="<?= base_url(); ?>plugins/flot/jquery.flot.time.js"></script>
<script src="<?= base_url(); ?>plugins/flot/jquery.flot.stack.js"></script>
<script src="<?= base_url(); ?>plugins/flot/jquery.flot.crosshair.js"></script>
<script src="<?= base_url(); ?>plugins/flot.tooltip/js/jquery.flot.tooltip.min.js"></script>
<script src="<?= base_url(); ?>resources/js/pages/chart/chart-page-init.js"></script>
</body>
</html>