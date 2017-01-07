﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SqlSugar
{
    public partial interface ISqlBuilder
    {
        SqlSugarClient Context { get; set; }
        CommandType CommandType { get; set; }
        String AppendWhereOrAnd(bool isWhere, string sqlString);
        SqlQueryBuilder SqlQueryBuilder { get; set; }
        LambadaQueryBuilder LambadaQueryBuilder { get; set; }
        InsertBuilder InsertBuilder { get; set; }
        DeleteBuilder DeleteBuilder { get; set; }
        UpdateBuilder UpdateBuilder { get; set; }

        string SqlParameterKeyWord { get; }
        string GetTranslationTableName(string name);
        string GetTranslationColumnName(string name);
    }
}