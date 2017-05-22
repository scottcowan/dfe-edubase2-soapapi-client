using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dfe.Edubase2.SoapApi.Client.EdubaseService;
using Moq;
using NUnit.Framework;

namespace Dfe.Edubase2.SoapApi.Client.Tests
{
    [TestFixture]
    public class EstablishmentClientTests
    {
        [Test]
        public void ShouldRequestMultiplePagesIfThePageCountIsGreaterThanOne()
        {
            // Arrange
            int pages = 2;
            var pageCallbacks = new List<int>();
            var mockClient = new Mock<IEdubaseClient>();
            var sut = new EstablishmentClient(mockClient.Object);
            mockClient.Setup(x => x.FindEstablishments(It.IsAny<EstablishmentFilter>(), out pages)).Returns(new EstablishmentList())
                .Callback<EstablishmentFilter, int>((x,y) => pageCallbacks.Add(x.Page));

            // Act
            sut.FindEstablishments().ToList();

            // Assert
            mockClient.Verify(x => x.FindEstablishments(It.IsAny<EstablishmentFilter>(), out pages), Times.Exactly(2));
            CollectionAssert.Contains(pageCallbacks, 0);
            CollectionAssert.Contains(pageCallbacks, 1);
        }

        [Test]
        public void ShouldIgnoreThePageIfItsExplicitlyStated()
        {
            // Arrange
            int pages = 2;
            var pageCallbacks = new List<int>();
            var mockClient = new Mock<IEdubaseClient>();
            var sut = new EstablishmentClient(mockClient.Object);
            mockClient.Setup(x => x.FindEstablishments(It.IsAny<EstablishmentFilter>(), out pages)).Returns(new EstablishmentList())
                .Callback<EstablishmentFilter, int>((x, y) => pageCallbacks.Add(x.Page));
            var filter = new EstablishmentFilter { Page = 1};

            // Act
            sut.FindEstablishments(filter).ToList();

            // Assert
            mockClient.Verify(x => x.FindEstablishments(It.IsAny<EstablishmentFilter>(), out pages), Times.Exactly(2));
            CollectionAssert.Contains(pageCallbacks, 0);
            CollectionAssert.Contains(pageCallbacks, 1);
        }


        [Test]
        public void ShouldRequestMultiplePagesAsyncIfThePageCountIsGreaterThanOne()
        {
            // Arrange
            var pageCallbacks = new List<int>();
            var mockClient = new Mock<IEdubaseClient>();
            var sut = new EstablishmentClient(mockClient.Object);
            mockClient.Setup(x => x.FindEstablishmentsAsync(It.IsAny<FindEstablishmentsRequest>())).Returns(GetReponse(2))
                .Callback<FindEstablishmentsRequest>(x => pageCallbacks.Add(x.Filter.Page));

            // Act
            var task = sut.FindEstablishmentsAsync();
            Task.WaitAll(task);

            // Assert
            mockClient.Verify(x => x.FindEstablishmentsAsync(It.IsAny<FindEstablishmentsRequest>()), Times.Exactly(2));
            CollectionAssert.Contains(pageCallbacks, 0);
            CollectionAssert.Contains(pageCallbacks, 1);
        }

        [Test]
        public void ShouldIgnoreThePageIfItsExplicitlyStatedAsync()
        {
            // Arrange
            var pageCallbacks = new List<int>();
            var mockClient = new Mock<IEdubaseClient>();
            var sut = new EstablishmentClient(mockClient.Object);
            mockClient.Setup(x => x.FindEstablishmentsAsync(It.IsAny<FindEstablishmentsRequest>())).Returns(GetReponse(2))
                .Callback<FindEstablishmentsRequest>(x => pageCallbacks.Add(x.Filter.Page));

            // Act
            var task = sut.FindEstablishmentsAsync(new EstablishmentFilter {Page = 1});
            Task.WaitAll(task);

            // Assert
            mockClient.Verify(x => x.FindEstablishmentsAsync(It.IsAny<FindEstablishmentsRequest>()), Times.Exactly(2));
            CollectionAssert.Contains(pageCallbacks, 0);
            CollectionAssert.Contains(pageCallbacks, 1);
        }

        private async Task<FindEstablishmentsResponse> GetReponse(int pageCount)
        {
            return new FindEstablishmentsResponse
            {
                Establishments = new EstablishmentList(),
                PageCount = pageCount
            };
        }
    } 
}
