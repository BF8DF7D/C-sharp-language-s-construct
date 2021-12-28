using System;

public class RefOutTest
{
	private int value = 5;

	public void UseRef(ref int number)
    {
		
    }

	public void UseOut(out int number)
    {
		number = value;
    }
	public RefOutTest()
	{
	}
}
