﻿// Copyright (c) 2014, The Outercurve Foundation. The software is licensed under the (the "License"); you may not use the software except in compliance with the License.
namespace Outercurve.SQLiteCreateTree.AlterTable.Action {
    public class DropIndexCommand : TableCommand {
        public string IndexName { get; set; }

        public DropIndexCommand(string tableName, string indexName)
            : base(tableName) {
            IndexName = indexName;
        }
    }
}
