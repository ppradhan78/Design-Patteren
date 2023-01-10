using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern.Generics
{
    
	public abstract class GenericsSingleton<T>
	{
		protected GenericsSingleton() { }

		private static T instance;
		private static Func<T> act;
		private static readonly object padlock = new object();

		protected static void initializer(Func<T> action) 
		{ 
			act = action;
		}
		protected static T Instance
		{
			get
			{
				lock (padlock)
				{
					if (GenericsSingleton<T>.instance == null) { instance = act(); }
					return GenericsSingleton<T>.instance;
				}
			}
		}
	}
}
