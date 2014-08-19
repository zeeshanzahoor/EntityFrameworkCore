// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Metadata.Internal
{
    public class InternalForeignKeyBuilder : InternalMetadataItemBuilder<ForeignKey>
    {
        public InternalForeignKeyBuilder([NotNull] ForeignKey foreignKey, [NotNull] InternalModelBuilder modelBuilder)
            : base(foreignKey, modelBuilder)
        {
        }

        public virtual void IsUnique(bool isUnique)
        {
            Metadata.IsUnique = isUnique;
        }
    }
}
