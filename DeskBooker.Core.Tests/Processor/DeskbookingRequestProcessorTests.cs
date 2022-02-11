using DeskBooker.Core.Domain;
using System;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskbookingRequestProcessorTests
    {
        private readonly DeskBookingRequestProcessor _processor;

        public DeskbookingRequestProcessorTests()
        {
            _processor = new DeskBookingRequestProcessor();
        }
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
            

            //Act
            DeskBookingResult result= _processor.BookDesk(request);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

        }

        [Fact]
        public void ShouldThrowExecptionIfRequestIsNull()
        {
           

            var exception= Assert.Throws<ArgumentNullException>(()=>_processor.BookDesk(null));

            Assert.Equal("request", exception.ParamName);

        }
    }
}
