<?php

defined('BASEPATH') OR exit('No direct script access allowed');


class Course extends CI_Controller
{

    public function __construct()
    {
        parent::__construct();
    }

    public function index()
    {
        $this->load->view('welcome_message');
    }

    public function entry()
    {
        $this->load->view('layout/base_layout');
    }
}
