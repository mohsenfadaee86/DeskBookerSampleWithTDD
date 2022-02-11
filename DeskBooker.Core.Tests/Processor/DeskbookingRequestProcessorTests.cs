using DeskBooker.Core.Domain;
using System;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskbookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestVlaues()
        {

            //Arrange
            var request = new DeskbookingRequest
            {
                FirstName = "Mohsen",
                LastName = "Fadaee",
                Email = "Mohsen4us@gmail.com",
                Date = new DateTime(2022, 02, 11)
            };
            var processor = new DeskBookingRequestProcessor();

            //Act
            DeskBookingResult result= processor.BookDesk(request);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

        }
    }
}
