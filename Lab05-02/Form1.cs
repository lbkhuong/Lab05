using Lab05_02.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<ReportOrder> reportOrders = new List<ReportOrder>();
            List<ReportOrder> listTemp = new List<ReportOrder>();
            List<ReportOrder> listReportOrder = AddDataToReportOrder(reportOrders);
            
            foreach (ReportOrder item in listReportOrder)
            {
                if (radioXemTheoNgay.Checked == true)
                {
                    if (item.ngayGiaoHang.Date == dtpTheoNgay.Value.Date)
                    {
                        listTemp.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                    }
                }
                else if (radioXemTheoThang.Checked == true)
                {
                    if (item.ngayGiaoHang.Month == dtpTheoThang.Value.Month && item.ngayGiaoHang.Year == dtpTheoThang.Value.Year)
                    {
                        listTemp.Add(item);
                        
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (radioXemTuNgay.Checked == true)
                {
                    if (dtpTuNgay1.Value <= item.ngayGiaoHang && item.ngayGiaoHang <= dtpTuNgay2.Value)
                    {
                        listTemp.Add(item);
                        
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            


            reportViewer1.LocalReport.ReportPath = "./Report/ReportOrder.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSetOrder", listTemp);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }

        private List<ReportOrder> AddDataToReportOrder(List<ReportOrder> reportOrders)
        {
            QLBanHangDB contextDB = new QLBanHangDB();
            List<Invoice> invoices = contextDB.Invoice.ToList();
            List<Order> orders = contextDB.Order.ToList();
            reportOrders = new List<ReportOrder>();
            double thanhTien;

            foreach (var item in invoices)
            {
                ReportOrder reportOrder = new ReportOrder();

                var tempThanhTien = from s in orders
                                    where s.InvoiceNo == item.InvoiceNo
                                    select s.Price * s.Quantity;

                thanhTien = Convert.ToDouble(tempThanhTien.Sum());

                reportOrder.sTT = reportOrders.Count + 1;
                reportOrder.ngayGiaoHang = item.DeliveryDate;
                reportOrder.soHoaDon = item.InvoiceNo;
                reportOrder.thanhTien = thanhTien;

                reportOrders.Add(reportOrder);
            }
            return reportOrders;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpTheoThang.CustomFormat = "MM/yyyy";
            dtpTheoNgay.Enabled = false;
            dtpTheoThang.Enabled = false;
            dtpTuNgay1.Enabled = false;
            dtpTuNgay2.Enabled = false;
            this.reportViewer1.RefreshReport();
        }
        private void radioXemTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioXemTheoNgay.Checked == true)
            {
                dtpTheoNgay.Enabled = true;
                dtpTheoThang.Enabled = false;
                dtpTuNgay1.Enabled = false;
                dtpTuNgay2.Enabled = false;
                radioXemTheoThang.Checked = false;
                radioXemTuNgay.Checked = false;
            }
            
        }
        private void radioXemTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radioXemTheoThang.Checked == true)
            {
                dtpTheoNgay.Enabled = false;
                dtpTheoThang.Enabled = true;
                dtpTuNgay1.Enabled = false;
                dtpTuNgay2.Enabled = false;
                radioXemTheoNgay.Checked = false;
                radioXemTuNgay.Checked = false;
            }
           
        }
        private void radioXemTuNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioXemTuNgay.Checked == true)
            {
                dtpTheoNgay.Enabled = false;
                dtpTheoThang.Enabled = false;
                dtpTuNgay1.Enabled = true;
                dtpTuNgay2.Enabled = true;
                radioXemTheoNgay.Checked = false;
                radioXemTheoThang.Checked = false;
            }
           
        }

        

        
    }
}
