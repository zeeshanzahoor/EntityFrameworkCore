// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class DocumentDbPropertyAnnotations : IDocumentDbPropertyAnnotations
    {
        public DocumentDbPropertyAnnotations(IProperty property)
            : this(new DocumentDbAnnotations(property))
        {
        }

        protected DocumentDbPropertyAnnotations(DocumentDbAnnotations annotations)
        {
            Annotations = annotations;
        }

        protected virtual DocumentDbAnnotations Annotations { get; }
        protected virtual IProperty Property => (IProperty)Annotations.Metadata;
    }
}