﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;

namespace Microsoft.Data.Entity.Sqlite.Metadata
{
    public class SqliteKeyExtensions : ReadOnlySqliteKeyExtensions
    {
        public SqliteKeyExtensions([NotNull] Key key)
            : base(key)
        {
        }

        public virtual new string Name
        {
            get { return base.Name; }
            [param: CanBeNull]
            set { Key[SqliteNameAnnotation] = value; }
        }

        protected virtual new Key Key => (Key)base.Key;
    }
}
