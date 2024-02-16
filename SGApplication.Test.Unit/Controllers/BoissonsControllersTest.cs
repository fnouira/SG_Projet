using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using SGApplication.Controllers;
using SGApplication.Data.Boissons;
using SGApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGApplication.Test.Unit.Controllers
{
    public class BoissonsControllersTest
    {
        private readonly BoissonsController _sut;
        private readonly IBoissonsService _service = Substitute.For<IBoissonsService>();

        public BoissonsControllersTest()
        {
            _sut = new BoissonsController(_service);
        }

        #region Expresso
        [Fact]
        public void GetBoissonsByName_ShouldReturnExpresso_WhenBoissonsExist()
        {
            //Arrange
            var exceptedBoisson = new BoissonsCommande()
            {
                commande = "Expresso"
            };
            _service.IsExpresso(exceptedBoisson).Returns(new Double());
            //Act
            var result = (OkObjectResult)_sut.GetBoissonsByName(exceptedBoisson);

            //Assert
            result.StatusCode.Should().Be(200);
            result.Should().NotBeNull();
        }
        #endregion

        #region Allonge
        [Fact]
        public void GetBoissonsByName_ShouldReturnAllonge_WhenBoissonsExist()
        {
            //Arrange
            var exceptedBoisson = new BoissonsCommande()
            {
                commande = "Allonge"
            };
            _service.IsAllonge(exceptedBoisson).Returns(new Double());
            //Act
            var result = (OkObjectResult)_sut.GetBoissonsByName(exceptedBoisson);

            //Assert
            result.StatusCode.Should().Be(200);
        }
        #endregion

        #region Capuccino
        [Fact]
        public void GetBoissonsByName_ShouldReturnCapuccino_WhenBoissonsExist()
        {
            //Arrange
            var exceptedBoisson = new BoissonsCommande()
            {
                commande = "Capuccino"
            };
            _service.IsCapuccino(exceptedBoisson).Returns(new Double());
            //Act
            var result = (OkObjectResult)_sut.GetBoissonsByName(exceptedBoisson);

            //Assert
            result.StatusCode.Should().Be(200);
        }
        #endregion

        #region Chocolat
        [Fact]
        public void GetBoissonsByName_ShouldReturnChocolat_WhenBoissonsExist()
        {
            //Arrange
            var exceptedBoisson = new BoissonsCommande()
            {
                commande = "Chocolat"
            };
            _service.IsChocolat(exceptedBoisson).Returns(new Double());
            //Act
            var result = (OkObjectResult)_sut.GetBoissonsByName(exceptedBoisson);

            //Assert
            result.StatusCode.Should().Be(200);
        }
        #endregion

        #region The
        [Fact]
        public void GetBoissonsByName_ShouldReturnThe_WhenBoissonsExist()
        {
            //Arrange
            var exceptedBoisson = new BoissonsCommande()
            {
                commande = "The"
            };
            _service.IsThe(exceptedBoisson).Returns(new Double());
            //Act
            var result = (OkObjectResult)_sut.GetBoissonsByName(exceptedBoisson);

            //Assert
            result.StatusCode.Should().Be(200);
        }
        #endregion
    }
}
