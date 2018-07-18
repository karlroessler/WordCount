using Autofac;
using Moq;
using System;
using System.IO.Abstractions;
using System.Linq;
using WordCount.Implementations;
using Xunit;

namespace WordCount.Test.ImplementationTests
{
    public class TextFileLoaderTests
    {
        private Mock<IFileSystem> _mockFileSystem;
        private TextFileLoader _systemUnderText;

        public TextFileLoaderTests()
        {
            _mockFileSystem = new Mock<IFileSystem>();

            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder
                .RegisterInstance(instance: _mockFileSystem.Object)
                .As<IFileSystem>();

            containerBuilder
                .RegisterType<TextFileLoader>();

            _systemUnderText = containerBuilder
                .Build()
                .Resolve<TextFileLoader>();
        }

        [Fact]
        public void TextFileLoaderTests_ReadAllText_Text_is_Bla_bla_Expect_Bla_bla()
        {
            _mockFileSystem
                .Setup(m => m.File.ReadAllText(It.IsAny<string>()))
                .Returns(() => { return "Bla bla"; });

            string actual = _systemUnderText.ReadAllText("datei");

            Assert.Equal("Bla bla", actual);
        }



        [Fact]
        public void TextFileLoaderTests_ReadAllText_file_not_exists_Expect_string_empty()
        {
            _mockFileSystem
                .Setup(m => m.File.Exists(It.IsAny<string>()))
                .Returns(false);

            _mockFileSystem
                .Setup(m => m.File.ReadAllText(It.IsAny<string>()))
                .Returns(() => { return "Bla bla"; });

            string actual = _systemUnderText.ReadAllText("datei");

            Assert.Equal(string.Empty, actual);
        }
    }
}
