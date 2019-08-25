<?php
defined('BASEPATH') OR exit('No direct script access allowed');
?>
<aside class="left-sidebar" data-sidebarbg="skin5">
  <!-- Sidebar scroll-->
  <div class="scroll-sidebar">
    <!-- Sidebar navigation-->
    <nav class="sidebar-nav">
      <ul id="sidebarnav" class="p-t-30">
        <!-- Dashboard -->
        <li class="sidebar-item">
          <a class="sidebar-link waves-effect waves-dark sidebar-link" href="<?= base_url() . 'home/dashboard'; ?>" aria-expanded="false">
            <i class="mdi mdi-view-dashboard"></i>
            <span class="hide-menu">Dashboard</span>
          </a>
        </li>
        <!-- Organization -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-hospital-building"></i>
            <span class="hide-menu">Organization</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'organization/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Org. </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'organization/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Organization List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'organization/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'organization/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
        <!-- Course -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-library"></i>
            <span class="hide-menu">Course</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'course/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Course </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'course/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Course List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'course/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'course/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
        <!-- Batch -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-account-group"></i>
            <span class="hide-menu"> Batch</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'batch/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Batch. </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'batch/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Batch List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'batch/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'batch/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
        <!-- Trainer -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-teach"></i>
            <span class="hide-menu">Trainer</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'trainer/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Trainer </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'trainer/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Trainer List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'trainer/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'trainer/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
        <!-- Exam -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-pencil-plus"></i>
            <span class="hide-menu">Examination</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'exam/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Exam </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'exam/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Exam List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'exam/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'exam/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
        <!-- Question -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-file-question"></i>
            <span class="hide-menu">Questions</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'question/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Questions </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'question/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Question List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'question/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'question/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
        <!--Participant -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-account-tie"></i>
            <span class="hide-menu">Participant</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'participant/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Org. </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'participant/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Participant List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'participant/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'participant/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
        <!--Settings -->
        <li class="sidebar-item">
          <a class="sidebar-link has-arrow waves-effect waves-dark" href="javascript:void(0)" aria-expanded="false">
            <i class="mdi mdi-account-tie"></i>
            <span class="hide-menu"> Setting</span>
          </a>
          <ul aria-expanded="false" class="collapse  first-level">
            <li class="sidebar-item">
              <a href="<?= base_url() . 'setting/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Add New Org. </span>
              </a>
            </li>
            <li class="sidebar-item">
              <a href="<?= base_url() . 'setting/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> setting List </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'setting/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-checkbox-blank-circle"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li><li class="sidebar-item">
              <a href="<?= base_url() . 'setting/entry'; ?>" class="sidebar-link">
                <i class="mdi mdi-note-outline"></i>
                <span class="hide-menu"> Form Basic </span>
              </a>
            </li>
          </ul>
        </li>
      </ul>
    </nav>
    <!-- End Sidebar navigation -->
  </div>
  <!-- End Sidebar scroll-->
</aside>