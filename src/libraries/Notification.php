<?php

defined('BASEPATH') OR exit('No direct script access allowed');


class Notification
{
    public function __construct()
    {
        parent::__construct();
    }

    public function index()
    {
        $this->load->view('welcome_message');
    }
}
