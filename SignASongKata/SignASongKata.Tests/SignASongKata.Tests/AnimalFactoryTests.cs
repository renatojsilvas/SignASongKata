using FluentAssertions;
using SignASongKata.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SignASongKata.Tests
{
    public class AnimalFactoryTests
    {
        [Fact]
        public void CreateAnimal_ShouldCreateAHorse_WhenArgumentIsHorse()
        {
            // Arrange & Act
            var sut = AnimalFactory.CreateAnimal("horse");

            // Assert
            sut.Should().BeAssignableTo<Animal>();
            sut.Size.Should().Be(7);
        }

        [Fact]
        public void CreateAnimal_ShouldCreateACow_WhenArgumentIsCow()
        {
            // Arrange & Act
            var sut = AnimalFactory.CreateAnimal("cow");

            // Assert
            sut.Should().BeAssignableTo<Animal>();
            sut.Size.Should().Be(6);
        }

        [Fact]
        public void CreateAnimal_ShouldCreateADog_WhenArgumentIsDog()
        {
            // Arrange & Act
            var sut = AnimalFactory.CreateAnimal("dog");

            // Assert
            sut.Should().BeAssignableTo<Animal>();
            sut.Size.Should().Be(5);
        }

        [Fact]
        public void CreateAnimal_ShouldCreateACat_WhenArgumentIsCat()
        {
            // Arrange & Act
            var sut = AnimalFactory.CreateAnimal("cat");

            // Assert
            sut.Should().BeAssignableTo<Animal>();
            sut.Size.Should().Be(4);
        }

        [Fact]
        public void CreateAnimal_ShouldCreateABird_WhenArgumentIsBird()
        {
            // Arrange & Act
            var sut = AnimalFactory.CreateAnimal("bird");

            // Assert
            sut.Should().BeAssignableTo<Animal>();
            sut.Size.Should().Be(3);
        }

        [Fact]
        public void CreateAnimal_ShouldCreateASpider_WhenArgumentIsSpider()
        {
            // Arrange & Act
            var sut = AnimalFactory.CreateAnimal("spider");

            // Assert
            sut.Should().BeAssignableTo<Animal>();
            sut.Size.Should().Be(2);
        }

        [Fact]
        public void CreateAnimal_ShouldCreateAFly_WhenArgumentIsFly()
        {
            // Arrange & Act
            var sut = AnimalFactory.CreateAnimal("fly");

            // Assert
            sut.Should().BeAssignableTo<Animal>();
            sut.Size.Should().Be(1);
        }

        [Fact]
        public void ParseList_ShouldCreateAListOfAnimals_WhenListOfStringIsProvided()
        {
            // Arrange
            var animals = new List<string>() { "fly", "spider", "bird", "cat", "dog", "cow", "horse" };

            // Act
            var sut = AnimalFactory.ParseList(animals);

            // Assert
            sut.Should().BeEquivalentTo(new List<Animal>() { new Fly(), new Spider(), new Bird(), new Cat(), new Dog(), new Cow(), new Horse() });
        }

        [Fact]
        public void ParseList_ShouldCreateAListOfAnimals_WhenUnorderedListOfStringIsProvided()
        {
            // Arrange
            var animals = new List<string>() { "horse", "cow", "dog", "cat", "bird", "spider", "fly" };

            // Act
            var sut = AnimalFactory.ParseList(animals);

            // Assert
            sut.Should().BeEquivalentTo(new List<Animal>() { new Fly(), new Spider(), new Bird(), new Cat(), new Dog(), new Cow(), new Horse() });
        }
    }
}
