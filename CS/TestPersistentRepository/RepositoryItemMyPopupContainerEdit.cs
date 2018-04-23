using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.Collections;




namespace DevExpress.MyControl
{
    public class RepositoryItemMyPopupContainerEdit : RepositoryItemPopupContainerEdit
    {
        private Hashtable cacheSize;

        internal const string EDITORTypeName = "MyPopupContainerEdit";
        public override string EditorTypeName
        {
            get
            {
                return EDITORTypeName;
            }
        }



        [Browsable(false)]
        public new MyPopupContainerEdit OwnerEdit
        {
            get
            {
                return base.OwnerEdit as MyPopupContainerEdit;
            }
        }


        public Hashtable CacheSize
        {
            get 
            {
                return cacheSize;
            }
        }




        static RepositoryItemMyPopupContainerEdit()
        {
            RegisterMyPopupContainerEdit();
        }



        public RepositoryItemMyPopupContainerEdit()
            : base()
        {
            cacheSize = null;
            cacheSize = new Hashtable();            
        }


        public static void RegisterMyPopupContainerEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EDITORTypeName,
                                                       typeof(MyPopupContainerEdit), typeof(RepositoryItemMyPopupContainerEdit),
                                                       typeof(PopupContainerEditViewInfo), new ButtonEditPainter(), true, null));
        }



        public override void Assign(RepositoryItem item)
        {
            RepositoryItemMyPopupContainerEdit source = item as RepositoryItemMyPopupContainerEdit;
            BeginUpdate();
            try
            {
                base.Assign(item);
                this.cacheSize = source.CacheSize;
            }
            finally
            {
                EndUpdate();
            }
        }
    }
}
