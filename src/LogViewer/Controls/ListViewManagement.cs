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

        public void AddRow(string rowName, string firstColValue, params string[] additionalColValues)
        {
            var row = GenerateNewItem(rowName, firstColValue, additionalColValues);
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

        public void RefreshRows(string[] firstColValues)
        {
            LvwControl.BeginUpdate();
            DoRefreshRows(firstColValues);
            LvwControl.EndUpdate();
        }

        public void RefreshRows(DateTime[] firstColValues)
        {
            LvwControl.BeginUpdate();
            var values = new string[firstColValues.Length];
            for (int i = 0; i < firstColValues.Length; i++)
            {
                values[i] = firstColValues[i].ToString();
            }
            DoRefreshRows(values);
            LvwControl.EndUpdate();
        }

        private void DoRefreshRows(string[] firstColValues)
        {
            LvwControl.Items.Clear();
            var lvwItems = new List<ListViewItem>(firstColValues.Length);
            foreach (var value in firstColValues)
            {
                var valueString = value.ToString();
                lvwItems.Add(GenerateNewItem(valueString, valueString));
            }
            LvwControl.Items.AddRange(lvwItems.ToArray());
        }

        #region Helper Methods
        public static CustomListView GenerateCustomListView(Control parent, string[] columnNames, bool gridLines = false)
        {
            var lvw = new CustomListView
            {
                Parent = parent,
                Dock = DockStyle.Fill,
                View = View.Details,
                GridLines = gridLines,
                FullRowSelect = true,
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

        private static ListViewItem GenerateNewItem(string name, string firstColValue, params string[] additionalColValues)
        {
            var lvwItem = new ListViewItem { Name = name, Text = firstColValue };
            foreach (var value in additionalColValues)
            {
                lvwItem.SubItems.Add(new ListViewItem.ListViewSubItem(lvwItem, value));
            }
            return lvwItem;
        }
        #endregion

        #region Members
        private readonly ListView LvwControl;
        #endregion
    }
}
