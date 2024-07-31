using EgitimPortal.Application.Features.Products.Exceptions;
using EgitimPortal.Application.Features.Products.Rules;
using EgitimPortal.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class ProductRulesTests
{
    private readonly ProductRules _productRules;

    public ProductRulesTests()
    {
        _productRules = new ProductRules();
    }

    [Fact]
    public async Task ProductTitleMustNotBeSame_ShouldThrowException_WhenTitleExists()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product { title = "Existing Title" }
        };
        var requestTitle = "Existing Title";

        // Act & Assert
        await Assert.ThrowsAsync<ProductTitleMustNotBeSameException>(() => _productRules.ProductTitleMustNotBeSame(products, requestTitle));
    }

    [Fact]
    public async Task ProductTitleMustNotBeSame_ShouldNotThrowException_WhenTitleDoesNotExist()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product { title = "Existing Title" }
        };
        var requestTitle = "New Title";

        // Act
        var exception = await Record.ExceptionAsync(() => _productRules.ProductTitleMustNotBeSame(products, requestTitle));

        // Assert
        Assert.Null(exception);
    }
}