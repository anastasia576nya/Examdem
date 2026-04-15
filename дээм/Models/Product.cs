using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace дээм.Models;

public partial class Product : IEditableObject
{
    private Ispr2522SafiulinaAdPzLazarevContext context;

    public void BeginEdit()
    {
        if (context == null)
        {
            context = new Ispr2522SafiulinaAdPzLazarevContext();
        }
        context.Update(this);
    }

    public void CancelEdit()
    {
        if (context != null)
        {
            var entry = context.Entry(this);
            if (entry.State == EntityState.Modified)
            {
                entry.Reload();
            }
        }
    }

    public void EndEdit()
    {
        if (IdProductNameNavigation == null || string.IsNullOrEmpty(IdProductNameNavigation.ProductName1))
        {
            throw new ValidationException("Название товара не может быть пустым!");
        }

        if (Price < 0)
        {
            throw new ValidationException("Цена не может быть отрицательной!");
        }

        if (Discount < 0 || Discount > 100)
        {
            throw new ValidationException("Скидка должна быть от 0 до 100%!");
        }

        if (context != null)
        {
            context.SaveChanges();
        }
    }

    public int IdProduct { get; set; }

    public string Article { get; set; } = null!;

    public int IdProductName { get; set; }

    public string Unit { get; set; } = null!;

    public decimal Price { get; set; }

    public int IdSupplier { get; set; }

    public int IdManufacturer { get; set; }

    public int IdCategory { get; set; }

    public int Discount { get; set; }

    public int Count { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual ProductName IdProductNameNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual ICollection<OrdersProduct> OrdersProducts { get; set; } = new List<OrdersProduct>();
}

