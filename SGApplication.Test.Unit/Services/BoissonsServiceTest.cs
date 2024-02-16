using FluentAssertions;
using Microsoft.Data.Sqlite;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using SGApplication.Data.Boissons;
using SGApplication.Repository;
using SGApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGApplication.Test.Unit.Services
{
    public class BoissonsServiceTest
    {
        private readonly BoissonsService _sut;
        private readonly IBoissonsRepository _repository = Substitute.For<IBoissonsRepository>();
        public BoissonsServiceTest()
        {
            _sut = new BoissonsService(_repository);
        }

        #region Expresso
        [Fact]
        public void IsExpresso_ShouldReturnExpresso_WhenBoissonsExist()
        {
            //Arrange
            var boisson = new BoissonsModel()
            {
                Id = 1,
                Name = "café",
                Price = 1.2
            };
            var exceptedBoisson = new List<BoissonsModel>
            {
                boisson,
            };
            var commande = new BoissonsCommande()
            {
                commande = "Expresso"
            };

            _repository.GetAllBoisson().Returns(exceptedBoisson);

            //Act
            var result = _sut.IsExpresso(commande);

            //Assert
            result.Should().Be(new Double());
        }

        public void IsExpresso_ShouldReturnExceptions_WhenRequestException()
        {
            //Arrange
            var commande = new BoissonsCommande()
            {
                commande = "Expresso"
            };
            var sqliteException = new SqliteException("Une erreur est survenue", 500);

            _repository.GetAllBoisson().Throws(new SqliteException("Une erreur est survenue", 500));

            //Act
            var result = _sut.IsExpresso(commande);

            //Assert
        }
        #endregion


        #region Allonge
        [Fact]
        public void IsExpresso_ShouldReturnAllonge_WhenBoissonsExist()
        {
            //Arrange
            var boisson = new BoissonsModel()
            {
                Id = 1,
                Name = "café",
                Price = 1.2
            };
            var exceptedBoisson = new List<BoissonsModel>
            {
                boisson,
            };
            var commande = new BoissonsCommande()
            {
                commande = "Expresso"
            };

            _repository.GetAllBoisson().Returns(exceptedBoisson);

            //Act
            var result = _sut.IsAllonge(commande);

            //Assert
            result.Should().Be(new Double());
        }

        #endregion

        #region Capuccino
        [Fact]
        public void IsExpresso_ShouldReturnCapuccino_WhenBoissonsExist()
        {
            //Arrange
            var boisson = new BoissonsModel()
            {
                Id = 1,
                Name = "Capuccino",
                Price = 1.2
            };
            var exceptedBoisson = new List<BoissonsModel>
            {
                boisson,
            };
            var commande = new BoissonsCommande()
            {
                commande = "Capuccino"
            };

            _repository.GetAllBoisson().Returns(exceptedBoisson);

            //Act
            var result = _sut.IsCapuccino(commande);

            //Assert
            result.Should().Be(new Double());
        }

        #endregion

        #region Chocolat
        [Fact]
        public void IsExpresso_ShouldReturnChocolat_WhenBoissonsExist()
        {
            //Arrange
            var boisson = new BoissonsModel()
            {
                Id = 1,
                Name = "Chocolat",
                Price = new double()
            };
            var exceptedBoisson = new List<BoissonsModel>
            {
                boisson,
            };
            var commande = new BoissonsCommande()
            {
                commande = "Chocolat"
            };

            _repository.GetAllBoisson().Returns(exceptedBoisson);

            //Act
            var result = _sut.IsChocolat(commande);

            //Assert
            result.Should().Be(new Double());
        }

        #endregion

        #region The
        [Fact]
        public void IsExpresso_ShouldReturnThe_WhenBoissonsExist()
        {
            //Arrange
            var boisson = new BoissonsModel()
            {
                Id = 1,
                Name = "the",
                Price = 1.2
            };
            var exceptedBoisson = new List<BoissonsModel>
            {
                boisson,
            };
            var commande = new BoissonsCommande()
            {
                commande = "The"
            };

            _repository.GetAllBoisson().Returns(exceptedBoisson);

            //Act
            var result = _sut.IsThe(commande);

            //Assert
            result.Should().Be(new Double());
        }

        #endregion
    }
}
