using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNet.Template.CSharp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
			var config = ManualConfig
				.Create(DefaultConfig.Instance);
				
            var summary = BenchmarkRunner.Run<Benchmarks>(config);
        }
    }
	
	/// <summary>
	/// The benchmarks to run
	/// </summary>
	public class Benchmarks
	{
		[Benchmark(Baseline = true)]
		public void A()
		{
			throw new NotImplementedException("Replace this with the code to benchmark");
		}
		
		[Benchmark]
		public void B()
		{
			throw new NotImplementedException("Replace this with the code to benchmark");
		}
	}
}
