﻿using System;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Components.Extensibility.TableColumns
{
    public class TableColumnDictionary : Dictionary<string, List<TableColumn>>
    {
        public List<TableColumn> Get<T>()
        {
            return this.GetOrAdd(typeof(T).FullName, () => new List<TableColumn>());
        }
    }
}