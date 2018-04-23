namespace TestPersistentRepository
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.ribbonContrl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridContrl = new DevExpress.XtraGrid.GridControl();
            this.gridV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.treeLst = new DevExpress.XtraTreeList.TreeList();
            this.vGridContrl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonContrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeLst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridContrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonContrl
            // 
            this.ribbonContrl.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonContrl.ExpandCollapseItem.Id = 0;
            this.ribbonContrl.ExpandCollapseItem.Name = "";
            this.ribbonContrl.ExternalRepository = this.persistentRepository1;
            this.ribbonContrl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonContrl.ExpandCollapseItem});
            this.ribbonContrl.Location = new System.Drawing.Point(0, 0);
            this.ribbonContrl.MaxItemId = 4;
            this.ribbonContrl.Name = "ribbonContrl";
            this.ribbonContrl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonContrl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemCalcEdit1});
            this.ribbonContrl.SelectedPage = this.ribbonPage1;
            this.ribbonContrl.Size = new System.Drawing.Size(918, 145);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // gridContrl
            // 
            this.gridContrl.ExternalRepository = this.persistentRepository1;
            this.gridContrl.Location = new System.Drawing.Point(12, 151);
            this.gridContrl.MainView = this.gridV;
            this.gridContrl.MenuManager = this.ribbonContrl;
            this.gridContrl.Name = "gridContrl";
            this.gridContrl.Size = new System.Drawing.Size(488, 200);
            this.gridContrl.TabIndex = 1;
            this.gridContrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridV});
            // 
            // gridV
            // 
            this.gridV.GridControl = this.gridContrl;
            this.gridV.Name = "gridV";
            // 
            // treeLst
            // 
            this.treeLst.ExternalRepository = this.persistentRepository1;
            this.treeLst.Location = new System.Drawing.Point(12, 368);
            this.treeLst.Name = "treeLst";
            this.treeLst.Size = new System.Drawing.Size(494, 231);
            this.treeLst.TabIndex = 2;
            this.treeLst.CustomNodeCellEditForEditing += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(this.treeLst_CustomNodeCellEditForEditing);
            // 
            // vGridContrl
            // 
            this.vGridContrl.ExternalRepository = this.persistentRepository1;
            this.vGridContrl.Location = new System.Drawing.Point(506, 151);
            this.vGridContrl.Name = "vGridContrl";
            this.vGridContrl.Size = new System.Drawing.Size(400, 200);
            this.vGridContrl.TabIndex = 3;
            this.vGridContrl.CustomRecordCellEditForEditing += new DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventHandler(this.vGridContrl_CustomRecordCellEditForEditing);
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Location = new System.Drawing.Point(512, 368);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(120, 100);
            this.popupContainerControl1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 611);
            this.Controls.Add(this.popupContainerControl1);
            this.Controls.Add(this.vGridContrl);
            this.Controls.Add(this.treeLst);
            this.Controls.Add(this.gridContrl);
            this.Controls.Add(this.ribbonContrl);
            this.Name = "FormMain";
            this.Text = "Main form";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonContrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeLst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridContrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonContrl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridContrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridV;
        private DevExpress.XtraTreeList.TreeList treeLst;
        private DevExpress.XtraVerticalGrid.VGridControl vGridContrl;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
    }
}

