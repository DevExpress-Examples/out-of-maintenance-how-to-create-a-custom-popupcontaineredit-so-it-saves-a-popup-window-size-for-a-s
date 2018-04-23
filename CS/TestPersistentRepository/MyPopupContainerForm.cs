using System;
using System.Collections.Generic;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors;
using System.Drawing;



namespace DevExpress.MyControl
{
    public class MyPopupContainerForm : PopupContainerForm
    {
        public MyPopupContainerForm(PopupContainerEdit ownerEdit)
            : base(ownerEdit)
        {
		}



        protected override Size CalcFormSizeCore()
        {
            Size size = base.CalcFormSizeCore();
            MyPopupContainerEdit editor = OwnerEdit as MyPopupContainerEdit;
            if (editor != null)
            {

                string s_type = editor.Parent.GetType().ToString();
                object size_obj = editor.Properties.CacheSize[s_type];
                if (size_obj != null) size = (Size)size_obj;
            }

            return size;
        }



        protected override void SetPropertyStore(Size size)
        {
            base.SetPropertyStore(size);

            RepositoryItemMyPopupContainerEdit ri = OwnerEdit.Properties as RepositoryItemMyPopupContainerEdit;
            
            if (ri.CacheSize != null)
            {
                string parent_type = OwnerEdit.Parent.GetType().ToString();
                if (!ri.CacheSize.ContainsKey(parent_type))
                {
                    ri.CacheSize.Add(parent_type, size);
                    return;
                }

                ri.CacheSize[parent_type] = size;
            }
        }
    }
}
