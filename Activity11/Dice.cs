public class Dice
{
	//variables
	private int sides;                      
	private int value;
	//randome class call
	Random rnd = new Random();
	

	//defult consturcor
	public Dice()
	{                           	
		sides = 6;
		value = 1;
	}
	//Overloaded constructor
	public Dice(int numSides)
	{               
		sides = numSides;
		value = 1;
	}
	//getters and setters below
	public int getSides()
	{                   
		return sides;
	}
	public void setSides(int sides)
	{       
		this.sides = sides;
	}
	public int getValue()
	{
		return value;
	}
	public void setValue(int value)
	{
		this.value = value;
	}
	//Method to roll the dice
	public void roll()
	{
		value = (int)rnd.Next(7) * sides + 1;   
	}
	public String toString()
	{
		return "(" + value + ")";               
	}

}


