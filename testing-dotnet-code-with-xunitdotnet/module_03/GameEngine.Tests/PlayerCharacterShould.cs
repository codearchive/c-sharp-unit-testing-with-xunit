using System;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void CalculateFullName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Pavel";
            sut.LastName = "Patrusov";

            Assert.Equal("Pavel Patrusov", sut.FullName);
            Assert.StartsWith("Pavel", sut.FirstName);
        }

        [Fact]
        public void HaveFullNameStartsWithFirstName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Pavel";
            sut.LastName = "Patrusov";

            Assert.StartsWith("Pavel", sut.FirstName);
        }

        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Pavel";
            sut.LastName = "Patrusov";

            Assert.StartsWith("Patrusov", sut.LastName);
        }

        [Fact]
        public void CalculateFullName_IgnoreCaseAssertExample()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "PAVEL";
            sut.LastName = "PATRUSOV";

            Assert.Equal("Pavel Patrusov", sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullName_SubstringAssertExample()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Pavel";
            sut.LastName = "Patrusov";

            Assert.Contains("el Pa", sut.FullName);
        }

        [Fact]
        public void CalculateFullNameWithTitleCase()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Pavel";
            sut.LastName = "Patrusov";

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);
        }
    }
}
