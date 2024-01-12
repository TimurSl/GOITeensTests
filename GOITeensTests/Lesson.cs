public enum Genders
{
    Male,
    Female,
    AttackHelicopter,
    Mechanic,
    WalmartBag,
    Croissant,
    Doomguy,
    Other,
}

public class Student
{
	public int AverageMark = 0;
	public Genders gender;

	public Student(int mark, Genders gender = Genders.Other)
	{
		AverageMark = mark;
		this.gender = gender;
	}
}

public static class MyClass
{
	public static int GetAmountOf<T>(this IEnumerable<T> collection, Predicate<T> criteria)
	{
		int amount = 0;
		foreach (T item in collection)
		{
			if (criteria(item))
			{
				amount++;
			}
		}
		return amount;
	}
}

