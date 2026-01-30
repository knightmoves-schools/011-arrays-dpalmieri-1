namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Contain_A_Class_Level_Array_Named_IceCreamFlavors_That_Contains_Chocolate_Vanilla_And_Twist(){
        var iceCreamShop = new IceCreamShop();
        var iceCreamFlavors = iceCreamShop.IceCreamFlavors;
        Assert.Equal(3, iceCreamFlavors.Length);
        Assert.Equal("chocolate", iceCreamFlavors[0]);
        Assert.Equal("vanilla", iceCreamFlavors[1]);
        Assert.Equal("twist", iceCreamFlavors[2]);
    }
}