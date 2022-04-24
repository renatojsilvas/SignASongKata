using FluentAssertions;
using SignASongKata.Core;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace SignASongKata.Tests
{
    public class SongGeneratorTests
    {
        [Fact]
        public void GenerateSong_ShouldReturnTheStandardSong_WhenAnimalsAreFlySpiderBirdCatDogCow()
        {
            // Arrange
            var goldenFileContent = File.ReadAllText(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Data\golden-file.txt"));
            var animals = new List<string>() { "fly", "spider", "bird", "cat", "dog", "cow" };
            var sut = new SongGenerator(animals);            

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(goldenFileContent);
        }
    }
}
