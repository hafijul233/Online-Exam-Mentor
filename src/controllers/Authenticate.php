<?php

defined('BASEPATH') OR exit('No direct script access allowed');


class Authenticate extends CI_Controller
{

    public function __construct()
    {
        parent::__construct();

        $this->load->helper('form');
        $this->load->library('form_validation');

    }

    public function index()
    {
        $this->login();
    }

    //Login Page View
    public function login()
    {
        //if(isset($_POST)) redirect(base_url().'home/dashboard');
        $this->load->view('authenticate/login');
    }

    //Login Process
    protected function login_process($username = NULL,$email = NULL, $password) {

    }

    //Register Page View
    public function register()
    {
        $this->load->view('authenticate/register');
    }

    //Login Process
    protected function register_process($user_info = array()) {

    }

    //Account Activation Page View
    public function activation()
    {
        $this->load->view('authenticate/activation');
    }

    //Password Recovery Page View
    public function recovery()
    {
        $this->load->view('authenticate/recovery');
    }

    //System Logout View / process
    public function logout()
    {
        $this->session->sess_destroy();
        redirect(base_url().'authenticate/login');
    }
}