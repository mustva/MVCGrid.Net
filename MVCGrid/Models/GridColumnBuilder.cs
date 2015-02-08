﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCGrid.Models
{
    public class GridColumnBuilder<T1>
    {
        public GridColumnBuilder()
        {
            GridColumn = new GridColumn<T1>();
        }

        public GridColumn<T1> GridColumn { get; set; }

        public GridColumnBuilder<T1> WithColumnName(string name)
        {
            GridColumn.ColumnName = name;
            return this;
        }

        public GridColumnBuilder<T1> WithHeaderText(string text)
        {
            GridColumn.HeaderText = text;
            return this;
        }

        public GridColumnBuilder<T1> WithSorting(bool enableSorting)
        {
            GridColumn.EnableSorting = enableSorting;
            return this;
        }

        public GridColumnBuilder<T1> WithValueExpression(Func<T1, ControllerContext, string> expression)
        {
            GridColumn.ValueExpression = expression;
            return this;
        }
    }
}
