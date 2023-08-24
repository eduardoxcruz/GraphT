using Model.ValueObjects;

namespace Model.Tests;

public class PriorityTests
{
    [Fact]
    public void FromValues_ReturnsPurposeful_WhenIsFunAndIsProductive()
    {
        Priority priority;
        bool isFun;
        bool isProductive;

        // Arrange
        isFun = true;
        isProductive = true;

        // Act
        priority = Priority.FromValues(isFun, isProductive);

        // Assert
        Assert.Equal(Priority.Purposeful, priority);
    }
}