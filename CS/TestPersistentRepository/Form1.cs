using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraBars;
using DevExpress.MyControl;



namespace TestPersistentRepository
{
    public partial class FormMain : Form
    {
        private DataTable dtList;
        private RepositoryItemMyPopupContainerEdit repositoryItemMyPCE;


        public FormMain()
        {
            InitializeComponent();
            InitTable();
            gridContrl.DataSource = dtList;
            treeLst.DataSource = dtList;
            vGridContrl.DataSource = dtList;
            repositoryItemMyPCE = new RepositoryItemMyPopupContainerEdit();
            repositoryItemMyPCE.PopupControl = popupContainerControl1;
            persistentRepository1.Items.Add(repositoryItemMyPCE);
            gridV.Columns["Info"].ColumnEdit = repositoryItemMyPCE;
            BarEditItem bi = new BarEditItem();
            bi.Edit = repositoryItemMyPCE;
            ribbonPageGroup1.ItemLinks.Add(bi);
        }



        private void InitTable()
        {
            dtList = new DataTable();

            dtList.Columns.AddRange(new DataColumn[] { new DataColumn("Name"), new DataColumn("Info") });
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                dtList.Rows.Add(new string[] { "Name_" + rnd.Next(1000, 10000).ToString(), "Info_" + rnd.Next(1000, 10000).ToString() });
            }
        }



        private void treeLst_CustomNodeCellEditForEditing(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
        {
            e.RepositoryItem = repositoryItemMyPCE;
        }

        private void vGridContrl_CustomRecordCellEditForEditing(object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventArgs e)
        {
            e.RepositoryItem = repositoryItemMyPCE;
        }
    }
}