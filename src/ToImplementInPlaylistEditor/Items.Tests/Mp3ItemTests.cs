using IPlaylistItem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.Tests
{
    [TestFixture]
    public class ItemTests
    {
        private IPlaylistItem.IPlaylistItem _fixture;

        [SetUp]
        public void TestInit()
        {
            _fixture = new Mp3Item(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");
        }

        #region Title

        #region GetTitle

        [Test]
        public void GetTitle()
        {
            //arrange

            //act
            var title = _fixture.Title;

            //assert
            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("Grenade"));

        }

        [Test]
        public void GetTitle_FilePathIsNull()
        {
            //arrange
            _fixture = new Mp3Item(null);

            //act
            var title = _fixture.Title;

            //assert
            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("--[File not found]--"));

        }

        [Test]
        public void GetTitle_FilePathIsEmpty()
        {
            //arrange
            _fixture = new Mp3Item("");

            //act
            var title = _fixture.Title;

            //assert
            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("--[File not found]--"));

        }

        [Test]
        public void GetTitle_FilePathNotExists()
        {
            //arrange
            _fixture = new Mp3Item(@"C:\Gibtsnicht\unbekannt.mp3");

            //act
            var title = _fixture.Title;

            //assert
            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("--[File not found]--"));

        }

        #endregion

        #region SetTitle

        #endregion

        #endregion

        #region Artist

        #region GetArtist

        [Test]
        public void GetArtist()
        {
            //arrange

            //act
            var artist = _fixture.Artist;

            //assert
            Assert.That(artist, Is.Not.Null);
            Assert.That(artist, Is.EqualTo("Bruno Mars"));

        }

        #endregion

        #region SetArtist

        #endregion

        #endregion

        #region Duration

        #region GetDuration

        [Test]
        public void GetDuration()
        {
            //arrange

            //act
            var duration = _fixture.Duration;

            //assert
            Assert.That(duration, Is.EqualTo(TimeSpan.FromSeconds(222.688)));

        }

        #endregion

        #region SetDuration

        #endregion

        #endregion

        #region Path

        #region GetPath

        [Test]
        public void GetPath()
        {
            //arrange

            //act
            var path = _fixture.Path;

            //assert
            Assert.That(path, Is.Not.Null);
            Assert.That(path, Is.EqualTo(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3"));

        }

        #endregion

        #region SetPath

        #endregion

        #endregion

        #region Thumbnail

        #region GetThumbnail

        [Test]
        public void GetThumbnail()
        {
            //arrange

            //act
            var thumbnail = _fixture.Thumbnail;

            //assert
            Assert.That(thumbnail, Is.Not.Null);
            //Assert.That(thumbnail, Is.EqualTo("Bruno Mars"));

        }

        [Test]
        public void GetThumbnail_WithMp3WithNoImage()
        {
            //arrange
            _fixture = new Mp3Item(@"C:\Users\user\Music\TestMediaFiles\002 - Lena - Taken By A Stranger.mp3");

            //act
            var thumbnail = _fixture.Thumbnail;

            //assert
            Assert.That(thumbnail, Is.Null);
            //Assert.That(thumbnail, Is.EqualTo("Bruno Mars"));

        }

        #endregion

        #region SetThumbnail

        #endregion

        #endregion

    }
}
