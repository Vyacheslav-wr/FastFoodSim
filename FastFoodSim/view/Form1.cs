using FastFoodSim.controller;
using FastFoodSim.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace FastFoodSim
{
    public partial class Form1 : Form
    {
        private delegate void DeleteCallDelegate();
        private delegate void SafeCallDelegate(Customer customer);
        private delegate void DeleteCallDelegate2();
        private delegate void SafeCallDelegate2(Order order);
        private delegate void UpdateDelegate1();
        private delegate void ProgressDelegate1(int count);
        private static Thread customerPlaceOrder;
        private static Thread cook;
        private static Thread customerTakeOrder;
        string compare1 = @"[0-9]+";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(customerTextBox.ToString(),compare1) && Regex.IsMatch(orderTextBox.ToString(), compare1))
            {
                customerPlaceOrder = new Thread(new ParameterizedThreadStart(clientPlaceOrder.placeOrder));
                cook = new Thread(new ParameterizedThreadStart(CookService.takeAndPlaceOrder));
                customerTakeOrder = new Thread(clientPickUpOrder.takeOrder);
                customerPlaceOrder.Start(customerTextBox.Text);
                cook.Start(orderTextBox.Text);
                customerTakeOrder.Start();
            }
            else {
                MessageBox.Show("Invalid input data", "Error");
            }
            
        }

        private void customerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            customerPlaceOrder.Abort();
            cook.Abort();
            customerTakeOrder.Abort();
        }

        public void update(Customer customer) {
            updateSafely(customer);
        }

        public void updateSafely(Customer customer) {
            if (listView1.InvokeRequired)
            {
                var d = new SafeCallDelegate(updateSafely);
                listView1.Invoke(d, new object[] { customer });
            }
            else
            {
                try
                {
                    int str = customer.getOrderNum();
                    String str2 = customer.getName();
                    string[] raw = { str.ToString(),str2};
                    ListViewItem lvi = new ListViewItem(raw);
                    listView1.Items.Add(lvi);
                }
                catch (NullReferenceException ex) { }
            }
        }

        public void delete() {
            deleteSafely();
        }

        public void deleteSafely() { 
            if (listView1.InvokeRequired)
            {
                var d = new DeleteCallDelegate(deleteSafely);
                listView1.Invoke(d);
            }
            else
            {
                try
                {
                    listView1.Items.RemoveAt(0);
                }
                catch (Exception ex) { }
            }
        }

        public void update2(Order order)
        {
            updateSafely2(order);
        }

        public void updateSafely2(Order order)
        {
            if (listView2.InvokeRequired)
            {
                var d = new SafeCallDelegate2(updateSafely2);
                listView2.Invoke(d, new object[] { order });
            }
            else
            {
                try
                {
                    int str = order.getOrderNum();
                    String str2 = order.getCustomerName();
                    string[] raw = { str.ToString(), str2 };
                    ListViewItem lvi = new ListViewItem(raw);
                    listView2.Items.Add(lvi);
                }
                catch (NullReferenceException ex) { }
            }
        }

        public void delete2()
        {
            deleteSafely2();
        }

        public void deleteSafely2()
        {
            if (listView2.InvokeRequired)
            {
                var d = new DeleteCallDelegate2(deleteSafely2);
                listView2.Invoke(d);
            }
            else
            {
                try
                {
                    listView2.Items.RemoveAt(0);
                }
                catch (Exception ex) { }
            }
        }

        public void queueUpdate1() {
            safeQueueUpdate1();
        }
        public void safeQueueUpdate1()
        {
            if (customerNumTextBox.InvokeRequired)
            {
                var d = new UpdateDelegate1(safeQueueUpdate1);
                customerNumTextBox.Invoke(d);
            }
            else
            {
                try
                {
                   customerNumTextBox.Text = listView1.Items.Count.ToString();
                }
                catch (NullReferenceException ex) { }
            }
        }

        public void progressQueue(int count)
        {
            safeProgrressQueue(count);
        }
        public void safeProgrressQueue(int count)
        {
            if (inProgressTextBox.InvokeRequired)
            {
                var d = new ProgressDelegate1(safeProgrressQueue);
                inProgressTextBox.Invoke(d, new object[] { count });
            }
            else
            {
                try
                {
                    inProgressTextBox.Text = count.ToString();
                }
                catch (NullReferenceException ex) { }
            }
        }
    }
}
