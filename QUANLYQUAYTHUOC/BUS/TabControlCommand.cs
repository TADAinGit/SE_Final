using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BUS
{
    public class TabControlCommand : CommandBase
    {
        ChildTab tab;

        public TabControlCommand(ChildTab tab)
        {
            this.tab = tab;
        }

        public override void Execute()
        {
            tab.SetUpTab();
        }
    }

    public class ChildTab : Tab
    {
        XtraUserControl userControl;
        private string tabName;

        public ChildTab(XtraTabControl tabParent, XtraUserControl userControl, string tabName) : base(tabParent) 
        {
            this.userControl = userControl;
            this.tabName = tabName;
        }

        #region Getter - Setter
        public XtraUserControl UserControl 
        {
            get { return userControl; }
            set { this.userControl = value; }
        }

        public string TabName 
        {
            get { return tabName; }
            set { this.tabName = value; }
        }
        #endregion

        public void SetUpTab() 
        {
            bool isExist = false;
            foreach (XtraTabPage page in TabParent.TabPages)
            {
                if (page.Text == tabName)
                {
                    isExist = true;
                    TabParent.SelectedTabPage = page;
                }
            }
            if (isExist == false)
            {
                XtraTabPage pageControl = new XtraTabPage();
                pageControl.PageVisible = true;
                pageControl.Text = tabName;
                pageControl.Controls.Add(userControl);
                TabParent.TabPages.Add(pageControl);
                TabParent.SelectedTabPage = pageControl;
            }
        }

        public override Tab Clone()
        {
            return (Tab) this.MemberwiseClone();
        }
    }

    public abstract class Tab
    {
        private XtraTabControl tabParent;

        public Tab(XtraTabControl tabParent)
        {
            this.tabParent = tabParent;
        }

        public Tab()
        {}

        #region Getter - Setter
        public XtraTabControl TabParent
        {
            get { return this.tabParent; }
            set { tabParent = value; }
        }
        #endregion

        #region Prototype
        public abstract Tab Clone();
        #endregion
    }
}
