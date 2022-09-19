﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace テストDB.共通UI
{
    public partial class DgvPager : DataGridView
    {

        // -------------------------------------------------------
        // 公開プロパティ
        // -------------------------------------------------------

        // こちらに全ページ分のDataSourceをセット
        public List<Object> fullDataSource;
        public void SetFullDatasource<T>(List<T> list)
        {
            fullDataSource = list.Cast<Object>().ToList();
        }

        // -------------------------------------------------------
        // コンストラクタ
        // -------------------------------------------------------
        public DgvPager()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        // -------------------------------------------------------
        // ページを表示
        // -------------------------------------------------------
        public void ShowPage<T>(int CurrentCount, int RowsInPage)
        {
            if (fullDataSource == null) return;

            var castedlist = fullDataSource.Cast<T>().ToList();
    
            var list = castedlist
                .Skip(CurrentCount - 1)
                .Take(RowsInPage)
                .ToArray()
                ;

            this.DataSource = list;
        }

    }
}
