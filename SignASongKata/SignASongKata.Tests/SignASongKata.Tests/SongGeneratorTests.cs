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
            var animals = new List<string>() { "fly", "spider", "bird", "cat", "dog", "cow", "horse" };
            var sut = new SongGenerator(animals);            

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(goldenFileContent);
        }

        [Fact]
        public void GenerateSong_ShouldReturnTheHorse_WhenAnimalIsJustAHorse()
        {
            // Arrange
            var expected = @"There was an old lady who swallowed a horse...
...She's dead, of course!";
            var animals = new List<string>() { "horse" };
            var sut = new SongGenerator(animals);

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(expected);
        }

        [Fact]
        public void GenerateSong_ShouldReturnTheHorseAndCow_WhenAnimalAreHorseAndCow()
        {
            // Arrange
            var expected = @"There was an old lady who swallowed a cow;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!";
            var animals = new List<string>() { "cow", "horse" };
            var sut = new SongGenerator(animals);

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(expected);
        }
    }
}
