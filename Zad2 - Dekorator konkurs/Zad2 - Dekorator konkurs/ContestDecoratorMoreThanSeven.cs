﻿using System;
using System.Collections.Generic;

namespace Zad2___Dekorator_konkurs
{
	class ContestDecoratorMoreThanSeven : ContestDecorator
	{
		public override void Play()
		{
			DecoratedContest.Play();
			Reward();
		}

		private void Reward()
		{
			if (DecoratedContest.Numbers.Count > 7)
			{
				Console.WriteLine("You won 150!");
			}
		}

		public ContestDecoratorMoreThanSeven(IContest decoratedContest) : base(decoratedContest)
		{
	
		}
	}
}