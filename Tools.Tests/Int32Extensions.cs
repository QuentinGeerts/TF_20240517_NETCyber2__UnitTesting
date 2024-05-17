namespace Tools.Tests;

public class Int32Extensions
{
    [Fact]
    public void IsPrime_ShouldReturnTrue_WhenValueIsPrime()
    {
        // Arrange (mettre en place le contexte)
        int x = 13;
        
        // Act (exécution de la méthode)
        bool result = x.IsPrime();

        // Assert (Vérifier le résultat obtenu par rapport au résultat attendu)
        Assert.True(result);
    }

    [Fact]
    public void IsPrime_ShouldReturnFalse_WhenValueIsNotPrime()
    {
        // Arrange
        int x = 14;
        
        // Act
        bool result = x.IsPrime();
        
        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1, "La valeur 1 ne peut pas être inférieure à 2 !")]
    [InlineData(0, "La valeur 0 ne peut pas être inférieure à 2 !")]
    [InlineData(-1, "La valeur -1 ne peut pas être inférieure à 2 !")]
    public void IsPrime_ShouldThrowsInvalidOperationException_WhenValueLessThanTwo(int value, string errorMessage)
    {
        // Arrange
        int x = value;
        
        // Act
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => x.IsPrime());

        // Assert
        Assert.Equal(errorMessage, ex.Message);
    }
}