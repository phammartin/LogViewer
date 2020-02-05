using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace LogViewer.Controls
{
    public class ListViewManagement
    {
        public ListViewManagement(ListView listViewControl)
        {
            LvwControl = listViewControl;
        }

        public void AddRow(string[] columnValues, string rowName = "")
        {
            var row = GenerateNewItem(columnValues, rowName);
            LvwControl.Items.Add(row);
        }

        public void UpdateRow(string rowName, string firstColValue, params string[] additionalColValues)
        {
            var row = LvwControl.Items[rowName];
            row.Text = firstColValue;
            for (int i = 1; i < additionalColValues.Length; i++)
            {
                var value = additionalColValues[i];
                row.SubItems[i].Text = value;
            }
        }

        public void RefreshRows(string[][] columnValues)
        {
            LvwControl.BeginUpdate();
            DoRefreshRows(columnValues);
            LvwControl.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            LvwControl.EndUpdate();
        }

        private void DoRefreshRows(string[][] rowData)
        {
            LvwControl.Items.Clear();
            var lvwItems = new List<ListViewItem>(rowData.Length);
            foreach (var columnValue in rowData)
            {
                lvwItems.Add(GenerateNewItem(columnValue));
            }
            LvwControl.Items.AddRange(lvwItems.ToArray());
        }

        #region Helper Methods
        public static CustomListView GenerateCustomListView(Control parent, string[] columnNames,
            bool gridLines = false, bool multiselect = false)
        {
            var lvw = new CustomListView
            {
                Parent = parent,
                Dock = DockStyle.Fill,
                View = View.Details,
                GridLines = gridLines,
                FullRowSelect = true,
                MultiSelect = multiselect
            };
            for (int i = 0; i < columnNames.Length; i++)
            {
                var key = i.ToString();
                var text = columnNames[i];
                lvw.Columns.Add(key, text);
            }
            lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            return lvw;
        }

        private static ListViewItem GenerateNewItem(string[] rowData, string name = "")
        {
            var lvwItem = new ListViewItem() { Text = rowData.First() };
            if (name != string.Empty)
            {
                lvwItem.Name = name;
            }
            if (rowData.Length > 1)
            {
                for (int i = 1; i < rowData.Length; i++)
                {
                    lvwItem.SubItems.Add(new ListViewItem.ListViewSubItem(lvwItem, rowData[i]));
                }
            }
            return lvwItem;
        }
        #endregion

        #region Members
        private readonly ListView LvwControl;
        #endregion
    }
}
