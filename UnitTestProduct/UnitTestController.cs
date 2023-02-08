using Moq;
using UnitTestMoq.Controllers;
using UnitTestMoq.Model;
using UnitTestMoq.Services;

namespace UnitTestProduct
{
    public class UnitTestController
    {
        private readonly Mock<IProductService> productService;

        public UnitTestController()
        {
            productService = new Mock<IProductService>();
        }

        [Theory]
        [InlineData("Iphone")]
        public void CheckProduct(string productName)
        {
            //Arrange
            var productList = GetProductData();
            productService.Setup(x => x.GetProductList())
                .Returns(productList);
            var productController = new ProductController(productService.Object);

            //Act
            var productResult = productController.ProductList();
            var expectedResult = productResult.ToList()[0].ProductName;

            //Assert

            Assert.Equal(productName, expectedResult);

        }

       [Fact]
        public void GetProductList_Test()
        {
            //arrange
            var productList = GetProductData();
            productService.Setup(x => x.GetProductList())
                .Returns(productList);
            var productController = new ProductController(productService.Object);

            //act
            var productResult = productController.ProductList();

            //assert
            Assert.NotNull(productResult);
            Assert.Equal(productList, productResult);


        }

        [Fact]
        public void GetProductById_Test()
        {
            //arrange
            var productList = GetProductData();
            productService.Setup(x => x.GetProductById(2))
                .Returns(productList[1]);
            var productController = new ProductController(productService.Object);

            //act
            var productResult = productController.GetProductById(2);

            //assert
            Assert.NotNull(productResult);
            Assert.Equal(productList[1].ProductId, productResult.ProductId);


        }

        [Fact]
        public void AddProduct_Test()
        {
            //arrange
            var productList = GetProductData();
            productService.Setup(x => x.AddProduct(productList[2]))
                .Returns(productList[2]);
            var productController = new ProductController(productService.Object);

            //act
            var productResult = productController.AddProduct(productList[2]);

            //assert
            Assert.NotNull(productResult);
            Assert.Equal(productList[2].ProductId, productResult.ProductId);

        }


        private List<Product> GetProductData()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                  ProductId=1,
                  ProductName="Iphone",
                  ProductDescription="IPhone 11 max pro",
                  ProductPrice = 120000,
                  ProductStock=10
                },
                new Product
                {
                  ProductId=2,
                  ProductName="Mac Book",
                  ProductDescription="Mac Book pro",
                  ProductPrice = 125000,
                  ProductStock=15
                },
                new Product
                {
                  ProductId=3,
                  ProductName="TV",
                  ProductDescription="Samsung",
                  ProductPrice = 50000,
                  ProductStock=30
                }

            };
            return products;
        }
    }
}