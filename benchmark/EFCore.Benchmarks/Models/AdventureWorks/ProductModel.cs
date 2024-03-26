// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Microsoft.EntityFrameworkCore.Benchmarks.Models.AdventureWorks;

public class ProductModel
{
    public ProductModel()
    {
        Product = new HashSet<Product>();
        ProductModelIllustration = new HashSet<ProductModelIllustration>();
        ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCulture>();
    }

    public int ProductModelID { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string Name { get; set; }
#pragma warning disable IDE1006 // Naming Styles
    public Guid rowguid { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    public string CatalogDescription { get; set; }
    public string Instructions { get; set; }

    public virtual ICollection<Product> Product { get; set; }
    public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; }
    public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
}
