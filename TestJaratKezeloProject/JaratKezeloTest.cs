using NUnit.Framework;
using JaratKezeloProject;
using System;

namespace TestJaratKezeloProject
{
	public class JaratKezeloTest
	{
		JaratKezelo kezelo;

		[SetUp]
		public void Setup()
		{
			kezelo = new JaratKezelo();
		}

		[Test]
		public void UjJaratDuplikaltJaratszam()
		{
			kezelo.UjJarat("viz-123","Budapest","Praga",new DateTime(2022,05,25,16,00,00));
			Assert.Throws<ArgumentException>(()=> {kezelo.UjJarat("viz-123", "Barcelona", "Velence", new DateTime(2022, 05, 26, 16, 00, 00)); });
	
		}

		public void UjJaratUres()
		{
			
		}
	}
}