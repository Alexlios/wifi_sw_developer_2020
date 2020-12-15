using Moq;
using NUnit.Framework;
using Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types.Tests
{
    [TestFixture]
    public class TypeTests
    {
        private IPlaylist _fixture;

        [SetUp]
        public void Innit()
        {
            _fixture = new Playlist.Playlist("playlistname", "authorname", new DateTime(2000,12,24));
        }

        [Test]
        public void GetName()
        {
            //arrange

            //act
            var name = _fixture.Name;

            //assert
            Assert.That(name, Is.EqualTo("playlistname"));
        }

        [Test]
        public void SetName()
        {
            //arrange

            //act
            _fixture.Name = "Moin";

            //assert
            Assert.That(_fixture.Name, Is.EqualTo("Moin"));
        }

        [Test]
        public void GetAuthor()
        {
            //arrange

            //act
            var author = _fixture.Author;

            //assert
            Assert.That(author, Is.EqualTo("authorname"));
        }

        [Test]
        public void SetAuthor()
        {
            //arrange

            //act
            _fixture.Author = "Moin";

            //assert
            Assert.That(_fixture.Author, Is.EqualTo("Moin"));
        }

        [Test]
        public void GetCreatedAt()
        {
            //arrange

            //act
            var createdAt = _fixture.CreatedAt;

            //assert
            Assert.That(createdAt, Is.EqualTo(new DateTime(2000, 12, 24)));
        }

        [Test]
        public void GetCount()
        {
            //arrange
            var mockedItem1 = new Mock<IPlaylistItem.IPlaylistItem>();
            var mockedItem2 = new Mock<IPlaylistItem.IPlaylistItem>();

            _fixture.Add(mockedItem1.Object);
            _fixture.Add(mockedItem2.Object);

            //act
            var count = _fixture.Count;

            //assert
            Assert.That(count, Is.EqualTo(2));
        }

        [Test]
        public void GetDuration()
        {
            //arrange
            var mockedItem1 = new Mock<IPlaylistItem.IPlaylistItem>();
            var mockedItem2 = new Mock<IPlaylistItem.IPlaylistItem>();

            _fixture.Add(mockedItem1.Object);
            _fixture.Add(mockedItem2.Object);

            mockedItem1.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(5));
            mockedItem2.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(66));

            //act
            var duration = _fixture.Duration;

            //assert
            Assert.That(duration, Is.EqualTo(TimeSpan.FromSeconds(71)));
        }

        [Test]
        public void GetDuration_WithNoItems()
        {
            //arrange

            //act
            var duration = _fixture.Duration;

            //assert
            Assert.That(duration, Is.EqualTo(TimeSpan.Zero));
        }

        [Test]
        public void Add()
        {
            //arrange
            var mockedItem1 = new Mock<IPlaylistItem.IPlaylistItem>();


            //act
            _fixture.Add(mockedItem1.Object);

            //assert
            Assert.That(_fixture.Items.First, Is.EqualTo(mockedItem1.Object));
        }

        [Test]
        public void Remove()
        {
            //arrange
            var mockedItem1 = new Mock<IPlaylistItem.IPlaylistItem>();
            _fixture.Add(mockedItem1.Object);


            //act
            _fixture.Remove(mockedItem1.Object);

            //assert
            Assert.That(_fixture.Items, Is.Empty);
        }

        [Test]
        public void Clear()
        {
            //arrange
            var mockedItem1 = new Mock<IPlaylistItem.IPlaylistItem>();
            var mockedItem2 = new Mock<IPlaylistItem.IPlaylistItem>();
            _fixture.Add(mockedItem1.Object);
            _fixture.Add(mockedItem2.Object);

            //act
            _fixture.Clear();

            //assert
            Assert.That(_fixture.Items, Is.Empty);
        }
    }
}
