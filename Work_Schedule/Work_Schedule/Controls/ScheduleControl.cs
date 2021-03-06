﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Schedule
{
    public partial class ScheduleControl : UserControl
    {

        
        public ScheduleControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get datagridview data in a 2d array
            var array = new object[UpSchedule.RowCount, UpSchedule.ColumnCount];
            foreach (DataGridViewRow i in UpSchedule.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    array[j.RowIndex, j.ColumnIndex] = j.Value;
                }
            }
            var array_down = new object[DownSchedule.RowCount, DownSchedule.ColumnCount];
            foreach (DataGridViewRow i in DownSchedule.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    array_down[j.RowIndex, j.ColumnIndex] = j.Value;
                }
            }
            //
            //merge two array
            //
            var array_merge = new object[24,33];

            for (int i = 0; i < 12; i++)        //left and up is upschedule,left and down is empty
            {
                for (int j = 0; j < 17; j++)
                {
                    if (array[i,j] != null)
                        array_merge[i, j] = array[i, j];
                }
            }
            for (int i = 12; i < 24; i++)       //name column should be merged with downschedule name
            {
                int CountSame = 0;
                for (int j = 0; j < 12; j++)
                {
                    if (array_down[i - 12, 0] != null && array_merge[j, 0] != null && array_down[i - 12, 0].ToString() == array_merge[j, 0].ToString())
                    {
                        CountSame++;
                        array_merge[i, 0] = null;
                        for (int a = 17; a < 33; a++)
                        {
                            array_merge[j, a] = array_down[i - 12, a - 15];
                        }
                    }
                }                                                      
                if (CountSame == 0)
                {
                        array_merge[i, 0] = array_down[i-12 , 0];
                    for (int a = 17; a < 33; a++)
                    {
                        array_merge[i, a] = array_down[i - 12, a - 15];
                    }
                }
            }


            CheckRule checkrule = new CheckRule();
            //string str = "" + UpSchedule.Rows[0].Cells[0].Value;
            //MessageBox.Show("" + checkrule.daily8(str));
            MessageBox.Show(checkrule.TotalCheck(array_merge));
<<<<<<< HEAD
=======
        }

        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            //
            // Add rows initially
            //
            UpSchedule.Rows.Add(12);
            DownSchedule.Rows.Add(12);
            //
            //disable sort in every columns
            //
            foreach (DataGridViewColumn column in UpSchedule.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in DownSchedule.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //
            //Set ComboBox in Title
            //

>>>>>>> master
        }
    }
}
