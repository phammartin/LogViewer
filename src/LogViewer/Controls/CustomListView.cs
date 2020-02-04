using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LogViewer
{
    public class CustomListView : ListView
    {

        public CustomListView()
        {
            base.DoubleBuffered = true;
        }
    }
}