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
I don't know why she swallowed a cow - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!";
            var animals = new List<string>() { "cow", "horse" };
            var sut = new SongGenerator(animals);

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(expected);
        }

        [Fact]
        public void GenerateSong_ShouldReturnTheHorseAndCowAndDog_WhenAnimalAreHorseAndCowAndDog()
        {
            // Arrange
            var expected = @"There was an old lady who swallowed a dog;
I don't know why she swallowed a dog - perhaps she'll die!

There was an old lady who swallowed a cow;
I don't know how she swallowed a cow!
She swallowed the cow to catch the dog,
I don't know why she swallowed a dog - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!";
            var animals = new List<string>() { "dog", "cow", "horse" };
            var sut = new SongGenerator(animals);

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(expected);
        }

        [Fact]
        public void GenerateSong_ShouldReturnTheHorseAndCowAndDogAndCat_WhenAnimalAreHorseAndCowAndDogAndCat()
        {
            // Arrange
            var expected = @"There was an old lady who swallowed a cat;
I don't know why she swallowed a cat - perhaps she'll die!

There was an old lady who swallowed a dog;
What a hog, to swallow a dog!
She swallowed the dog to catch the cat,
I don't know why she swallowed a cat - perhaps she'll die!

There was an old lady who swallowed a cow;
I don't know how she swallowed a cow!
She swallowed the cow to catch the dog,
She swallowed the dog to catch the cat,
I don't know why she swallowed a cat - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!";
            var animals = new List<string>() { "cat", "dog", "cow", "horse" };
            var sut = new SongGenerator(animals);

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(expected);
        }

        [Fact]
        public void GenerateSong_ShouldReturnTheHorseAndCowAndDogAndCat_WhenAnimalAreHorseAndCowAndDogAndCatAndBird()
        {
            // Arrange
            var expected = @"There was an old lady who swallowed a bird;
I don't know why she swallowed a bird - perhaps she'll die!

There was an old lady who swallowed a cat;
Fancy that to swallow a cat!
She swallowed the cat to catch the bird,
I don't know why she swallowed a bird - perhaps she'll die!

There was an old lady who swallowed a dog;
What a hog, to swallow a dog!
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
I don't know why she swallowed a bird - perhaps she'll die!

There was an old lady who swallowed a cow;
I don't know how she swallowed a cow!
She swallowed the cow to catch the dog,
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
I don't know why she swallowed a bird - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!";
            var animals = new List<string>() { "bird", "cat", "dog", "cow", "horse" };
            var sut = new SongGenerator(animals);

            // Act
            var song = sut.GenerateSong();

            // Assert
            song.Should().Be(expected);
        }
    }
}
