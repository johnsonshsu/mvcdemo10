using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo10.Models
{
    public class z_sqlCodeBases : DapperSql<CodeDatas>
    {
        public z_sqlCodeBases()
        {
            OrderByColumn = SessionService.SortColumn;
            OrderByDirection = SessionService.SortDirection;
            DefaultOrderByColumn = "CodeBases.BaseNo";
            DefaultOrderByDirection = "ASC";
            DropDownValueColumn = "CodeBases.BaseNo";
            DropDownTextColumn = "CodeBases.BaseName";
            DropDownOrderColumn = "CodeBases.BaseNo ASC";
            if (string.IsNullOrEmpty(OrderByColumn)) OrderByColumn = DefaultOrderByColumn;
            if (string.IsNullOrEmpty(OrderByDirection)) OrderByDirection = DefaultOrderByDirection;
        }
    }
}