using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;




namespace DevExpress.MyControl
{
    public class MyPopupContainerEdit : PopupContainerEdit
    {
        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemMyPopupContainerEdit.EDITORTypeName;
            }
        }



        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyPopupContainerEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemMyPopupContainerEdit;
            }
        }



        static MyPopupContainerEdit()
        {
            RepositoryItemMyPopupContainerEdit.RegisterMyPopupContainerEdit();
        }



        public MyPopupContainerEdit()
            : base()
        {

        }



        protected override PopupBaseForm CreatePopupForm()
        {
            if (Properties.PopupControl == null) return null;
            return new MyPopupContainerForm(this);
        }
    }
}
