using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace CalculadoraPitagoras.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularA_CorrectValues_ReturnsNumber()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act
            var result = operacion.CalcularA(5, 7);


            //- Assert
            Assert.AreEqual(4.899, result);
        }

        [TestMethod]
        public void CalcularA_ValueLessZero_ReturnsException()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act - Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.CalcularA(5, -3));
        }

        [TestMethod]
        public void CalcularA_ValueCLessB_ReturnsException()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act - Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.CalcularA(5, 4));
        }

        [TestMethod]
        public void CalcularB_CorrectValues_ReturnsNumber()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act
            var result = operacion.CalcularB(10, 17);


            //- Assert
            Assert.AreEqual(13.748, result);
        }

        [TestMethod]
        public void CalcularB_ValueLessZero_ReturnsException()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act - Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.CalcularB(-9, 4));
        }

        [TestMethod]
        public void CalcularB_ValueALessB_ReturnsException()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act - Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.CalcularB(10, 5));
        }

        [TestMethod]
        public void CalcularC_CorrectValues_ReturnsNumber()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act
            var result = operacion.CalcularC(6, 9);


            //- Assert
            Assert.AreEqual(10.817, result);
        }

        [TestMethod]
        public void CalcularC_ValueLessZero_ReturnsException()
        {
            //Arrange
            var operacion = new ClassOp();

            //Act - Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.CalcularC(-1, 10));
        }


    }
}

