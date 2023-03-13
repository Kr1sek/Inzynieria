using Bogus;
using System;
using Testy.Models;
using Xunit;



namespace Testy
{
    public class UnitTest1
    {
        [Fact] // dla pojedyñczego faktu
        //[Theory] // dla grupy faktów
        //[InlineData()] // wywolanie metody w nawiasach podajemy wartos poczatkowa i oczekujaca
        public void Test1()
        {
            Faker<PersonCar> personCarBogus = new Faker<PersonCar>();
            personCarBogus.RuleFor(x => x.Model, y => y.Person.UserName);
            personCarBogus.RuleFor(typeof(int?)x => x.co);


            Faker<UserAddress> addressBogus = new Faker<UserAddress>();
            addressBogus.RuleFor(x => x.Description, y => y.Address.FullAddress());
            addressBogus.RuleFor(x => x.Number, y => y.Address.CountryCode());

            var personBogus = new Faker<Models.Person>();
            personBogus.RuleFor(x => x.Name, y => y.Person.FirstName);
            personBogus.RuleFor(x => x.Surname, y => y.Person.LastName);
            personBogus.RuleFor(x => x.Birthday, y => y.Person.DateOfBirth);
            personBogus.RuleFor(x => x.Address, y => addressBogus.Generate());

            var hundredPpl = personBogus.Generate(100);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(11,22,33)]
        [InlineData(100,200,300)]
        public void calc_test_add(float a, float b, float result) 
        {
            Calculator calc = new Calculator();
            var added = calc.add(a, b);
            Assert.Equal(result, added);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(11, 22, -11)]
        [InlineData(100, 200, -100)]
        public void calc_test_sub(float a, float b, float result)
        {
            Calculator calc = new Calculator();
            var added = calc.sub(a, b);
            Assert.Equal(result, added);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(11, 22, 242)]
        [InlineData(100, 200, 20000)]
        public void calc_test_multi(float a, float b, float result)
        {
            Calculator calc = new Calculator();
            var added = calc.multi(a, b);
            Assert.Equal(result, added);
        }


//        [Fact]
//        public void calc_test_div()
//        {
//#pragma warning disable xUnit2015 // Do not use typeof expression to check the exception type
//            Assert.Throws(typeof(Exception),
//                () =>
//                {
//                    Calculator calc = new Calculator();
//                    var added = calc.div(2,0);
//                });
//#pragma warning restore xUnit2015 // Do not use typeof expression to check the exception type


//        }
    }
}
