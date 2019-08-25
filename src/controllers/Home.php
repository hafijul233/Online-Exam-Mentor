<?php

defined('BASEPATH') OR exit('No direct script access allowed');


class Home extends CI_Controller
{
    public function __construct()
    {
        parent::__construct();
    }

    public function index()
    {
        $this->load->view('welcome_message');
    }

    public function dashboard()
    {
        $data = array(
            'view_path' => 'home/dashboard'
        );
        $this->load->view('layout/base_layout', $data);
    }
}
