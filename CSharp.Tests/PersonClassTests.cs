using System;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

using CSharpLib;
using static FSharpLib.Model;
using System.Collections.Generic;

namespace CSharp.Tests
{
    public class PersonTests
    {
        private readonly ITestOutputHelper output;

        public PersonTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void CSharpPersonClassTests()
        {
            // Arrange
            var person1 = new PersonClass("Name", new DateTime(2000, 1, 1));
            var person2 = new PersonClass("Name", new DateTime(2000, 1, 1));

            // Debug
            //output.WriteLine($"person1.GetHashCode(): {person1.GetHashCode()}");
            //output.WriteLine($"person2.GetHashCode(): {person2.GetHashCode()}");

            // Assert
            person1.Should().NotBeNull();
            person2.Should().NotBeNull();
            person1.Should().NotBeSameAs(person2);
            person1.Should().BeEquivalentTo(person2);

            person1.Name.Should().NotBeNullOrEmpty();
            person1.DateOfBirth.Should().HaveYear(2000);
            person1.Children.Should().NotBeNull();

            Assert.Equal(person1.GetHashCode(), person2.GetHashCode());
            Assert.Equal(person1, person2);
        }

        [Fact]
        public void CSharpPersonStructTests()
        {
            // Arrange
            var person1 = new PersonStruct("Name", new DateTime(2000, 1, 1));
            var person2 = new PersonStruct("Name", new DateTime(2000, 1, 1));

            // Debug
            //output.WriteLine($"person1.GetHashCode(): {person1.GetHashCode()}");
            //output.WriteLine($"person2.GetHashCode(): {person2.GetHashCode()}");

            // Assert
            person1.Should().NotBeNull();
            person2.Should().NotBeNull();
            person1.Should().NotBeSameAs(person2);
            person1.Should().BeEquivalentTo(person2);

            person1.Name.Should().NotBeNullOrEmpty();
            person1.DateOfBirth.Should().HaveYear(2000);
            person1.Children.Should().NotBeNull();

            Assert.Equal(person1.GetHashCode(), person2.GetHashCode());
            Assert.Equal(person1, person2);
        }


        [Fact]
        public void FSharpPersonTests()
        {
            var person1 = new Person("Name", new DateTime(2000, 1, 1), new List<Person>());
            var person2 = new Person("Name", new DateTime(2000, 1, 1), new List<Person>());

            // Debug
            //output.WriteLine($"person1.GetHashCode(): {person1.GetHashCode()}");
            //output.WriteLine($"person2.GetHashCode(): {person2.GetHashCode()}");

            // Assert
            person1.Should().NotBeNull();
            person2.Should().NotBeNull();
            person1.Should().NotBeSameAs(person2);
            person1.Should().BeEquivalentTo(person2);

            person1.Name.Should().NotBeNullOrEmpty();
            person1.DateOfBirth.Should().HaveYear(2000);
            person1.Children.Should().NotBeNull();

            Assert.Equal(person1.GetHashCode(), person2.GetHashCode());
            Assert.Equal(person1, person2);
        }

        [Fact]
        public void TestCar()
        {
            // Arrange
            var dimensions = Tuple.Create(1.0d, 2.0d);
            var car = new Car(3, "Fård", dimensions);


            // Assert
        }
    }
}
