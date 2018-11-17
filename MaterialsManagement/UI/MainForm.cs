﻿using MaterialsManagement.Model;
using MaterialsManagement.UI.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsManagement
{
    public partial class MainForm : Form
    {
        private EventHandler qkOnClickEvent;
        private EventHandler dvOnClickEvent;

        public MainForm()
        {
            InitializeComponent();
            InitHomeScreen();
        }

        private void InitHomeScreen()
        {
            //change text of main label
            mainLabel.Text = "Danh sách quân khu";
            ResetAddressBar(false, false);
            InitMainPanel(new QkUC(OnItemQk_Click));
        }

        private void InitQkScreen(Qk qk)
        {
            //change text of current qk
            btnQk.Text = qk.Name;
            //change text of main label
            mainLabel.Text = "Danh sách đơn vị trực thuộc " + qk.Name;
            //change event when click on qk button in address bar
            if (qkOnClickEvent != null)
            {
                //remove old event
                btnQk.Click -= qkOnClickEvent;
            }
            //init new event
            qkOnClickEvent = delegate (object sender, EventArgs e)
            {
                InitQkScreen(qk);
            };
            //add event
            btnQk.Click += qkOnClickEvent;
            //reset address bar
            ResetAddressBar(true, false);
            //init main panel
            InitMainPanel(new DvUC(qk, OnItemDv_Click));
        }

        private void InitMainPanel(Control control)
        {
            mainPanel.Controls.Clear();
            mainPanel.RowStyles.Clear();
            mainPanel.Controls.Add(control);
        }

        private void InitDvScreen(Dv dv)
        {
            btnDv.Text = dv.Name;
            //change text of main label
            mainLabel.Text = "Danh sách trang bị của đơn vị " + dv.Name;
            if (dvOnClickEvent != null)
            {
                btnDv.Click -= dvOnClickEvent;
            }
            dvOnClickEvent = delegate (object sender, EventArgs e)
            {
                InitDvScreen(dv);
            };
            btnDv.Click += dvOnClickEvent;
            ResetAddressBar(true, true);
            InitMainPanel(new MaterialUC(dv));
        }

        private void ResetAddressBar(bool InQk, bool InDv)
        {
            if (InQk)
            {
                icArrowQk.Visible = true;
                btnQk.Visible = true;
            }
            else
            {
                icArrowQk.Visible = false;
                btnQk.Visible = false;
            }
            if (InDv)
            {
                icArrowDv.Visible = true;
                btnDv.Visible = true;
            }
            else
            {
                icArrowDv.Visible = false;
                btnDv.Visible = false;
            }
        }

        private void OnItemQk_Click(Qk qk)
        {
            InitQkScreen(qk);
        }

        private void OnItemDv_Click(Dv dv)
        {
            InitDvScreen(dv);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            InitHomeScreen();
        }
    }
}
