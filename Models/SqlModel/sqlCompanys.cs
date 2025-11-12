using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo10.Models
{
    public class z_sqlCompanys : DapperSql<Companys>
    {
        public z_sqlCompanys()
        {
            OrderByColumn = SessionService.SortColumn;
            OrderByDirection = SessionService.SortDirection;
            DefaultOrderByColumn = "Companys.CompNo";
            DefaultOrderByDirection = "ASC";
            DropDownValueColumn = "Companys.CompNo";
            DropDownTextColumn = "Companys.CompName";
            DropDownOrderColumn = "Companys.CompNo ASC";
            if (string.IsNullOrEmpty(OrderByColumn)) OrderByColumn = DefaultOrderByColumn;
            if (string.IsNullOrEmpty(OrderByDirection)) OrderByDirection = DefaultOrderByDirection;
        }
    }
}